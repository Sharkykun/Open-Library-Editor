namespace OpenLibraryEditor.Forms
{
    partial class FrmMisTitulos
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
            this.PanLsvMTI = new System.Windows.Forms.Panel();
            this.PanNumTitulosMTI = new System.Windows.Forms.Panel();
            this.LblPonerNumTitulosMTI = new System.Windows.Forms.Label();
            this.LblNumTitulosMTI = new System.Windows.Forms.Label();
            this.LsvTitulosMTI = new System.Windows.Forms.ListView();
            this.PanBusquedaMTI = new System.Windows.Forms.Panel();
            this.MBtnBuscarMTI = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarTituloMTI = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrdenMTI = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbOrdenPorMTI = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblOrdenarMTI = new System.Windows.Forms.Label();
            this.MBtnBorrarTituloMTI = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasTituloMTI = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTituloMisTitulos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloMisTitulos = new System.Windows.Forms.Label();
            this.MPcbMisTitulos = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.ImgListTitulosMTI = new System.Windows.Forms.ImageList(this.components);
            this.PanLsvMTI.SuspendLayout();
            this.PanNumTitulosMTI.SuspendLayout();
            this.PanBusquedaMTI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMTI)).BeginInit();
            this.PanTituloMisTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanLsvMTI
            // 
            this.PanLsvMTI.BackColor = System.Drawing.Color.Gainsboro;
            this.PanLsvMTI.Controls.Add(this.PanNumTitulosMTI);
            this.PanLsvMTI.Controls.Add(this.LsvTitulosMTI);
            this.PanLsvMTI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLsvMTI.Location = new System.Drawing.Point(0, 104);
            this.PanLsvMTI.Name = "PanLsvMTI";
            this.PanLsvMTI.Size = new System.Drawing.Size(948, 589);
            this.PanLsvMTI.TabIndex = 5;
            // 
            // PanNumTitulosMTI
            // 
            this.PanNumTitulosMTI.BackColor = System.Drawing.Color.Navy;
            this.PanNumTitulosMTI.Controls.Add(this.LblPonerNumTitulosMTI);
            this.PanNumTitulosMTI.Controls.Add(this.LblNumTitulosMTI);
            this.PanNumTitulosMTI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanNumTitulosMTI.Location = new System.Drawing.Point(0, 544);
            this.PanNumTitulosMTI.Name = "PanNumTitulosMTI";
            this.PanNumTitulosMTI.Size = new System.Drawing.Size(948, 45);
            this.PanNumTitulosMTI.TabIndex = 1;
            // 
            // LblPonerNumTitulosMTI
            // 
            this.LblPonerNumTitulosMTI.AutoSize = true;
            this.LblPonerNumTitulosMTI.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPonerNumTitulosMTI.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPonerNumTitulosMTI.Location = new System.Drawing.Point(172, 15);
            this.LblPonerNumTitulosMTI.Name = "LblPonerNumTitulosMTI";
            this.LblPonerNumTitulosMTI.Size = new System.Drawing.Size(0, 18);
            this.LblPonerNumTitulosMTI.TabIndex = 10;
            // 
            // LblNumTitulosMTI
            // 
            this.LblNumTitulosMTI.AutoSize = true;
            this.LblNumTitulosMTI.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumTitulosMTI.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNumTitulosMTI.Location = new System.Drawing.Point(37, 15);
            this.LblNumTitulosMTI.Name = "LblNumTitulosMTI";
            this.LblNumTitulosMTI.Size = new System.Drawing.Size(128, 18);
            this.LblNumTitulosMTI.TabIndex = 9;
            this.LblNumTitulosMTI.Text = "Número de títulos:";
            // 
            // LsvTitulosMTI
            // 
            this.LsvTitulosMTI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvTitulosMTI.BackColor = System.Drawing.Color.Navy;
            this.LsvTitulosMTI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvTitulosMTI.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvTitulosMTI.ForeColor = System.Drawing.Color.Gainsboro;
            this.LsvTitulosMTI.HideSelection = false;
            this.LsvTitulosMTI.Location = new System.Drawing.Point(40, 40);
            this.LsvTitulosMTI.Name = "LsvTitulosMTI";
            this.LsvTitulosMTI.Size = new System.Drawing.Size(868, 458);
            this.LsvTitulosMTI.TabIndex = 0;
            this.LsvTitulosMTI.UseCompatibleStateImageBehavior = false;
            // 
            // PanBusquedaMTI
            // 
            this.PanBusquedaMTI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMTI.Controls.Add(this.MBtnBuscarMTI);
            this.PanBusquedaMTI.Controls.Add(this.KTxtBuscarTituloMTI);
            this.PanBusquedaMTI.Controls.Add(this.MBtnOrdenMTI);
            this.PanBusquedaMTI.Controls.Add(this.KCmbOrdenPorMTI);
            this.PanBusquedaMTI.Controls.Add(this.LblOrdenarMTI);
            this.PanBusquedaMTI.Controls.Add(this.MBtnBorrarTituloMTI);
            this.PanBusquedaMTI.Controls.Add(this.MBtnMasTituloMTI);
            this.PanBusquedaMTI.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMTI.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMTI.Name = "PanBusquedaMTI";
            this.PanBusquedaMTI.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMTI.TabIndex = 4;
            // 
            // MBtnBuscarMTI
            // 
            this.MBtnBuscarMTI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnBuscarMTI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMTI.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMTI.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMTI.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMTI.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMTI.IconSize = 30;
            this.MBtnBuscarMTI.Location = new System.Drawing.Point(878, 11);
            this.MBtnBuscarMTI.Name = "MBtnBuscarMTI";
            this.MBtnBuscarMTI.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMTI.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarMTI.TabIndex = 126;
            this.MBtnBuscarMTI.UseVisualStyleBackColor = true;
            // 
            // KTxtBuscarTituloMTI
            // 
            this.KTxtBuscarTituloMTI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KTxtBuscarTituloMTI.Location = new System.Drawing.Point(673, 4);
            this.KTxtBuscarTituloMTI.Name = "KTxtBuscarTituloMTI";
            this.KTxtBuscarTituloMTI.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarTituloMTI.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarTituloMTI.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarTituloMTI.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarTituloMTI.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarTituloMTI.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarTituloMTI.StateCommon.Border.Width = 2;
            this.KTxtBuscarTituloMTI.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarTituloMTI.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarTituloMTI.TabIndex = 125;
            // 
            // MBtnOrdenMTI
            // 
            this.MBtnOrdenMTI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMTI.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMTI.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMTI.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMTI.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMTI.IconSize = 40;
            this.MBtnOrdenMTI.Location = new System.Drawing.Point(390, 5);
            this.MBtnOrdenMTI.Name = "MBtnOrdenMTI";
            this.MBtnOrdenMTI.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrdenMTI.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrdenMTI.TabIndex = 109;
            this.MBtnOrdenMTI.UseVisualStyleBackColor = true;
            // 
            // KCmbOrdenPorMTI
            // 
            this.KCmbOrdenPorMTI.DropDownWidth = 228;
            this.KCmbOrdenPorMTI.Location = new System.Drawing.Point(217, 4);
            this.KCmbOrdenPorMTI.Name = "KCmbOrdenPorMTI";
            this.KCmbOrdenPorMTI.Size = new System.Drawing.Size(161, 33);
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTI.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMTI.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMTI.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMTI.TabIndex = 108;
            // 
            // LblOrdenarMTI
            // 
            this.LblOrdenarMTI.AutoSize = true;
            this.LblOrdenarMTI.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenarMTI.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblOrdenarMTI.Location = new System.Drawing.Point(120, 11);
            this.LblOrdenarMTI.Name = "LblOrdenarMTI";
            this.LblOrdenarMTI.Size = new System.Drawing.Size(91, 18);
            this.LblOrdenarMTI.TabIndex = 8;
            this.LblOrdenarMTI.Text = "Ordenar por:";
            // 
            // MBtnBorrarTituloMTI
            // 
            this.MBtnBorrarTituloMTI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarTituloMTI.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarTituloMTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarTituloMTI.IconChar = FontAwesome.Sharp.MaterialIcons.Delete;
            this.MBtnBorrarTituloMTI.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBorrarTituloMTI.IconSize = 40;
            this.MBtnBorrarTituloMTI.Location = new System.Drawing.Point(76, 5);
            this.MBtnBorrarTituloMTI.Name = "MBtnBorrarTituloMTI";
            this.MBtnBorrarTituloMTI.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBorrarTituloMTI.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarTituloMTI.TabIndex = 7;
            this.MBtnBorrarTituloMTI.UseVisualStyleBackColor = true;
            // 
            // MBtnMasTituloMTI
            // 
            this.MBtnMasTituloMTI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasTituloMTI.FlatAppearance.BorderSize = 0;
            this.MBtnMasTituloMTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasTituloMTI.IconChar = FontAwesome.Sharp.MaterialIcons.Plus;
            this.MBtnMasTituloMTI.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMasTituloMTI.IconSize = 40;
            this.MBtnMasTituloMTI.Location = new System.Drawing.Point(40, 5);
            this.MBtnMasTituloMTI.Name = "MBtnMasTituloMTI";
            this.MBtnMasTituloMTI.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasTituloMTI.TabIndex = 6;
            this.MBtnMasTituloMTI.UseVisualStyleBackColor = true;
            this.MBtnMasTituloMTI.Click += new System.EventHandler(this.MBtnMasTituloMTI_Click);
            // 
            // PanTituloMisTitulos
            // 
            this.PanTituloMisTitulos.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTituloMisTitulos.Controls.Add(this.panel2);
            this.PanTituloMisTitulos.Controls.Add(this.LblTituloMisTitulos);
            this.PanTituloMisTitulos.Controls.Add(this.MPcbMisTitulos);
            this.PanTituloMisTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMisTitulos.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMisTitulos.Name = "PanTituloMisTitulos";
            this.PanTituloMisTitulos.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMisTitulos.TabIndex = 3;
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
            // LblTituloMisTitulos
            // 
            this.LblTituloMisTitulos.AutoSize = true;
            this.LblTituloMisTitulos.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMisTitulos.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloMisTitulos.Location = new System.Drawing.Point(75, 18);
            this.LblTituloMisTitulos.Name = "LblTituloMisTitulos";
            this.LblTituloMisTitulos.Size = new System.Drawing.Size(142, 32);
            this.LblTituloMisTitulos.TabIndex = 10;
            this.LblTituloMisTitulos.Text = "Mis Títulos";
            // 
            // MPcbMisTitulos
            // 
            this.MPcbMisTitulos.BackColor = System.Drawing.Color.Transparent;
            this.MPcbMisTitulos.ForeColor = System.Drawing.Color.Navy;
            this.MPcbMisTitulos.IconChar = FontAwesome.Sharp.MaterialIcons.TextShadow;
            this.MPcbMisTitulos.IconColor = System.Drawing.Color.Navy;
            this.MPcbMisTitulos.IconSize = 40;
            this.MPcbMisTitulos.Location = new System.Drawing.Point(40, 15);
            this.MPcbMisTitulos.Name = "MPcbMisTitulos";
            this.MPcbMisTitulos.Size = new System.Drawing.Size(40, 40);
            this.MPcbMisTitulos.TabIndex = 12;
            this.MPcbMisTitulos.TabStop = false;
            // 
            // ImgListTitulosMTI
            // 
            this.ImgListTitulosMTI.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListTitulosMTI.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListTitulosMTI.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMisTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanLsvMTI);
            this.Controls.Add(this.PanBusquedaMTI);
            this.Controls.Add(this.PanTituloMisTitulos);
            this.Name = "FrmMisTitulos";
            this.Text = "FrmMisTitulos";
            this.PanLsvMTI.ResumeLayout(false);
            this.PanNumTitulosMTI.ResumeLayout(false);
            this.PanNumTitulosMTI.PerformLayout();
            this.PanBusquedaMTI.ResumeLayout(false);
            this.PanBusquedaMTI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMTI)).EndInit();
            this.PanTituloMisTitulos.ResumeLayout(false);
            this.PanTituloMisTitulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisTitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanLsvMTI;
        private System.Windows.Forms.Panel PanNumTitulosMTI;
        private System.Windows.Forms.Label LblPonerNumTitulosMTI;
        private System.Windows.Forms.Label LblNumTitulosMTI;
        private System.Windows.Forms.ListView LsvTitulosMTI;
        private System.Windows.Forms.Panel PanBusquedaMTI;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMTI;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarTituloMTI;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMTI;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOrdenPorMTI;
        private System.Windows.Forms.Label LblOrdenarMTI;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarTituloMTI;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasTituloMTI;
        private System.Windows.Forms.Panel PanTituloMisTitulos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloMisTitulos;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbMisTitulos;
        private System.Windows.Forms.ImageList ImgListTitulosMTI;
    }
}