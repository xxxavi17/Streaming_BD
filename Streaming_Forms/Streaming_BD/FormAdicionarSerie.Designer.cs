namespace Streaming_BD
{
    partial class FormAdicionarSerie
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
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtIdadeMinima;
        private System.Windows.Forms.TextBox txtAverageRating;
        private System.Windows.Forms.TextBox txtIdProdutora;
        private System.Windows.Forms.TextBox txtNumeroTemporadas;
        private System.Windows.Forms.TextBox txtNumeroTemporada;
        private System.Windows.Forms.TextBox txtAnoTemporada;
        private System.Windows.Forms.TextBox txtTituloEpisodio;
        private System.Windows.Forms.TextBox txtNumeroEpisodio;
        private System.Windows.Forms.TextBox txtDuracaoEpisodio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblIdadeMinima;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblIdProdutora;
        private System.Windows.Forms.Label lblNumeroTemporadas;
        private System.Windows.Forms.Label lblNumeroTemporada;
        private System.Windows.Forms.Label lblAnoTemporada;
        private System.Windows.Forms.Label lblTituloEpisodio;
        private System.Windows.Forms.Label lblNumeroEpisodio;
        private System.Windows.Forms.Label lblDuracaoEpisodio;
        private System.Windows.Forms.Button btnAdicionarSerie;
        private System.Windows.Forms.Button btnMenuInicial;
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtIdadeMinima = new System.Windows.Forms.TextBox();
            this.txtAverageRating = new System.Windows.Forms.TextBox();
            this.txtIdProdutora = new System.Windows.Forms.TextBox();
            this.txtNumeroTemporadas = new System.Windows.Forms.TextBox();
            this.txtNumeroTemporada = new System.Windows.Forms.TextBox();
            this.txtAnoTemporada = new System.Windows.Forms.TextBox();
            this.txtTituloEpisodio = new System.Windows.Forms.TextBox();
            this.txtNumeroEpisodio = new System.Windows.Forms.TextBox();
            this.txtDuracaoEpisodio = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblIdadeMinima = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblIdProdutora = new System.Windows.Forms.Label();
            this.lblNumeroTemporadas = new System.Windows.Forms.Label();
            this.lblNumeroTemporada = new System.Windows.Forms.Label();
            this.lblAnoTemporada = new System.Windows.Forms.Label();
            this.lblTituloEpisodio = new System.Windows.Forms.Label();
            this.lblNumeroEpisodio = new System.Windows.Forms.Label();
            this.lblDuracaoEpisodio = new System.Windows.Forms.Label();
            this.btnAdicionarSerie = new System.Windows.Forms.Button();
            this.btnMenuInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // Labels
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblGenero.Text = "Gênero:";
            this.lblGenero.Location = new System.Drawing.Point(30, 70);
            this.lblAno.Text = "Ano:";
            this.lblAno.Location = new System.Drawing.Point(30, 110);
            this.lblIdadeMinima.Text = "Idade Mínima:";
            this.lblIdadeMinima.Location = new System.Drawing.Point(30, 150);
            this.lblAverageRating.Text = "Average Rating:";
            this.lblAverageRating.Location = new System.Drawing.Point(30, 190);
            this.lblIdProdutora.Text = "ID Produtora:";
            this.lblIdProdutora.Location = new System.Drawing.Point(30, 230);
            this.lblNumeroTemporadas.Text = "Nº Temporadas:";
            this.lblNumeroTemporadas.Location = new System.Drawing.Point(30, 270);
            this.lblNumeroTemporada.Text = "Nº Temporada:";
            this.lblNumeroTemporada.Location = new System.Drawing.Point(30, 310);
            this.lblAnoTemporada.Text = "Ano Temporada:";
            this.lblAnoTemporada.Location = new System.Drawing.Point(30, 350);
            this.lblTituloEpisodio.Text = "Título Episódio:";
            this.lblTituloEpisodio.Location = new System.Drawing.Point(30, 390);
            this.lblNumeroEpisodio.Text = "Nº Episódio:";
            this.lblNumeroEpisodio.Location = new System.Drawing.Point(30, 430);
            this.lblDuracaoEpisodio.Text = "Duração Episódio (min):";
            this.lblDuracaoEpisodio.Location = new System.Drawing.Point(30, 470);
            // TextBoxes
            this.txtTitulo.Location = new System.Drawing.Point(200, 30);
            this.txtGenero.Location = new System.Drawing.Point(200, 70);
            this.txtAno.Location = new System.Drawing.Point(200, 110);
            this.txtIdadeMinima.Location = new System.Drawing.Point(200, 150);
            this.txtAverageRating.Location = new System.Drawing.Point(200, 190);
            this.txtIdProdutora.Location = new System.Drawing.Point(200, 230);
            this.txtNumeroTemporadas.Location = new System.Drawing.Point(200, 270);
            this.txtNumeroTemporada.Location = new System.Drawing.Point(200, 310);
            this.txtAnoTemporada.Location = new System.Drawing.Point(200, 350);
            this.txtTituloEpisodio.Location = new System.Drawing.Point(200, 390);
            this.txtNumeroEpisodio.Location = new System.Drawing.Point(200, 430);
            this.txtDuracaoEpisodio.Location = new System.Drawing.Point(200, 470);
            // Botões
            this.btnAdicionarSerie.Text = "Adicionar Série";
            this.btnAdicionarSerie.Location = new System.Drawing.Point(200, 520);
            this.btnAdicionarSerie.Size = new System.Drawing.Size(180, 40);
            this.btnMenuInicial.Location = new System.Drawing.Point(20, 20);
            this.btnMenuInicial.Name = "btnMenuInicial";
            this.btnMenuInicial.Size = new System.Drawing.Size(120, 35);
            this.btnMenuInicial.TabIndex = 99;
            this.btnMenuInicial.Text = "Menu Inicial";
            this.btnMenuInicial.UseVisualStyleBackColor = true;
            this.btnMenuInicial.Click += new System.EventHandler(this.btnMenuInicial_Click);
            // Adiciona controles ao formulário
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblIdadeMinima);
            this.Controls.Add(this.txtIdadeMinima);
            this.Controls.Add(this.lblAverageRating);
            this.Controls.Add(this.txtAverageRating);
            this.Controls.Add(this.lblIdProdutora);
            this.Controls.Add(this.txtIdProdutora);
            this.Controls.Add(this.lblNumeroTemporadas);
            this.Controls.Add(this.txtNumeroTemporadas);
            this.Controls.Add(this.lblNumeroTemporada);
            this.Controls.Add(this.txtNumeroTemporada);
            this.Controls.Add(this.lblAnoTemporada);
            this.Controls.Add(this.txtAnoTemporada);
            this.Controls.Add(this.lblTituloEpisodio);
            this.Controls.Add(this.txtTituloEpisodio);
            this.Controls.Add(this.lblNumeroEpisodio);
            this.Controls.Add(this.txtNumeroEpisodio);
            this.Controls.Add(this.lblDuracaoEpisodio);
            this.Controls.Add(this.txtDuracaoEpisodio);
            this.Controls.Add(this.btnAdicionarSerie);
            this.Controls.Add(this.btnMenuInicial);
            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Name = "FormAdicionarSerie";
            this.Text = "Adicionar Série";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
