using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormEditarTemporada : Form
    {
        private int idTemporada;
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormEditarTemporada(int idTemporada)
        {
            InitializeComponent();
            this.idTemporada = idTemporada;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT numero_temporada, ano FROM Streaming_Temporada WHERE id_temporada = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idTemporada);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            numericNumero.Value = reader.GetInt32(0);
                            numericAno.Value = reader.GetInt32(1);
                        }
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SP_EditarTemporada", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_temporada", idTemporada);
                    cmd.Parameters.AddWithValue("@numero_temporada", (int)numericNumero.Value);
                    cmd.Parameters.AddWithValue("@ano", (int)numericAno.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Temporada atualizada com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
