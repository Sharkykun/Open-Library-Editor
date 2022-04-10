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
            this.BtnInvitado = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnEntrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnRegistrarse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LblError = new System.Windows.Forms.Label();
            this.LblSesionIniciada = new System.Windows.Forms.Label();
            this.ToggleConectado = new OpenLibraryEditor.Controles.ToggleButton();
            this.KTxtNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtUrl = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LlblRecuperar = new System.Windows.Forms.LinkLabel();
            this.IpcbMostrarContra = new FontAwesome.Sharp.IconPictureBox();
            this.IpcbOcultarContra = new FontAwesome.Sharp.IconPictureBox();
            this.KTxtContra = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.ToolIdiomas = new System.Windows.Forms.ToolStrip();
            this.BtnSpain = new System.Windows.Forms.ToolStripButton();
            this.BtnUsa = new System.Windows.Forms.ToolStripButton();
            this.BtnFrancia = new System.Windows.Forms.ToolStripButton();
            this.TimerAparecer = new System.Windows.Forms.Timer(this.components);
            this.MBtnCerrarLogin = new FontAwesome.Sharp.Material.MaterialButton();
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
            this.PanLogin.Controls.Add(this.BtnInvitado);
            this.PanLogin.Controls.Add(this.BtnEntrar);
            this.PanLogin.Controls.Add(this.BtnRegistrarse);
            this.PanLogin.Controls.Add(this.LblError);
            this.PanLogin.Controls.Add(this.LblSesionIniciada);
            this.PanLogin.Controls.Add(this.ToggleConectado);
            this.PanLogin.Controls.Add(this.KTxtNombre);
            this.PanLogin.Controls.Add(this.KTxtUrl);
            this.PanLogin.Controls.Add(this.LlblRecuperar);
            this.PanLogin.Controls.Add(this.IpcbMostrarContra);
            this.PanLogin.Controls.Add(this.IpcbOcultarContra);
            this.PanLogin.Controls.Add(this.KTxtContra);
            this.PanLogin.Location = new System.Drawing.Point(661, 179);
            this.PanLogin.Margin = new System.Windows.Forms.Padding(2);
            this.PanLogin.Name = "PanLogin";
            this.PanLogin.Size = new System.Drawing.Size(385, 350);
            this.PanLogin.TabIndex = 11;
            // 
            // BtnInvitado
            // 
            this.BtnInvitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInvitado.Location = new System.Drawing.Point(14, 297);
            this.BtnInvitado.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInvitado.Name = "BtnInvitado";
            this.BtnInvitado.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnInvitado.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnInvitado.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnInvitado.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnInvitado.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnInvitado.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnInvitado.OverrideDefault.Border.Rounding = 30;
            this.BtnInvitado.OverrideDefault.Border.Width = 2;
            this.BtnInvitado.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnInvitado.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnInvitado.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnInvitado.Size = new System.Drawing.Size(354, 44);
            this.BtnInvitado.StateCommon.Back.Color1 = System.Drawing.Color.Navy;
            this.BtnInvitado.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.BtnInvitado.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnInvitado.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.BtnInvitado.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.BtnInvitado.StateCommon.Border.ColorAngle = 0F;
            this.BtnInvitado.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnInvitado.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnInvitado.StateCommon.Border.Rounding = 30;
            this.BtnInvitado.StateCommon.Border.Width = 2;
            this.BtnInvitado.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.BtnInvitado.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnInvitado.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnInvitado.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.BtnInvitado.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnInvitado.StateNormal.Back.Color1 = System.Drawing.Color.Navy;
            this.BtnInvitado.StateNormal.Back.Color2 = System.Drawing.Color.Navy;
            this.BtnInvitado.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnInvitado.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnInvitado.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnInvitado.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnInvitado.StateNormal.Border.Rounding = 30;
            this.BtnInvitado.StateNormal.Border.Width = 2;
            this.BtnInvitado.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnInvitado.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnInvitado.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnInvitado.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.BtnInvitado.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.BtnInvitado.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.BtnInvitado.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.BtnInvitado.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnInvitado.StatePressed.Border.Rounding = 30;
            this.BtnInvitado.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.BtnInvitado.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.BtnInvitado.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.BtnInvitado.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.BtnInvitado.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnInvitado.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnInvitado.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.BtnInvitado.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.BtnInvitado.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnInvitado.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnInvitado.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnInvitado.TabIndex = 7;
            this.BtnInvitado.Values.Text = "Acceso invitado";
            this.BtnInvitado.Click += new System.EventHandler(this.BtnInvitado_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.Location = new System.Drawing.Point(196, 248);
            this.BtnEntrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnEntrar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnEntrar.OverrideDefault.Border.Rounding = 30;
            this.BtnEntrar.OverrideDefault.Border.Width = 2;
            this.BtnEntrar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnEntrar.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnEntrar.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Size = new System.Drawing.Size(172, 44);
            this.BtnEntrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnEntrar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateCommon.Border.ColorAngle = 0F;
            this.BtnEntrar.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnEntrar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnEntrar.StateCommon.Border.Rounding = 30;
            this.BtnEntrar.StateCommon.Border.Width = 2;
            this.BtnEntrar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.BtnEntrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnEntrar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnEntrar.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.BtnEntrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnEntrar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnEntrar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnEntrar.StateNormal.Border.Rounding = 30;
            this.BtnEntrar.StateNormal.Border.Width = 2;
            this.BtnEntrar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnEntrar.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnEntrar.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.BtnEntrar.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.BtnEntrar.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.BtnEntrar.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.BtnEntrar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnEntrar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.BtnEntrar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.BtnEntrar.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.BtnEntrar.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.BtnEntrar.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnEntrar.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnEntrar.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.BtnEntrar.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.BtnEntrar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnEntrar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnEntrar.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnEntrar.TabIndex = 6;
            this.BtnEntrar.Values.Text = "Entrar";
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarse.Location = new System.Drawing.Point(14, 248);
            this.BtnRegistrarse.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrarse.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrarse.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarse.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarse.OverrideDefault.Border.Rounding = 30;
            this.BtnRegistrarse.OverrideDefault.Border.Width = 2;
            this.BtnRegistrarse.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarse.Size = new System.Drawing.Size(172, 44);
            this.BtnRegistrarse.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrarse.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrarse.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarse.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateCommon.Border.ColorAngle = 0F;
            this.BtnRegistrarse.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarse.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarse.StateCommon.Border.Rounding = 30;
            this.BtnRegistrarse.StateCommon.Border.Width = 2;
            this.BtnRegistrarse.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.BtnRegistrarse.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.BtnRegistrarse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarse.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrarse.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRegistrarse.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarse.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarse.StateNormal.Border.Rounding = 30;
            this.BtnRegistrarse.StateNormal.Border.Width = 2;
            this.BtnRegistrarse.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarse.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarse.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.BtnRegistrarse.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.BtnRegistrarse.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarse.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarse.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarse.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarse.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarse.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnRegistrarse.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnRegistrarse.TabIndex = 5;
            this.BtnRegistrarse.Values.Text = "Registrarse";
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Transparent;
            this.LblError.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Black;
            this.LblError.Image = global::OpenLibraryEditor.Properties.Resources.error1;
            this.LblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblError.Location = new System.Drawing.Point(14, 208);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(32, 18);
            this.LblError.TabIndex = 20;
            this.LblError.Text = "      ";
            this.LblError.Visible = false;
            // 
            // LblSesionIniciada
            // 
            this.LblSesionIniciada.AutoSize = true;
            this.LblSesionIniciada.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSesionIniciada.ForeColor = System.Drawing.Color.Navy;
            this.LblSesionIniciada.Location = new System.Drawing.Point(50, 158);
            this.LblSesionIniciada.Name = "LblSesionIniciada";
            this.LblSesionIniciada.Size = new System.Drawing.Size(199, 22);
            this.LblSesionIniciada.TabIndex = 8;
            this.LblSesionIniciada.Text = "Mantener sesión iniciada";
            // 
            // ToggleConectado
            // 
            this.ToggleConectado.AutoSize = true;
            this.ToggleConectado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleConectado.Location = new System.Drawing.Point(261, 158);
            this.ToggleConectado.MinimumSize = new System.Drawing.Size(45, 22);
            this.ToggleConectado.Name = "ToggleConectado";
            this.ToggleConectado.OffBackColor = System.Drawing.Color.DarkGray;
            this.ToggleConectado.OffToggleColor = System.Drawing.Color.Black;
            this.ToggleConectado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.ToggleConectado.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.ToggleConectado.Size = new System.Drawing.Size(45, 22);
            this.ToggleConectado.TabIndex = 4;
            this.ToggleConectado.UseVisualStyleBackColor = true;
            // 
            // KTxtNombre
            // 
            this.KTxtNombre.Location = new System.Drawing.Point(14, 57);
            this.KTxtNombre.Name = "KTxtNombre";
            this.KTxtNombre.Size = new System.Drawing.Size(354, 41);
            this.KTxtNombre.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtNombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombre.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtNombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombre.StateCommon.Border.Rounding = 15;
            this.KTxtNombre.StateCommon.Border.Width = 3;
            this.KTxtNombre.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.KTxtNombre.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombre.TabIndex = 2;
            this.KTxtNombre.Text = "Nombre de Usuario o Email";
            this.KTxtNombre.Enter += new System.EventHandler(this.KTxtNombre_Enter);
            this.KTxtNombre.Leave += new System.EventHandler(this.KTxtNombre_Leave);
            // 
            // KTxtUrl
            // 
            this.KTxtUrl.Location = new System.Drawing.Point(14, 6);
            this.KTxtUrl.Name = "KTxtUrl";
            this.KTxtUrl.Size = new System.Drawing.Size(354, 41);
            this.KTxtUrl.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtUrl.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtUrl.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtUrl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtUrl.StateCommon.Border.Rounding = 15;
            this.KTxtUrl.StateCommon.Border.Width = 3;
            this.KTxtUrl.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.KTxtUrl.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.LlblRecuperar.Location = new System.Drawing.Point(42, 182);
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
            this.IpcbMostrarContra.IconSize = 30;
            this.IpcbMostrarContra.Location = new System.Drawing.Point(323, 113);
            this.IpcbMostrarContra.Name = "IpcbMostrarContra";
            this.IpcbMostrarContra.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbMostrarContra.Size = new System.Drawing.Size(30, 30);
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
            this.IpcbOcultarContra.IconSize = 30;
            this.IpcbOcultarContra.Location = new System.Drawing.Point(323, 113);
            this.IpcbOcultarContra.Name = "IpcbOcultarContra";
            this.IpcbOcultarContra.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbOcultarContra.Size = new System.Drawing.Size(30, 30);
            this.IpcbOcultarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbOcultarContra.TabIndex = 14;
            this.IpcbOcultarContra.TabStop = false;
            this.IpcbOcultarContra.Visible = false;
            this.IpcbOcultarContra.Click += new System.EventHandler(this.IpcbOcultarContra_Click);
            // 
            // KTxtContra
            // 
            this.KTxtContra.Location = new System.Drawing.Point(14, 108);
            this.KTxtContra.Name = "KTxtContra";
            this.KTxtContra.Size = new System.Drawing.Size(354, 41);
            this.KTxtContra.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtContra.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtContra.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtContra.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContra.StateCommon.Border.Rounding = 15;
            this.KTxtContra.StateCommon.Border.Width = 3;
            this.KTxtContra.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.KTxtContra.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtContra.TabIndex = 3;
            this.KTxtContra.Text = "Contraseña";
            this.KTxtContra.Enter += new System.EventHandler(this.KTxtContra_Enter);
            this.KTxtContra.Leave += new System.EventHandler(this.KTxtContra_Leave);
            // 
            // PcbLogo
            // 
            this.PcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogo.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogo.Location = new System.Drawing.Point(182, 179);
            this.PcbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(350, 350);
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnInvitado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnEntrar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRegistrarse;
        private System.Windows.Forms.ToolStrip ToolIdiomas;
        private System.Windows.Forms.ToolStripButton BtnSpain;
        private System.Windows.Forms.ToolStripButton BtnUsa;
        private System.Windows.Forms.ToolStripButton BtnFrancia;
        private System.Windows.Forms.Timer TimerAparecer;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarLogin;
    }
}