using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormEditarSerieCompleta : Form
    {
        private int idConteudo;
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormEditarSerieCompleta(int idConteudo)
        {
            InitializeComponent();
            this.idConteudo = idConteudo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarTemporadas();
        }

        private void CarregarTemporadas()
        {
            flowLayoutPanelTemporadas.Controls.Clear();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(@"
                    SELECT id_temporada, numero_temporada, ano
                    FROM Streaming_Temporada
                    WHERE id_serie = @id_serie
                    ORDER BY numero_temporada
                ", conn))
                {
                    cmd.Parameters.AddWithValue("@id_serie", idConteudo);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idTemporada = reader.GetInt32(0);
                            int numero = reader.GetInt32(1);
                            int ano = reader.GetInt32(2);

                            flowLayoutPanelTemporadas.Controls.Add(CriarBlocoTemporada(idTemporada, numero, ano));
                        }
                    }
                }
            }
        }

        private Panel CriarBlocoTemporada(int idTemporada, int numero, int ano)
        {
            Panel panel = new Panel
            {
                Width = 950,
                Height = 80,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lbl = new Label
            {
                Text = $"Temporada {numero} - {ano}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            panel.Controls.Add(lbl);

            Button btnEditar = new Button
            {
                Text = "Editar",
                Location = new Point(300, 10),
                Width = 90
            };
            btnEditar.Click += (s, e) =>
            {
                var form = new FormEditarTemporada(idTemporada);
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                    CarregarTemporadas(); // Atualiza o painel após edição
            };
            panel.Controls.Add(btnEditar);

            Button btnAdicionarEpisodio = new Button
            {
                Text = "Adicionar Episódio",
                Location = new Point(400, 10),
                Width = 140
            };
            btnAdicionarEpisodio.Click += (s, e) =>
            {
                var form = new FormAdicionarEpisodio(idTemporada);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    CarregarTemporadas(); // Atualiza o painel após adicionar episódio
            };
            panel.Controls.Add(btnAdicionarEpisodio);

            Button btnVerEpisodios = new Button
            {
                Text = "Ver Episódios",
                Location = new Point(550, 10),
                Width = 120
            };
            btnVerEpisodios.Click += (s, e) =>
            {
                var form = new FormVerEpisodios(idTemporada);
                form.ShowDialog();
                CarregarTemporadas(); // Atualiza após edição/remoção de episódio
            };

            panel.Controls.Add(btnVerEpisodios);

            return panel;
        }

        private void btnAdicionarTemporada_Click(object sender, EventArgs e)
        {
            var form = new FormAdicionarTemporada(idConteudo);
            form.ShowDialog();
            CarregarTemporadas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
