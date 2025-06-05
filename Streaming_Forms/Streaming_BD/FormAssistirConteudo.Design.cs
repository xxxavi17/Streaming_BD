namespace Streaming_BD
{
    partial class FormAssistirConteudo
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCliente;
        private Label lblConteudo;
        private ComboBox comboCliente;
        private ComboBox comboConteudo;
        private Button btnRegistrar;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblCliente = new Label();
            this.lblConteudo = new Label();
            this.comboCliente = new ComboBox();
            this.comboConteudo = new ComboBox();
            this.btnRegistrar = new Button();
            this.btnCancelar = new Button();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Text = "Registrar Visualização";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(100, 20);
            this.lblTitulo.AutoSize = true;

            // lblCliente
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Location = new System.Drawing.Point(40, 80);
            this.comboCliente.Location = new System.Drawing.Point(150, 80);
            this.comboCliente.Size = new System.Drawing.Size(250, 28);
            this.comboCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblConteudo
            this.lblConteudo.Text = "Conteúdo:";
            this.lblConteudo.Location = new System.Drawing.Point(40, 130);
            this.comboConteudo.Location = new System.Drawing.Point(150, 130);
            this.comboConteudo.Size = new System.Drawing.Size(250, 28);
            this.comboConteudo.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnRegistrar
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Location = new System.Drawing.Point(100, 200);
            this.btnRegistrar.Size = new System.Drawing.Size(120, 40);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(240, 200);
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FormAssistirConteudo
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.comboConteudo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Text = "Assistir Conteúdo";
            this.StartPosition = FormStartPosition.CenterParent;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
