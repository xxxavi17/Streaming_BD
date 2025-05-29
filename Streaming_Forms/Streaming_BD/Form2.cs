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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Streaming_Cliente (nome, email, data_nascimento, sexo) VALUES (@nome, @email, @data_nascimento, @sexo)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                        cmd.Parameters.AddWithValue("@sexo", txtSexo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente adicionado com sucesso!");
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
