namespace Streaming_BD
{
    partial class FormVerSeries
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSeries;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionarSerie;
        private System.Windows.Forms.Button btnEditarTemporada;
        private System.Windows.Forms.Button btnRemoverTemporada;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvSeries = new System.Windows.Forms.DataGridView();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionarSerie = new System.Windows.Forms.Button();
            this.btnEditarTemporada = new System.Windows.Forms.Button();
            this.btnRemoverTemporada = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvSeries
            // 
            this.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeries.Location = new System.Drawing.Point(30, 80);
            this.dgvSeries.Name = "dgvSeries";
            this.dgvSeries.RowHeadersWidth = 51;
            this.dgvSeries.RowTemplate.Height = 29;
            this.dgvSeries.Size = new System.Drawing.Size(1020, 550);
            this.dgvSeries.TabIndex = 0;
            this.dgvSeries.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(20, 20);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.TabIndex = 1;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(370, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(375, 41);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de Séries e Temporadas";

            // 
            // btnAdicionarSerie
            // 
            this.btnAdicionarSerie.Location = new System.Drawing.Point(30, 650);
            this.btnAdicionarSerie.Name = "btnAdicionarSerie";
            this.btnAdicionarSerie.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionarSerie.TabIndex = 3;
            this.btnAdicionarSerie.Text = "Adicionar Série";
            this.btnAdicionarSerie.UseVisualStyleBackColor = true;
            this.btnAdicionarSerie.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionarSerie.Click += new System.EventHandler(this.btnAdicionarSerie_Click);

            // 
            // btnEditarTemporada
            // 
            this.btnEditarTemporada.Location = new System.Drawing.Point(230, 650);
            this.btnEditarTemporada.Name = "btnEditarTemporada";
            this.btnEditarTemporada.Size = new System.Drawing.Size(180, 40);
            this.btnEditarTemporada.TabIndex = 4;
            this.btnEditarTemporada.Text = "Editar Série";
            this.btnEditarTemporada.UseVisualStyleBackColor = true;
            this.btnEditarTemporada.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnEditarTemporada.Click += new System.EventHandler(this.btnEditarTemporada_Click);

            // 
            // btnRemoverTemporada
            // 
            this.btnRemoverTemporada.Location = new System.Drawing.Point(430, 650);
            this.btnRemoverTemporada.Name = "btnRemoverTemporada";
            this.btnRemoverTemporada.Size = new System.Drawing.Size(180, 40);
            this.btnRemoverTemporada.TabIndex = 5;
            this.btnRemoverTemporada.Text = "Remover Série";
            this.btnRemoverTemporada.UseVisualStyleBackColor = true;
            this.btnRemoverTemporada.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoverTemporada.Click += new System.EventHandler(this.btnRemoverTemporada_Click);

            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(this.lblTitulo.Location.X + this.lblTitulo.Width + 40, 30);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(120, 20);
            this.lblPesquisa.TabIndex = 6;
            this.lblPesquisa.Text = "Pesquisar Série:";
            this.lblPesquisa.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.Controls.Add(this.lblPesquisa);

            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(this.lblPesquisa.Location.X + this.lblPesquisa.Width + 8, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(250, 27);
            this.txtPesquisa.TabIndex = 7;
            this.txtPesquisa.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.Controls.Add(this.txtPesquisa);

            // 
            // FormVerSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnRemoverTemporada);
            this.Controls.Add(this.btnEditarTemporada);
            this.Controls.Add(this.btnAdicionarSerie);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.dgvSeries);
            this.Name = "FormVerSeries";
            this.Text = "Lista de Séries e Temporadas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
