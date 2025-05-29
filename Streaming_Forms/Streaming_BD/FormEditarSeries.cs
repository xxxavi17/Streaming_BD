using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormEditarSeries : Form
    {
        public FormEditarSeries()
        {
            InitializeComponent();
        }

        private void FormEditarSeries_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            var seriesList = new List<SerieItem>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_conteudo, titulo FROM Streaming_Conteudo WHERE tipo = 'Serie'";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        seriesList.Add(new SerieItem { Id = reader.GetInt32(0), Titulo = reader.GetString(1) });
                    }
                }
            }
            comboSeries.DataSource = seriesList;
            comboSeries.DisplayMember = "Titulo";
            comboSeries.ValueMember = "Id";
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnAdicionarTemporada_Click(object sender, EventArgs e)
        {
            if (comboSeries.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma série.");
                return;
            }
            var selectedSerie = comboSeries.SelectedItem as SerieItem;
            if (selectedSerie == null)
            {
                MessageBox.Show("Erro ao obter série selecionada.");
                return;
            }
            int idSerie = selectedSerie.Id;
            int numeroTemporada;
            int anoTemporada;
            if (!int.TryParse(txtNumeroTemporada.Text, out numeroTemporada) || !int.TryParse(txtAnoTemporada.Text, out anoTemporada))
            {
                MessageBox.Show("Preencha corretamente os campos de número e ano da temporada.");
                return;
            }
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Streaming_Temporada (id_serie, numero_temporada, ano) VALUES (@id_serie, @numero_temporada, @ano)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_serie", idSerie);
                    cmd.Parameters.AddWithValue("@numero_temporada", numeroTemporada);
                    cmd.Parameters.AddWithValue("@ano", anoTemporada);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Temporada adicionada com sucesso!");
        }

        private class SerieItem
        {
            public int Id { get; set; }
            public string? Titulo { get; set; }
        }
    }
}
