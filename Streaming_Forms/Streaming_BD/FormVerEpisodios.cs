using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormVerEpisodios : Form
    {
        private int idTemporada;
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormVerEpisodios(int idTemporada)
        {
            InitializeComponent();
            this.idTemporada = idTemporada;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarEpisodios();
        }

        private void CarregarEpisodios()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(@"
                    SELECT id_episodio, titulo, numero_episodio, duracao
                    FROM Streaming_Episodio
                    WHERE id_temporada = @id
                    ORDER BY numero_episodio", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTemporada);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEpisodios.DataSource = dt;

                        if (dt.Columns.Contains("id_episodio"))
                            dgvEpisodios.Columns["id_episodio"].Visible = false;
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarEpisodio_Click(object sender, EventArgs e)
        {
            var form = new FormAdicionarEpisodio(idTemporada);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                CarregarEpisodios();
        }

        private void btnEditarEpisodio_Click(object sender, EventArgs e)
        {
            if (dgvEpisodios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um episódio para editar.");
                return;
            }

            int idEpisodio = Convert.ToInt32(dgvEpisodios.SelectedRows[0].Cells["id_episodio"].Value);
            string titulo = dgvEpisodios.SelectedRows[0].Cells["titulo"].Value.ToString() ?? "";
            int numero = Convert.ToInt32(dgvEpisodios.SelectedRows[0].Cells["numero_episodio"].Value);
            int duracao = Convert.ToInt32(dgvEpisodios.SelectedRows[0].Cells["duracao"].Value);

            var form = new FormEditarEpisodio(idEpisodio, titulo, numero, duracao);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                CarregarEpisodios();
        }

        private void btnRemoverEpisodio_Click(object sender, EventArgs e)
        {
            if (dgvEpisodios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um episódio para remover.");
                return;
            }

            var confirm = MessageBox.Show("Tem certeza que deseja remover o episódio selecionado?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            int idEpisodio = Convert.ToInt32(dgvEpisodios.SelectedRows[0].Cells["id_episodio"].Value);

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Streaming_Episodio WHERE id_episodio = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEpisodio);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Episódio removido com sucesso!");
            CarregarEpisodios();
        }
    }
}
