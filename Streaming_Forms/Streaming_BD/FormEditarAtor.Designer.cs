namespace Streaming_BD
{
    partial class FormEditarAtor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxNome = new TextBox();
            this.textBoxIdade = new TextBox();
            this.comboBoxSexo = new ComboBox();
            this.buttonGuardar = new Button();
            this.buttonCancelar = new Button();
            this.labelTitulo = new Label();
            this.labelNome = new Label();
            this.labelIdade = new Label();
            this.labelSexo = new Label();
            this.checkedListBoxConteudos = new CheckedListBox();
            this.labelConteudos = new Label();

            this.SuspendLayout();

            // textBoxNome
            this.textBoxNome.Location = new System.Drawing.Point(130, 50);
            this.textBoxNome.Size = new System.Drawing.Size(200, 27);
            this.textBoxNome.PlaceholderText = "Nome do ator";

            // textBoxIdade
            this.textBoxIdade.Location = new System.Drawing.Point(130, 100);
            this.textBoxIdade.Size = new System.Drawing.Size(100, 27);
            this.textBoxIdade.PlaceholderText = "Idade";

            // comboBoxSexo
            this.comboBoxSexo.Location = new System.Drawing.Point(130, 150);
            this.comboBoxSexo.Size = new System.Drawing.Size(150, 28);
            this.comboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSexo.Items.AddRange(new object[] { "Masculino", "Feminino"});

            // labelTitulo
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(30, 10);
            this.labelTitulo.Text = "Editar Ator";

            // labelNome
            this.labelNome.Location = new System.Drawing.Point(30, 50);
            this.labelNome.Text = "Nome:";
            this.labelNome.AutoSize = true;

            // labelIdade
            this.labelIdade.Location = new System.Drawing.Point(30, 100);
            this.labelIdade.Text = "Idade:";
            this.labelIdade.AutoSize = true;

            // labelSexo
            this.labelSexo.Location = new System.Drawing.Point(30, 150);
            this.labelSexo.Text = "Sexo:";
            this.labelSexo.AutoSize = true;

            // labelConteudos
            this.labelConteudos.Location = new System.Drawing.Point(30, 200);
            this.labelConteudos.Text = "Conteúdos Associados:";
            this.labelConteudos.AutoSize = true;

            // checkedListBoxConteudos
            this.checkedListBoxConteudos.Location = new System.Drawing.Point(30, 225);
            this.checkedListBoxConteudos.Size = new System.Drawing.Size(300, 120);
            this.checkedListBoxConteudos.CheckOnClick = true;

            // buttonGuardar
            this.buttonGuardar.Location = new System.Drawing.Point(60, 360);
            this.buttonGuardar.Size = new System.Drawing.Size(100, 35);
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);

            // buttonCancelar
            this.buttonCancelar.Location = new System.Drawing.Point(180, 360);
            this.buttonCancelar.Size = new System.Drawing.Size(100, 35);
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);

            // FormEditarAtor
            this.ClientSize = new System.Drawing.Size(380, 420);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.labelConteudos);
            this.Controls.Add(this.checkedListBoxConteudos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Editar Ator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxIdade;
        private ComboBox comboBoxSexo;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private Label labelTitulo;
        private Label labelNome;
        private Label labelIdade;
        private Label labelSexo;
        private CheckedListBox checkedListBoxConteudos;
        private Label labelConteudos;
    }
}
