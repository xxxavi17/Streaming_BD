namespace Streaming_BD
{
    partial class Form2
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipoSub = new System.Windows.Forms.Label();
            this.lblDuracaoMeses = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();

            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtDuracaoMeses = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.cmbTipoSub = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();

            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.SuspendLayout();

            int textboxWidth = 250;
            int textboxHeight = 28;
            int formWidth = 800;
            int startY = 80;
            int spacingY = 60;
            int labelHeight = 22;
            int centerX = (formWidth - textboxWidth) / 2;

            // Título
            this.lblTitulo.Text = "Adicionar Cliente";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(centerX, startY - 60);
            this.Controls.Add(this.lblTitulo);

            // Nome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(centerX, startY);
            this.lblNome.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtNome.Location = new System.Drawing.Point(centerX, startY + labelHeight);
            this.txtNome.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.txtNome.PlaceholderText = "Ex: João Silva";

            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(centerX, startY + spacingY);
            this.lblEmail.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtEmail.Location = new System.Drawing.Point(centerX, startY + spacingY + labelHeight);
            this.txtEmail.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.txtEmail.PlaceholderText = "Ex: joao@email.com";

            // Data de Nascimento
            this.lblDataNascimento.Text = "Data de Nascimento:";
            this.lblDataNascimento.Location = new System.Drawing.Point(centerX, startY + 2 * spacingY);
            this.lblDataNascimento.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtDataNascimento.Location = new System.Drawing.Point(centerX, startY + 2 * spacingY + labelHeight);
            this.txtDataNascimento.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.txtDataNascimento.PlaceholderText = "Ex: 2000-01-01";

            // Sexo
            this.lblSexo.Text = "Género:";
            this.lblSexo.Location = new System.Drawing.Point(centerX, startY + 3 * spacingY);
            this.lblSexo.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbSexo.Location = new System.Drawing.Point(centerX, startY + 3 * spacingY + labelHeight);
            this.cmbSexo.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });

            // Tipo de Subscrição
            this.lblTipoSub.Text = "Tipo de Subscrição:";
            this.lblTipoSub.Location = new System.Drawing.Point(centerX, startY + 4 * spacingY);
            this.lblTipoSub.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblTipoSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cmbTipoSub.Location = new System.Drawing.Point(centerX, startY + 4 * spacingY + labelHeight);
            this.cmbTipoSub.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.cmbTipoSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSub.Items.AddRange(new object[] { "Standart", "Premium", "Sem Subscrição" });

            // Duração
            this.lblDuracaoMeses.Text = "Duração da Subscrição em meses:";
            this.lblDuracaoMeses.Location = new System.Drawing.Point(centerX, startY + 5 * spacingY);
            this.lblDuracaoMeses.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblDuracaoMeses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtDuracaoMeses.Location = new System.Drawing.Point(centerX, startY + 5 * spacingY + labelHeight);
            this.txtDuracaoMeses.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.txtDuracaoMeses.PlaceholderText = "Ex: 12";

            // Password
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(centerX, startY + 6 * spacingY);
            this.lblPassword.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtPassword.Location = new System.Drawing.Point(centerX, startY + 6 * spacingY + labelHeight);
            this.txtPassword.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            this.txtPassword.PasswordChar = '*';

            // Botão Adicionar
            this.btnAdicionar.Text = "Adicionar Cliente";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionar.Location = new System.Drawing.Point((formWidth - 180) / 2, startY + 7 * spacingY + labelHeight);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // Botão Menu Inicial
            this.btnMenuInicial.Location = new System.Drawing.Point(30, 30);
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);

            // Adiciona todos os controles
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblTipoSub);
            this.Controls.Add(this.cmbTipoSub);
            this.Controls.Add(this.lblDuracaoMeses);
            this.Controls.Add(this.txtDuracaoMeses);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnMenuInicial);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(formWidth, 950);
            this.Name = "Form2";
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoSub;
        private System.Windows.Forms.Label lblDuracaoMeses;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtDuracaoMeses;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.ComboBox cmbTipoSub;
        private System.Windows.Forms.ComboBox cmbSexo;

        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnAdicionar;
    }
}
