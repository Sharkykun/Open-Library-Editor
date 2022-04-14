namespace OpenLibraryEditor.Forms
{
    partial class FrmMisAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMisAutores));
            this.PanTituloMisAutores = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloMisAutores = new System.Windows.Forms.Label();
            this.MPcbMisAutores = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.PanBusquedaMAU = new System.Windows.Forms.Panel();
            this.MBtnBuscarMAU = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarAutorMAU = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrdenMAU = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbOrdenPorMAU = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblOrdenarMAU = new System.Windows.Forms.Label();
            this.MBtnBorrarAutorMAU = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasAutorMAU = new FontAwesome.Sharp.Material.MaterialButton();
            this.ImgListAutoresMAU = new System.Windows.Forms.ImageList(this.components);
            this.PanLsvMAU = new System.Windows.Forms.Panel();
            this.PanNumAutoresMAU = new System.Windows.Forms.Panel();
            this.LblPonerNumAutoresMAU = new System.Windows.Forms.Label();
            this.LblNumAutoresMAU = new System.Windows.Forms.Label();
            this.LsvMisAutoresMAU = new System.Windows.Forms.ListView();
            this.PanTituloMisAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisAutores)).BeginInit();
            this.PanBusquedaMAU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMAU)).BeginInit();
            this.PanLsvMAU.SuspendLayout();
            this.PanNumAutoresMAU.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTituloMisAutores
            // 
            this.PanTituloMisAutores.Controls.Add(this.panel2);
            this.PanTituloMisAutores.Controls.Add(this.LblTituloMisAutores);
            this.PanTituloMisAutores.Controls.Add(this.MPcbMisAutores);
            this.PanTituloMisAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMisAutores.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMisAutores.Name = "PanTituloMisAutores";
            this.PanTituloMisAutores.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMisAutores.TabIndex = 0;
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
            // LblTituloMisAutores
            // 
            this.LblTituloMisAutores.AutoSize = true;
            this.LblTituloMisAutores.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMisAutores.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloMisAutores.Location = new System.Drawing.Point(75, 18);
            this.LblTituloMisAutores.Name = "LblTituloMisAutores";
            this.LblTituloMisAutores.Size = new System.Drawing.Size(152, 32);
            this.LblTituloMisAutores.TabIndex = 10;
            this.LblTituloMisAutores.Text = "Mis Autores";
            // 
            // MPcbMisAutores
            // 
            this.MPcbMisAutores.BackColor = System.Drawing.Color.Transparent;
            this.MPcbMisAutores.ForeColor = System.Drawing.Color.Navy;
            this.MPcbMisAutores.IconChar = FontAwesome.Sharp.MaterialIcons.AccountGroup;
            this.MPcbMisAutores.IconColor = System.Drawing.Color.Navy;
            this.MPcbMisAutores.IconSize = 40;
            this.MPcbMisAutores.Location = new System.Drawing.Point(40, 15);
            this.MPcbMisAutores.Name = "MPcbMisAutores";
            this.MPcbMisAutores.Size = new System.Drawing.Size(40, 40);
            this.MPcbMisAutores.TabIndex = 12;
            this.MPcbMisAutores.TabStop = false;
            // 
            // PanBusquedaMAU
            // 
            this.PanBusquedaMAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMAU.Controls.Add(this.MBtnBuscarMAU);
            this.PanBusquedaMAU.Controls.Add(this.KTxtBuscarAutorMAU);
            this.PanBusquedaMAU.Controls.Add(this.MBtnOrdenMAU);
            this.PanBusquedaMAU.Controls.Add(this.KCmbOrdenPorMAU);
            this.PanBusquedaMAU.Controls.Add(this.LblOrdenarMAU);
            this.PanBusquedaMAU.Controls.Add(this.MBtnBorrarAutorMAU);
            this.PanBusquedaMAU.Controls.Add(this.MBtnMasAutorMAU);
            this.PanBusquedaMAU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMAU.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMAU.Name = "PanBusquedaMAU";
            this.PanBusquedaMAU.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMAU.TabIndex = 1;
            // 
            // MBtnBuscarMAU
            // 
            this.MBtnBuscarMAU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnBuscarMAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMAU.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMAU.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMAU.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMAU.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMAU.IconSize = 30;
            this.MBtnBuscarMAU.Location = new System.Drawing.Point(878, 11);
            this.MBtnBuscarMAU.Name = "MBtnBuscarMAU";
            this.MBtnBuscarMAU.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMAU.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarMAU.TabIndex = 126;
            this.MBtnBuscarMAU.UseVisualStyleBackColor = true;
            // 
            // KTxtBuscarAutorMAU
            // 
            this.KTxtBuscarAutorMAU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KTxtBuscarAutorMAU.Location = new System.Drawing.Point(673, 4);
            this.KTxtBuscarAutorMAU.Name = "KTxtBuscarAutorMAU";
            this.KTxtBuscarAutorMAU.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarAutorMAU.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarAutorMAU.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarAutorMAU.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarAutorMAU.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarAutorMAU.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarAutorMAU.StateCommon.Border.Width = 2;
            this.KTxtBuscarAutorMAU.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarAutorMAU.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarAutorMAU.TabIndex = 125;
            // 
            // MBtnOrdenMAU
            // 
            this.MBtnOrdenMAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMAU.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMAU.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMAU.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMAU.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMAU.IconSize = 40;
            this.MBtnOrdenMAU.Location = new System.Drawing.Point(390, 5);
            this.MBtnOrdenMAU.Name = "MBtnOrdenMAU";
            this.MBtnOrdenMAU.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrdenMAU.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrdenMAU.TabIndex = 109;
            this.MBtnOrdenMAU.UseVisualStyleBackColor = true;
            // 
            // KCmbOrdenPorMAU
            // 
            this.KCmbOrdenPorMAU.DropDownWidth = 228;
            this.KCmbOrdenPorMAU.Location = new System.Drawing.Point(217, 4);
            this.KCmbOrdenPorMAU.Name = "KCmbOrdenPorMAU";
            this.KCmbOrdenPorMAU.Size = new System.Drawing.Size(161, 33);
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMAU.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMAU.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMAU.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMAU.TabIndex = 108;
            // 
            // LblOrdenarMAU
            // 
            this.LblOrdenarMAU.AutoSize = true;
            this.LblOrdenarMAU.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenarMAU.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblOrdenarMAU.Location = new System.Drawing.Point(120, 11);
            this.LblOrdenarMAU.Name = "LblOrdenarMAU";
            this.LblOrdenarMAU.Size = new System.Drawing.Size(91, 18);
            this.LblOrdenarMAU.TabIndex = 8;
            this.LblOrdenarMAU.Text = "Ordenar por:";
            // 
            // MBtnBorrarAutorMAU
            // 
            this.MBtnBorrarAutorMAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarAutorMAU.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarAutorMAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarAutorMAU.IconChar = FontAwesome.Sharp.MaterialIcons.Delete;
            this.MBtnBorrarAutorMAU.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBorrarAutorMAU.IconSize = 40;
            this.MBtnBorrarAutorMAU.Location = new System.Drawing.Point(76, 5);
            this.MBtnBorrarAutorMAU.Name = "MBtnBorrarAutorMAU";
            this.MBtnBorrarAutorMAU.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBorrarAutorMAU.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarAutorMAU.TabIndex = 7;
            this.MBtnBorrarAutorMAU.UseVisualStyleBackColor = true;
            // 
            // MBtnMasAutorMAU
            // 
            this.MBtnMasAutorMAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasAutorMAU.FlatAppearance.BorderSize = 0;
            this.MBtnMasAutorMAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasAutorMAU.IconChar = FontAwesome.Sharp.MaterialIcons.Plus;
            this.MBtnMasAutorMAU.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMasAutorMAU.IconSize = 40;
            this.MBtnMasAutorMAU.Location = new System.Drawing.Point(40, 5);
            this.MBtnMasAutorMAU.Name = "MBtnMasAutorMAU";
            this.MBtnMasAutorMAU.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasAutorMAU.TabIndex = 6;
            this.MBtnMasAutorMAU.UseVisualStyleBackColor = true;
            this.MBtnMasAutorMAU.Click += new System.EventHandler(this.MBtnMasAutorMAU_Click);
            // 
            // ImgListAutoresMAU
            // 
            this.ImgListAutoresMAU.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListAutoresMAU.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListAutoresMAU.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PanLsvMAU
            // 
            this.PanLsvMAU.Controls.Add(this.PanNumAutoresMAU);
            this.PanLsvMAU.Controls.Add(this.LsvMisAutoresMAU);
            this.PanLsvMAU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLsvMAU.Location = new System.Drawing.Point(0, 104);
            this.PanLsvMAU.Name = "PanLsvMAU";
            this.PanLsvMAU.Size = new System.Drawing.Size(948, 589);
            this.PanLsvMAU.TabIndex = 2;
            // 
            // PanNumAutoresMAU
            // 
            this.PanNumAutoresMAU.BackColor = System.Drawing.Color.Navy;
            this.PanNumAutoresMAU.Controls.Add(this.LblPonerNumAutoresMAU);
            this.PanNumAutoresMAU.Controls.Add(this.LblNumAutoresMAU);
            this.PanNumAutoresMAU.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanNumAutoresMAU.Location = new System.Drawing.Point(0, 544);
            this.PanNumAutoresMAU.Name = "PanNumAutoresMAU";
            this.PanNumAutoresMAU.Size = new System.Drawing.Size(948, 45);
            this.PanNumAutoresMAU.TabIndex = 1;
            // 
            // LblPonerNumAutoresMAU
            // 
            this.LblPonerNumAutoresMAU.AutoSize = true;
            this.LblPonerNumAutoresMAU.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPonerNumAutoresMAU.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPonerNumAutoresMAU.Location = new System.Drawing.Point(172, 15);
            this.LblPonerNumAutoresMAU.Name = "LblPonerNumAutoresMAU";
            this.LblPonerNumAutoresMAU.Size = new System.Drawing.Size(0, 18);
            this.LblPonerNumAutoresMAU.TabIndex = 10;
            // 
            // LblNumAutoresMAU
            // 
            this.LblNumAutoresMAU.AutoSize = true;
            this.LblNumAutoresMAU.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumAutoresMAU.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNumAutoresMAU.Location = new System.Drawing.Point(37, 15);
            this.LblNumAutoresMAU.Name = "LblNumAutoresMAU";
            this.LblNumAutoresMAU.Size = new System.Drawing.Size(136, 18);
            this.LblNumAutoresMAU.TabIndex = 9;
            this.LblNumAutoresMAU.Text = "Número de autores:";
            // 
            // LsvMisAutoresMAU
            // 
            this.LsvMisAutoresMAU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvMisAutoresMAU.BackColor = System.Drawing.Color.Navy;
            this.LsvMisAutoresMAU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvMisAutoresMAU.Font = new System.Drawing.Font("Merienda One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvMisAutoresMAU.ForeColor = System.Drawing.Color.Gainsboro;
            this.LsvMisAutoresMAU.HideSelection = false;
            this.LsvMisAutoresMAU.Location = new System.Drawing.Point(40, 40);
            this.LsvMisAutoresMAU.Name = "LsvMisAutoresMAU";
            this.LsvMisAutoresMAU.Size = new System.Drawing.Size(868, 458);
            this.LsvMisAutoresMAU.TabIndex = 0;
            this.LsvMisAutoresMAU.UseCompatibleStateImageBehavior = false;
            // 
            // FrmMisAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanLsvMAU);
            this.Controls.Add(this.PanBusquedaMAU);
            this.Controls.Add(this.PanTituloMisAutores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMisAutores";
            this.Text = "FrmMisAutores";
            this.PanTituloMisAutores.ResumeLayout(false);
            this.PanTituloMisAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisAutores)).EndInit();
            this.PanBusquedaMAU.ResumeLayout(false);
            this.PanBusquedaMAU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMAU)).EndInit();
            this.PanLsvMAU.ResumeLayout(false);
            this.PanNumAutoresMAU.ResumeLayout(false);
            this.PanNumAutoresMAU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloMisAutores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloMisAutores;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbMisAutores;
        private System.Windows.Forms.Panel PanBusquedaMAU;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMAU;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOrdenPorMAU;
        private System.Windows.Forms.Label LblOrdenarMAU;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarAutorMAU;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasAutorMAU;
        private System.Windows.Forms.ImageList ImgListAutoresMAU;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMAU;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarAutorMAU;
        private System.Windows.Forms.Panel PanLsvMAU;
        private System.Windows.Forms.ListView LsvMisAutoresMAU;
        private System.Windows.Forms.Panel PanNumAutoresMAU;
        private System.Windows.Forms.Label LblPonerNumAutoresMAU;
        private System.Windows.Forms.Label LblNumAutoresMAU;
    }
}