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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.PanBtnTa.SuspendLayout();
            this.PanTituloTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoTags)).BeginInit();
            this.PanOpcionesTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbCategoriaNE)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtnTa
            // 
            this.PanBtnTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtnTa.Controls.Add(this.GBtnAceptar);
            this.PanBtnTa.Controls.Add(this.GBtnCancelar);
            this.PanBtnTa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnTa.Location = new System.Drawing.Point(0, 454);
            this.PanBtnTa.Name = "PanBtnTa";
            this.PanBtnTa.Size = new System.Drawing.Size(805, 45);
            this.PanBtnTa.TabIndex = 120;
            // 
            // PanTituloTags
            // 
            this.PanTituloTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.MBtnCerrarTags.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
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
            this.LblTituloTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
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
            this.LsvTagsNT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
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
            this.MBtnMasLsvNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvNT.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNT.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.MBtnMenosLsvNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvNT.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNT.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.KCmbCategoriaNE.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbCategoriaNE.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbCategoriaNE.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbCategoriaNE.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbCategoriaNE.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbCategoriaNE.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbCategoriaNE.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbCategoriaNE.TabIndex = 137;
            // 
            // LblCategoriaTa
            // 
            this.LblCategoriaTa.AutoSize = true;
            this.LblCategoriaTa.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoriaTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.LblNombreTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.KTxtNombreNE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreNE.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreNE.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreNE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreNE.StateCommon.Border.Rounding = 10;
            this.KTxtNombreNE.StateCommon.Border.Width = 2;
            this.KTxtNombreNE.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreNE.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreNE.TabIndex = 134;
            // 
            // MBtnMasCategoriaTag
            // 
            this.MBtnMasCategoriaTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasCategoriaTag.FlatAppearance.BorderSize = 0;
            this.MBtnMasCategoriaTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasCategoriaTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasCategoriaTag.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.MBtnMasCategoriaTag.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.MBtnMenosCategoriaTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosCategoriaTag.IconChar = FontAwesome.Sharp.MaterialIcons.MinusCircleOutline;
            this.MBtnMenosCategoriaTag.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.LblComentarioTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
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
            this.KTxtComentarioTa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtComentarioTa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioTa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioTa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioTa.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioTa.StateCommon.Border.Width = 2;
            this.KTxtComentarioTa.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtComentarioTa.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioTa.TabIndex = 132;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(802, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 414);
            this.panel2.TabIndex = 148;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 414);
            this.panel1.TabIndex = 149;
            // 
            // GBtnAceptar
            // 
            this.GBtnAceptar.AnimationHoverSpeed = 0.07F;
            this.GBtnAceptar.AnimationSpeed = 0.03F;
            this.GBtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnAceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnAceptar.Image = null;
            this.GBtnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnAceptar.Location = new System.Drawing.Point(670, 5);
            this.GBtnAceptar.Name = "GBtnAceptar";
            this.GBtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnAceptar.OnHoverImage = null;
            this.GBtnAceptar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.Radius = 15;
            this.GBtnAceptar.Size = new System.Drawing.Size(126, 35);
            this.GBtnAceptar.TabIndex = 5;
            this.GBtnAceptar.Text = "Aceptar";
            this.GBtnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnAceptar.Click += new System.EventHandler(this.GBtnAceptar_Click);
            // 
            // GBtnCancelar
            // 
            this.GBtnCancelar.AnimationHoverSpeed = 0.07F;
            this.GBtnCancelar.AnimationSpeed = 0.03F;
            this.GBtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCancelar.Image = null;
            this.GBtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnCancelar.Location = new System.Drawing.Point(532, 5);
            this.GBtnCancelar.Name = "GBtnCancelar";
            this.GBtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.OnHoverForeColor = System.Drawing.Color.Black;
            this.GBtnCancelar.OnHoverImage = null;
            this.GBtnCancelar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.Radius = 15;
            this.GBtnCancelar.Size = new System.Drawing.Size(126, 35);
            this.GBtnCancelar.TabIndex = 4;
            this.GBtnCancelar.Text = "Cancelar";
            this.GBtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCancelar.Click += new System.EventHandler(this.GBtnCancelar_Click);
            // 
            // FrmTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton GBtnAceptar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
    }
}