namespace Streaming_BD
{
    partial class FormAdicionarEpisodio
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
        private System.Windows.Forms.Label lblTituloEpisodio;
        private System.Windows.Forms.TextBox txtTituloEpisodio;
        private System.Windows.Forms.Label lblNumeroEpisodio;
        private System.Windows.Forms.TextBox txtNumeroEpisodio;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Button btnAdicionarEpisodio;
        private System.Windows.Forms.Button btnMenuInicial;

        private void InitializeComponent()
        {
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblTituloEpisodio = new System.Windows.Forms.Label();
            this.txtTituloEpisodio = new System.Windows.Forms.TextBox();
            this.lblNumeroEpisodio = new System.Windows.Forms.Label();
            this.txtNumeroEpisodio = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.btnAdicionarEpisodio = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();

            // 
            // FormAdicionarEpisodio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Name = "FormAdicionarEpisodio";
            this.Text = "Adicionar Episódio";

            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Text = "Adicionar Episódio";
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloForm.Size = new System.Drawing.Size(450, 40);
            this.lblTituloForm.Location = new System.Drawing.Point(0, 20);

            // 
            // Título do Episódio
            // 
            this.lblTituloEpisodio.Text = "Título do Episódio:";
            this.lblTituloEpisodio.Location = new System.Drawing.Point(40, 80);
            this.txtTituloEpisodio.Location = new System.Drawing.Point(180, 80);
            this.txtTituloEpisodio.Size = new System.Drawing.Size(200, 27);

            // 
            // Número do Episódio
            // 
            this.lblNumeroEpisodio.Text = "Nº Episódio:";
            this.lblNumeroEpisodio.Location = new System.Drawing.Point(40, 120);
            this.txtNumeroEpisodio.Location = new System.Drawing.Point(180, 120);
            this.txtNumeroEpisodio.Size = new System.Drawing.Size(200, 27);

            // 
            // Duração
            // 
            this.lblDuracao.Text = "Duração (min):";
            this.lblDuracao.Location = new System.Drawing.Point(40, 160);
            this.txtDuracao.Location = new System.Drawing.Point(180, 160);
            this.txtDuracao.Size = new System.Drawing.Size(200, 27);

            // 
            // Botão: Adicionar Episódio
            // 
            this.btnAdicionarEpisodio.Text = "Adicionar Episódio";
            this.btnAdicionarEpisodio.Size = new System.Drawing.Size(160, 40);
            this.btnAdicionarEpisodio.Location = new System.Drawing.Point(130, 210);
            this.btnAdicionarEpisodio.Click += new System.EventHandler(this.btnAdicionarEpisodio_Click);

            // 
            // Botão: Menu Inicial
            // 
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.Location = new System.Drawing.Point(20, 20);
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);

            // 
            // Adiciona controles
            // 
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.lblTituloEpisodio);
            this.Controls.Add(this.txtTituloEpisodio);
            this.Controls.Add(this.lblNumeroEpisodio);
            this.Controls.Add(this.txtNumeroEpisodio);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.btnAdicionarEpisodio);
            this.Controls.Add(this.btnMenuInicial);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
