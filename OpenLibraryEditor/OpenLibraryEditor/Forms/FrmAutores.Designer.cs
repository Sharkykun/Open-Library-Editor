namespace OpenLibraryEditor.Forms
{
    partial class FrmAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutores));
            this.PanTituloAutores = new System.Windows.Forms.Panel();
            this.MBtnCerrarAutores = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloAutores = new System.Windows.Forms.Label();
            this.PcbLogoAutores = new System.Windows.Forms.PictureBox();
            this.PanBtnAu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GBtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.GBtnActualizar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.LsvAutoresNA = new System.Windows.Forms.ListView();
            this.ChNombreAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChOcupacionAu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanOpcionesNA = new System.Windows.Forms.Panel();
            this.LblObligatorio = new System.Windows.Forms.Label();
            this.TBtnVivo = new OpenLibraryEditor.Controles.ToggleButton();
            this.LblSigueVivo = new System.Windows.Forms.Label();
            this.LblOcupacionNA = new System.Windows.Forms.Label();
            this.KCmbOcupacionNA = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.MBtnMasOcupacionNA = new FontAwesome.Sharp.Material.MaterialButton();
            this.KMtxtFecMuerteNA = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.KMtxtFecNacimientoNA = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.MBtnAniadirImagenAu = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnBorrarImagenAu = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblComentarioAu = new System.Windows.Forms.Label();
            this.KTxtComentarioAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblEnlaceAu = new System.Windows.Forms.Label();
            this.KTxtEnlaceAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblDefuncionAu = new System.Windows.Forms.Label();
            this.LblAliasAu = new System.Windows.Forms.Label();
            this.KtxtAliasAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblNacimientoAu = new System.Windows.Forms.Label();
            this.LblNombreNA = new System.Windows.Forms.Label();
            this.KTxtNombreAu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PcbAutorNA = new System.Windows.Forms.PictureBox();
            this.TTAutores = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanTituloAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).BeginInit();
            this.PanBtnAu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanOpcionesNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOcupacionNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAutorNA)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTituloAutores
            // 
            this.PanTituloAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloAutores.Controls.Add(this.MBtnCerrarAutores);
            this.PanTituloAutores.Controls.Add(this.LblTituloAutores);
            this.PanTituloAutores.Controls.Add(this.PcbLogoAutores);
            this.PanTituloAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloAutores.Location = new System.Drawing.Point(0, 0);
            this.PanTituloAutores.Name = "PanTituloAutores";
            this.PanTituloAutores.Size = new System.Drawing.Size(805, 40);
            this.PanTituloAutores.TabIndex = 1;
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
            this.MBtnCerrarAutores.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarAutores.Name = "MBtnCerrarAutores";
            this.MBtnCerrarAutores.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarAutores.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarAutores.TabIndex = 28;
            this.MBtnCerrarAutores.UseVisualStyleBackColor = false;
            this.MBtnCerrarAutores.Click += new System.EventHandler(this.MBtnCerrarAutores_Click);
            // 
            // LblTituloAutores
            // 
            this.LblTituloAutores.AutoSize = true;
            this.LblTituloAutores.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTituloAutores.Location = new System.Drawing.Point(54, 9);
            this.LblTituloAutores.Name = "LblTituloAutores";
            this.LblTituloAutores.Size = new System.Drawing.Size(282, 23);
            this.LblTituloAutores.TabIndex = 4;
            this.LblTituloAutores.Text = "Open Library Editor - Nuevo Autor";
            this.LblTituloAutores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
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
            this.PcbLogoAutores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanTituloAutores_MouseDown);
            // 
            // PanBtnAu
            // 
            this.PanBtnAu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtnAu.Controls.Add(this.flowLayoutPanel1);
            this.PanBtnAu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnAu.Location = new System.Drawing.Point(0, 454);
            this.PanBtnAu.Name = "PanBtnAu";
            this.PanBtnAu.Size = new System.Drawing.Size(805, 45);
            this.PanBtnAu.TabIndex = 97;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GBtnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.GBtnActualizar);
            this.flowLayoutPanel1.Controls.Add(this.GBtnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(185, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(620, 45);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // GBtnAceptar
            // 
            this.GBtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.GBtnAceptar.Location = new System.Drawing.Point(486, 5);
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
            this.GBtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.GBtnActualizar.Location = new System.Drawing.Point(310, 5);
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
            this.GBtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.GBtnCancelar.Location = new System.Drawing.Point(178, 5);
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
            // LsvAutoresNA
            // 
            this.LsvAutoresNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LsvAutoresNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvAutoresNA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreAutor,
            this.ChOcupacionAu});
            this.LsvAutoresNA.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvAutoresNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LsvAutoresNA.HideSelection = false;
            this.LsvAutoresNA.Location = new System.Drawing.Point(12, 70);
            this.LsvAutoresNA.MultiSelect = false;
            this.LsvAutoresNA.Name = "LsvAutoresNA";
            this.LsvAutoresNA.Size = new System.Drawing.Size(221, 313);
            this.LsvAutoresNA.TabIndex = 0;
            this.LsvAutoresNA.UseCompatibleStateImageBehavior = false;
            this.LsvAutoresNA.View = System.Windows.Forms.View.Details;
            this.LsvAutoresNA.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvAutoresNA_ItemSelectionChanged);
            // 
            // ChNombreAutor
            // 
            this.ChNombreAutor.Text = "Nombre";
            this.ChNombreAutor.Width = 117;
            // 
            // ChOcupacionAu
            // 
            this.ChOcupacionAu.Text = "Ocupación";
            this.ChOcupacionAu.Width = 127;
            // 
            // MBtnMasLsvNA
            // 
            this.MBtnMasLsvNA.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNA.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNA.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvNA.IconSize = 65;
            this.MBtnMasLsvNA.Location = new System.Drawing.Point(12, 389);
            this.MBtnMasLsvNA.Name = "MBtnMasLsvNA";
            this.MBtnMasLsvNA.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNA.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNA.TabIndex = 1;
            this.MBtnMasLsvNA.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNA.Click += new System.EventHandler(this.MBtnMasLsvNA_Click);
            // 
            // MBtnMenosLsvNA
            // 
            this.MBtnMenosLsvNA.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNA.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNA.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvNA.IconSize = 65;
            this.MBtnMenosLsvNA.Location = new System.Drawing.Point(69, 389);
            this.MBtnMenosLsvNA.Name = "MBtnMenosLsvNA";
            this.MBtnMenosLsvNA.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNA.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNA.TabIndex = 2;
            this.MBtnMenosLsvNA.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNA.Click += new System.EventHandler(this.MBtnMenosLsvNA_Click);
            // 
            // PanOpcionesNA
            // 
            this.PanOpcionesNA.Controls.Add(this.LblObligatorio);
            this.PanOpcionesNA.Controls.Add(this.TBtnVivo);
            this.PanOpcionesNA.Controls.Add(this.LblSigueVivo);
            this.PanOpcionesNA.Controls.Add(this.LblOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.KCmbOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.MBtnMasOcupacionNA);
            this.PanOpcionesNA.Controls.Add(this.KMtxtFecMuerteNA);
            this.PanOpcionesNA.Controls.Add(this.KMtxtFecNacimientoNA);
            this.PanOpcionesNA.Controls.Add(this.MBtnAniadirImagenAu);
            this.PanOpcionesNA.Controls.Add(this.MBtnBorrarImagenAu);
            this.PanOpcionesNA.Controls.Add(this.LblComentarioAu);
            this.PanOpcionesNA.Controls.Add(this.KTxtComentarioAu);
            this.PanOpcionesNA.Controls.Add(this.LblEnlaceAu);
            this.PanOpcionesNA.Controls.Add(this.KTxtEnlaceAu);
            this.PanOpcionesNA.Controls.Add(this.LblDefuncionAu);
            this.PanOpcionesNA.Controls.Add(this.LblAliasAu);
            this.PanOpcionesNA.Controls.Add(this.KtxtAliasAu);
            this.PanOpcionesNA.Controls.Add(this.LblNacimientoAu);
            this.PanOpcionesNA.Controls.Add(this.LblNombreNA);
            this.PanOpcionesNA.Controls.Add(this.KTxtNombreAu);
            this.PanOpcionesNA.Controls.Add(this.PcbAutorNA);
            this.PanOpcionesNA.Location = new System.Drawing.Point(240, 46);
            this.PanOpcionesNA.Name = "PanOpcionesNA";
            this.PanOpcionesNA.Size = new System.Drawing.Size(556, 405);
            this.PanOpcionesNA.TabIndex = 145;
            this.PanOpcionesNA.Visible = false;
            // 
            // LblObligatorio
            // 
            this.LblObligatorio.AutoSize = true;
            this.LblObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.LblObligatorio.Font = new System.Drawing.Font("Merienda One", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblObligatorio.Location = new System.Drawing.Point(4, 384);
            this.LblObligatorio.Name = "LblObligatorio";
            this.LblObligatorio.Size = new System.Drawing.Size(150, 16);
            this.LblObligatorio.TabIndex = 166;
            this.LblObligatorio.Text = "( * ) Campos obligatorios";
            // 
            // TBtnVivo
            // 
            this.TBtnVivo.AutoSize = true;
            this.TBtnVivo.Location = new System.Drawing.Point(172, 180);
            this.TBtnVivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.TBtnVivo.Name = "TBtnVivo";
            this.TBtnVivo.OffBackColor = System.Drawing.Color.DarkGray;
            this.TBtnVivo.OffToggleColor = System.Drawing.Color.Black;
            this.TBtnVivo.OnBackColor = System.Drawing.Color.LimeGreen;
            this.TBtnVivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TBtnVivo.Size = new System.Drawing.Size(45, 22);
            this.TBtnVivo.TabIndex = 4;
            this.TBtnVivo.UseVisualStyleBackColor = true;
            // 
            // LblSigueVivo
            // 
            this.LblSigueVivo.AutoSize = true;
            this.LblSigueVivo.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSigueVivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblSigueVivo.Location = new System.Drawing.Point(3, 180);
            this.LblSigueVivo.Name = "LblSigueVivo";
            this.LblSigueVivo.Size = new System.Drawing.Size(75, 20);
            this.LblSigueVivo.TabIndex = 164;
            this.LblSigueVivo.Text = "Está vivo:";
            // 
            // LblOcupacionNA
            // 
            this.LblOcupacionNA.AutoSize = true;
            this.LblOcupacionNA.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOcupacionNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblOcupacionNA.Location = new System.Drawing.Point(3, 102);
            this.LblOcupacionNA.Name = "LblOcupacionNA";
            this.LblOcupacionNA.Size = new System.Drawing.Size(84, 20);
            this.LblOcupacionNA.TabIndex = 163;
            this.LblOcupacionNA.Text = "Ocupación";
            // 
            // KCmbOcupacionNA
            // 
            this.KCmbOcupacionNA.DropDownWidth = 228;
            this.KCmbOcupacionNA.Location = new System.Drawing.Point(172, 96);
            this.KCmbOcupacionNA.Name = "KCmbOcupacionNA";
            this.KCmbOcupacionNA.Size = new System.Drawing.Size(194, 33);
            this.KCmbOcupacionNA.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbOcupacionNA.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbOcupacionNA.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbOcupacionNA.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOcupacionNA.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbOcupacionNA.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbOcupacionNA.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbOcupacionNA.TabIndex = 2;
            // 
            // MBtnMasOcupacionNA
            // 
            this.MBtnMasOcupacionNA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasOcupacionNA.FlatAppearance.BorderSize = 0;
            this.MBtnMasOcupacionNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasOcupacionNA.IconChar = FontAwesome.Sharp.MaterialIcons.PencilPlus;
            this.MBtnMasOcupacionNA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasOcupacionNA.IconSize = 40;
            this.MBtnMasOcupacionNA.Location = new System.Drawing.Point(372, 98);
            this.MBtnMasOcupacionNA.Name = "MBtnMasOcupacionNA";
            this.MBtnMasOcupacionNA.Size = new System.Drawing.Size(30, 30);
            this.MBtnMasOcupacionNA.TabIndex = 160;
            this.MBtnMasOcupacionNA.UseVisualStyleBackColor = true;
            this.MBtnMasOcupacionNA.Click += new System.EventHandler(this.MBtnMasOcupacionNA_Click);
            // 
            // KMtxtFecMuerteNA
            // 
            this.KMtxtFecMuerteNA.Location = new System.Drawing.Point(172, 213);
            this.KMtxtFecMuerteNA.Mask = "00/00/0000";
            this.KMtxtFecMuerteNA.Name = "KMtxtFecMuerteNA";
            this.KMtxtFecMuerteNA.Size = new System.Drawing.Size(107, 33);
            this.KMtxtFecMuerteNA.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KMtxtFecMuerteNA.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KMtxtFecMuerteNA.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KMtxtFecMuerteNA.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KMtxtFecMuerteNA.StateCommon.Border.Rounding = 10;
            this.KMtxtFecMuerteNA.StateCommon.Border.Width = 2;
            this.KMtxtFecMuerteNA.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KMtxtFecMuerteNA.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMtxtFecMuerteNA.TabIndex = 5;
            this.KMtxtFecMuerteNA.Text = "  /  /";
            // 
            // KMtxtFecNacimientoNA
            // 
            this.KMtxtFecNacimientoNA.Location = new System.Drawing.Point(172, 135);
            this.KMtxtFecNacimientoNA.Mask = "00/00/0000";
            this.KMtxtFecNacimientoNA.Name = "KMtxtFecNacimientoNA";
            this.KMtxtFecNacimientoNA.Size = new System.Drawing.Size(107, 33);
            this.KMtxtFecNacimientoNA.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KMtxtFecNacimientoNA.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KMtxtFecNacimientoNA.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KMtxtFecNacimientoNA.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KMtxtFecNacimientoNA.StateCommon.Border.Rounding = 10;
            this.KMtxtFecNacimientoNA.StateCommon.Border.Width = 2;
            this.KMtxtFecNacimientoNA.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KMtxtFecNacimientoNA.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMtxtFecNacimientoNA.TabIndex = 3;
            this.KMtxtFecNacimientoNA.Text = "  /  /";
            // 
            // MBtnAniadirImagenAu
            // 
            this.MBtnAniadirImagenAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnAniadirImagenAu.FlatAppearance.BorderSize = 0;
            this.MBtnAniadirImagenAu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAniadirImagenAu.IconChar = FontAwesome.Sharp.MaterialIcons.FileImagePlusOutline;
            this.MBtnAniadirImagenAu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnAniadirImagenAu.Location = new System.Drawing.Point(455, 164);
            this.MBtnAniadirImagenAu.Name = "MBtnAniadirImagenAu";
            this.MBtnAniadirImagenAu.Size = new System.Drawing.Size(30, 30);
            this.MBtnAniadirImagenAu.TabIndex = 8;
            this.MBtnAniadirImagenAu.UseVisualStyleBackColor = true;
            this.MBtnAniadirImagenAu.Click += new System.EventHandler(this.MBtnAniadirImagenAu_Click);
            // 
            // MBtnBorrarImagenAu
            // 
            this.MBtnBorrarImagenAu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBorrarImagenAu.FlatAppearance.BorderSize = 0;
            this.MBtnBorrarImagenAu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBorrarImagenAu.IconChar = FontAwesome.Sharp.MaterialIcons.FileImageMinus;
            this.MBtnBorrarImagenAu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnBorrarImagenAu.Location = new System.Drawing.Point(495, 164);
            this.MBtnBorrarImagenAu.Name = "MBtnBorrarImagenAu";
            this.MBtnBorrarImagenAu.Size = new System.Drawing.Size(30, 30);
            this.MBtnBorrarImagenAu.TabIndex = 9;
            this.MBtnBorrarImagenAu.UseVisualStyleBackColor = true;
            this.MBtnBorrarImagenAu.Click += new System.EventHandler(this.MBtnBorrarImagenAu_Click);
            // 
            // LblComentarioAu
            // 
            this.LblComentarioAu.AutoSize = true;
            this.LblComentarioAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblComentarioAu.Location = new System.Drawing.Point(3, 297);
            this.LblComentarioAu.Name = "LblComentarioAu";
            this.LblComentarioAu.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioAu.TabIndex = 157;
            this.LblComentarioAu.Text = "Comentario";
            // 
            // KTxtComentarioAu
            // 
            this.KTxtComentarioAu.Location = new System.Drawing.Point(172, 291);
            this.KTxtComentarioAu.Multiline = true;
            this.KTxtComentarioAu.Name = "KTxtComentarioAu";
            this.KTxtComentarioAu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioAu.Size = new System.Drawing.Size(369, 85);
            this.KTxtComentarioAu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtComentarioAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioAu.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioAu.StateCommon.Border.Width = 2;
            this.KTxtComentarioAu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtComentarioAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioAu.TabIndex = 7;
            // 
            // LblEnlaceAu
            // 
            this.LblEnlaceAu.AutoSize = true;
            this.LblEnlaceAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnlaceAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblEnlaceAu.Location = new System.Drawing.Point(3, 258);
            this.LblEnlaceAu.Name = "LblEnlaceAu";
            this.LblEnlaceAu.Size = new System.Drawing.Size(155, 20);
            this.LblEnlaceAu.TabIndex = 156;
            this.LblEnlaceAu.Text = "Enlace de referencia";
            // 
            // KTxtEnlaceAu
            // 
            this.KTxtEnlaceAu.Location = new System.Drawing.Point(172, 252);
            this.KTxtEnlaceAu.Name = "KTxtEnlaceAu";
            this.KTxtEnlaceAu.Size = new System.Drawing.Size(369, 33);
            this.KTxtEnlaceAu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtEnlaceAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtEnlaceAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtEnlaceAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtEnlaceAu.StateCommon.Border.Rounding = 10;
            this.KTxtEnlaceAu.StateCommon.Border.Width = 2;
            this.KTxtEnlaceAu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtEnlaceAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtEnlaceAu.TabIndex = 6;
            // 
            // LblDefuncionAu
            // 
            this.LblDefuncionAu.AutoSize = true;
            this.LblDefuncionAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefuncionAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblDefuncionAu.Location = new System.Drawing.Point(3, 219);
            this.LblDefuncionAu.Name = "LblDefuncionAu";
            this.LblDefuncionAu.Size = new System.Drawing.Size(147, 20);
            this.LblDefuncionAu.TabIndex = 155;
            this.LblDefuncionAu.Text = "Fecha de defunción";
            // 
            // LblAliasAu
            // 
            this.LblAliasAu.AutoSize = true;
            this.LblAliasAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAliasAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblAliasAu.Location = new System.Drawing.Point(3, 63);
            this.LblAliasAu.Name = "LblAliasAu";
            this.LblAliasAu.Size = new System.Drawing.Size(42, 20);
            this.LblAliasAu.TabIndex = 154;
            this.LblAliasAu.Text = "Alias";
            // 
            // KtxtAliasAu
            // 
            this.KtxtAliasAu.Location = new System.Drawing.Point(172, 57);
            this.KtxtAliasAu.Name = "KtxtAliasAu";
            this.KtxtAliasAu.Size = new System.Drawing.Size(235, 33);
            this.KtxtAliasAu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KtxtAliasAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KtxtAliasAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KtxtAliasAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KtxtAliasAu.StateCommon.Border.Rounding = 10;
            this.KtxtAliasAu.StateCommon.Border.Width = 2;
            this.KtxtAliasAu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KtxtAliasAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KtxtAliasAu.TabIndex = 1;
            // 
            // LblNacimientoAu
            // 
            this.LblNacimientoAu.AutoSize = true;
            this.LblNacimientoAu.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimientoAu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblNacimientoAu.Location = new System.Drawing.Point(3, 141);
            this.LblNacimientoAu.Name = "LblNacimientoAu";
            this.LblNacimientoAu.Size = new System.Drawing.Size(155, 20);
            this.LblNacimientoAu.TabIndex = 153;
            this.LblNacimientoAu.Text = "Fecha de nacimiento";
            // 
            // LblNombreNA
            // 
            this.LblNombreNA.AutoSize = true;
            this.LblNombreNA.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreNA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblNombreNA.Location = new System.Drawing.Point(3, 24);
            this.LblNombreNA.Name = "LblNombreNA";
            this.LblNombreNA.Size = new System.Drawing.Size(136, 20);
            this.LblNombreNA.TabIndex = 152;
            this.LblNombreNA.Text = "Nombre completo";
            // 
            // KTxtNombreAu
            // 
            this.KTxtNombreAu.Location = new System.Drawing.Point(172, 18);
            this.KTxtNombreAu.Name = "KTxtNombreAu";
            this.KTxtNombreAu.Size = new System.Drawing.Size(235, 33);
            this.KTxtNombreAu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreAu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreAu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreAu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreAu.StateCommon.Border.Rounding = 10;
            this.KTxtNombreAu.StateCommon.Border.Width = 2;
            this.KTxtNombreAu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreAu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreAu.TabIndex = 0;
            this.KTxtNombreAu.Enter += new System.EventHandler(this.KTxtNombreAu_Enter);
            this.KTxtNombreAu.Leave += new System.EventHandler(this.KTxtNombreAu_Leave);
            // 
            // PcbAutorNA
            // 
            this.PcbAutorNA.Image = global::OpenLibraryEditor.Properties.Resources.silueta;
            this.PcbAutorNA.Location = new System.Drawing.Point(428, 18);
            this.PcbAutorNA.Name = "PcbAutorNA";
            this.PcbAutorNA.Size = new System.Drawing.Size(120, 140);
            this.PcbAutorNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAutorNA.TabIndex = 146;
            this.PcbAutorNA.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 414);
            this.panel1.TabIndex = 146;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(802, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 414);
            this.panel2.TabIndex = 147;
            // 
            // FrmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MBtnMasLsvNA);
            this.Controls.Add(this.MBtnMenosLsvNA);
            this.Controls.Add(this.LsvAutoresNA);
            this.Controls.Add(this.PanBtnAu);
            this.Controls.Add(this.PanTituloAutores);
            this.Controls.Add(this.PanOpcionesNA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutores_FormClosing);
            this.Load += new System.EventHandler(this.FrmAutores_Load);
            this.PanTituloAutores.ResumeLayout(false);
            this.PanTituloAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoAutores)).EndInit();
            this.PanBtnAu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanOpcionesNA.ResumeLayout(false);
            this.PanOpcionesNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbOcupacionNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAutorNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloAutores;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarAutores;
        private System.Windows.Forms.Label LblTituloAutores;
        private System.Windows.Forms.PictureBox PcbLogoAutores;
        private System.Windows.Forms.Panel PanBtnAu;
        private System.Windows.Forms.ListView LsvAutoresNA;
        private System.Windows.Forms.ColumnHeader ChNombreAutor;
        private System.Windows.Forms.ColumnHeader ChOcupacionAu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNA;
        private System.Windows.Forms.Panel PanOpcionesNA;
        private System.Windows.Forms.Label LblOcupacionNA;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbOcupacionNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasOcupacionNA;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox KMtxtFecMuerteNA;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox KMtxtFecNacimientoNA;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAniadirImagenAu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBorrarImagenAu;
        private System.Windows.Forms.Label LblComentarioAu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioAu;
        private System.Windows.Forms.Label LblEnlaceAu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtEnlaceAu;
        private System.Windows.Forms.Label LblDefuncionAu;
        private System.Windows.Forms.Label LblAliasAu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KtxtAliasAu;
        private System.Windows.Forms.Label LblNacimientoAu;
        private System.Windows.Forms.Label LblNombreNA;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreAu;
        private System.Windows.Forms.PictureBox PcbAutorNA;
        private System.Windows.Forms.ToolTip TTAutores;
        private Controles.ToggleButton TBtnVivo;
        private System.Windows.Forms.Label LblSigueVivo;
        private Guna.UI.WinForms.GunaButton GBtnAceptar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton GBtnActualizar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblObligatorio;
    }
}