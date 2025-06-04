using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormEditarEpisodio : Form
    {
        private int idEpisodio;
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormEditarEpisodio(int idEpisodio, string titulo, int numero, int duracao)
        {
            InitializeComponent();
            this.idEpisodio = idEpisodio;
            txtTitulo.Text = titulo;
            numericNumero.Value = numero;
            numericDuracao.Value = duracao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            int numero = (int)numericNumero.Value;
            int duracao = (int)numericDuracao.Value;

            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("O título do episódio não pode estar vazio.");
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SP_EditarEpisodio", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_episodio", idEpisodio);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@numero_episodio", numero);
                    cmd.Parameters.AddWithValue("@duracao", duracao);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Episódio atualizado com sucesso.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
