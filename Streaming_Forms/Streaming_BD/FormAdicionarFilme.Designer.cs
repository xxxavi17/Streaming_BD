namespace Streaming_BD
{
    partial class FormAdicionarFilme
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
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblIdadeMinima;
        private System.Windows.Forms.TextBox txtIdadeMinima;
        private System.Windows.Forms.Label lblProdutora;
        private System.Windows.Forms.TextBox txtProdutora;
        private System.Windows.Forms.Button btnAdicionarFilme;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormAdicionarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Name = "FormAdicionarFilme";
            this.Text = "Adicionar Filme";
            this.ResumeLayout(false);
            this.btnMenuInicial = new System.Windows.Forms.Button();
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
            this.Controls.Add(this.btnMenuInicial);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblIdadeMinima = new System.Windows.Forms.Label();
            this.txtIdadeMinima = new System.Windows.Forms.TextBox();
            this.lblProdutora = new System.Windows.Forms.Label();
            this.txtProdutora = new System.Windows.Forms.TextBox();
            this.btnAdicionarFilme = new System.Windows.Forms.Button();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Location = new System.Drawing.Point(40, 80);
            this.lblTitulo.Size = new System.Drawing.Size(100, 25);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(180, 80);
            this.txtTitulo.Size = new System.Drawing.Size(350, 27);
            // 
            // lblGenero
            // 
            this.lblGenero.Text = "Género:";
            this.lblGenero.Location = new System.Drawing.Point(40, 120);
            this.lblGenero.Size = new System.Drawing.Size(100, 25);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(180, 120);
            this.txtGenero.Size = new System.Drawing.Size(350, 27);
            // 
            // lblAno
            // 
            this.lblAno.Text = "Ano:";
            this.lblAno.Location = new System.Drawing.Point(40, 160);
            this.lblAno.Size = new System.Drawing.Size(100, 25);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(180, 160);
            this.txtAno.Size = new System.Drawing.Size(100, 27);
            // 
            // lblDuracao
            // 
            this.lblDuracao.Text = "Duração (min):";
            this.lblDuracao.Location = new System.Drawing.Point(40, 200);
            this.lblDuracao.Size = new System.Drawing.Size(120, 25);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(180, 200);
            this.txtDuracao.Size = new System.Drawing.Size(100, 27);
            // 
            // lblIdadeMinima
            // 
            this.lblIdadeMinima.Text = "Idade Mínima:";
            this.lblIdadeMinima.Location = new System.Drawing.Point(40, 240);
            this.lblIdadeMinima.Size = new System.Drawing.Size(120, 25);
            // 
            // txtIdadeMinima
            // 
            this.txtIdadeMinima.Location = new System.Drawing.Point(180, 240);
            this.txtIdadeMinima.Size = new System.Drawing.Size(100, 27);
            // 
            // lblProdutora
            // 
            this.lblProdutora.Text = "Nome da Produtora:";
            this.lblProdutora.Location = new System.Drawing.Point(40, 280);
            this.lblProdutora.Size = new System.Drawing.Size(140, 25);
            // 
            // txtProdutora
            // 
            this.txtProdutora.Location = new System.Drawing.Point(180, 280);
            this.txtProdutora.Size = new System.Drawing.Size(350, 27);
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.Text = "Adicionar Filme";
            this.btnAdicionarFilme.Location = new System.Drawing.Point(220, 330);
            this.btnAdicionarFilme.Size = new System.Drawing.Size(160, 40);
            this.btnAdicionarFilme.Click += new System.EventHandler(this.btnAdicionarFilme_Click);
            // Adicionar controles ao formulário
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.lblIdadeMinima);
            this.Controls.Add(this.txtIdadeMinima);
            this.Controls.Add(this.lblProdutora);
            this.Controls.Add(this.txtProdutora);
            this.Controls.Add(this.btnAdicionarFilme);
        }
    }
}
