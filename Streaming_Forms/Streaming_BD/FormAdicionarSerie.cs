using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAdicionarSerie : Form
    {
        public FormAdicionarSerie()
        {
            InitializeComponent();
            this.Load += FormAdicionarSerie_Load;
        }

        private void FormAdicionarSerie_Load(object? sender, EventArgs e)
        {
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarSerie_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

            try
            {
                string titulo = txtTitulo.Text.Trim();
                string genero = txtGenero.Text.Trim();
                if (!int.TryParse(txtAno.Text, out int ano) || ano <= 0)
                {
                    MessageBox.Show("Ano inválido.");
                    return;
                }

                if (!int.TryParse(txtIdadeMinima.Text, out int idadeMinima) || idadeMinima < 0)
                {
                    MessageBox.Show("Idade mínima inválida.");
                    return;
                }

                string nomeProdutora = string.IsNullOrWhiteSpace(txtProdutora.Text)
                    ? (cmbProdutora.SelectedItem?.ToString() ?? "")
                    : txtProdutora.Text;

                if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(nomeProdutora))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                int idSerie;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AdicionarSerie", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@genero", genero);
                        cmd.Parameters.AddWithValue("@ano", ano);
                        cmd.Parameters.AddWithValue("@idade_minima", idadeMinima);
                        cmd.Parameters.AddWithValue("@nome_produtora", nomeProdutora);

                        idSerie = Convert.ToInt32(cmd.ExecuteScalar()); // Retorna id_conteudo da série
                    }
                }

                DialogResult resposta = MessageBox.Show("Série adicionada com sucesso! Deseja adicionar temporadas agora?",
                                                        "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    FormAdicionarTemporada formTemp = new FormAdicionarTemporada(idSerie);
                    formTemp.ShowDialog();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar série: " + ex.Message);
            }
        }
    }
}
