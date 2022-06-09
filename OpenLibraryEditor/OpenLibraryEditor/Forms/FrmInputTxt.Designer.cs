namespace OpenLibraryEditor.Forms
{
    partial class FrmInputTxt
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBtnModificar = new Guna.UI.WinForms.GunaButton();
            this.PanTituloAutores = new System.Windows.Forms.Panel();
            this.MBtnCerrarAutores = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcbLogoAutores = new System.Windows.Forms.PictureBox();
            this.PanBtn = new System.Windows.Forms.Panel();
            this.GBtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.GBtnGuardar = new Guna.UI.WinForms.GunaButton();
            this.LblNombre = new System.Windows.Forms.Label();
            this.KTxtNombreTipo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TTInput = new System.Windows.Forms.ToolTip(this.components);
            this.PanTituloAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).BeginInit();
            this.PanBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(473, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 183);
            this.panel2.TabIndex = 151;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 183);
            this.panel1.TabIndex = 150;
            // 
            // GBtnModificar
            // 
            this.GBtnModificar.AnimationHoverSpeed = 0.07F;
            this.GBtnModificar.AnimationSpeed = 0.03F;
            this.GBtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnModificar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnModificar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnModificar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnModificar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnModificar.Image = null;
            this.GBtnModificar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnModificar.Location = new System.Drawing.Point(172, 5);
            this.GBtnModificar.Name = "GBtnModificar";
            this.GBtnModificar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnModificar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnModificar.OnHoverForeColor = System.Drawing.Color.Black;
            this.GBtnModificar.OnHoverImage = null;
            this.GBtnModificar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnModificar.Radius = 15;
            this.GBtnModificar.Size = new System.Drawing.Size(126, 35);
            this.GBtnModificar.TabIndex = 1;
            this.GBtnModificar.Text = "Modificar";
            this.GBtnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnModificar.Click += new System.EventHandler(this.GBtnModificar_Click);
            // 
            // PanTituloAutores
            // 
            this.PanTituloAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloAutores.Controls.Add(this.MBtnCerrarAutores);
            this.PanTituloAutores.Controls.Add(this.LblTitulo);
            this.PanTituloAutores.Controls.Add(this.PcbLogoAutores);
            this.PanTituloAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloAutores.Location = new System.Drawing.Point(0, 0);
            this.PanTituloAutores.Name = "PanTituloAutores";
            this.PanTituloAutores.Size = new System.Drawing.Size(476, 40);
            this.PanTituloAutores.TabIndex = 148;
            this.PanTituloAutores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
            // 
            // MBtnCerrarAutores
            // 
            this.MBtnCerrarAutores.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarAutores.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarAutores.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarAutores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarAutores.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarAutores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarAutores.IconSize = 40;
            this.MBtnCerrarAutores.Location = new System.Drawing.Point(444, 0);
            this.MBtnCerrarAutores.Name = "MBtnCerrarAutores";
            this.MBtnCerrarAutores.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarAutores.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarAutores.TabIndex = 0;
            this.MBtnCerrarAutores.UseVisualStyleBackColor = false;
            this.MBtnCerrarAutores.Click += new System.EventHandler(this.MBtnCerrarAutores_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTitulo.Location = new System.Drawing.Point(54, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(338, 23);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Open Library Editor - Añadir tipo de libro";
            this.LblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
            // 
            // PcbLogoAutores
            // 
            this.PcbLogoAutores.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoAutores.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoAutores.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoAutores.Name = "PcbLogoAutores";
            this.PcbLogoAutores.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoAutores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoAutores.TabIndex = 3;
            this.PcbLogoAutores.TabStop = false;
            this.PcbLogoAutores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
            // 
            // PanBtn
            // 
            this.PanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtn.Controls.Add(this.GBtnEliminar);
            this.PanBtn.Controls.Add(this.GBtnGuardar);
            this.PanBtn.Controls.Add(this.GBtnModificar);
            this.PanBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtn.Location = new System.Drawing.Point(3, 178);
            this.PanBtn.Name = "PanBtn";
            this.PanBtn.Size = new System.Drawing.Size(470, 45);
            this.PanBtn.TabIndex = 152;
            // 
            // GBtnEliminar
            // 
            this.GBtnEliminar.AnimationHoverSpeed = 0.07F;
            this.GBtnEliminar.AnimationSpeed = 0.03F;
            this.GBtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnEliminar.BaseColor = System.Drawing.Color.DarkGray;
            this.GBtnEliminar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnEliminar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnEliminar.Image = null;
            this.GBtnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnEliminar.Location = new System.Drawing.Point(303, 5);
            this.GBtnEliminar.Name = "GBtnEliminar";
            this.GBtnEliminar.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.GBtnEliminar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnEliminar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnEliminar.OnHoverImage = null;
            this.GBtnEliminar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnEliminar.Radius = 15;
            this.GBtnEliminar.Size = new System.Drawing.Size(126, 35);
            this.GBtnEliminar.TabIndex = 2;
            this.GBtnEliminar.Text = "Eliminar";
            this.GBtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnEliminar.Click += new System.EventHandler(this.GBtnEliminar_Click);
            // 
            // GBtnGuardar
            // 
            this.GBtnGuardar.AnimationHoverSpeed = 0.07F;
            this.GBtnGuardar.AnimationSpeed = 0.03F;
            this.GBtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnGuardar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnGuardar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnGuardar.Image = null;
            this.GBtnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnGuardar.Location = new System.Drawing.Point(41, 5);
            this.GBtnGuardar.Name = "GBtnGuardar";
            this.GBtnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnGuardar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnGuardar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnGuardar.OnHoverImage = null;
            this.GBtnGuardar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnGuardar.Radius = 15;
            this.GBtnGuardar.Size = new System.Drawing.Size(126, 35);
            this.GBtnGuardar.TabIndex = 0;
            this.GBtnGuardar.Text = "Guardar";
            this.GBtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnGuardar.Click += new System.EventHandler(this.GBtnGuardar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblNombre.Location = new System.Drawing.Point(101, 62);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(266, 22);
            this.LblNombre.TabIndex = 153;
            this.LblNombre.Text = "Escribe el nombre del tipo de libro";
            // 
            // KTxtNombreTipo
            // 
            this.KTxtNombreTipo.Location = new System.Drawing.Point(44, 95);
            this.KTxtNombreTipo.Name = "KTxtNombreTipo";
            this.KTxtNombreTipo.Size = new System.Drawing.Size(388, 33);
            this.KTxtNombreTipo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreTipo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreTipo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreTipo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreTipo.StateCommon.Border.Rounding = 10;
            this.KTxtNombreTipo.StateCommon.Border.Width = 2;
            this.KTxtNombreTipo.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreTipo.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreTipo.TabIndex = 0;
            // 
            // FrmInputTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(476, 223);
            this.Controls.Add(this.KTxtNombreTipo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.PanBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanTituloAutores);
            this.Name = "FrmInputTxt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo libro";
            this.Load += new System.EventHandler(this.FrmInputTxt_Load);
            this.PanTituloAutores.ResumeLayout(false);
            this.PanTituloAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).EndInit();
            this.PanBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton GBtnModificar;
        private System.Windows.Forms.Panel PanTituloAutores;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarAutores;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PcbLogoAutores;
        private System.Windows.Forms.Panel PanBtn;
        private Guna.UI.WinForms.GunaButton GBtnEliminar;
        private Guna.UI.WinForms.GunaButton GBtnGuardar;
        private System.Windows.Forms.Label LblNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreTipo;
        private System.Windows.Forms.ToolTip TTInput;
    }
}