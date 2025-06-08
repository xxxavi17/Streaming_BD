using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace Streaming_BD
{
    public partial class FormLogin : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";

        public int ClienteId { get; private set; }
        public string ClienteNome { get; private set; } = string.Empty;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Obter id_cliente e nome
                    int idCliente = -1;
                    string nomeCliente = "";
                    using (var cmd = new SqlCommand("SELECT id_cliente, nome FROM Streaming_Cliente WHERE email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Email não encontrado.");
                                return;
                            }

                            idCliente = reader.GetInt32(0);
                            nomeCliente = reader.GetString(1);
                        }
                    }

                    // 2. Obter hash da password
                    string? storedHash = null;
                    using (var cmd = new SqlCommand("SELECT password_hash FROM Streaming_Cliente_Auth WHERE id_cliente = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idCliente);
                        var result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Este utilizador não tem password definida.");
                            return;
                        }
                        storedHash = result.ToString();
                    }

                    // 3. Gerar hash da password inserida
                    string inputHash = GerarHashSHA256(password);

                    if (storedHash == inputHash)
                    {
                        // sucesso
                        ClienteId = idCliente;
                        ClienteNome = nomeCliente;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Password incorreta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar login: " + ex.Message);
            }
        }

        private string GerarHashSHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
