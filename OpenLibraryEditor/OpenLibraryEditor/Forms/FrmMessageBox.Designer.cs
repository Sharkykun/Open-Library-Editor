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
            this.PanTituloMb = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.LblCaption = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.PanTituloMb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTituloMb
            // 
            this.PanTituloMb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTituloMb.Controls.Add(this.btnClose);
            this.PanTituloMb.Controls.Add(this.LblCaption);
            this.PanTituloMb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMb.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMb.Name = "PanTituloMb";
            this.PanTituloMb.Size = new System.Drawing.Size(448, 40);
            this.PanTituloMb.TabIndex = 0;
            this.PanTituloMb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloMb_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(361, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "button4";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(34, 55);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(35, 13);
            this.LblMensaje.TabIndex = 1;
            this.LblMensaje.Text = "label1";
            // 
            // LblCaption
            // 
            this.LblCaption.AutoSize = true;
            this.LblCaption.Location = new System.Drawing.Point(21, 12);
            this.LblCaption.Name = "LblCaption";
            this.LblCaption.Size = new System.Drawing.Size(35, 13);
            this.LblCaption.TabIndex = 2;
            this.LblCaption.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 80);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(75, 58);
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.Location = new System.Drawing.Point(112, 64);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(336, 108);
            this.panelBody.TabIndex = 7;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Location = new System.Drawing.Point(0, 174);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(448, 51);
            this.panelButtons.TabIndex = 8;
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 221);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.PanTituloMb);
            this.Name = "FrmMessageBox";
            this.Text = "FrmMessageBox";
            this.PanTituloMb.ResumeLayout(false);
            this.PanTituloMb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloMb;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Label LblCaption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelButtons;
    }
}