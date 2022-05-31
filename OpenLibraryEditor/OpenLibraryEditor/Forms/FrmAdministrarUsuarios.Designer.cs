namespace OpenLibraryEditor.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrarUsuarios));
            this.PanTituloFormAbierto = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloFormAbierto = new System.Windows.Forms.Label();
            this.MPcbTituloFrm = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.KCmbBuscarPorUsu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.PanPiePagina = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblTipoUsuarioConectado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KgbDatosUsuario = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.GBtnGuardarCambios = new Guna.UI.WinForms.GunaButton();
            this.MBtnEditarUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbTipoUsu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblEscribirEmail = new System.Windows.Forms.Label();
            this.LblEscribirNombreUsu = new System.Windows.Forms.Label();
            this.LblTipoUsu = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNombreUsu = new System.Windows.Forms.Label();
            this.MBtnMenosUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.FlPanBuscar = new System.Windows.Forms.FlowLayoutPanel();
            this.MBtnOrdenMBI = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblBuscarPor = new System.Windows.Forms.Label();
            this.TxtBusqueda = new OpenLibraryEditor.Controles.TxtBusqueda();
            this.MBtnBuscarMBI = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanListViewsOpciones = new System.Windows.Forms.Panel();
            this.MBtnMasUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.LsvUsuariosBD = new System.Windows.Forms.ListView();
            this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TTAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblNumeroLsv = new System.Windows.Forms.Label();
            this.PanTituloFormAbierto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbTituloFrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbBuscarPorUsu)).BeginInit();
            this.PanPiePagina.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario.Panel)).BeginInit();
            this.KgbDatosUsuario.Panel.SuspendLayout();
            this.KgbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoUsu)).BeginInit();
            this.FlPanBuscar.SuspendLayout();
            this.PanListViewsOpciones.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.LblTituloFormAbierto.Size = new System.Drawing.Size(365, 32);
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
            // KCmbBuscarPorUsu
            // 
            this.KCmbBuscarPorUsu.DropDownWidth = 160;
            this.KCmbBuscarPorUsu.Location = new System.Drawing.Point(166, 3);
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
            this.KCmbBuscarPorUsu.TabIndex = 0;
            // 
            // PanPiePagina
            // 
            this.PanPiePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanPiePagina.Controls.Add(this.panel5);
            this.PanPiePagina.Controls.Add(this.panel1);
            this.PanPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanPiePagina.Location = new System.Drawing.Point(0, 646);
            this.PanPiePagina.Name = "PanPiePagina";
            this.PanPiePagina.Size = new System.Drawing.Size(948, 47);
            this.PanPiePagina.TabIndex = 142;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LblTipoUsuarioConectado);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(550, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 43);
            this.panel5.TabIndex = 5;
            // 
            // LblTipoUsuarioConectado
            // 
            this.LblTipoUsuarioConectado.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoUsuarioConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTipoUsuarioConectado.Location = new System.Drawing.Point(27, 13);
            this.LblTipoUsuarioConectado.Name = "LblTipoUsuarioConectado";
            this.LblTipoUsuarioConectado.Size = new System.Drawing.Size(360, 20);
            this.LblTipoUsuarioConectado.TabIndex = 2;
            this.LblTipoUsuarioConectado.Text = "Estás en modo sin conexión";
            this.LblTipoUsuarioConectado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // KgbDatosUsuario
            // 
            this.KgbDatosUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KgbDatosUsuario.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KgbDatosUsuario.Location = new System.Drawing.Point(457, 150);
            this.KgbDatosUsuario.Name = "KgbDatosUsuario";
            // 
            // KgbDatosUsuario.Panel
            // 
            this.KgbDatosUsuario.Panel.Controls.Add(this.GBtnGuardarCambios);
            this.KgbDatosUsuario.Panel.Controls.Add(this.MBtnEditarUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.KCmbTipoUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblEscribirEmail);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblEscribirNombreUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblTipoUsu);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblEmail);
            this.KgbDatosUsuario.Panel.Controls.Add(this.LblNombreUsu);
            this.KgbDatosUsuario.Size = new System.Drawing.Size(475, 259);
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
            // GBtnGuardarCambios
            // 
            this.GBtnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GBtnGuardarCambios.AnimationHoverSpeed = 0.07F;
            this.GBtnGuardarCambios.AnimationSpeed = 0.03F;
            this.GBtnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.GBtnGuardarCambios.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnGuardarCambios.BorderColor = System.Drawing.Color.Empty;
            this.GBtnGuardarCambios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnGuardarCambios.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnGuardarCambios.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnGuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnGuardarCambios.Image = null;
            this.GBtnGuardarCambios.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnGuardarCambios.Location = new System.Drawing.Point(282, 170);
            this.GBtnGuardarCambios.Margin = new System.Windows.Forms.Padding(3, 5, 8, 3);
            this.GBtnGuardarCambios.Name = "GBtnGuardarCambios";
            this.GBtnGuardarCambios.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnGuardarCambios.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnGuardarCambios.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnGuardarCambios.OnHoverImage = null;
            this.GBtnGuardarCambios.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnGuardarCambios.Radius = 15;
            this.GBtnGuardarCambios.Size = new System.Drawing.Size(126, 35);
            this.GBtnGuardarCambios.TabIndex = 1;
            this.GBtnGuardarCambios.Text = "Guardar";
            this.GBtnGuardarCambios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnGuardarCambios.Click += new System.EventHandler(this.GBtnGuardarCambios_Click);
            // 
            // MBtnEditarUsu
            // 
            this.MBtnEditarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnEditarUsu.FlatAppearance.BorderSize = 0;
            this.MBtnEditarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnEditarUsu.IconChar = FontAwesome.Sharp.MaterialIcons.PencilPlus;
            this.MBtnEditarUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnEditarUsu.IconSize = 40;
            this.MBtnEditarUsu.Location = new System.Drawing.Point(430, 12);
            this.MBtnEditarUsu.Name = "MBtnEditarUsu";
            this.MBtnEditarUsu.Size = new System.Drawing.Size(30, 30);
            this.MBtnEditarUsu.TabIndex = 166;
            this.MBtnEditarUsu.UseVisualStyleBackColor = true;
            this.MBtnEditarUsu.Visible = false;
            this.MBtnEditarUsu.Click += new System.EventHandler(this.MBtnEditarUsu_Click);
            // 
            // KCmbTipoUsu
            // 
            this.KCmbTipoUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KCmbTipoUsu.DropDownWidth = 228;
            this.KCmbTipoUsu.Location = new System.Drawing.Point(196, 96);
            this.KCmbTipoUsu.Name = "KCmbTipoUsu";
            this.KCmbTipoUsu.Size = new System.Drawing.Size(212, 33);
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
            this.KCmbTipoUsu.TabIndex = 0;
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
            this.MBtnMenosUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MBtnMenosUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosUsu.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnMenosUsu.IconSize = 50;
            this.MBtnMenosUsu.Location = new System.Drawing.Point(401, 46);
            this.MBtnMenosUsu.Name = "MBtnMenosUsu";
            this.MBtnMenosUsu.Size = new System.Drawing.Size(30, 30);
            this.MBtnMenosUsu.TabIndex = 165;
            this.MBtnMenosUsu.UseVisualStyleBackColor = false;
            this.MBtnMenosUsu.Click += new System.EventHandler(this.MBtnMenosUsu_Click);
            // 
            // FlPanBuscar
            // 
            this.FlPanBuscar.AutoSize = true;
            this.FlPanBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlPanBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.FlPanBuscar.Controls.Add(this.MBtnOrdenMBI);
            this.FlPanBuscar.Controls.Add(this.LblBuscarPor);
            this.FlPanBuscar.Controls.Add(this.KCmbBuscarPorUsu);
            this.FlPanBuscar.Controls.Add(this.TxtBusqueda);
            this.FlPanBuscar.Controls.Add(this.MBtnBuscarMBI);
            this.FlPanBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlPanBuscar.Location = new System.Drawing.Point(0, 64);
            this.FlPanBuscar.Name = "FlPanBuscar";
            this.FlPanBuscar.Size = new System.Drawing.Size(948, 42);
            this.FlPanBuscar.TabIndex = 145;
            // 
            // MBtnOrdenMBI
            // 
            this.MBtnOrdenMBI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMBI.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMBI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMBI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnOrdenMBI.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMBI.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnOrdenMBI.IconSize = 40;
            this.MBtnOrdenMBI.Location = new System.Drawing.Point(15, 3);
            this.MBtnOrdenMBI.Margin = new System.Windows.Forms.Padding(15, 3, 25, 3);
            this.MBtnOrdenMBI.Name = "MBtnOrdenMBI";
            this.MBtnOrdenMBI.Size = new System.Drawing.Size(34, 34);
            this.MBtnOrdenMBI.TabIndex = 3;
            this.MBtnOrdenMBI.UseVisualStyleBackColor = true;
            this.MBtnOrdenMBI.Click += new System.EventHandler(this.MBtnOrden_Click);
            // 
            // LblBuscarPor
            // 
            this.LblBuscarPor.AutoSize = true;
            this.LblBuscarPor.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblBuscarPor.Location = new System.Drawing.Point(77, 0);
            this.LblBuscarPor.Name = "LblBuscarPor";
            this.LblBuscarPor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LblBuscarPor.Size = new System.Drawing.Size(83, 28);
            this.LblBuscarPor.TabIndex = 133;
            this.LblBuscarPor.Text = "Buscar por:";
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.TxtBusqueda.Location = new System.Drawing.Point(379, 3);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(263, 36);
            this.TxtBusqueda.TabIndex = 1;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KTxtBuscarUsu_KeyDown);
            // 
            // MBtnBuscarMBI
            // 
            this.MBtnBuscarMBI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMBI.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMBI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMBI.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMBI.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMBI.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnBuscarMBI.IconSize = 45;
            this.MBtnBuscarMBI.Location = new System.Drawing.Point(648, 3);
            this.MBtnBuscarMBI.Name = "MBtnBuscarMBI";
            this.MBtnBuscarMBI.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMBI.Size = new System.Drawing.Size(34, 34);
            this.MBtnBuscarMBI.TabIndex = 2;
            this.MBtnBuscarMBI.UseVisualStyleBackColor = true;
            this.MBtnBuscarMBI.Click += new System.EventHandler(this.MBtnBuscar_Click);
            // 
            // PanListViewsOpciones
            // 
            this.PanListViewsOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanListViewsOpciones.Controls.Add(this.panel7);
            this.PanListViewsOpciones.Controls.Add(this.MBtnMasUsu);
            this.PanListViewsOpciones.Controls.Add(this.LsvUsuariosBD);
            this.PanListViewsOpciones.Controls.Add(this.MBtnMenosUsu);
            this.PanListViewsOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanListViewsOpciones.Location = new System.Drawing.Point(0, 106);
            this.PanListViewsOpciones.Name = "PanListViewsOpciones";
            this.PanListViewsOpciones.Size = new System.Drawing.Size(440, 540);
            this.PanListViewsOpciones.TabIndex = 146;
            // 
            // MBtnMasUsu
            // 
            this.MBtnMasUsu.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasUsu.FlatAppearance.BorderSize = 0;
            this.MBtnMasUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MBtnMasUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasUsu.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBoxOutline;
            this.MBtnMasUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnMasUsu.IconSize = 50;
            this.MBtnMasUsu.Location = new System.Drawing.Point(401, 10);
            this.MBtnMasUsu.Name = "MBtnMasUsu";
            this.MBtnMasUsu.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasUsu.TabIndex = 168;
            this.MBtnMasUsu.UseVisualStyleBackColor = false;
            this.MBtnMasUsu.Click += new System.EventHandler(this.MBtnMasUsu_Click);
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
            this.LsvUsuariosBD.Size = new System.Drawing.Size(382, 476);
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
            this.ColTipo.Text = "Tipo de usuario";
            this.ColTipo.Width = 128;
            // 
            // ColCorreo
            // 
            this.ColCorreo.Text = "Email";
            this.ColCorreo.Width = 132;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel7.Controls.Add(this.LblNumeroLsv);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 492);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(440, 48);
            this.panel7.TabIndex = 169;
            // 
            // LblNumeroLsv
            // 
            this.LblNumeroLsv.AutoSize = true;
            this.LblNumeroLsv.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroLsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblNumeroLsv.Location = new System.Drawing.Point(11, 15);
            this.LblNumeroLsv.Name = "LblNumeroLsv";
            this.LblNumeroLsv.Size = new System.Drawing.Size(135, 20);
            this.LblNumeroLsv.TabIndex = 2;
            this.LblNumeroLsv.Text = "Número de libros:";
            // 
            // FrmAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanListViewsOpciones);
            this.Controls.Add(this.FlPanBuscar);
            this.Controls.Add(this.KgbDatosUsuario);
            this.Controls.Add(this.PanPiePagina);
            this.Controls.Add(this.PanTituloFormAbierto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrarUsuarios";
            this.Text = "FrmAdministrarUsuarios";
            this.Load += new System.EventHandler(this.FrmAdministrarUsuarios_Load);
            this.PanTituloFormAbierto.ResumeLayout(false);
            this.PanTituloFormAbierto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbTituloFrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbBuscarPorUsu)).EndInit();
            this.PanPiePagina.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario.Panel)).EndInit();
            this.KgbDatosUsuario.Panel.ResumeLayout(false);
            this.KgbDatosUsuario.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosUsuario)).EndInit();
            this.KgbDatosUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoUsu)).EndInit();
            this.FlPanBuscar.ResumeLayout(false);
            this.FlPanBuscar.PerformLayout();
            this.PanListViewsOpciones.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloFormAbierto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloFormAbierto;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbTituloFrm;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbBuscarPorUsu;
        private System.Windows.Forms.Panel PanPiePagina;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KgbDatosUsuario;
        private System.Windows.Forms.Label LblEscribirEmail;
        private System.Windows.Forms.Label LblEscribirNombreUsu;
        private System.Windows.Forms.Label LblTipoUsu;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNombreUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbTipoUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnEditarUsu;
        private System.Windows.Forms.FlowLayoutPanel FlPanBuscar;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMBI;
        private System.Windows.Forms.Label LblBuscarPor;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMBI;
        private System.Windows.Forms.Panel PanListViewsOpciones;
        private System.Windows.Forms.ListView LsvUsuariosBD;
        private System.Windows.Forms.ColumnHeader ColNombre;
        private System.Windows.Forms.ColumnHeader ColTipo;
        private System.Windows.Forms.ColumnHeader ColCorreo;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasUsu;
        private Controles.TxtBusqueda TxtBusqueda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblTipoUsuarioConectado;
        private Guna.UI.WinForms.GunaButton GBtnGuardarCambios;
        private System.Windows.Forms.ToolTip TTAdmin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LblNumeroLsv;
    }
}