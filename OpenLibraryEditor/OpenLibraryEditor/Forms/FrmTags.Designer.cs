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
            this.KCmbEstadoSe = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblCategoriaTa = new System.Windows.Forms.Label();
            this.LblNombreTa = new System.Windows.Forms.Label();
            this.KTxtNombreTa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnMasCategoriaTa = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosCategoriaTag = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioTa = new System.Windows.Forms.Label();
            this.KTxtComentarioTa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PanBtnTa = new System.Windows.Forms.Panel();
            this.KBtnCancelarTa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KBtnAceptarTa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanTituloTags = new System.Windows.Forms.Panel();
            this.MBtnCerrarTags = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloTags = new System.Windows.Forms.Label();
            this.PcbLogoTags = new System.Windows.Forms.PictureBox();
            this.LsvTags = new System.Windows.Forms.ListView();
            this.ChNombreTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvTa = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvTa = new FontAwesome.Sharp.Material.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbEstadoSe)).BeginInit();
            this.PanBtnTa.SuspendLayout();
            this.PanTituloTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoTags)).BeginInit();
            this.SuspendLayout();
            // 
            // KCmbEstadoSe
            // 
            this.KCmbEstadoSe.DropDownWidth = 228;
            this.KCmbEstadoSe.Location = new System.Drawing.Point(312, 164);
            this.KCmbEstadoSe.Name = "KCmbEstadoSe";
            this.KCmbEstadoSe.Size = new System.Drawing.Size(266, 33);
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
            this.KCmbEstadoSe.TabIndex = 129;
            // 
            // LblCategoriaTa
            // 
            this.LblCategoriaTa.AutoSize = true;
            this.LblCategoriaTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoriaTa.ForeColor = System.Drawing.Color.Navy;
            this.LblCategoriaTa.Location = new System.Drawing.Point(312, 141);
            this.LblCategoriaTa.Name = "LblCategoriaTa";
            this.LblCategoriaTa.Size = new System.Drawing.Size(78, 20);
            this.LblCategoriaTa.TabIndex = 128;
            this.LblCategoriaTa.Text = "Categoría";
            // 
            // LblNombreTa
            // 
            this.LblNombreTa.AutoSize = true;
            this.LblNombreTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreTa.ForeColor = System.Drawing.Color.Navy;
            this.LblNombreTa.Location = new System.Drawing.Point(312, 71);
            this.LblNombreTa.Name = "LblNombreTa";
            this.LblNombreTa.Size = new System.Drawing.Size(127, 20);
            this.LblNombreTa.TabIndex = 127;
            this.LblNombreTa.Text = "Nombre etiqueta";
            // 
            // KTxtNombreTa
            // 
            this.KTxtNombreTa.Location = new System.Drawing.Point(312, 92);
            this.KTxtNombreTa.Name = "KTxtNombreTa";
            this.KTxtNombreTa.Size = new System.Drawing.Size(333, 33);
            this.KTxtNombreTa.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombreTa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreTa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombreTa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreTa.StateCommon.Border.Rounding = 10;
            this.KTxtNombreTa.StateCommon.Border.Width = 2;
            this.KTxtNombreTa.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.KTxtNombreTa.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreTa.TabIndex = 126;
            // 
            // MBtnMasCategoriaTa
            // 
            this.MBtnMasCategoriaTa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasCategoriaTa.FlatAppearance.BorderSize = 0;
            this.MBtnMasCategoriaTa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasCategoriaTa.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.MBtnMasCategoriaTa.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasCategoriaTa.IconSize = 40;
            this.MBtnMasCategoriaTa.Location = new System.Drawing.Point(584, 167);
            this.MBtnMasCategoriaTa.Name = "MBtnMasCategoriaTa";
            this.MBtnMasCategoriaTa.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasCategoriaTa.TabIndex = 122;
            this.MBtnMasCategoriaTa.UseVisualStyleBackColor = true;
            // 
            // MBtnMenosCategoriaTag
            // 
            this.MBtnMenosCategoriaTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosCategoriaTag.FlatAppearance.BorderSize = 0;
            this.MBtnMenosCategoriaTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosCategoriaTag.IconChar = FontAwesome.Sharp.MaterialIcons.MinusCircleOutline;
            this.MBtnMenosCategoriaTag.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosCategoriaTag.IconSize = 40;
            this.MBtnMenosCategoriaTag.Location = new System.Drawing.Point(615, 167);
            this.MBtnMenosCategoriaTag.Name = "MBtnMenosCategoriaTag";
            this.MBtnMenosCategoriaTag.Size = new System.Drawing.Size(30, 30);
            this.MBtnMenosCategoriaTag.TabIndex = 123;
            this.MBtnMenosCategoriaTag.UseVisualStyleBackColor = true;
            // 
            // LblComentarioTa
            // 
            this.LblComentarioTa.AutoSize = true;
            this.LblComentarioTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioTa.ForeColor = System.Drawing.Color.Navy;
            this.LblComentarioTa.Location = new System.Drawing.Point(312, 217);
            this.LblComentarioTa.Name = "LblComentarioTa";
            this.LblComentarioTa.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioTa.TabIndex = 125;
            this.LblComentarioTa.Text = "Comentario";
            // 
            // KTxtComentarioTa
            // 
            this.KTxtComentarioTa.Location = new System.Drawing.Point(312, 240);
            this.KTxtComentarioTa.Multiline = true;
            this.KTxtComentarioTa.Name = "KTxtComentarioTa";
            this.KTxtComentarioTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioTa.Size = new System.Drawing.Size(333, 182);
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
            this.KTxtComentarioTa.TabIndex = 124;
            // 
            // PanBtnTa
            // 
            this.PanBtnTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBtnTa.Controls.Add(this.KBtnCancelarTa);
            this.PanBtnTa.Controls.Add(this.KBtnAceptarTa);
            this.PanBtnTa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnTa.Location = new System.Drawing.Point(0, 454);
            this.PanBtnTa.Name = "PanBtnTa";
            this.PanBtnTa.Size = new System.Drawing.Size(675, 45);
            this.PanBtnTa.TabIndex = 120;
            // 
            // KBtnCancelarTa
            // 
            this.KBtnCancelarTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KBtnCancelarTa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnCancelarTa.Location = new System.Drawing.Point(379, 5);
            this.KBtnCancelarTa.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnCancelarTa.Name = "KBtnCancelarTa";
            this.KBtnCancelarTa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTa.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTa.OverrideDefault.Border.Rounding = 30;
            this.KBtnCancelarTa.OverrideDefault.Border.Width = 2;
            this.KBtnCancelarTa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarTa.Size = new System.Drawing.Size(126, 35);
            this.KBtnCancelarTa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTa.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateCommon.Border.ColorAngle = 0F;
            this.KBtnCancelarTa.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTa.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTa.StateCommon.Border.Rounding = 30;
            this.KBtnCancelarTa.StateCommon.Border.Width = 2;
            this.KBtnCancelarTa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnCancelarTa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnCancelarTa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarTa.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTa.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KBtnCancelarTa.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTa.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTa.StateNormal.Border.Rounding = 30;
            this.KBtnCancelarTa.StateNormal.Border.Width = 2;
            this.KBtnCancelarTa.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnCancelarTa.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnCancelarTa.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnCancelarTa.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnCancelarTa.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnCancelarTa.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnCancelarTa.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnCancelarTa.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnCancelarTa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnCancelarTa.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnCancelarTa.TabIndex = 1;
            this.KBtnCancelarTa.Values.Text = "Cancelar";
            // 
            // KBtnAceptarTa
            // 
            this.KBtnAceptarTa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KBtnAceptarTa.Location = new System.Drawing.Point(519, 5);
            this.KBtnAceptarTa.Margin = new System.Windows.Forms.Padding(0);
            this.KBtnAceptarTa.Name = "KBtnAceptarTa";
            this.KBtnAceptarTa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTa.OverrideDefault.Border.Rounding = 30;
            this.KBtnAceptarTa.OverrideDefault.Border.Width = 2;
            this.KBtnAceptarTa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTa.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTa.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarTa.Size = new System.Drawing.Size(126, 35);
            this.KBtnAceptarTa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTa.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.KBtnAceptarTa.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.KBtnAceptarTa.StateCommon.Border.ColorAngle = 0F;
            this.KBtnAceptarTa.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTa.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTa.StateCommon.Border.Rounding = 30;
            this.KBtnAceptarTa.StateCommon.Border.Width = 2;
            this.KBtnAceptarTa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.KBtnAceptarTa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTa.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.KBtnAceptarTa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarTa.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KBtnAceptarTa.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTa.StateNormal.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarTa.StateNormal.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KBtnAceptarTa.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTa.StateNormal.Border.Rounding = 30;
            this.KBtnAceptarTa.StateNormal.Border.Width = 2;
            this.KBtnAceptarTa.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTa.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTa.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Bold);
            this.KBtnAceptarTa.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.KBtnAceptarTa.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.KBtnAceptarTa.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTa.StatePressed.Border.Rounding = 30;
            this.KBtnAceptarTa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.KBtnAceptarTa.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.KBtnAceptarTa.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.KBtnAceptarTa.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KBtnAceptarTa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.KBtnAceptarTa.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.KBtnAceptarTa.TabIndex = 0;
            this.KBtnAceptarTa.Values.Text = "Aceptar";
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
            this.PanTituloTags.Size = new System.Drawing.Size(675, 40);
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
            this.MBtnCerrarTags.Location = new System.Drawing.Point(643, 0);
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
            // LsvTags
            // 
            this.LsvTags.BackColor = System.Drawing.Color.Gainsboro;
            this.LsvTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreTag,
            this.ChCategoria});
            this.LsvTags.HideSelection = false;
            this.LsvTags.Location = new System.Drawing.Point(30, 70);
            this.LsvTags.Name = "LsvTags";
            this.LsvTags.Size = new System.Drawing.Size(244, 306);
            this.LsvTags.TabIndex = 130;
            this.LsvTags.UseCompatibleStateImageBehavior = false;
            this.LsvTags.View = System.Windows.Forms.View.Details;
            // 
            // ChNombreTag
            // 
            this.ChNombreTag.Text = "Nombre";
            this.ChNombreTag.Width = 133;
            // 
            // ChCategoria
            // 
            this.ChCategoria.Text = "Categoría";
            this.ChCategoria.Width = 105;
            // 
            // MBtnMasLsvTa
            // 
            this.MBtnMasLsvTa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvTa.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvTa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvTa.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvTa.IconColor = System.Drawing.Color.Navy;
            this.MBtnMasLsvTa.IconSize = 50;
            this.MBtnMasLsvTa.Location = new System.Drawing.Point(33, 382);
            this.MBtnMasLsvTa.Name = "MBtnMasLsvTa";
            this.MBtnMasLsvTa.Size = new System.Drawing.Size(40, 40);
            this.MBtnMasLsvTa.TabIndex = 131;
            this.MBtnMasLsvTa.UseVisualStyleBackColor = true;
            // 
            // MBtnMenosLsvTa
            // 
            this.MBtnMenosLsvTa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvTa.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvTa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvTa.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvTa.IconColor = System.Drawing.Color.Navy;
            this.MBtnMenosLsvTa.IconSize = 50;
            this.MBtnMenosLsvTa.Location = new System.Drawing.Point(79, 382);
            this.MBtnMenosLsvTa.Name = "MBtnMenosLsvTa";
            this.MBtnMenosLsvTa.Size = new System.Drawing.Size(40, 40);
            this.MBtnMenosLsvTa.TabIndex = 132;
            this.MBtnMenosLsvTa.UseVisualStyleBackColor = true;
            // 
            // FrmTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(675, 499);
            this.Controls.Add(this.MBtnMasLsvTa);
            this.Controls.Add(this.MBtnMenosLsvTa);
            this.Controls.Add(this.LsvTags);
            this.Controls.Add(this.KCmbEstadoSe);
            this.Controls.Add(this.LblCategoriaTa);
            this.Controls.Add(this.LblNombreTa);
            this.Controls.Add(this.KTxtNombreTa);
            this.Controls.Add(this.MBtnMasCategoriaTa);
            this.Controls.Add(this.MBtnMenosCategoriaTag);
            this.Controls.Add(this.LblComentarioTa);
            this.Controls.Add(this.KTxtComentarioTa);
            this.Controls.Add(this.PanBtnTa);
            this.Controls.Add(this.PanTituloTags);
            this.Name = "FrmTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTags";
            ((System.ComponentModel.ISupportInitialize)(this.KCmbEstadoSe)).EndInit();
            this.PanBtnTa.ResumeLayout(false);
            this.PanTituloTags.ResumeLayout(false);
            this.PanTituloTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbEstadoSe;
        private System.Windows.Forms.Label LblCategoriaTa;
        private System.Windows.Forms.Label LblNombreTa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreTa;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasCategoriaTa;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosCategoriaTag;
        private System.Windows.Forms.Label LblComentarioTa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioTa;
        private System.Windows.Forms.Panel PanBtnTa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnCancelarTa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton KBtnAceptarTa;
        private System.Windows.Forms.Panel PanTituloTags;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarTags;
        private System.Windows.Forms.Label LblTituloTags;
        private System.Windows.Forms.PictureBox PcbLogoTags;
        private System.Windows.Forms.ListView LsvTags;
        private System.Windows.Forms.ColumnHeader ChNombreTag;
        private System.Windows.Forms.ColumnHeader ChCategoria;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvTa;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvTa;
    }
}