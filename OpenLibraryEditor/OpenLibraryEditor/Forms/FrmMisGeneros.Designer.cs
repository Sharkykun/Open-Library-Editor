namespace OpenLibraryEditor.Forms
{
    partial class FrmMisGeneros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMisGeneros));
            this.PanTreeMGE = new System.Windows.Forms.Panel();
            this.TrvGenerosMGE = new System.Windows.Forms.TreeView();
            this.PanNumGenerosMGE = new System.Windows.Forms.Panel();
            this.LblPonerNumGenerosMGE = new System.Windows.Forms.Label();
            this.LblNumGenerosMGE = new System.Windows.Forms.Label();
            this.PanBusquedaMGE = new System.Windows.Forms.Panel();
            this.MBtnBuscarMGE = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarGeneroMGE = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnOrdenMGE = new FontAwesome.Sharp.Material.MaterialButton();
            this.KCmbOrdenPorMGE = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblOrdenarMGE = new System.Windows.Forms.Label();
            this.MBtnBorrarGeneroMGE = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMasGeneroMGE = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanTituloMisGeneros = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloMisGeneros = new System.Windows.Forms.Label();
            this.MPcbMisGeneros = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.ImgListGenerosMGE = new System.Windows.Forms.ImageList(this.components);
            this.PanTreeMGE.SuspendLayout();
            this.PanNumGenerosMGE.SuspendLayout();
            this.PanBusquedaMGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMGE)).BeginInit();
            this.PanTituloMisGeneros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTreeMGE
            // 
            this.PanTreeMGE.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTreeMGE.Controls.Add(this.TrvGenerosMGE);
            this.PanTreeMGE.Controls.Add(this.PanNumGenerosMGE);
            this.PanTreeMGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanTreeMGE.Location = new System.Drawing.Point(0, 104);
            this.PanTreeMGE.Name = "PanTreeMGE";
            this.PanTreeMGE.Size = new System.Drawing.Size(948, 589);
            this.PanTreeMGE.TabIndex = 8;
            // 
            // TrvGenerosMGE
            // 
            this.TrvGenerosMGE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvGenerosMGE.BackColor = System.Drawing.Color.Navy;
            this.TrvGenerosMGE.Location = new System.Drawing.Point(0, 0);
            this.TrvGenerosMGE.Name = "TrvGenerosMGE";
            this.TrvGenerosMGE.Size = new System.Drawing.Size(260, 546);
            this.TrvGenerosMGE.TabIndex = 2;
            // 
            // PanNumGenerosMGE
            // 
            this.PanNumGenerosMGE.BackColor = System.Drawing.Color.Navy;
            this.PanNumGenerosMGE.Controls.Add(this.LblPonerNumGenerosMGE);
            this.PanNumGenerosMGE.Controls.Add(this.LblNumGenerosMGE);
            this.PanNumGenerosMGE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanNumGenerosMGE.Location = new System.Drawing.Point(0, 544);
            this.PanNumGenerosMGE.Name = "PanNumGenerosMGE";
            this.PanNumGenerosMGE.Size = new System.Drawing.Size(948, 45);
            this.PanNumGenerosMGE.TabIndex = 1;
            // 
            // LblPonerNumGenerosMGE
            // 
            this.LblPonerNumGenerosMGE.AutoSize = true;
            this.LblPonerNumGenerosMGE.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPonerNumGenerosMGE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPonerNumGenerosMGE.Location = new System.Drawing.Point(172, 15);
            this.LblPonerNumGenerosMGE.Name = "LblPonerNumGenerosMGE";
            this.LblPonerNumGenerosMGE.Size = new System.Drawing.Size(0, 18);
            this.LblPonerNumGenerosMGE.TabIndex = 10;
            // 
            // LblNumGenerosMGE
            // 
            this.LblNumGenerosMGE.AutoSize = true;
            this.LblNumGenerosMGE.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumGenerosMGE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblNumGenerosMGE.Location = new System.Drawing.Point(37, 15);
            this.LblNumGenerosMGE.Name = "LblNumGenerosMGE";
            this.LblNumGenerosMGE.Size = new System.Drawing.Size(138, 18);
            this.LblNumGenerosMGE.TabIndex = 9;
            this.LblNumGenerosMGE.Text = "Número de géneros:";
            // 
            // PanBusquedaMGE
            // 
            this.PanBusquedaMGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMGE.Controls.Add(this.MBtnBuscarMGE);
            this.PanBusquedaMGE.Controls.Add(this.KTxtBuscarGeneroMGE);
            this.PanBusquedaMGE.Controls.Add(this.MBtnOrdenMGE);
            this.PanBusquedaMGE.Controls.Add(this.KCmbOrdenPorMGE);
            this.PanBusquedaMGE.Controls.Add(this.LblOrdenarMGE);
            this.PanBusquedaMGE.Controls.Add(this.MBtnBorrarGeneroMGE);
            this.PanBusquedaMGE.Controls.Add(this.MBtnMasGeneroMGE);
            this.PanBusquedaMGE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMGE.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMGE.Name = "PanBusquedaMGE";
            this.PanBusquedaMGE.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMGE.TabIndex = 7;
            // 
            // MBtnBuscarMGE
            // 
            this.MBtnBuscarMGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MBtnBuscarMGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarMGE.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarMGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarMGE.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMGE.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarMGE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarMGE.IconSize = 30;
            this.MBtnBuscarMGE.Location = new System.Drawing.Point(878, 11);
            this.MBtnBuscarMGE.Name = "MBtnBuscarMGE";
            this.MBtnBuscarMGE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarMGE.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarMGE.TabIndex = 126;
            this.MBtnBuscarMGE.UseVisualStyleBackColor = true;
            // 
            // KTxtBuscarGeneroMGE
            // 
            this.KTxtBuscarGeneroMGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KTxtBuscarGeneroMGE.Location = new System.Drawing.Point(673, 4);
            this.KTxtBuscarGeneroMGE.Name = "KTxtBuscarGeneroMGE";
            this.KTxtBuscarGeneroMGE.Size = new System.Drawing.Size(235, 33);
            this.KTxtBuscarGeneroMGE.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarGeneroMGE.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarGeneroMGE.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarGeneroMGE.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarGeneroMGE.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarGeneroMGE.StateCommon.Border.Width = 2;
            this.KTxtBuscarGeneroMGE.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarGeneroMGE.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarGeneroMGE.TabIndex = 125;
            // 
            // MBtnOrdenMGE
            // 
            this.MBtnOrdenMGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnOrdenMGE.FlatAppearance.BorderSize = 0;
            this.MBtnOrdenMGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnOrdenMGE.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMGE.IconChar = FontAwesome.Sharp.MaterialIcons.OrderAlphabeticalAscending;
            this.MBtnOrdenMGE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnOrdenMGE.IconSize = 40;
            this.MBtnOrdenMGE.Location = new System.Drawing.Point(390, 5);
            this.MBtnOrdenMGE.Name = "MBtnOrdenMGE";
            this.MBtnOrdenMGE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnOrdenMGE.Size = new System.Drawing.Size(30, 30);
            this.MBtnOrdenMGE.TabIndex = 109;
            this.MBtnOrdenMGE.UseVisualStyleBackColor = true;
            // 
            // KCmbOrdenPorMGE
            // 
            this.KCmbOrdenPorMGE.DropDownWidth = 228;
            this.KCmbOrdenPorMGE.Location = new System.Drawing.Point(217, 4);
            this.KCmbOrdenPorMGE.Name = "KCmbOrdenPorMGE";
            this.KCmbOrdenPorMGE.Size = new System.Drawing.Size(161, 33);
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMGE.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMGE.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbOrdenPorMGE.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOrdenPorMGE.TabIndex = 108;
            // 
            // LblOrdenarMGE
            // 
            this.LblOrdenarMGE.AutoSize = true;
            this.LblOrdenarMGE.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenarMGE.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblOrdenarMGE.Location = new System.Drawing.Point(120, 11);
            this.LblOrdenarMGE.Name = "LblOrdenarMGE";
            this.LblOrdenarMGE.Size = new System.Drawing.Size(91, 18);
            this.LblOrdenarMGE.TabIndex = 8;
            this.LblOrdenarMGE.Text = "Ordenar por:";
            // 
            // MBtnBorrarGeneroMGE
            // 
            this.MBtnBorrarGeneroMGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarGeneroMGE.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarGeneroMGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarGeneroMGE.IconChar = FontAwesome.Sharp.MaterialIcons.Delete;
            this.MBtnBorrarGeneroMGE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBorrarGeneroMGE.IconSize = 40;
            this.MBtnBorrarGeneroMGE.Location = new System.Drawing.Point(76, 5);
            this.MBtnBorrarGeneroMGE.Name = "MBtnBorrarGeneroMGE";
            this.MBtnBorrarGeneroMGE.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBorrarGeneroMGE.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarGeneroMGE.TabIndex = 7;
            this.MBtnBorrarGeneroMGE.UseVisualStyleBackColor = true;
            // 
            // MBtnMasGeneroMGE
            // 
            this.MBtnMasGeneroMGE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasGeneroMGE.FlatAppearance.BorderSize = 0;
            this.MBtnMasGeneroMGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasGeneroMGE.IconChar = FontAwesome.Sharp.MaterialIcons.Plus;
            this.MBtnMasGeneroMGE.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMasGeneroMGE.IconSize = 40;
            this.MBtnMasGeneroMGE.Location = new System.Drawing.Point(40, 5);
            this.MBtnMasGeneroMGE.Name = "MBtnMasGeneroMGE";
            this.MBtnMasGeneroMGE.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasGeneroMGE.TabIndex = 6;
            this.MBtnMasGeneroMGE.UseVisualStyleBackColor = true;
            this.MBtnMasGeneroMGE.Click += new System.EventHandler(this.MBtnMasGeneroMGE_Click);
            // 
            // PanTituloMisGeneros
            // 
            this.PanTituloMisGeneros.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTituloMisGeneros.Controls.Add(this.panel2);
            this.PanTituloMisGeneros.Controls.Add(this.LblTituloMisGeneros);
            this.PanTituloMisGeneros.Controls.Add(this.MPcbMisGeneros);
            this.PanTituloMisGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMisGeneros.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMisGeneros.Name = "PanTituloMisGeneros";
            this.PanTituloMisGeneros.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMisGeneros.TabIndex = 6;
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
            // LblTituloMisGeneros
            // 
            this.LblTituloMisGeneros.AutoSize = true;
            this.LblTituloMisGeneros.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMisGeneros.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloMisGeneros.Location = new System.Drawing.Point(75, 18);
            this.LblTituloMisGeneros.Name = "LblTituloMisGeneros";
            this.LblTituloMisGeneros.Size = new System.Drawing.Size(158, 32);
            this.LblTituloMisGeneros.TabIndex = 10;
            this.LblTituloMisGeneros.Text = "Mis Géneros";
            // 
            // MPcbMisGeneros
            // 
            this.MPcbMisGeneros.BackColor = System.Drawing.Color.Transparent;
            this.MPcbMisGeneros.ForeColor = System.Drawing.Color.Navy;
            this.MPcbMisGeneros.IconChar = FontAwesome.Sharp.MaterialIcons.DramaMasks;
            this.MPcbMisGeneros.IconColor = System.Drawing.Color.Navy;
            this.MPcbMisGeneros.IconSize = 40;
            this.MPcbMisGeneros.Location = new System.Drawing.Point(40, 15);
            this.MPcbMisGeneros.Name = "MPcbMisGeneros";
            this.MPcbMisGeneros.Size = new System.Drawing.Size(40, 40);
            this.MPcbMisGeneros.TabIndex = 12;
            this.MPcbMisGeneros.TabStop = false;
            // 
            // ImgListGenerosMGE
            // 
            this.ImgListGenerosMGE.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListGenerosMGE.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListGenerosMGE.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMisGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanTreeMGE);
            this.Controls.Add(this.PanBusquedaMGE);
            this.Controls.Add(this.PanTituloMisGeneros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMisGeneros";
            this.Text = "FrmMisGeneros";
            this.PanTreeMGE.ResumeLayout(false);
            this.PanNumGenerosMGE.ResumeLayout(false);
            this.PanNumGenerosMGE.PerformLayout();
            this.PanBusquedaMGE.ResumeLayout(false);
            this.PanBusquedaMGE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOrdenPorMGE)).EndInit();
            this.PanTituloMisGeneros.ResumeLayout(false);
            this.PanTituloMisGeneros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbMisGeneros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTreeMGE;
        private System.Windows.Forms.TreeView TrvGenerosMGE;
        private System.Windows.Forms.Panel PanNumGenerosMGE;
        private System.Windows.Forms.Label LblPonerNumGenerosMGE;
        private System.Windows.Forms.Label LblNumGenerosMGE;
        private System.Windows.Forms.Panel PanBusquedaMGE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarMGE;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarGeneroMGE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnOrdenMGE;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOrdenPorMGE;
        private System.Windows.Forms.Label LblOrdenarMGE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarGeneroMGE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasGeneroMGE;
        private System.Windows.Forms.Panel PanTituloMisGeneros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloMisGeneros;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbMisGeneros;
        private System.Windows.Forms.ImageList ImgListGenerosMGE;
    }
}