namespace Streaming_BD
{
    partial class FormVerAtores
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvAtores;
        private System.Windows.Forms.Button btnMenuInicial;
        private System.Windows.Forms.Button btnEditarAtor;
        private System.Windows.Forms.Button btnRemoverAtor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboFiltroSexo;
        private System.Windows.Forms.Label lblFiltroSexo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAtores = new System.Windows.Forms.DataGridView();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnEditarAtor = new System.Windows.Forms.Button();
            this.btnRemoverAtor = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboFiltroSexo = new System.Windows.Forms.ComboBox();
            this.lblFiltroSexo = new System.Windows.Forms.Label();

            // 
            // FormVerAtores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Lista de Atores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.FormVerAtores_Resize);

            // 
            // lblTitulo
            // 
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo.Text = "Lista de Atores";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(400, 20);
            this.Controls.Add(this.lblTitulo);

            // 
            // lblFiltroSexo
            // 
            this.lblFiltroSexo = new System.Windows.Forms.Label();
            this.lblFiltroSexo.Text = "Filtrar por sexo:";
            this.lblFiltroSexo.AutoSize = true;
            this.lblFiltroSexo.Location = new System.Drawing.Point(680, 30);
            this.Controls.Add(this.lblFiltroSexo);

            // 
            // comboFiltroSexo
            // 
            this.comboFiltroSexo = new System.Windows.Forms.ComboBox();
            this.comboFiltroSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltroSexo.Items.AddRange(new object[] { "Todos", "Masculino", "Feminino", "Outro" });
            this.comboFiltroSexo.SelectedIndex = 0;
            this.comboFiltroSexo.Location = new System.Drawing.Point(800, 25);
            this.comboFiltroSexo.Size = new System.Drawing.Size(150, 28);
            this.comboFiltroSexo.SelectedIndexChanged += new System.EventHandler(this.comboFiltroSexo_SelectedIndexChanged);
            this.Controls.Add(this.comboFiltroSexo);

            // 
            // dgvAtores
            // 
            this.dgvAtores = new System.Windows.Forms.DataGridView();
            this.dgvAtores.Location = new System.Drawing.Point(30, 70);
            this.dgvAtores.Size = new System.Drawing.Size(940, 400);
            this.dgvAtores.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvAtores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtores.ReadOnly = true;
            this.dgvAtores.AllowUserToAddRows = false;
            this.dgvAtores.AllowUserToDeleteRows = false;
            this.Controls.Add(this.dgvAtores);

            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.Location = new System.Drawing.Point(30, 500);
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            this.Controls.Add(this.btnMenuInicial);

            // 
            // btnEditarAtor
            // 
            this.btnEditarAtor = new System.Windows.Forms.Button();
            this.btnEditarAtor.Text = "Editar Ator";
            this.btnEditarAtor.Location = new System.Drawing.Point(180, 500);
            this.btnEditarAtor.Size = new System.Drawing.Size(150, 35);
            this.btnEditarAtor.Click += new System.EventHandler(this.btnEditarAtor_Click);
            this.Controls.Add(this.btnEditarAtor);

            // 
            // btnRemoverAtor
            // 
            this.btnRemoverAtor = new System.Windows.Forms.Button();
            this.btnRemoverAtor.Text = "Remover Ator";
            this.btnRemoverAtor.Location = new System.Drawing.Point(350, 500);
            this.btnRemoverAtor.Size = new System.Drawing.Size(150, 35);
            this.btnRemoverAtor.Click += new System.EventHandler(this.btnRemoverAtor_Click);
            this.Controls.Add(this.btnRemoverAtor);

            // 
            // Finalizar
            // 
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
