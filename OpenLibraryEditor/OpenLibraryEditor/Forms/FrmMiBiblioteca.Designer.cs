namespace OpenLibraryEditor.Forms
{
    partial class FrmMiBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiBiblioteca));
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.PanBtnAu = new System.Windows.Forms.Panel();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblNoLibros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbLogo
            // 
            this.PcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogo.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogo.Location = new System.Drawing.Point(270, 131);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(400, 400);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogo.TabIndex = 13;
            this.PcbLogo.TabStop = false;
            // 
            // PanBtnAu
            // 
            this.PanBtnAu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtnAu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnAu.Location = new System.Drawing.Point(0, 650);
            this.PanBtnAu.Name = "PanBtnAu";
            this.PanBtnAu.Size = new System.Drawing.Size(948, 43);
            this.PanBtnAu.TabIndex = 98;
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Merienda One", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblBienvenido.Location = new System.Drawing.Point(169, 51);
            this.LblBienvenido.Margin = new System.Windows.Forms.Padding(130, 25, 0, 0);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(621, 49);
            this.LblBienvenido.TabIndex = 99;
            this.LblBienvenido.Text = "Bienvenido a Open Library Editor";
            this.LblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 0);
            this.panel1.TabIndex = 100;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 0);
            this.flowLayoutPanel1.TabIndex = 101;
            // 
            // LblNoLibros
            // 
            this.LblNoLibros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNoLibros.AutoSize = true;
            this.LblNoLibros.Font = new System.Drawing.Font("Merienda One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblNoLibros.Location = new System.Drawing.Point(172, 572);
            this.LblNoLibros.Margin = new System.Windows.Forms.Padding(130, 25, 0, 0);
            this.LblNoLibros.Name = "LblNoLibros";
            this.LblNoLibros.Size = new System.Drawing.Size(586, 34);
            this.LblNoLibros.TabIndex = 102;
            this.LblNoLibros.Text = "Il n\'y a pas de livres dans votre bibliothèque";
            this.LblNoLibros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMiBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.LblNoLibros);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanBtnAu);
            this.Controls.Add(this.PcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMiBiblioteca";
            this.Text = "FrmBiblioteca";
            this.Load += new System.EventHandler(this.FrmMiBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Panel PanBtnAu;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblNoLibros;
    }
}