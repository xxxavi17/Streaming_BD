using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormEditarFilme : Form
    {
        private int idConteudo;
        private string connectionString;
        public bool FilmeEditado { get; private set; } = false;

        public FormEditarFilme(int idConteudo, string titulo, string genero, string produtora, int duracao, string connStr)
        {
            InitializeComponent();
            this.idConteudo = idConteudo;
            this.connectionString = connStr;
            txtTitulo.Text = titulo;
            txtGenero.Text = genero;
            txtProdutora.Text = produtora;
            numDuracao.Value = duracao > 0 ? duracao : 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string novoTitulo = txtTitulo.Text.Trim();
            string novoGenero = txtGenero.Text.Trim();
            string novaProdutora = txtProdutora.Text.Trim();
            int novaDuracao = (int)numDuracao.Value;
            if (string.IsNullOrWhiteSpace(novoTitulo) || string.IsNullOrWhiteSpace(novoGenero) || string.IsNullOrWhiteSpace(novaProdutora) || novaDuracao <= 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Atualiza Streaming_Conteudo
                using (var cmd = new SqlCommand("UPDATE Streaming_Conteudo SET titulo=@titulo, genero=@genero WHERE id_conteudo=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@titulo", novoTitulo);
                    cmd.Parameters.AddWithValue("@genero", novoGenero);
                    cmd.Parameters.AddWithValue("@id", idConteudo);
                    cmd.ExecuteNonQuery();
                }
                // Atualiza produtora
                int idProdutora;
                using (var cmd = new SqlCommand("SELECT id_produtora FROM Streaming_Produtora WHERE nome=@nome", conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novaProdutora);
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        using (var cmdInsert = new SqlCommand("INSERT INTO Streaming_Produtora (nome) VALUES (@nome); SELECT SCOPE_IDENTITY();", conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@nome", novaProdutora);
                            idProdutora = Convert.ToInt32(cmdInsert.ExecuteScalar());
                        }
                    }
                    else
                    {
                        idProdutora = Convert.ToInt32(result);
                    }
                }
                using (var cmd = new SqlCommand("UPDATE Streaming_Conteudo SET id_produtora=@id_produtora WHERE id_conteudo=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id_produtora", idProdutora);
                    cmd.Parameters.AddWithValue("@id", idConteudo);
                    cmd.ExecuteNonQuery();
                }
                // Atualiza duração
                using (var cmd = new SqlCommand("UPDATE Streaming_Filme SET duracao=@duracao WHERE id_conteudo=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@duracao", novaDuracao);
                    cmd.Parameters.AddWithValue("@id", idConteudo);
                    cmd.ExecuteNonQuery();
                }
            }
            FilmeEditado = true;
            MessageBox.Show("Filme editado com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
