namespace OpenLibraryEditor.Controles
{
    partial class TxtBusqueda
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.KTxtBuscarMBI = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MbtnBorrarTxtBuscar = new FontAwesome.Sharp.Material.MaterialButton();
            this.SuspendLayout();
            // 
            // KTxtBuscarMBI
            // 
            this.KTxtBuscarMBI.Location = new System.Drawing.Point(0, 1);
            this.KTxtBuscarMBI.Margin = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.KTxtBuscarMBI.Name = "KTxtBuscarMBI";
            this.KTxtBuscarMBI.Size = new System.Drawing.Size(263, 33);
            this.KTxtBuscarMBI.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.KTxtBuscarMBI.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarMBI.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarMBI.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarMBI.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarMBI.StateCommon.Border.Width = 2;
            this.KTxtBuscarMBI.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarMBI.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarMBI.TabIndex = 131;
            this.KTxtBuscarMBI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KTxtBuscarMBI_KeyDown);
            // 
            // MbtnBorrarTxtBuscar
            // 
            this.MbtnBorrarTxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.MbtnBorrarTxtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MbtnBorrarTxtBuscar.FlatAppearance.BorderSize = 0;
            this.MbtnBorrarTxtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbtnBorrarTxtBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.MbtnBorrarTxtBuscar.IconChar = FontAwesome.Sharp.MaterialIcons.Close;
            this.MbtnBorrarTxtBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MbtnBorrarTxtBuscar.IconSize = 30;
            this.MbtnBorrarTxtBuscar.Location = new System.Drawing.Point(234, 7);
            this.MbtnBorrarTxtBuscar.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.MbtnBorrarTxtBuscar.Name = "MbtnBorrarTxtBuscar";
            this.MbtnBorrarTxtBuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MbtnBorrarTxtBuscar.Size = new System.Drawing.Size(20, 20);
            this.MbtnBorrarTxtBuscar.TabIndex = 135;
            this.MbtnBorrarTxtBuscar.UseVisualStyleBackColor = false;
            this.MbtnBorrarTxtBuscar.Click += new System.EventHandler(this.MbtnBorrarTxtBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.MbtnBorrarTxtBuscar);
            this.Controls.Add(this.KTxtBuscarMBI);
            this.Name = "TxtBusqueda";
            this.Size = new System.Drawing.Size(263, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarMBI;
        private FontAwesome.Sharp.Material.MaterialButton MbtnBorrarTxtBuscar;
    }
}
