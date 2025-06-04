namespace Streaming_BD
{
    partial class FormAdicionarSerie
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblIdadeMinima;
        private System.Windows.Forms.TextBox txtIdadeMinima;
        private System.Windows.Forms.Label lblProdutora;
        private System.Windows.Forms.ComboBox cmbProdutora;
        private System.Windows.Forms.TextBox txtProdutora;
        private System.Windows.Forms.Button btnAdicionarSerie;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnVoltar;

        private void InitializeComponent()
        {
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblIdadeMinima = new System.Windows.Forms.Label();
            this.txtIdadeMinima = new System.Windows.Forms.TextBox();
            this.lblProdutora = new System.Windows.Forms.Label();
            this.cmbProdutora = new System.Windows.Forms.ComboBox();
            this.txtProdutora = new System.Windows.Forms.TextBox();
            this.btnAdicionarSerie = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            // 
            // FormAdicionarSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Name = "FormAdicionarSerie";
            this.Text = "Adicionar Série";

            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Text = "Adicionar Série";
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloForm.Location = new System.Drawing.Point(0, 20);
            this.lblTituloForm.Size = new System.Drawing.Size(500, 40);
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Location = new System.Drawing.Point(40, 80);
            this.txtTitulo.Location = new System.Drawing.Point(180, 80);
            this.txtTitulo.Size = new System.Drawing.Size(250, 27);

            // 
            // lblGenero
            // 
            this.lblGenero.Text = "Gênero:";
            this.lblGenero.Location = new System.Drawing.Point(40, 120);
            this.txtGenero.Location = new System.Drawing.Point(180, 120);
            this.txtGenero.Size = new System.Drawing.Size(250, 27);

            // 
            // lblAno
            // 
            this.lblAno.Text = "Ano:";
            this.lblAno.Location = new System.Drawing.Point(40, 160);
            this.txtAno.Location = new System.Drawing.Point(180, 160);
            this.txtAno.Size = new System.Drawing.Size(100, 27);

            // 
            // lblIdadeMinima
            // 
            this.lblIdadeMinima.Text = "Idade Mínima:";
            this.lblIdadeMinima.Location = new System.Drawing.Point(40, 200);
            this.txtIdadeMinima.Location = new System.Drawing.Point(180, 200);
            this.txtIdadeMinima.Size = new System.Drawing.Size(100, 27);

            // 
            // lblProdutora
            // 
            this.lblProdutora.Text = "Produtora:";
            this.lblProdutora.Location = new System.Drawing.Point(40, 240);
            this.cmbProdutora.Location = new System.Drawing.Point(180, 240);
            this.cmbProdutora.Size = new System.Drawing.Size(250, 28);
            this.cmbProdutora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // 
            // txtProdutora
            // 
            this.txtProdutora.PlaceholderText = "Ou digite o nome da produtora";
            this.txtProdutora.Location = new System.Drawing.Point(180, 280);
            this.txtProdutora.Size = new System.Drawing.Size(250, 27);

            // 
            // btnAdicionarSerie
            // 
            this.btnAdicionarSerie.Text = "Adicionar Série";
            this.btnAdicionarSerie.Location = new System.Drawing.Point(180, 340);
            this.btnAdicionarSerie.Size = new System.Drawing.Size(160, 40);
            this.btnAdicionarSerie.Click += new System.EventHandler(this.btnAdicionarSerie_Click);

            // 
            // btnVoltar
            // 
            this.btnVoltar.Text = "Voltar Atrás";
            this.btnVoltar.Location = new System.Drawing.Point(30, 400);
            this.btnVoltar.Size = new System.Drawing.Size(120, 35);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.Location = new System.Drawing.Point(20, 20);
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);

            // 
            // Add controls
            // 
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblIdadeMinima);
            this.Controls.Add(this.txtIdadeMinima);
            this.Controls.Add(this.lblProdutora);
            this.Controls.Add(this.cmbProdutora);
            this.Controls.Add(this.txtProdutora);
            this.Controls.Add(this.btnAdicionarSerie);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMenuInicial);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
