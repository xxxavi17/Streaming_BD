namespace Streaming_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label5 = new Label();
            btnAdicionarCliente = new Button();
            btnVerClientes = new Button();
            btnAdicionarConteudo = new Button();
            btnVerConteudos = new Button();
            lblOpcoes = new Label();
            btnEditarSeries = new Button();

            // 
            // button1
            // 
            button1.Location = new Point(364, 358);
            button1.Name = "button1";
            button1.Size = new Size(102, 61);
            button1.TabIndex = 0;
            button1.Text = "Registar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 36);
            label5.Name = "label5";
            label5.Size = new Size(241, 41);
            label5.TabIndex = 12;
            label5.Text = "Menu Inicial Streaming BD";

            // lblOpcoes (Opções)
            lblOpcoes.AutoSize = true;
            lblOpcoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpcoes.Location = new Point(50, 100);
            lblOpcoes.Name = "lblOpcoes";
            lblOpcoes.Size = new Size(90, 28);
            lblOpcoes.TabIndex = 0;
            lblOpcoes.Text = "Opções:";

            // Posição dos botões em duas colunas
            int buttonWidth = 180;
            int buttonHeight = 40;
            int spacingY = 20;
            int startX1 = 100;
            int startX2 = startX1 + buttonWidth + 60;
            int y1 = lblOpcoes.Location.Y + lblOpcoes.Height + 40;

            this.btnAdicionarCliente.Location = new System.Drawing.Point(startX1, y1);
            this.btnVerClientes.Location = new System.Drawing.Point(startX1, y1 + buttonHeight + spacingY);
            this.btnAdicionarConteudo.Location = new System.Drawing.Point(startX2, y1);
            this.btnVerConteudos.Location = new System.Drawing.Point(startX2, y1 + buttonHeight + spacingY);
            this.btnEditarSeries.Location = new System.Drawing.Point(startX1, y1 + 2 * (buttonHeight + spacingY));

            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnAdicionarCliente.Text = "Adicionar Cliente";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);

            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnVerClientes.Text = "Ver Lista de Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);

            // 
            // btnAdicionarConteudo
            // 
            this.btnAdicionarConteudo.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnAdicionarConteudo.Text = "Adicionar Conteúdo";
            this.btnAdicionarConteudo.UseVisualStyleBackColor = true;
            this.btnAdicionarConteudo.Click += new System.EventHandler(this.btnAdicionarConteudo_Click);

            // 
            // btnVerConteudos
            // 
            this.btnVerConteudos.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnVerConteudos.Text = "Ver Lista de Conteúdos";
            this.btnVerConteudos.UseVisualStyleBackColor = true;
            this.btnVerConteudos.Click += new System.EventHandler(this.btnVerConteudos_Click);

            // 
            // btnEditarSeries
            // 
            this.btnEditarSeries.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnEditarSeries.Text = "Editar Séries";
            this.btnEditarSeries.UseVisualStyleBackColor = true;
            this.btnEditarSeries.Click += new System.EventHandler(this.btnEditarSeries_Click);

            // Controls
            Controls.Clear();
            Controls.Add(label5);
            Controls.Add(lblOpcoes);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(btnVerClientes);
            Controls.Add(btnAdicionarConteudo);
            Controls.Add(btnVerConteudos);
            Controls.Add(btnEditarSeries);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Menu Inicial Streaming BD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Button btnAdicionarCliente;
        private Button btnVerClientes;
        private Button btnAdicionarConteudo;
        private Button btnVerConteudos;
        private Label lblOpcoes;
        private Button btnEditarSeries;
    }
}
