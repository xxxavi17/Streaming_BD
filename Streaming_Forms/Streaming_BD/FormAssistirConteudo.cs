using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormAssistirConteudo : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public FormAssistirConteudo()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarConteudos();
        }

        private void CarregarClientes()
        {
            comboCliente.Items.Clear();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            var query = "SELECT id_cliente, nome FROM Streaming_Cliente ORDER BY nome";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboCliente.Items.Add(new AssistirComboboxItem
                {
                    Text = reader.GetString(1),
                    Value = reader.GetInt32(0)
                });
            }
            comboCliente.SelectedIndex = comboCliente.Items.Count > 0 ? 0 : -1;
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
            if (comboCliente.SelectedItem is not AssistirComboboxItem clienteItem || comboConteudo.SelectedItem is not AssistirComboboxItem conteudoItem)
            {
                MessageBox.Show("Selecione um cliente e um conteúdo.");
                return;
            }

            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var cmd = new SqlCommand("SP_RegistrarAssistencia", conn); // nome da sua SP
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente", clienteItem.Value);
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
