using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormVisualizarVisualizacoes : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormVisualizarVisualizacoes()
        {
            InitializeComponent();
            CarregarVisualizacoes();
        }

        private void CarregarVisualizacoes()
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            var query = @"
                SELECT 
                    c.nome AS Cliente,
                    ct.titulo AS Conteudo,
                    ac.data AS DataVisualizacao
                FROM 
                    Streaming_Assiste_Conteudo ac
                JOIN Streaming_Cliente c ON c.id_cliente = ac.id_cliente
                JOIN Streaming_Conteudo ct ON ct.id_conteudo = ac.id_conteudo
                ORDER BY c.nome, ac.data DESC";

            using var cmd = new SqlCommand(query, conn);
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            dataGridViewVisualizacoes.DataSource = table;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
