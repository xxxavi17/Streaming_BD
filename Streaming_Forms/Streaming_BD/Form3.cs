using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Streaming_BD
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p1g11;User Id=p1g11;Password=Theoxavi11;TrustServerCertificate=True";
        private ComboBox comboFiltroSubscricao;

        public Form3()
        {
            InitializeComponent();
            // Adiciona ComboBox de filtro de subscrição
            comboFiltroSubscricao = new ComboBox();
            comboFiltroSubscricao.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltroSubscricao.Items.AddRange(new object[] { "Todos", "Premium", "Standart", "Sem Subscrição" });
            comboFiltroSubscricao.SelectedIndex = 0;
            comboFiltroSubscricao.Location = new System.Drawing.Point(30, 30);
            comboFiltroSubscricao.Size = new System.Drawing.Size(180, 28);
            comboFiltroSubscricao.SelectedIndexChanged += ComboFiltroSubscricao_SelectedIndexChanged;
            this.Controls.Add(comboFiltroSubscricao);
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            CarregarClientes();
        }

        private void ComboFiltroSubscricao_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string filtro = comboFiltroSubscricao?.SelectedItem?.ToString() ?? "Todos";
                using (var cmd = new SqlCommand("SP_FiltrarClientesPorSubscricao", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (filtro == "Todos")
                        cmd.Parameters.AddWithValue("@tipo_sub", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@tipo_sub", filtro);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvClientes.DataSource = dt;
                    }
                }
            }
        }

        // Botão: Menu Inicial
        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        // Botão: Remover Cliente
        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem a certeza que deseja remover o cliente selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_cliente"].Value);
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Remove ratings do cliente antes de remover subscrições e cliente
                        string deleteRatings = "DELETE FROM Streaming_Rating WHERE id_cliente = @id_cliente";
                        using (var cmd = new SqlCommand(deleteRatings, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }
                        // Remove subscrições primeiro (se existirem)
                        string deleteSub = "DELETE FROM Streaming_Subscricao WHERE id_cliente = @id_cliente";
                        using (var cmd = new SqlCommand(deleteSub, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }
                        // Remove cliente via stored procedure
                        using (var cmd = new SqlCommand("SP_RemoverCliente", conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente removido com sucesso!");
                    CarregarClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.");
            }
        }

        // Botão: Adicionar Cliente
        private void btnAdicionarCliente_Click(object? sender, EventArgs e)
        {
            var form2 = new Form2();
            var result = form2.ShowDialog();
            CarregarClientes();
        }

        private void btnEditarCliente_Click(object? sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_cliente"].Value);
                string nome = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString() ?? "";
                string email = dgvClientes.SelectedRows[0].Cells["email"].Value.ToString() ?? "";
                string tipoSub = dgvClientes.SelectedRows[0].Cells["Tipo Subscrição"].Value.ToString() ?? "";
                string estado = dgvClientes.SelectedRows[0].Cells["Estado"].Value.ToString() ?? "";
                var formEditar = new FormEditarCliente(idCliente, nome, email, tipoSub, estado, connectionString);
                var result = formEditar.ShowDialog();
                if (formEditar.ClienteEditado)
                {
                    CarregarClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
        }
    }
}
