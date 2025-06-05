using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAdicionarAtor : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormAdicionarAtor()
        {
            InitializeComponent();
            CarregarConteudos();
        }

        private void CarregarConteudos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id_conteudo, titulo FROM Streaming_Conteudo ORDER BY titulo", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clbConteudos.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["titulo"].ToString(),
                                    Value = reader["id_conteudo"]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar conteúdos: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string sexoTexto = cmbSexo.SelectedItem?.ToString() ?? "";
            int idade;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sexoTexto))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (!int.TryParse(txtIdade.Text, out idade) || idade <= 0)
            {
                MessageBox.Show("Insira uma idade válida.");
                return;
            }

            // Converter sexo para 'M', 'F' ou 'O'
            string sexo = sexoTexto.StartsWith("M") ? "M" :
                          sexoTexto.StartsWith("F") ? "F" : "O";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Inserir o ator
                    int idNovoAtor;
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Streaming_Ator (nome, sexo, idade) OUTPUT INSERTED.id_ator VALUES (@nome, @sexo, @idade)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@idade", idade);
                        idNovoAtor = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Associar o ator aos conteúdos selecionados
                    foreach (var item in clbConteudos.CheckedItems)
                    {
                        if (item is ComboBoxItem selected)
                        {
                            int idConteudo = (int)selected.Value;
                            using (SqlCommand cmdAssoc = new SqlCommand("INSERT INTO Streaming_Conteudo_Ator (id_conteudo, id_ator) VALUES (@id_conteudo, @id_ator)", conn))
                            {
                                cmdAssoc.Parameters.AddWithValue("@id_conteudo", idConteudo);
                                cmdAssoc.Parameters.AddWithValue("@id_ator", idNovoAtor);
                                cmdAssoc.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Ator adicionado com sucesso!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao adicionar ator: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString() => Text;
    }
}
