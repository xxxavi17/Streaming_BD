using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Streaming_BD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_cliente, nome, email, data_nascimento, sexo FROM Streaming_Cliente";
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
            }
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
