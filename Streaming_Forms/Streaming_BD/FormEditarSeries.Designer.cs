namespace Streaming_BD
{
    partial class FormEditarSeries
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
        private void InitializeComponent()
        {
            this.comboSeries = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNumeroTemporada = new System.Windows.Forms.Label();
            this.txtNumeroTemporada = new System.Windows.Forms.TextBox();
            this.lblAnoTemporada = new System.Windows.Forms.Label();
            this.txtAnoTemporada = new System.Windows.Forms.TextBox();
            this.btnAdicionarTemporada = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSeries
            // 
            this.comboSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeries.Location = new System.Drawing.Point(180, 30);
            this.comboSeries.Name = "comboSeries";
            this.comboSeries.Size = new System.Drawing.Size(250, 28);
            // 
            // lblSerie
            // 
            this.lblSerie.Text = "Série:";
            this.lblSerie.Location = new System.Drawing.Point(30, 30);
            // 
            // lblNumeroTemporada
            // 
            this.lblNumeroTemporada.Text = "Nº Temporada:";
            this.lblNumeroTemporada.Location = new System.Drawing.Point(30, 80);
            // 
            // txtNumeroTemporada
            // 
            this.txtNumeroTemporada.Location = new System.Drawing.Point(180, 80);
            // 
            // lblAnoTemporada
            // 
            this.lblAnoTemporada.Text = "Ano Temporada:";
            this.lblAnoTemporada.Location = new System.Drawing.Point(30, 130);
            // 
            // txtAnoTemporada
            // 
            this.txtAnoTemporada.Location = new System.Drawing.Point(180, 130);
            // 
            // btnAdicionarTemporada
            // 
            this.btnAdicionarTemporada.Text = "Adicionar Temporada";
            this.btnAdicionarTemporada.Location = new System.Drawing.Point(180, 180);
            this.btnAdicionarTemporada.Size = new System.Drawing.Size(180, 40);
            // 
            // btnMenuInicial
            // 
            this.btnMenuInicial.Location = new System.Drawing.Point(20, 20);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.TabIndex = 99;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // 
            // FormEditarSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.comboSeries);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblNumeroTemporada);
            this.Controls.Add(this.txtNumeroTemporada);
            this.Controls.Add(this.lblAnoTemporada);
            this.Controls.Add(this.txtAnoTemporada);
            this.Controls.Add(this.btnAdicionarTemporada);
            this.Controls.Add(this.btnMenuInicial);
            this.Name = "FormEditarSeries";
            this.Text = "Editar Séries";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ComboBox comboSeries;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNumeroTemporada;
        private System.Windows.Forms.TextBox txtNumeroTemporada;
        private System.Windows.Forms.Label lblAnoTemporada;
        private System.Windows.Forms.TextBox txtAnoTemporada;
        private System.Windows.Forms.Button btnAdicionarTemporada;
        private System.Windows.Forms.Button btnMenuInicial;
    }
}
