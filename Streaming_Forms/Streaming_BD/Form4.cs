using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdicionarSerie_Click(object sender, EventArgs e)
        {
            FormAdicionarSerie formSerie = new FormAdicionarSerie();
            formSerie.ShowDialog();
        }

        private void btnAdicionarFilme_Click(object sender, EventArgs e)
        {
            FormAdicionarFilme formFilme = new FormAdicionarFilme();
            formFilme.ShowDialog();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
