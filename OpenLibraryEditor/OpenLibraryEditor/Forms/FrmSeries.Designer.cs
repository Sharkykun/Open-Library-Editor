namespace OpenLibraryEditor.Forms
{
    partial class FrmSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeries));
            this.PanBtnSe = new System.Windows.Forms.Panel();
            this.KBtnCancelarSe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarSe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanTituloSeries = new System.Windows.Forms.Panel();
            this.MBtnCerrarSeries = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloSeries = new System.Windows.Forms.Label();
            this.PcbLogoSeries = new System.Windows.Forms.PictureBox();
            this.MBtnMasLsvNS = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNS = new FontAwesome.Sharp.Material.MaterialButton();
            this.LsvSeriesNS = new System.Windows.Forms.ListView();
            this.ChNombreNS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChEstadoNS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanOpcionesSE = new System.Windows.Forms.Panel();
            this.LblImagenSerieNS = new System.Windows.Forms.Label();
            this.KGbRelacionesNS = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.MBtnEditarRS = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasRelacionNS = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosRelacionNS = new FontAwesome.Sharp.Material.MaterialButton();
            this.LsvRelacionSeriesNS = new System.Windows.Forms.ListView();
            this.ChSerieNS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChTipNS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KCmbEstadoSe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblEstadoSe = new System.Windows.Forms.Label();
            this.LblNombreSe = new System.Windows.Forms.Label();
            this.KTxtNombreSe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnAniadirImagenSe = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnBorrarImagenSe = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioSe = new System.Windows.Forms.Label();
            this.KTxtComentarioSe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PcbSerieNS = new System.Windows.Forms.PictureBox();
            this.TTSeries = new System.Windows.Forms.ToolTip(this.components);
            this.PanBtnSe.SuspendLayout();
            this.PanTituloSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoSeries)).BeginInit();
            this.PanOpcionesSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KGbRelacionesNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KGbRelacionesNS.Panel)).BeginInit();
            this.KGbRelacionesNS.Panel.SuspendLayout();
            this.KGbRelacionesNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbEstadoSe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSerieNS)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtnSe
            // 
            this.PanBtnSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnSe.Controls.Add(this.KBtnCancelarSe);
            this.PanBtnSe.Controls.Add(this.KBtnAceptarSe);
            this.PanBtnSe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnSe.Location = new System.Drawing.Point(0, 454);
            this.PanBtnSe.Name = "PanBtnSe";
            this.PanBtnSe.Size = new System.Drawing.Size(884, 45);
            this.PanBtnSe.TabIndex = 109;
            // 
            // KBtnCancelarSe
            // 
            this.KBtnCancelarSe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarSe.Location = new System.Drawing.Point(612, 5);
            this.KBtnCancelarSe.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarSe.Name = "KBtnCancelarSe";
            this.KBtnCancelarSe.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarSe.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarSe.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarSe.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarSe.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarSe.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarSe.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarSe.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarSe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarSe.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarSe.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarSe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarSe.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarSe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarSe.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarSe.StateCommon.Border.Width = 2;
            this.KBtnCancelarSe.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarSe.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarSe.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarSe.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarSe.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarSe.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarSe.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarSe.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarSe.StateNormal.Border.Width = 2;
            this.KBtnCancelarSe.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarSe.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarSe.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarSe.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarSe.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarSe.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarSe.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarSe.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarSe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarSe.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarSe.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarSe.TabIndex = 1;
            this.KBtnCancelarSe.Values.Text = "Cancelar";
            this.KBtnCancelarSe.Click += new System.EventHandler(this.KBtnCancelarSe_Click);
            // 
            // KBtnAceptarSe
            // 
            this.KBtnAceptarSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarSe.Location = new System.Drawing.Point(749, 5);
            this.KBtnAceptarSe.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarSe.Name = "KBtnAceptarSe";
            this.KBtnAceptarSe.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarSe.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarSe.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarSe.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarSe.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarSe.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarSe.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarSe.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarSe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarSe.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarSe.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarSe.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarSe.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarSe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarSe.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarSe.StateCommon.Border.Width = 2;
            this.KBtnAceptarSe.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarSe.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarSe.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarSe.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarSe.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarSe.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarSe.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarSe.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarSe.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarSe.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarSe.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarSe.StateNormal.Border.Width = 2;
            this.KBtnAceptarSe.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarSe.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarSe.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarSe.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarSe.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarSe.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarSe.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarSe.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarSe.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarSe.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarSe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarSe.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarSe.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarSe.TabIndex = 0;
            this.KBtnAceptarSe.Values.Text = "Aceptar";
            this.KBtnAceptarSe.Click += new System.EventHandler(this.KBtnAceptarSe_Click);
            // 
            // PanTituloSeries
            // 
            this.PanTituloSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloSeries.Controls.Add(this.MBtnCerrarSeries);
            this.PanTituloSeries.Controls.Add(this.LblTituloSeries);
            this.PanTituloSeries.Controls.Add(this.PcbLogoSeries);
            this.PanTituloSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloSeries.Location = new System.Drawing.Point(0, 0);
            this.PanTituloSeries.Name = "PanTituloSeries";
            this.PanTituloSeries.Size = new System.Drawing.Size(884, 40);
            this.PanTituloSeries.TabIndex = 108;
            this.PanTituloSeries.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloSeries_MouseDown);
            // 
            // MBtnCerrarSeries
            // 
            this.MBtnCerrarSeries.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarSeries.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarSeries.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarSeries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarSeries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarSeries.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarSeries.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarSeries.IconSize = 40;
            this.MBtnCerrarSeries.Location = new System.Drawing.Point(852, 0);
            this.MBtnCerrarSeries.Name = "MBtnCerrarSeries";
            this.MBtnCerrarSeries.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarSeries.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarSeries.TabIndex = 28;
            this.MBtnCerrarSeries.UseVisualStyleBackColor = false;
            this.MBtnCerrarSeries.Click += new System.EventHandler(this.MBtnCerrarSeries_Click);
            // 
            // LblTituloSeries
            // 
            this.LblTituloSeries.AutoSize = true;
            this.LblTituloSeries.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloSeries.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloSeries.Location = new System.Drawing.Point(54, 9);
            this.LblTituloSeries.Name = "LblTituloSeries";
            this.LblTituloSeries.Size = new System.Drawing.Size(279, 23);
            this.LblTituloSeries.TabIndex = 4;
            this.LblTituloSeries.Text = "Open Library Editor - Nueva Serie";
            // 
            // PcbLogoSeries
            // 
            this.PcbLogoSeries.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoSeries.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoSeries.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoSeries.Name = "PcbLogoSeries";
            this.PcbLogoSeries.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoSeries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoSeries.TabIndex = 3;
            this.PcbLogoSeries.TabStop = false;
            // 
            // MBtnMasLsvNS
            // 
            this.MBtnMasLsvNS.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNS.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNS.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNS.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasLsvNS.IconSize = 65;
            this.MBtnMasLsvNS.Location = new System.Drawing.Point(15, 389);
            this.MBtnMasLsvNS.Name = "MBtnMasLsvNS";
            this.MBtnMasLsvNS.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNS.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNS.TabIndex = 140;
            this.MBtnMasLsvNS.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNS.Click += new System.EventHandler(this.MBtnMasLsvNS_Click);
            // 
            // MBtnMenosLsvNS
            // 
            this.MBtnMenosLsvNS.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNS.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNS.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNS.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosLsvNS.IconSize = 65;
            this.MBtnMenosLsvNS.Location = new System.Drawing.Point(66, 389);
            this.MBtnMenosLsvNS.Name = "MBtnMenosLsvNS";
            this.MBtnMenosLsvNS.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNS.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNS.TabIndex = 141;
            this.MBtnMenosLsvNS.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNS.Click += new System.EventHandler(this.MBtnMenosLsvNS_Click);
            // 
            // LsvSeriesNS
            // 
            this.LsvSeriesNS.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvSeriesNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvSeriesNS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreNS,
            this.ChEstadoNS});
            this.LsvSeriesNS.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvSeriesNS.HideSelection = false;
            this.LsvSeriesNS.Location = new System.Drawing.Point(15, 70);
            this.LsvSeriesNS.Name = "LsvSeriesNS";
            this.LsvSeriesNS.Size = new System.Drawing.Size(215, 313);
            this.LsvSeriesNS.TabIndex = 139;
            this.LsvSeriesNS.UseCompatibleStateImageBehavior = false;
            this.LsvSeriesNS.View = System.Windows.Forms.View.Details;
            this.LsvSeriesNS.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvSeriesNS_ItemSelectionChanged);
            // 
            // ChNombreNS
            // 
            this.ChNombreNS.Text = "Nombre";
            this.ChNombreNS.Width = 107;
            // 
            // ChEstadoNS
            // 
            this.ChEstadoNS.Text = "Estado";
            this.ChEstadoNS.Width = 104;
            // 
            // PanOpcionesSE
            // 
            this.PanOpcionesSE.Controls.Add(this.LblImagenSerieNS);
            this.PanOpcionesSE.Controls.Add(this.KGbRelacionesNS);
            this.PanOpcionesSE.Controls.Add(this.KCmbEstadoSe);
            this.PanOpcionesSE.Controls.Add(this.LblEstadoSe);
            this.PanOpcionesSE.Controls.Add(this.LblNombreSe);
            this.PanOpcionesSE.Controls.Add(this.KTxtNombreSe);
            this.PanOpcionesSE.Controls.Add(this.MBtnAniadirImagenSe);
            this.PanOpcionesSE.Controls.Add(this.MBtnBorrarImagenSe);
            this.PanOpcionesSE.Controls.Add(this.LblComentarioSe);
            this.PanOpcionesSE.Controls.Add(this.KTxtComentarioSe);
            this.PanOpcionesSE.Controls.Add(this.PcbSerieNS);
            this.PanOpcionesSE.Location = new System.Drawing.Point(242, 58);
            this.PanOpcionesSE.Name = "PanOpcionesSE";
            this.PanOpcionesSE.Size = new System.Drawing.Size(633, 390);
            this.PanOpcionesSE.TabIndex = 145;
            this.PanOpcionesSE.Visible = false;
            // 
            // LblImagenSerieNS
            // 
            this.LblImagenSerieNS.AutoSize = true;
            this.LblImagenSerieNS.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagenSerieNS.ForeColor = System.Drawing.Color.Navy;
            this.LblImagenSerieNS.Location = new System.Drawing.Point(12, 226);
            this.LblImagenSerieNS.Name = "LblImagenSerieNS";
            this.LblImagenSerieNS.Size = new System.Drawing.Size(62, 20);
            this.LblImagenSerieNS.TabIndex = 155;
            this.LblImagenSerieNS.Text = "Imagen";
            // 
            // KGbRelacionesNS
            // 
            this.KGbRelacionesNS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KGbRelacionesNS.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KGbRelacionesNS.Location = new System.Drawing.Point(365, 6);
            this.KGbRelacionesNS.Name = "KGbRelacionesNS";
            // 
            // KGbRelacionesNS.Panel
            // 
            this.KGbRelacionesNS.Panel.Controls.Add(this.MBtnEditarRS);
            this.KGbRelacionesNS.Panel.Controls.Add(this.MBtnMasRelacionNS);
            this.KGbRelacionesNS.Panel.Controls.Add(this.MBtnMenosRelacionNS);
            this.KGbRelacionesNS.Panel.Controls.Add(this.LsvRelacionSeriesNS);
            this.KGbRelacionesNS.Size = new System.Drawing.Size(260, 364);
            this.KGbRelacionesNS.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KGbRelacionesNS.StateCommon.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.KGbRelacionesNS.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KGbRelacionesNS.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KGbRelacionesNS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KGbRelacionesNS.StateCommon.Border.Rounding = 0;
            this.KGbRelacionesNS.StateCommon.Border.Width = 2;
            this.KGbRelacionesNS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KGbRelacionesNS.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Navy;
            this.KGbRelacionesNS.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KGbRelacionesNS.TabIndex = 154;
            this.KGbRelacionesNS.Values.Heading = "Relaciones";
            // 
            // MBtnEditarRS
            // 
            this.MBtnEditarRS.BackColor = System.Drawing.Color.Navy;
            this.MBtnEditarRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnEditarRS.FlatAppearance.BorderSize = 0;
            this.MBtnEditarRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnEditarRS.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnEditarRS.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnEditarRS.IconChar = FontAwesome.Sharp.MaterialIcons.FileEdit;
            this.MBtnEditarRS.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnEditarRS.IconSize = 40;
            this.MBtnEditarRS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnEditarRS.Location = new System.Drawing.Point(133, 276);
            this.MBtnEditarRS.Name = "MBtnEditarRS";
            this.MBtnEditarRS.Size = new System.Drawing.Size(120, 45);
            this.MBtnEditarRS.TabIndex = 145;
            this.MBtnEditarRS.Text = "Editar";
            this.MBtnEditarRS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnEditarRS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnEditarRS.UseVisualStyleBackColor = false;
            this.MBtnEditarRS.Click += new System.EventHandler(this.MBtnEditarRS_Click);
            // 
            // MBtnMasRelacionNS
            // 
            this.MBtnMasRelacionNS.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasRelacionNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasRelacionNS.FlatAppearance.BorderSize = 0;
            this.MBtnMasRelacionNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasRelacionNS.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasRelacionNS.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasRelacionNS.IconSize = 65;
            this.MBtnMasRelacionNS.Location = new System.Drawing.Point(7, 276);
            this.MBtnMasRelacionNS.Name = "MBtnMasRelacionNS";
            this.MBtnMasRelacionNS.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasRelacionNS.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasRelacionNS.TabIndex = 143;
            this.MBtnMasRelacionNS.UseVisualStyleBackColor = false;
            this.MBtnMasRelacionNS.Click += new System.EventHandler(this.MBtnMasRelacionNS_Click);
            // 
            // MBtnMenosRelacionNS
            // 
            this.MBtnMenosRelacionNS.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosRelacionNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosRelacionNS.FlatAppearance.BorderSize = 0;
            this.MBtnMenosRelacionNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosRelacionNS.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosRelacionNS.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosRelacionNS.IconSize = 65;
            this.MBtnMenosRelacionNS.Location = new System.Drawing.Point(58, 276);
            this.MBtnMenosRelacionNS.Name = "MBtnMenosRelacionNS";
            this.MBtnMenosRelacionNS.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosRelacionNS.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosRelacionNS.TabIndex = 144;
            this.MBtnMenosRelacionNS.UseVisualStyleBackColor = false;
            this.MBtnMenosRelacionNS.Click += new System.EventHandler(this.MBtnMenosRelacionNS_Click);
            // 
            // LsvRelacionSeriesNS
            // 
            this.LsvRelacionSeriesNS.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvRelacionSeriesNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvRelacionSeriesNS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChSerieNS,
            this.ChTipNS});
            this.LsvRelacionSeriesNS.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvRelacionSeriesNS.HideSelection = false;
            this.LsvRelacionSeriesNS.Location = new System.Drawing.Point(3, 11);
            this.LsvRelacionSeriesNS.Name = "LsvRelacionSeriesNS";
            this.LsvRelacionSeriesNS.Size = new System.Drawing.Size(250, 259);
            this.LsvRelacionSeriesNS.TabIndex = 142;
            this.LsvRelacionSeriesNS.UseCompatibleStateImageBehavior = false;
            this.LsvRelacionSeriesNS.View = System.Windows.Forms.View.Details;
            this.LsvRelacionSeriesNS.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvRelacionSeriesNS_ItemSelectionChanged);
            // 
            // ChSerieNS
            // 
            this.ChSerieNS.Text = "Serie";
            this.ChSerieNS.Width = 118;
            // 
            // ChTipNS
            // 
            this.ChTipNS.Text = "Tipo relación";
            this.ChTipNS.Width = 129;
            // 
            // KCmbEstadoSe
            // 
            this.KCmbEstadoSe.DropDownWidth = 228;
            this.KCmbEstadoSe.Location = new System.Drawing.Point(122, 45);
            this.KCmbEstadoSe.Name = "KCmbEstadoSe";
            this.KCmbEstadoSe.Size = new System.Drawing.Size(218, 33);
            this.KCmbEstadoSe.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbEstadoSe.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbEstadoSe.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbEstadoSe.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbEstadoSe.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbEstadoSe.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbEstadoSe.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Navy;
            this.KCmbEstadoSe.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbEstadoSe.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Navy;
            this.KCmbEstadoSe.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbEstadoSe.TabIndex = 153;
            // 
            // LblEstadoSe
            // 
            this.LblEstadoSe.AutoSize = true;
            this.LblEstadoSe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoSe.ForeColor = System.Drawing.Color.Navy;
            this.LblEstadoSe.Location = new System.Drawing.Point(12, 51);
            this.LblEstadoSe.Name = "LblEstadoSe";
            this.LblEstadoSe.Size = new System.Drawing.Size(57, 20);
            this.LblEstadoSe.TabIndex = 152;
            this.LblEstadoSe.Text = "Estado";
            // 
            // LblNombreSe
            // 
            this.LblNombreSe.AutoSize = true;
            this.LblNombreSe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreSe.ForeColor = System.Drawing.Color.Navy;
            this.LblNombreSe.Location = new System.Drawing.Point(12, 12);
            this.LblNombreSe.Name = "LblNombreSe";
            this.LblNombreSe.Size = new System.Drawing.Size(104, 20);
            this.LblNombreSe.TabIndex = 151;
            this.LblNombreSe.Text = "Nombre serie";
            // 
            // KTxtNombreSe
            // 
            this.KTxtNombreSe.Location = new System.Drawing.Point(122, 6);
            this.KTxtNombreSe.Name = "KTxtNombreSe";
            this.KTxtNombreSe.Size = new System.Drawing.Size(218, 33);
            this.KTxtNombreSe.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombreSe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreSe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreSe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreSe.StateCommon.Border.Rounding = 10;
            this.KTxtNombreSe.StateCommon.Border.Width = 2;
            this.KTxtNombreSe.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtNombreSe.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreSe.TabIndex = 150;
            // 
            // MBtnAniadirImagenSe
            // 
            this.MBtnAniadirImagenSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnAniadirImagenSe.FlatAppearance.BorderSize = 0;
            this.MBtnAniadirImagenSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAniadirImagenSe.IconChar = FontAwesome.Sharp.MaterialIcons.FileImagePlusOutline;
            this.MBtnAniadirImagenSe.IconColor = System.Drawing.Color.Navy;
            this.MBtnAniadirImagenSe.Location = new System.Drawing.Point(259, 340);
            this.MBtnAniadirImagenSe.Name = "MBtnAniadirImagenSe";
            this.MBtnAniadirImagenSe.Size = new System.Drawing.Size(30, 30);
            this.MBtnAniadirImagenSe.TabIndex = 146;
            this.MBtnAniadirImagenSe.UseVisualStyleBackColor = true;
            this.MBtnAniadirImagenSe.Click += new System.EventHandler(this.MBtnAniadirImagenSe_Click);
            // 
            // MBtnBorrarImagenSe
            // 
            this.MBtnBorrarImagenSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarImagenSe.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarImagenSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarImagenSe.IconChar = FontAwesome.Sharp.MaterialIcons.FileImageMinus;
            this.MBtnBorrarImagenSe.IconColor = System.Drawing.Color.Navy;
            this.MBtnBorrarImagenSe.Location = new System.Drawing.Point(299, 340);
            this.MBtnBorrarImagenSe.Name = "MBtnBorrarImagenSe";
            this.MBtnBorrarImagenSe.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarImagenSe.TabIndex = 147;
            this.MBtnBorrarImagenSe.UseVisualStyleBackColor = true;
            this.MBtnBorrarImagenSe.Click += new System.EventHandler(this.MBtnBorrarImagenSe_Click);
            // 
            // LblComentarioSe
            // 
            this.LblComentarioSe.AutoSize = true;
            this.LblComentarioSe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioSe.ForeColor = System.Drawing.Color.Navy;
            this.LblComentarioSe.Location = new System.Drawing.Point(12, 90);
            this.LblComentarioSe.Name = "LblComentarioSe";
            this.LblComentarioSe.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioSe.TabIndex = 149;
            this.LblComentarioSe.Text = "Comentario";
            // 
            // KTxtComentarioSe
            // 
            this.KTxtComentarioSe.Location = new System.Drawing.Point(122, 84);
            this.KTxtComentarioSe.Multiline = true;
            this.KTxtComentarioSe.Name = "KTxtComentarioSe";
            this.KTxtComentarioSe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioSe.Size = new System.Drawing.Size(218, 130);
            this.KTxtComentarioSe.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtComentarioSe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioSe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtComentarioSe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioSe.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioSe.StateCommon.Border.Width = 2;
            this.KTxtComentarioSe.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtComentarioSe.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioSe.TabIndex = 148;
            // 
            // PcbSerieNS
            // 
            this.PcbSerieNS.Image = global::OpenLibraryEditor.Properties.Resources.imagen;
            this.PcbSerieNS.Location = new System.Drawing.Point(122, 220);
            this.PcbSerieNS.Name = "PcbSerieNS";
            this.PcbSerieNS.Size = new System.Drawing.Size(120, 150);
            this.PcbSerieNS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbSerieNS.TabIndex = 145;
            this.PcbSerieNS.TabStop = false;
            // 
            // FrmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.MBtnMasLsvNS);
            this.Controls.Add(this.MBtnMenosLsvNS);
            this.Controls.Add(this.LsvSeriesNS);
            this.Controls.Add(this.PanBtnSe);
            this.Controls.Add(this.PanTituloSeries);
            this.Controls.Add(this.PanOpcionesSE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeries";
            this.Load += new System.EventHandler(this.FrmSeries_Load);
            this.PanBtnSe.ResumeLayout(false);
            this.PanTituloSeries.ResumeLayout(false);
            this.PanTituloSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoSeries)).EndInit();
            this.PanOpcionesSE.ResumeLayout(false);
            this.PanOpcionesSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KGbRelacionesNS.Panel)).EndInit();
            this.KGbRelacionesNS.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KGbRelacionesNS)).EndInit();
            this.KGbRelacionesNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbEstadoSe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSerieNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanBtnSe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarSe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarSe;
        private System.Windows.Forms.Panel PanTituloSeries;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarSeries;
        private System.Windows.Forms.Label LblTituloSeries;
        private System.Windows.Forms.PictureBox PcbLogoSeries;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNS;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNS;
        private System.Windows.Forms.ListView LsvSeriesNS;
        private System.Windows.Forms.ColumnHeader ChNombreNS;
        private System.Windows.Forms.ColumnHeader ChEstadoNS;
        private System.Windows.Forms.Panel PanOpcionesSE;
        private System.Windows.Forms.Label LblImagenSerieNS;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KGbRelacionesNS;
        private FontAwesome.Sharp.Material.MaterialButton MBtnEditarRS;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasRelacionNS;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosRelacionNS;
        private System.Windows.Forms.ListView LsvRelacionSeriesNS;
        private System.Windows.Forms.ColumnHeader ChSerieNS;
        private System.Windows.Forms.ColumnHeader ChTipNS;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbEstadoSe;
        private System.Windows.Forms.Label LblEstadoSe;
        private System.Windows.Forms.Label LblNombreSe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreSe;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAniadirImagenSe;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarImagenSe;
        private System.Windows.Forms.Label LblComentarioSe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioSe;
        private System.Windows.Forms.PictureBox PcbSerieNS;
        private System.Windows.Forms.ToolTip TTSeries;
    }
}