namespace OpenLibraryEditor.Forms
{
    partial class FrmMisSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMisSeries));
            this.PanLsvMSE = new System.Windows.Forms.Panel();
            this.PanNumSeriesMSE = new System.Windows.Forms.Panel();
            this.LblPonerNumSeriesMSE = new System.Windows.Forms.Label();
            this.LblNumSeriesMSE = new System.Windows.Forms.Label();
            this.LsvMisSeriesMSE = new System.Windows.Forms.ListView();
            this.PanBusquedaMSE = new System.Windows.Forms.Panel();
            this.MBtnBuscarMSE = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarSerieMSE = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrdenMSE = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbOrdenPorMSE = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblOrdenarMSE = new System.Windows.Forms.Label();
            this.MBtnBorrarSerieMSE = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasSerieMSE = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTituloMisSeries = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloMisSeries = new System.Windows.Forms.Label();
            this.MPcbMisSeries = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.ImgListSeriesMSE = new System.Windows.Forms.ImageList(this.components);
            this.PanLsvMSE.SuspendLayout();
            this.PanNumSeriesMSE.SuspendLayout();
            this.PanBusquedaMSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMSE)).BeginInit();
            this.PanTituloMisSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // PanLsvMSE
            // 
            this.PanLsvMSE.BackColor = System.Drawing.Color.Gainsboro;
            this.PanLsvMSE.Controls.Add(this.PanNumSeriesMSE);
            this.PanLsvMSE.Controls.Add(this.LsvMisSeriesMSE);
            this.PanLsvMSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLsvMSE.Location = new System.Drawing.Point(0, 104);
            this.PanLsvMSE.Name = "PanLsvMSE";
            this.PanLsvMSE.Size = new System.Drawing.Size(948, 589);
            this.PanLsvMSE.TabIndex = 5;
            // 
            // PanNumSeriesMSE
            // 
            this.PanNumSeriesMSE.BackColor = System.Drawing.Color.Navy;
            this.PanNumSeriesMSE.Controls.Add(this.LblPonerNumSeriesMSE);
            this.PanNumSeriesMSE.Controls.Add(this.LblNumSeriesMSE);
            this.PanNumSeriesMSE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanNumSeriesMSE.Location = new System.Drawing.Point(0, 544);
            this.PanNumSeriesMSE.Name = "PanNumSeriesMSE";
            this.PanNumSeriesMSE.Size = new System.Drawing.Size(948, 45);
            this.PanNumSeriesMSE.TabIndex = 1;
            // 
            // LblPonerNumSeriesMSE
            // 
            this.LblPonerNumSeriesMSE.AutoSize = true;
            this.LblPonerNumSeriesMSE.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPonerNumSeriesMSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPonerNumSeriesMSE.Location = new System.Drawing.Point(172, 15);
            this.LblPonerNumSeriesMSE.Name = "LblPonerNumSeriesMSE";
            this.LblPonerNumSeriesMSE.Size = new System.Drawing.Size(0, 18);
            this.LblPonerNumSeriesMSE.TabIndex = 10;
            // 
            // LblNumSeriesMSE
            // 
            this.LblNumSeriesMSE.AutoSize = true;
            this.LblNumSeriesMSE.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumSeriesMSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNumSeriesMSE.Location = new System.Drawing.Point(37, 15);
            this.LblNumSeriesMSE.Name = "LblNumSeriesMSE";
            this.LblNumSeriesMSE.Size = new System.Drawing.Size(125, 18);
            this.LblNumSeriesMSE.TabIndex = 9;
            this.LblNumSeriesMSE.Text = "Número de series:";
            // 
            // LsvMisSeriesMSE
            // 
            this.LsvMisSeriesMSE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvMisSeriesMSE.BackColor = System.Drawing.Color.Navy;
            this.LsvMisSeriesMSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvMisSeriesMSE.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvMisSeriesMSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LsvMisSeriesMSE.HideSelection = false;
            this.LsvMisSeriesMSE.Location = new System.Drawing.Point(40, 40);
            this.LsvMisSeriesMSE.Name = "LsvMisSeriesMSE";
            this.LsvMisSeriesMSE.Size = new System.Drawing.Size(868, 458);
            this.LsvMisSeriesMSE.TabIndex = 0;
            this.LsvMisSeriesMSE.UseCompatibleStateImageBehavior = false;
            // 
            // PanBusquedaMSE
            // 
            this.PanBusquedaMSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMSE.Controls.Add(this.MBtnBuscarMSE);
            this.PanBusquedaMSE.Controls.Add(this.KTxtBuscarSerieMSE);
            this.PanBusquedaMSE.Controls.Add(this.MBtnOrdenMSE);
            this.PanBusquedaMSE.Controls.Add(this.KCmbOrdenPorMSE);
            this.PanBusquedaMSE.Controls.Add(this.LblOrdenarMSE);
            this.PanBusquedaMSE.Controls.Add(this.MBtnBorrarSerieMSE);
            this.PanBusquedaMSE.Controls.Add(this.MBtnMasSerieMSE);
            this.PanBusquedaMSE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMSE.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMSE.Name = "PanBusquedaMSE";
            this.PanBusquedaMSE.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMSE.TabIndex = 4;
            // 
            // MBtnBuscarMSE
            // 
            this.MBtnBuscarMSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnBuscarMSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMSE.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMSE.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMSE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMSE.IconSize = 30;
            this.MBtnBuscarMSE.Location = new System.Drawing.Point(878, 11);
            this.MBtnBuscarMSE.Name = "MBtnBuscarMSE";
            this.MBtnBuscarMSE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMSE.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarMSE.TabIndex = 126;
            this.MBtnBuscarMSE.UseVisualStyleBackColor = true;
            // 
            // KTxtBuscarSerieMSE
            // 
            this.KTxtBuscarSerieMSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KTxtBuscarSerieMSE.Location = new System.Drawing.Point(673, 4);
            this.KTxtBuscarSerieMSE.Name = "KTxtBuscarSerieMSE";
            this.KTxtBuscarSerieMSE.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarSerieMSE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarSerieMSE.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarSerieMSE.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarSerieMSE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarSerieMSE.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarSerieMSE.StateCommon.Border.Width = 2;
            this.KTxtBuscarSerieMSE.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarSerieMSE.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarSerieMSE.TabIndex = 125;
            // 
            // MBtnOrdenMSE
            // 
            this.MBtnOrdenMSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMSE.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMSE.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMSE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMSE.IconSize = 40;
            this.MBtnOrdenMSE.Location = new System.Drawing.Point(390, 5);
            this.MBtnOrdenMSE.Name = "MBtnOrdenMSE";
            this.MBtnOrdenMSE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrdenMSE.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrdenMSE.TabIndex = 109;
            this.MBtnOrdenMSE.UseVisualStyleBackColor = true;
            // 
            // KCmbOrdenPorMSE
            // 
            this.KCmbOrdenPorMSE.DropDownWidth = 228;
            this.KCmbOrdenPorMSE.Location = new System.Drawing.Point(217, 4);
            this.KCmbOrdenPorMSE.Name = "KCmbOrdenPorMSE";
            this.KCmbOrdenPorMSE.Size = new System.Drawing.Size(161, 33);
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMSE.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMSE.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMSE.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMSE.TabIndex = 108;
            // 
            // LblOrdenarMSE
            // 
            this.LblOrdenarMSE.AutoSize = true;
            this.LblOrdenarMSE.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenarMSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblOrdenarMSE.Location = new System.Drawing.Point(120, 11);
            this.LblOrdenarMSE.Name = "LblOrdenarMSE";
            this.LblOrdenarMSE.Size = new System.Drawing.Size(91, 18);
            this.LblOrdenarMSE.TabIndex = 8;
            this.LblOrdenarMSE.Text = "Ordenar por:";
            // 
            // MBtnBorrarSerieMSE
            // 
            this.MBtnBorrarSerieMSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarSerieMSE.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarSerieMSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarSerieMSE.IconChar = FontAwesome.Sharp.MaterialIcons.Delete;
            this.MBtnBorrarSerieMSE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBorrarSerieMSE.IconSize = 40;
            this.MBtnBorrarSerieMSE.Location = new System.Drawing.Point(76, 5);
            this.MBtnBorrarSerieMSE.Name = "MBtnBorrarSerieMSE";
            this.MBtnBorrarSerieMSE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBorrarSerieMSE.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarSerieMSE.TabIndex = 7;
            this.MBtnBorrarSerieMSE.UseVisualStyleBackColor = true;
            // 
            // MBtnMasSerieMSE
            // 
            this.MBtnMasSerieMSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasSerieMSE.FlatAppearance.BorderSize = 0;
            this.MBtnMasSerieMSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasSerieMSE.IconChar = FontAwesome.Sharp.MaterialIcons.Plus;
            this.MBtnMasSerieMSE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMasSerieMSE.IconSize = 40;
            this.MBtnMasSerieMSE.Location = new System.Drawing.Point(40, 5);
            this.MBtnMasSerieMSE.Name = "MBtnMasSerieMSE";
            this.MBtnMasSerieMSE.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasSerieMSE.TabIndex = 6;
            this.MBtnMasSerieMSE.UseVisualStyleBackColor = true;
            this.MBtnMasSerieMSE.Click += new System.EventHandler(this.MBtnMasSerieMSE_Click);
            // 
            // PanTituloMisSeries
            // 
            this.PanTituloMisSeries.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTituloMisSeries.Controls.Add(this.panel2);
            this.PanTituloMisSeries.Controls.Add(this.LblTituloMisSeries);
            this.PanTituloMisSeries.Controls.Add(this.MPcbMisSeries);
            this.PanTituloMisSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMisSeries.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMisSeries.Name = "PanTituloMisSeries";
            this.PanTituloMisSeries.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMisSeries.TabIndex = 3;
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
            // LblTituloMisSeries
            // 
            this.LblTituloMisSeries.AutoSize = true;
            this.LblTituloMisSeries.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMisSeries.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloMisSeries.Location = new System.Drawing.Point(75, 18);
            this.LblTituloMisSeries.Name = "LblTituloMisSeries";
            this.LblTituloMisSeries.Size = new System.Drawing.Size(135, 32);
            this.LblTituloMisSeries.TabIndex = 10;
            this.LblTituloMisSeries.Text = "Mis Series";
            // 
            // MPcbMisSeries
            // 
            this.MPcbMisSeries.BackColor = System.Drawing.Color.Transparent;
            this.MPcbMisSeries.ForeColor = System.Drawing.Color.Navy;
            this.MPcbMisSeries.IconChar = FontAwesome.Sharp.MaterialIcons.Bookshelf;
            this.MPcbMisSeries.IconColor = System.Drawing.Color.Navy;
            this.MPcbMisSeries.IconSize = 40;
            this.MPcbMisSeries.Location = new System.Drawing.Point(40, 15);
            this.MPcbMisSeries.Name = "MPcbMisSeries";
            this.MPcbMisSeries.Size = new System.Drawing.Size(40, 40);
            this.MPcbMisSeries.TabIndex = 12;
            this.MPcbMisSeries.TabStop = false;
            // 
            // ImgListSeriesMSE
            // 
            this.ImgListSeriesMSE.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListSeriesMSE.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListSeriesMSE.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMisSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanLsvMSE);
            this.Controls.Add(this.PanBusquedaMSE);
            this.Controls.Add(this.PanTituloMisSeries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMisSeries";
            this.Text = "FrmMisSeries";
            this.PanLsvMSE.ResumeLayout(false);
            this.PanNumSeriesMSE.ResumeLayout(false);
            this.PanNumSeriesMSE.PerformLayout();
            this.PanBusquedaMSE.ResumeLayout(false);
            this.PanBusquedaMSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMSE)).EndInit();
            this.PanTituloMisSeries.ResumeLayout(false);
            this.PanTituloMisSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanLsvMSE;
        private System.Windows.Forms.Panel PanNumSeriesMSE;
        private System.Windows.Forms.Label LblPonerNumSeriesMSE;
        private System.Windows.Forms.Label LblNumSeriesMSE;
        private System.Windows.Forms.ListView LsvMisSeriesMSE;
        private System.Windows.Forms.Panel PanBusquedaMSE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMSE;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarSerieMSE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMSE;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOrdenPorMSE;
        private System.Windows.Forms.Label LblOrdenarMSE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarSerieMSE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasSerieMSE;
        private System.Windows.Forms.Panel PanTituloMisSeries;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloMisSeries;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbMisSeries;
        private System.Windows.Forms.ImageList ImgListSeriesMSE;
    }
}