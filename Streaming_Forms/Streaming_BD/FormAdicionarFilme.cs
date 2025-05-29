using System;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class FormAdicionarFilme : Form
    {
        public FormAdicionarFilme()
        {
            InitializeComponent();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
