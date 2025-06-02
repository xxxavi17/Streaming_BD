namespace Streaming_BD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Labels
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipoSub = new System.Windows.Forms.Label();
            this.lblDuracaoMeses = new System.Windows.Forms.Label();
            // TextBoxes
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtDuracaoMeses = new System.Windows.Forms.TextBox();
            // Centralização e layout
            int textboxWidth = 250;
            int textboxHeight = 28;
            // ComboBox Tipo de Subscrição
            this.cmbTipoSub = new System.Windows.Forms.ComboBox();
            this.cmbTipoSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSub.Items.Clear();
            this.cmbTipoSub.Items.AddRange(new object[] { "Standart", "Premium", "Sem Subscrição" });
            this.cmbTipoSub.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            // Buttons
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            // Título
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();

            // Centralização e layout (moved here to declare variables before use)
            int formWidth = this.ClientSize.Width > 0 ? this.ClientSize.Width : 500;
            int startY = 80;
            int spacingY = 60;
            int labelHeight = 22;
            // int textboxHeight = 28; // Removed duplicate declaration
            // int textboxWidth = 250; // Removed duplicate declaration
            int centerX = (formWidth - textboxWidth) / 2;

            this.SuspendLayout();
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(30, 30);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.TabIndex = 99;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            this.Controls.Add(this.btnMenuInicial);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(centerX + textboxWidth + 40, startY + 5 * spacingY + labelHeight);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 40);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar Cliente";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Adicionar Cliente";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // O título será centralizado dinamicamente após o layout dos campos
            this.Controls.Add(this.lblTitulo);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 950); // altura aumentada
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Form2";
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Centralização e layout
            formWidth = this.ClientSize.Width > 0 ? this.ClientSize.Width : 500;
            startY = 80;
            spacingY = 60;
            labelHeight = 22;
            textboxHeight = 28;
            textboxWidth = 250;
            centerX = (formWidth - textboxWidth) / 2;

            // ComboBox Tipo de Subscrição
            this.cmbTipoSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSub.Items.Clear();
            this.cmbTipoSub.Items.AddRange(new object[] { "Standart", "Premium", "Sem Subscrição" });
            this.cmbTipoSub.Size = new System.Drawing.Size(textboxWidth, textboxHeight);

            // Botão Adicionar Cliente à direita
            this.btnAdicionar.Location = new System.Drawing.Point(centerX + textboxWidth + 40, startY + 5 * spacingY + labelHeight);

            // Centraliza o título acima do formulário
            this.lblTitulo.Location = new System.Drawing.Point(centerX, startY - 60);

            // Nome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(centerX, startY);
            this.lblNome.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNome.Location = new System.Drawing.Point(centerX, startY + labelHeight);
            this.txtNome.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(centerX, startY + spacingY);
            this.lblEmail.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Location = new System.Drawing.Point(centerX, startY + spacingY + labelHeight);
            this.txtEmail.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            // Data de Nascimento
            this.lblDataNascimento.Text = "Data de Nascimento:";
            this.lblDataNascimento.Location = new System.Drawing.Point(centerX, startY + 2 * spacingY);
            this.lblDataNascimento.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDataNascimento.Location = new System.Drawing.Point(centerX, startY + 2 * spacingY + labelHeight);
            this.txtDataNascimento.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
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
            // Duração em meses
            this.lblDuracaoMeses.Text = "Duração da Subscrição em meses:";
            this.lblDuracaoMeses.Location = new System.Drawing.Point(centerX, startY + 5 * spacingY);
            this.lblDuracaoMeses.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblDuracaoMeses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDuracaoMeses.Location = new System.Drawing.Point(centerX, startY + 5 * spacingY + labelHeight);
            this.txtDuracaoMeses.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
            // Adiciona controles ao formulário (labels e campos)
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

            // Remove qualquer botão duplicado de adicionar cliente
            if (this.Controls.Contains(this.btnAdicionar))
                this.Controls.Remove(this.btnAdicionar);
            // Cria e adiciona apenas um botão de adicionar cliente centralizado
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAdicionar.Text = "Adicionar Cliente";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 40);
            // Centralizar o botão horizontalmente abaixo dos campos
            this.btnAdicionar.Location = new System.Drawing.Point((formWidth - 180) / 2, startY + 7 * spacingY + labelHeight);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.TabIndex = 101;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.Controls.Add(this.btnAdicionar);

            // Placeholders para os campos de preenchimento
            this.txtNome.PlaceholderText = "Ex: João Silva";
            this.txtEmail.PlaceholderText = "Ex: joao@email.com";
            this.txtDataNascimento.PlaceholderText = "Ex: 2000-01-01";
            this.txtDuracaoMeses.PlaceholderText = "Ex: 12";
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoSub;
        private System.Windows.Forms.Label lblDuracaoMeses;
        private System.Windows.Forms.TextBox txtDuracaoMeses;
        private System.Windows.Forms.ComboBox cmbTipoSub;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}
