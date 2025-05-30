using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAdicionarFilme : Form
    {
        public FormAdicionarFilme()
        {
            InitializeComponent();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAdicionarFilme_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            try
            {
                string titulo = txtTitulo.Text;
                string genero = txtGenero.Text;
                int ano = int.Parse(txtAno.Text);
                int duracao = int.Parse(txtDuracao.Text);
                int idadeMinima = int.Parse(txtIdadeMinima.Text);
                string nomeProdutora = txtProdutora.Text;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AdicionarFilme", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@genero", genero);
                        cmd.Parameters.AddWithValue("@ano", ano);
                        cmd.Parameters.AddWithValue("@duracao", duracao);
                        cmd.Parameters.AddWithValue("@idade_minima", idadeMinima);
                        cmd.Parameters.AddWithValue("@nome_produtora", nomeProdutora);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Filme adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar filme: " + ex.Message);
            }
        }
    }
}
