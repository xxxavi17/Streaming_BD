using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            CarregarConteudos();
        }

        private void CarregarConteudos()
        {
            string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT c.id_conteudo, c.titulo, p.nome AS produtora, c.genero, c.average_rating
                    FROM Streaming_Conteudo c
                    INNER JOIN Streaming_Produtora p ON c.id_produtora = p.id_produtora
                ";
                using (var adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvConteudos.DataSource = dt;
                }
            }
            // Adicionar evento para formatar a coluna average_rating
            dgvConteudos.CellFormatting -= dgvConteudos_CellFormatting;
            dgvConteudos.CellFormatting += dgvConteudos_CellFormatting;
        }

        private void dgvConteudos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvConteudos.Columns[e.ColumnIndex].Name == "average_rating" && e.Value != null && e.Value != DBNull.Value)
            {
                decimal val;
                if (decimal.TryParse(e.Value.ToString(), out val))
                {
                    e.Value = val.ToString("0.0") + " / 5.0";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnMenuInicial_Click(object sender, System.EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnRemoverConteudo_Click(object sender, EventArgs e)
        {
            if (dgvConteudos.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem a certeza que deseja remover o conteúdo selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idConteudo = Convert.ToInt32(dgvConteudos.SelectedRows[0].Cells["id_conteudo"].Value);
                    string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (var cmd = new Microsoft.Data.SqlClient.SqlCommand("SP_RemoverConteudo", conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_conteudo", idConteudo);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Conteúdo removido com sucesso!");
                    CarregarConteudos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um conteúdo para remover.");
            }
        }
    }
}
