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
                string query = @"
                    SELECT c.id_cliente, c.nome, c.email, c.data_nascimento, c.sexo,
                           ISNULL(s.tipo_sub, 'Sem Subscrição') AS [Tipo Subscrição],
                           CASE 
                               WHEN s.data_fim IS NULL THEN 'Inativo'
                               WHEN s.data_fim >= CAST(GETDATE() AS DATE) THEN 'Ativo'
                               ELSE 'Inativo'
                           END AS [Estado]
                    FROM Streaming_Cliente c
                    LEFT JOIN (
                        SELECT *, ROW_NUMBER() OVER (PARTITION BY id_cliente ORDER BY data_fim DESC) AS rn
                        FROM Streaming_Subscricao
                    ) s ON c.id_cliente = s.id_cliente AND s.rn = 1
                ";
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
                var result = MessageBox.Show("Tem a certeza que deseja remover o cliente selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_cliente"].Value);
                    string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Remove subscrições primeiro (se existirem)
                        string deleteSub = "DELETE FROM Streaming_Subscricao WHERE id_cliente = @id_cliente";
                        using (var cmd = new SqlCommand(deleteSub, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }
                        // Remove cliente
                        string deleteCliente = "DELETE FROM Streaming_Cliente WHERE id_cliente = @id_cliente";
                        using (var cmd = new SqlCommand(deleteCliente, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente removido com sucesso!");
                    CarregarClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.");
            }
        }
    }
}
