using System.Windows.Forms;

namespace Streaming_BD
{
    partial class FormFazerRating
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCliente;
        private Label lblClienteValor;
        private ComboBox comboConteudo;
        private Label lblConteudo;
        private Label lblRating;
        private NumericUpDown numRating;
        private Button btnFazerRating;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblTitulo.Text = "Fazer um Rating";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(120, 20);

            this.lblCliente = new Label();
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Location = new System.Drawing.Point(40, 80);
            this.lblCliente.Size = new System.Drawing.Size(100, 25);

            this.lblClienteValor = new Label();
            this.lblClienteValor.Text = ""; // será preenchido no construtor com o nome do cliente
            this.lblClienteValor.Location = new System.Drawing.Point(180, 80);
            this.lblClienteValor.Size = new System.Drawing.Size(250, 25);

            this.lblConteudo = new Label();
            this.lblConteudo.Text = "Conteúdo:";
            this.lblConteudo.Location = new System.Drawing.Point(40, 130);
            this.lblConteudo.Size = new System.Drawing.Size(100, 25);

            this.comboConteudo = new ComboBox();
            this.comboConteudo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboConteudo.Location = new System.Drawing.Point(180, 130);
            this.comboConteudo.Size = new System.Drawing.Size(250, 28);

            this.lblRating = new Label();
            this.lblRating.Text = "Estrelas (1 a 5):";
            this.lblRating.Location = new System.Drawing.Point(40, 180);
            this.lblRating.Size = new System.Drawing.Size(120, 25);

            this.numRating = new NumericUpDown();
            this.numRating.DecimalPlaces = 0;
            this.numRating.Increment = 1M;
            this.numRating.Minimum = 1M;
            this.numRating.Maximum = 5M;
            this.numRating.Location = new System.Drawing.Point(180, 180);
            this.numRating.Size = new System.Drawing.Size(100, 27);

            this.btnFazerRating = new Button();
            this.btnFazerRating.Text = "Fazer Rating";
            this.btnFazerRating.Location = new System.Drawing.Point(100, 240);
            this.btnFazerRating.Size = new System.Drawing.Size(120, 40);
            this.btnFazerRating.Click += new System.EventHandler(this.btnFazerRating_Click);

            this.btnCancelar = new Button();
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(260, 240);
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblClienteValor);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.comboConteudo);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.btnFazerRating);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FormFazerRating";
            this.Text = "Fazer um Rating";
        }
    }
}
