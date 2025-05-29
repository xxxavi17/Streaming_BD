using System.Data.SqlClient;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botão: Adicionar Cliente
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        // Botão: Ver Lista de Clientes
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        // Botão: Adicionar Conteúdo
        private void btnAdicionarConteudo_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        // Botão: Ver Lista de Conteúdos
        private void btnVerConteudos_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        // Botão: Editar Séries
        private void btnEditarSeries_Click(object sender, EventArgs e)
        {
            FormEditarSeries formEditarSeries = new FormEditarSeries();
            formEditarSeries.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
