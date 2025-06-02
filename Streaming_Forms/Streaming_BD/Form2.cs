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
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }
                if (cmbTipoSub.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o tipo de subscrição.");
                    return;
                }
                if (cmbSexo.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o género.");
                    return;
                }
                string sexo = cmbSexo.SelectedItem?.ToString() ?? string.Empty;
                string tipoSub = cmbTipoSub.SelectedItem?.ToString() ?? string.Empty;
                int duracaoMeses = 0;
                if (tipoSub != "Sem Subscrição")
                {
                    if (!int.TryParse(txtDuracaoMeses.Text, out duracaoMeses) || duracaoMeses <= 0)
                    {
                        MessageBox.Show("Indique uma duração válida (em meses) para a subscrição.");
                        return;
                    }
                }
                int idCliente;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Inserir cliente via stored procedure
                    using (SqlCommand cmd = new SqlCommand("SP_AdicionarCliente", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    if (tipoSub != "Sem Subscrição" && duracaoMeses > 0)
                    {
                        DateTime dataInicio = DateTime.Now;
                        DateTime dataFim = dataInicio.AddMonths(duracaoMeses);
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Streaming_Subscricao (tipo_sub, estado, duracao_meses, id_cliente, data_inicio, data_fim) VALUES (@tipo_sub, 'ativa', @duracao_meses, @id_cliente, @data_inicio, @data_fim)", conn))
                        {
                            cmd.Parameters.AddWithValue("@tipo_sub", tipoSub);
                            cmd.Parameters.AddWithValue("@duracao_meses", duracaoMeses);
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.Parameters.AddWithValue("@data_inicio", dataInicio);
                            cmd.Parameters.AddWithValue("@data_fim", dataFim);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (tipoSub == "Sem Subscrição")
                    {
                        // Insere subscrição inativa sem datas
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Streaming_Subscricao (tipo_sub, estado, duracao_meses, id_cliente) VALUES (@tipo_sub, 'inativa', 0, @id_cliente)", conn))
                        {
                            cmd.Parameters.AddWithValue("@tipo_sub", tipoSub);
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
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
