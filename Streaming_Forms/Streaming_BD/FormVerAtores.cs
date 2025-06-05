using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormVerAtores : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormVerAtores()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarAtores();
        }

        private void CarregarAtores()
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                var query = @"
                    SELECT 
                        a.id_ator, a.nome, a.sexo, a.idade,
                        STUFF((
                            SELECT ', ' + c.titulo
                            FROM Streaming_Conteudo c
                            JOIN Streaming_Conteudo_Ator ac ON ac.id_conteudo = c.id_conteudo
                            WHERE ac.id_ator = a.id_ator
                            FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS conteudos
                    FROM Streaming_Ator a
                    ORDER BY a.nome";

                using var cmd = new SqlCommand(query, conn);
                using var adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAtores.DataSource = dt;
                dgvAtores.Columns["id_ator"].HeaderText = "ID";
                dgvAtores.Columns["nome"].HeaderText = "Nome";
                dgvAtores.Columns["sexo"].HeaderText = "Sexo";
                dgvAtores.Columns["idade"].HeaderText = "Idade";
                dgvAtores.Columns["conteudos"].HeaderText = "Conteúdos Associados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar atores: " + ex.Message);
            }
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void btnEditarAtor_Click(object sender, EventArgs e)
        {
            if (dgvAtores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um ator para editar.");
                return;
            }

            var row = dgvAtores.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id_ator"].Value);
            string nome = row.Cells["nome"].Value.ToString() ?? "";
            string sexo = row.Cells["sexo"].Value.ToString() ?? "";
            int idade = Convert.ToInt32(row.Cells["idade"].Value);

            var editarForm = new FormEditarAtor(id, nome, sexo, idade, connectionString);
            editarForm.ShowDialog();
            if (editarForm.AtorEditado)
                CarregarAtores();
        }

        private void btnRemoverAtor_Click(object sender, EventArgs e)
        {
            if (dgvAtores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um ator para remover.");
                return;
            }

            var result = MessageBox.Show("Deseja realmente remover o ator selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgvAtores.SelectedRows[0].Cells["id_ator"].Value);

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand("SP_RemoverAtor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ator", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ator removido com sucesso!");
                CarregarAtores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover ator: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormVerAtores_Resize(object sender, EventArgs e)
        {
            int largura = this.ClientSize.Width;
            int altura = this.ClientSize.Height;

            lblTitulo.Location = new System.Drawing.Point((largura - lblTitulo.Width) / 2, 20);

            dgvAtores.Location = new System.Drawing.Point(30, 70);
            dgvAtores.Size = new System.Drawing.Size(largura - 60, altura - 150);

            int yBotao = altura - 60;
            btnMenuInicial.Location = new System.Drawing.Point(30, yBotao);
            btnEditarAtor.Location = new System.Drawing.Point(200, yBotao);
            btnRemoverAtor.Location = new System.Drawing.Point(370, yBotao);
        }
    }
}
