namespace Streaming_BD
{
    partial class Form3
    {
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFiltroSubscricao;
        private System.Windows.Forms.ComboBox comboFiltroSubscricao;
        private System.Windows.Forms.Label lblFiltroSexo;
        private System.Windows.Forms.ComboBox comboFiltroSexo;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            // Botão Adicionar Cliente
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.btnAdicionarCliente.Location = new System.Drawing.Point(20, this.ClientSize.Height - 60);
            this.btnAdicionarCliente.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            this.Controls.Add(this.btnAdicionarCliente);
            // Botão Editar Cliente
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente.Location = new System.Drawing.Point(220, this.ClientSize.Height - 60);
            this.btnEditarCliente.Size = new System.Drawing.Size(180, 40);
            this.btnEditarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            this.Controls.Add(this.btnEditarCliente);
            // Botão Remover Cliente
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.btnRemoverCliente.Location = new System.Drawing.Point(420, this.ClientSize.Height - 60);
            this.btnRemoverCliente.Size = new System.Drawing.Size(180, 40);
            this.btnRemoverCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverCliente.Text = "Remover Cliente";
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            this.Controls.Add(this.btnRemoverCliente);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(30, 70);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 29;
            this.dgvClientes.Size = new System.Drawing.Size(1020, 550);
            this.dgvClientes.TabIndex = 0;
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
            // Título
            // 
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo.Text = "Lista de Clientes";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new System.Drawing.Point((1100 - 300) / 2, 20);
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Controls.Add(this.lblTitulo);
            // Filtro por Subscrição (label + ComboBox)
            // 
            this.lblFiltroSubscricao = new System.Windows.Forms.Label();
            this.lblFiltroSubscricao.Text = "Filtrar por subscrição:";
            this.lblFiltroSubscricao.Size = new System.Drawing.Size(150, 20);
            this.lblFiltroSubscricao.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.Controls.Add(this.lblFiltroSubscricao);

            this.comboFiltroSubscricao = new System.Windows.Forms.ComboBox();
            this.comboFiltroSubscricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroSubscricao.Size = new System.Drawing.Size(180, 28);
            this.comboFiltroSubscricao.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.comboFiltroSubscricao.Items.AddRange(new object[] { "Todos", "Premium", "Standart", "Sem Subscrição" });
            this.comboFiltroSubscricao.SelectedIndex = 0;
            this.comboFiltroSubscricao.SelectedIndexChanged += new System.EventHandler(this.ComboFiltroSubscricao_SelectedIndexChanged);
            this.Controls.Add(this.comboFiltroSubscricao);
            // Filtro de sexo (label + ComboBox)
            // 
            this.lblFiltroSexo = new System.Windows.Forms.Label();
            this.lblFiltroSexo.Text = "Filtrar por sexo:";
            this.lblFiltroSexo.Size = new System.Drawing.Size(120, 20);
            this.lblFiltroSexo.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.Controls.Add(this.lblFiltroSexo);

            this.comboFiltroSexo = new System.Windows.Forms.ComboBox();
            this.comboFiltroSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroSexo.Size = new System.Drawing.Size(120, 28);
            this.comboFiltroSexo.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.comboFiltroSexo.Items.AddRange(new object[] { "Todos", "Masculino", "Feminino" });
            this.comboFiltroSexo.SelectedIndex = 0;
            this.comboFiltroSexo.SelectedIndexChanged += new System.EventHandler(this.ComboFiltroSexo_SelectedIndexChanged);
            this.Controls.Add(this.comboFiltroSexo);

            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnRemoverCliente);
            this.Name = "Form3";
            this.Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            // Ajustar DataGridView para ocupar toda a largura disponível
            this.dgvClientes.Location = new System.Drawing.Point(30, 70);
            this.dgvClientes.Size = new System.Drawing.Size(this.ClientSize.Width - 60, this.ClientSize.Height - 120);
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // Evento de resize para atualizar posição dos controles
            this.Resize += new System.EventHandler(this.Form3_Resize);
            // Garantir alinhamento inicial dos controles
            this.Form3_Resize(null, null);
        }

        #endregion

        private void Form3_Resize(object sender, System.EventArgs e)
        {
            int padding = 30;
            int filtroWidth = 150 + 10 + 180; // lblFiltroSubscricao + espaço + comboFiltroSubscricao
            int tituloWidth = lblTitulo.Width;
            int formWidth = this.ClientSize.Width;
            int buttonY = this.ClientSize.Height - 50; // 10px mais abaixo
            int buttonHeight = 40;
            int buttonWidth = 180;
            int buttonSpacing = 20;
            int filtrosAltura = 30 + comboFiltroSubscricao.Height + 8 + comboFiltroSexo.Height + 8; // altura dos filtros + espaçamento
            int gridTop = filtrosAltura + 20; // espaço extra após filtros

            // Centralizar título
            if (lblTitulo != null)
                lblTitulo.Location = new System.Drawing.Point((formWidth - tituloWidth - filtroWidth - padding) / 2, 20);
            // Alinhar filtro à direita, na mesma linha do título
            if (lblFiltroSubscricao != null)
                lblFiltroSubscricao.Location = new System.Drawing.Point(formWidth - filtroWidth - padding, 34);
            if (comboFiltroSubscricao != null)
                comboFiltroSubscricao.Location = new System.Drawing.Point(formWidth - 180 - padding, 30);
            // Filtro de sexo (logo abaixo do filtro de subscrição)
            int filtroSexoY = 30 + comboFiltroSubscricao.Height + 8;
            if (lblFiltroSexo != null)
                lblFiltroSexo.Location = new System.Drawing.Point(formWidth - 180 - padding - lblFiltroSexo.Width - 10, filtroSexoY + 4);
            if (comboFiltroSexo != null)
                comboFiltroSexo.Location = new System.Drawing.Point(formWidth - 180 - padding, filtroSexoY);
            // Botões
            if (btnAdicionarCliente != null)
                btnAdicionarCliente.Location = new System.Drawing.Point(20, buttonY);
            if (btnEditarCliente != null)
                btnEditarCliente.Location = new System.Drawing.Point(20 + buttonWidth + buttonSpacing, buttonY);
            if (btnRemoverCliente != null)
                btnRemoverCliente.Location = new System.Drawing.Point(20 + 2 * (buttonWidth + buttonSpacing), buttonY);
            if (btnAdicionarCliente != null)
                btnAdicionarCliente.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            if (btnEditarCliente != null)
                btnEditarCliente.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            if (btnRemoverCliente != null)
                btnRemoverCliente.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            // DataGridView
            if (dgvClientes != null)
            {
                dgvClientes.Location = new System.Drawing.Point(30, gridTop);
                dgvClientes.Size = new System.Drawing.Size(this.ClientSize.Width - 60, this.ClientSize.Height - gridTop - 70);
            }
        }
    }
}
