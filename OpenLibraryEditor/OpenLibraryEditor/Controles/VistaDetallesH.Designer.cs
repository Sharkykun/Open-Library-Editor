namespace OpenLibraryEditor.Controles
{
    partial class VistaDetallesH
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanBorde = new OpenLibraryEditor.Controles.PanelTransparente();
            this.PanDatos = new System.Windows.Forms.Panel();
            this.PcbImagenLibro = new System.Windows.Forms.PictureBox();
            this.LblEscribirEditoriales = new System.Windows.Forms.Label();
            this.LblescribirSeries = new System.Windows.Forms.Label();
            this.LblEscribirFormato = new System.Windows.Forms.Label();
            this.LblEscribirIdioma = new System.Windows.Forms.Label();
            this.LblEscribirPaginas = new System.Windows.Forms.Label();
            this.LblEscribirFecha = new System.Windows.Forms.Label();
            this.LblFormato = new System.Windows.Forms.Label();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblPaginas = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblEscribirIsbn10 = new System.Windows.Forms.Label();
            this.LblEscribirIsbn13 = new System.Windows.Forms.Label();
            this.LblIsbn13 = new System.Windows.Forms.Label();
            this.LblIsbn10 = new System.Windows.Forms.Label();
            this.LblSeries = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblPersonasLibro = new System.Windows.Forms.Label();
            this.LblTituloLibro = new System.Windows.Forms.Label();
            this.PanDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagenLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBorde
            // 
            this.PanBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanBorde.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBorde.Location = new System.Drawing.Point(0, 0);
            this.PanBorde.Name = "PanBorde";
            this.PanBorde.Size = new System.Drawing.Size(520, 210);
            this.PanBorde.TabIndex = 6;
            this.PanBorde.TamBorde = 5;
            this.PanBorde.Click += new System.EventHandler(this.PanBorde_Click);
            this.PanBorde.MouseEnter += new System.EventHandler(this.PanBorde_MouseEnter);
            this.PanBorde.MouseLeave += new System.EventHandler(this.PanBorde_MouseLeave);
            // 
            // PanDatos
            // 
            this.PanDatos.BackColor = System.Drawing.Color.Gainsboro;
            this.PanDatos.Controls.Add(this.PcbImagenLibro);
            this.PanDatos.Controls.Add(this.LblEscribirEditoriales);
            this.PanDatos.Controls.Add(this.LblescribirSeries);
            this.PanDatos.Controls.Add(this.LblEscribirFormato);
            this.PanDatos.Controls.Add(this.LblEscribirIdioma);
            this.PanDatos.Controls.Add(this.LblEscribirPaginas);
            this.PanDatos.Controls.Add(this.LblEscribirFecha);
            this.PanDatos.Controls.Add(this.LblFormato);
            this.PanDatos.Controls.Add(this.LblIdioma);
            this.PanDatos.Controls.Add(this.LblPaginas);
            this.PanDatos.Controls.Add(this.LblFecha);
            this.PanDatos.Controls.Add(this.LblEscribirIsbn10);
            this.PanDatos.Controls.Add(this.LblEscribirIsbn13);
            this.PanDatos.Controls.Add(this.LblIsbn13);
            this.PanDatos.Controls.Add(this.LblIsbn10);
            this.PanDatos.Controls.Add(this.LblSeries);
            this.PanDatos.Controls.Add(this.LblEditorial);
            this.PanDatos.Controls.Add(this.LblPersonasLibro);
            this.PanDatos.Controls.Add(this.LblTituloLibro);
            this.PanDatos.Location = new System.Drawing.Point(5, 5);
            this.PanDatos.Name = "PanDatos";
            this.PanDatos.Size = new System.Drawing.Size(510, 200);
            this.PanDatos.TabIndex = 5;
            // 
            // PcbImagenLibro
            // 
            this.PcbImagenLibro.Image = global::OpenLibraryEditor.Properties.Resources.PortadaLogo;
            this.PcbImagenLibro.Location = new System.Drawing.Point(5, 23);
            this.PcbImagenLibro.Name = "PcbImagenLibro";
            this.PcbImagenLibro.Size = new System.Drawing.Size(120, 160);
            this.PcbImagenLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbImagenLibro.TabIndex = 20;
            this.PcbImagenLibro.TabStop = false;
            // 
            // LblEscribirEditoriales
            // 
            this.LblEscribirEditoriales.AutoSize = true;
            this.LblEscribirEditoriales.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirEditoriales.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirEditoriales.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirEditoriales.Location = new System.Drawing.Point(207, 74);
            this.LblEscribirEditoriales.Name = "LblEscribirEditoriales";
            this.LblEscribirEditoriales.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirEditoriales.TabIndex = 19;
            // 
            // LblescribirSeries
            // 
            this.LblescribirSeries.AutoSize = true;
            this.LblescribirSeries.BackColor = System.Drawing.Color.Transparent;
            this.LblescribirSeries.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblescribirSeries.ForeColor = System.Drawing.Color.Black;
            this.LblescribirSeries.Location = new System.Drawing.Point(207, 95);
            this.LblescribirSeries.Name = "LblescribirSeries";
            this.LblescribirSeries.Size = new System.Drawing.Size(0, 17);
            this.LblescribirSeries.TabIndex = 18;
            // 
            // LblEscribirFormato
            // 
            this.LblEscribirFormato.AutoSize = true;
            this.LblEscribirFormato.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirFormato.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirFormato.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirFormato.Location = new System.Drawing.Point(380, 163);
            this.LblEscribirFormato.Name = "LblEscribirFormato";
            this.LblEscribirFormato.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirFormato.TabIndex = 16;
            // 
            // LblEscribirIdioma
            // 
            this.LblEscribirIdioma.AutoSize = true;
            this.LblEscribirIdioma.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirIdioma.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirIdioma.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirIdioma.Location = new System.Drawing.Point(380, 141);
            this.LblEscribirIdioma.Name = "LblEscribirIdioma";
            this.LblEscribirIdioma.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirIdioma.TabIndex = 15;
            // 
            // LblEscribirPaginas
            // 
            this.LblEscribirPaginas.AutoSize = true;
            this.LblEscribirPaginas.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirPaginas.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirPaginas.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirPaginas.Location = new System.Drawing.Point(207, 163);
            this.LblEscribirPaginas.Name = "LblEscribirPaginas";
            this.LblEscribirPaginas.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirPaginas.TabIndex = 14;
            // 
            // LblEscribirFecha
            // 
            this.LblEscribirFecha.AutoSize = true;
            this.LblEscribirFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirFecha.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirFecha.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirFecha.Location = new System.Drawing.Point(380, 118);
            this.LblEscribirFecha.Name = "LblEscribirFecha";
            this.LblEscribirFecha.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirFecha.TabIndex = 13;
            // 
            // LblFormato
            // 
            this.LblFormato.AutoSize = true;
            this.LblFormato.BackColor = System.Drawing.Color.Transparent;
            this.LblFormato.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblFormato.Location = new System.Drawing.Point(319, 163);
            this.LblFormato.Name = "LblFormato";
            this.LblFormato.Size = new System.Drawing.Size(61, 17);
            this.LblFormato.TabIndex = 12;
            this.LblFormato.Text = "Formato:";
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.LblIdioma.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblIdioma.Location = new System.Drawing.Point(328, 141);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(52, 17);
            this.LblIdioma.TabIndex = 11;
            this.LblIdioma.Text = "Idioma:";
            // 
            // LblPaginas
            // 
            this.LblPaginas.AutoSize = true;
            this.LblPaginas.BackColor = System.Drawing.Color.Transparent;
            this.LblPaginas.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblPaginas.Location = new System.Drawing.Point(151, 163);
            this.LblPaginas.Name = "LblPaginas";
            this.LblPaginas.Size = new System.Drawing.Size(59, 17);
            this.LblPaginas.TabIndex = 10;
            this.LblPaginas.Text = "Páginas:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblFecha.Location = new System.Drawing.Point(310, 118);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(70, 17);
            this.LblFecha.TabIndex = 9;
            this.LblFecha.Text = "Publicado:";
            // 
            // LblEscribirIsbn10
            // 
            this.LblEscribirIsbn10.AutoSize = true;
            this.LblEscribirIsbn10.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirIsbn10.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirIsbn10.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirIsbn10.Location = new System.Drawing.Point(207, 118);
            this.LblEscribirIsbn10.Name = "LblEscribirIsbn10";
            this.LblEscribirIsbn10.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirIsbn10.TabIndex = 8;
            // 
            // LblEscribirIsbn13
            // 
            this.LblEscribirIsbn13.AutoSize = true;
            this.LblEscribirIsbn13.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirIsbn13.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirIsbn13.ForeColor = System.Drawing.Color.Black;
            this.LblEscribirIsbn13.Location = new System.Drawing.Point(207, 141);
            this.LblEscribirIsbn13.Name = "LblEscribirIsbn13";
            this.LblEscribirIsbn13.Size = new System.Drawing.Size(0, 17);
            this.LblEscribirIsbn13.TabIndex = 7;
            // 
            // LblIsbn13
            // 
            this.LblIsbn13.AutoSize = true;
            this.LblIsbn13.BackColor = System.Drawing.Color.Transparent;
            this.LblIsbn13.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsbn13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblIsbn13.Location = new System.Drawing.Point(151, 141);
            this.LblIsbn13.Name = "LblIsbn13";
            this.LblIsbn13.Size = new System.Drawing.Size(59, 17);
            this.LblIsbn13.TabIndex = 6;
            this.LblIsbn13.Text = "ISBN 13:";
            // 
            // LblIsbn10
            // 
            this.LblIsbn10.AutoSize = true;
            this.LblIsbn10.BackColor = System.Drawing.Color.Transparent;
            this.LblIsbn10.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsbn10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblIsbn10.Location = new System.Drawing.Point(151, 118);
            this.LblIsbn10.Name = "LblIsbn10";
            this.LblIsbn10.Size = new System.Drawing.Size(59, 17);
            this.LblIsbn10.TabIndex = 5;
            this.LblIsbn10.Text = "ISBN 10:";
            // 
            // LblSeries
            // 
            this.LblSeries.AutoSize = true;
            this.LblSeries.BackColor = System.Drawing.Color.Transparent;
            this.LblSeries.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblSeries.Location = new System.Drawing.Point(161, 95);
            this.LblSeries.Name = "LblSeries";
            this.LblSeries.Size = new System.Drawing.Size(49, 17);
            this.LblSeries.TabIndex = 4;
            this.LblSeries.Text = "Series:";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.BackColor = System.Drawing.Color.Transparent;
            this.LblEditorial.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LblEditorial.Location = new System.Drawing.Point(133, 74);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(77, 17);
            this.LblEditorial.TabIndex = 3;
            this.LblEditorial.Text = "Editoriales:";
            // 
            // LblPersonasLibro
            // 
            this.LblPersonasLibro.AutoSize = true;
            this.LblPersonasLibro.BackColor = System.Drawing.Color.Transparent;
            this.LblPersonasLibro.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonasLibro.ForeColor = System.Drawing.Color.Navy;
            this.LblPersonasLibro.Location = new System.Drawing.Point(133, 48);
            this.LblPersonasLibro.Name = "LblPersonasLibro";
            this.LblPersonasLibro.Size = new System.Drawing.Size(135, 17);
            this.LblPersonasLibro.TabIndex = 2;
            this.LblPersonasLibro.Text = "J. K. Rowling, Jim Kay";
            // 
            // LblTituloLibro
            // 
            this.LblTituloLibro.AutoSize = true;
            this.LblTituloLibro.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloLibro.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloLibro.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloLibro.Location = new System.Drawing.Point(132, 20);
            this.LblTituloLibro.Name = "LblTituloLibro";
            this.LblTituloLibro.Size = new System.Drawing.Size(283, 22);
            this.LblTituloLibro.TabIndex = 1;
            this.LblTituloLibro.Text = "Harry Potter y la orden del fénix";
            // 
            // VistaDetallesH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanDatos);
            this.Controls.Add(this.PanBorde);
            this.Name = "VistaDetallesH";
            this.Size = new System.Drawing.Size(520, 210);
            this.PanDatos.ResumeLayout(false);
            this.PanDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagenLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelTransparente PanBorde;
        private System.Windows.Forms.Panel PanDatos;
        private System.Windows.Forms.Label LblEscribirFormato;
        private System.Windows.Forms.Label LblEscribirIdioma;
        private System.Windows.Forms.Label LblEscribirPaginas;
        private System.Windows.Forms.Label LblEscribirFecha;
        private System.Windows.Forms.Label LblFormato;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.Label LblPaginas;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblEscribirIsbn10;
        private System.Windows.Forms.Label LblEscribirIsbn13;
        private System.Windows.Forms.Label LblIsbn13;
        private System.Windows.Forms.Label LblIsbn10;
        private System.Windows.Forms.Label LblSeries;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblPersonasLibro;
        private System.Windows.Forms.Label LblTituloLibro;
        private System.Windows.Forms.Label LblEscribirEditoriales;
        private System.Windows.Forms.Label LblescribirSeries;
        private System.Windows.Forms.PictureBox PcbImagenLibro;
    }
}
