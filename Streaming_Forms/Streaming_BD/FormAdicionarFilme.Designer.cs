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
        private System.Windows.Forms.ComboBox cmbProdutora;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblInstrucaoProdutora;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormAdicionarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Name = "FormAdicionarFilme";
            this.Text = "Adicionar Filme";
            // Título do formulário
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblTituloForm.Text = "Adicionar Filme";
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloForm.Location = new System.Drawing.Point(0, 20);
            this.lblTituloForm.Size = new System.Drawing.Size(600, 40);
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblTituloForm);
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
            this.cmbProdutora = new System.Windows.Forms.ComboBox();
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
            this.lblProdutora.Location = new System.Drawing.Point(40, 340);
            this.lblProdutora.Size = new System.Drawing.Size(140, 25);
            // Ajustar label e ComboBox de produtora para melhor alinhamento
            this.cmbProdutora = new System.Windows.Forms.ComboBox();
            this.cmbProdutora.Location = new System.Drawing.Point(180, 340);
            this.cmbProdutora.Size = new System.Drawing.Size(350, 27);
            this.cmbProdutora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutora.Text = "Selecionar uma opção";
            this.Controls.Add(this.cmbProdutora);
            // Label de instrução ajustada logo abaixo do ComboBox
            this.lblInstrucaoProdutora = new System.Windows.Forms.Label();
            this.lblInstrucaoProdutora.Text = "Selecionar uma produtora ou escrever o seu nome";
            this.lblInstrucaoProdutora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInstrucaoProdutora.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstrucaoProdutora.Location = new System.Drawing.Point(180, 370);
            this.lblInstrucaoProdutora.Size = new System.Drawing.Size(350, 20);
            this.Controls.Add(this.lblInstrucaoProdutora);
            // TextBox para inserir produtora manualmente
            this.txtProdutora.Location = new System.Drawing.Point(180, 400);
            this.txtProdutora.Size = new System.Drawing.Size(350, 27);
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.Text = "Adicionar Filme";
            this.btnAdicionarFilme.Location = new System.Drawing.Point(220, 470);
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
            this.Controls.Add(this.cmbProdutora);
            this.Controls.Add(this.btnAdicionarFilme);
            // Placeholders para os campos de preenchimento
            this.txtTitulo.PlaceholderText = "Ex: O Senhor dos Anéis";
            this.txtGenero.PlaceholderText = "Ex: Fantasia";
            this.txtAno.PlaceholderText = "Ex: 2001";
            this.txtDuracao.PlaceholderText = "Ex: 178";
            this.txtIdadeMinima.PlaceholderText = "Ex: 12";
            this.txtProdutora.PlaceholderText = "Ex: Warner Bros.";
            // Botão Voltar Atrás
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnVoltar.Location = new System.Drawing.Point(30, this.ClientSize.Height - 60);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 35);
            this.btnVoltar.TabIndex = 100;
            this.btnVoltar.Text = "Voltar Atrás";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.Controls.Add(this.btnVoltar);
            this.ResumeLayout(false);
        }
    }
}
