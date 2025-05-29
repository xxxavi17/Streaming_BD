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
            // TextBoxes
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            // Buttons
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVerListaClientes = new System.Windows.Forms.Button();
            // Título
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(50, 400);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(200, 40);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVerListaClientes
            // 
            this.btnVerListaClientes.Location = new System.Drawing.Point(50, 450);
            this.btnVerListaClientes.Name = "btnVerListaClientes";
            this.btnVerListaClientes.Size = new System.Drawing.Size(200, 40);
            this.btnVerListaClientes.TabIndex = 7;
            this.btnVerListaClientes.Text = "Ver Lista de Clientes";
            this.btnVerListaClientes.UseVisualStyleBackColor = true;
            this.btnVerListaClientes.Click += new System.EventHandler(this.btnVerListaClientes_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Adicionar Cliente";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point((this.ClientSize.Width - 300) / 2, 20);
            this.lblTitulo.Size = new System.Drawing.Size(300, 40);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblTitulo);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnVerListaClientes);
            this.Name = "Form2";
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Centralização e layout
            int formWidth = this.ClientSize.Width > 0 ? this.ClientSize.Width : 500;
            int startY = 80;
            int spacingY = 60;
            int labelHeight = 22;
            int textboxHeight = 28;
            int textboxWidth = 250;
            int centerX = (formWidth - textboxWidth) / 2;

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
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Location = new System.Drawing.Point(centerX, startY + 3 * spacingY);
            this.lblSexo.Size = new System.Drawing.Size(textboxWidth, labelHeight);
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSexo.Location = new System.Drawing.Point(centerX, startY + 3 * spacingY + labelHeight);
            this.txtSexo.Size = new System.Drawing.Size(textboxWidth, textboxHeight);

            // Adiciona controles ao formulário
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtSexo);

            // Botão Menu Inicial
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.Location = new System.Drawing.Point((this.ClientSize.Width - 120) / 2, 350);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.TabIndex = 100;
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            this.Controls.Add(this.btnMenuInicial);
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
        private System.Windows.Forms.Button btnVerListaClientes;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
