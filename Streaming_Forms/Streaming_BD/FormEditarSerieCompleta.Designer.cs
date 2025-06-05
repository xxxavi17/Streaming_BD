namespace Streaming_BD
{
    partial class FormEditarSerieCompleta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTemporadas;
        private System.Windows.Forms.Button btnAdicionarTemporada;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRemoverTemporada;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flowLayoutPanelTemporadas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdicionarTemporada = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRemoverTemporada = new System.Windows.Forms.Button();

            // 
            // flowLayoutPanelTemporadas
            // 
            this.flowLayoutPanelTemporadas.AutoScroll = true;
            this.flowLayoutPanelTemporadas.Location = new System.Drawing.Point(20, 80);
            this.flowLayoutPanelTemporadas.Name = "flowLayoutPanelTemporadas";
            this.flowLayoutPanelTemporadas.Size = new System.Drawing.Size(1040, 540);
            this.flowLayoutPanelTemporadas.TabIndex = 0;
            this.flowLayoutPanelTemporadas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnAdicionarTemporada
            // 
            this.btnAdicionarTemporada.Location = new System.Drawing.Point(20, 640);
            this.btnAdicionarTemporada.Name = "btnAdicionarTemporada";
            this.btnAdicionarTemporada.Size = new System.Drawing.Size(200, 40);
            this.btnAdicionarTemporada.TabIndex = 1;
            this.btnAdicionarTemporada.Text = "Adicionar Temporada";
            this.btnAdicionarTemporada.UseVisualStyleBackColor = true;
            this.btnAdicionarTemporada.Click += new System.EventHandler(this.btnAdicionarTemporada_Click);

            // 
            // btnRemoverTemporada
            // 
            this.btnRemoverTemporada.Location = new System.Drawing.Point(240, 640);
            this.btnRemoverTemporada.Name = "btnRemoverTemporada";
            this.btnRemoverTemporada.Size = new System.Drawing.Size(200, 40);
            this.btnRemoverTemporada.TabIndex = 4;
            this.btnRemoverTemporada.Text = "Remover Temporada";
            this.btnRemoverTemporada.UseVisualStyleBackColor = true;
            this.btnRemoverTemporada.Click += new System.EventHandler(this.btnRemoverTemporada_Click);


            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(860, 640);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(200, 40);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(360, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 41);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Editar Série: Temporadas";

            // 
            // FormEditarSerieCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAdicionarTemporada);
            this.Controls.Add(this.flowLayoutPanelTemporadas);
            this.Controls.Add(this.btnRemoverTemporada);
            this.Name = "FormEditarSerieCompleta";
            this.Text = "Edição Completa de Série";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
