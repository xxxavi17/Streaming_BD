namespace Streaming_BD
{
    partial class FormAdicionarEpisodio
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
            this.lblTituloEpisodio = new System.Windows.Forms.Label();
            this.txtTituloEpisodio = new System.Windows.Forms.TextBox();
            this.lblNumeroEpisodio = new System.Windows.Forms.Label();
            this.txtNumeroEpisodio = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.btnAdicionarEpisodio = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloEpisodio
            // 
            this.lblTituloEpisodio.Text = "Título do Episódio:";
            this.lblTituloEpisodio.Location = new System.Drawing.Point(30, 30);
            // 
            // txtTituloEpisodio
            // 
            this.txtTituloEpisodio.Location = new System.Drawing.Point(180, 30);
            // 
            // lblNumeroEpisodio
            // 
            this.lblNumeroEpisodio.Text = "Nº Episódio:";
            this.lblNumeroEpisodio.Location = new System.Drawing.Point(30, 70);
            // 
            // txtNumeroEpisodio
            // 
            this.txtNumeroEpisodio.Location = new System.Drawing.Point(180, 70);
            // 
            // lblDuracao
            // 
            this.lblDuracao.Text = "Duração (min):";
            this.lblDuracao.Location = new System.Drawing.Point(30, 110);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(180, 110);
            // 
            // btnAdicionarEpisodio
            // 
            this.btnAdicionarEpisodio.Text = "Adicionar Episódio";
            this.btnAdicionarEpisodio.Location = new System.Drawing.Point(100, 160);
            this.btnAdicionarEpisodio.Size = new System.Drawing.Size(180, 40);
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
            // FormAdicionarEpisodio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.lblTituloEpisodio);
            this.Controls.Add(this.txtTituloEpisodio);
            this.Controls.Add(this.lblNumeroEpisodio);
            this.Controls.Add(this.txtNumeroEpisodio);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.btnAdicionarEpisodio);
            this.Controls.Add(this.btnMenuInicial);
            this.Name = "FormAdicionarEpisodio";
            this.Text = "Adicionar Episódio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblTituloEpisodio;
        private System.Windows.Forms.TextBox txtTituloEpisodio;
        private System.Windows.Forms.Label lblNumeroEpisodio;
        private System.Windows.Forms.TextBox txtNumeroEpisodio;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Button btnAdicionarEpisodio;
        private System.Windows.Forms.Button btnMenuInicial;
    }
}
