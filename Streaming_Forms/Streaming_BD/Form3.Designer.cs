namespace Streaming_BD
{
    partial class Form3
    {
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnMenuInicial;
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
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(50, 50);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 29;
            this.dgvClientes.Size = new System.Drawing.Size(700, 300);
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
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.Location = new System.Drawing.Point(550, 370);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(200, 40);
            this.btnRemoverCliente.TabIndex = 2;
            this.btnRemoverCliente.Text = "Remover Cliente";
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnRemoverCliente);
            this.Name = "Form3";
            this.Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
