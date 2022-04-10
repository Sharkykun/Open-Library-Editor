namespace OpenLibraryEditor.Forms
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.LblTituloFrm = new System.Windows.Forms.Label();
            this.PcbLogoRegistro = new System.Windows.Forms.PictureBox();
            this.PanTexto = new System.Windows.Forms.Panel();
            this.TxtUrlReg = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblUrlReg = new System.Windows.Forms.Label();
            this.BtnRegistrarme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TxtMailReg = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtNombreReg = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblContra1Reg = new System.Windows.Forms.Label();
            this.LblContraReg = new System.Windows.Forms.Label();
            this.LblMailReg = new System.Windows.Forms.Label();
            this.LblNombreReg = new System.Windows.Forms.Label();
            this.IpcbMostrarContraReg = new FontAwesome.Sharp.IconPictureBox();
            this.IpcbOcultarContraReg = new FontAwesome.Sharp.IconPictureBox();
            this.IpcbMostrarContra1Reg = new FontAwesome.Sharp.IconPictureBox();
            this.IpcbOcultarContra1Reg = new FontAwesome.Sharp.IconPictureBox();
            this.KTxtContra1Reg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtContraReg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnCerrarRegistro = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoRegistro)).BeginInit();
            this.PanTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContraReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContraReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContra1Reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContra1Reg)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTitulo
            // 
            this.PanTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTitulo.Controls.Add(this.MBtnCerrarRegistro);
            this.PanTitulo.Controls.Add(this.LblTituloFrm);
            this.PanTitulo.Controls.Add(this.PcbLogoRegistro);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(600, 40);
            this.PanTitulo.TabIndex = 0;
            this.PanTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // LblTituloFrm
            // 
            this.LblTituloFrm.AutoSize = true;
            this.LblTituloFrm.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFrm.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloFrm.Location = new System.Drawing.Point(54, 9);
            this.LblTituloFrm.Name = "LblTituloFrm";
            this.LblTituloFrm.Size = new System.Drawing.Size(250, 23);
            this.LblTituloFrm.TabIndex = 4;
            this.LblTituloFrm.Text = "Open Library Editor - Registro\r\n";
            // 
            // PcbLogoRegistro
            // 
            this.PcbLogoRegistro.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoRegistro.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoRegistro.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoRegistro.Name = "PcbLogoRegistro";
            this.PcbLogoRegistro.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoRegistro.TabIndex = 3;
            this.PcbLogoRegistro.TabStop = false;
            // 
            // PanTexto
            // 
            this.PanTexto.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTexto.Controls.Add(this.TxtUrlReg);
            this.PanTexto.Controls.Add(this.panel5);
            this.PanTexto.Controls.Add(this.LblUrlReg);
            this.PanTexto.Controls.Add(this.BtnRegistrarme);
            this.PanTexto.Controls.Add(this.TxtMailReg);
            this.PanTexto.Controls.Add(this.panel4);
            this.PanTexto.Controls.Add(this.panel3);
            this.PanTexto.Controls.Add(this.panel2);
            this.PanTexto.Controls.Add(this.TxtNombreReg);
            this.PanTexto.Controls.Add(this.panel6);
            this.PanTexto.Controls.Add(this.LblContra1Reg);
            this.PanTexto.Controls.Add(this.LblContraReg);
            this.PanTexto.Controls.Add(this.LblMailReg);
            this.PanTexto.Controls.Add(this.LblNombreReg);
            this.PanTexto.Controls.Add(this.IpcbMostrarContraReg);
            this.PanTexto.Controls.Add(this.IpcbOcultarContraReg);
            this.PanTexto.Controls.Add(this.IpcbMostrarContra1Reg);
            this.PanTexto.Controls.Add(this.IpcbOcultarContra1Reg);
            this.PanTexto.Controls.Add(this.KTxtContra1Reg);
            this.PanTexto.Controls.Add(this.KTxtContraReg);
            this.PanTexto.Location = new System.Drawing.Point(3, 42);
            this.PanTexto.Name = "PanTexto";
            this.PanTexto.Size = new System.Drawing.Size(594, 305);
            this.PanTexto.TabIndex = 2;
            // 
            // TxtUrlReg
            // 
            this.TxtUrlReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUrlReg.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtUrlReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUrlReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrlReg.Location = new System.Drawing.Point(230, 22);
            this.TxtUrlReg.Name = "TxtUrlReg";
            this.TxtUrlReg.Size = new System.Drawing.Size(313, 24);
            this.TxtUrlReg.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(58, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(486, 2);
            this.panel5.TabIndex = 23;
            // 
            // LblUrlReg
            // 
            this.LblUrlReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUrlReg.AutoSize = true;
            this.LblUrlReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrlReg.Location = new System.Drawing.Point(54, 21);
            this.LblUrlReg.Name = "LblUrlReg";
            this.LblUrlReg.Size = new System.Drawing.Size(39, 23);
            this.LblUrlReg.TabIndex = 22;
            this.LblUrlReg.Text = "Url:";
            // 
            // BtnRegistrarme
            // 
            this.BtnRegistrarme.Location = new System.Drawing.Point(125, 230);
            this.BtnRegistrarme.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRegistrarme.Name = "BtnRegistrarme";
            this.BtnRegistrarme.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarme.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarme.OverrideDefault.Border.Rounding = 30;
            this.BtnRegistrarme.OverrideDefault.Border.Width = 2;
            this.BtnRegistrarme.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnRegistrarme.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnRegistrarme.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarme.Size = new System.Drawing.Size(354, 46);
            this.BtnRegistrarme.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarme.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateCommon.Border.ColorAngle = 0F;
            this.BtnRegistrarme.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarme.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarme.StateCommon.Border.Rounding = 30;
            this.BtnRegistrarme.StateCommon.Border.Width = 2;
            this.BtnRegistrarme.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-5);
            this.BtnRegistrarme.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnRegistrarme.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnRegistrarme.StateCommon.Content.ShortText.ColorAngle = 36F;
            this.BtnRegistrarme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarme.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarme.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.BtnRegistrarme.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarme.StateNormal.Border.Rounding = 30;
            this.BtnRegistrarme.StateNormal.Border.Width = 2;
            this.BtnRegistrarme.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnRegistrarme.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnRegistrarme.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarme.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.BtnRegistrarme.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.BtnRegistrarme.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarme.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StateTracking.Back.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.BtnRegistrarme.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BtnRegistrarme.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.BtnRegistrarme.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnRegistrarme.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BtnRegistrarme.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BtnRegistrarme.TabIndex = 5;
            this.BtnRegistrarme.Values.Text = "Registrarme";
            this.BtnRegistrarme.Click += new System.EventHandler(this.BtnRegistrarme_Click);
            // 
            // TxtMailReg
            // 
            this.TxtMailReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMailReg.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtMailReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMailReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMailReg.Location = new System.Drawing.Point(230, 103);
            this.TxtMailReg.Name = "TxtMailReg";
            this.TxtMailReg.Size = new System.Drawing.Size(313, 24);
            this.TxtMailReg.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(58, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 2);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(58, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 2);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(58, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 2);
            this.panel2.TabIndex = 12;
            // 
            // TxtNombreReg
            // 
            this.TxtNombreReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreReg.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNombreReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreReg.Location = new System.Drawing.Point(230, 61);
            this.TxtNombreReg.Name = "TxtNombreReg";
            this.TxtNombreReg.Size = new System.Drawing.Size(313, 24);
            this.TxtNombreReg.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(58, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(486, 2);
            this.panel6.TabIndex = 11;
            // 
            // LblContra1Reg
            // 
            this.LblContra1Reg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContra1Reg.AutoSize = true;
            this.LblContra1Reg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContra1Reg.Location = new System.Drawing.Point(54, 179);
            this.LblContra1Reg.Name = "LblContra1Reg";
            this.LblContra1Reg.Size = new System.Drawing.Size(166, 23);
            this.LblContra1Reg.TabIndex = 10;
            this.LblContra1Reg.Text = "Repetir contraseña:";
            // 
            // LblContraReg
            // 
            this.LblContraReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContraReg.AutoSize = true;
            this.LblContraReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraReg.Location = new System.Drawing.Point(54, 141);
            this.LblContraReg.Name = "LblContraReg";
            this.LblContraReg.Size = new System.Drawing.Size(106, 23);
            this.LblContraReg.TabIndex = 9;
            this.LblContraReg.Text = "Contraseña:";
            // 
            // LblMailReg
            // 
            this.LblMailReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMailReg.AutoSize = true;
            this.LblMailReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMailReg.Location = new System.Drawing.Point(54, 101);
            this.LblMailReg.Name = "LblMailReg";
            this.LblMailReg.Size = new System.Drawing.Size(59, 23);
            this.LblMailReg.TabIndex = 8;
            this.LblMailReg.Text = "Email:";
            // 
            // LblNombreReg
            // 
            this.LblNombreReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombreReg.AutoSize = true;
            this.LblNombreReg.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreReg.Location = new System.Drawing.Point(54, 60);
            this.LblNombreReg.Name = "LblNombreReg";
            this.LblNombreReg.Size = new System.Drawing.Size(173, 23);
            this.LblNombreReg.TabIndex = 7;
            this.LblNombreReg.Text = "Nombre de usuari@:";
            // 
            // IpcbMostrarContraReg
            // 
            this.IpcbMostrarContraReg.BackColor = System.Drawing.Color.Transparent;
            this.IpcbMostrarContraReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbMostrarContraReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbMostrarContraReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContraReg.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IpcbMostrarContraReg.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContraReg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbMostrarContraReg.IconSize = 30;
            this.IpcbMostrarContraReg.Location = new System.Drawing.Point(513, 136);
            this.IpcbMostrarContraReg.Name = "IpcbMostrarContraReg";
            this.IpcbMostrarContraReg.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbMostrarContraReg.Size = new System.Drawing.Size(30, 30);
            this.IpcbMostrarContraReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbMostrarContraReg.TabIndex = 24;
            this.IpcbMostrarContraReg.TabStop = false;
            this.IpcbMostrarContraReg.Click += new System.EventHandler(this.IpcbMostrarContraReg_Click);
            // 
            // IpcbOcultarContraReg
            // 
            this.IpcbOcultarContraReg.BackColor = System.Drawing.Color.Transparent;
            this.IpcbOcultarContraReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbOcultarContraReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbOcultarContraReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContraReg.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IpcbOcultarContraReg.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContraReg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbOcultarContraReg.IconSize = 30;
            this.IpcbOcultarContraReg.Location = new System.Drawing.Point(513, 136);
            this.IpcbOcultarContraReg.Name = "IpcbOcultarContraReg";
            this.IpcbOcultarContraReg.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbOcultarContraReg.Size = new System.Drawing.Size(30, 30);
            this.IpcbOcultarContraReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbOcultarContraReg.TabIndex = 25;
            this.IpcbOcultarContraReg.TabStop = false;
            this.IpcbOcultarContraReg.Visible = false;
            this.IpcbOcultarContraReg.Click += new System.EventHandler(this.IpcbOcultarContraReg_Click);
            // 
            // IpcbMostrarContra1Reg
            // 
            this.IpcbMostrarContra1Reg.BackColor = System.Drawing.Color.Transparent;
            this.IpcbMostrarContra1Reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbMostrarContra1Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbMostrarContra1Reg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContra1Reg.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.IpcbMostrarContra1Reg.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbMostrarContra1Reg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbMostrarContra1Reg.IconSize = 30;
            this.IpcbMostrarContra1Reg.Location = new System.Drawing.Point(513, 176);
            this.IpcbMostrarContra1Reg.Name = "IpcbMostrarContra1Reg";
            this.IpcbMostrarContra1Reg.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbMostrarContra1Reg.Size = new System.Drawing.Size(30, 30);
            this.IpcbMostrarContra1Reg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbMostrarContra1Reg.TabIndex = 27;
            this.IpcbMostrarContra1Reg.TabStop = false;
            this.IpcbMostrarContra1Reg.Click += new System.EventHandler(this.IpcbMostrarContra1Reg_Click);
            // 
            // IpcbOcultarContra1Reg
            // 
            this.IpcbOcultarContra1Reg.BackColor = System.Drawing.Color.Transparent;
            this.IpcbOcultarContra1Reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IpcbOcultarContra1Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IpcbOcultarContra1Reg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContra1Reg.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IpcbOcultarContra1Reg.IconColor = System.Drawing.SystemColors.ControlText;
            this.IpcbOcultarContra1Reg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IpcbOcultarContra1Reg.IconSize = 30;
            this.IpcbOcultarContra1Reg.Location = new System.Drawing.Point(513, 176);
            this.IpcbOcultarContra1Reg.Name = "IpcbOcultarContra1Reg";
            this.IpcbOcultarContra1Reg.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.IpcbOcultarContra1Reg.Size = new System.Drawing.Size(30, 30);
            this.IpcbOcultarContra1Reg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IpcbOcultarContra1Reg.TabIndex = 26;
            this.IpcbOcultarContra1Reg.TabStop = false;
            this.IpcbOcultarContra1Reg.Visible = false;
            this.IpcbOcultarContra1Reg.Click += new System.EventHandler(this.IpcbOcultarContra1Reg_Click);
            // 
            // KTxtContra1Reg
            // 
            this.KTxtContra1Reg.Location = new System.Drawing.Point(230, 175);
            this.KTxtContra1Reg.Name = "KTxtContra1Reg";
            this.KTxtContra1Reg.PasswordChar = '●';
            this.KTxtContra1Reg.Size = new System.Drawing.Size(313, 31);
            this.KTxtContra1Reg.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtContra1Reg.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.KTxtContra1Reg.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.KTxtContra1Reg.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContra1Reg.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtContra1Reg.StateNormal.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtContra1Reg.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.KTxtContra1Reg.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.KTxtContra1Reg.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContra1Reg.TabIndex = 4;
            this.KTxtContra1Reg.UseSystemPasswordChar = true;
            // 
            // KTxtContraReg
            // 
            this.KTxtContraReg.Location = new System.Drawing.Point(230, 135);
            this.KTxtContraReg.Name = "KTxtContraReg";
            this.KTxtContraReg.PasswordChar = '●';
            this.KTxtContraReg.Size = new System.Drawing.Size(313, 31);
            this.KTxtContraReg.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtContraReg.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.KTxtContraReg.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.KTxtContraReg.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContraReg.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtContraReg.StateNormal.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtContraReg.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.KTxtContraReg.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.KTxtContraReg.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContraReg.TabIndex = 3;
            this.KTxtContraReg.UseSystemPasswordChar = true;
            // 
            // MBtnCerrarRegistro
            // 
            this.MBtnCerrarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarRegistro.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarRegistro.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarRegistro.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarRegistro.IconSize = 40;
            this.MBtnCerrarRegistro.Location = new System.Drawing.Point(564, 4);
            this.MBtnCerrarRegistro.Name = "MBtnCerrarRegistro";
            this.MBtnCerrarRegistro.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarRegistro.Size = new System.Drawing.Size(32, 32);
            this.MBtnCerrarRegistro.TabIndex = 28;
            this.MBtnCerrarRegistro.UseVisualStyleBackColor = false;
            this.MBtnCerrarRegistro.Click += new System.EventHandler(this.MBtnCerrarRegistro_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.PanTitulo);
            this.Controls.Add(this.PanTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoRegistro)).EndInit();
            this.PanTexto.ResumeLayout(false);
            this.PanTexto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContraReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContraReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbMostrarContra1Reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpcbOcultarContra1Reg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTitulo;
        private System.Windows.Forms.PictureBox PcbLogoRegistro;
        private System.Windows.Forms.Label LblTituloFrm;
        private System.Windows.Forms.Panel PanTexto;
        private System.Windows.Forms.TextBox TxtUrlReg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblUrlReg;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRegistrarme;
        private System.Windows.Forms.TextBox TxtMailReg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtNombreReg;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LblContra1Reg;
        private System.Windows.Forms.Label LblContraReg;
        private System.Windows.Forms.Label LblMailReg;
        private System.Windows.Forms.Label LblNombreReg;
        private FontAwesome.Sharp.IconPictureBox IpcbMostrarContraReg;
        private FontAwesome.Sharp.IconPictureBox IpcbOcultarContra1Reg;
        private FontAwesome.Sharp.IconPictureBox IpcbOcultarContraReg;
        private FontAwesome.Sharp.IconPictureBox IpcbMostrarContra1Reg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtContraReg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtContra1Reg;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarRegistro;
    }
}