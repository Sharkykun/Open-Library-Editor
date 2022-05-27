namespace OpenLibraryEditor.Forms
{
    partial class FrmRecuperarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperarContra));
            this.PanTituloEditUsu = new System.Windows.Forms.Panel();
            this.MBtnCerrarEditUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcbLogoEditUsu = new System.Windows.Forms.PictureBox();
            this.PanBtn = new System.Windows.Forms.Panel();
            this.GBtnRecuperar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KTxtMail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtUrl = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblPuerto = new System.Windows.Forms.Label();
            this.KNudPuerto = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.PanTituloEditUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditUsu)).BeginInit();
            this.PanBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTituloEditUsu
            // 
            this.PanTituloEditUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloEditUsu.Controls.Add(this.MBtnCerrarEditUsu);
            this.PanTituloEditUsu.Controls.Add(this.LblTitulo);
            this.PanTituloEditUsu.Controls.Add(this.PcbLogoEditUsu);
            this.PanTituloEditUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloEditUsu.Location = new System.Drawing.Point(0, 0);
            this.PanTituloEditUsu.Name = "PanTituloEditUsu";
            this.PanTituloEditUsu.Size = new System.Drawing.Size(494, 40);
            this.PanTituloEditUsu.TabIndex = 158;
            this.PanTituloEditUsu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloEditUsu_MouseDown);
            // 
            // MBtnCerrarEditUsu
            // 
            this.MBtnCerrarEditUsu.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarEditUsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarEditUsu.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarEditUsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarEditUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarEditUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarEditUsu.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarEditUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarEditUsu.IconSize = 40;
            this.MBtnCerrarEditUsu.Location = new System.Drawing.Point(462, 0);
            this.MBtnCerrarEditUsu.Name = "MBtnCerrarEditUsu";
            this.MBtnCerrarEditUsu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarEditUsu.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarEditUsu.TabIndex = 28;
            this.MBtnCerrarEditUsu.UseVisualStyleBackColor = false;
            this.MBtnCerrarEditUsu.Click += new System.EventHandler(this.MBtnCerrarEditUsu_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTitulo.Location = new System.Drawing.Point(54, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(360, 23);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Open Library Editor - Recuperar contraseña";
            this.LblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanTituloEditUsu_MouseDown);
            // 
            // PcbLogoEditUsu
            // 
            this.PcbLogoEditUsu.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoEditUsu.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoEditUsu.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoEditUsu.Name = "PcbLogoEditUsu";
            this.PcbLogoEditUsu.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoEditUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoEditUsu.TabIndex = 3;
            this.PcbLogoEditUsu.TabStop = false;
            // 
            // PanBtn
            // 
            this.PanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtn.Controls.Add(this.GBtnRecuperar);
            this.PanBtn.Controls.Add(this.GBtnCancelar);
            this.PanBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtn.Location = new System.Drawing.Point(0, 304);
            this.PanBtn.Name = "PanBtn";
            this.PanBtn.Size = new System.Drawing.Size(494, 45);
            this.PanBtn.TabIndex = 159;
            // 
            // GBtnRecuperar
            // 
            this.GBtnRecuperar.AnimationHoverSpeed = 0.07F;
            this.GBtnRecuperar.AnimationSpeed = 0.03F;
            this.GBtnRecuperar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnRecuperar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnRecuperar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnRecuperar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnRecuperar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnRecuperar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnRecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnRecuperar.Image = null;
            this.GBtnRecuperar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnRecuperar.Location = new System.Drawing.Point(355, 5);
            this.GBtnRecuperar.Name = "GBtnRecuperar";
            this.GBtnRecuperar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnRecuperar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnRecuperar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnRecuperar.OnHoverImage = null;
            this.GBtnRecuperar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnRecuperar.Radius = 15;
            this.GBtnRecuperar.Size = new System.Drawing.Size(126, 35);
            this.GBtnRecuperar.TabIndex = 0;
            this.GBtnRecuperar.Text = "Recuperar";
            this.GBtnRecuperar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnRecuperar.Click += new System.EventHandler(this.GBtnRecuperar_Click);
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
            this.GBtnCancelar.Location = new System.Drawing.Point(223, 5);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(150)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(491, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 264);
            this.panel8.TabIndex = 163;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 264);
            this.panel1.TabIndex = 162;
            // 
            // KTxtMail
            // 
            this.KTxtMail.Location = new System.Drawing.Point(21, 241);
            this.KTxtMail.Name = "KTxtMail";
            this.KTxtMail.Size = new System.Drawing.Size(451, 39);
            this.KTxtMail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtMail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtMail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtMail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtMail.StateCommon.Border.Rounding = 15;
            this.KTxtMail.StateCommon.Border.Width = 2;
            this.KTxtMail.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtMail.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtMail.TabIndex = 30;
            // 
            // KTxtUrl
            // 
            this.KTxtUrl.Location = new System.Drawing.Point(21, 85);
            this.KTxtUrl.Name = "KTxtUrl";
            this.KTxtUrl.Size = new System.Drawing.Size(451, 39);
            this.KTxtUrl.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtUrl.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtUrl.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtUrl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtUrl.StateCommon.Border.Rounding = 15;
            this.KTxtUrl.StateCommon.Border.Width = 2;
            this.KTxtUrl.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtUrl.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtUrl.TabIndex = 29;
            // 
            // LblUrl
            // 
            this.LblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUrl.AutoSize = true;
            this.LblUrl.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblUrl.Location = new System.Drawing.Point(21, 58);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(154, 23);
            this.LblUrl.TabIndex = 24;
            this.LblUrl.Text = "Url base de datos:";
            // 
            // LblMail
            // 
            this.LblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMail.AutoSize = true;
            this.LblMail.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblMail.Location = new System.Drawing.Point(21, 212);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(59, 23);
            this.LblMail.TabIndex = 23;
            this.LblMail.Text = "Email:";
            // 
            // LblPuerto
            // 
            this.LblPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPuerto.AutoSize = true;
            this.LblPuerto.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblPuerto.Location = new System.Drawing.Point(22, 137);
            this.LblPuerto.Name = "LblPuerto";
            this.LblPuerto.Size = new System.Drawing.Size(67, 23);
            this.LblPuerto.TabIndex = 164;
            this.LblPuerto.Text = "Puerto:";
            // 
            // KNudPuerto
            // 
            this.KNudPuerto.Location = new System.Drawing.Point(21, 163);
            this.KNudPuerto.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.KNudPuerto.Name = "KNudPuerto";
            this.KNudPuerto.Size = new System.Drawing.Size(160, 34);
            this.KNudPuerto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KNudPuerto.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KNudPuerto.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KNudPuerto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KNudPuerto.StateCommon.Border.Rounding = 10;
            this.KNudPuerto.StateCommon.Border.Width = 2;
            this.KNudPuerto.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KNudPuerto.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KNudPuerto.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1);
            this.KNudPuerto.TabIndex = 165;
            this.KNudPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KNudPuerto.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // FrmRecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.KNudPuerto);
            this.Controls.Add(this.LblPuerto);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.KTxtMail);
            this.Controls.Add(this.KTxtUrl);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanBtn);
            this.Controls.Add(this.PanTituloEditUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecuperarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRecuperarContra";
            this.Load += new System.EventHandler(this.FrmRecuperarContra_Load);
            this.PanTituloEditUsu.ResumeLayout(false);
            this.PanTituloEditUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditUsu)).EndInit();
            this.PanBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloEditUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarEditUsu;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PcbLogoEditUsu;
        private System.Windows.Forms.Panel PanBtn;
        private Guna.UI.WinForms.GunaButton GBtnRecuperar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtMail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblPuerto;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown KNudPuerto;
    }
}