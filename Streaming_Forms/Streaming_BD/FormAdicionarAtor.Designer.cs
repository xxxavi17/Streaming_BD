namespace Streaming_BD
{
    partial class FormAdicionarAtor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblNome = new Label();
            this.lblSexo = new Label();
            this.lblIdade = new Label();
            this.lblConteudo = new Label();
            this.txtNome = new TextBox();
            this.cmbSexo = new ComboBox();
            this.txtIdade = new TextBox();
            this.clbConteudos = new CheckedListBox();
            this.btnAdicionar = new Button();

            // FormAdicionarAtor
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Text = "Adicionar Ator";
            this.StartPosition = FormStartPosition.CenterParent;

            int centerX = (this.ClientSize.Width - 250) / 2;
            int startY = 60;
            int spacingY = 60;

            // lblTitulo
            this.lblTitulo.Text = "Adicionar Ator";
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new Point(centerX, 20);
            this.Controls.Add(this.lblTitulo);

            // lblNome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new Point(centerX, startY);
            this.lblNome.Size = new Size(250, 20);
            this.Controls.Add(this.lblNome);

            // txtNome
            this.txtNome.Location = new Point(centerX, startY + 25);
            this.txtNome.Size = new Size(250, 27);
            this.txtNome.PlaceholderText = "Ex: Maria Oliveira";
            this.Controls.Add(this.txtNome);

            // lblSexo
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Location = new Point(centerX, startY + spacingY);
            this.lblSexo.Size = new Size(250, 20);
            this.Controls.Add(this.lblSexo);

            // cmbSexo
            this.cmbSexo.Location = new Point(centerX, startY + spacingY + 25);
            this.cmbSexo.Size = new Size(250, 28);
            this.cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino"});
            this.Controls.Add(this.cmbSexo);

            // lblIdade
            this.lblIdade.Text = "Idade:";
            this.lblIdade.Location = new Point(centerX, startY + 2 * spacingY);
            this.lblIdade.Size = new Size(250, 20);
            this.Controls.Add(this.lblIdade);

            // txtIdade
            this.txtIdade.Location = new Point(centerX, startY + 2 * spacingY + 25);
            this.txtIdade.Size = new Size(250, 27);
            this.txtIdade.PlaceholderText = "Ex: 35";
            this.Controls.Add(this.txtIdade);

            // lblConteudo
            this.lblConteudo.Text = "Selecionar Conteúdos:";
            this.lblConteudo.Location = new Point(centerX, startY + 3 * spacingY);
            this.lblConteudo.Size = new Size(250, 20);
            this.Controls.Add(this.lblConteudo);

            // clbConteudos (CheckedListBox para múltiplos)
            this.clbConteudos.Location = new Point(centerX, startY + 3 * spacingY + 25);
            this.clbConteudos.Size = new Size(250, 100);
            this.clbConteudos.CheckOnClick = true;
            this.Controls.Add(this.clbConteudos);

            // btnAdicionar
            this.btnAdicionar.Text = "Adicionar Ator";
            this.btnAdicionar.Size = new Size(180, 40);
            this.btnAdicionar.Location = new Point(centerX + 35, startY + 3 * spacingY + 150);
            this.btnAdicionar.Click += new EventHandler(this.btnAdicionar_Click);
            this.Controls.Add(this.btnAdicionar);
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private Label lblSexo;
        private Label lblIdade;
        private Label lblConteudo;
        private TextBox txtNome;
        private ComboBox cmbSexo;
        private TextBox txtIdade;
        private CheckedListBox clbConteudos;
        private Button btnAdicionar;
    }
}
