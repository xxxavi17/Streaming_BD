using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Streaming_BD
{
    public partial class FormEditarAtor : Form
    {
        private int atorId;
        private string connectionString;
        public bool AtorEditado { get; private set; } = false;

        public FormEditarAtor(int id, string nome, string sexo, int idade, string connStr)
        {
            InitializeComponent();
            atorId = id;
            connectionString = connStr;
            textBoxNome.Text = nome;
            textBoxIdade.Text = idade.ToString();
            labelTitulo.Text = $"Editar Ator: {nome} (ID: {id})";

            if (sexo == "M")
                comboBoxSexo.SelectedItem = "Masculino";
            else if (sexo == "F")
                comboBoxSexo.SelectedItem = "Feminino";

            CarregarConteudos();
        }

        private void CarregarConteudos()
        {
            checkedListBoxConteudos.Items.Clear();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            // Obter todos os conteúdos
            var cmdConteudos = new SqlCommand("SELECT id_conteudo, titulo FROM Streaming_Conteudo", conn);
            using var reader = cmdConteudos.ExecuteReader();
            while (reader.Read())
            {
                checkedListBoxConteudos.Items.Add(new ConteudoItem
                {
                    Id = (int)reader["id_conteudo"],
                    Titulo = reader["titulo"].ToString()
                });
            }
            reader.Close();

            // Marcar os conteúdos associados ao ator
            var cmdAssoc = new SqlCommand("SELECT id_conteudo FROM Streaming_Conteudo_Ator WHERE id_ator = @id", conn);
            cmdAssoc.Parameters.AddWithValue("@id", atorId);
            using var assocReader = cmdAssoc.ExecuteReader();
            while (assocReader.Read())
            {
                int idConteudo = (int)assocReader["id_conteudo"];
                for (int i = 0; i < checkedListBoxConteudos.Items.Count; i++)
                {
                    if (((ConteudoItem)checkedListBoxConteudos.Items[i]).Id == idConteudo)
                    {
                        checkedListBoxConteudos.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string novoNome = textBoxNome.Text.Trim();
            string sexoSelecionado = comboBoxSexo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(novoNome) || string.IsNullOrEmpty(sexoSelecionado))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            string novoSexo = sexoSelecionado.StartsWith("M") ? "M" :
                              sexoSelecionado.StartsWith("F") ? "F" : "O";

            if (!int.TryParse(textBoxIdade.Text, out int novaIdade) || novaIdade <= 0)
            {
                MessageBox.Show("Insira uma idade válida.");
                return;
            }

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // Atualizar ator
                var cmd = new SqlCommand("SP_EditarAtor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ator", atorId);
                cmd.Parameters.AddWithValue("@novo_nome", novoNome);
                cmd.Parameters.AddWithValue("@novo_sexo", novoSexo);
                cmd.Parameters.AddWithValue("@nova_idade", novaIdade);
                cmd.ExecuteNonQuery();

                // Atualizar conteúdos associados
                var cmdDel = new SqlCommand("DELETE FROM Streaming_Conteudo_Ator WHERE id_ator = @id", conn);
                cmdDel.Parameters.AddWithValue("@id", atorId);
                cmdDel.ExecuteNonQuery();

                foreach (var item in checkedListBoxConteudos.CheckedItems)
                {
                    var conteudo = (ConteudoItem)item;
                    var cmdIns = new SqlCommand("INSERT INTO Streaming_Conteudo_Ator (id_conteudo, id_ator) VALUES (@id_conteudo, @id_ator)", conn);
                    cmdIns.Parameters.AddWithValue("@id_conteudo", conteudo.Id);
                    cmdIns.Parameters.AddWithValue("@id_ator", atorId);
                    cmdIns.ExecuteNonQuery();
                }

                AtorEditado = true;
                MessageBox.Show("Ator editado com sucesso!");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao editar ator: " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class ConteudoItem
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public override string ToString() => Titulo;
        }
    }
}
