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
            comboFiltroSexo.SelectedIndex = 0;
            CarregarAtores();
        }

        private void comboFiltroSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarAtores();
        }

        private void CarregarAtores()
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand("SP_ObterAtoresFiltrados", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                string sexo = comboFiltroSexo.SelectedItem?.ToString() ?? "Todos";
                if (sexo == "Todos")
                    cmd.Parameters.AddWithValue("@sexo", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@sexo", sexo);

                using var adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Adiciona coluna de conteúdos se não existir
                if (!dt.Columns.Contains("conteudos"))
                    dt.Columns.Add("conteudos", typeof(string));

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
            lblFiltroSexo.Location = new System.Drawing.Point(largura - 330, 30);
            comboFiltroSexo.Location = new System.Drawing.Point(largura - 180, 25);

            dgvAtores.Location = new System.Drawing.Point(30, 70);
            dgvAtores.Size = new System.Drawing.Size(largura - 60, altura - 150);

            int yBotao = altura - 60;
            btnMenuInicial.Location = new System.Drawing.Point(30, yBotao);
            btnEditarAtor.Location = new System.Drawing.Point(200, yBotao);
            btnRemoverAtor.Location = new System.Drawing.Point(370, yBotao);
        }
    }
}
