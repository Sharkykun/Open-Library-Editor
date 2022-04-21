namespace OpenLibraryEditor.Forms
{
    partial class FrmEditoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditoriales));
            this.PanBtnEd = new System.Windows.Forms.Panel();
            this.KBtnCancelarEd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarEd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanTituloEditoriales = new System.Windows.Forms.Panel();
            this.MBtnCerrarEditoriales = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloEditoriales = new System.Windows.Forms.Label();
            this.PcbLogoEditoriales = new System.Windows.Forms.PictureBox();
            this.LsvEditorialNE = new System.Windows.Forms.ListView();
            this.ChNombreNE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvNE = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNE = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanOpcionesED = new System.Windows.Forms.Panel();
            this.LblNombreEd = new System.Windows.Forms.Label();
            this.KTxtNombreEd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnAniadirImagenEd = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnBorrarImagenEd = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioEd = new System.Windows.Forms.Label();
            this.KTxtComentarioEd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PcbEditorialesEd = new System.Windows.Forms.PictureBox();
            this.TTEditorial = new System.Windows.Forms.ToolTip(this.components);
            this.PanBtnEd.SuspendLayout();
            this.PanTituloEditoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditoriales)).BeginInit();
            this.PanOpcionesED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEditorialesEd)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtnEd
            // 
            this.PanBtnEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnEd.Controls.Add(this.KBtnCancelarEd);
            this.PanBtnEd.Controls.Add(this.KBtnAceptarEd);
            this.PanBtnEd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnEd.Location = new System.Drawing.Point(0, 454);
            this.PanBtnEd.Name = "PanBtnEd";
            this.PanBtnEd.Size = new System.Drawing.Size(805, 45);
            this.PanBtnEd.TabIndex = 118;
            // 
            // KBtnCancelarEd
            // 
            this.KBtnCancelarEd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarEd.Location = new System.Drawing.Point(532, 5);
            this.KBtnCancelarEd.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarEd.Name = "KBtnCancelarEd";
            this.KBtnCancelarEd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarEd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarEd.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarEd.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarEd.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarEd.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarEd.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarEd.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarEd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarEd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarEd.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarEd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarEd.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarEd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarEd.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarEd.StateCommon.Border.Width = 2;
            this.KBtnCancelarEd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarEd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarEd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarEd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarEd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarEd.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarEd.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarEd.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarEd.StateNormal.Border.Width = 2;
            this.KBtnCancelarEd.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarEd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarEd.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarEd.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarEd.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarEd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarEd.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarEd.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarEd.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarEd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarEd.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarEd.TabIndex = 1;
            this.KBtnCancelarEd.Values.Text = "Cancelar";
            this.KBtnCancelarEd.Click += new System.EventHandler(this.KBtnCancelarEd_Click);
            // 
            // KBtnAceptarEd
            // 
            this.KBtnAceptarEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarEd.Location = new System.Drawing.Point(670, 5);
            this.KBtnAceptarEd.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarEd.Name = "KBtnAceptarEd";
            this.KBtnAceptarEd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarEd.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarEd.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarEd.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarEd.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarEd.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarEd.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarEd.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarEd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarEd.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarEd.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarEd.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarEd.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarEd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarEd.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarEd.StateCommon.Border.Width = 2;
            this.KBtnAceptarEd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarEd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarEd.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarEd.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarEd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarEd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarEd.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarEd.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarEd.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarEd.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarEd.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarEd.StateNormal.Border.Width = 2;
            this.KBtnAceptarEd.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarEd.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarEd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarEd.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarEd.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarEd.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarEd.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarEd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarEd.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarEd.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarEd.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarEd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarEd.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarEd.TabIndex = 0;
            this.KBtnAceptarEd.Values.Text = "Aceptar";
            this.KBtnAceptarEd.Click += new System.EventHandler(this.KBtnAceptarEd_Click);
            // 
            // PanTituloEditoriales
            // 
            this.PanTituloEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloEditoriales.Controls.Add(this.MBtnCerrarEditoriales);
            this.PanTituloEditoriales.Controls.Add(this.LblTituloEditoriales);
            this.PanTituloEditoriales.Controls.Add(this.PcbLogoEditoriales);
            this.PanTituloEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloEditoriales.Location = new System.Drawing.Point(0, 0);
            this.PanTituloEditoriales.Name = "PanTituloEditoriales";
            this.PanTituloEditoriales.Size = new System.Drawing.Size(805, 40);
            this.PanTituloEditoriales.TabIndex = 117;
            this.PanTituloEditoriales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloEditoriales_MouseDown);
            // 
            // MBtnCerrarEditoriales
            // 
            this.MBtnCerrarEditoriales.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarEditoriales.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarEditoriales.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarEditoriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarEditoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarEditoriales.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarEditoriales.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarEditoriales.IconSize = 40;
            this.MBtnCerrarEditoriales.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarEditoriales.Name = "MBtnCerrarEditoriales";
            this.MBtnCerrarEditoriales.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarEditoriales.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarEditoriales.TabIndex = 28;
            this.MBtnCerrarEditoriales.UseVisualStyleBackColor = false;
            this.MBtnCerrarEditoriales.Click += new System.EventHandler(this.MBtnCerrarEditoriales_Click);
            // 
            // LblTituloEditoriales
            // 
            this.LblTituloEditoriales.AutoSize = true;
            this.LblTituloEditoriales.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloEditoriales.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloEditoriales.Location = new System.Drawing.Point(54, 9);
            this.LblTituloEditoriales.Name = "LblTituloEditoriales";
            this.LblTituloEditoriales.Size = new System.Drawing.Size(307, 23);
            this.LblTituloEditoriales.TabIndex = 4;
            this.LblTituloEditoriales.Text = "Open Library Editor - Nueva Editorial";
            // 
            // PcbLogoEditoriales
            // 
            this.PcbLogoEditoriales.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoEditoriales.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoEditoriales.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoEditoriales.Name = "PcbLogoEditoriales";
            this.PcbLogoEditoriales.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoEditoriales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoEditoriales.TabIndex = 3;
            this.PcbLogoEditoriales.TabStop = false;
            // 
            // LsvEditorialNE
            // 
            this.LsvEditorialNE.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvEditorialNE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvEditorialNE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreNE});
            this.LsvEditorialNE.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvEditorialNE.HideSelection = false;
            this.LsvEditorialNE.Location = new System.Drawing.Point(25, 70);
            this.LsvEditorialNE.MultiSelect = false;
            this.LsvEditorialNE.Name = "LsvEditorialNE";
            this.LsvEditorialNE.Size = new System.Drawing.Size(215, 313);
            this.LsvEditorialNE.TabIndex = 126;
            this.LsvEditorialNE.UseCompatibleStateImageBehavior = false;
            this.LsvEditorialNE.View = System.Windows.Forms.View.Details;
            this.LsvEditorialNE.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvEditorialNE_ItemSelectionChanged);
            // 
            // ChNombreNE
            // 
            this.ChNombreNE.Text = "Nombre";
            this.ChNombreNE.Width = 178;
            // 
            // MBtnMasLsvNE
            // 
            this.MBtnMasLsvNE.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNE.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNE.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNE.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasLsvNE.IconSize = 65;
            this.MBtnMasLsvNE.Location = new System.Drawing.Point(25, 389);
            this.MBtnMasLsvNE.Name = "MBtnMasLsvNE";
            this.MBtnMasLsvNE.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNE.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNE.TabIndex = 135;
            this.MBtnMasLsvNE.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNE.Click += new System.EventHandler(this.MBtnMasLsvNE_Click);
            // 
            // MBtnMenosLsvNE
            // 
            this.MBtnMenosLsvNE.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNE.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNE.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNE.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosLsvNE.IconSize = 65;
            this.MBtnMenosLsvNE.Location = new System.Drawing.Point(82, 389);
            this.MBtnMenosLsvNE.Name = "MBtnMenosLsvNE";
            this.MBtnMenosLsvNE.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNE.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNE.TabIndex = 136;
            this.MBtnMenosLsvNE.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNE.Click += new System.EventHandler(this.MBtnMenosLsvNE_Click);
            // 
            // PanOpcionesED
            // 
            this.PanOpcionesED.Controls.Add(this.LblNombreEd);
            this.PanOpcionesED.Controls.Add(this.KTxtNombreEd);
            this.PanOpcionesED.Controls.Add(this.MBtnAniadirImagenEd);
            this.PanOpcionesED.Controls.Add(this.MBtnBorrarImagenEd);
            this.PanOpcionesED.Controls.Add(this.LblComentarioEd);
            this.PanOpcionesED.Controls.Add(this.KTxtComentarioEd);
            this.PanOpcionesED.Controls.Add(this.PcbEditorialesEd);
            this.PanOpcionesED.Location = new System.Drawing.Point(251, 60);
            this.PanOpcionesED.Name = "PanOpcionesED";
            this.PanOpcionesED.Size = new System.Drawing.Size(542, 348);
            this.PanOpcionesED.TabIndex = 137;
            this.PanOpcionesED.Visible = false;
            // 
            // LblNombreEd
            // 
            this.LblNombreEd.AutoSize = true;
            this.LblNombreEd.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEd.ForeColor = System.Drawing.Color.Navy;
            this.LblNombreEd.Location = new System.Drawing.Point(25, 10);
            this.LblNombreEd.Name = "LblNombreEd";
            this.LblNombreEd.Size = new System.Drawing.Size(129, 20);
            this.LblNombreEd.TabIndex = 132;
            this.LblNombreEd.Text = "Nombre editorial";
            // 
            // KTxtNombreEd
            // 
            this.KTxtNombreEd.Location = new System.Drawing.Point(25, 31);
            this.KTxtNombreEd.Name = "KTxtNombreEd";
            this.KTxtNombreEd.Size = new System.Drawing.Size(268, 33);
            this.KTxtNombreEd.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombreEd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreEd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreEd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreEd.StateCommon.Border.Rounding = 10;
            this.KTxtNombreEd.StateCommon.Border.Width = 2;
            this.KTxtNombreEd.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtNombreEd.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreEd.TabIndex = 131;
            // 
            // MBtnAniadirImagenEd
            // 
            this.MBtnAniadirImagenEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnAniadirImagenEd.FlatAppearance.BorderSize = 0;
            this.MBtnAniadirImagenEd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAniadirImagenEd.IconChar = FontAwesome.Sharp.MaterialIcons.FileImagePlusOutline;
            this.MBtnAniadirImagenEd.IconColor = System.Drawing.Color.Navy;
            this.MBtnAniadirImagenEd.Location = new System.Drawing.Point(390, 257);
            this.MBtnAniadirImagenEd.Name = "MBtnAniadirImagenEd";
            this.MBtnAniadirImagenEd.Size = new System.Drawing.Size(30, 30);
            this.MBtnAniadirImagenEd.TabIndex = 127;
            this.MBtnAniadirImagenEd.UseVisualStyleBackColor = true;
            this.MBtnAniadirImagenEd.Click += new System.EventHandler(this.MBtnAniadirImagenEd_Click);
            // 
            // MBtnBorrarImagenEd
            // 
            this.MBtnBorrarImagenEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarImagenEd.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarImagenEd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarImagenEd.IconChar = FontAwesome.Sharp.MaterialIcons.FileImageMinus;
            this.MBtnBorrarImagenEd.IconColor = System.Drawing.Color.Navy;
            this.MBtnBorrarImagenEd.Location = new System.Drawing.Point(430, 257);
            this.MBtnBorrarImagenEd.Name = "MBtnBorrarImagenEd";
            this.MBtnBorrarImagenEd.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarImagenEd.TabIndex = 128;
            this.MBtnBorrarImagenEd.UseVisualStyleBackColor = true;
            this.MBtnBorrarImagenEd.Click += new System.EventHandler(this.MBtnBorrarImagenEd_Click);
            // 
            // LblComentarioEd
            // 
            this.LblComentarioEd.AutoSize = true;
            this.LblComentarioEd.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioEd.ForeColor = System.Drawing.Color.Navy;
            this.LblComentarioEd.Location = new System.Drawing.Point(25, 81);
            this.LblComentarioEd.Name = "LblComentarioEd";
            this.LblComentarioEd.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioEd.TabIndex = 130;
            this.LblComentarioEd.Text = "Comentario";
            // 
            // KTxtComentarioEd
            // 
            this.KTxtComentarioEd.Location = new System.Drawing.Point(25, 104);
            this.KTxtComentarioEd.Multiline = true;
            this.KTxtComentarioEd.Name = "KTxtComentarioEd";
            this.KTxtComentarioEd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioEd.Size = new System.Drawing.Size(268, 219);
            this.KTxtComentarioEd.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtComentarioEd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioEd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioEd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioEd.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioEd.StateCommon.Border.Width = 2;
            this.KTxtComentarioEd.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtComentarioEd.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioEd.TabIndex = 129;
            // 
            // PcbEditorialesEd
            // 
            this.PcbEditorialesEd.Image = global::OpenLibraryEditor.Properties.Resources.imagen;
            this.PcbEditorialesEd.Location = new System.Drawing.Point(327, 10);
            this.PcbEditorialesEd.Name = "PcbEditorialesEd";
            this.PcbEditorialesEd.Size = new System.Drawing.Size(190, 240);
            this.PcbEditorialesEd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbEditorialesEd.TabIndex = 126;
            this.PcbEditorialesEd.TabStop = false;
            // 
            // FrmEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.MBtnMasLsvNE);
            this.Controls.Add(this.MBtnMenosLsvNE);
            this.Controls.Add(this.LsvEditorialNE);
            this.Controls.Add(this.PanBtnEd);
            this.Controls.Add(this.PanTituloEditoriales);
            this.Controls.Add(this.PanOpcionesED);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditoriales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditoriales_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditoriales_Load);
            this.PanBtnEd.ResumeLayout(false);
            this.PanTituloEditoriales.ResumeLayout(false);
            this.PanTituloEditoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditoriales)).EndInit();
            this.PanOpcionesED.ResumeLayout(false);
            this.PanOpcionesED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEditorialesEd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanBtnEd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarEd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarEd;
        private System.Windows.Forms.Panel PanTituloEditoriales;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarEditoriales;
        private System.Windows.Forms.Label LblTituloEditoriales;
        private System.Windows.Forms.PictureBox PcbLogoEditoriales;
        private System.Windows.Forms.ListView LsvEditorialNE;
        private System.Windows.Forms.ColumnHeader ChNombreNE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNE;
        private System.Windows.Forms.Panel PanOpcionesED;
        private System.Windows.Forms.Label LblNombreEd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreEd;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAniadirImagenEd;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarImagenEd;
        private System.Windows.Forms.Label LblComentarioEd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioEd;
        private System.Windows.Forms.PictureBox PcbEditorialesEd;
        private System.Windows.Forms.ToolTip TTEditorial;
    }
}