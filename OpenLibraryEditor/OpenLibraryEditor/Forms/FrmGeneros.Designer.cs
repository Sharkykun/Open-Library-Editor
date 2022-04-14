namespace OpenLibraryEditor.Forms
{
    partial class FrmGeneros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneros));
            this.PanTituloGeneros = new System.Windows.Forms.Panel();
            this.MBtnCerrarGeneros = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloGeneros = new System.Windows.Forms.Label();
            this.PcbLogoGeneros = new System.Windows.Forms.PictureBox();
            this.PanBtnGe = new System.Windows.Forms.Panel();
            this.KBtnCancelarGe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarGe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LsvGeneroNG = new System.Windows.Forms.ListView();
            this.ChNombreNG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChGeneroPadreNG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvNG = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNG = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanOpcionesGE = new System.Windows.Forms.Panel();
            this.KCmbGeneroPadreGe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblGeneroPadreGe = new System.Windows.Forms.Label();
            this.LblNombreGe = new System.Windows.Forms.Label();
            this.KTxtNombreGe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblComentarioGe = new System.Windows.Forms.Label();
            this.KTxtComentarioGe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PanTituloGeneros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoGeneros)).BeginInit();
            this.PanBtnGe.SuspendLayout();
            this.PanOpcionesGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbGeneroPadreGe)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTituloGeneros
            // 
            this.PanTituloGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloGeneros.Controls.Add(this.MBtnCerrarGeneros);
            this.PanTituloGeneros.Controls.Add(this.LblTituloGeneros);
            this.PanTituloGeneros.Controls.Add(this.PcbLogoGeneros);
            this.PanTituloGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloGeneros.Location = new System.Drawing.Point(0, 0);
            this.PanTituloGeneros.Name = "PanTituloGeneros";
            this.PanTituloGeneros.Size = new System.Drawing.Size(805, 40);
            this.PanTituloGeneros.TabIndex = 2;
            this.PanTituloGeneros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloGeneros_MouseDown);
            // 
            // MBtnCerrarGeneros
            // 
            this.MBtnCerrarGeneros.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarGeneros.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarGeneros.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarGeneros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarGeneros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarGeneros.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarGeneros.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarGeneros.IconSize = 40;
            this.MBtnCerrarGeneros.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarGeneros.Name = "MBtnCerrarGeneros";
            this.MBtnCerrarGeneros.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarGeneros.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarGeneros.TabIndex = 28;
            this.MBtnCerrarGeneros.UseVisualStyleBackColor = false;
            this.MBtnCerrarGeneros.Click += new System.EventHandler(this.MBtnCerrarGeneros_Click);
            // 
            // LblTituloGeneros
            // 
            this.LblTituloGeneros.AutoSize = true;
            this.LblTituloGeneros.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloGeneros.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloGeneros.Location = new System.Drawing.Point(54, 9);
            this.LblTituloGeneros.Name = "LblTituloGeneros";
            this.LblTituloGeneros.Size = new System.Drawing.Size(295, 23);
            this.LblTituloGeneros.TabIndex = 4;
            this.LblTituloGeneros.Text = "Open Library Editor - Nuevo Género";
            // 
            // PcbLogoGeneros
            // 
            this.PcbLogoGeneros.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoGeneros.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoGeneros.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoGeneros.Name = "PcbLogoGeneros";
            this.PcbLogoGeneros.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoGeneros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoGeneros.TabIndex = 3;
            this.PcbLogoGeneros.TabStop = false;
            // 
            // PanBtnGe
            // 
            this.PanBtnGe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnGe.Controls.Add(this.KBtnCancelarGe);
            this.PanBtnGe.Controls.Add(this.KBtnAceptarGe);
            this.PanBtnGe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnGe.Location = new System.Drawing.Point(0, 454);
            this.PanBtnGe.Name = "PanBtnGe";
            this.PanBtnGe.Size = new System.Drawing.Size(805, 45);
            this.PanBtnGe.TabIndex = 98;
            // 
            // KBtnCancelarGe
            // 
            this.KBtnCancelarGe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarGe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarGe.Location = new System.Drawing.Point(532, 5);
            this.KBtnCancelarGe.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarGe.Name = "KBtnCancelarGe";
            this.KBtnCancelarGe.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarGe.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarGe.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarGe.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarGe.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarGe.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarGe.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarGe.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarGe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarGe.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarGe.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarGe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarGe.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarGe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarGe.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarGe.StateCommon.Border.Width = 2;
            this.KBtnCancelarGe.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarGe.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarGe.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarGe.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarGe.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarGe.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarGe.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarGe.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarGe.StateNormal.Border.Width = 2;
            this.KBtnCancelarGe.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarGe.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarGe.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarGe.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarGe.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarGe.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarGe.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarGe.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarGe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarGe.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarGe.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarGe.TabIndex = 1;
            this.KBtnCancelarGe.Values.Text = "Cancelar";
            this.KBtnCancelarGe.Click += new System.EventHandler(this.KBtnCancelarGe_Click);
            // 
            // KBtnAceptarGe
            // 
            this.KBtnAceptarGe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarGe.Location = new System.Drawing.Point(670, 5);
            this.KBtnAceptarGe.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarGe.Name = "KBtnAceptarGe";
            this.KBtnAceptarGe.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarGe.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarGe.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarGe.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarGe.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarGe.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarGe.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarGe.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarGe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarGe.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarGe.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarGe.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarGe.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarGe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarGe.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarGe.StateCommon.Border.Width = 2;
            this.KBtnAceptarGe.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarGe.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarGe.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarGe.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarGe.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarGe.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarGe.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarGe.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarGe.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarGe.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarGe.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarGe.StateNormal.Border.Width = 2;
            this.KBtnAceptarGe.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarGe.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarGe.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarGe.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarGe.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarGe.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarGe.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarGe.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarGe.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarGe.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarGe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarGe.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarGe.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarGe.TabIndex = 0;
            this.KBtnAceptarGe.Values.Text = "Aceptar";
            this.KBtnAceptarGe.Click += new System.EventHandler(this.KBtnAceptarGe_Click);
            // 
            // LsvGeneroNG
            // 
            this.LsvGeneroNG.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvGeneroNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvGeneroNG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreNG,
            this.ChGeneroPadreNG});
            this.LsvGeneroNG.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvGeneroNG.HideSelection = false;
            this.LsvGeneroNG.Location = new System.Drawing.Point(25, 70);
            this.LsvGeneroNG.Name = "LsvGeneroNG";
            this.LsvGeneroNG.Size = new System.Drawing.Size(283, 313);
            this.LsvGeneroNG.TabIndex = 127;
            this.LsvGeneroNG.UseCompatibleStateImageBehavior = false;
            this.LsvGeneroNG.View = System.Windows.Forms.View.Details;
            this.LsvGeneroNG.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvGeneroNG_ItemSelectionChanged);
            // 
            // ChNombreNG
            // 
            this.ChNombreNG.Text = "Nombre";
            this.ChNombreNG.Width = 107;
            // 
            // ChGeneroPadreNG
            // 
            this.ChGeneroPadreNG.Text = "Género Padre";
            this.ChGeneroPadreNG.Width = 113;
            // 
            // MBtnMasLsvNG
            // 
            this.MBtnMasLsvNG.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNG.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNG.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNG.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasLsvNG.IconSize = 65;
            this.MBtnMasLsvNG.Location = new System.Drawing.Point(25, 389);
            this.MBtnMasLsvNG.Name = "MBtnMasLsvNG";
            this.MBtnMasLsvNG.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNG.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNG.TabIndex = 137;
            this.MBtnMasLsvNG.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNG.Click += new System.EventHandler(this.MBtnMasLsvNG_Click);
            // 
            // MBtnMenosLsvNG
            // 
            this.MBtnMenosLsvNG.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNG.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNG.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNG.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosLsvNG.IconSize = 65;
            this.MBtnMenosLsvNG.Location = new System.Drawing.Point(82, 389);
            this.MBtnMenosLsvNG.Name = "MBtnMenosLsvNG";
            this.MBtnMenosLsvNG.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNG.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNG.TabIndex = 138;
            this.MBtnMenosLsvNG.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNG.Click += new System.EventHandler(this.MBtnMenosLsvNG_Click);
            // 
            // PanOpcionesGE
            // 
            this.PanOpcionesGE.Controls.Add(this.KCmbGeneroPadreGe);
            this.PanOpcionesGE.Controls.Add(this.LblGeneroPadreGe);
            this.PanOpcionesGE.Controls.Add(this.LblNombreGe);
            this.PanOpcionesGE.Controls.Add(this.KTxtNombreGe);
            this.PanOpcionesGE.Controls.Add(this.LblComentarioGe);
            this.PanOpcionesGE.Controls.Add(this.KTxtComentarioGe);
            this.PanOpcionesGE.Location = new System.Drawing.Point(351, 60);
            this.PanOpcionesGE.Name = "PanOpcionesGE";
            this.PanOpcionesGE.Size = new System.Drawing.Size(407, 354);
            this.PanOpcionesGE.TabIndex = 139;
            this.PanOpcionesGE.Visible = false;
            // 
            // KCmbGeneroPadreGe
            // 
            this.KCmbGeneroPadreGe.DropDownWidth = 228;
            this.KCmbGeneroPadreGe.Location = new System.Drawing.Point(14, 92);
            this.KCmbGeneroPadreGe.Name = "KCmbGeneroPadreGe";
            this.KCmbGeneroPadreGe.Size = new System.Drawing.Size(335, 33);
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Navy;
            this.KCmbGeneroPadreGe.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbGeneroPadreGe.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KCmbGeneroPadreGe.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbGeneroPadreGe.TabIndex = 116;
            // 
            // LblGeneroPadreGe
            // 
            this.LblGeneroPadreGe.AutoSize = true;
            this.LblGeneroPadreGe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeneroPadreGe.ForeColor = System.Drawing.Color.Navy;
            this.LblGeneroPadreGe.Location = new System.Drawing.Point(14, 69);
            this.LblGeneroPadreGe.Name = "LblGeneroPadreGe";
            this.LblGeneroPadreGe.Size = new System.Drawing.Size(105, 20);
            this.LblGeneroPadreGe.TabIndex = 115;
            this.LblGeneroPadreGe.Text = "Género Padre";
            // 
            // LblNombreGe
            // 
            this.LblNombreGe.AutoSize = true;
            this.LblNombreGe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreGe.ForeColor = System.Drawing.Color.Navy;
            this.LblNombreGe.Location = new System.Drawing.Point(14, 10);
            this.LblNombreGe.Name = "LblNombreGe";
            this.LblNombreGe.Size = new System.Drawing.Size(120, 20);
            this.LblNombreGe.TabIndex = 114;
            this.LblNombreGe.Text = "Nombre género";
            // 
            // KTxtNombreGe
            // 
            this.KTxtNombreGe.Location = new System.Drawing.Point(14, 31);
            this.KTxtNombreGe.Name = "KTxtNombreGe";
            this.KTxtNombreGe.Size = new System.Drawing.Size(335, 33);
            this.KTxtNombreGe.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombreGe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreGe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreGe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreGe.StateCommon.Border.Rounding = 10;
            this.KTxtNombreGe.StateCommon.Border.Width = 2;
            this.KTxtNombreGe.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtNombreGe.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreGe.TabIndex = 113;
            // 
            // LblComentarioGe
            // 
            this.LblComentarioGe.AutoSize = true;
            this.LblComentarioGe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioGe.ForeColor = System.Drawing.Color.Navy;
            this.LblComentarioGe.Location = new System.Drawing.Point(14, 165);
            this.LblComentarioGe.Name = "LblComentarioGe";
            this.LblComentarioGe.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioGe.TabIndex = 112;
            this.LblComentarioGe.Text = "Comentario";
            // 
            // KTxtComentarioGe
            // 
            this.KTxtComentarioGe.Location = new System.Drawing.Point(14, 188);
            this.KTxtComentarioGe.Multiline = true;
            this.KTxtComentarioGe.Name = "KTxtComentarioGe";
            this.KTxtComentarioGe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioGe.Size = new System.Drawing.Size(335, 135);
            this.KTxtComentarioGe.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtComentarioGe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioGe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioGe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioGe.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioGe.StateCommon.Border.Width = 2;
            this.KTxtComentarioGe.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtComentarioGe.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioGe.TabIndex = 111;
            // 
            // FrmGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.MBtnMasLsvNG);
            this.Controls.Add(this.MBtnMenosLsvNG);
            this.Controls.Add(this.LsvGeneroNG);
            this.Controls.Add(this.PanBtnGe);
            this.Controls.Add(this.PanTituloGeneros);
            this.Controls.Add(this.PanOpcionesGE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGeneros";
            this.Load += new System.EventHandler(this.FrmGeneros_Load);
            this.PanTituloGeneros.ResumeLayout(false);
            this.PanTituloGeneros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoGeneros)).EndInit();
            this.PanBtnGe.ResumeLayout(false);
            this.PanOpcionesGE.ResumeLayout(false);
            this.PanOpcionesGE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbGeneroPadreGe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloGeneros;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarGeneros;
        private System.Windows.Forms.Label LblTituloGeneros;
        private System.Windows.Forms.PictureBox PcbLogoGeneros;
        private System.Windows.Forms.Panel PanBtnGe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarGe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarGe;
        private System.Windows.Forms.ListView LsvGeneroNG;
        private System.Windows.Forms.ColumnHeader ChNombreNG;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNG;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNG;
        private System.Windows.Forms.ColumnHeader ChGeneroPadreNG;
        private System.Windows.Forms.Panel PanOpcionesGE;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbGeneroPadreGe;
        private System.Windows.Forms.Label LblGeneroPadreGe;
        private System.Windows.Forms.Label LblNombreGe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreGe;
        private System.Windows.Forms.Label LblComentarioGe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioGe;
    }
}