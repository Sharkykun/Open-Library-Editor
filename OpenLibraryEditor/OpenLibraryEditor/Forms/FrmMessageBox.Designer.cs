namespace OpenLibraryEditor.Forms
{
    partial class FrmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.PcbLogoMain = new System.Windows.Forms.PictureBox();
            this.MBtnCerrarDialog = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblCaption = new System.Windows.Forms.Label();
            this.PanBotones = new System.Windows.Forms.Panel();
            this.button3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanTexto = new System.Windows.Forms.Panel();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.PcbIcono = new System.Windows.Forms.PictureBox();
            this.PanTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoMain)).BeginInit();
            this.PanBotones.SuspendLayout();
            this.PanTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTitulo
            // 
            this.PanTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTitulo.Controls.Add(this.PcbLogoMain);
            this.PanTitulo.Controls.Add(this.MBtnCerrarDialog);
            this.PanTitulo.Controls.Add(this.LblCaption);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(366, 40);
            this.PanTitulo.TabIndex = 0;
            this.PanTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // PcbLogoMain
            // 
            this.PcbLogoMain.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoMain.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoMain.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoMain.Name = "PcbLogoMain";
            this.PcbLogoMain.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoMain.TabIndex = 5;
            this.PcbLogoMain.TabStop = false;
            this.PcbLogoMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // MBtnCerrarDialog
            // 
            this.MBtnCerrarDialog.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarDialog.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarDialog.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarDialog.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarDialog.IconSize = 40;
            this.MBtnCerrarDialog.Location = new System.Drawing.Point(326, 0);
            this.MBtnCerrarDialog.Name = "MBtnCerrarDialog";
            this.MBtnCerrarDialog.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarDialog.Size = new System.Drawing.Size(40, 40);
            this.MBtnCerrarDialog.TabIndex = 6;
            this.MBtnCerrarDialog.UseVisualStyleBackColor = false;
            // 
            // LblCaption
            // 
            this.LblCaption.AutoSize = true;
            this.LblCaption.BackColor = System.Drawing.Color.Transparent;
            this.LblCaption.Font = new System.Drawing.Font("Merienda One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaption.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblCaption.Location = new System.Drawing.Point(50, 12);
            this.LblCaption.Name = "LblCaption";
            this.LblCaption.Size = new System.Drawing.Size(52, 17);
            this.LblCaption.TabIndex = 0;
            this.LblCaption.Text = "label1";
            this.LblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // PanBotones
            // 
            this.PanBotones.BackColor = System.Drawing.Color.Silver;
            this.PanBotones.Controls.Add(this.button3);
            this.PanBotones.Controls.Add(this.button2);
            this.PanBotones.Controls.Add(this.button1);
            this.PanBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBotones.Location = new System.Drawing.Point(0, 148);
            this.PanBotones.Name = "PanBotones";
            this.PanBotones.Size = new System.Drawing.Size(366, 50);
            this.PanBotones.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 41);
            this.button3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button3.StateCommon.Border.Rounding = 18;
            this.button3.StateCommon.Border.Width = 2;
            this.button3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.TabIndex = 5;
            this.button3.Values.Text = "ok";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 41);
            this.button2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateCommon.Border.Rounding = 18;
            this.button2.StateCommon.Border.Width = 2;
            this.button2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.TabIndex = 4;
            this.button2.Values.Text = "ok";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 6);
            this.button1.Name = "button1";
            this.button1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.OverrideFocus.Border.Width = 1;
            this.button1.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.button1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StateCommon.Border.Rounding = 20;
            this.button1.StateCommon.Border.Width = 2;
            this.button1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.button1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.TabIndex = 3;
            this.button1.Values.Text = "ok";
            // 
            // PanTexto
            // 
            this.PanTexto.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTexto.Controls.Add(this.LblMensaje);
            this.PanTexto.Controls.Add(this.PcbIcono);
            this.PanTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanTexto.Location = new System.Drawing.Point(0, 40);
            this.PanTexto.Name = "PanTexto";
            this.PanTexto.Padding = new System.Windows.Forms.Padding(25, 20, 0, 20);
            this.PanTexto.Size = new System.Drawing.Size(366, 108);
            this.PanTexto.TabIndex = 2;
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(73, 16);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Padding = new System.Windows.Forms.Padding(0, 12, 20, 18);
            this.LblMensaje.Size = new System.Drawing.Size(65, 47);
            this.LblMensaje.TabIndex = 1;
            this.LblMensaje.Text = "label1";
            // 
            // PcbIcono
            // 
            this.PcbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcbIcono.Location = new System.Drawing.Point(12, 18);
            this.PcbIcono.Name = "PcbIcono";
            this.PcbIcono.Padding = new System.Windows.Forms.Padding(3);
            this.PcbIcono.Size = new System.Drawing.Size(50, 50);
            this.PcbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbIcono.TabIndex = 0;
            this.PcbIcono.TabStop = false;
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 198);
            this.Controls.Add(this.PanTexto);
            this.Controls.Add(this.PanBotones);
            this.Controls.Add(this.PanTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessageBox";
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoMain)).EndInit();
            this.PanBotones.ResumeLayout(false);
            this.PanTexto.ResumeLayout(false);
            this.PanTexto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTitulo;
        private System.Windows.Forms.Label LblCaption;
        private System.Windows.Forms.Panel PanBotones;
        private System.Windows.Forms.Panel PanTexto;
        private System.Windows.Forms.PictureBox PcbLogoMain;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarDialog;
        private System.Windows.Forms.PictureBox PcbIcono;
        private System.Windows.Forms.Label LblMensaje;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
    }
}