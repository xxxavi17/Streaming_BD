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
            this.Load += FormAdicionarFilme_Load;
        }

        private void FormAdicionarFilme_Load(object? sender, EventArgs e)
        {
            // Carregar produtoras conhecidas no ComboBox
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT nome FROM Streaming_Produtora ORDER BY nome", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbProdutora.Items.Add(reader.GetString(0));
                    }
                }
            }
            cmbProdutora.SelectedIndex = -1;
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
                string nomeProdutora = string.IsNullOrWhiteSpace(txtProdutora.Text) ? (cmbProdutora.SelectedItem?.ToString() ?? "") : txtProdutora.Text;
                if (string.IsNullOrWhiteSpace(nomeProdutora))
                {
                    MessageBox.Show("Selecione ou escreva o nome da produtora.");
                    return;
                }
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar filme: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
