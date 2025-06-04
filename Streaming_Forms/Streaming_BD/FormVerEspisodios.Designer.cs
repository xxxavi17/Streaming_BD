namespace Streaming_BD
{
    partial class FormVerEpisodios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEpisodios;
        private System.Windows.Forms.Button btnAdicionarEpisodio;
        private System.Windows.Forms.Button btnEditarEpisodio;
        private System.Windows.Forms.Button btnRemoverEpisodio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvEpisodios = new System.Windows.Forms.DataGridView();
            this.btnAdicionarEpisodio = new System.Windows.Forms.Button();
            this.btnEditarEpisodio = new System.Windows.Forms.Button();
            this.btnRemoverEpisodio = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodios)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Episódios da Temporada";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(280, 20);
            this.lblTitulo.AutoSize = true;

            // 
            // dgvEpisodios
            // 
            this.dgvEpisodios.AllowUserToAddRows = false;
            this.dgvEpisodios.AllowUserToDeleteRows = false;
            this.dgvEpisodios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEpisodios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpisodios.Location = new System.Drawing.Point(30, 70);
            this.dgvEpisodios.Name = "dgvEpisodios";
            this.dgvEpisodios.ReadOnly = true;
            this.dgvEpisodios.RowHeadersWidth = 51;
            this.dgvEpisodios.RowTemplate.Height = 29;
            this.dgvEpisodios.Size = new System.Drawing.Size(740, 380);
            this.dgvEpisodios.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnAdicionarEpisodio
            // 
            this.btnAdicionarEpisodio.Text = "Adicionar Episódio";
            this.btnAdicionarEpisodio.Location = new System.Drawing.Point(30, 470);
            this.btnAdicionarEpisodio.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionarEpisodio.Click += new System.EventHandler(this.btnAdicionarEpisodio_Click);

            // 
            // btnEditarEpisodio
            // 
            this.btnEditarEpisodio.Text = "Editar Episódio";
            this.btnEditarEpisodio.Location = new System.Drawing.Point(230, 470);
            this.btnEditarEpisodio.Size = new System.Drawing.Size(180, 40);
            this.btnEditarEpisodio.Click += new System.EventHandler(this.btnEditarEpisodio_Click);

            // 
            // btnRemoverEpisodio
            // 
            this.btnRemoverEpisodio.Text = "Remover Episódio";
            this.btnRemoverEpisodio.Location = new System.Drawing.Point(430, 470);
            this.btnRemoverEpisodio.Size = new System.Drawing.Size(180, 40);
            this.btnRemoverEpisodio.Click += new System.EventHandler(this.btnRemoverEpisodio_Click);

            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Location = new System.Drawing.Point(630, 470);
            this.btnVoltar.Size = new System.Drawing.Size(140, 40);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // 
            // FormVerEpisodios
            // 
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvEpisodios);
            this.Controls.Add(this.btnAdicionarEpisodio);
            this.Controls.Add(this.btnEditarEpisodio);
            this.Controls.Add(this.btnRemoverEpisodio);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FormVerEpisodios";
            this.Text = "Ver Episódios";

            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
