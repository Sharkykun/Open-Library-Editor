namespace OpenLibraryEditor.Controles
{
    partial class VistaDetallesV
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
            this.PanDatos = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.LblTituloLibro = new System.Windows.Forms.Label();
            this.PanAutores = new System.Windows.Forms.Panel();
            this.LblAutores = new System.Windows.Forms.Label();
            this.PanFoto = new System.Windows.Forms.Panel();
            this.PcbImgLibro = new System.Windows.Forms.PictureBox();
            this.PanEditorial = new System.Windows.Forms.Panel();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblEscribirEditorial = new System.Windows.Forms.Label();
            this.PanSeries = new System.Windows.Forms.Panel();
            this.LblEscribirSeries = new System.Windows.Forms.Label();
            this.LblSeries = new System.Windows.Forms.Label();
            this.PanRestoDatos = new System.Windows.Forms.Panel();
            this.LblEscribirIsbn10 = new System.Windows.Forms.Label();
            this.LblIsbn10 = new System.Windows.Forms.Label();
            this.LblEscribirIsbn13 = new System.Windows.Forms.Label();
            this.LblIsbn13 = new System.Windows.Forms.Label();
            this.LblEscribirPag = new System.Windows.Forms.Label();
            this.LblPaginas = new System.Windows.Forms.Label();
            this.LblEscribirFecha = new System.Windows.Forms.Label();
            this.LblPublicado = new System.Windows.Forms.Label();
            this.LblEscribirIdioma = new System.Windows.Forms.Label();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblEscribirFormato = new System.Windows.Forms.Label();
            this.LblFormato = new System.Windows.Forms.Label();
            this.PanBorde = new OpenLibraryEditor.Controles.PanelTransparente();
            this.PanDatos.SuspendLayout();
            this.PanTitulo.SuspendLayout();
            this.PanAutores.SuspendLayout();
            this.PanFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImgLibro)).BeginInit();
            this.PanEditorial.SuspendLayout();
            this.PanSeries.SuspendLayout();
            this.PanRestoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanDatos
            // 
            this.PanDatos.AutoScroll = true;
            this.PanDatos.AutoSize = true;
            this.PanDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.PanDatos.Controls.Add(this.PanRestoDatos);
            this.PanDatos.Controls.Add(this.PanSeries);
            this.PanDatos.Controls.Add(this.PanEditorial);
            this.PanDatos.Controls.Add(this.PanFoto);
            this.PanDatos.Controls.Add(this.PanAutores);
            this.PanDatos.Controls.Add(this.PanTitulo);
            this.PanDatos.Controls.Add(this.flowLayoutPanel3);
            this.PanDatos.Location = new System.Drawing.Point(5, 5);
            this.PanDatos.Name = "PanDatos";
            this.PanDatos.Size = new System.Drawing.Size(400, 240);
            this.PanDatos.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(0, 240);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // PanTitulo
            // 
            this.PanTitulo.AutoSize = true;
            this.PanTitulo.Controls.Add(this.LblTituloLibro);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(400, 32);
            this.PanTitulo.TabIndex = 6;
            // 
            // LblTituloLibro
            // 
            this.LblTituloLibro.AutoSize = true;
            this.LblTituloLibro.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloLibro.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblTituloLibro.Location = new System.Drawing.Point(10, 10);
            this.LblTituloLibro.Margin = new System.Windows.Forms.Padding(0);
            this.LblTituloLibro.Name = "LblTituloLibro";
            this.LblTituloLibro.Size = new System.Drawing.Size(0, 22);
            this.LblTituloLibro.TabIndex = 0;
            // 
            // PanAutores
            // 
            this.PanAutores.AutoSize = true;
            this.PanAutores.Controls.Add(this.LblAutores);
            this.PanAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanAutores.Location = new System.Drawing.Point(0, 32);
            this.PanAutores.Name = "PanAutores";
            this.PanAutores.Size = new System.Drawing.Size(400, 30);
            this.PanAutores.TabIndex = 7;
            // 
            // LblAutores
            // 
            this.LblAutores.AutoSize = true;
            this.LblAutores.BackColor = System.Drawing.Color.Transparent;
            this.LblAutores.Font = new System.Drawing.Font("Merienda One", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblAutores.Location = new System.Drawing.Point(10, 5);
            this.LblAutores.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.LblAutores.Name = "LblAutores";
            this.LblAutores.Size = new System.Drawing.Size(0, 17);
            this.LblAutores.TabIndex = 0;
            // 
            // PanFoto
            // 
            this.PanFoto.AutoSize = true;
            this.PanFoto.Controls.Add(this.PcbImgLibro);
            this.PanFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanFoto.Location = new System.Drawing.Point(0, 62);
            this.PanFoto.Name = "PanFoto";
            this.PanFoto.Size = new System.Drawing.Size(138, 178);
            this.PanFoto.TabIndex = 8;
            // 
            // PcbImgLibro
            // 
            this.PcbImgLibro.Location = new System.Drawing.Point(10, 9);
            this.PcbImgLibro.Margin = new System.Windows.Forms.Padding(3, 5, 8, 3);
            this.PcbImgLibro.Name = "PcbImgLibro";
            this.PcbImgLibro.Size = new System.Drawing.Size(120, 160);
            this.PcbImgLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbImgLibro.TabIndex = 1;
            this.PcbImgLibro.TabStop = false;
            // 
            // PanEditorial
            // 
            this.PanEditorial.AutoSize = true;
            this.PanEditorial.Controls.Add(this.LblEscribirEditorial);
            this.PanEditorial.Controls.Add(this.LblEditorial);
            this.PanEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanEditorial.Location = new System.Drawing.Point(138, 62);
            this.PanEditorial.Name = "PanEditorial";
            this.PanEditorial.Size = new System.Drawing.Size(262, 22);
            this.PanEditorial.TabIndex = 9;
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.BackColor = System.Drawing.Color.Transparent;
            this.LblEditorial.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblEditorial.Location = new System.Drawing.Point(0, 5);
            this.LblEditorial.Margin = new System.Windows.Forms.Padding(0);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(64, 17);
            this.LblEditorial.TabIndex = 0;
            this.LblEditorial.Text = "Editorial:";
            // 
            // LblEscribirEditorial
            // 
            this.LblEscribirEditorial.AutoSize = true;
            this.LblEscribirEditorial.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirEditorial.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirEditorial.Location = new System.Drawing.Point(86, 7);
            this.LblEscribirEditorial.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirEditorial.Name = "LblEscribirEditorial";
            this.LblEscribirEditorial.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirEditorial.TabIndex = 1;
            // 
            // PanSeries
            // 
            this.PanSeries.AutoSize = true;
            this.PanSeries.Controls.Add(this.LblEscribirSeries);
            this.PanSeries.Controls.Add(this.LblSeries);
            this.PanSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSeries.Location = new System.Drawing.Point(138, 84);
            this.PanSeries.Name = "PanSeries";
            this.PanSeries.Size = new System.Drawing.Size(262, 22);
            this.PanSeries.TabIndex = 10;
            this.PanSeries.Visible = false;
            // 
            // LblEscribirSeries
            // 
            this.LblEscribirSeries.AutoSize = true;
            this.LblEscribirSeries.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirSeries.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirSeries.Location = new System.Drawing.Point(86, 7);
            this.LblEscribirSeries.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirSeries.Name = "LblEscribirSeries";
            this.LblEscribirSeries.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirSeries.TabIndex = 1;
            // 
            // LblSeries
            // 
            this.LblSeries.AutoSize = true;
            this.LblSeries.BackColor = System.Drawing.Color.Transparent;
            this.LblSeries.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblSeries.Location = new System.Drawing.Point(0, 5);
            this.LblSeries.Margin = new System.Windows.Forms.Padding(0);
            this.LblSeries.Name = "LblSeries";
            this.LblSeries.Size = new System.Drawing.Size(49, 17);
            this.LblSeries.TabIndex = 0;
            this.LblSeries.Text = "Series:";
            // 
            // PanRestoDatos
            // 
            this.PanRestoDatos.AutoSize = true;
            this.PanRestoDatos.Controls.Add(this.LblEscribirFormato);
            this.PanRestoDatos.Controls.Add(this.LblFormato);
            this.PanRestoDatos.Controls.Add(this.LblEscribirIdioma);
            this.PanRestoDatos.Controls.Add(this.LblIdioma);
            this.PanRestoDatos.Controls.Add(this.LblEscribirFecha);
            this.PanRestoDatos.Controls.Add(this.LblPublicado);
            this.PanRestoDatos.Controls.Add(this.LblEscribirPag);
            this.PanRestoDatos.Controls.Add(this.LblPaginas);
            this.PanRestoDatos.Controls.Add(this.LblEscribirIsbn13);
            this.PanRestoDatos.Controls.Add(this.LblIsbn13);
            this.PanRestoDatos.Controls.Add(this.LblEscribirIsbn10);
            this.PanRestoDatos.Controls.Add(this.LblIsbn10);
            this.PanRestoDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanRestoDatos.Location = new System.Drawing.Point(138, 106);
            this.PanRestoDatos.Name = "PanRestoDatos";
            this.PanRestoDatos.Size = new System.Drawing.Size(262, 132);
            this.PanRestoDatos.TabIndex = 11;
            // 
            // LblEscribirIsbn10
            // 
            this.LblEscribirIsbn10.AutoSize = true;
            this.LblEscribirIsbn10.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirIsbn10.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirIsbn10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirIsbn10.Location = new System.Drawing.Point(86, 7);
            this.LblEscribirIsbn10.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirIsbn10.Name = "LblEscribirIsbn10";
            this.LblEscribirIsbn10.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirIsbn10.TabIndex = 1;
            // 
            // LblIsbn10
            // 
            this.LblIsbn10.AutoSize = true;
            this.LblIsbn10.BackColor = System.Drawing.Color.Transparent;
            this.LblIsbn10.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsbn10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblIsbn10.Location = new System.Drawing.Point(0, 5);
            this.LblIsbn10.Margin = new System.Windows.Forms.Padding(0);
            this.LblIsbn10.Name = "LblIsbn10";
            this.LblIsbn10.Size = new System.Drawing.Size(59, 17);
            this.LblIsbn10.TabIndex = 0;
            this.LblIsbn10.Text = "ISBN 10:";
            // 
            // LblEscribirIsbn13
            // 
            this.LblEscribirIsbn13.AutoSize = true;
            this.LblEscribirIsbn13.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirIsbn13.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirIsbn13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirIsbn13.Location = new System.Drawing.Point(86, 26);
            this.LblEscribirIsbn13.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirIsbn13.Name = "LblEscribirIsbn13";
            this.LblEscribirIsbn13.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirIsbn13.TabIndex = 3;
            // 
            // LblIsbn13
            // 
            this.LblIsbn13.AutoSize = true;
            this.LblIsbn13.BackColor = System.Drawing.Color.Transparent;
            this.LblIsbn13.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsbn13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblIsbn13.Location = new System.Drawing.Point(0, 24);
            this.LblIsbn13.Margin = new System.Windows.Forms.Padding(0);
            this.LblIsbn13.Name = "LblIsbn13";
            this.LblIsbn13.Size = new System.Drawing.Size(59, 17);
            this.LblIsbn13.TabIndex = 2;
            this.LblIsbn13.Text = "ISBN 13:";
            // 
            // LblEscribirPag
            // 
            this.LblEscribirPag.AutoSize = true;
            this.LblEscribirPag.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirPag.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirPag.Location = new System.Drawing.Point(86, 48);
            this.LblEscribirPag.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirPag.Name = "LblEscribirPag";
            this.LblEscribirPag.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirPag.TabIndex = 5;
            // 
            // LblPaginas
            // 
            this.LblPaginas.AutoSize = true;
            this.LblPaginas.BackColor = System.Drawing.Color.Transparent;
            this.LblPaginas.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblPaginas.Location = new System.Drawing.Point(0, 46);
            this.LblPaginas.Margin = new System.Windows.Forms.Padding(0);
            this.LblPaginas.Name = "LblPaginas";
            this.LblPaginas.Size = new System.Drawing.Size(59, 17);
            this.LblPaginas.TabIndex = 4;
            this.LblPaginas.Text = "Páginas:";
            // 
            // LblEscribirFecha
            // 
            this.LblEscribirFecha.AutoSize = true;
            this.LblEscribirFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirFecha.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirFecha.Location = new System.Drawing.Point(86, 70);
            this.LblEscribirFecha.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirFecha.Name = "LblEscribirFecha";
            this.LblEscribirFecha.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirFecha.TabIndex = 7;
            // 
            // LblPublicado
            // 
            this.LblPublicado.AutoSize = true;
            this.LblPublicado.BackColor = System.Drawing.Color.Transparent;
            this.LblPublicado.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPublicado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblPublicado.Location = new System.Drawing.Point(0, 68);
            this.LblPublicado.Margin = new System.Windows.Forms.Padding(0);
            this.LblPublicado.Name = "LblPublicado";
            this.LblPublicado.Size = new System.Drawing.Size(70, 17);
            this.LblPublicado.TabIndex = 6;
            this.LblPublicado.Text = "Publicado:";
            // 
            // LblEscribirIdioma
            // 
            this.LblEscribirIdioma.AutoSize = true;
            this.LblEscribirIdioma.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirIdioma.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirIdioma.Location = new System.Drawing.Point(86, 92);
            this.LblEscribirIdioma.Margin = new System.Windows.Forms.Padding(0);
            this.LblEscribirIdioma.Name = "LblEscribirIdioma";
            this.LblEscribirIdioma.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirIdioma.TabIndex = 9;
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.LblIdioma.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblIdioma.Location = new System.Drawing.Point(0, 90);
            this.LblIdioma.Margin = new System.Windows.Forms.Padding(0);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(52, 17);
            this.LblIdioma.TabIndex = 8;
            this.LblIdioma.Text = "Idioma:";
            // 
            // LblEscribirFormato
            // 
            this.LblEscribirFormato.AutoSize = true;
            this.LblEscribirFormato.BackColor = System.Drawing.Color.Transparent;
            this.LblEscribirFormato.Font = new System.Drawing.Font("Merienda", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirFormato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirFormato.Location = new System.Drawing.Point(86, 114);
            this.LblEscribirFormato.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LblEscribirFormato.Name = "LblEscribirFormato";
            this.LblEscribirFormato.Size = new System.Drawing.Size(0, 14);
            this.LblEscribirFormato.TabIndex = 11;
            // 
            // LblFormato
            // 
            this.LblFormato.AutoSize = true;
            this.LblFormato.BackColor = System.Drawing.Color.Transparent;
            this.LblFormato.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblFormato.Location = new System.Drawing.Point(0, 112);
            this.LblFormato.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LblFormato.Name = "LblFormato";
            this.LblFormato.Size = new System.Drawing.Size(61, 17);
            this.LblFormato.TabIndex = 10;
            this.LblFormato.Text = "Formato:";
            // 
            // PanBorde
            // 
            this.PanBorde.AutoScroll = true;
            this.PanBorde.AutoSize = true;
            this.PanBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanBorde.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBorde.Location = new System.Drawing.Point(0, 0);
            this.PanBorde.Name = "PanBorde";
            this.PanBorde.Size = new System.Drawing.Size(410, 250);
            this.PanBorde.TabIndex = 0;
            this.PanBorde.TamBorde = 5;
            this.PanBorde.Click += new System.EventHandler(this.PanBorde_Click);
            this.PanBorde.MouseEnter += new System.EventHandler(this.PanBorde_MouseEnter);
            this.PanBorde.MouseLeave += new System.EventHandler(this.PanBorde_MouseLeave);
            // 
            // VistaDetallesV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanBorde);
            this.Controls.Add(this.PanDatos);
            this.Name = "VistaDetallesV";
            this.Size = new System.Drawing.Size(410, 250);
            this.Load += new System.EventHandler(this.VistaDetallesV_Load);
            this.PanDatos.ResumeLayout(false);
            this.PanDatos.PerformLayout();
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanAutores.ResumeLayout(false);
            this.PanAutores.PerformLayout();
            this.PanFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbImgLibro)).EndInit();
            this.PanEditorial.ResumeLayout(false);
            this.PanEditorial.PerformLayout();
            this.PanSeries.ResumeLayout(false);
            this.PanSeries.PerformLayout();
            this.PanRestoDatos.ResumeLayout(false);
            this.PanRestoDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelTransparente PanBorde;
        private System.Windows.Forms.Panel PanDatos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel PanEditorial;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Panel PanFoto;
        private System.Windows.Forms.PictureBox PcbImgLibro;
        private System.Windows.Forms.Panel PanAutores;
        private System.Windows.Forms.Label LblAutores;
        private System.Windows.Forms.Panel PanTitulo;
        private System.Windows.Forms.Label LblTituloLibro;
        private System.Windows.Forms.Label LblEscribirEditorial;
        private System.Windows.Forms.Panel PanSeries;
        private System.Windows.Forms.Label LblEscribirSeries;
        private System.Windows.Forms.Label LblSeries;
        private System.Windows.Forms.Panel PanRestoDatos;
        private System.Windows.Forms.Label LblEscribirIsbn10;
        private System.Windows.Forms.Label LblIsbn10;
        private System.Windows.Forms.Label LblEscribirIsbn13;
        private System.Windows.Forms.Label LblIsbn13;
        private System.Windows.Forms.Label LblEscribirIdioma;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.Label LblEscribirFecha;
        private System.Windows.Forms.Label LblPublicado;
        private System.Windows.Forms.Label LblEscribirPag;
        private System.Windows.Forms.Label LblPaginas;
        private System.Windows.Forms.Label LblEscribirFormato;
        private System.Windows.Forms.Label LblFormato;
    }
}
