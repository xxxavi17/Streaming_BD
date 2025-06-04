namespace Streaming_BD
{
    partial class FormAdicionarTemporada
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblNumeroTemporada;
        private System.Windows.Forms.TextBox txtNumeroTemporada;
        private System.Windows.Forms.Label lblAnoTemporada;
        private System.Windows.Forms.TextBox txtAnoTemporada;
        private System.Windows.Forms.Button btnAdicionarTemporada;
        private System.Windows.Forms.Button btnMenuInicial;

        private void InitializeComponent()
        {
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblNumeroTemporada = new System.Windows.Forms.Label();
            this.txtNumeroTemporada = new System.Windows.Forms.TextBox();
            this.lblAnoTemporada = new System.Windows.Forms.Label();
            this.txtAnoTemporada = new System.Windows.Forms.TextBox();
            this.btnAdicionarTemporada = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();

            // 
            // FormAdicionarTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Name = "FormAdicionarTemporada";
            this.Text = "Adicionar Temporada";

            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Text = "Adicionar Temporada";
            this.lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTituloForm.Size = new Size(500, 40);
            this.lblTituloForm.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTituloForm.Location = new Point(0, 20);

            // 
            // Número da Temporada
            // 
            this.lblNumeroTemporada.Text = "Nº Temporada:";
            this.lblNumeroTemporada.Location = new Point(40, 80);
            this.txtNumeroTemporada.Location = new Point(200, 80);
            this.txtNumeroTemporada.Size = new Size(200, 27);

            // 
            // Ano da Temporada
            // 
            this.lblAnoTemporada.Text = "Ano da Temporada:";
            this.lblAnoTemporada.Location = new Point(40, 130);
            this.txtAnoTemporada.Location = new Point(200, 130);
            this.txtAnoTemporada.Size = new Size(200, 27);

            // 
            // Botão: Adicionar Temporada
            // 
            this.btnAdicionarTemporada.Text = "Adicionar Temporada";
            this.btnAdicionarTemporada.Size = new Size(180, 40);
            this.btnAdicionarTemporada.Location = new Point(40, 190);
            this.btnAdicionarTemporada.Click += new EventHandler(this.btnAdicionarTemporada_Click);

            // 
            // Botão: Menu Inicial
            // 
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.Size = new Size(120, 35);
            this.btnMenuInicial.Location = new Point(20, 20);
            this.btnMenuInicial.Click += new EventHandler(this.btnMenuInicial_Click);

            // 
            // Adicionar controles
            // 
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.lblNumeroTemporada);
            this.Controls.Add(this.txtNumeroTemporada);
            this.Controls.Add(this.lblAnoTemporada);
            this.Controls.Add(this.txtAnoTemporada);
            this.Controls.Add(this.btnAdicionarTemporada);
            this.Controls.Add(this.btnMenuInicial);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
