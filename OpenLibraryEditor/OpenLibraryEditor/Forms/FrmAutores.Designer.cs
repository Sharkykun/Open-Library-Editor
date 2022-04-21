namespace OpenLibraryEditor.Forms
{
    partial class FrmAutores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutores));
            this.PanTituloAutores = new System.Windows.Forms.Panel();
            this.MBtnCerrarAutores = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloAutores = new System.Windows.Forms.Label();
            this.PcbLogoAutores = new System.Windows.Forms.PictureBox();
            this.PanBtnAu = new System.Windows.Forms.Panel();
            this.KBtnCancelarAu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarAu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LsvAutoresNA = new System.Windows.Forms.ListView();
            this.ChNombreAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChOcupacionAu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanOpcionesNA = new System.Windows.Forms.Panel();
            this.LblOcupacionNA = new System.Windows.Forms.Label();
            this.KCmbOcupacionNA = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.MBtnMasOcupacionNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosOcupacionNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.KMtxtFecMuerteNA = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KMtxtFecNacimientoNA = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.MBtnAniadirImagenAu = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnBorrarImagenAu = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioAu = new System.Windows.Forms.Label();
            this.KTxtComentarioAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblEnlaceAu = new System.Windows.Forms.Label();
            this.KTxtEnlaceAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblDefuncionAu = new System.Windows.Forms.Label();
            this.LblAliasAu = new System.Windows.Forms.Label();
            this.KtxtAliasAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblNacimientoAu = new System.Windows.Forms.Label();
            this.LblNombreNA = new System.Windows.Forms.Label();
            this.KTxtNombreAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PcbAutorNA = new System.Windows.Forms.PictureBox();
            this.TTAutores = new System.Windows.Forms.ToolTip(this.components);
            this.PanTituloAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).BeginInit();
            this.PanBtnAu.SuspendLayout();
            this.PanOpcionesNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOcupacionNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAutorNA)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTituloAutores
            // 
            this.PanTituloAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloAutores.Controls.Add(this.MBtnCerrarAutores);
            this.PanTituloAutores.Controls.Add(this.LblTituloAutores);
            this.PanTituloAutores.Controls.Add(this.PcbLogoAutores);
            this.PanTituloAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloAutores.Location = new System.Drawing.Point(0, 0);
            this.PanTituloAutores.Name = "PanTituloAutores";
            this.PanTituloAutores.Size = new System.Drawing.Size(805, 40);
            this.PanTituloAutores.TabIndex = 1;
            this.PanTituloAutores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
            // 
            // MBtnCerrarAutores
            // 
            this.MBtnCerrarAutores.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarAutores.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarAutores.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarAutores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarAutores.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarAutores.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarAutores.IconSize = 40;
            this.MBtnCerrarAutores.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarAutores.Name = "MBtnCerrarAutores";
            this.MBtnCerrarAutores.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarAutores.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarAutores.TabIndex = 28;
            this.MBtnCerrarAutores.UseVisualStyleBackColor = false;
            this.MBtnCerrarAutores.Click += new System.EventHandler(this.MBtnCerrarAutores_Click);
            // 
            // LblTituloAutores
            // 
            this.LblTituloAutores.AutoSize = true;
            this.LblTituloAutores.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAutores.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloAutores.Location = new System.Drawing.Point(54, 9);
            this.LblTituloAutores.Name = "LblTituloAutores";
            this.LblTituloAutores.Size = new System.Drawing.Size(282, 23);
            this.LblTituloAutores.TabIndex = 4;
            this.LblTituloAutores.Text = "Open Library Editor - Nuevo Autor";
            // 
            // PcbLogoAutores
            // 
            this.PcbLogoAutores.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoAutores.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoAutores.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoAutores.Name = "PcbLogoAutores";
            this.PcbLogoAutores.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoAutores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoAutores.TabIndex = 3;
            this.PcbLogoAutores.TabStop = false;
            // 
            // PanBtnAu
            // 
            this.PanBtnAu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnAu.Controls.Add(this.KBtnCancelarAu);
            this.PanBtnAu.Controls.Add(this.KBtnAceptarAu);
            this.PanBtnAu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnAu.Location = new System.Drawing.Point(0, 454);
            this.PanBtnAu.Name = "PanBtnAu";
            this.PanBtnAu.Size = new System.Drawing.Size(805, 45);
            this.PanBtnAu.TabIndex = 97;
            // 
            // KBtnCancelarAu
            // 
            this.KBtnCancelarAu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarAu.Location = new System.Drawing.Point(532, 5);
            this.KBtnCancelarAu.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarAu.Name = "KBtnCancelarAu";
            this.KBtnCancelarAu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarAu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarAu.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarAu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarAu.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarAu.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarAu.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarAu.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarAu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarAu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarAu.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarAu.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarAu.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarAu.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarAu.StateCommon.Border.Width = 2;
            this.KBtnCancelarAu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarAu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarAu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarAu.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarAu.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarAu.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarAu.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarAu.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarAu.StateNormal.Border.Width = 2;
            this.KBtnCancelarAu.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarAu.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarAu.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarAu.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarAu.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarAu.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarAu.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarAu.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarAu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarAu.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarAu.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarAu.TabIndex = 1;
            this.KBtnCancelarAu.Values.Text = "Cancelar";
            this.KBtnCancelarAu.Click += new System.EventHandler(this.KBtnCancelarAu_Click);
            // 
            // KBtnAceptarAu
            // 
            this.KBtnAceptarAu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnAceptarAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarAu.Location = new System.Drawing.Point(670, 5);
            this.KBtnAceptarAu.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarAu.Name = "KBtnAceptarAu";
            this.KBtnAceptarAu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarAu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarAu.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarAu.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarAu.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarAu.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarAu.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarAu.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarAu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarAu.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarAu.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarAu.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarAu.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarAu.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarAu.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarAu.StateCommon.Border.Width = 2;
            this.KBtnAceptarAu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarAu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarAu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarAu.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarAu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarAu.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarAu.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarAu.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarAu.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarAu.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarAu.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarAu.StateNormal.Border.Width = 2;
            this.KBtnAceptarAu.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarAu.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarAu.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarAu.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarAu.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarAu.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarAu.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarAu.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarAu.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarAu.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarAu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarAu.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarAu.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarAu.TabIndex = 0;
            this.KBtnAceptarAu.Values.Text = "Aceptar";
            this.KBtnAceptarAu.Click += new System.EventHandler(this.KBtnAceptarAu_Click);
            // 
            // LsvAutoresNA
            // 
            this.LsvAutoresNA.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvAutoresNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvAutoresNA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreAutor,
            this.ChOcupacionAu});
            this.LsvAutoresNA.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvAutoresNA.HideSelection = false;
            this.LsvAutoresNA.Location = new System.Drawing.Point(12, 70);
            this.LsvAutoresNA.Name = "LsvAutoresNA";
            this.LsvAutoresNA.Size = new System.Drawing.Size(221, 313);
            this.LsvAutoresNA.TabIndex = 131;
            this.LsvAutoresNA.UseCompatibleStateImageBehavior = false;
            this.LsvAutoresNA.View = System.Windows.Forms.View.Details;
            this.LsvAutoresNA.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvAutoresNA_ItemSelectionChanged);
            // 
            // ChNombreAutor
            // 
            this.ChNombreAutor.Text = "Nombre";
            this.ChNombreAutor.Width = 117;
            // 
            // ChOcupacionAu
            // 
            this.ChOcupacionAu.Text = "Ocupación";
            this.ChOcupacionAu.Width = 127;
            // 
            // MBtnMasLsvNA
            // 
            this.MBtnMasLsvNA.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNA.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNA.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNA.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasLsvNA.IconSize = 65;
            this.MBtnMasLsvNA.Location = new System.Drawing.Point(12, 389);
            this.MBtnMasLsvNA.Name = "MBtnMasLsvNA";
            this.MBtnMasLsvNA.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNA.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNA.TabIndex = 139;
            this.MBtnMasLsvNA.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNA.Click += new System.EventHandler(this.MBtnMasLsvNA_Click);
            // 
            // MBtnMenosLsvNA
            // 
            this.MBtnMenosLsvNA.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNA.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNA.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNA.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosLsvNA.IconSize = 65;
            this.MBtnMenosLsvNA.Location = new System.Drawing.Point(69, 389);
            this.MBtnMenosLsvNA.Name = "MBtnMenosLsvNA";
            this.MBtnMenosLsvNA.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNA.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNA.TabIndex = 140;
            this.MBtnMenosLsvNA.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNA.Click += new System.EventHandler(this.MBtnMenosLsvNA_Click);
            // 
            // PanOpcionesNA
            // 
            this.PanOpcionesNA.Controls.Add(this.LblOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.KCmbOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.MBtnMasOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.MBtnMenosOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.KMtxtFecMuerteNA);
            this.PanOpcionesNA.Controls.Add(this.KMtxtFecNacimientoNA);
            this.PanOpcionesNA.Controls.Add(this.MBtnAniadirImagenAu);
            this.PanOpcionesNA.Controls.Add(this.MBtnBorrarImagenAu);
            this.PanOpcionesNA.Controls.Add(this.LblComentarioAu);
            this.PanOpcionesNA.Controls.Add(this.KTxtComentarioAu);
            this.PanOpcionesNA.Controls.Add(this.LblEnlaceAu);
            this.PanOpcionesNA.Controls.Add(this.KTxtEnlaceAu);
            this.PanOpcionesNA.Controls.Add(this.LblDefuncionAu);
            this.PanOpcionesNA.Controls.Add(this.LblAliasAu);
            this.PanOpcionesNA.Controls.Add(this.KtxtAliasAu);
            this.PanOpcionesNA.Controls.Add(this.LblNacimientoAu);
            this.PanOpcionesNA.Controls.Add(this.LblNombreNA);
            this.PanOpcionesNA.Controls.Add(this.KTxtNombreAu);
            this.PanOpcionesNA.Controls.Add(this.PcbAutorNA);
            this.PanOpcionesNA.Location = new System.Drawing.Point(245, 46);
            this.PanOpcionesNA.Name = "PanOpcionesNA";
            this.PanOpcionesNA.Size = new System.Drawing.Size(560, 388);
            this.PanOpcionesNA.TabIndex = 145;
            this.PanOpcionesNA.Visible = false;
            // 
            // LblOcupacionNA
            // 
            this.LblOcupacionNA.AutoSize = true;
            this.LblOcupacionNA.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOcupacionNA.ForeColor = System.Drawing.Color.Navy;
            this.LblOcupacionNA.Location = new System.Drawing.Point(3, 102);
            this.LblOcupacionNA.Name = "LblOcupacionNA";
            this.LblOcupacionNA.Size = new System.Drawing.Size(84, 20);
            this.LblOcupacionNA.TabIndex = 163;
            this.LblOcupacionNA.Text = "Ocupación";
            // 
            // KCmbOcupacionNA
            // 
            this.KCmbOcupacionNA.DropDownWidth = 228;
            this.KCmbOcupacionNA.Location = new System.Drawing.Point(172, 96);
            this.KCmbOcupacionNA.Name = "KCmbOcupacionNA";
            this.KCmbOcupacionNA.Size = new System.Drawing.Size(168, 33);
            this.KCmbOcupacionNA.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOcupacionNA.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Navy;
            this.KCmbOcupacionNA.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOcupacionNA.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KCmbOcupacionNA.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOcupacionNA.TabIndex = 162;
            // 
            // MBtnMasOcupacionNA
            // 
            this.MBtnMasOcupacionNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasOcupacionNA.FlatAppearance.BorderSize = 0;
            this.MBtnMasOcupacionNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasOcupacionNA.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.MBtnMasOcupacionNA.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasOcupacionNA.IconSize = 40;
            this.MBtnMasOcupacionNA.Location = new System.Drawing.Point(346, 97);
            this.MBtnMasOcupacionNA.Name = "MBtnMasOcupacionNA";
            this.MBtnMasOcupacionNA.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasOcupacionNA.TabIndex = 160;
            this.MBtnMasOcupacionNA.UseVisualStyleBackColor = true;
            this.MBtnMasOcupacionNA.Click += new System.EventHandler(this.MBtnMasOcupacionNA_Click);
            // 
            // MBtnMenosOcupacionNA
            // 
            this.MBtnMenosOcupacionNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosOcupacionNA.FlatAppearance.BorderSize = 0;
            this.MBtnMenosOcupacionNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosOcupacionNA.IconChar = FontAwesome.Sharp.MaterialIcons.MinusCircleOutline;
            this.MBtnMenosOcupacionNA.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosOcupacionNA.IconSize = 40;
            this.MBtnMenosOcupacionNA.Location = new System.Drawing.Point(377, 97);
            this.MBtnMenosOcupacionNA.Name = "MBtnMenosOcupacionNA";
            this.MBtnMenosOcupacionNA.Size = new System.Drawing.Size(30, 30);
            this.MBtnMenosOcupacionNA.TabIndex = 161;
            this.MBtnMenosOcupacionNA.UseVisualStyleBackColor = true;
            this.MBtnMenosOcupacionNA.Click += new System.EventHandler(this.MBtnMenosOcupacionNA_Click);
            // 
            // KMtxtFecMuerteNA
            // 
            this.KMtxtFecMuerteNA.Location = new System.Drawing.Point(172, 174);
            this.KMtxtFecMuerteNA.Mask = "00/00/0000";
            this.KMtxtFecMuerteNA.Name = "KMtxtFecMuerteNA";
            this.KMtxtFecMuerteNA.Size = new System.Drawing.Size(107, 33);
            this.KMtxtFecMuerteNA.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KMtxtFecMuerteNA.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KMtxtFecMuerteNA.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KMtxtFecMuerteNA.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KMtxtFecMuerteNA.StateCommon.Border.Rounding = 10;
            this.KMtxtFecMuerteNA.StateCommon.Border.Width = 2;
            this.KMtxtFecMuerteNA.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMtxtFecMuerteNA.TabIndex = 159;
            this.KMtxtFecMuerteNA.Text = "  /  /";
            // 
            // KMtxtFecNacimientoNA
            // 
            this.KMtxtFecNacimientoNA.Location = new System.Drawing.Point(172, 135);
            this.KMtxtFecNacimientoNA.Mask = "00/00/0000";
            this.KMtxtFecNacimientoNA.Name = "KMtxtFecNacimientoNA";
            this.KMtxtFecNacimientoNA.Size = new System.Drawing.Size(107, 33);
            this.KMtxtFecNacimientoNA.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KMtxtFecNacimientoNA.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KMtxtFecNacimientoNA.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KMtxtFecNacimientoNA.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KMtxtFecNacimientoNA.StateCommon.Border.Rounding = 10;
            this.KMtxtFecNacimientoNA.StateCommon.Border.Width = 2;
            this.KMtxtFecNacimientoNA.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMtxtFecNacimientoNA.TabIndex = 158;
            this.KMtxtFecNacimientoNA.Text = "  /  /";
            // 
            // MBtnAniadirImagenAu
            // 
            this.MBtnAniadirImagenAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnAniadirImagenAu.FlatAppearance.BorderSize = 0;
            this.MBtnAniadirImagenAu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAniadirImagenAu.IconChar = FontAwesome.Sharp.MaterialIcons.FileImagePlusOutline;
            this.MBtnAniadirImagenAu.IconColor = System.Drawing.Color.Navy;
            this.MBtnAniadirImagenAu.Location = new System.Drawing.Point(455, 164);
            this.MBtnAniadirImagenAu.Name = "MBtnAniadirImagenAu";
            this.MBtnAniadirImagenAu.Size = new System.Drawing.Size(30, 30);
            this.MBtnAniadirImagenAu.TabIndex = 149;
            this.MBtnAniadirImagenAu.UseVisualStyleBackColor = true;
            this.MBtnAniadirImagenAu.Click += new System.EventHandler(this.MBtnAniadirImagenAu_Click);
            // 
            // MBtnBorrarImagenAu
            // 
            this.MBtnBorrarImagenAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarImagenAu.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarImagenAu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarImagenAu.IconChar = FontAwesome.Sharp.MaterialIcons.FileImageMinus;
            this.MBtnBorrarImagenAu.IconColor = System.Drawing.Color.Navy;
            this.MBtnBorrarImagenAu.Location = new System.Drawing.Point(495, 164);
            this.MBtnBorrarImagenAu.Name = "MBtnBorrarImagenAu";
            this.MBtnBorrarImagenAu.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarImagenAu.TabIndex = 150;
            this.MBtnBorrarImagenAu.UseVisualStyleBackColor = true;
            this.MBtnBorrarImagenAu.Click += new System.EventHandler(this.MBtnBorrarImagenAu_Click);
            // 
            // LblComentarioAu
            // 
            this.LblComentarioAu.AutoSize = true;
            this.LblComentarioAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioAu.ForeColor = System.Drawing.Color.Navy;
            this.LblComentarioAu.Location = new System.Drawing.Point(3, 258);
            this.LblComentarioAu.Name = "LblComentarioAu";
            this.LblComentarioAu.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioAu.TabIndex = 157;
            this.LblComentarioAu.Text = "Comentario";
            // 
            // KTxtComentarioAu
            // 
            this.KTxtComentarioAu.Location = new System.Drawing.Point(172, 252);
            this.KTxtComentarioAu.Multiline = true;
            this.KTxtComentarioAu.Name = "KTxtComentarioAu";
            this.KTxtComentarioAu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioAu.Size = new System.Drawing.Size(369, 85);
            this.KTxtComentarioAu.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtComentarioAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioAu.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioAu.StateCommon.Border.Width = 2;
            this.KTxtComentarioAu.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtComentarioAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioAu.TabIndex = 151;
            // 
            // LblEnlaceAu
            // 
            this.LblEnlaceAu.AutoSize = true;
            this.LblEnlaceAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnlaceAu.ForeColor = System.Drawing.Color.Navy;
            this.LblEnlaceAu.Location = new System.Drawing.Point(3, 219);
            this.LblEnlaceAu.Name = "LblEnlaceAu";
            this.LblEnlaceAu.Size = new System.Drawing.Size(155, 20);
            this.LblEnlaceAu.TabIndex = 156;
            this.LblEnlaceAu.Text = "Enlace de referencia";
            // 
            // KTxtEnlaceAu
            // 
            this.KTxtEnlaceAu.Location = new System.Drawing.Point(172, 213);
            this.KTxtEnlaceAu.Name = "KTxtEnlaceAu";
            this.KTxtEnlaceAu.Size = new System.Drawing.Size(369, 33);
            this.KTxtEnlaceAu.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtEnlaceAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtEnlaceAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtEnlaceAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtEnlaceAu.StateCommon.Border.Rounding = 10;
            this.KTxtEnlaceAu.StateCommon.Border.Width = 2;
            this.KTxtEnlaceAu.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtEnlaceAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtEnlaceAu.TabIndex = 148;
            // 
            // LblDefuncionAu
            // 
            this.LblDefuncionAu.AutoSize = true;
            this.LblDefuncionAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefuncionAu.ForeColor = System.Drawing.Color.Navy;
            this.LblDefuncionAu.Location = new System.Drawing.Point(3, 180);
            this.LblDefuncionAu.Name = "LblDefuncionAu";
            this.LblDefuncionAu.Size = new System.Drawing.Size(147, 20);
            this.LblDefuncionAu.TabIndex = 155;
            this.LblDefuncionAu.Text = "Fecha de defunción";
            // 
            // LblAliasAu
            // 
            this.LblAliasAu.AutoSize = true;
            this.LblAliasAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAliasAu.ForeColor = System.Drawing.Color.Navy;
            this.LblAliasAu.Location = new System.Drawing.Point(3, 63);
            this.LblAliasAu.Name = "LblAliasAu";
            this.LblAliasAu.Size = new System.Drawing.Size(42, 20);
            this.LblAliasAu.TabIndex = 154;
            this.LblAliasAu.Text = "Alias";
            // 
            // KtxtAliasAu
            // 
            this.KtxtAliasAu.Location = new System.Drawing.Point(172, 57);
            this.KtxtAliasAu.Name = "KtxtAliasAu";
            this.KtxtAliasAu.Size = new System.Drawing.Size(235, 33);
            this.KtxtAliasAu.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KtxtAliasAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KtxtAliasAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KtxtAliasAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KtxtAliasAu.StateCommon.Border.Rounding = 10;
            this.KtxtAliasAu.StateCommon.Border.Width = 2;
            this.KtxtAliasAu.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KtxtAliasAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KtxtAliasAu.TabIndex = 147;
            // 
            // LblNacimientoAu
            // 
            this.LblNacimientoAu.AutoSize = true;
            this.LblNacimientoAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimientoAu.ForeColor = System.Drawing.Color.Navy;
            this.LblNacimientoAu.Location = new System.Drawing.Point(3, 141);
            this.LblNacimientoAu.Name = "LblNacimientoAu";
            this.LblNacimientoAu.Size = new System.Drawing.Size(155, 20);
            this.LblNacimientoAu.TabIndex = 153;
            this.LblNacimientoAu.Text = "Fecha de nacimiento";
            // 
            // LblNombreNA
            // 
            this.LblNombreNA.AutoSize = true;
            this.LblNombreNA.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreNA.ForeColor = System.Drawing.Color.Navy;
            this.LblNombreNA.Location = new System.Drawing.Point(3, 24);
            this.LblNombreNA.Name = "LblNombreNA";
            this.LblNombreNA.Size = new System.Drawing.Size(136, 20);
            this.LblNombreNA.TabIndex = 152;
            this.LblNombreNA.Text = "Nombre completo";
            // 
            // KTxtNombreAu
            // 
            this.KTxtNombreAu.Location = new System.Drawing.Point(172, 18);
            this.KTxtNombreAu.Name = "KTxtNombreAu";
            this.KTxtNombreAu.Size = new System.Drawing.Size(235, 33);
            this.KTxtNombreAu.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombreAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreAu.StateCommon.Border.Rounding = 10;
            this.KTxtNombreAu.StateCommon.Border.Width = 2;
            this.KTxtNombreAu.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtNombreAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreAu.TabIndex = 145;
            // 
            // PcbAutorNA
            // 
            this.PcbAutorNA.Image = global::OpenLibraryEditor.Properties.Resources.silueta;
            this.PcbAutorNA.Location = new System.Drawing.Point(428, 18);
            this.PcbAutorNA.Name = "PcbAutorNA";
            this.PcbAutorNA.Size = new System.Drawing.Size(120, 140);
            this.PcbAutorNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAutorNA.TabIndex = 146;
            this.PcbAutorNA.TabStop = false;
            // 
            // FrmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.MBtnMasLsvNA);
            this.Controls.Add(this.MBtnMenosLsvNA);
            this.Controls.Add(this.LsvAutoresNA);
            this.Controls.Add(this.PanBtnAu);
            this.Controls.Add(this.PanTituloAutores);
            this.Controls.Add(this.PanOpcionesNA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutores";
            this.Load += new System.EventHandler(this.FrmAutores_Load);
            this.PanTituloAutores.ResumeLayout(false);
            this.PanTituloAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).EndInit();
            this.PanBtnAu.ResumeLayout(false);
            this.PanOpcionesNA.ResumeLayout(false);
            this.PanOpcionesNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOcupacionNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAutorNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloAutores;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarAutores;
        private System.Windows.Forms.Label LblTituloAutores;
        private System.Windows.Forms.PictureBox PcbLogoAutores;
        private System.Windows.Forms.Panel PanBtnAu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarAu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarAu;
        private System.Windows.Forms.ListView LsvAutoresNA;
        private System.Windows.Forms.ColumnHeader ChNombreAutor;
        private System.Windows.Forms.ColumnHeader ChOcupacionAu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNA;
        private System.Windows.Forms.Panel PanOpcionesNA;
        private System.Windows.Forms.Label LblOcupacionNA;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOcupacionNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasOcupacionNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosOcupacionNA;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox KMtxtFecMuerteNA;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox KMtxtFecNacimientoNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAniadirImagenAu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarImagenAu;
        private System.Windows.Forms.Label LblComentarioAu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioAu;
        private System.Windows.Forms.Label LblEnlaceAu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtEnlaceAu;
        private System.Windows.Forms.Label LblDefuncionAu;
        private System.Windows.Forms.Label LblAliasAu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KtxtAliasAu;
        private System.Windows.Forms.Label LblNacimientoAu;
        private System.Windows.Forms.Label LblNombreNA;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreAu;
        private System.Windows.Forms.PictureBox PcbAutorNA;
        private System.Windows.Forms.ToolTip TTAutores;
    }
}