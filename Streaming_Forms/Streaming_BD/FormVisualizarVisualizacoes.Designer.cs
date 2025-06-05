namespace Streaming_BD
{
    partial class FormVisualizarVisualizacoes
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewVisualizacoes;
        private Button btnFechar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewVisualizacoes = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisualizacoes
            // 
            this.dataGridViewVisualizacoes.AllowUserToAddRows = false;
            this.dataGridViewVisualizacoes.AllowUserToDeleteRows = false;
            this.dataGridViewVisualizacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisualizacoes.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewVisualizacoes.Name = "dataGridViewVisualizacoes";
            this.dataGridViewVisualizacoes.ReadOnly = true;
            this.dataGridViewVisualizacoes.RowHeadersWidth = 51;
            this.dataGridViewVisualizacoes.RowTemplate.Height = 29;
            this.dataGridViewVisualizacoes.Size = new System.Drawing.Size(740, 350);
            this.dataGridViewVisualizacoes.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(340, 390);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 30);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormVisualizarVisualizacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 440);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dataGridViewVisualizacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormVisualizarVisualizacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizações de Conteúdos por Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizacoes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
