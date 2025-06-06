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
            this.lblFiltroProdutora = new System.Windows.Forms.Label();
            this.comboFiltroProdutora = new System.Windows.Forms.ComboBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
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
            // lblFiltroProdutora
            // 
            this.lblFiltroProdutora = new System.Windows.Forms.Label();
            this.lblFiltroProdutora.Text = "Filtrar por produtora:";
            this.lblFiltroProdutora.Size = new System.Drawing.Size(150, 20);
            this.lblFiltroProdutora.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.Controls.Add(this.lblFiltroProdutora);
            // 
            // comboFiltroProdutora
            // 
            this.comboFiltroProdutora = new System.Windows.Forms.ComboBox();
            this.comboFiltroProdutora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroProdutora.Size = new System.Drawing.Size(180, 28);
            this.comboFiltroProdutora.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.comboFiltroProdutora.SelectedIndexChanged += new System.EventHandler(this.comboFiltroProdutora_SelectedIndexChanged);
            this.Controls.Add(this.comboFiltroProdutora);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Text = "Pesquisar Filme:";
            this.lblPesquisa.Location = new System.Drawing.Point(20, 65);
            this.lblPesquisa.Size = new System.Drawing.Size(120, 20);
            this.lblPesquisa.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            this.Controls.Add(this.lblPesquisa);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(150, 62);
            this.txtPesquisa.Size = new System.Drawing.Size(300, 27);
            this.txtPesquisa.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.Controls.Add(this.txtPesquisa);
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
            // Garantir alinhamento inicial dos controles
            this.Form5_Resize(null, null);
        }

        private System.Windows.Forms.DataGridView dgvConteudos;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Button btnEditarFilme;
        private System.Windows.Forms.Button btnRemoverFilme;
        private System.Windows.Forms.Label lblFiltroGenero;
        private System.Windows.Forms.ComboBox comboFiltroGenero;
        private System.Windows.Forms.Label lblFiltroProdutora;
        private System.Windows.Forms.ComboBox comboFiltroProdutora;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;

        // Removed duplicate Form5_Resize method to resolve ambiguity error.

        private void Form5_Resize(object sender, System.EventArgs e)
        {
            int padding = 30;
            int comboWidth = 180;
            int labelGeneroWidth = 130;
            int labelProdutoraWidth = 150;
            int spacing = 10;
            int formWidth = this.ClientSize.Width;
            int yProdutora = 30;
            int yGenero = yProdutora + 38; // espaço vertical entre filtros
            // Produtora (no topo à direita)
            lblFiltroProdutora.Location = new System.Drawing.Point(formWidth - labelProdutoraWidth - comboWidth - spacing - padding, yProdutora + 4);
            comboFiltroProdutora.Location = new System.Drawing.Point(formWidth - comboWidth - padding, yProdutora);
            // Gênero (abaixo do filtro de produtora, alinhado à direita)
            lblFiltroGenero.Location = new System.Drawing.Point(formWidth - labelGeneroWidth - comboWidth - spacing - padding, yGenero + 4);
            comboFiltroGenero.Location = new System.Drawing.Point(formWidth - comboWidth - padding, yGenero);
            // Botões
            int buttonY = this.ClientSize.Height - 50;
            int buttonHeight = 40;
            int buttonWidth = 180;
            int buttonSpacing = 20;
            if (btnAdicionarFilme != null)
                btnAdicionarFilme.Location = new System.Drawing.Point(20, buttonY);
            if (btnEditarFilme != null)
                btnEditarFilme.Location = new System.Drawing.Point(20 + buttonWidth + buttonSpacing, buttonY);
            if (btnRemoverFilme != null)
                btnRemoverFilme.Location = new System.Drawing.Point(20 + 2 * (buttonWidth + buttonSpacing), buttonY);
            if (btnAdicionarFilme != null)
                btnAdicionarFilme.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            if (btnEditarFilme != null)
                btnEditarFilme.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            if (btnRemoverFilme != null)
                btnRemoverFilme.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            // DataGridView - mover para baixo para dar espaço aos filtros
            int gridTop = yGenero + 38; // espaço após o segundo filtro
            if (dgvConteudos != null)
            {
                dgvConteudos.Location = new System.Drawing.Point(30, gridTop);
                dgvConteudos.Size = new System.Drawing.Size(this.ClientSize.Width - 60, this.ClientSize.Height - gridTop - 70);
            }
        }
    }
}