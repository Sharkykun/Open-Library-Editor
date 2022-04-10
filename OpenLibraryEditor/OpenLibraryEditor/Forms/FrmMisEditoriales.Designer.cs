namespace OpenLibraryEditor.Forms
{
    partial class FrmMisEditoriales
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
            this.PanLsvMED = new System.Windows.Forms.Panel();
            this.PanNumEditorialesMED = new System.Windows.Forms.Panel();
            this.LblPonerNumEditorialesMED = new System.Windows.Forms.Label();
            this.LblNumEditorialesMED = new System.Windows.Forms.Label();
            this.LsvMisEditorialesMED = new System.Windows.Forms.ListView();
            this.PanBusquedaMED = new System.Windows.Forms.Panel();
            this.MBtnBuscarMED = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarEditorialMED = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrdenMED = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbOrdenPorMED = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblOrdenarMED = new System.Windows.Forms.Label();
            this.MBtnBorrarEditorialMED = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasEditorialMED = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTituloMisEditoriales = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloMisEditoriales = new System.Windows.Forms.Label();
            this.MPcbMisEditoriales = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.ImgListEditorialesMED = new System.Windows.Forms.ImageList(this.components);
            this.PanLsvMED.SuspendLayout();
            this.PanNumEditorialesMED.SuspendLayout();
            this.PanBusquedaMED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMED)).BeginInit();
            this.PanTituloMisEditoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // PanLsvMED
            // 
            this.PanLsvMED.BackColor = System.Drawing.Color.Gainsboro;
            this.PanLsvMED.Controls.Add(this.PanNumEditorialesMED);
            this.PanLsvMED.Controls.Add(this.LsvMisEditorialesMED);
            this.PanLsvMED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLsvMED.Location = new System.Drawing.Point(0, 104);
            this.PanLsvMED.Name = "PanLsvMED";
            this.PanLsvMED.Size = new System.Drawing.Size(948, 589);
            this.PanLsvMED.TabIndex = 8;
            // 
            // PanNumEditorialesMED
            // 
            this.PanNumEditorialesMED.BackColor = System.Drawing.Color.Navy;
            this.PanNumEditorialesMED.Controls.Add(this.LblPonerNumEditorialesMED);
            this.PanNumEditorialesMED.Controls.Add(this.LblNumEditorialesMED);
            this.PanNumEditorialesMED.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanNumEditorialesMED.Location = new System.Drawing.Point(0, 544);
            this.PanNumEditorialesMED.Name = "PanNumEditorialesMED";
            this.PanNumEditorialesMED.Size = new System.Drawing.Size(948, 45);
            this.PanNumEditorialesMED.TabIndex = 1;
            // 
            // LblPonerNumEditorialesMED
            // 
            this.LblPonerNumEditorialesMED.AutoSize = true;
            this.LblPonerNumEditorialesMED.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPonerNumEditorialesMED.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPonerNumEditorialesMED.Location = new System.Drawing.Point(198, 15);
            this.LblPonerNumEditorialesMED.Name = "LblPonerNumEditorialesMED";
            this.LblPonerNumEditorialesMED.Size = new System.Drawing.Size(0, 18);
            this.LblPonerNumEditorialesMED.TabIndex = 10;
            // 
            // LblNumEditorialesMED
            // 
            this.LblNumEditorialesMED.AutoSize = true;
            this.LblNumEditorialesMED.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumEditorialesMED.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNumEditorialesMED.Location = new System.Drawing.Point(37, 15);
            this.LblNumEditorialesMED.Name = "LblNumEditorialesMED";
            this.LblNumEditorialesMED.Size = new System.Drawing.Size(155, 18);
            this.LblNumEditorialesMED.TabIndex = 9;
            this.LblNumEditorialesMED.Text = "Número de editoriales:";
            // 
            // LsvMisEditorialesMED
            // 
            this.LsvMisEditorialesMED.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvMisEditorialesMED.BackColor = System.Drawing.Color.Navy;
            this.LsvMisEditorialesMED.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvMisEditorialesMED.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvMisEditorialesMED.ForeColor = System.Drawing.Color.Gainsboro;
            this.LsvMisEditorialesMED.HideSelection = false;
            this.LsvMisEditorialesMED.Location = new System.Drawing.Point(40, 40);
            this.LsvMisEditorialesMED.Name = "LsvMisEditorialesMED";
            this.LsvMisEditorialesMED.Size = new System.Drawing.Size(868, 458);
            this.LsvMisEditorialesMED.TabIndex = 0;
            this.LsvMisEditorialesMED.UseCompatibleStateImageBehavior = false;
            // 
            // PanBusquedaMED
            // 
            this.PanBusquedaMED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMED.Controls.Add(this.MBtnBuscarMED);
            this.PanBusquedaMED.Controls.Add(this.KTxtBuscarEditorialMED);
            this.PanBusquedaMED.Controls.Add(this.MBtnOrdenMED);
            this.PanBusquedaMED.Controls.Add(this.KCmbOrdenPorMED);
            this.PanBusquedaMED.Controls.Add(this.LblOrdenarMED);
            this.PanBusquedaMED.Controls.Add(this.MBtnBorrarEditorialMED);
            this.PanBusquedaMED.Controls.Add(this.MBtnMasEditorialMED);
            this.PanBusquedaMED.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMED.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMED.Name = "PanBusquedaMED";
            this.PanBusquedaMED.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMED.TabIndex = 7;
            // 
            // MBtnBuscarMED
            // 
            this.MBtnBuscarMED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnBuscarMED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMED.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMED.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMED.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMED.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMED.IconSize = 30;
            this.MBtnBuscarMED.Location = new System.Drawing.Point(878, 11);
            this.MBtnBuscarMED.Name = "MBtnBuscarMED";
            this.MBtnBuscarMED.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMED.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarMED.TabIndex = 126;
            this.MBtnBuscarMED.UseVisualStyleBackColor = true;
            // 
            // KTxtBuscarEditorialMED
            // 
            this.KTxtBuscarEditorialMED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KTxtBuscarEditorialMED.Location = new System.Drawing.Point(673, 4);
            this.KTxtBuscarEditorialMED.Name = "KTxtBuscarEditorialMED";
            this.KTxtBuscarEditorialMED.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarEditorialMED.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarEditorialMED.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarEditorialMED.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarEditorialMED.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarEditorialMED.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarEditorialMED.StateCommon.Border.Width = 2;
            this.KTxtBuscarEditorialMED.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarEditorialMED.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarEditorialMED.TabIndex = 125;
            // 
            // MBtnOrdenMED
            // 
            this.MBtnOrdenMED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMED.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMED.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMED.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMED.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMED.IconSize = 40;
            this.MBtnOrdenMED.Location = new System.Drawing.Point(390, 5);
            this.MBtnOrdenMED.Name = "MBtnOrdenMED";
            this.MBtnOrdenMED.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrdenMED.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrdenMED.TabIndex = 109;
            this.MBtnOrdenMED.UseVisualStyleBackColor = true;
            // 
            // KCmbOrdenPorMED
            // 
            this.KCmbOrdenPorMED.DropDownWidth = 228;
            this.KCmbOrdenPorMED.Location = new System.Drawing.Point(217, 4);
            this.KCmbOrdenPorMED.Name = "KCmbOrdenPorMED";
            this.KCmbOrdenPorMED.Size = new System.Drawing.Size(161, 33);
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMED.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMED.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMED.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMED.TabIndex = 108;
            // 
            // LblOrdenarMED
            // 
            this.LblOrdenarMED.AutoSize = true;
            this.LblOrdenarMED.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenarMED.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblOrdenarMED.Location = new System.Drawing.Point(120, 11);
            this.LblOrdenarMED.Name = "LblOrdenarMED";
            this.LblOrdenarMED.Size = new System.Drawing.Size(91, 18);
            this.LblOrdenarMED.TabIndex = 8;
            this.LblOrdenarMED.Text = "Ordenar por:";
            // 
            // MBtnBorrarEditorialMED
            // 
            this.MBtnBorrarEditorialMED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarEditorialMED.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarEditorialMED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarEditorialMED.IconChar = FontAwesome.Sharp.MaterialIcons.Delete;
            this.MBtnBorrarEditorialMED.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBorrarEditorialMED.IconSize = 40;
            this.MBtnBorrarEditorialMED.Location = new System.Drawing.Point(76, 5);
            this.MBtnBorrarEditorialMED.Name = "MBtnBorrarEditorialMED";
            this.MBtnBorrarEditorialMED.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBorrarEditorialMED.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarEditorialMED.TabIndex = 7;
            this.MBtnBorrarEditorialMED.UseVisualStyleBackColor = true;
            // 
            // MBtnMasEditorialMED
            // 
            this.MBtnMasEditorialMED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasEditorialMED.FlatAppearance.BorderSize = 0;
            this.MBtnMasEditorialMED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasEditorialMED.IconChar = FontAwesome.Sharp.MaterialIcons.Plus;
            this.MBtnMasEditorialMED.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMasEditorialMED.IconSize = 40;
            this.MBtnMasEditorialMED.Location = new System.Drawing.Point(40, 5);
            this.MBtnMasEditorialMED.Name = "MBtnMasEditorialMED";
            this.MBtnMasEditorialMED.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasEditorialMED.TabIndex = 6;
            this.MBtnMasEditorialMED.UseVisualStyleBackColor = true;
            this.MBtnMasEditorialMED.Click += new System.EventHandler(this.MBtnMasEditorialMED_Click);
            // 
            // PanTituloMisEditoriales
            // 
            this.PanTituloMisEditoriales.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTituloMisEditoriales.Controls.Add(this.panel2);
            this.PanTituloMisEditoriales.Controls.Add(this.LblTituloMisEditoriales);
            this.PanTituloMisEditoriales.Controls.Add(this.MPcbMisEditoriales);
            this.PanTituloMisEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMisEditoriales.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMisEditoriales.Name = "PanTituloMisEditoriales";
            this.PanTituloMisEditoriales.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMisEditoriales.TabIndex = 6;
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
            // LblTituloMisEditoriales
            // 
            this.LblTituloMisEditoriales.AutoSize = true;
            this.LblTituloMisEditoriales.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMisEditoriales.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloMisEditoriales.Location = new System.Drawing.Point(75, 18);
            this.LblTituloMisEditoriales.Name = "LblTituloMisEditoriales";
            this.LblTituloMisEditoriales.Size = new System.Drawing.Size(192, 32);
            this.LblTituloMisEditoriales.TabIndex = 10;
            this.LblTituloMisEditoriales.Text = "Mis Editoriales";
            // 
            // MPcbMisEditoriales
            // 
            this.MPcbMisEditoriales.BackColor = System.Drawing.Color.Transparent;
            this.MPcbMisEditoriales.ForeColor = System.Drawing.Color.Navy;
            this.MPcbMisEditoriales.IconChar = FontAwesome.Sharp.MaterialIcons.BankOutline;
            this.MPcbMisEditoriales.IconColor = System.Drawing.Color.Navy;
            this.MPcbMisEditoriales.IconSize = 40;
            this.MPcbMisEditoriales.Location = new System.Drawing.Point(40, 15);
            this.MPcbMisEditoriales.Name = "MPcbMisEditoriales";
            this.MPcbMisEditoriales.Size = new System.Drawing.Size(40, 40);
            this.MPcbMisEditoriales.TabIndex = 12;
            this.MPcbMisEditoriales.TabStop = false;
            // 
            // ImgListEditorialesMED
            // 
            this.ImgListEditorialesMED.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListEditorialesMED.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListEditorialesMED.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMisEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanLsvMED);
            this.Controls.Add(this.PanBusquedaMED);
            this.Controls.Add(this.PanTituloMisEditoriales);
            this.Name = "FrmMisEditoriales";
            this.Text = "FrmMisEditoriales";
            this.PanLsvMED.ResumeLayout(false);
            this.PanNumEditorialesMED.ResumeLayout(false);
            this.PanNumEditorialesMED.PerformLayout();
            this.PanBusquedaMED.ResumeLayout(false);
            this.PanBusquedaMED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMED)).EndInit();
            this.PanTituloMisEditoriales.ResumeLayout(false);
            this.PanTituloMisEditoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisEditoriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanLsvMED;
        private System.Windows.Forms.Panel PanNumEditorialesMED;
        private System.Windows.Forms.Label LblPonerNumEditorialesMED;
        private System.Windows.Forms.Label LblNumEditorialesMED;
        private System.Windows.Forms.ListView LsvMisEditorialesMED;
        private System.Windows.Forms.Panel PanBusquedaMED;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMED;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarEditorialMED;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMED;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOrdenPorMED;
        private System.Windows.Forms.Label LblOrdenarMED;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarEditorialMED;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasEditorialMED;
        private System.Windows.Forms.Panel PanTituloMisEditoriales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloMisEditoriales;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbMisEditoriales;
        private System.Windows.Forms.ImageList ImgListEditorialesMED;
    }
}