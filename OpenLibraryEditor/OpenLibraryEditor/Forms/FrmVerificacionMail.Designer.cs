namespace OpenLibraryEditor.Forms
{
    partial class FrmVerificacionMail
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
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.MBtnCerrarRegistro = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloFrm = new System.Windows.Forms.Label();
            this.PcbLogoRegistro = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMirarSpam = new System.Windows.Forms.Label();
            this.KMaskTxt = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.Lblcodigo = new System.Windows.Forms.Label();
            this.GBtnVerificar = new Guna.UI.WinForms.GunaButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TTVerificar = new System.Windows.Forms.ToolTip(this.components);
            this.PanTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoRegistro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTitulo
            // 
            this.PanTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTitulo.Controls.Add(this.MBtnCerrarRegistro);
            this.PanTitulo.Controls.Add(this.LblTituloFrm);
            this.PanTitulo.Controls.Add(this.PcbLogoRegistro);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(460, 40);
            this.PanTitulo.TabIndex = 1;
            this.PanTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // MBtnCerrarRegistro
            // 
            this.MBtnCerrarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarRegistro.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarRegistro.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarRegistro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarRegistro.IconSize = 40;
            this.MBtnCerrarRegistro.Location = new System.Drawing.Point(428, 0);
            this.MBtnCerrarRegistro.Name = "MBtnCerrarRegistro";
            this.MBtnCerrarRegistro.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarRegistro.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarRegistro.TabIndex = 0;
            this.MBtnCerrarRegistro.UseVisualStyleBackColor = false;
            this.MBtnCerrarRegistro.Click += new System.EventHandler(this.MBtnCerrarRegistro_Click);
            // 
            // LblTituloFrm
            // 
            this.LblTituloFrm.AutoSize = true;
            this.LblTituloFrm.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTituloFrm.Location = new System.Drawing.Point(54, 9);
            this.LblTituloFrm.Name = "LblTituloFrm";
            this.LblTituloFrm.Size = new System.Drawing.Size(316, 23);
            this.LblTituloFrm.TabIndex = 4;
            this.LblTituloFrm.Text = "Open Library Editor - Verifica tu email\r\n";
            this.LblTituloFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
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
            this.PcbLogoRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.LblMirarSpam);
            this.panel1.Controls.Add(this.KMaskTxt);
            this.panel1.Controls.Add(this.Lblcodigo);
            this.panel1.Controls.Add(this.GBtnVerificar);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 197);
            this.panel1.TabIndex = 2;
            // 
            // LblMirarSpam
            // 
            this.LblMirarSpam.Font = new System.Drawing.Font("Merienda", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMirarSpam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblMirarSpam.Location = new System.Drawing.Point(13, 108);
            this.LblMirarSpam.Name = "LblMirarSpam";
            this.LblMirarSpam.Size = new System.Drawing.Size(435, 23);
            this.LblMirarSpam.TabIndex = 37;
            this.LblMirarSpam.Text = "Si no ha recibido el email revise su correo no deseado";
            this.LblMirarSpam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KMaskTxt
            // 
            this.KMaskTxt.Location = new System.Drawing.Point(164, 71);
            this.KMaskTxt.Mask = "999999";
            this.KMaskTxt.Name = "KMaskTxt";
            this.KMaskTxt.Size = new System.Drawing.Size(128, 31);
            this.KMaskTxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KMaskTxt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KMaskTxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KMaskTxt.StateCommon.Border.Width = 2;
            this.KMaskTxt.StateCommon.Content.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMaskTxt.TabIndex = 0;
            this.KMaskTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lblcodigo
            // 
            this.Lblcodigo.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.Lblcodigo.Location = new System.Drawing.Point(9, 27);
            this.Lblcodigo.Name = "Lblcodigo";
            this.Lblcodigo.Size = new System.Drawing.Size(439, 23);
            this.Lblcodigo.TabIndex = 35;
            this.Lblcodigo.Text = "Introduzca el código que le hemos enviado";
            this.Lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBtnVerificar
            // 
            this.GBtnVerificar.AnimationHoverSpeed = 0.07F;
            this.GBtnVerificar.AnimationSpeed = 0.03F;
            this.GBtnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnVerificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnVerificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnVerificar.BorderSize = 2;
            this.GBtnVerificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnVerificar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnVerificar.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnVerificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnVerificar.Image = null;
            this.GBtnVerificar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnVerificar.Location = new System.Drawing.Point(49, 134);
            this.GBtnVerificar.Name = "GBtnVerificar";
            this.GBtnVerificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnVerificar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnVerificar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnVerificar.OnHoverImage = null;
            this.GBtnVerificar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnVerificar.Radius = 18;
            this.GBtnVerificar.Size = new System.Drawing.Size(355, 39);
            this.GBtnVerificar.TabIndex = 1;
            this.GBtnVerificar.Text = "Verificar";
            this.GBtnVerificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnVerificar.Click += new System.EventHandler(this.GBtnVerificar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(150)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(457, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 194);
            this.panel8.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(150)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 194);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 3);
            this.panel7.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 197);
            this.panel2.TabIndex = 31;
            // 
            // FrmVerificacionMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 237);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanTitulo);
            this.Name = "FrmVerificacionMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerificacionMail";
            this.Load += new System.EventHandler(this.FrmVerificacionMail_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoRegistro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTitulo;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarRegistro;
        private System.Windows.Forms.Label LblTituloFrm;
        private System.Windows.Forms.PictureBox PcbLogoRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox KMaskTxt;
        private System.Windows.Forms.Label Lblcodigo;
        private Guna.UI.WinForms.GunaButton GBtnVerificar;
        private System.Windows.Forms.ToolTip TTVerificar;
        private System.Windows.Forms.Label LblMirarSpam;
    }
}