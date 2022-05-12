﻿namespace OpenLibraryEditor.Forms
{
    partial class FrmAdministrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrarUsuarios));
            this.PanTituloFormAbierto = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloFormAbierto = new System.Windows.Forms.Label();
            this.MPcbTituloFrm = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.PanBusquedaUsu = new System.Windows.Forms.Panel();
            this.MBtnBuscar = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarUsu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrden = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbBuscarPorUsu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.PanPiePagina = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanListViewsOpciones = new System.Windows.Forms.Panel();
            this.LsvUsuariosBD = new System.Windows.Forms.ListView();
            this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KgbDatosUsuario = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.KCmbTipoUsu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblEscribirEmail = new System.Windows.Forms.Label();
            this.LblEscribirNombreUsu = new System.Windows.Forms.Label();
            this.LblTipoUsu = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNombreUsu = new System.Windows.Forms.Label();
            this.MBtnMenosUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnEditarUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTituloFormAbierto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbTituloFrm)).BeginInit();
            this.PanBusquedaUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbBuscarPorUsu)).BeginInit();
            this.PanPiePagina.SuspendLayout();
            this.PanListViewsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario.Panel)).BeginInit();
            this.KgbDatosUsuario.Panel.SuspendLayout();
            this.KgbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTituloFormAbierto
            // 
            this.PanTituloFormAbierto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.PanTituloFormAbierto.Controls.Add(this.panel2);
            this.PanTituloFormAbierto.Controls.Add(this.LblTituloFormAbierto);
            this.PanTituloFormAbierto.Controls.Add(this.MPcbTituloFrm);
            this.PanTituloFormAbierto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloFormAbierto.Location = new System.Drawing.Point(0, 0);
            this.PanTituloFormAbierto.Name = "PanTituloFormAbierto";
            this.PanTituloFormAbierto.Size = new System.Drawing.Size(948, 64);
            this.PanTituloFormAbierto.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(40, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 3);
            this.panel2.TabIndex = 11;
            // 
            // LblTituloFormAbierto
            // 
            this.LblTituloFormAbierto.AutoSize = true;
            this.LblTituloFormAbierto.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFormAbierto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblTituloFormAbierto.Location = new System.Drawing.Point(75, 18);
            this.LblTituloFormAbierto.Name = "LblTituloFormAbierto";
            this.LblTituloFormAbierto.Size = new System.Drawing.Size(366, 32);
            this.LblTituloFormAbierto.TabIndex = 10;
            this.LblTituloFormAbierto.Text = "Usuarios de mi base de datos";
            // 
            // MPcbTituloFrm
            // 
            this.MPcbTituloFrm.BackColor = System.Drawing.Color.Transparent;
            this.MPcbTituloFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MPcbTituloFrm.IconChar = FontAwesome.Sharp.MaterialIcons.AccountCircle;
            this.MPcbTituloFrm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MPcbTituloFrm.IconSize = 40;
            this.MPcbTituloFrm.Location = new System.Drawing.Point(40, 15);
            this.MPcbTituloFrm.Name = "MPcbTituloFrm";
            this.MPcbTituloFrm.Size = new System.Drawing.Size(40, 40);
            this.MPcbTituloFrm.TabIndex = 12;
            this.MPcbTituloFrm.TabStop = false;
            // 
            // PanBusquedaUsu
            // 
            this.PanBusquedaUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.PanBusquedaUsu.Controls.Add(this.MBtnBuscar);
            this.PanBusquedaUsu.Controls.Add(this.KTxtBuscarUsu);
            this.PanBusquedaUsu.Controls.Add(this.MBtnOrden);
            this.PanBusquedaUsu.Controls.Add(this.KCmbBuscarPorUsu);
            this.PanBusquedaUsu.Controls.Add(this.LblBuscarPor);
            this.PanBusquedaUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaUsu.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaUsu.Name = "PanBusquedaUsu";
            this.PanBusquedaUsu.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaUsu.TabIndex = 12;
            // 
            // MBtnBuscar
            // 
            this.MBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscar.FlatAppearance.BorderSize = 0;
            this.MBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscar.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnBuscar.IconSize = 30;
            this.MBtnBuscar.Location = new System.Drawing.Point(545, 9);
            this.MBtnBuscar.Name = "MBtnBuscar";
            this.MBtnBuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscar.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscar.TabIndex = 126;
            this.MBtnBuscar.UseVisualStyleBackColor = true;
            this.MBtnBuscar.Click += new System.EventHandler(this.MBtnBuscar_Click);
            // 
            // KTxtBuscarUsu
            // 
            this.KTxtBuscarUsu.Location = new System.Drawing.Point(340, 3);
            this.KTxtBuscarUsu.Name = "KTxtBuscarUsu";
            this.KTxtBuscarUsu.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarUsu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.KTxtBuscarUsu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarUsu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarUsu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarUsu.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarUsu.StateCommon.Border.Width = 2;
            this.KTxtBuscarUsu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarUsu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarUsu.TabIndex = 125;
            // 
            // MBtnOrden
            // 
            this.MBtnOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrden.FlatAppearance.BorderSize = 0;
            this.MBtnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnOrden.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrden.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnOrden.IconSize = 40;
            this.MBtnOrden.Location = new System.Drawing.Point(585, 4);
            this.MBtnOrden.Name = "MBtnOrden";
            this.MBtnOrden.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrden.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrden.TabIndex = 109;
            this.MBtnOrden.UseVisualStyleBackColor = true;
            this.MBtnOrden.Click += new System.EventHandler(this.MBtnOrden_Click);
            // 
            // KCmbBuscarPorUsu
            // 
            this.KCmbBuscarPorUsu.DropDownWidth = 160;
            this.KCmbBuscarPorUsu.Location = new System.Drawing.Point(127, 3);
            this.KCmbBuscarPorUsu.Name = "KCmbBuscarPorUsu";
            this.KCmbBuscarPorUsu.Size = new System.Drawing.Size(207, 33);
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbBuscarPorUsu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbBuscarPorUsu.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbBuscarPorUsu.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbBuscarPorUsu.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbBuscarPorUsu.TabIndex = 108;
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblBuscarPor.Location = new System.Drawing.Point(40, 11);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Size = new System.Drawing.Size(83, 18);
            this.LblBuscarPor.TabIndex = 8;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // PanPiePagina
            // 
            this.PanPiePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanPiePagina.Controls.Add(this.panel1);
            this.PanPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanPiePagina.Location = new System.Drawing.Point(0, 646);
            this.PanPiePagina.Name = "PanPiePagina";
            this.PanPiePagina.Size = new System.Drawing.Size(948, 47);
            this.PanPiePagina.TabIndex = 142;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 4);
            this.panel1.TabIndex = 0;
            // 
            // PanListViewsOpciones
            // 
            this.PanListViewsOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanListViewsOpciones.Controls.Add(this.LsvUsuariosBD);
            this.PanListViewsOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanListViewsOpciones.Location = new System.Drawing.Point(0, 104);
            this.PanListViewsOpciones.Name = "PanListViewsOpciones";
            this.PanListViewsOpciones.Size = new System.Drawing.Size(423, 542);
            this.PanListViewsOpciones.TabIndex = 143;
            // 
            // LsvUsuariosBD
            // 
            this.LsvUsuariosBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvUsuariosBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LsvUsuariosBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvUsuariosBD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNombre,
            this.ColTipo,
            this.ColCorreo});
            this.LsvUsuariosBD.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvUsuariosBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LsvUsuariosBD.HideSelection = false;
            this.LsvUsuariosBD.Location = new System.Drawing.Point(10, 10);
            this.LsvUsuariosBD.MultiSelect = false;
            this.LsvUsuariosBD.Name = "LsvUsuariosBD";
            this.LsvUsuariosBD.Size = new System.Drawing.Size(403, 522);
            this.LsvUsuariosBD.TabIndex = 0;
            this.LsvUsuariosBD.UseCompatibleStateImageBehavior = false;
            this.LsvUsuariosBD.View = System.Windows.Forms.View.Details;
            this.LsvUsuariosBD.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvUsuariosBD_ItemSelectionChanged);
            // 
            // ColNombre
            // 
            this.ColNombre.Text = "Nombre";
            this.ColNombre.Width = 115;
            // 
            // ColTipo
            // 
            this.ColTipo.Text = "Tipo";
            this.ColTipo.Width = 133;
            // 
            // ColCorreo
            // 
            this.ColCorreo.Text = "Correo";
            this.ColCorreo.Width = 151;
            // 
            // KgbDatosUsuario
            // 
            this.KgbDatosUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KgbDatosUsuario.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KgbDatosUsuario.Location = new System.Drawing.Point(429, 114);
            this.KgbDatosUsuario.Name = "KgbDatosUsuario";
            // 
            // KgbDatosUsuario.Panel
            // 
            this.KgbDatosUsuario.Panel.Controls.Add(this.MBtnEditarUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.MBtnMenosUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.KCmbTipoUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblEscribirEmail);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblEscribirNombreUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblTipoUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblEmail);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblNombreUsu);
            this.KgbDatosUsuario.Size = new System.Drawing.Size(507, 191);
            this.KgbDatosUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosUsuario.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosUsuario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KgbDatosUsuario.StateCommon.Border.Rounding = 0;
            this.KgbDatosUsuario.StateCommon.Border.Width = 2;
            this.KgbDatosUsuario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosUsuario.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosUsuario.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgbDatosUsuario.TabIndex = 144;
            this.KgbDatosUsuario.Values.Heading = "Datos del usuario";
            this.KgbDatosUsuario.Visible = false;
            // 
            // KCmbTipoUsu
            // 
            this.KCmbTipoUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KCmbTipoUsu.DropDownWidth = 228;
            this.KCmbTipoUsu.Enabled = false;
            this.KCmbTipoUsu.Location = new System.Drawing.Point(196, 96);
            this.KCmbTipoUsu.Name = "KCmbTipoUsu";
            this.KCmbTipoUsu.Size = new System.Drawing.Size(230, 33);
            this.KCmbTipoUsu.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KCmbTipoUsu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbTipoUsu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbTipoUsu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbTipoUsu.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbTipoUsu.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbTipoUsu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoUsu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoUsu.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoUsu.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoUsu.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoUsu.TabIndex = 163;
            // 
            // LblEscribirEmail
            // 
            this.LblEscribirEmail.AutoSize = true;
            this.LblEscribirEmail.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirEmail.Location = new System.Drawing.Point(193, 57);
            this.LblEscribirEmail.Name = "LblEscribirEmail";
            this.LblEscribirEmail.Size = new System.Drawing.Size(73, 22);
            this.LblEscribirEmail.TabIndex = 32;
            this.LblEscribirEmail.Text = "Nombre:";
            // 
            // LblEscribirNombreUsu
            // 
            this.LblEscribirNombreUsu.AutoSize = true;
            this.LblEscribirNombreUsu.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscribirNombreUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEscribirNombreUsu.Location = new System.Drawing.Point(193, 14);
            this.LblEscribirNombreUsu.Name = "LblEscribirNombreUsu";
            this.LblEscribirNombreUsu.Size = new System.Drawing.Size(73, 22);
            this.LblEscribirNombreUsu.TabIndex = 31;
            this.LblEscribirNombreUsu.Text = "Nombre:";
            // 
            // LblTipoUsu
            // 
            this.LblTipoUsu.AutoSize = true;
            this.LblTipoUsu.Font = new System.Drawing.Font("Merienda One", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblTipoUsu.Location = new System.Drawing.Point(23, 98);
            this.LblTipoUsu.Name = "LblTipoUsu";
            this.LblTipoUsu.Size = new System.Drawing.Size(156, 26);
            this.LblTipoUsu.TabIndex = 30;
            this.LblTipoUsu.Text = "Tipo de usuario:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Merienda One", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEmail.Location = new System.Drawing.Point(20, 53);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(66, 26);
            this.LblEmail.TabIndex = 23;
            this.LblEmail.Text = "Email:";
            // 
            // LblNombreUsu
            // 
            this.LblNombreUsu.AutoSize = true;
            this.LblNombreUsu.Font = new System.Drawing.Font("Merienda One", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblNombreUsu.Location = new System.Drawing.Point(20, 10);
            this.LblNombreUsu.Name = "LblNombreUsu";
            this.LblNombreUsu.Size = new System.Drawing.Size(162, 26);
            this.LblNombreUsu.TabIndex = 21;
            this.LblNombreUsu.Text = "Nombre usuario:";
            // 
            // MBtnMenosUsu
            // 
            this.MBtnMenosUsu.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosUsu.FlatAppearance.BorderSize = 0;
            this.MBtnMenosUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosUsu.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosUsu.IconSize = 45;
            this.MBtnMenosUsu.Location = new System.Drawing.Point(461, 9);
            this.MBtnMenosUsu.Name = "MBtnMenosUsu";
            this.MBtnMenosUsu.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosUsu.Size = new System.Drawing.Size(34, 31);
            this.MBtnMenosUsu.TabIndex = 165;
            this.MBtnMenosUsu.UseVisualStyleBackColor = false;
            // 
            // MBtnEditarUsu
            // 
            this.MBtnEditarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnEditarUsu.FlatAppearance.BorderSize = 0;
            this.MBtnEditarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnEditarUsu.IconChar = FontAwesome.Sharp.MaterialIcons.PencilPlus;
            this.MBtnEditarUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnEditarUsu.IconSize = 40;
            this.MBtnEditarUsu.Location = new System.Drawing.Point(431, 11);
            this.MBtnEditarUsu.Name = "MBtnEditarUsu";
            this.MBtnEditarUsu.Size = new System.Drawing.Size(30, 30);
            this.MBtnEditarUsu.TabIndex = 166;
            this.MBtnEditarUsu.UseVisualStyleBackColor = true;
            // 
            // FrmAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.KgbDatosUsuario);
            this.Controls.Add(this.PanListViewsOpciones);
            this.Controls.Add(this.PanPiePagina);
            this.Controls.Add(this.PanBusquedaUsu);
            this.Controls.Add(this.PanTituloFormAbierto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrarUsuarios";
            this.Text = "FrmAdministrarUsuarios";
            this.Load += new System.EventHandler(this.FrmAdministrarUsuarios_Load);
            this.PanTituloFormAbierto.ResumeLayout(false);
            this.PanTituloFormAbierto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbTituloFrm)).EndInit();
            this.PanBusquedaUsu.ResumeLayout(false);
            this.PanBusquedaUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbBuscarPorUsu)).EndInit();
            this.PanPiePagina.ResumeLayout(false);
            this.PanListViewsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario.Panel)).EndInit();
            this.KgbDatosUsuario.Panel.ResumeLayout(false);
            this.KgbDatosUsuario.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario)).EndInit();
            this.KgbDatosUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloFormAbierto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloFormAbierto;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbTituloFrm;
        private System.Windows.Forms.Panel PanBusquedaUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrden;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbBuscarPorUsu;
        private System.Windows.Forms.Label LblBuscarPor;
        private System.Windows.Forms.Panel PanPiePagina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanListViewsOpciones;
        private System.Windows.Forms.ListView LsvUsuariosBD;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KgbDatosUsuario;
        private System.Windows.Forms.Label LblEscribirEmail;
        private System.Windows.Forms.Label LblEscribirNombreUsu;
        private System.Windows.Forms.Label LblTipoUsu;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNombreUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbTipoUsu;
        private System.Windows.Forms.ColumnHeader ColNombre;
        private System.Windows.Forms.ColumnHeader ColTipo;
        private System.Windows.Forms.ColumnHeader ColCorreo;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnEditarUsu;
    }
}