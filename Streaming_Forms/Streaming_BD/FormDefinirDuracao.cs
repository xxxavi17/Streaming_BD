using System;
using System.Windows.Forms;

namespace Streaming_BD
{
    public partial class FormDefinirDuracao : Form
    {
        public int DuracaoMeses { get; private set; } = 1;
        private NumericUpDown numericDuracao;
        private Button btnOk;
        private Button btnCancelar;

        public FormDefinirDuracao()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Definir Duração da Subscrição";
            this.Size = new System.Drawing.Size(320, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            var label = new Label();
            label.Text = "Duração (meses):";
            label.Location = new System.Drawing.Point(20, 20);
            label.Size = new System.Drawing.Size(120, 25);
            this.Controls.Add(label);

            numericDuracao = new NumericUpDown();
            numericDuracao.Minimum = 1;
            numericDuracao.Maximum = 60;
            numericDuracao.Value = 1;
            numericDuracao.Location = new System.Drawing.Point(150, 20);
            numericDuracao.Size = new System.Drawing.Size(100, 25);
            this.Controls.Add(numericDuracao);

            btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.Location = new System.Drawing.Point(50, 70);
            btnOk.Size = new System.Drawing.Size(80, 30);
            btnOk.Click += BtnOk_Click;
            this.Controls.Add(btnOk);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(150, 70);
            btnCancelar.Size = new System.Drawing.Size(80, 30);
            btnCancelar.Click += BtnCancelar_Click;
            this.Controls.Add(btnCancelar);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DuracaoMeses = (int)numericDuracao.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
