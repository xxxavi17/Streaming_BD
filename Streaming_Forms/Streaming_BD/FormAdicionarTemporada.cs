using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAdicionarTemporada : Form
    {
        public int IdSerie { get; private set; }

        public FormAdicionarTemporada(int idSerie)
        {
            InitializeComponent();
            this.IdSerie = idSerie;
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAdicionarTemporada_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroTemporada.Text, out int numeroTemporada) || numeroTemporada <= 0)
            {
                MessageBox.Show("Número da temporada inválido.");
                return;
            }

            if (!int.TryParse(txtAnoTemporada.Text, out int anoTemporada) || anoTemporada < 1900)
            {
                MessageBox.Show("Ano inválido.");
                return;
            }

            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            int idTemporada;

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SP_AdicionarTemporada", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_serie", IdSerie);
                        cmd.Parameters.AddWithValue("@numero_temporada", numeroTemporada);
                        cmd.Parameters.AddWithValue("@ano", anoTemporada);

                        idTemporada = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                MessageBox.Show("Temporada adicionada com sucesso!");

                // Atualização opcional: abrir FormAdicionarEpisodio já com o idTemporada
                DialogResult resposta = MessageBox.Show("Deseja adicionar episódios agora?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    var formEpisodio = new FormAdicionarEpisodio(idTemporada);
                    formEpisodio.ShowDialog();
                }

                // Pode-se limpar campos ou fechar o formulário
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar temporada: " + ex.Message);
            }
        }

        private void btnAdicionarEpisodio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicione a temporada primeiro para criar episódios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
