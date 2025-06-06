namespace Streaming_BD
{
    partial class FormEditarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.checkBoxPremium = new System.Windows.Forms.CheckBox();
            this.checkBoxStandart = new System.Windows.Forms.CheckBox();
            this.checkBoxSemSub = new System.Windows.Forms.CheckBox();
            this.labelSubscricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 50);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 23);
            this.textBoxEmail.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(120, 180);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(90, 30);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(230, 180);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(30, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(200, 30);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Editar Cliente";
            // 
            // checkBoxPremium
            // 
            this.checkBoxPremium.AutoSize = true;
            this.checkBoxPremium.Location = new System.Drawing.Point(180, 100);
            this.checkBoxPremium.Name = "checkBoxPremium";
            this.checkBoxPremium.Size = new System.Drawing.Size(70, 19);
            this.checkBoxPremium.TabIndex = 9;
            this.checkBoxPremium.Text = "Premium";
            this.checkBoxPremium.UseVisualStyleBackColor = true;
            this.checkBoxPremium.CheckedChanged += new System.EventHandler(this.CheckBoxSubscricao_CheckedChanged);
            // 
            // checkBoxStandart
            // 
            this.checkBoxStandart.AutoSize = true;
            this.checkBoxStandart.Location = new System.Drawing.Point(180, 125);
            this.checkBoxStandart.Name = "checkBoxStandart";
            this.checkBoxStandart.Size = new System.Drawing.Size(70, 19);
            this.checkBoxStandart.TabIndex = 10;
            this.checkBoxStandart.Text = "Standart";
            this.checkBoxStandart.UseVisualStyleBackColor = true;
            this.checkBoxStandart.CheckedChanged += new System.EventHandler(this.CheckBoxSubscricao_CheckedChanged);
            // 
            // checkBoxSemSub
            // 
            this.checkBoxSemSub.AutoSize = true;
            this.checkBoxSemSub.Location = new System.Drawing.Point(180, 150);
            this.checkBoxSemSub.Name = "checkBoxSemSub";
            this.checkBoxSemSub.Size = new System.Drawing.Size(120, 19);
            this.checkBoxSemSub.TabIndex = 11;
            this.checkBoxSemSub.Text = "Sem Subscrição";
            this.checkBoxSemSub.UseVisualStyleBackColor = true;
            this.checkBoxSemSub.CheckedChanged += new System.EventHandler(this.CheckBoxSubscricao_CheckedChanged);
            // 
            // labelSubscricao
            // 
            this.labelSubscricao.AutoSize = true;
            this.labelSubscricao.Location = new System.Drawing.Point(30, 73);
            this.labelSubscricao.Name = "labelSubscricao";
            this.labelSubscricao.Size = new System.Drawing.Size(67, 15);
            this.labelSubscricao.TabIndex = 4;
            this.labelSubscricao.Text = "Subscrição";
            // 
            // FormEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 240);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelSubscricao);
            this.Controls.Add(this.checkBoxSemSub);
            this.Controls.Add(this.checkBoxStandart);
            this.Controls.Add(this.checkBoxPremium);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.CheckBox checkBoxPremium;
        private System.Windows.Forms.CheckBox checkBoxStandart;
        private System.Windows.Forms.CheckBox checkBoxSemSub;
        private System.Windows.Forms.Label labelSubscricao;
    }
}
