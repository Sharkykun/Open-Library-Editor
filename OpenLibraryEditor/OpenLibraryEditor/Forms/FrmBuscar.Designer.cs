namespace OpenLibraryEditor.Forms
{
    partial class FrmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.PanBusquedaMBI = new System.Windows.Forms.Panel();
            this.MBtnBuscarBUS = new FontAwesome.Sharp.Material.MaterialButton();
            this.KTxtBuscarBUS = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KCmbServidoresBUS = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblBuscarPorBUS = new System.Windows.Forms.Label();
            this.PanTituloMiBiblioteca = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloBuscar = new System.Windows.Forms.Label();
            this.MPcbBuscar = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.KCmbTipoBusquedaBUS = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.PanBusquedaMBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbServidoresBUS)).BeginInit();
            this.PanTituloMiBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoBusquedaBUS)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBusquedaMBI
            // 
            this.PanBusquedaMBI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanBusquedaMBI.Controls.Add(this.KCmbTipoBusquedaBUS);
            this.PanBusquedaMBI.Controls.Add(this.MBtnBuscarBUS);
            this.PanBusquedaMBI.Controls.Add(this.KTxtBuscarBUS);
            this.PanBusquedaMBI.Controls.Add(this.KCmbServidoresBUS);
            this.PanBusquedaMBI.Controls.Add(this.LblBuscarPorBUS);
            this.PanBusquedaMBI.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBusquedaMBI.Location = new System.Drawing.Point(0, 64);
            this.PanBusquedaMBI.Name = "PanBusquedaMBI";
            this.PanBusquedaMBI.Size = new System.Drawing.Size(948, 40);
            this.PanBusquedaMBI.TabIndex = 11;
            // 
            // MBtnBuscarBUS
            // 
            this.MBtnBuscarBUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarBUS.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarBUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarBUS.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarBUS.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarBUS.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarBUS.IconSize = 30;
            this.MBtnBuscarBUS.Location = new System.Drawing.Point(796, 10);
            this.MBtnBuscarBUS.Name = "MBtnBuscarBUS";
            this.MBtnBuscarBUS.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarBUS.Size = new System.Drawing.Size(20, 20);
            this.MBtnBuscarBUS.TabIndex = 126;
            this.MBtnBuscarBUS.UseVisualStyleBackColor = true;
            this.MBtnBuscarBUS.Click += new System.EventHandler(this.MBtnBuscarBUS_Click);
            // 
            // KTxtBuscarBUS
            // 
            this.KTxtBuscarBUS.Location = new System.Drawing.Point(478, 3);
            this.KTxtBuscarBUS.Name = "KTxtBuscarBUS";
            this.KTxtBuscarBUS.Size = new System.Drawing.Size(349, 33);
            this.KTxtBuscarBUS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KTxtBuscarBUS.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarBUS.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarBUS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarBUS.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarBUS.StateCommon.Border.Width = 2;
            this.KTxtBuscarBUS.StateCommon.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KTxtBuscarBUS.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarBUS.TabIndex = 125;
            // 
            // KCmbServidoresBUS
            // 
            this.KCmbServidoresBUS.DropDownWidth = 160;
            this.KCmbServidoresBUS.Location = new System.Drawing.Point(138, 4);
            this.KCmbServidoresBUS.Name = "KCmbServidoresBUS";
            this.KCmbServidoresBUS.Size = new System.Drawing.Size(161, 33);
            this.KCmbServidoresBUS.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbServidoresBUS.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbServidoresBUS.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbServidoresBUS.TabIndex = 108;
            this.KCmbServidoresBUS.SelectedIndexChanged += new System.EventHandler(this.KCmbServidoresBUS_SelectedIndexChanged);
            // 
            // LblBuscarPorBUS
            // 
            this.LblBuscarPorBUS.AutoSize = true;
            this.LblBuscarPorBUS.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarPorBUS.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblBuscarPorBUS.Location = new System.Drawing.Point(41, 11);
            this.LblBuscarPorBUS.Name = "LblBuscarPorBUS";
            this.LblBuscarPorBUS.Size = new System.Drawing.Size(76, 18);
            this.LblBuscarPorBUS.TabIndex = 8;
            this.LblBuscarPorBUS.Text = "Buscar en:";
            // 
            // PanTituloMiBiblioteca
            // 
            this.PanTituloMiBiblioteca.BackColor = System.Drawing.Color.Gainsboro;
            this.PanTituloMiBiblioteca.Controls.Add(this.panel2);
            this.PanTituloMiBiblioteca.Controls.Add(this.LblTituloBuscar);
            this.PanTituloMiBiblioteca.Controls.Add(this.MPcbBuscar);
            this.PanTituloMiBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloMiBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.PanTituloMiBiblioteca.Name = "PanTituloMiBiblioteca";
            this.PanTituloMiBiblioteca.Size = new System.Drawing.Size(948, 64);
            this.PanTituloMiBiblioteca.TabIndex = 10;
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
            // LblTituloBuscar
            // 
            this.LblTituloBuscar.AutoSize = true;
            this.LblTituloBuscar.Font = new System.Drawing.Font("Merienda One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloBuscar.ForeColor = System.Drawing.Color.Navy;
            this.LblTituloBuscar.Location = new System.Drawing.Point(75, 18);
            this.LblTituloBuscar.Name = "LblTituloBuscar";
            this.LblTituloBuscar.Size = new System.Drawing.Size(96, 32);
            this.LblTituloBuscar.TabIndex = 10;
            this.LblTituloBuscar.Text = "Buscar";
            // 
            // MPcbBuscar
            // 
            this.MPcbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.MPcbBuscar.ForeColor = System.Drawing.Color.Navy;
            this.MPcbBuscar.IconChar = FontAwesome.Sharp.MaterialIcons.MagnifyExpand;
            this.MPcbBuscar.IconColor = System.Drawing.Color.Navy;
            this.MPcbBuscar.IconSize = 40;
            this.MPcbBuscar.Location = new System.Drawing.Point(40, 15);
            this.MPcbBuscar.Name = "MPcbBuscar";
            this.MPcbBuscar.Size = new System.Drawing.Size(40, 40);
            this.MPcbBuscar.TabIndex = 12;
            this.MPcbBuscar.TabStop = false;
            // 
            // KCmbTipoBusquedaBUS
            // 
            this.KCmbTipoBusquedaBUS.DropDownWidth = 160;
            this.KCmbTipoBusquedaBUS.Location = new System.Drawing.Point(307, 3);
            this.KCmbTipoBusquedaBUS.Name = "KCmbTipoBusquedaBUS";
            this.KCmbTipoBusquedaBUS.Size = new System.Drawing.Size(161, 33);
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoBusquedaBUS.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro;
            this.KCmbTipoBusquedaBUS.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoBusquedaBUS.TabIndex = 127;
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanBusquedaMBI);
            this.Controls.Add(this.PanTituloMiBiblioteca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            this.PanBusquedaMBI.ResumeLayout(false);
            this.PanBusquedaMBI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbServidoresBUS)).EndInit();
            this.PanTituloMiBiblioteca.ResumeLayout(false);
            this.PanTituloMiBiblioteca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoBusquedaBUS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBusquedaMBI;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarBUS;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarBUS;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbServidoresBUS;
        private System.Windows.Forms.Label LblBuscarPorBUS;
        private System.Windows.Forms.Panel PanTituloMiBiblioteca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloBuscar;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbBuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbTipoBusquedaBUS;
    }
}