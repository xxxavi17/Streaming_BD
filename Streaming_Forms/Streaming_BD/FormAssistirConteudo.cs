using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAssistirConteudo : Form
    {
        private readonly int clienteId;
        private readonly string clienteNome;
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormAssistirConteudo(int clienteId, string clienteNome)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            this.clienteNome = clienteNome;

            lblCliente.Text = $"Cliente: {clienteNome}";
            CarregarConteudos();
        }

        private void CarregarConteudos()
        {
            comboConteudo.Items.Clear();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            var query = "SELECT id_conteudo, titulo FROM Streaming_Conteudo ORDER BY titulo";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboConteudo.Items.Add(new AssistirComboboxItem
                {
                    Text = reader.GetString(1),
                    Value = reader.GetInt32(0)
                });
            }
            comboConteudo.SelectedIndex = comboConteudo.Items.Count > 0 ? 0 : -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (comboConteudo.SelectedItem is not AssistirComboboxItem conteudoItem)
            {
                MessageBox.Show("Selecione um conteúdo.");
                return;
            }

            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var cmd = new SqlCommand("SP_RegistrarAssistencia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente", clienteId);
            cmd.Parameters.AddWithValue("@id_conteudo", conteudoItem.Value);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assistência registrada com sucesso!");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao registrar assistência: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class AssistirComboboxItem
    {
        public string? Text { get; set; }
        public object? Value { get; set; }
        public override string ToString() => Text ?? string.Empty;
    }
}
