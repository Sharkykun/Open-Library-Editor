namespace OpenLibraryEditor.Forms
{
    partial class FrmTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTags));
            this.PanBtnTa = new System.Windows.Forms.Panel();
            this.KBtnCancelarTag = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarTag = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanTituloTags = new System.Windows.Forms.Panel();
            this.MBtnCerrarTags = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloTags = new System.Windows.Forms.Label();
            this.PcbLogoTags = new System.Windows.Forms.PictureBox();
            this.LsvTagsNT = new System.Windows.Forms.ListView();
            this.ChNombreTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvNT = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNT = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanOpcionesTag = new System.Windows.Forms.Panel();
            this.KCmbCategoriaNE = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblCategoriaTa = new System.Windows.Forms.Label();
            this.LblNombreTa = new System.Windows.Forms.Label();
            this.KTxtNombreNE = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnMasCategoriaTag = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosCategoriaTag = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioTa = new System.Windows.Forms.Label();
            this.KTxtComentarioTa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TTEtiquetas = new System.Windows.Forms.ToolTip(this.components);
            this.PanBtnTa.SuspendLayout();
            this.PanTituloTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoTags)).BeginInit();
            this.PanOpcionesTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbCategoriaNE)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtnTa
            // 
            this.PanBtnTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnTa.Controls.Add(this.KBtnCancelarTag);
            this.PanBtnTa.Controls.Add(this.KBtnAceptarTag);
            this.PanBtnTa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnTa.Location = new System.Drawing.Point(0, 454);
            this.PanBtnTa.Name = "PanBtnTa";
            this.PanBtnTa.Size = new System.Drawing.Size(805, 45);
            this.PanBtnTa.TabIndex = 120;
            // 
            // KBtnCancelarTag
            // 
            this.KBtnCancelarTag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarTag.Location = new System.Drawing.Point(532, 5);
            this.KBtnCancelarTag.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarTag.Name = "KBtnCancelarTag";
            this.KBtnCancelarTag.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTag.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTag.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTag.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTag.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarTag.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarTag.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarTag.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarTag.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTag.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTag.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTag.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarTag.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTag.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTag.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarTag.StateCommon.Border.Width = 2;
            this.KBtnCancelarTag.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarTag.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarTag.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarTag.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTag.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTag.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTag.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTag.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarTag.StateNormal.Border.Width = 2;
            this.KBtnCancelarTag.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTag.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarTag.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarTag.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarTag.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTag.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTag.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTag.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTag.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTag.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarTag.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarTag.TabIndex = 1;
            this.KBtnCancelarTag.Values.Text = "Cancelar";
            this.KBtnCancelarTag.Click += new System.EventHandler(this.KBtnCancelarTa_Click);
            // 
            // KBtnAceptarTag
            // 
            this.KBtnAceptarTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarTag.Location = new System.Drawing.Point(670, 5);
            this.KBtnAceptarTag.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarTag.Name = "KBtnAceptarTag";
            this.KBtnAceptarTag.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTag.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTag.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarTag.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarTag.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTag.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTag.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarTag.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarTag.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTag.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarTag.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarTag.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarTag.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTag.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTag.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarTag.StateCommon.Border.Width = 2;
            this.KBtnAceptarTag.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarTag.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTag.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTag.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarTag.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarTag.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTag.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTag.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarTag.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarTag.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTag.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarTag.StateNormal.Border.Width = 2;
            this.KBtnAceptarTag.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTag.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTag.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarTag.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarTag.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarTag.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTag.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarTag.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTag.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTag.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTag.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTag.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTag.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTag.TabIndex = 0;
            this.KBtnAceptarTag.Values.Text = "Aceptar";
            this.KBtnAceptarTag.Click += new System.EventHandler(this.KBtnAceptarTa_Click);
            // 
            // PanTituloTags
            // 
            this.PanTituloTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloTags.Controls.Add(this.MBtnCerrarTags);
            this.PanTituloTags.Controls.Add(this.LblTituloTags);
            this.PanTituloTags.Controls.Add(this.PcbLogoTags);
            this.PanTituloTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloTags.Location = new System.Drawing.Point(0, 0);
            this.PanTituloTags.Name = "PanTituloTags";
            this.PanTituloTags.Size = new System.Drawing.Size(805, 40);
            this.PanTituloTags.TabIndex = 119;
            this.PanTituloTags.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloTags_MouseDown);
            // 
            // MBtnCerrarTags
            // 
            this.MBtnCerrarTags.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarTags.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarTags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarTags.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarTags.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarTags.IconSize = 40;
            this.MBtnCerrarTags.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarTags.Name = "MBtnCerrarTags";
            this.MBtnCerrarTags.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarTags.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarTags.TabIndex = 28;
            this.MBtnCerrarTags.UseVisualStyleBackColor = false;
            this.MBtnCerrarTags.Click += new System.EventHandler(this.MBtnCerrarTags_Click);
            // 
            // LblTituloTags
            // 
            this.LblTituloTags.AutoSize = true;
            this.LblTituloTags.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloTags.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloTags.Location = new System.Drawing.Point(54, 9);
            this.LblTituloTags.Name = "LblTituloTags";
            this.LblTituloTags.Size = new System.Drawing.Size(305, 23);
            this.LblTituloTags.TabIndex = 4;
            this.LblTituloTags.Text = "Open Library Editor - Nueva Etiqueta";
            // 
            // PcbLogoTags
            // 
            this.PcbLogoTags.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoTags.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoTags.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoTags.Name = "PcbLogoTags";
            this.PcbLogoTags.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoTags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoTags.TabIndex = 3;
            this.PcbLogoTags.TabStop = false;
            // 
            // LsvTagsNT
            // 
            this.LsvTagsNT.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvTagsNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvTagsNT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreTag,
            this.ChCategoria});
            this.LsvTagsNT.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvTagsNT.HideSelection = false;
            this.LsvTagsNT.Location = new System.Drawing.Point(25, 70);
            this.LsvTagsNT.MultiSelect = false;
            this.LsvTagsNT.Name = "LsvTagsNT";
            this.LsvTagsNT.Size = new System.Drawing.Size(308, 313);
            this.LsvTagsNT.TabIndex = 130;
            this.LsvTagsNT.UseCompatibleStateImageBehavior = false;
            this.LsvTagsNT.View = System.Windows.Forms.View.Details;
            this.LsvTagsNT.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvTagsNT_ItemSelectionChanged);
            // 
            // ChNombreTag
            // 
            this.ChNombreTag.Text = "Nombre";
            this.ChNombreTag.Width = 164;
            // 
            // ChCategoria
            // 
            this.ChCategoria.Text = "Categoría";
            this.ChCategoria.Width = 141;
            // 
            // MBtnMasLsvNT
            // 
            this.MBtnMasLsvNT.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNT.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNT.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNT.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasLsvNT.IconSize = 65;
            this.MBtnMasLsvNT.Location = new System.Drawing.Point(25, 389);
            this.MBtnMasLsvNT.Name = "MBtnMasLsvNT";
            this.MBtnMasLsvNT.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNT.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNT.TabIndex = 135;
            this.MBtnMasLsvNT.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNT.Click += new System.EventHandler(this.MBtnMasLsvNT_Click);
            // 
            // MBtnMenosLsvNT
            // 
            this.MBtnMenosLsvNT.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNT.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNT.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNT.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosLsvNT.IconSize = 65;
            this.MBtnMenosLsvNT.Location = new System.Drawing.Point(82, 389);
            this.MBtnMenosLsvNT.Name = "MBtnMenosLsvNT";
            this.MBtnMenosLsvNT.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNT.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNT.TabIndex = 136;
            this.MBtnMenosLsvNT.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNT.Click += new System.EventHandler(this.MBtnMenosLsvNT_Click);
            // 
            // PanOpcionesTag
            // 
            this.PanOpcionesTag.Controls.Add(this.KCmbCategoriaNE);
            this.PanOpcionesTag.Controls.Add(this.LblCategoriaTa);
            this.PanOpcionesTag.Controls.Add(this.LblNombreTa);
            this.PanOpcionesTag.Controls.Add(this.KTxtNombreNE);
            this.PanOpcionesTag.Controls.Add(this.MBtnMasCategoriaTag);
            this.PanOpcionesTag.Controls.Add(this.MBtnMenosCategoriaTag);
            this.PanOpcionesTag.Controls.Add(this.LblComentarioTa);
            this.PanOpcionesTag.Controls.Add(this.KTxtComentarioTa);
            this.PanOpcionesTag.Location = new System.Drawing.Point(350, 60);
            this.PanOpcionesTag.Name = "PanOpcionesTag";
            this.PanOpcionesTag.Size = new System.Drawing.Size(443, 345);
            this.PanOpcionesTag.TabIndex = 137;
            this.PanOpcionesTag.Visible = false;
            // 
            // KCmbCategoriaNE
            // 
            this.KCmbCategoriaNE.DropDownWidth = 228;
            this.KCmbCategoriaNE.Location = new System.Drawing.Point(30, 104);
            this.KCmbCategoriaNE.Name = "KCmbCategoriaNE";
            this.KCmbCategoriaNE.Size = new System.Drawing.Size(315, 33);
            this.KCmbCategoriaNE.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbCategoriaNE.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Navy;
            this.KCmbCategoriaNE.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbCategoriaNE.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KCmbCategoriaNE.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbCategoriaNE.TabIndex = 137;
            // 
            // LblCategoriaTa
            // 
            this.LblCategoriaTa.AutoSize = true;
            this.LblCategoriaTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoriaTa.ForeColor = System.Drawing.Color.Navy;
            this.LblCategoriaTa.Location = new System.Drawing.Point(30, 81);
            this.LblCategoriaTa.Name = "LblCategoriaTa";
            this.LblCategoriaTa.Size = new System.Drawing.Size(78, 20);
            this.LblCategoriaTa.TabIndex = 136;
            this.LblCategoriaTa.Text = "Categoría";
            // 
            // LblNombreTa
            // 
            this.LblNombreTa.AutoSize = true;
            this.LblNombreTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTa.ForeColor = System.Drawing.Color.Navy;
            this.LblNombreTa.Location = new System.Drawing.Point(30, 10);
            this.LblNombreTa.Name = "LblNombreTa";
            this.LblNombreTa.Size = new System.Drawing.Size(127, 20);
            this.LblNombreTa.TabIndex = 135;
            this.LblNombreTa.Text = "Nombre etiqueta";
            // 
            // KTxtNombreNE
            // 
            this.KTxtNombreNE.Location = new System.Drawing.Point(30, 32);
            this.KTxtNombreNE.Name = "KTxtNombreNE";
            this.KTxtNombreNE.Size = new System.Drawing.Size(382, 33);
            this.KTxtNombreNE.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombreNE.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreNE.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreNE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreNE.StateCommon.Border.Rounding = 10;
            this.KTxtNombreNE.StateCommon.Border.Width = 2;
            this.KTxtNombreNE.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtNombreNE.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreNE.TabIndex = 134;
            // 
            // MBtnMasCategoriaTag
            // 
            this.MBtnMasCategoriaTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasCategoriaTag.FlatAppearance.BorderSize = 0;
            this.MBtnMasCategoriaTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasCategoriaTag.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.MBtnMasCategoriaTag.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasCategoriaTag.IconSize = 40;
            this.MBtnMasCategoriaTag.Location = new System.Drawing.Point(351, 107);
            this.MBtnMasCategoriaTag.Name = "MBtnMasCategoriaTag";
            this.MBtnMasCategoriaTag.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasCategoriaTag.TabIndex = 130;
            this.MBtnMasCategoriaTag.UseVisualStyleBackColor = true;
            this.MBtnMasCategoriaTag.Click += new System.EventHandler(this.MBtnMasCategoriaTa_Click);
            // 
            // MBtnMenosCategoriaTag
            // 
            this.MBtnMenosCategoriaTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosCategoriaTag.FlatAppearance.BorderSize = 0;
            this.MBtnMenosCategoriaTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosCategoriaTag.IconChar = FontAwesome.Sharp.MaterialIcons.MinusCircleOutline;
            this.MBtnMenosCategoriaTag.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosCategoriaTag.IconSize = 40;
            this.MBtnMenosCategoriaTag.Location = new System.Drawing.Point(382, 107);
            this.MBtnMenosCategoriaTag.Name = "MBtnMenosCategoriaTag";
            this.MBtnMenosCategoriaTag.Size = new System.Drawing.Size(30, 30);
            this.MBtnMenosCategoriaTag.TabIndex = 131;
            this.MBtnMenosCategoriaTag.UseVisualStyleBackColor = true;
            this.MBtnMenosCategoriaTag.Click += new System.EventHandler(this.MBtnMenosCategoriaTag_Click);
            // 
            // LblComentarioTa
            // 
            this.LblComentarioTa.AutoSize = true;
            this.LblComentarioTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioTa.ForeColor = System.Drawing.Color.Navy;
            this.LblComentarioTa.Location = new System.Drawing.Point(30, 157);
            this.LblComentarioTa.Name = "LblComentarioTa";
            this.LblComentarioTa.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioTa.TabIndex = 133;
            this.LblComentarioTa.Text = "Comentario";
            // 
            // KTxtComentarioTa
            // 
            this.KTxtComentarioTa.Location = new System.Drawing.Point(30, 180);
            this.KTxtComentarioTa.Multiline = true;
            this.KTxtComentarioTa.Name = "KTxtComentarioTa";
            this.KTxtComentarioTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioTa.Size = new System.Drawing.Size(382, 143);
            this.KTxtComentarioTa.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtComentarioTa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioTa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioTa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioTa.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioTa.StateCommon.Border.Width = 2;
            this.KTxtComentarioTa.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtComentarioTa.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioTa.TabIndex = 132;
            // 
            // FrmTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.MBtnMasLsvNT);
            this.Controls.Add(this.MBtnMenosLsvNT);
            this.Controls.Add(this.LsvTagsNT);
            this.Controls.Add(this.PanBtnTa);
            this.Controls.Add(this.PanTituloTags);
            this.Controls.Add(this.PanOpcionesTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTags";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTags_FormClosing);
            this.Load += new System.EventHandler(this.FrmTags_Load);
            this.PanBtnTa.ResumeLayout(false);
            this.PanTituloTags.ResumeLayout(false);
            this.PanTituloTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoTags)).EndInit();
            this.PanOpcionesTag.ResumeLayout(false);
            this.PanOpcionesTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbCategoriaNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanBtnTa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarTag;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarTag;
        private System.Windows.Forms.Panel PanTituloTags;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarTags;
        private System.Windows.Forms.Label LblTituloTags;
        private System.Windows.Forms.PictureBox PcbLogoTags;
        private System.Windows.Forms.ListView LsvTagsNT;
        private System.Windows.Forms.ColumnHeader ChNombreTag;
        private System.Windows.Forms.ColumnHeader ChCategoria;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNT;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNT;
        private System.Windows.Forms.Panel PanOpcionesTag;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbCategoriaNE;
        private System.Windows.Forms.Label LblCategoriaTa;
        private System.Windows.Forms.Label LblNombreTa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreNE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasCategoriaTag;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosCategoriaTag;
        private System.Windows.Forms.Label LblComentarioTa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioTa;
        private System.Windows.Forms.ToolTip TTEtiquetas;
    }
}