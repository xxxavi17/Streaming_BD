using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class Form5 : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public Form5()
        {
            InitializeComponent();        }
        // Handler único para comboFiltroProdutora_SelectedIndexChanged
        private void comboFiltroProdutora_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void CarregarProdutoras()
        {
            comboFiltroProdutora.Items.Clear();
            comboFiltroProdutora.Items.Add("Todos");
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT DISTINCT p.nome FROM Streaming_Produtora p INNER JOIN Streaming_Conteudo c ON p.id_produtora = c.id_produtora INNER JOIN Streaming_Filme f ON c.id_conteudo = f.id_conteudo ORDER BY p.nome", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboFiltroProdutora.Items.Add(reader.GetString(0));
                    }
                }
            }
            comboFiltroProdutora.SelectedIndex = 0;
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            CarregarGeneros();
            CarregarProdutoras();
            CarregarFilmes();
        }

        private void CarregarGeneros()
        {
            comboFiltroGenero.Items.Clear();
            comboFiltroGenero.Items.Add("Todos");
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT DISTINCT genero FROM Streaming_Conteudo c INNER JOIN Streaming_Filme f ON c.id_conteudo = f.id_conteudo ORDER BY genero", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboFiltroGenero.Items.Add(reader.GetString(0));
                    }
                }
            }
            comboFiltroGenero.SelectedIndex = 0;
        }

        private void comboFiltroGenero_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void CarregarFilmes()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string genero = comboFiltroGenero?.SelectedItem?.ToString() ?? "Todos";
                string produtora = comboFiltroProdutora?.SelectedItem?.ToString() ?? "Todos";
                string pesquisa = txtPesquisa?.Text ?? string.Empty;
                SqlCommand cmd;
                if (!string.IsNullOrWhiteSpace(pesquisa))
                {
                    cmd = new SqlCommand("SP_PesquisarFilmes", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                    cmd.Parameters.AddWithValue("@genero", (genero == "Todos" || string.IsNullOrWhiteSpace(genero)) ? (object)DBNull.Value : genero);
                    cmd.Parameters.AddWithValue("@produtora", (produtora == "Todos" || string.IsNullOrWhiteSpace(produtora)) ? (object)DBNull.Value : produtora);
                }
                else
                {
                    cmd = new SqlCommand("SP_FiltrarFilmesPorGeneroEProdutora", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@genero", (genero == "Todos" || string.IsNullOrWhiteSpace(genero)) ? (object)DBNull.Value : genero);
                    cmd.Parameters.AddWithValue("@produtora", (produtora == "Todos" || string.IsNullOrWhiteSpace(produtora)) ? (object)DBNull.Value : produtora);
                }
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvConteudos.DataSource = dt;
                    // Centralizar coluna do título
                    if (dt.Columns.Contains("titulo"))
                    {
                        dgvConteudos.Columns["titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvConteudos.Columns["titulo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            // Adicionar evento para formatar a coluna average_rating
            dgvConteudos.CellFormatting -= dgvConteudos_CellFormatting;
            dgvConteudos.CellFormatting += dgvConteudos_CellFormatting;
        }

        private void dgvConteudos_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
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

        private void btnAdicionarFilme_Click(object sender, EventArgs e)
        {
            var formAdicionar = new FormAdicionarFilme();
            var result = formAdicionar.ShowDialog();
            CarregarFilmes();
        }

        private void btnEditarFilme_Click(object sender, EventArgs e)
        {
            if (dgvConteudos.SelectedRows.Count > 0)
            {
                int idConteudo = Convert.ToInt32(dgvConteudos.SelectedRows[0].Cells["id_conteudo"].Value);
                string titulo = dgvConteudos.SelectedRows[0].Cells["titulo"].Value.ToString() ?? "";
                string genero = dgvConteudos.SelectedRows[0].Cells["genero"].Value.ToString() ?? "";
                string produtora = dgvConteudos.SelectedRows[0].Cells["produtora"].Value.ToString() ?? "";
                int duracao = Convert.ToInt32(dgvConteudos.SelectedRows[0].Cells["duracao"].Value);
                var formEditar = new FormEditarFilme(idConteudo, titulo, genero, produtora, duracao, connectionString);
                var result = formEditar.ShowDialog();
                if (formEditar.FilmeEditado)
                {
                    CarregarFilmes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um filme para editar.");
            }
        }

        private void btnRemoverFilme_Click(object sender, EventArgs e)
        {
            if (dgvConteudos.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem a certeza que deseja remover o filme selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idConteudo = Convert.ToInt32(dgvConteudos.SelectedRows[0].Cells["id_conteudo"].Value);
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand("SP_RemoverFilme", conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_conteudo", idConteudo);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Filme removido com sucesso!");
                    CarregarFilmes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um filme para remover.");
            }
        }

        // Removed duplicate Form5_Resize method to resolve compile error.
    }
}
