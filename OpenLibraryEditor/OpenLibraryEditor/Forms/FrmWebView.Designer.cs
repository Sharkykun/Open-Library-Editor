namespace OpenLibraryEditor.Forms
{
    partial class FrmWebView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWebView));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.PanButtons = new System.Windows.Forms.Panel();
            this.MBtnMinimizar = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnCerrar = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMaximizar = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnRestaurar = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloMain = new System.Windows.Forms.Label();
            this.PcbLogoMain = new System.Windows.Forms.PictureBox();
            this.webView2Enlace = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PanTitulo.SuspendLayout();
            this.PanButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Enlace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 811);
            this.panel3.TabIndex = 151;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1001, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 811);
            this.panel2.TabIndex = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 808);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 3);
            this.panel1.TabIndex = 152;
            // 
            // PanTitulo
            // 
            this.PanTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTitulo.Controls.Add(this.PanButtons);
            this.PanTitulo.Controls.Add(this.LblTituloMain);
            this.PanTitulo.Controls.Add(this.PcbLogoMain);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(3, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(998, 39);
            this.PanTitulo.TabIndex = 153;
            this.PanTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloTitulos_MouseMove);
            // 
            // PanButtons
            // 
            this.PanButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanButtons.BackColor = System.Drawing.Color.Transparent;
            this.PanButtons.Controls.Add(this.MBtnMinimizar);
            this.PanButtons.Controls.Add(this.MBtnCerrar);
            this.PanButtons.Controls.Add(this.MBtnMaximizar);
            this.PanButtons.Controls.Add(this.MBtnRestaurar);
            this.PanButtons.Location = new System.Drawing.Point(878, 0);
            this.PanButtons.Name = "PanButtons";
            this.PanButtons.Size = new System.Drawing.Size(120, 40);
            this.PanButtons.TabIndex = 4;
            // 
            // MBtnMinimizar
            // 
            this.MBtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMinimizar.FlatAppearance.BorderSize = 0;
            this.MBtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMinimizar.IconChar = FontAwesome.Sharp.MaterialIcons.Minus;
            this.MBtnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnMinimizar.IconSize = 60;
            this.MBtnMinimizar.Location = new System.Drawing.Point(0, 0);
            this.MBtnMinimizar.Name = "MBtnMinimizar";
            this.MBtnMinimizar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.MBtnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.MBtnMinimizar.TabIndex = 7;
            this.MBtnMinimizar.UseVisualStyleBackColor = false;
            this.MBtnMinimizar.Click += new System.EventHandler(this.MBtnMinimizar_Click);
            // 
            // MBtnCerrar
            // 
            this.MBtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrar.FlatAppearance.BorderSize = 0;
            this.MBtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrar.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrar.IconSize = 40;
            this.MBtnCerrar.Location = new System.Drawing.Point(80, 0);
            this.MBtnCerrar.Name = "MBtnCerrar";
            this.MBtnCerrar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrar.Size = new System.Drawing.Size(40, 40);
            this.MBtnCerrar.TabIndex = 4;
            this.MBtnCerrar.UseVisualStyleBackColor = false;
            this.MBtnCerrar.Click += new System.EventHandler(this.MBtnCerrar_Click);
            // 
            // MBtnMaximizar
            // 
            this.MBtnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMaximizar.FlatAppearance.BorderSize = 0;
            this.MBtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMaximizar.IconChar = FontAwesome.Sharp.MaterialIcons.SquareOutline;
            this.MBtnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnMaximizar.IconSize = 42;
            this.MBtnMaximizar.Location = new System.Drawing.Point(40, 0);
            this.MBtnMaximizar.Name = "MBtnMaximizar";
            this.MBtnMaximizar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.MBtnMaximizar.TabIndex = 5;
            this.MBtnMaximizar.UseVisualStyleBackColor = false;
            this.MBtnMaximizar.Click += new System.EventHandler(this.MBtnMaximizar_Click);
            // 
            // MBtnRestaurar
            // 
            this.MBtnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.MBtnRestaurar.FlatAppearance.BorderSize = 0;
            this.MBtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnRestaurar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.MBtnRestaurar.IconChar = FontAwesome.Sharp.MaterialIcons.ArrangeBringForward;
            this.MBtnRestaurar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnRestaurar.IconSize = 40;
            this.MBtnRestaurar.Location = new System.Drawing.Point(40, 0);
            this.MBtnRestaurar.Name = "MBtnRestaurar";
            this.MBtnRestaurar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MBtnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.MBtnRestaurar.TabIndex = 8;
            this.MBtnRestaurar.UseVisualStyleBackColor = false;
            this.MBtnRestaurar.Click += new System.EventHandler(this.MBtnRestaurar_Click);
            // 
            // LblTituloMain
            // 
            this.LblTituloMain.AutoSize = true;
            this.LblTituloMain.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTituloMain.Location = new System.Drawing.Point(48, 9);
            this.LblTituloMain.Name = "LblTituloMain";
            this.LblTituloMain.Size = new System.Drawing.Size(171, 23);
            this.LblTituloMain.TabIndex = 5;
            this.LblTituloMain.Text = "Open Library Editor ";
            // 
            // PcbLogoMain
            // 
            this.PcbLogoMain.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoMain.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoMain.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoMain.Name = "PcbLogoMain";
            this.PcbLogoMain.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoMain.TabIndex = 4;
            this.PcbLogoMain.TabStop = false;
            this.PcbLogoMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanTituloTitulos_MouseMove);
            // 
            // webView2Enlace
            // 
            this.webView2Enlace.AllowExternalDrop = true;
            this.webView2Enlace.CreationProperties = null;
            this.webView2Enlace.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2Enlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2Enlace.Location = new System.Drawing.Point(3, 39);
            this.webView2Enlace.Name = "webView2Enlace";
            this.webView2Enlace.Size = new System.Drawing.Size(998, 769);
            this.webView2Enlace.TabIndex = 154;
            this.webView2Enlace.ZoomFactor = 1D;
            // 
            // FrmWebView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1004, 811);
            this.Controls.Add(this.webView2Enlace);
            this.Controls.Add(this.PanTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWebView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OLE";
            this.Load += new System.EventHandler(this.WebView_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView2Enlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanTitulo;
        private System.Windows.Forms.Panel PanButtons;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMinimizar;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrar;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMaximizar;
        private FontAwesome.Sharp.Material.MaterialButton MBtnRestaurar;
        private System.Windows.Forms.Label LblTituloMain;
        private System.Windows.Forms.PictureBox PcbLogoMain;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Enlace;
    }
}