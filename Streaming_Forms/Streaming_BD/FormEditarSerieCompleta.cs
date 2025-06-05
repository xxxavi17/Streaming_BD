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
        private string tituloSerie = "";
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
        private int? temporadaSelecionada = null;
        private Panel? painelSelecionado = null;

        public FormEditarSerieCompleta(int idConteudo)
        {
            InitializeComponent();
            this.idConteudo = idConteudo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Buscar o título da série
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT titulo FROM Streaming_Conteudo WHERE id_conteudo = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idConteudo);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        tituloSerie = result.ToString()!;
                }
            }

            lblTitulo.Text = $"Editar Série: {tituloSerie}";
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
                    CarregarTemporadas(); // Atualiza após adicionar episódio
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
                CarregarTemporadas(); // Atualiza após edição/remoção
            };

            // Tornar o painel clicável para selecionar
            panel.Click += (s, e) =>
            {
                temporadaSelecionada = idTemporada;
                painelSelecionado = panel;

                // Remover destaque de todos
                foreach (Control ctrl in flowLayoutPanelTemporadas.Controls)
                {
                    ctrl.BackColor = SystemColors.Control;
                }

                // Destacar o painel clicado
                panel.BackColor = Color.LightBlue;
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
        
        private void btnRemoverTemporada_Click(object sender, EventArgs e)
        {
            if (temporadaSelecionada == null)
            {
                MessageBox.Show("Selecione uma temporada clicando em um dos blocos.");
                return;
            }

            var confirm = MessageBox.Show("Tem certeza que deseja remover a temporada selecionada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SP_RemoverTemporada", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_temporada", temporadaSelecionada.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Temporada removida com sucesso!");
                temporadaSelecionada = null;
                painelSelecionado = null;
                CarregarTemporadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover temporada: " + ex.Message);
            }
        }

    }
}
