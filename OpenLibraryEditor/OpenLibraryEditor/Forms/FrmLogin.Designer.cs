namespace OpenLibraryEditor.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanLogin = new System.Windows.Forms.Panel();
            this.GBtnCrearBD = new Guna.UI.WinForms.GunaButton();
            this.GBtnEntrar = new Guna.UI.WinForms.GunaButton();
            this.GBtnSinConexion = new Guna.UI.WinForms.GunaButton();
            this.LblError = new System.Windows.Forms.Label();
            this.LblSesionIniciada = new System.Windows.Forms.Label();
            this.ToggleConectado = new OpenLibraryEditor.Controles.ToggleButton();
            this.KTxtNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtUrl = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LlblRecuperar = new System.Windows.Forms.LinkLabel();
            this.IpcbMostrarContra = new FontAwesome.Sharp.IconPictureBox();
            this.IpcbOcultarContra = new FontAwesome.Sharp.IconPictureBox();
            this.KTxtContra = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.GBtnRegistro = new Guna.UI.WinForms.GunaButton();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.ToolIdiomas = new System.Windows.Forms.ToolStrip();
            this.BtnSpain = new System.Windows.Forms.ToolStripButton();
            this.BtnUsa = new System.Windows.Forms.ToolStripButton();
            this.BtnFrancia = new System.Windows.Forms.ToolStripButton();
            this.TimerAparecer = new System.Windows.Forms.Timer(this.components);
            this.MBtnCerrarLogin = new FontAwesome.Sharp.Material.MaterialButton();
            this.TTLogin = new System.Windows.Forms.ToolTip(this.components);
            this.PanLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.ToolIdiomas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanLogin
            // 
            this.PanLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.PanLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanLogin.Controls.Add(this.GBtnCrearBD);
            this.PanLogin.Controls.Add(this.GBtnEntrar);
            this.PanLogin.Controls.Add(this.GBtnRegistro);
            this.PanLogin.Controls.Add(this.GBtnSinConexion);
            this.PanLogin.Controls.Add(this.LblError);
            this.PanLogin.Controls.Add(this.LblSesionIniciada);
            this.PanLogin.Controls.Add(this.ToggleConectado);
            this.PanLogin.Controls.Add(this.KTxtNombre);
            this.PanLogin.Controls.Add(this.KTxtUrl);
            this.PanLogin.Controls.Add(this.LlblRecuperar);
            this.PanLogin.Controls.Add(this.IpcbMostrarContra);
            this.PanLogin.Controls.Add(this.IpcbOcultarContra);
            this.PanLogin.Controls.Add(this.KTxtContra);
            this.PanLogin.Location = new System.Drawing.Point(664, 179);
            this.PanLogin.Margin = new System.Windows.Forms.Padding(2);
            this.PanLogin.Name = "PanLogin";
            this.PanLogin.Size = new System.Drawing.Size(385, 375);
            this.PanLogin.TabIndex = 11;
            // 
            // GBtnCrearBD
            // 
            this.GBtnCrearBD.AnimationHoverSpeed = 0.07F;
            this.GBtnCrearBD.AnimationSpeed = 0.03F;
            this.GBtnCrearBD.BackColor = System.Drawing.Color.Transparent;
            this.GBtnCrearBD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCrearBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCrearBD.BorderSize = 2;
            this.GBtnCrearBD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnCrearBD.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnCrearBD.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnCrearBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCrearBD.Image = null;
            this.GBtnCrearBD.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnCrearBD.Location = new System.Drawing.Point(15, 5);
            this.GBtnCrearBD.Name = "GBtnCrearBD";
            this.GBtnCrearBD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCrearBD.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCrearBD.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCrearBD.OnHoverImage = null;
            this.GBtnCrearBD.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCrearBD.Radius = 18;
            this.GBtnCrearBD.Size = new System.Drawing.Size(355, 39);
            this.GBtnCrearBD.TabIndex = 21;
            this.GBtnCrearBD.Text = "Crear base de datos";
            this.GBtnCrearBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCrearBD.Click += new System.EventHandler(this.GBtnCrearBD_Click);
            // 
            // GBtnEntrar
            // 
            this.GBtnEntrar.AnimationHoverSpeed = 0.07F;
            this.GBtnEntrar.AnimationSpeed = 0.03F;
            this.GBtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnEntrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnEntrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnEntrar.BorderSize = 2;
            this.GBtnEntrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnEntrar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnEntrar.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnEntrar.Image = null;
            this.GBtnEntrar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnEntrar.Location = new System.Drawing.Point(192, 281);
            this.GBtnEntrar.Name = "GBtnEntrar";
            this.GBtnEntrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnEntrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnEntrar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnEntrar.OnHoverImage = null;
            this.GBtnEntrar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnEntrar.Radius = 18;
            this.GBtnEntrar.Size = new System.Drawing.Size(178, 39);
            this.GBtnEntrar.TabIndex = 24;
            this.GBtnEntrar.Text = "Entrar";
            this.GBtnEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnEntrar.Click += new System.EventHandler(this.GBtnEntrar_Click);
            // 
            // GBtnSinConexion
            // 
            this.GBtnSinConexion.AnimationHoverSpeed = 0.07F;
            this.GBtnSinConexion.AnimationSpeed = 0.03F;
            this.GBtnSinConexion.BackColor = System.Drawing.Color.Transparent;
            this.GBtnSinConexion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnSinConexion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnSinConexion.BorderSize = 2;
            this.GBtnSinConexion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnSinConexion.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnSinConexion.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnSinConexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnSinConexion.Image = null;
            this.GBtnSinConexion.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnSinConexion.Location = new System.Drawing.Point(15, 326);
            this.GBtnSinConexion.Name = "GBtnSinConexion";
            this.GBtnSinConexion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnSinConexion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnSinConexion.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnSinConexion.OnHoverImage = null;
            this.GBtnSinConexion.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnSinConexion.Radius = 18;
            this.GBtnSinConexion.Size = new System.Drawing.Size(355, 39);
            this.GBtnSinConexion.TabIndex = 22;
            this.GBtnSinConexion.Text = "Modo sin conexión";
            this.GBtnSinConexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnSinConexion.Click += new System.EventHandler(this.GBtnSinConexion_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Transparent;
            this.LblError.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Black;
            this.LblError.Image = global::OpenLibraryEditor.Properties.Resources.error1;
            this.LblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblError.Location = new System.Drawing.Point(14, 232);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(32, 18);
            this.LblError.TabIndex = 20;
            this.LblError.Text = "      ";
            this.LblError.Visible = false;
            // 
            // LblSesionIniciada
            // 
            this.LblSesionIniciada.AutoSize = true;
            this.LblSesionIniciada.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSesionIniciada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblSesionIniciada.Location = new System.Drawing.Point(50, 182);
            this.LblSesionIniciada.Name = "LblSesionIniciada";
            this.LblSesionIniciada.Size = new System.Drawing.Size(186, 20);
            this.LblSesionIniciada.TabIndex = 8;
            this.LblSesionIniciada.Text = "Mantener sesión iniciada";
            // 
            // ToggleConectado
            // 
            this.ToggleConectado.AutoSize = true;
            this.ToggleConectado.BackColor = System.Drawing.Color.Gainsboro;
            this.ToggleConectado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleConectado.Location = new System.Drawing.Point(251, 182);
            this.ToggleConectado.MinimumSize = new System.Drawing.Size(45, 22);
            this.ToggleConectado.Name = "ToggleConectado";
            this.ToggleConectado.OffBackColor = System.Drawing.Color.DarkGray;
            this.ToggleConectado.OffToggleColor = System.Drawing.Color.Black;
            this.ToggleConectado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.ToggleConectado.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleConectado.Size = new System.Drawing.Size(45, 22);
            this.ToggleConectado.TabIndex = 4;
            this.ToggleConectado.UseVisualStyleBackColor = false;
            // 
            // KTxtNombre
            // 
            this.KTxtNombre.Location = new System.Drawing.Point(15, 94);
            this.KTxtNombre.Name = "KTxtNombre";
            this.KTxtNombre.Size = new System.Drawing.Size(355, 39);
            this.KTxtNombre.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombre.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombre.StateCommon.Border.Rounding = 15;
            this.KTxtNombre.StateCommon.Border.Width = 2;
            this.KTxtNombre.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.KTxtNombre.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombre.TabIndex = 2;
            this.KTxtNombre.Text = "Nombre de Usuario o Email";
            this.KTxtNombre.Enter += new System.EventHandler(this.KTxtNombre_Enter);
            this.KTxtNombre.Leave += new System.EventHandler(this.KTxtNombre_Leave);
            // 
            // KTxtUrl
            // 
            this.KTxtUrl.Location = new System.Drawing.Point(15, 50);
            this.KTxtUrl.Name = "KTxtUrl";
            this.KTxtUrl.Size = new System.Drawing.Size(355, 39);
            this.KTxtUrl.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtUrl.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtUrl.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtUrl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtUrl.StateCommon.Border.Rounding = 15;
            this.KTxtUrl.StateCommon.Border.Width = 2;
            this.KTxtUrl.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.KTxtUrl.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtUrl.TabIndex = 1;
            this.KTxtUrl.Text = "Url base de datos";
            this.KTxtUrl.Enter += new System.EventHandler(this.KTxtUrl_Enter);
            this.KTxtUrl.Leave += new System.EventHandler(this.KTxtUrl_Leave);
            // 
            // LlblRecuperar
            // 
            this.LlblRecuperar.AutoSize = true;
            this.LlblRecuperar.BackColor = System.Drawing.Color.Transparent;
            this.LlblRecuperar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblRecuperar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.LlblRecuperar.Location = new System.Drawing.Point(42, 206);
            this.LlblRecuperar.Name = "LlblRecuperar";
            this.LlblRecuperar.Size = new System.Drawing.Size(294, 18);
            this.LlblRecuperar.TabIndex = 0;
            this.LlblRecuperar.TabStop = true;
            this.LlblRecuperar.Text = "¿Ha olvidado su contraseña? Haga click aquí";
            // 
            // IpcbMostrarContra
            // 
            this.IpcbMostrarContra.BackColor = System.Drawing.Color.Transparent;
            this.IpcbMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbMostrarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbMostrarContra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContra.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IpcbMostrarContra.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbMostrarContra.IconSize = 27;
            this.IpcbMostrarContra.Location = new System.Drawing.Point(326, 144);
            this.IpcbMostrarContra.Name = "IpcbMostrarContra";
            this.IpcbMostrarContra.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbMostrarContra.Size = new System.Drawing.Size(27, 27);
            this.IpcbMostrarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbMostrarContra.TabIndex = 13;
            this.IpcbMostrarContra.TabStop = false;
            this.IpcbMostrarContra.Click += new System.EventHandler(this.IpcbMostrarContra_Click);
            // 
            // IpcbOcultarContra
            // 
            this.IpcbOcultarContra.BackColor = System.Drawing.Color.Transparent;
            this.IpcbOcultarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbOcultarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbOcultarContra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContra.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IpcbOcultarContra.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbOcultarContra.IconSize = 27;
            this.IpcbOcultarContra.Location = new System.Drawing.Point(326, 144);
            this.IpcbOcultarContra.Name = "IpcbOcultarContra";
            this.IpcbOcultarContra.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbOcultarContra.Size = new System.Drawing.Size(27, 27);
            this.IpcbOcultarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbOcultarContra.TabIndex = 14;
            this.IpcbOcultarContra.TabStop = false;
            this.IpcbOcultarContra.Visible = false;
            this.IpcbOcultarContra.Click += new System.EventHandler(this.IpcbOcultarContra_Click);
            // 
            // KTxtContra
            // 
            this.KTxtContra.Location = new System.Drawing.Point(15, 138);
            this.KTxtContra.Name = "KTxtContra";
            this.KTxtContra.Size = new System.Drawing.Size(355, 39);
            this.KTxtContra.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtContra.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtContra.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtContra.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContra.StateCommon.Border.Rounding = 15;
            this.KTxtContra.StateCommon.Border.Width = 2;
            this.KTxtContra.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.KTxtContra.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtContra.TabIndex = 3;
            this.KTxtContra.Text = "Contraseña";
            this.KTxtContra.Enter += new System.EventHandler(this.KTxtContra_Enter);
            this.KTxtContra.Leave += new System.EventHandler(this.KTxtContra_Leave);
            // 
            // GBtnRegistro
            // 
            this.GBtnRegistro.AnimationHoverSpeed = 0.07F;
            this.GBtnRegistro.AnimationSpeed = 0.03F;
            this.GBtnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.GBtnRegistro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.GBtnRegistro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnRegistro.BorderSize = 2;
            this.GBtnRegistro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnRegistro.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnRegistro.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnRegistro.Image = null;
            this.GBtnRegistro.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnRegistro.Location = new System.Drawing.Point(15, 282);
            this.GBtnRegistro.Name = "GBtnRegistro";
            this.GBtnRegistro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.GBtnRegistro.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnRegistro.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnRegistro.OnHoverImage = null;
            this.GBtnRegistro.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.GBtnRegistro.Radius = 18;
            this.GBtnRegistro.Size = new System.Drawing.Size(171, 39);
            this.GBtnRegistro.TabIndex = 23;
            this.GBtnRegistro.Text = "Registrarse";
            this.GBtnRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnRegistro.Click += new System.EventHandler(this.GBtnRegistro_Click);
            // 
            // PcbLogo
            // 
            this.PcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogo.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogo.Location = new System.Drawing.Point(162, 179);
            this.PcbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(375, 375);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogo.TabIndex = 14;
            this.PcbLogo.TabStop = false;
            // 
            // ToolIdiomas
            // 
            this.ToolIdiomas.BackColor = System.Drawing.Color.Transparent;
            this.ToolIdiomas.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolIdiomas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolIdiomas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolIdiomas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSpain,
            this.BtnUsa,
            this.BtnFrancia});
            this.ToolIdiomas.Location = new System.Drawing.Point(977, 152);
            this.ToolIdiomas.Name = "ToolIdiomas";
            this.ToolIdiomas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolIdiomas.Size = new System.Drawing.Size(72, 25);
            this.ToolIdiomas.TabIndex = 15;
            this.ToolIdiomas.Text = "Seleccione un idioma";
            // 
            // BtnSpain
            // 
            this.BtnSpain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSpain.Image = global::OpenLibraryEditor.Properties.Resources.espana;
            this.BtnSpain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSpain.Name = "BtnSpain";
            this.BtnSpain.Size = new System.Drawing.Size(23, 22);
            this.BtnSpain.Text = "Español";
            this.BtnSpain.Click += new System.EventHandler(this.BtnSpain_Click);
            // 
            // BtnUsa
            // 
            this.BtnUsa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUsa.Image = global::OpenLibraryEditor.Properties.Resources.estados_unidos_de_america;
            this.BtnUsa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUsa.Name = "BtnUsa";
            this.BtnUsa.Size = new System.Drawing.Size(23, 22);
            this.BtnUsa.Text = "Inglés";
            this.BtnUsa.Click += new System.EventHandler(this.BtnUsa_Click);
            // 
            // BtnFrancia
            // 
            this.BtnFrancia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFrancia.Image = global::OpenLibraryEditor.Properties.Resources.francia;
            this.BtnFrancia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFrancia.Name = "BtnFrancia";
            this.BtnFrancia.Size = new System.Drawing.Size(23, 22);
            this.BtnFrancia.Text = "Francés";
            this.BtnFrancia.Click += new System.EventHandler(this.BtnFrancia_Click);
            // 
            // TimerAparecer
            // 
            this.TimerAparecer.Interval = 15;
            this.TimerAparecer.Tick += new System.EventHandler(this.TimerAparecer_Tick);
            // 
            // MBtnCerrarLogin
            // 
            this.MBtnCerrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnCerrarLogin.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarLogin.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarLogin.IconSize = 40;
            this.MBtnCerrarLogin.Location = new System.Drawing.Point(1026, 92);
            this.MBtnCerrarLogin.Name = "MBtnCerrarLogin";
            this.MBtnCerrarLogin.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarLogin.Size = new System.Drawing.Size(32, 32);
            this.MBtnCerrarLogin.TabIndex = 16;
            this.MBtnCerrarLogin.UseVisualStyleBackColor = false;
            this.MBtnCerrarLogin.Click += new System.EventHandler(this.MBtnCerrarLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::OpenLibraryEditor.Properties.Resources.libroAzulTexturaBookMark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.MBtnCerrarLogin);
            this.Controls.Add(this.ToolIdiomas);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.PanLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.PanLogin.ResumeLayout(false);
            this.PanLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.ToolIdiomas.ResumeLayout(false);
            this.ToolIdiomas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanLogin;
      
        private System.Windows.Forms.LinkLabel LlblRecuperar;
        private FontAwesome.Sharp.IconPictureBox IpcbMostrarContra;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtContra;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtUrl;
        private FontAwesome.Sharp.IconPictureBox IpcbOcultarContra;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblSesionIniciada;
        private Controles.ToggleButton ToggleConectado;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.ToolStrip ToolIdiomas;
        private System.Windows.Forms.ToolStripButton BtnSpain;
        private System.Windows.Forms.ToolStripButton BtnUsa;
        private System.Windows.Forms.ToolStripButton BtnFrancia;
        private System.Windows.Forms.Timer TimerAparecer;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarLogin;
        private System.Windows.Forms.ToolTip TTLogin;
        private Guna.UI.WinForms.GunaButton GBtnCrearBD;
        private Guna.UI.WinForms.GunaButton GBtnEntrar;
        private Guna.UI.WinForms.GunaButton GBtnRegistro;
        private Guna.UI.WinForms.GunaButton GBtnSinConexion;
    }
}