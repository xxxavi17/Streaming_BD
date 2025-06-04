namespace Streaming_BD
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            label5 = new Label();
            btnAdicionarCliente = new Button();
            btnVerClientes = new Button();
            btnAdicionarConteudo = new Button();
            btnVerConteudos = new Button();
            lblOpcoes = new Label();
            btnVerSeries = new Button(); // novo botão
            btnFazerRating = new Button();

            // 
            // button1 (não utilizado no momento)
            // 
            button1.Location = new Point(364, 358);
            button1.Name = "button1";
            button1.Size = new Size(102, 61);
            button1.TabIndex = 0;
            button1.Text = "Registar";
            button1.UseVisualStyleBackColor = true;

            // 
            // label5 (título)
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 36);
            label5.Name = "label5";
            label5.Size = new Size(241, 41);
            label5.TabIndex = 12;
            label5.Text = "Menu Inicial Streaming BD";

            // 
            // lblOpcoes
            // 
            lblOpcoes.AutoSize = true;
            lblOpcoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpcoes.Location = new Point(50, 100);
            lblOpcoes.Name = "lblOpcoes";
            lblOpcoes.Size = new Size(90, 28);
            lblOpcoes.TabIndex = 0;
            lblOpcoes.Text = "Opções:";

            // Posições
            int buttonWidth = 180;
            int buttonHeight = 40;
            int spacingY = 20;
            int startX1 = 100;
            int startX2 = startX1 + buttonWidth + 60;
            int y1 = lblOpcoes.Location.Y + lblOpcoes.Height + 40;

            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.Location = new Point(startX1, y1);
            btnAdicionarCliente.Size = new Size(buttonWidth, buttonHeight);
            btnAdicionarCliente.Text = "Adicionar Cliente";
            btnAdicionarCliente.UseVisualStyleBackColor = true;
            btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);

            // 
            // btnVerClientes
            // 
            btnVerClientes.Location = new Point(startX1, y1 + buttonHeight + spacingY);
            btnVerClientes.Size = new Size(buttonWidth, buttonHeight);
            btnVerClientes.Text = "Ver Lista de Clientes";
            btnVerClientes.UseVisualStyleBackColor = true;
            btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);

            // 
            // btnAdicionarConteudo
            // 
            btnAdicionarConteudo.Location = new Point(startX2, y1);
            btnAdicionarConteudo.Size = new Size(buttonWidth, buttonHeight);
            btnAdicionarConteudo.Text = "Adicionar Conteúdo";
            btnAdicionarConteudo.UseVisualStyleBackColor = true;
            btnAdicionarConteudo.Click += new System.EventHandler(this.btnAdicionarConteudo_Click);

            // 
            // btnVerConteudos
            // 
            btnVerConteudos.Location = new Point(startX2, y1 + buttonHeight + spacingY);
            btnVerConteudos.Size = new Size(buttonWidth, buttonHeight);
            btnVerConteudos.Text = "Ver Lista de Filmes";
            btnVerConteudos.UseVisualStyleBackColor = true;
            btnVerConteudos.Click += new System.EventHandler(this.btnVerConteudos_Click);

            // 
            // btnVerSeries
            // 
            btnVerSeries.Location = new Point(startX1, y1 + 2 * (buttonHeight + spacingY));
            btnVerSeries.Size = new Size(buttonWidth, buttonHeight);
            btnVerSeries.Text = "Ver Lista de Séries";
            btnVerSeries.UseVisualStyleBackColor = true;
            btnVerSeries.Click += new System.EventHandler(this.btnVerSeries_Click);

            // 
            // btnFazerRating
            // 
            btnFazerRating.Location = new Point(startX2, y1 + 2 * (buttonHeight + spacingY));
            btnFazerRating.Size = new Size(buttonWidth, buttonHeight);
            btnFazerRating.Text = "Fazer Rating";
            btnFazerRating.UseVisualStyleBackColor = true;
            btnFazerRating.Click += new System.EventHandler(this.btnFazerRating_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Name = "Form1";
            this.Text = "Menu Inicial Streaming BD";

            // Controles
            Controls.Clear();
            Controls.Add(label5);
            Controls.Add(lblOpcoes);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(btnVerClientes);
            Controls.Add(btnAdicionarConteudo);
            Controls.Add(btnVerConteudos);
            Controls.Add(btnVerSeries); // novo
            Controls.Add(btnFazerRating);

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
        private Button btnVerSeries; // novo
        private Button btnFazerRating;
    }
}
