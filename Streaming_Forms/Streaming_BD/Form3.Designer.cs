namespace Streaming_BD
{
    partial class Form3
    {
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnRemoverCliente;

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
            // Adicionar label de título acima do DataGridView
            System.Windows.Forms.Label lblTitulo = new System.Windows.Forms.Label();
            lblTitulo.Text = "Lista de Clientes";
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.AutoSize = true;
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitulo.Location = new System.Drawing.Point((this.ClientSize.Width - lblTitulo.Width) / 2, 20);
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Controls.Add(lblTitulo);
            // Ajustar DataGridView para ocupar toda a largura disponível
            this.dgvClientes.Location = new System.Drawing.Point(30, 70);
            this.dgvClientes.Size = new System.Drawing.Size(this.ClientSize.Width - 60, this.ClientSize.Height - 120);
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Resize += new System.EventHandler(this.Form3_Resize);
        }

        #endregion

        // No final do arquivo, adicionar o método para atualizar a posição do botão
        private void Form3_Resize(object sender, System.EventArgs e)
        {
            int baseY = this.dgvClientes.Location.Y + this.dgvClientes.Height + 20;
            this.btnAdicionarCliente.Location = new System.Drawing.Point(20, baseY);
            this.btnEditarCliente.Location = new System.Drawing.Point(220, baseY);
            this.btnRemoverCliente.Location = new System.Drawing.Point(420, baseY);
        }
    }
}
