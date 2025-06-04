namespace Streaming_BD
{
    partial class FormEditarEpisodio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.NumericUpDown numericNumero;
        private System.Windows.Forms.NumericUpDown numericDuracao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.numericNumero = new System.Windows.Forms.NumericUpDown();
            this.numericDuracao = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuracao)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblTitulo.AutoSize = true;

            // 
            // lblNumero
            // 
            this.lblNumero.Text = "Número do Episódio:";
            this.lblNumero.Location = new System.Drawing.Point(30, 80);
            this.lblNumero.AutoSize = true;

            // 
            // lblDuracao
            // 
            this.lblDuracao.Text = "Duração (min):";
            this.lblDuracao.Location = new System.Drawing.Point(30, 130);
            this.lblDuracao.AutoSize = true;

            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(180, 27);
            this.txtTitulo.Size = new System.Drawing.Size(250, 27);

            // 
            // numericNumero
            // 
            this.numericNumero.Location = new System.Drawing.Point(180, 77);
            this.numericNumero.Minimum = 1;
            this.numericNumero.Maximum = 1000;
            this.numericNumero.Size = new System.Drawing.Size(120, 27);

            // 
            // numericDuracao
            // 
            this.numericDuracao.Location = new System.Drawing.Point(180, 127);
            this.numericDuracao.Minimum = 1;
            this.numericDuracao.Maximum = 1000;
            this.numericDuracao.Size = new System.Drawing.Size(120, 27);

            // 
            // btnSalvar
            // 
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(80, 190);
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(220, 190);
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // FormEditarEpisodio
            // 
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.numericNumero);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.numericDuracao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FormEditarEpisodio";
            this.Text = "Editar Episódio";

            ((System.ComponentModel.ISupportInitialize)(this.numericNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
