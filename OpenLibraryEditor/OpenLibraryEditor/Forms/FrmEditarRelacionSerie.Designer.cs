namespace OpenLibraryEditor.Forms
{
    partial class FrmEditarRelacionSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarRelacionSerie));
            this.PanBtnReSe = new System.Windows.Forms.Panel();
            this.KBtnCancelarRS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarRS = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanTituloRelacionSerie = new System.Windows.Forms.Panel();
            this.MBtnCerrarReSe = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloReSe = new System.Windows.Forms.Label();
            this.PcbLogoReSe = new System.Windows.Forms.PictureBox();
            this.KGbSerieRS = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.LsvSeriesRS = new System.Windows.Forms.ListView();
            this.ChNombreRS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChEstadoRS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KCmbtipoRelacionRS = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblTipoRelacionRS = new System.Windows.Forms.Label();
            this.PcbRS = new System.Windows.Forms.PictureBox();
            this.MBtnMasRS = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosRS = new FontAwesome.Sharp.Material.MaterialButton();
            this.TTrs = new System.Windows.Forms.ToolTip(this.components);
            this.PanBtnReSe.SuspendLayout();
            this.PanTituloRelacionSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoReSe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KGbSerieRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KGbSerieRS.Panel)).BeginInit();
            this.KGbSerieRS.Panel.SuspendLayout();
            this.KGbSerieRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbtipoRelacionRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbRS)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtnReSe
            // 
            this.PanBtnReSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnReSe.Controls.Add(this.KBtnCancelarRS);
            this.PanBtnReSe.Controls.Add(this.KBtnAceptarRS);
            this.PanBtnReSe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnReSe.Location = new System.Drawing.Point(0, 454);
            this.PanBtnReSe.Name = "PanBtnReSe";
            this.PanBtnReSe.Size = new System.Drawing.Size(805, 45);
            this.PanBtnReSe.TabIndex = 102;
            // 
            // KBtnCancelarRS
            // 
            this.KBtnCancelarRS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarRS.Location = new System.Drawing.Point(532, 5);
            this.KBtnCancelarRS.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarRS.Name = "KBtnCancelarRS";
            this.KBtnCancelarRS.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarRS.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarRS.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarRS.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarRS.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarRS.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarRS.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarRS.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarRS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarRS.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarRS.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarRS.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarRS.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarRS.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarRS.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarRS.StateCommon.Border.Width = 2;
            this.KBtnCancelarRS.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarRS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarRS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarRS.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarRS.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarRS.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarRS.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarRS.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarRS.StateNormal.Border.Width = 2;
            this.KBtnCancelarRS.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarRS.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarRS.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarRS.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarRS.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarRS.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarRS.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarRS.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarRS.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarRS.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarRS.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarRS.TabIndex = 1;
            this.KBtnCancelarRS.Values.Text = "Cancelar";
            this.KBtnCancelarRS.Click += new System.EventHandler(this.KBtnCancelarRS_Click);
            // 
            // KBtnAceptarRS
            // 
            this.KBtnAceptarRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarRS.Location = new System.Drawing.Point(670, 5);
            this.KBtnAceptarRS.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarRS.Name = "KBtnAceptarRS";
            this.KBtnAceptarRS.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarRS.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarRS.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarRS.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarRS.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarRS.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarRS.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarRS.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarRS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarRS.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarRS.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarRS.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarRS.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarRS.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarRS.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarRS.StateCommon.Border.Width = 2;
            this.KBtnAceptarRS.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarRS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarRS.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarRS.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarRS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarRS.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarRS.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarRS.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarRS.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarRS.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarRS.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarRS.StateNormal.Border.Width = 2;
            this.KBtnAceptarRS.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarRS.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarRS.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarRS.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarRS.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarRS.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarRS.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarRS.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarRS.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarRS.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarRS.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarRS.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarRS.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarRS.TabIndex = 0;
            this.KBtnAceptarRS.Values.Text = "Aceptar";
            this.KBtnAceptarRS.Click += new System.EventHandler(this.KBtnAceptarRS_Click);
            // 
            // PanTituloRelacionSerie
            // 
            this.PanTituloRelacionSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloRelacionSerie.Controls.Add(this.MBtnCerrarReSe);
            this.PanTituloRelacionSerie.Controls.Add(this.LblTituloReSe);
            this.PanTituloRelacionSerie.Controls.Add(this.PcbLogoReSe);
            this.PanTituloRelacionSerie.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloRelacionSerie.Location = new System.Drawing.Point(0, 0);
            this.PanTituloRelacionSerie.Name = "PanTituloRelacionSerie";
            this.PanTituloRelacionSerie.Size = new System.Drawing.Size(805, 40);
            this.PanTituloRelacionSerie.TabIndex = 101;
            this.PanTituloRelacionSerie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloRelacionSerie_MouseDown);
            // 
            // MBtnCerrarReSe
            // 
            this.MBtnCerrarReSe.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarReSe.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarReSe.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarReSe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarReSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarReSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarReSe.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarReSe.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarReSe.IconSize = 40;
            this.MBtnCerrarReSe.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarReSe.Name = "MBtnCerrarReSe";
            this.MBtnCerrarReSe.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarReSe.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarReSe.TabIndex = 28;
            this.MBtnCerrarReSe.UseVisualStyleBackColor = false;
            this.MBtnCerrarReSe.Click += new System.EventHandler(this.MBtnCerrarReSe_Click);
            // 
            // LblTituloReSe
            // 
            this.LblTituloReSe.AutoSize = true;
            this.LblTituloReSe.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloReSe.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloReSe.Location = new System.Drawing.Point(54, 9);
            this.LblTituloReSe.Name = "LblTituloReSe";
            this.LblTituloReSe.Size = new System.Drawing.Size(399, 23);
            this.LblTituloReSe.TabIndex = 4;
            this.LblTituloReSe.Text = "Open Library Editor - Editar relación entre series";
            // 
            // PcbLogoReSe
            // 
            this.PcbLogoReSe.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoReSe.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoReSe.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoReSe.Name = "PcbLogoReSe";
            this.PcbLogoReSe.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoReSe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoReSe.TabIndex = 3;
            this.PcbLogoReSe.TabStop = false;
            // 
            // KGbSerieRS
            // 
            this.KGbSerieRS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KGbSerieRS.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KGbSerieRS.Location = new System.Drawing.Point(25, 60);
            this.KGbSerieRS.Name = "KGbSerieRS";
            // 
            // KGbSerieRS.Panel
            // 
            this.KGbSerieRS.Panel.Controls.Add(this.LsvSeriesRS);
            this.KGbSerieRS.Size = new System.Drawing.Size(260, 364);
            this.KGbSerieRS.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KGbSerieRS.StateCommon.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.KGbSerieRS.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KGbSerieRS.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KGbSerieRS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KGbSerieRS.StateCommon.Border.Rounding = 0;
            this.KGbSerieRS.StateCommon.Border.Width = 2;
            this.KGbSerieRS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KGbSerieRS.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Navy;
            this.KGbSerieRS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KGbSerieRS.TabIndex = 144;
            this.KGbSerieRS.Values.Heading = "Serie";
            // 
            // LsvSeriesRS
            // 
            this.LsvSeriesRS.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvSeriesRS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvSeriesRS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreRS,
            this.ChEstadoRS});
            this.LsvSeriesRS.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvSeriesRS.HideSelection = false;
            this.LsvSeriesRS.Location = new System.Drawing.Point(3, 8);
            this.LsvSeriesRS.MultiSelect = false;
            this.LsvSeriesRS.Name = "LsvSeriesRS";
            this.LsvSeriesRS.Size = new System.Drawing.Size(250, 317);
            this.LsvSeriesRS.TabIndex = 140;
            this.LsvSeriesRS.UseCompatibleStateImageBehavior = false;
            this.LsvSeriesRS.View = System.Windows.Forms.View.Details;
            this.LsvSeriesRS.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvSeriesRS_ItemSelectionChanged);
            // 
            // ChNombreRS
            // 
            this.ChNombreRS.Text = "Nombre";
            this.ChNombreRS.Width = 122;
            // 
            // ChEstadoRS
            // 
            this.ChEstadoRS.Text = "Estado";
            this.ChEstadoRS.Width = 104;
            // 
            // KCmbtipoRelacionRS
            // 
            this.KCmbtipoRelacionRS.DropDownWidth = 228;
            this.KCmbtipoRelacionRS.Location = new System.Drawing.Point(340, 97);
            this.KCmbtipoRelacionRS.Name = "KCmbtipoRelacionRS";
            this.KCmbtipoRelacionRS.Size = new System.Drawing.Size(309, 33);
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Navy;
            this.KCmbtipoRelacionRS.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbtipoRelacionRS.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KCmbtipoRelacionRS.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbtipoRelacionRS.TabIndex = 149;
            // 
            // LblTipoRelacionRS
            // 
            this.LblTipoRelacionRS.AutoSize = true;
            this.LblTipoRelacionRS.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoRelacionRS.ForeColor = System.Drawing.Color.Navy;
            this.LblTipoRelacionRS.Location = new System.Drawing.Point(340, 70);
            this.LblTipoRelacionRS.Name = "LblTipoRelacionRS";
            this.LblTipoRelacionRS.Size = new System.Drawing.Size(123, 20);
            this.LblTipoRelacionRS.TabIndex = 148;
            this.LblTipoRelacionRS.Text = "Tipo de relación";
            // 
            // PcbRS
            // 
            this.PcbRS.Image = global::OpenLibraryEditor.Properties.Resources.imagen;
            this.PcbRS.Location = new System.Drawing.Point(340, 160);
            this.PcbRS.Name = "PcbRS";
            this.PcbRS.Size = new System.Drawing.Size(190, 265);
            this.PcbRS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbRS.TabIndex = 145;
            this.PcbRS.TabStop = false;
            // 
            // MBtnMasRS
            // 
            this.MBtnMasRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasRS.FlatAppearance.BorderSize = 0;
            this.MBtnMasRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasRS.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.MBtnMasRS.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasRS.IconSize = 40;
            this.MBtnMasRS.Location = new System.Drawing.Point(654, 98);
            this.MBtnMasRS.Name = "MBtnMasRS";
            this.MBtnMasRS.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasRS.TabIndex = 150;
            this.MBtnMasRS.UseVisualStyleBackColor = true;
            this.MBtnMasRS.Click += new System.EventHandler(this.MBtnMasRS_Click);
            // 
            // MBtnMenosRS
            // 
            this.MBtnMenosRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosRS.FlatAppearance.BorderSize = 0;
            this.MBtnMenosRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosRS.IconChar = FontAwesome.Sharp.MaterialIcons.MinusCircleOutline;
            this.MBtnMenosRS.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosRS.IconSize = 40;
            this.MBtnMenosRS.Location = new System.Drawing.Point(685, 98);
            this.MBtnMenosRS.Name = "MBtnMenosRS";
            this.MBtnMenosRS.Size = new System.Drawing.Size(30, 30);
            this.MBtnMenosRS.TabIndex = 151;
            this.MBtnMenosRS.UseVisualStyleBackColor = true;
            this.MBtnMenosRS.Click += new System.EventHandler(this.MBtnMenosRS_Click);
            // 
            // FrmEditarRelacionSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.MBtnMasRS);
            this.Controls.Add(this.MBtnMenosRS);
            this.Controls.Add(this.KCmbtipoRelacionRS);
            this.Controls.Add(this.LblTipoRelacionRS);
            this.Controls.Add(this.PcbRS);
            this.Controls.Add(this.KGbSerieRS);
            this.Controls.Add(this.PanBtnReSe);
            this.Controls.Add(this.PanTituloRelacionSerie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarRelacionSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarRelacionSerie";
            this.PanBtnReSe.ResumeLayout(false);
            this.PanTituloRelacionSerie.ResumeLayout(false);
            this.PanTituloRelacionSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoReSe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KGbSerieRS.Panel)).EndInit();
            this.KGbSerieRS.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KGbSerieRS)).EndInit();
            this.KGbSerieRS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbtipoRelacionRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanBtnReSe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarRS;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarRS;
        private System.Windows.Forms.Panel PanTituloRelacionSerie;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarReSe;
        private System.Windows.Forms.Label LblTituloReSe;
        private System.Windows.Forms.PictureBox PcbLogoReSe;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KGbSerieRS;
        private System.Windows.Forms.ListView LsvSeriesRS;
        private System.Windows.Forms.ColumnHeader ChNombreRS;
        private System.Windows.Forms.ColumnHeader ChEstadoRS;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbtipoRelacionRS;
        private System.Windows.Forms.Label LblTipoRelacionRS;
        private System.Windows.Forms.PictureBox PcbRS;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasRS;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosRS;
        private System.Windows.Forms.ToolTip TTrs;
    }
}