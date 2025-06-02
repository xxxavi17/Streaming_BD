using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class FormEditarCliente : Form
    {
        private int clienteId;
        private string connectionString;
        public bool ClienteEditado { get; private set; } = false;

        public FormEditarCliente(int id, string nome, string email, string subscricao, string estado, string connStr)
        {
            InitializeComponent();
            clienteId = id;
            connectionString = connStr;
            textBoxEmail.Text = email;
            labelTitulo.Text = $"Editar Cliente: {nome} (ID: {id})";
            // Espaçamento extra após o campo de email
            int offsetY = textBoxEmail.Location.Y + textBoxEmail.Height + 30;
            checkBoxPremium.Location = new System.Drawing.Point(checkBoxPremium.Location.X, offsetY);
            checkBoxStandart.Location = new System.Drawing.Point(checkBoxStandart.Location.X, offsetY + 30);
            checkBoxSemSub.Location = new System.Drawing.Point(checkBoxSemSub.Location.X, offsetY + 60);
            // Seleciona o checkbox correto
            if (subscricao == "Premium")
                checkBoxPremium.Checked = true;
            else if (subscricao == "Standart")
                checkBoxStandart.Checked = true;
            else
                checkBoxSemSub.Checked = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string novoEmail = textBoxEmail.Text.Trim();
            if (!novoEmail.Contains("@") || !novoEmail.Contains("."))
            {
                MessageBox.Show("O email deve conter '@' e '.' para ser válido.", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string novaSubscricao = checkBoxPremium.Checked ? "Premium" : (checkBoxStandart.Checked ? "Standart" : "Sem Subscrição");
            string novoEstado = novaSubscricao == "Sem Subscrição" ? "inativa" : "ativa";

            if (string.IsNullOrEmpty(novoEmail) || string.IsNullOrEmpty(novaSubscricao))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            // Se mudou para Premium ou Standart, abrir form para definir duração
            if (novaSubscricao != "Sem Subscrição")
            {
                using (var formDuracao = new FormDefinirDuracao())
                {
                    if (formDuracao.ShowDialog() == DialogResult.OK)
                    {
                        int novaDuracao = formDuracao.DuracaoMeses;
                        AtualizarClienteESubscricao(novoEmail, novaSubscricao, novoEstado, novaDuracao);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                AtualizarClienteESubscricao(novoEmail, novaSubscricao, novoEstado, 0);
            }
        }

        private void AtualizarClienteESubscricao(string novoEmail, string novaSubscricao, string novoEstado, int novaDuracao)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SP_EditarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", clienteId);
                cmd.Parameters.AddWithValue("@novo_email", novoEmail);
                cmd.Parameters.AddWithValue("@novo_tipo_sub", novaSubscricao);
                cmd.Parameters.AddWithValue("@novo_estado", novoEstado);
                cmd.Parameters.AddWithValue("@nova_duracao", novaDuracao);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    ClienteEditado = true;
                    MessageBox.Show("Cliente editado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao editar cliente.");
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Garante que só um checkbox pode estar selecionado
        private void CheckBoxSubscricao_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBoxPremium && checkBoxPremium.Checked)
            {
                checkBoxStandart.Checked = false;
                checkBoxSemSub.Checked = false;
            }
            else if (sender == checkBoxStandart && checkBoxStandart.Checked)
            {
                checkBoxPremium.Checked = false;
                checkBoxSemSub.Checked = false;
            }
            else if (sender == checkBoxSemSub && checkBoxSemSub.Checked)
            {
                checkBoxPremium.Checked = false;
                checkBoxStandart.Checked = false;
            }
        }
    }
}
