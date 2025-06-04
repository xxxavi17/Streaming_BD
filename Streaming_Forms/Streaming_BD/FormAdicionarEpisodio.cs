using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAdicionarEpisodio : Form
    {
        public int IdTemporada { get; private set; }

        public FormAdicionarEpisodio(int idTemporada)
        {
            InitializeComponent();
            this.IdTemporada = idTemporada;
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAdicionarEpisodio_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloEpisodio.Text.Trim();
            bool numeroOK = int.TryParse(txtNumeroEpisodio.Text, out int numeroEpisodio);
            bool duracaoOK = int.TryParse(txtDuracao.Text, out int duracao);

            if (string.IsNullOrWhiteSpace(titulo) || !numeroOK || !duracaoOK || numeroEpisodio <= 0 || duracao <= 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SP_AdicionarEpisodio", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@numero_episodio", numeroEpisodio);
                        cmd.Parameters.AddWithValue("@duracao", duracao);
                        cmd.Parameters.AddWithValue("@id_temporada", IdTemporada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Episódio adicionado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar episódio: " + ex.Message);
            }
        }
    }
}
