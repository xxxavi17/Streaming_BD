namespace Streaming_BD
{
    partial class FormEditarTemporada
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown numericNumero;
        private System.Windows.Forms.NumericUpDown numericAno;
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
            this.lblAno = new System.Windows.Forms.Label();
            this.numericNumero = new System.Windows.Forms.NumericUpDown();
            this.numericAno = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();

            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Editar Temporada";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(100, 20);

            // 
            // lblNumero
            // 
            this.lblNumero.Text = "Número da Temporada:";
            this.lblNumero.Location = new System.Drawing.Point(30, 80);
            this.lblNumero.AutoSize = true;

            // 
            // lblAno
            // 
            this.lblAno.Text = "Ano:";
            this.lblAno.Location = new System.Drawing.Point(30, 130);
            this.lblAno.AutoSize = true;

            // 
            // numericNumero
            // 
            this.numericNumero.Location = new System.Drawing.Point(220, 75);
            this.numericNumero.Minimum = 1;
            this.numericNumero.Maximum = 100;
            this.numericNumero.Size = new System.Drawing.Size(120, 27);

            // 
            // numericAno
            // 
            this.numericAno.Location = new System.Drawing.Point(220, 125);
            this.numericAno.Minimum = 1900;
            this.numericAno.Maximum = 2100;
            this.numericAno.Size = new System.Drawing.Size(120, 27);

            // 
            // btnSalvar
            // 
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(60, 190);
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(200, 190);
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // FormEditarTemporada
            // 
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.numericNumero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.numericAno);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FormEditarTemporada";
            this.Text = "Editar Temporada";

            ((System.ComponentModel.ISupportInitialize)(this.numericNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
