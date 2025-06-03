namespace Streaming_BD
{
    partial class FormEditarFilme
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblProdutora;
        private System.Windows.Forms.TextBox txtProdutora;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private void InitializeComponent()
        {
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblTituloForm.Text = "Editar Filme";
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloForm.Location = new System.Drawing.Point(0, 20);
            this.lblTituloForm.Size = new System.Drawing.Size(500, 40);
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblTituloForm);
            // Título
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Location = new System.Drawing.Point(40, 80);
            this.lblTitulo.Size = new System.Drawing.Size(100, 25);
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtTitulo.Location = new System.Drawing.Point(180, 80);
            this.txtTitulo.Size = new System.Drawing.Size(250, 27);
            // Género
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblGenero.Text = "Género:";
            this.lblGenero.Location = new System.Drawing.Point(40, 120);
            this.lblGenero.Size = new System.Drawing.Size(100, 25);
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtGenero.Location = new System.Drawing.Point(180, 120);
            this.txtGenero.Size = new System.Drawing.Size(250, 27);
            // Produtora
            this.lblProdutora = new System.Windows.Forms.Label();
            this.lblProdutora.Text = "Produtora:";
            this.lblProdutora.Location = new System.Drawing.Point(40, 160);
            this.lblProdutora.Size = new System.Drawing.Size(100, 25);
            this.txtProdutora = new System.Windows.Forms.TextBox();
            this.txtProdutora.Location = new System.Drawing.Point(180, 160);
            this.txtProdutora.Size = new System.Drawing.Size(250, 27);
            // Duração
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblDuracao.Text = "Duração (min):";
            this.lblDuracao.Location = new System.Drawing.Point(40, 200);
            this.lblDuracao.Size = new System.Drawing.Size(120, 25);
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.numDuracao.Location = new System.Drawing.Point(180, 200);
            this.numDuracao.Size = new System.Drawing.Size(100, 27);
            this.numDuracao.Minimum = 1;
            this.numDuracao.Maximum = 600;
            // Botão Guardar
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(120, 270);
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // Botão Cancelar
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(260, 270);
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // Adicionar controles
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblProdutora);
            this.Controls.Add(this.txtProdutora);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.numDuracao);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Name = "FormEditarFilme";
            this.Text = "Editar Filme";
        }
    }
}
