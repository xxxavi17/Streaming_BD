using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormVerSeries : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormVerSeries()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarSeriesTemporadas();
        }

        private void CarregarSeriesTemporadas()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SP_ListarSeriesTemporadasComEpisodios", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSeries.DataSource = dt;

                        if (dt.Columns.Contains("serie"))
                        {
                            dgvSeries.Columns["serie"].HeaderText = "Série";
                            dgvSeries.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvSeries.Columns["serie"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }

                        if (dt.Columns.Contains("id_temporada"))
                            dgvSeries.Columns["id_temporada"].Visible = false;

                        if (dt.Columns.Contains("id_serie"))
                            dgvSeries.Columns["id_serie"].Visible = false;
                    }
                }
            }
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnAdicionarSerie_Click(object sender, EventArgs e)
        {
            var form = new FormAdicionarSerie();
            var result = form.ShowDialog();
            CarregarSeriesTemporadas();
        }

        private void btnEditarTemporada_Click(object sender, EventArgs e)
        {
            if (dgvSeries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma série para editar.");
                return;
            }

            try
            {
                int idConteudo = Convert.ToInt32(dgvSeries.SelectedRows[0].Cells["id_serie"].Value);
                var form = new FormEditarSerieCompleta(idConteudo);
                form.ShowDialog();
                CarregarSeriesTemporadas();
            }
            catch
            {
                MessageBox.Show("Erro ao carregar série selecionada.");
            }
        }

        private void btnRemoverTemporada_Click(object sender, EventArgs e)
        {
            if (dgvSeries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma série para remover.");
                return;
            }

            var result = MessageBox.Show(
                "Tem a certeza que deseja remover a série selecionada (com todas as temporadas e episódios)?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                int idSerie = Convert.ToInt32(dgvSeries.SelectedRows[0].Cells["id_serie"].Value);

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SP_RemoverSerie", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_serie", idSerie);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Série removida com sucesso.");
                CarregarSeriesTemporadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover série: " + ex.Message);
            }
        }
    }
}
