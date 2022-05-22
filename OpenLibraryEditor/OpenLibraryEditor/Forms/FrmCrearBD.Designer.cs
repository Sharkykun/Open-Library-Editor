namespace OpenLibraryEditor.Forms
{
    partial class FrmCrearBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearBD));
            this.PanBtn = new System.Windows.Forms.Panel();
            this.GBtnCrear = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanTituloAutores = new System.Windows.Forms.Panel();
            this.MBtnCerrarAutores = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcbLogoAutores = new System.Windows.Forms.PictureBox();
            this.KgbDatosServidor = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.IpcbMostrarContraSer = new FontAwesome.Sharp.IconPictureBox();
            this.KNudPuerto = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.KTxtNombreUSer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtUrl = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblContraSer = new System.Windows.Forms.Label();
            this.LblNombreSer = new System.Windows.Forms.Label();
            this.LblPuerto = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.IpcbOcultarContraSer = new FontAwesome.Sharp.IconPictureBox();
            this.KTxtCSer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KgbDatosApp = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.IpcbMostrarContraUsu = new FontAwesome.Sharp.IconPictureBox();
            this.IpcbOcultarContraUsu = new FontAwesome.Sharp.IconPictureBox();
            this.KTxtContraApp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtEmailApp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtNombreApp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblContraApp = new System.Windows.Forms.Label();
            this.LblEmailApp = new System.Windows.Forms.Label();
            this.LblNombreApp = new System.Windows.Forms.Label();
            this.PanBtn.SuspendLayout();
            this.PanTituloAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosServidor.Panel)).BeginInit();
            this.KgbDatosServidor.Panel.SuspendLayout();
            this.KgbDatosServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContraSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContraSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosApp.Panel)).BeginInit();
            this.KgbDatosApp.Panel.SuspendLayout();
            this.KgbDatosApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContraUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContraUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtn
            // 
            this.PanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtn.Controls.Add(this.GBtnCrear);
            this.PanBtn.Controls.Add(this.GBtnCancelar);
            this.PanBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtn.Location = new System.Drawing.Point(3, 503);
            this.PanBtn.Name = "PanBtn";
            this.PanBtn.Size = new System.Drawing.Size(559, 45);
            this.PanBtn.TabIndex = 156;
            // 
            // GBtnCrear
            // 
            this.GBtnCrear.AnimationHoverSpeed = 0.07F;
            this.GBtnCrear.AnimationSpeed = 0.03F;
            this.GBtnCrear.BackColor = System.Drawing.Color.Transparent;
            this.GBtnCrear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnCrear.BorderColor = System.Drawing.Color.Empty;
            this.GBtnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnCrear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnCrear.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnCrear.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnCrear.Image = null;
            this.GBtnCrear.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnCrear.Location = new System.Drawing.Point(417, 5);
            this.GBtnCrear.Name = "GBtnCrear";
            this.GBtnCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnCrear.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnCrear.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCrear.OnHoverImage = null;
            this.GBtnCrear.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnCrear.Radius = 15;
            this.GBtnCrear.Size = new System.Drawing.Size(126, 35);
            this.GBtnCrear.TabIndex = 0;
            this.GBtnCrear.Text = "Crear";
            this.GBtnCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCrear.Click += new System.EventHandler(this.GBtnCrear_Click);
            // 
            // GBtnCancelar
            // 
            this.GBtnCancelar.AnimationHoverSpeed = 0.07F;
            this.GBtnCancelar.AnimationSpeed = 0.03F;
            this.GBtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCancelar.Image = null;
            this.GBtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnCancelar.Location = new System.Drawing.Point(285, 5);
            this.GBtnCancelar.Name = "GBtnCancelar";
            this.GBtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.OnHoverForeColor = System.Drawing.Color.Black;
            this.GBtnCancelar.OnHoverImage = null;
            this.GBtnCancelar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Radius = 15;
            this.GBtnCancelar.Size = new System.Drawing.Size(126, 35);
            this.GBtnCancelar.TabIndex = 1;
            this.GBtnCancelar.Text = "Cancelar";
            this.GBtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCancelar.Click += new System.EventHandler(this.GBtnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(562, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 508);
            this.panel2.TabIndex = 155;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 508);
            this.panel1.TabIndex = 154;
            // 
            // PanTituloAutores
            // 
            this.PanTituloAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloAutores.Controls.Add(this.MBtnCerrarAutores);
            this.PanTituloAutores.Controls.Add(this.LblTitulo);
            this.PanTituloAutores.Controls.Add(this.PcbLogoAutores);
            this.PanTituloAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloAutores.Location = new System.Drawing.Point(0, 0);
            this.PanTituloAutores.Name = "PanTituloAutores";
            this.PanTituloAutores.Size = new System.Drawing.Size(565, 40);
            this.PanTituloAutores.TabIndex = 153;
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
            this.MBtnCerrarAutores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarAutores.IconSize = 40;
            this.MBtnCerrarAutores.Location = new System.Drawing.Point(533, 0);
            this.MBtnCerrarAutores.Name = "MBtnCerrarAutores";
            this.MBtnCerrarAutores.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarAutores.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarAutores.TabIndex = 28;
            this.MBtnCerrarAutores.UseVisualStyleBackColor = false;
            this.MBtnCerrarAutores.Click += new System.EventHandler(this.MBtnCerrarAutores_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTitulo.Location = new System.Drawing.Point(54, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(343, 23);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Open Library Editor - Crear base de datos";
            this.LblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
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
            this.PcbLogoAutores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
            // 
            // KgbDatosServidor
            // 
            this.KgbDatosServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KgbDatosServidor.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KgbDatosServidor.Location = new System.Drawing.Point(20, 57);
            this.KgbDatosServidor.Name = "KgbDatosServidor";
            // 
            // KgbDatosServidor.Panel
            // 
            this.KgbDatosServidor.Panel.Controls.Add(this.KNudPuerto);
            this.KgbDatosServidor.Panel.Controls.Add(this.KTxtNombreUSer);
            this.KgbDatosServidor.Panel.Controls.Add(this.KTxtUrl);
            this.KgbDatosServidor.Panel.Controls.Add(this.LblContraSer);
            this.KgbDatosServidor.Panel.Controls.Add(this.LblNombreSer);
            this.KgbDatosServidor.Panel.Controls.Add(this.LblPuerto);
            this.KgbDatosServidor.Panel.Controls.Add(this.LblUrl);
            this.KgbDatosServidor.Panel.Controls.Add(this.IpcbMostrarContraSer);
            this.KgbDatosServidor.Panel.Controls.Add(this.IpcbOcultarContraSer);
            this.KgbDatosServidor.Panel.Controls.Add(this.KTxtCSer);
            this.KgbDatosServidor.Size = new System.Drawing.Size(521, 211);
            this.KgbDatosServidor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosServidor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosServidor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosServidor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosServidor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KgbDatosServidor.StateCommon.Border.Rounding = 0;
            this.KgbDatosServidor.StateCommon.Border.Width = 2;
            this.KgbDatosServidor.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosServidor.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosServidor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgbDatosServidor.TabIndex = 157;
            this.KgbDatosServidor.Values.Heading = "Datos del servidor";
            // 
            // IpcbMostrarContraSer
            // 
            this.IpcbMostrarContraSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.IpcbMostrarContraSer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbMostrarContraSer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbMostrarContraSer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContraSer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IpcbMostrarContraSer.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContraSer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbMostrarContraSer.IconSize = 23;
            this.IpcbMostrarContraSer.Location = new System.Drawing.Point(462, 127);
            this.IpcbMostrarContraSer.Name = "IpcbMostrarContraSer";
            this.IpcbMostrarContraSer.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.IpcbMostrarContraSer.Size = new System.Drawing.Size(23, 23);
            this.IpcbMostrarContraSer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbMostrarContraSer.TabIndex = 31;
            this.IpcbMostrarContraSer.TabStop = false;
            this.IpcbMostrarContraSer.Click += new System.EventHandler(this.IpcbMostrarContraSer_Click);
            // 
            // KNudPuerto
            // 
            this.KNudPuerto.Location = new System.Drawing.Point(175, 51);
            this.KNudPuerto.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.KNudPuerto.Name = "KNudPuerto";
            this.KNudPuerto.Size = new System.Drawing.Size(160, 33);
            this.KNudPuerto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KNudPuerto.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KNudPuerto.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KNudPuerto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KNudPuerto.StateCommon.Border.Rounding = 10;
            this.KNudPuerto.StateCommon.Border.Width = 2;
            this.KNudPuerto.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KNudPuerto.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KNudPuerto.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1);
            this.KNudPuerto.TabIndex = 1;
            this.KNudPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KNudPuerto.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // KTxtNombreUSer
            // 
            this.KTxtNombreUSer.Location = new System.Drawing.Point(175, 87);
            this.KTxtNombreUSer.Name = "KTxtNombreUSer";
            this.KTxtNombreUSer.Size = new System.Drawing.Size(322, 33);
            this.KTxtNombreUSer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreUSer.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreUSer.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreUSer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreUSer.StateCommon.Border.Rounding = 10;
            this.KTxtNombreUSer.StateCommon.Border.Width = 2;
            this.KTxtNombreUSer.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreUSer.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreUSer.TabIndex = 2;
            this.KTxtNombreUSer.Text = "root";
            // 
            // KTxtUrl
            // 
            this.KTxtUrl.Location = new System.Drawing.Point(175, 15);
            this.KTxtUrl.Name = "KTxtUrl";
            this.KTxtUrl.Size = new System.Drawing.Size(322, 33);
            this.KTxtUrl.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtUrl.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtUrl.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtUrl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtUrl.StateCommon.Border.Rounding = 10;
            this.KTxtUrl.StateCommon.Border.Width = 2;
            this.KTxtUrl.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtUrl.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtUrl.TabIndex = 0;
            this.KTxtUrl.Text = "localhost";
            // 
            // LblContraSer
            // 
            this.LblContraSer.AutoSize = true;
            this.LblContraSer.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraSer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblContraSer.Location = new System.Drawing.Point(20, 129);
            this.LblContraSer.Name = "LblContraSer";
            this.LblContraSer.Size = new System.Drawing.Size(100, 22);
            this.LblContraSer.TabIndex = 30;
            this.LblContraSer.Text = "Contraseña:";
            // 
            // LblNombreSer
            // 
            this.LblNombreSer.AutoSize = true;
            this.LblNombreSer.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreSer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblNombreSer.Location = new System.Drawing.Point(20, 93);
            this.LblNombreSer.Name = "LblNombreSer";
            this.LblNombreSer.Size = new System.Drawing.Size(135, 22);
            this.LblNombreSer.TabIndex = 29;
            this.LblNombreSer.Text = "Nombre usuario:";
            // 
            // LblPuerto
            // 
            this.LblPuerto.AutoSize = true;
            this.LblPuerto.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblPuerto.Location = new System.Drawing.Point(20, 57);
            this.LblPuerto.Name = "LblPuerto";
            this.LblPuerto.Size = new System.Drawing.Size(62, 22);
            this.LblPuerto.TabIndex = 23;
            this.LblPuerto.Text = "Puerto:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblUrl.Location = new System.Drawing.Point(20, 21);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(36, 22);
            this.LblUrl.TabIndex = 21;
            this.LblUrl.Text = "Url:";
            // 
            // IpcbOcultarContraSer
            // 
            this.IpcbOcultarContraSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.IpcbOcultarContraSer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbOcultarContraSer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbOcultarContraSer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContraSer.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IpcbOcultarContraSer.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContraSer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbOcultarContraSer.IconSize = 23;
            this.IpcbOcultarContraSer.Location = new System.Drawing.Point(462, 127);
            this.IpcbOcultarContraSer.Name = "IpcbOcultarContraSer";
            this.IpcbOcultarContraSer.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.IpcbOcultarContraSer.Size = new System.Drawing.Size(23, 23);
            this.IpcbOcultarContraSer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbOcultarContraSer.TabIndex = 32;
            this.IpcbOcultarContraSer.TabStop = false;
            this.IpcbOcultarContraSer.Visible = false;
            this.IpcbOcultarContraSer.Click += new System.EventHandler(this.IpcbOcultarContraSer_Click);
            // 
            // KTxtCSer
            // 
            this.KTxtCSer.Location = new System.Drawing.Point(175, 123);
            this.KTxtCSer.Name = "KTxtCSer";
            this.KTxtCSer.PasswordChar = '●';
            this.KTxtCSer.Size = new System.Drawing.Size(322, 33);
            this.KTxtCSer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtCSer.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtCSer.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtCSer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtCSer.StateCommon.Border.Rounding = 10;
            this.KTxtCSer.StateCommon.Border.Width = 2;
            this.KTxtCSer.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtCSer.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtCSer.TabIndex = 3;
            this.KTxtCSer.UseSystemPasswordChar = true;
            // 
            // KgbDatosApp
            // 
            this.KgbDatosApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KgbDatosApp.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KgbDatosApp.Location = new System.Drawing.Point(20, 294);
            this.KgbDatosApp.Name = "KgbDatosApp";
            // 
            // KgbDatosApp.Panel
            // 
            this.KgbDatosApp.Panel.Controls.Add(this.KTxtEmailApp);
            this.KgbDatosApp.Panel.Controls.Add(this.KTxtNombreApp);
            this.KgbDatosApp.Panel.Controls.Add(this.LblContraApp);
            this.KgbDatosApp.Panel.Controls.Add(this.LblEmailApp);
            this.KgbDatosApp.Panel.Controls.Add(this.LblNombreApp);
            this.KgbDatosApp.Panel.Controls.Add(this.IpcbMostrarContraUsu);
            this.KgbDatosApp.Panel.Controls.Add(this.IpcbOcultarContraUsu);
            this.KgbDatosApp.Panel.Controls.Add(this.KTxtContraApp);
            this.KgbDatosApp.Size = new System.Drawing.Size(521, 178);
            this.KgbDatosApp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosApp.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosApp.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosApp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosApp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KgbDatosApp.StateCommon.Border.Rounding = 0;
            this.KgbDatosApp.StateCommon.Border.Width = 2;
            this.KgbDatosApp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosApp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosApp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgbDatosApp.TabIndex = 158;
            this.KgbDatosApp.Values.Heading = "Datos para registrarse en la aplicación";
            // 
            // IpcbMostrarContraUsu
            // 
            this.IpcbMostrarContraUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.IpcbMostrarContraUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbMostrarContraUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbMostrarContraUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContraUsu.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IpcbMostrarContraUsu.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContraUsu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbMostrarContraUsu.IconSize = 23;
            this.IpcbMostrarContraUsu.Location = new System.Drawing.Point(462, 91);
            this.IpcbMostrarContraUsu.Name = "IpcbMostrarContraUsu";
            this.IpcbMostrarContraUsu.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.IpcbMostrarContraUsu.Size = new System.Drawing.Size(23, 23);
            this.IpcbMostrarContraUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbMostrarContraUsu.TabIndex = 33;
            this.IpcbMostrarContraUsu.TabStop = false;
            this.IpcbMostrarContraUsu.Click += new System.EventHandler(this.IpcbMostrarContraUsu_Click);
            // 
            // IpcbOcultarContraUsu
            // 
            this.IpcbOcultarContraUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.IpcbOcultarContraUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbOcultarContraUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbOcultarContraUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContraUsu.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IpcbOcultarContraUsu.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContraUsu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbOcultarContraUsu.IconSize = 23;
            this.IpcbOcultarContraUsu.Location = new System.Drawing.Point(462, 91);
            this.IpcbOcultarContraUsu.Name = "IpcbOcultarContraUsu";
            this.IpcbOcultarContraUsu.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.IpcbOcultarContraUsu.Size = new System.Drawing.Size(23, 23);
            this.IpcbOcultarContraUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbOcultarContraUsu.TabIndex = 33;
            this.IpcbOcultarContraUsu.TabStop = false;
            this.IpcbOcultarContraUsu.Visible = false;
            this.IpcbOcultarContraUsu.Click += new System.EventHandler(this.IpcbOcultarContraUsu_Click);
            // 
            // KTxtContraApp
            // 
            this.KTxtContraApp.Location = new System.Drawing.Point(175, 87);
            this.KTxtContraApp.Name = "KTxtContraApp";
            this.KTxtContraApp.PasswordChar = '●';
            this.KTxtContraApp.Size = new System.Drawing.Size(322, 33);
            this.KTxtContraApp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtContraApp.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtContraApp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtContraApp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContraApp.StateCommon.Border.Rounding = 10;
            this.KTxtContraApp.StateCommon.Border.Width = 2;
            this.KTxtContraApp.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtContraApp.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtContraApp.TabIndex = 2;
            this.KTxtContraApp.Text = "test";
            this.KTxtContraApp.UseSystemPasswordChar = true;
            // 
            // KTxtEmailApp
            // 
            this.KTxtEmailApp.Location = new System.Drawing.Point(175, 51);
            this.KTxtEmailApp.Name = "KTxtEmailApp";
            this.KTxtEmailApp.Size = new System.Drawing.Size(322, 33);
            this.KTxtEmailApp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtEmailApp.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtEmailApp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtEmailApp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtEmailApp.StateCommon.Border.Rounding = 10;
            this.KTxtEmailApp.StateCommon.Border.Width = 2;
            this.KTxtEmailApp.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtEmailApp.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtEmailApp.TabIndex = 1;
            this.KTxtEmailApp.Text = "test@gmail.com";
            // 
            // KTxtNombreApp
            // 
            this.KTxtNombreApp.Location = new System.Drawing.Point(175, 15);
            this.KTxtNombreApp.Name = "KTxtNombreApp";
            this.KTxtNombreApp.Size = new System.Drawing.Size(322, 33);
            this.KTxtNombreApp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreApp.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreApp.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreApp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreApp.StateCommon.Border.Rounding = 10;
            this.KTxtNombreApp.StateCommon.Border.Width = 2;
            this.KTxtNombreApp.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreApp.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreApp.TabIndex = 0;
            this.KTxtNombreApp.Text = "test";
            // 
            // LblContraApp
            // 
            this.LblContraApp.AutoSize = true;
            this.LblContraApp.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblContraApp.Location = new System.Drawing.Point(20, 93);
            this.LblContraApp.Name = "LblContraApp";
            this.LblContraApp.Size = new System.Drawing.Size(100, 22);
            this.LblContraApp.TabIndex = 29;
            this.LblContraApp.Text = "Contraseña:";
            // 
            // LblEmailApp
            // 
            this.LblEmailApp.AutoSize = true;
            this.LblEmailApp.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEmailApp.Location = new System.Drawing.Point(20, 57);
            this.LblEmailApp.Name = "LblEmailApp";
            this.LblEmailApp.Size = new System.Drawing.Size(55, 22);
            this.LblEmailApp.TabIndex = 23;
            this.LblEmailApp.Text = "Email:";
            // 
            // LblNombreApp
            // 
            this.LblNombreApp.AutoSize = true;
            this.LblNombreApp.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblNombreApp.Location = new System.Drawing.Point(20, 21);
            this.LblNombreApp.Name = "LblNombreApp";
            this.LblNombreApp.Size = new System.Drawing.Size(135, 22);
            this.LblNombreApp.TabIndex = 21;
            this.LblNombreApp.Text = "Nombre usuario:";
            // 
            // FrmCrearBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(565, 548);
            this.Controls.Add(this.KgbDatosApp);
            this.Controls.Add(this.KgbDatosServidor);
            this.Controls.Add(this.PanBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanTituloAutores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrearBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearBD";
            this.Load += new System.EventHandler(this.FrmCrearBD_Load);
            this.PanBtn.ResumeLayout(false);
            this.PanTituloAutores.ResumeLayout(false);
            this.PanTituloAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosServidor.Panel)).EndInit();
            this.KgbDatosServidor.Panel.ResumeLayout(false);
            this.KgbDatosServidor.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosServidor)).EndInit();
            this.KgbDatosServidor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContraSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContraSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosApp.Panel)).EndInit();
            this.KgbDatosApp.Panel.ResumeLayout(false);
            this.KgbDatosApp.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosApp)).EndInit();
            this.KgbDatosApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContraUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContraUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBtn;
        private Guna.UI.WinForms.GunaButton GBtnCrear;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanTituloAutores;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarAutores;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PcbLogoAutores;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KgbDatosServidor;
        private System.Windows.Forms.Label LblContraSer;
        private System.Windows.Forms.Label LblNombreSer;
        private System.Windows.Forms.Label LblPuerto;
        private System.Windows.Forms.Label LblUrl;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KgbDatosApp;
        private System.Windows.Forms.Label LblContraApp;
        private System.Windows.Forms.Label LblEmailApp;
        private System.Windows.Forms.Label LblNombreApp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtCSer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreUSer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtUrl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtContraApp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtEmailApp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreApp;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown KNudPuerto;
        private FontAwesome.Sharp.IconPictureBox IpcbMostrarContraSer;
        private FontAwesome.Sharp.IconPictureBox IpcbOcultarContraSer;
        private FontAwesome.Sharp.IconPictureBox IpcbOcultarContraUsu;
        private FontAwesome.Sharp.IconPictureBox IpcbMostrarContraUsu;
    }
}