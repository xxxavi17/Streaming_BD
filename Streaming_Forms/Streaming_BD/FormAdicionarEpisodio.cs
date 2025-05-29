using System;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class FormAdicionarEpisodio : Form
    {
        public FormAdicionarEpisodio(int idTemporada)
        {
            InitializeComponent();
            this.IdTemporada = idTemporada;
        }
        public int IdTemporada { get; set; }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
