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
            this.btnRemoverConteudo = new System.Windows.Forms.Button();
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
            this.lblTitulo.Text = "Lista de Conteúdos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new System.Drawing.Point((1100 - 300) / 2, 20);
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // btnRemoverConteudo
            // 
            this.btnRemoverConteudo.Text = "Remover Conteúdo";
            this.btnRemoverConteudo.Size = new System.Drawing.Size(200, 40);
            this.btnRemoverConteudo.Name = "btnRemoverConteudo";
            this.btnRemoverConteudo.TabIndex = 100;
            this.btnRemoverConteudo.UseVisualStyleBackColor = true;
            this.btnRemoverConteudo.Location = new System.Drawing.Point((this.ClientSize.Width - this.btnRemoverConteudo.Width) / 2, this.dgvConteudos.Location.Y + this.dgvConteudos.Height + 20);
            this.btnRemoverConteudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoverConteudo.Click += new System.EventHandler(this.btnRemoverConteudo_Click);
            this.Controls.Add(this.btnRemoverConteudo);
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
            this.Text = "Lista de Conteúdos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConteudos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvConteudos;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRemoverConteudo;
    }
}
