using System;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class FormAdicionarSerie : Form
    {
        public FormAdicionarSerie()
        {
            InitializeComponent();
        }

        private void btnAdicionarSerie_Click(object sender, EventArgs e)
        {
            // Lógica para inserir a série na base de dados e obter o idSerie gerado
            int idSerie = 1; // Substituir pela lógica real de inserção e obtenção do ID
            FormAdicionarTemporada formTemporada = new FormAdicionarTemporada(idSerie);
            formTemporada.ShowDialog();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
