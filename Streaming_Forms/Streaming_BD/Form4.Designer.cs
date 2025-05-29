namespace Streaming_BD
{
    partial class Form4
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

        private System.Windows.Forms.Button btnAdicionarSerie;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Button btnMenuInicial;

        private void InitializeComponent()
        {
            this.btnAdicionarSerie = new System.Windows.Forms.Button();
            this.btnAdicionarFilme = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarSerie
            // 
            this.btnAdicionarSerie.Location = new System.Drawing.Point(200, 150);
            this.btnAdicionarSerie.Name = "btnAdicionarSerie";
            this.btnAdicionarSerie.Size = new System.Drawing.Size(180, 50);
            this.btnAdicionarSerie.TabIndex = 0;
            this.btnAdicionarSerie.Text = "Adicionar Série";
            this.btnAdicionarSerie.UseVisualStyleBackColor = true;
            this.btnAdicionarSerie.Click += new System.EventHandler(this.btnAdicionarSerie_Click);
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.Location = new System.Drawing.Point(420, 150);
            this.btnAdicionarFilme.Name = "btnAdicionarFilme";
            this.btnAdicionarFilme.Size = new System.Drawing.Size(180, 50);
            this.btnAdicionarFilme.TabIndex = 1;
            this.btnAdicionarFilme.Text = "Adicionar Filme";
            this.btnAdicionarFilme.UseVisualStyleBackColor = true;
            this.btnAdicionarFilme.Click += new System.EventHandler(this.btnAdicionarFilme_Click);
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarSerie);
            this.Controls.Add(this.btnAdicionarFilme);
            this.Controls.Add(this.btnMenuInicial);
            this.Name = "Form4";
            this.Text = "Adicionar Conteúdo";
            this.ResumeLayout(false);
        }
    }
}
