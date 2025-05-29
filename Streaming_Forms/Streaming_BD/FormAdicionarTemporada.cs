using System;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class FormAdicionarTemporada : Form
    {
        public FormAdicionarTemporada(int idSerie)
        {
            InitializeComponent();
            this.IdSerie = idSerie;
        }
        public int IdSerie { get; set; }

        private void btnAdicionarEpisodio_Click(object sender, EventArgs e)
        {
            // Lógica para obter o idTemporada após inserir a temporada
            int idTemporada = 1; // Substituir pela lógica real de inserção e obtenção do ID
            FormAdicionarEpisodio formEpisodio = new FormAdicionarEpisodio(idTemporada);
            formEpisodio.ShowDialog();
        }

        private void btnAdicionarTemporada_Click(object sender, EventArgs e)
        {
            // Lógica para inserir a temporada na base de dados e obter o idTemporada gerado
            // Exemplo: int idTemporada = ...
            MessageBox.Show("Temporada adicionada! Agora pode adicionar episódios.");
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
