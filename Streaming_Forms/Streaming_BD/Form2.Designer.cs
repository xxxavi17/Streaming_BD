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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVerListaClientes = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 27);
            this.txtNome.TabIndex = 0;
            this.txtNome.PlaceholderText = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.PlaceholderText = "Email";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(50, 150);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(200, 27);
            this.txtDataNascimento.TabIndex = 2;
            this.txtDataNascimento.PlaceholderText = "Data de Nascimento";
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
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(50, 200);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(200, 27);
            this.txtSexo.TabIndex = 3;
            this.txtSexo.PlaceholderText = "Sexo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.btnMenuInicial);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnVerListaClientes);
            this.Controls.Add(this.txtSexo);
            this.Name = "Form2";
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVerListaClientes;
        private System.Windows.Forms.TextBox txtSexo;
    }
}
