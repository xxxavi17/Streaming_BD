using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormFazerRating : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        private readonly int clienteId;
        private readonly string clienteNome;

        public FormFazerRating(int clienteId, string clienteNome)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            this.clienteNome = clienteNome;

            lblClienteValor.Text = clienteNome;
            CarregarConteudos();
        }

        private void CarregarConteudos()
        {
            comboConteudo.Items.Clear();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_conteudo, titulo FROM Streaming_Conteudo ORDER BY titulo";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboConteudo.Items.Add(new ComboboxItem { Text = reader.GetString(1), Value = reader.GetInt32(0) });
                    }
                }
            }
            comboConteudo.SelectedIndex = comboConteudo.Items.Count > 0 ? 0 : -1;
        }

        private void btnFazerRating_Click(object sender, EventArgs e)
        {
            if (comboConteudo.SelectedItem is not ComboboxItem conteudoItem)
            {
                MessageBox.Show("Selecione um conteúdo.");
                return;
            }

            int estrelas = (int)numRating.Value;
            if (estrelas < 1 || estrelas > 5)
            {
                MessageBox.Show("O rating deve ser um número inteiro entre 1 e 5.");
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SP_AdicionarRating", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", clienteId);
                    cmd.Parameters.AddWithValue("@id_conteudo", conteudoItem.Value);
                    cmd.Parameters.AddWithValue("@estrelas", estrelas);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rating adicionado com sucesso!");
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("De certeza que quer atualizar o seu rating ao conteúdo"))
                        {
                            var confirm = MessageBox.Show(ex.Message, "Confirmação de atualização de rating", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (confirm == DialogResult.Yes)
                            {
                                using (var cmdUpdate = new SqlCommand("UPDATE Streaming_Rating SET estrelas = @estrelas, data = GETDATE() WHERE id_cliente = @id_cliente AND id_conteudo = @id_conteudo", conn))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@id_cliente", clienteId);
                                    cmdUpdate.Parameters.AddWithValue("@id_conteudo", conteudoItem.Value);
                                    cmdUpdate.Parameters.AddWithValue("@estrelas", estrelas);
                                    cmdUpdate.ExecuteNonQuery();
                                }
                                MessageBox.Show("Rating atualizado com sucesso!");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao adicionar rating: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ComboboxItem
    {
        public string? Text { get; set; }
        public object? Value { get; set; }
        public override string ToString() => Text ?? string.Empty;
    }
}
