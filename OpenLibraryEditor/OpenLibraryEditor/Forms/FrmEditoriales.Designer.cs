namespace OpenLibraryEditor.Forms
{
    partial class FrmEditoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditoriales));
            this.PanBtnEd = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GBtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.GBtnActualizar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.PanTituloEditoriales = new System.Windows.Forms.Panel();
            this.MBtnCerrarEditoriales = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloEditoriales = new System.Windows.Forms.Label();
            this.PcbLogoEditoriales = new System.Windows.Forms.PictureBox();
            this.LsvEditorialNE = new System.Windows.Forms.ListView();
            this.ChNombreNE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanOpcionesED = new System.Windows.Forms.Panel();
            this.LblObligatorio = new System.Windows.Forms.Label();
            this.LblNombreEd = new System.Windows.Forms.Label();
            this.KTxtNombreEd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MBtnAniadirImagenEd = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnBorrarImagenEd = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioEd = new System.Windows.Forms.Label();
            this.KTxtComentarioEd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PcbEditorialesEd = new System.Windows.Forms.PictureBox();
            this.TTEditorial = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MBtnMasLsvNE = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNE = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanBtnEd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanTituloEditoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditoriales)).BeginInit();
            this.PanOpcionesED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEditorialesEd)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtnEd
            // 
            this.PanBtnEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtnEd.Controls.Add(this.flowLayoutPanel1);
            this.PanBtnEd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnEd.Location = new System.Drawing.Point(0, 454);
            this.PanBtnEd.Name = "PanBtnEd";
            this.PanBtnEd.Size = new System.Drawing.Size(805, 45);
            this.PanBtnEd.TabIndex = 118;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GBtnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.GBtnActualizar);
            this.flowLayoutPanel1.Controls.Add(this.GBtnCancelar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(315, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(490, 45);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // GBtnAceptar
            // 
            this.GBtnAceptar.AnimationHoverSpeed = 0.07F;
            this.GBtnAceptar.AnimationSpeed = 0.03F;
            this.GBtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnAceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnAceptar.Image = null;
            this.GBtnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnAceptar.Location = new System.Drawing.Point(356, 5);
            this.GBtnAceptar.Margin = new System.Windows.Forms.Padding(3, 5, 8, 3);
            this.GBtnAceptar.Name = "GBtnAceptar";
            this.GBtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnAceptar.OnHoverImage = null;
            this.GBtnAceptar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.Radius = 15;
            this.GBtnAceptar.Size = new System.Drawing.Size(126, 35);
            this.GBtnAceptar.TabIndex = 0;
            this.GBtnAceptar.Text = "Aceptar";
            this.GBtnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnAceptar.Click += new System.EventHandler(this.GBtnAceptar_Click);
            // 
            // GBtnActualizar
            // 
            this.GBtnActualizar.AnimationHoverSpeed = 0.07F;
            this.GBtnActualizar.AnimationSpeed = 0.03F;
            this.GBtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnActualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnActualizar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnActualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnActualizar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnActualizar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnActualizar.Image = null;
            this.GBtnActualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnActualizar.Location = new System.Drawing.Point(180, 5);
            this.GBtnActualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.GBtnActualizar.Name = "GBtnActualizar";
            this.GBtnActualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnActualizar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnActualizar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnActualizar.OnHoverImage = null;
            this.GBtnActualizar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnActualizar.Radius = 15;
            this.GBtnActualizar.Size = new System.Drawing.Size(170, 35);
            this.GBtnActualizar.TabIndex = 1;
            this.GBtnActualizar.Text = "Actualizar con BD";
            this.GBtnActualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnActualizar.Visible = false;
            this.GBtnActualizar.Click += new System.EventHandler(this.GBtnActualizar_Click);
            // 
            // GBtnCancelar
            // 
            this.GBtnCancelar.AnimationHoverSpeed = 0.07F;
            this.GBtnCancelar.AnimationSpeed = 0.03F;
            this.GBtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCancelar.Image = null;
            this.GBtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnCancelar.Location = new System.Drawing.Point(48, 5);
            this.GBtnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.GBtnCancelar.Name = "GBtnCancelar";
            this.GBtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.OnHoverForeColor = System.Drawing.Color.Black;
            this.GBtnCancelar.OnHoverImage = null;
            this.GBtnCancelar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.Radius = 15;
            this.GBtnCancelar.Size = new System.Drawing.Size(126, 35);
            this.GBtnCancelar.TabIndex = 2;
            this.GBtnCancelar.Text = "Cancelar";
            this.GBtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCancelar.Click += new System.EventHandler(this.GBtnCancelar_Click);
            // 
            // PanTituloEditoriales
            // 
            this.PanTituloEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloEditoriales.Controls.Add(this.MBtnCerrarEditoriales);
            this.PanTituloEditoriales.Controls.Add(this.LblTituloEditoriales);
            this.PanTituloEditoriales.Controls.Add(this.PcbLogoEditoriales);
            this.PanTituloEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloEditoriales.Location = new System.Drawing.Point(0, 0);
            this.PanTituloEditoriales.Name = "PanTituloEditoriales";
            this.PanTituloEditoriales.Size = new System.Drawing.Size(805, 40);
            this.PanTituloEditoriales.TabIndex = 117;
            this.PanTituloEditoriales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloEditoriales_MouseDown);
            // 
            // MBtnCerrarEditoriales
            // 
            this.MBtnCerrarEditoriales.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarEditoriales.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarEditoriales.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarEditoriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarEditoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarEditoriales.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarEditoriales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarEditoriales.IconSize = 40;
            this.MBtnCerrarEditoriales.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarEditoriales.Name = "MBtnCerrarEditoriales";
            this.MBtnCerrarEditoriales.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarEditoriales.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarEditoriales.TabIndex = 0;
            this.MBtnCerrarEditoriales.UseVisualStyleBackColor = false;
            this.MBtnCerrarEditoriales.Click += new System.EventHandler(this.MBtnCerrarEditoriales_Click);
            // 
            // LblTituloEditoriales
            // 
            this.LblTituloEditoriales.AutoSize = true;
            this.LblTituloEditoriales.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloEditoriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTituloEditoriales.Location = new System.Drawing.Point(54, 9);
            this.LblTituloEditoriales.Name = "LblTituloEditoriales";
            this.LblTituloEditoriales.Size = new System.Drawing.Size(307, 23);
            this.LblTituloEditoriales.TabIndex = 4;
            this.LblTituloEditoriales.Text = "Open Library Editor - Nueva Editorial";
            this.LblTituloEditoriales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloEditoriales_MouseDown);
            // 
            // PcbLogoEditoriales
            // 
            this.PcbLogoEditoriales.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoEditoriales.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoEditoriales.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoEditoriales.Name = "PcbLogoEditoriales";
            this.PcbLogoEditoriales.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoEditoriales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoEditoriales.TabIndex = 3;
            this.PcbLogoEditoriales.TabStop = false;
            this.PcbLogoEditoriales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloEditoriales_MouseDown);
            // 
            // LsvEditorialNE
            // 
            this.LsvEditorialNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LsvEditorialNE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvEditorialNE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreNE});
            this.LsvEditorialNE.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvEditorialNE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LsvEditorialNE.HideSelection = false;
            this.LsvEditorialNE.Location = new System.Drawing.Point(25, 70);
            this.LsvEditorialNE.MultiSelect = false;
            this.LsvEditorialNE.Name = "LsvEditorialNE";
            this.LsvEditorialNE.Size = new System.Drawing.Size(215, 313);
            this.LsvEditorialNE.TabIndex = 0;
            this.LsvEditorialNE.UseCompatibleStateImageBehavior = false;
            this.LsvEditorialNE.View = System.Windows.Forms.View.Details;
            this.LsvEditorialNE.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvEditorialNE_ItemSelectionChanged);
            // 
            // ChNombreNE
            // 
            this.ChNombreNE.Text = "Nombre";
            this.ChNombreNE.Width = 178;
            // 
            // PanOpcionesED
            // 
            this.PanOpcionesED.Controls.Add(this.LblObligatorio);
            this.PanOpcionesED.Controls.Add(this.LblNombreEd);
            this.PanOpcionesED.Controls.Add(this.KTxtNombreEd);
            this.PanOpcionesED.Controls.Add(this.MBtnAniadirImagenEd);
            this.PanOpcionesED.Controls.Add(this.MBtnBorrarImagenEd);
            this.PanOpcionesED.Controls.Add(this.LblComentarioEd);
            this.PanOpcionesED.Controls.Add(this.KTxtComentarioEd);
            this.PanOpcionesED.Controls.Add(this.PcbEditorialesEd);
            this.PanOpcionesED.Location = new System.Drawing.Point(251, 60);
            this.PanOpcionesED.Name = "PanOpcionesED";
            this.PanOpcionesED.Size = new System.Drawing.Size(542, 374);
            this.PanOpcionesED.TabIndex = 137;
            this.PanOpcionesED.Visible = false;
            // 
            // LblObligatorio
            // 
            this.LblObligatorio.AutoSize = true;
            this.LblObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.LblObligatorio.Font = new System.Drawing.Font("Merienda One", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblObligatorio.Location = new System.Drawing.Point(26, 344);
            this.LblObligatorio.Name = "LblObligatorio";
            this.LblObligatorio.Size = new System.Drawing.Size(150, 16);
            this.LblObligatorio.TabIndex = 167;
            this.LblObligatorio.Text = "( * ) Campos obligatorios";
            // 
            // LblNombreEd
            // 
            this.LblNombreEd.AutoSize = true;
            this.LblNombreEd.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblNombreEd.Location = new System.Drawing.Point(25, 10);
            this.LblNombreEd.Name = "LblNombreEd";
            this.LblNombreEd.Size = new System.Drawing.Size(129, 20);
            this.LblNombreEd.TabIndex = 132;
            this.LblNombreEd.Text = "Nombre editorial";
            // 
            // KTxtNombreEd
            // 
            this.KTxtNombreEd.Location = new System.Drawing.Point(25, 31);
            this.KTxtNombreEd.Name = "KTxtNombreEd";
            this.KTxtNombreEd.Size = new System.Drawing.Size(268, 33);
            this.KTxtNombreEd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreEd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreEd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreEd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreEd.StateCommon.Border.Rounding = 10;
            this.KTxtNombreEd.StateCommon.Border.Width = 2;
            this.KTxtNombreEd.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreEd.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreEd.TabIndex = 0;
            this.KTxtNombreEd.Enter += new System.EventHandler(this.KTxtNombreEd_Enter);
            this.KTxtNombreEd.Leave += new System.EventHandler(this.KTxtNombreEd_Leave);
            // 
            // MBtnAniadirImagenEd
            // 
            this.MBtnAniadirImagenEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnAniadirImagenEd.FlatAppearance.BorderSize = 0;
            this.MBtnAniadirImagenEd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAniadirImagenEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnAniadirImagenEd.IconChar = FontAwesome.Sharp.MaterialIcons.FileImagePlusOutline;
            this.MBtnAniadirImagenEd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnAniadirImagenEd.Location = new System.Drawing.Point(400, 238);
            this.MBtnAniadirImagenEd.Name = "MBtnAniadirImagenEd";
            this.MBtnAniadirImagenEd.Size = new System.Drawing.Size(30, 30);
            this.MBtnAniadirImagenEd.TabIndex = 2;
            this.MBtnAniadirImagenEd.UseVisualStyleBackColor = true;
            this.MBtnAniadirImagenEd.Click += new System.EventHandler(this.MBtnAniadirImagenEd_Click);
            // 
            // MBtnBorrarImagenEd
            // 
            this.MBtnBorrarImagenEd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarImagenEd.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarImagenEd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarImagenEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnBorrarImagenEd.IconChar = FontAwesome.Sharp.MaterialIcons.FileImageMinus;
            this.MBtnBorrarImagenEd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnBorrarImagenEd.Location = new System.Drawing.Point(440, 238);
            this.MBtnBorrarImagenEd.Name = "MBtnBorrarImagenEd";
            this.MBtnBorrarImagenEd.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarImagenEd.TabIndex = 3;
            this.MBtnBorrarImagenEd.UseVisualStyleBackColor = true;
            this.MBtnBorrarImagenEd.Click += new System.EventHandler(this.MBtnBorrarImagenEd_Click);
            // 
            // LblComentarioEd
            // 
            this.LblComentarioEd.AutoSize = true;
            this.LblComentarioEd.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioEd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblComentarioEd.Location = new System.Drawing.Point(25, 81);
            this.LblComentarioEd.Name = "LblComentarioEd";
            this.LblComentarioEd.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioEd.TabIndex = 130;
            this.LblComentarioEd.Text = "Comentario";
            // 
            // KTxtComentarioEd
            // 
            this.KTxtComentarioEd.Location = new System.Drawing.Point(25, 104);
            this.KTxtComentarioEd.Multiline = true;
            this.KTxtComentarioEd.Name = "KTxtComentarioEd";
            this.KTxtComentarioEd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioEd.Size = new System.Drawing.Size(268, 219);
            this.KTxtComentarioEd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtComentarioEd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioEd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioEd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioEd.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioEd.StateCommon.Border.Width = 2;
            this.KTxtComentarioEd.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtComentarioEd.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioEd.TabIndex = 1;
            // 
            // PcbEditorialesEd
            // 
            this.PcbEditorialesEd.Image = global::OpenLibraryEditor.Properties.Resources.libros;
            this.PcbEditorialesEd.Location = new System.Drawing.Point(353, 31);
            this.PcbEditorialesEd.Name = "PcbEditorialesEd";
            this.PcbEditorialesEd.Size = new System.Drawing.Size(162, 191);
            this.PcbEditorialesEd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbEditorialesEd.TabIndex = 126;
            this.PcbEditorialesEd.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(802, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 414);
            this.panel2.TabIndex = 148;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 414);
            this.panel1.TabIndex = 149;
            // 
            // MBtnMasLsvNE
            // 
            this.MBtnMasLsvNE.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNE.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvNE.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNE.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvNE.IconSize = 65;
            this.MBtnMasLsvNE.Location = new System.Drawing.Point(25, 389);
            this.MBtnMasLsvNE.Name = "MBtnMasLsvNE";
            this.MBtnMasLsvNE.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNE.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNE.TabIndex = 1;
            this.MBtnMasLsvNE.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNE.Click += new System.EventHandler(this.MBtnMasLsvNE_Click);
            // 
            // MBtnMenosLsvNE
            // 
            this.MBtnMenosLsvNE.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNE.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvNE.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNE.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvNE.IconSize = 65;
            this.MBtnMenosLsvNE.Location = new System.Drawing.Point(82, 389);
            this.MBtnMenosLsvNE.Name = "MBtnMenosLsvNE";
            this.MBtnMenosLsvNE.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNE.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNE.TabIndex = 2;
            this.MBtnMenosLsvNE.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNE.Click += new System.EventHandler(this.MBtnMenosLsvNE_Click);
            // 
            // FrmEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MBtnMasLsvNE);
            this.Controls.Add(this.MBtnMenosLsvNE);
            this.Controls.Add(this.LsvEditorialNE);
            this.Controls.Add(this.PanBtnEd);
            this.Controls.Add(this.PanTituloEditoriales);
            this.Controls.Add(this.PanOpcionesED);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditoriales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditoriales_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditoriales_Load);
            this.PanBtnEd.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanTituloEditoriales.ResumeLayout(false);
            this.PanTituloEditoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditoriales)).EndInit();
            this.PanOpcionesED.ResumeLayout(false);
            this.PanOpcionesED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEditorialesEd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanBtnEd;
        private System.Windows.Forms.Panel PanTituloEditoriales;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarEditoriales;
        private System.Windows.Forms.Label LblTituloEditoriales;
        private System.Windows.Forms.PictureBox PcbLogoEditoriales;
        private System.Windows.Forms.ListView LsvEditorialNE;
        private System.Windows.Forms.ColumnHeader ChNombreNE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNE;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNE;
        private System.Windows.Forms.Panel PanOpcionesED;
        private System.Windows.Forms.Label LblNombreEd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreEd;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAniadirImagenEd;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarImagenEd;
        private System.Windows.Forms.Label LblComentarioEd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioEd;
        private System.Windows.Forms.PictureBox PcbEditorialesEd;
        private System.Windows.Forms.ToolTip TTEditorial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton GBtnAceptar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
        private Guna.UI.WinForms.GunaButton GBtnActualizar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblObligatorio;
    }
}