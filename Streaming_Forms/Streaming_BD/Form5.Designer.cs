namespace Streaming_BD
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.dgvConteudos = new System.Windows.Forms.DataGridView();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionarFilme = new System.Windows.Forms.Button();
            this.btnEditarFilme = new System.Windows.Forms.Button();
            this.btnRemoverFilme = new System.Windows.Forms.Button();
            this.lblFiltroGenero = new System.Windows.Forms.Label();
            this.comboFiltroGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConteudos
            // 
            this.dgvConteudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConteudos.Location = new System.Drawing.Point(30, 70);
            this.dgvConteudos.Name = "dgvConteudos";
            this.dgvConteudos.RowHeadersWidth = 51;
            this.dgvConteudos.RowTemplate.Height = 29;
            this.dgvConteudos.Size = new System.Drawing.Size(1020, 550);
            this.dgvConteudos.TabIndex = 0;
            this.dgvConteudos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvConteudos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(20, 20);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.TabIndex = 99;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Lista de Filmes";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new System.Drawing.Point((1100 - 300) / 2, 20);
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.Location = new System.Drawing.Point(20, this.ClientSize.Height - 60);
            this.btnAdicionarFilme.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionarFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionarFilme.Text = "Adicionar Filme";
            this.btnAdicionarFilme.UseVisualStyleBackColor = true;
            this.btnAdicionarFilme.Click += new System.EventHandler(this.btnAdicionarFilme_Click);
            this.Controls.Add(this.btnAdicionarFilme);
            // 
            // btnEditarFilme
            // 
            this.btnEditarFilme.Location = new System.Drawing.Point(220, this.ClientSize.Height - 60);
            this.btnEditarFilme.Size = new System.Drawing.Size(180, 40);
            this.btnEditarFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarFilme.Text = "Editar Filme";
            this.btnEditarFilme.UseVisualStyleBackColor = true;
            this.btnEditarFilme.Click += new System.EventHandler(this.btnEditarFilme_Click);
            this.Controls.Add(this.btnEditarFilme);
            // 
            // btnRemoverFilme
            // 
            this.btnRemoverFilme.Location = new System.Drawing.Point(420, this.ClientSize.Height - 60);
            this.btnRemoverFilme.Size = new System.Drawing.Size(180, 40);
            this.btnRemoverFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverFilme.Text = "Remover Filme";
            this.btnRemoverFilme.UseVisualStyleBackColor = true;
            this.btnRemoverFilme.Click += new System.EventHandler(this.btnRemoverFilme_Click);
            this.Controls.Add(this.btnRemoverFilme);
            // 
            // lblFiltroGenero
            // 
            this.lblFiltroGenero.Text = "Filtrar por gênero:";
            this.lblFiltroGenero.Location = new System.Drawing.Point(this.ClientSize.Width - 370, 34);
            this.lblFiltroGenero.Size = new System.Drawing.Size(130, 20);
            this.lblFiltroGenero.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.Controls.Add(this.lblFiltroGenero);
            // 
            // comboFiltroGenero
            // 
            this.comboFiltroGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroGenero.Location = new System.Drawing.Point(this.ClientSize.Width - 220, 30);
            this.comboFiltroGenero.Size = new System.Drawing.Size(180, 28);
            this.comboFiltroGenero.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.comboFiltroGenero.SelectedIndexChanged += new System.EventHandler(this.comboFiltroGenero_SelectedIndexChanged);
            this.Controls.Add(this.comboFiltroGenero);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvConteudos);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form5";
            this.Text = "Lista de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            // Ajustar DataGridView para ocupar toda a largura e altura disponíveis, exceto espaço dos botões
            this.dgvConteudos.Location = new System.Drawing.Point(30, 70);
            this.dgvConteudos.Size = new System.Drawing.Size(this.ClientSize.Width - 60, this.ClientSize.Height - 120);
            this.dgvConteudos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvConteudos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Botões
            this.btnAdicionarFilme.Location = new System.Drawing.Point(20, this.ClientSize.Height - 60);
            this.btnAdicionarFilme.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionarFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarFilme.Location = new System.Drawing.Point(220, this.ClientSize.Height - 60);
            this.btnEditarFilme.Size = new System.Drawing.Size(180, 40);
            this.btnEditarFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverFilme.Location = new System.Drawing.Point(420, this.ClientSize.Height - 60);
            this.btnRemoverFilme.Size = new System.Drawing.Size(180, 40);
            this.btnRemoverFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));

            // Evento de resize para atualizar posição dos botões
            this.Resize += new System.EventHandler(this.Form5_Resize);
        }

        private System.Windows.Forms.DataGridView dgvConteudos;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Button btnEditarFilme;
        private System.Windows.Forms.Button btnRemoverFilme;
        private System.Windows.Forms.Label lblFiltroGenero;
        private System.Windows.Forms.ComboBox comboFiltroGenero;

        // Removed duplicate Form5_Resize method to resolve ambiguity error.

        private void Form5_Resize(object sender, System.EventArgs e)
        {
            // Atualiza a posição e tamanho dos controles ao redimensionar o formulário
            if (btnAdicionarFilme != null)
                btnAdicionarFilme.Location = new System.Drawing.Point(20, this.ClientSize.Height - 60);
            if (btnEditarFilme != null)
                btnEditarFilme.Location = new System.Drawing.Point(220, this.ClientSize.Height - 60);
            if (btnRemoverFilme != null)
                btnRemoverFilme.Location = new System.Drawing.Point(420, this.ClientSize.Height - 60);
            if (dgvConteudos != null)
                dgvConteudos.Size = new System.Drawing.Size(this.ClientSize.Width - 60, this.ClientSize.Height - 120);
            if (lblFiltroGenero != null)
                lblFiltroGenero.Location = new System.Drawing.Point(this.ClientSize.Width - 370, 34);
            if (comboFiltroGenero != null)
                comboFiltroGenero.Location = new System.Drawing.Point(this.ClientSize.Width - 220, 30);
        }
    }
}
