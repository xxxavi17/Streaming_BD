using System;
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

        // Botão: Ver Lista de Séries
        private void btnVerSeries_Click(object sender, EventArgs e)
        {
            FormVerSeries formVerSeries = new FormVerSeries();
            formVerSeries.Show();
            this.Hide();
        }

        // Botão: Adicionar Ator
        private void btnAdicionarAtor_Click(object sender, EventArgs e)
        {
            var formAtor = new FormAdicionarAtor();
            formAtor.ShowDialog();
        }

        // Botão: Ver Lista de Atores
        private void btnVerAtores_Click(object sender, EventArgs e)
        {
            var formVerAtores = new FormVerAtores();
            formVerAtores.Show();
            this.Hide();
        }

        // Botão: Fazer Rating
        private void btnFazerRating_Click(object sender, EventArgs e)
        {
            var formRating = new FormFazerRating();
            formRating.ShowDialog();
        }

        // Botão: Assistir Conteúdo
        private void btnAssistirConteudo_Click(object sender, EventArgs e)
        {
            var formAssistir = new FormAssistirConteudo();
            formAssistir.ShowDialog();
        }

        // Botão: Ver Visualizações (Clientes que assistiram Conteúdo)
        private void btnVerVisualizacoes_Click(object sender, EventArgs e)
        {
            var formVisualizacoes = new FormVisualizarVisualizacoes();
            formVisualizacoes.ShowDialog();
        }

        // Eventos não utilizados
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
    }
}
