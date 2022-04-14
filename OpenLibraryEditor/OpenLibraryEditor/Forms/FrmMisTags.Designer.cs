namespace OpenLibraryEditor.Forms
{
    partial class FrmMisTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMisTags));
            this.PanLsvMTA = new System.Windows.Forms.Panel();
            this.PanNumTagsMTA = new System.Windows.Forms.Panel();
            this.LblPonerNumTagsMTA = new System.Windows.Forms.Label();
            this.LblNumTagsMTA = new System.Windows.Forms.Label();
            this.LsvMisTagsMTA = new System.Windows.Forms.ListView();
            this.PanBusquedaMTA = new System.Windows.Forms.Panel();
            this.MBtnBuscarMTA = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarTagsMTA = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrdenMTA = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbOrdenPorMTA = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblOrdenarMTA = new System.Windows.Forms.Label();
            this.MBtnBorrarTagMTA = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasTagMTA = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTituloMisTags = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloMisTags = new System.Windows.Forms.Label();
            this.MPcbMisTags = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.ImgListTagsMTA = new System.Windows.Forms.ImageList(this.components);
            this.PanLsvMTA.SuspendLayout();
            this.PanNumTagsMTA.SuspendLayout();
            this.PanBusquedaMTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMTA)).BeginInit();
            this.PanTituloMisTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisTags)).BeginInit();
            this.SuspendLayout();
            // 
            // PanLsvMTA
            // 
            this.PanLsvMTA.BackColor = System.Drawing.Color.Gainsboro;
            this.PanLsvMTA.Controls.Add(this.PanNumTagsMTA);
            this.PanLsvMTA.Controls.Add(this.LsvMisTagsMTA);
            this.PanLsvMTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLsvMTA.Location = new System.Drawing.Point(0, 104);
            this.PanLsvMTA.Name = "PanLsvMTA";
            this.PanLsvMTA.Size = new System.Drawing.Size(948, 589);
            this.PanLsvMTA.TabIndex = 8;
            // 
            // PanNumTagsMTA
            // 
            this.PanNumTagsMTA.BackColor = System.Drawing.Color.Navy;
            this.PanNumTagsMTA.Controls.Add(this.LblPonerNumTagsMTA);
            this.PanNumTagsMTA.Controls.Add(this.LblNumTagsMTA);
            this.PanNumTagsMTA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanNumTagsMTA.Location = new System.Drawing.Point(0, 544);
            this.PanNumTagsMTA.Name = "PanNumTagsMTA";
            this.PanNumTagsMTA.Size = new System.Drawing.Size(948, 45);
            this.PanNumTagsMTA.TabIndex = 1;
            // 
            // LblPonerNumTagsMTA
            // 
            this.LblPonerNumTagsMTA.AutoSize = true;
            this.LblPonerNumTagsMTA.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPonerNumTagsMTA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPonerNumTagsMTA.Location = new System.Drawing.Point(172, 15);
            this.LblPonerNumTagsMTA.Name = "LblPonerNumTagsMTA";
            this.LblPonerNumTagsMTA.Size = new System.Drawing.Size(0, 18);
            this.LblPonerNumTagsMTA.TabIndex = 10;
            // 
            // LblNumTagsMTA
            // 
            this.LblNumTagsMTA.AutoSize = true;
            this.LblNumTagsMTA.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumTagsMTA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNumTagsMTA.Location = new System.Drawing.Point(37, 15);
            this.LblNumTagsMTA.Name = "LblNumTagsMTA";
            this.LblNumTagsMTA.Size = new System.Drawing.Size(115, 18);
            this.LblNumTagsMTA.TabIndex = 9;
            this.LblNumTagsMTA.Text = "Número de tags:";
            // 
            // LsvMisTagsMTA
            // 
            this.LsvMisTagsMTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvMisTagsMTA.BackColor = System.Drawing.Color.Navy;
            this.LsvMisTagsMTA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvMisTagsMTA.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvMisTagsMTA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LsvMisTagsMTA.HideSelection = false;
            this.LsvMisTagsMTA.Location = new System.Drawing.Point(40, 40);
            this.LsvMisTagsMTA.Name = "LsvMisTagsMTA";
            this.LsvMisTagsMTA.Size = new System.Drawing.Size(868, 458);
            this.LsvMisTagsMTA.TabIndex = 0;
            this.LsvMisTagsMTA.UseCompatibleStateImageBehavior = false;
            // 
            // PanBusquedaMTA
            // 
            this.PanBusquedaMTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMTA.Controls.Add(this.MBtnBuscarMTA);
            this.PanBusquedaMTA.Controls.Add(this.KTxtBuscarTagsMTA);
            this.PanBusquedaMTA.Controls.Add(this.MBtnOrdenMTA);
            this.PanBusquedaMTA.Controls.Add(this.KCmbOrdenPorMTA);
            this.PanBusquedaMTA.Controls.Add(this.LblOrdenarMTA);
            this.PanBusquedaMTA.Controls.Add(this.MBtnBorrarTagMTA);
            this.PanBusquedaMTA.Controls.Add(this.MBtnMasTagMTA);
            this.PanBusquedaMTA.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMTA.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMTA.Name = "PanBusquedaMTA";
            this.PanBusquedaMTA.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMTA.TabIndex = 7;
            // 
            // MBtnBuscarMTA
            // 
            this.MBtnBuscarMTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnBuscarMTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMTA.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMTA.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMTA.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMTA.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMTA.IconSize = 30;
            this.MBtnBuscarMTA.Location = new System.Drawing.Point(878, 11);
            this.MBtnBuscarMTA.Name = "MBtnBuscarMTA";
            this.MBtnBuscarMTA.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMTA.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarMTA.TabIndex = 126;
            this.MBtnBuscarMTA.UseVisualStyleBackColor = true;
            // 
            // KTxtBuscarTagsMTA
            // 
            this.KTxtBuscarTagsMTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KTxtBuscarTagsMTA.Location = new System.Drawing.Point(673, 4);
            this.KTxtBuscarTagsMTA.Name = "KTxtBuscarTagsMTA";
            this.KTxtBuscarTagsMTA.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarTagsMTA.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarTagsMTA.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarTagsMTA.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarTagsMTA.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarTagsMTA.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarTagsMTA.StateCommon.Border.Width = 2;
            this.KTxtBuscarTagsMTA.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarTagsMTA.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarTagsMTA.TabIndex = 125;
            // 
            // MBtnOrdenMTA
            // 
            this.MBtnOrdenMTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMTA.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMTA.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMTA.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMTA.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMTA.IconSize = 40;
            this.MBtnOrdenMTA.Location = new System.Drawing.Point(390, 5);
            this.MBtnOrdenMTA.Name = "MBtnOrdenMTA";
            this.MBtnOrdenMTA.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrdenMTA.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrdenMTA.TabIndex = 109;
            this.MBtnOrdenMTA.UseVisualStyleBackColor = true;
            // 
            // KCmbOrdenPorMTA
            // 
            this.KCmbOrdenPorMTA.DropDownWidth = 228;
            this.KCmbOrdenPorMTA.Location = new System.Drawing.Point(217, 4);
            this.KCmbOrdenPorMTA.Name = "KCmbOrdenPorMTA";
            this.KCmbOrdenPorMTA.Size = new System.Drawing.Size(161, 33);
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTA.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMTA.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTA.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMTA.TabIndex = 108;
            // 
            // LblOrdenarMTA
            // 
            this.LblOrdenarMTA.AutoSize = true;
            this.LblOrdenarMTA.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenarMTA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblOrdenarMTA.Location = new System.Drawing.Point(120, 11);
            this.LblOrdenarMTA.Name = "LblOrdenarMTA";
            this.LblOrdenarMTA.Size = new System.Drawing.Size(91, 18);
            this.LblOrdenarMTA.TabIndex = 8;
            this.LblOrdenarMTA.Text = "Ordenar por:";
            // 
            // MBtnBorrarTagMTA
            // 
            this.MBtnBorrarTagMTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarTagMTA.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarTagMTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarTagMTA.IconChar = FontAwesome.Sharp.MaterialIcons.Delete;
            this.MBtnBorrarTagMTA.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBorrarTagMTA.IconSize = 40;
            this.MBtnBorrarTagMTA.Location = new System.Drawing.Point(76, 5);
            this.MBtnBorrarTagMTA.Name = "MBtnBorrarTagMTA";
            this.MBtnBorrarTagMTA.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBorrarTagMTA.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarTagMTA.TabIndex = 7;
            this.MBtnBorrarTagMTA.UseVisualStyleBackColor = true;
            // 
            // MBtnMasTagMTA
            // 
            this.MBtnMasTagMTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasTagMTA.FlatAppearance.BorderSize = 0;
            this.MBtnMasTagMTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasTagMTA.IconChar = FontAwesome.Sharp.MaterialIcons.Plus;
            this.MBtnMasTagMTA.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMasTagMTA.IconSize = 40;
            this.MBtnMasTagMTA.Location = new System.Drawing.Point(40, 5);
            this.MBtnMasTagMTA.Name = "MBtnMasTagMTA";
            this.MBtnMasTagMTA.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasTagMTA.TabIndex = 6;
            this.MBtnMasTagMTA.UseVisualStyleBackColor = true;
            this.MBtnMasTagMTA.Click += new System.EventHandler(this.MBtnMasTagMTA_Click);
            // 
            // PanTituloMisTags
            // 
            this.PanTituloMisTags.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTituloMisTags.Controls.Add(this.panel2);
            this.PanTituloMisTags.Controls.Add(this.LblTituloMisTags);
            this.PanTituloMisTags.Controls.Add(this.MPcbMisTags);
            this.PanTituloMisTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMisTags.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMisTags.Name = "PanTituloMisTags";
            this.PanTituloMisTags.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMisTags.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(40, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 3);
            this.panel2.TabIndex = 11;
            // 
            // LblTituloMisTags
            // 
            this.LblTituloMisTags.AutoSize = true;
            this.LblTituloMisTags.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMisTags.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloMisTags.Location = new System.Drawing.Point(75, 18);
            this.LblTituloMisTags.Name = "LblTituloMisTags";
            this.LblTituloMisTags.Size = new System.Drawing.Size(173, 32);
            this.LblTituloMisTags.TabIndex = 10;
            this.LblTituloMisTags.Text = "Mis Etiquetas";
            // 
            // MPcbMisTags
            // 
            this.MPcbMisTags.BackColor = System.Drawing.Color.Transparent;
            this.MPcbMisTags.ForeColor = System.Drawing.Color.Navy;
            this.MPcbMisTags.IconChar = FontAwesome.Sharp.MaterialIcons.TagMultiple;
            this.MPcbMisTags.IconColor = System.Drawing.Color.Navy;
            this.MPcbMisTags.IconSize = 40;
            this.MPcbMisTags.Location = new System.Drawing.Point(40, 15);
            this.MPcbMisTags.Name = "MPcbMisTags";
            this.MPcbMisTags.Size = new System.Drawing.Size(40, 40);
            this.MPcbMisTags.TabIndex = 12;
            this.MPcbMisTags.TabStop = false;
            // 
            // ImgListTagsMTA
            // 
            this.ImgListTagsMTA.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListTagsMTA.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListTagsMTA.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMisTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanLsvMTA);
            this.Controls.Add(this.PanBusquedaMTA);
            this.Controls.Add(this.PanTituloMisTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMisTags";
            this.Text = "FrmMisTags";
            this.PanLsvMTA.ResumeLayout(false);
            this.PanNumTagsMTA.ResumeLayout(false);
            this.PanNumTagsMTA.PerformLayout();
            this.PanBusquedaMTA.ResumeLayout(false);
            this.PanBusquedaMTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMTA)).EndInit();
            this.PanTituloMisTags.ResumeLayout(false);
            this.PanTituloMisTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanLsvMTA;
        private System.Windows.Forms.Panel PanNumTagsMTA;
        private System.Windows.Forms.Label LblPonerNumTagsMTA;
        private System.Windows.Forms.Label LblNumTagsMTA;
        private System.Windows.Forms.ListView LsvMisTagsMTA;
        private System.Windows.Forms.Panel PanBusquedaMTA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMTA;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarTagsMTA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMTA;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOrdenPorMTA;
        private System.Windows.Forms.Label LblOrdenarMTA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarTagMTA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasTagMTA;
        private System.Windows.Forms.Panel PanTituloMisTags;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloMisTags;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbMisTags;
        private System.Windows.Forms.ImageList ImgListTagsMTA;
    }
}