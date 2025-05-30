using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Botão: Menu Inicial
        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        // Botão: Adicionar Cliente
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            try
            {
                DateTime dataNascimento;
                if (!DateTime.TryParse(txtDataNascimento.Text, out dataNascimento))
                {
                    MessageBox.Show("Data de nascimento inválida! Use o formato AAAA-MM-DD ou DD/MM/AAAA.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSexo.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }
                if (cmbTipoSub.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o tipo de subscrição.");
                    return;
                }
                int duracaoMeses;
                if (!int.TryParse(txtDuracaoMeses.Text, out duracaoMeses) || duracaoMeses < 0)
                {
                    MessageBox.Show("Insira uma duração válida em meses (>= 0).");
                    return;
                }
                int idCliente;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Inserir cliente
                    string queryCliente = "INSERT INTO Streaming_Cliente (nome, email, data_nascimento, sexo) OUTPUT INSERTED.id_cliente VALUES (@nome, @email, @data_nascimento, @sexo)";
                    using (SqlCommand cmd = new SqlCommand(queryCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                        cmd.Parameters.AddWithValue("@sexo", txtSexo.Text);
                        idCliente = (int)cmd.ExecuteScalar();
                    }
                    // Só insere subscrição se duração > 0
                    if (duracaoMeses > 0)
                    {
                        DateTime dataInicio = DateTime.Now;
                        DateTime dataFim = dataInicio.AddMonths(duracaoMeses);
                        // Corrigido: só pode ser 'ativa' ou 'inativa'
                        string estado = dataFim >= DateTime.Today ? "ativa" : "inativa";
                        string querySub = "INSERT INTO Streaming_Subscricao (tipo_sub, estado, duracao_meses, id_cliente, data_inicio, data_fim) VALUES (@tipo_sub, @estado, @duracao_meses, @id_cliente, @data_inicio, @data_fim)";
                        using (SqlCommand cmd = new SqlCommand(querySub, conn))
                        {
                            cmd.Parameters.AddWithValue("@tipo_sub", cmbTipoSub.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@estado", estado);
                            cmd.Parameters.AddWithValue("@duracao_meses", duracaoMeses);
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.Parameters.AddWithValue("@data_inicio", dataInicio);
                            cmd.Parameters.AddWithValue("@data_fim", dataFim);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Cliente e subscrição adicionados com sucesso!");
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Já existe um utilizador com esse email."))
                {
                    MessageBox.Show("Já existe um utilizador com esse email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar cliente: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar cliente: " + ex.Message);
            }
        }

        // Botão: Ver Lista de Clientes
        private void btnVerListaClientes_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
