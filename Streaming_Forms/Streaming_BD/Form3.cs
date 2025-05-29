using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Botão: Menu Inicial
        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        // Botão: Remover Cliente
        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Código para remover cliente da base de dados
                MessageBox.Show("Cliente removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.");
            }
        }
    }
}
