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
            btnVerSeries = new Button();
            btnFazerRating = new Button();
            btnAdicionarAtor = new Button();
            btnVerAtores = new Button();
            btnAssistirConteudo = new Button();
            btnVerVisualizacoes = new Button(); // NOVO

            // 
            // button1 (não usado)
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
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(230, 36);
            label5.Name = "label5";
            label5.Size = new Size(341, 41);
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

            // Layout
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
            // btnAdicionarAtor
            // 
            btnAdicionarAtor.Location = new Point(startX1, y1 + 3 * (buttonHeight + spacingY));
            btnAdicionarAtor.Size = new Size(buttonWidth, buttonHeight);
            btnAdicionarAtor.Text = "Adicionar Ator";
            btnAdicionarAtor.UseVisualStyleBackColor = true;
            btnAdicionarAtor.Click += new System.EventHandler(this.btnAdicionarAtor_Click);

            // 
            // btnVerAtores
            // 
            btnVerAtores.Location = new Point(startX2, y1 + 3 * (buttonHeight + spacingY));
            btnVerAtores.Size = new Size(buttonWidth, buttonHeight);
            btnVerAtores.Text = "Ver Lista de Atores";
            btnVerAtores.UseVisualStyleBackColor = true;
            btnVerAtores.Click += new System.EventHandler(this.btnVerAtores_Click);

            // 
            // btnAssistirConteudo
            // 
            btnAssistirConteudo.Location = new Point(startX1, y1 + 4 * (buttonHeight + spacingY));
            btnAssistirConteudo.Size = new Size(buttonWidth, buttonHeight);
            btnAssistirConteudo.Text = "Assistir Conteúdo";
            btnAssistirConteudo.UseVisualStyleBackColor = true;
            btnAssistirConteudo.Click += new System.EventHandler(this.btnAssistirConteudo_Click);

            // 
            // btnVerVisualizacoes (novo)
            // 
            btnVerVisualizacoes.Location = new Point(startX2, y1 + 4 * (buttonHeight + spacingY));
            btnVerVisualizacoes.Size = new Size(buttonWidth, buttonHeight);
            btnVerVisualizacoes.Text = "Ver Visualizações";
            btnVerVisualizacoes.UseVisualStyleBackColor = true;
            btnVerVisualizacoes.Click += new System.EventHandler(this.btnVerVisualizacoes_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Name = "Form1";
            this.Text = "Menu Inicial Streaming BD";
            this.StartPosition = FormStartPosition.CenterScreen;

            Controls.Clear();
            Controls.Add(label5);
            Controls.Add(lblOpcoes);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(btnVerClientes);
            Controls.Add(btnAdicionarConteudo);
            Controls.Add(btnVerConteudos);
            Controls.Add(btnVerSeries);
            Controls.Add(btnFazerRating);
            Controls.Add(btnAdicionarAtor);
            Controls.Add(btnVerAtores);
            Controls.Add(btnAssistirConteudo);
            Controls.Add(btnVerVisualizacoes); // novo

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
        private Button btnVerSeries;
        private Button btnFazerRating;
        private Button btnAdicionarAtor;
        private Button btnVerAtores;
        private Button btnAssistirConteudo;
        private Button btnVerVisualizacoes; // novo
    }
}
