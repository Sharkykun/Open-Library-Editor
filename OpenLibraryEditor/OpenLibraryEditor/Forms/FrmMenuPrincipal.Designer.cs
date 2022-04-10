namespace OpenLibraryEditor.Forms
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.PanButtons = new System.Windows.Forms.Panel();
            this.MBtnMinimizarMain = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnCerrarMain = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMaximizarMain = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnRestaurarMain = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloMain = new System.Windows.Forms.Label();
            this.PcbLogoMain = new System.Windows.Forms.PictureBox();
            this.PanMenuMain = new System.Windows.Forms.Panel();
            this.PanSeparadorMain = new System.Windows.Forms.Panel();
            this.MBtnSalir = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnConfiguracion = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnBuscar = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnTags = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnEditoriales = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnSeries = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnGeneros = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnTítulos = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnAutores = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMiBiblioteca = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanFotoUsuario = new System.Windows.Forms.Panel();
            this.LlLogIn = new System.Windows.Forms.LinkLabel();
            this.AciFotoUsuario = new AfriCircleImage.AfriCircleImage();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.BtnAniadirLibroMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.BtnModificarLibroMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.BtnBorrarLibroMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAutoresMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.BtnGenerosMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.BtnSeriesMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.BtnEditorialesMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.BtnTagsMsb = new FontAwesome.Sharp.Material.MaterialSplitButton();
            this.PanFormHijos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.PanTitulo.SuspendLayout();
            this.PanButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoMain)).BeginInit();
            this.PanMenuMain.SuspendLayout();
            this.PanFotoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AciFotoUsuario)).BeginInit();
            this.ToolStripMain.SuspendLayout();
            this.PanFormHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanTitulo
            // 
            this.PanTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.PanTitulo.Controls.Add(this.PanButtons);
            this.PanTitulo.Controls.Add(this.LblTituloMain);
            this.PanTitulo.Controls.Add(this.PcbLogoMain);
            this.PanTitulo.Location = new System.Drawing.Point(1, 1);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(1198, 39);
            this.PanTitulo.TabIndex = 1;
            this.PanTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTitulo_MouseDown);
            // 
            // PanButtons
            // 
            this.PanButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanButtons.BackColor = System.Drawing.Color.Transparent;
            this.PanButtons.Controls.Add(this.MBtnMinimizarMain);
            this.PanButtons.Controls.Add(this.MBtnCerrarMain);
            this.PanButtons.Controls.Add(this.MBtnMaximizarMain);
            this.PanButtons.Controls.Add(this.MBtnRestaurarMain);
            this.PanButtons.Location = new System.Drawing.Point(1078, 0);
            this.PanButtons.Name = "PanButtons";
            this.PanButtons.Size = new System.Drawing.Size(120, 40);
            this.PanButtons.TabIndex = 4;
            // 
            // MBtnMinimizarMain
            // 
            this.MBtnMinimizarMain.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMinimizarMain.FlatAppearance.BorderSize = 0;
            this.MBtnMinimizarMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnMinimizarMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnMinimizarMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMinimizarMain.IconChar = FontAwesome.Sharp.MaterialIcons.Minus;
            this.MBtnMinimizarMain.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMinimizarMain.IconSize = 60;
            this.MBtnMinimizarMain.Location = new System.Drawing.Point(0, 0);
            this.MBtnMinimizarMain.Name = "MBtnMinimizarMain";
            this.MBtnMinimizarMain.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.MBtnMinimizarMain.Size = new System.Drawing.Size(40, 40);
            this.MBtnMinimizarMain.TabIndex = 7;
            this.MBtnMinimizarMain.UseVisualStyleBackColor = false;
            this.MBtnMinimizarMain.Click += new System.EventHandler(this.MBtnMinimizarMain_Click);
            // 
            // MBtnCerrarMain
            // 
            this.MBtnCerrarMain.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarMain.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarMain.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarMain.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnCerrarMain.IconSize = 40;
            this.MBtnCerrarMain.Location = new System.Drawing.Point(80, 0);
            this.MBtnCerrarMain.Name = "MBtnCerrarMain";
            this.MBtnCerrarMain.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarMain.Size = new System.Drawing.Size(40, 40);
            this.MBtnCerrarMain.TabIndex = 4;
            this.MBtnCerrarMain.UseVisualStyleBackColor = false;
            this.MBtnCerrarMain.Click += new System.EventHandler(this.MBtnCerrarMain_Click);
            // 
            // MBtnMaximizarMain
            // 
            this.MBtnMaximizarMain.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMaximizarMain.FlatAppearance.BorderSize = 0;
            this.MBtnMaximizarMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnMaximizarMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnMaximizarMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMaximizarMain.IconChar = FontAwesome.Sharp.MaterialIcons.SquareOutline;
            this.MBtnMaximizarMain.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMaximizarMain.IconSize = 42;
            this.MBtnMaximizarMain.Location = new System.Drawing.Point(40, 0);
            this.MBtnMaximizarMain.Name = "MBtnMaximizarMain";
            this.MBtnMaximizarMain.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnMaximizarMain.Size = new System.Drawing.Size(40, 40);
            this.MBtnMaximizarMain.TabIndex = 5;
            this.MBtnMaximizarMain.UseVisualStyleBackColor = false;
            this.MBtnMaximizarMain.Click += new System.EventHandler(this.MBtnMaximizarMain_Click);
            // 
            // MBtnRestaurarMain
            // 
            this.MBtnRestaurarMain.BackColor = System.Drawing.Color.Transparent;
            this.MBtnRestaurarMain.FlatAppearance.BorderSize = 0;
            this.MBtnRestaurarMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnRestaurarMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnRestaurarMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnRestaurarMain.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.MBtnRestaurarMain.IconChar = FontAwesome.Sharp.MaterialIcons.ArrangeBringForward;
            this.MBtnRestaurarMain.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnRestaurarMain.IconSize = 40;
            this.MBtnRestaurarMain.Location = new System.Drawing.Point(40, 0);
            this.MBtnRestaurarMain.Name = "MBtnRestaurarMain";
            this.MBtnRestaurarMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MBtnRestaurarMain.Size = new System.Drawing.Size(40, 40);
            this.MBtnRestaurarMain.TabIndex = 8;
            this.MBtnRestaurarMain.UseVisualStyleBackColor = false;
            this.MBtnRestaurarMain.Click += new System.EventHandler(this.MBtnRestaurar_Click);
            // 
            // LblTituloMain
            // 
            this.LblTituloMain.AutoSize = true;
            this.LblTituloMain.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloMain.Location = new System.Drawing.Point(48, 9);
            this.LblTituloMain.Name = "LblTituloMain";
            this.LblTituloMain.Size = new System.Drawing.Size(171, 23);
            this.LblTituloMain.TabIndex = 5;
            this.LblTituloMain.Text = "Open Library Editor ";
            // 
            // PcbLogoMain
            // 
            this.PcbLogoMain.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoMain.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoMain.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoMain.Name = "PcbLogoMain";
            this.PcbLogoMain.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoMain.TabIndex = 4;
            this.PcbLogoMain.TabStop = false;
            // 
            // PanMenuMain
            // 
            this.PanMenuMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanMenuMain.AutoScroll = true;
            this.PanMenuMain.BackColor = System.Drawing.Color.Navy;
            this.PanMenuMain.Controls.Add(this.PanSeparadorMain);
            this.PanMenuMain.Controls.Add(this.MBtnSalir);
            this.PanMenuMain.Controls.Add(this.MBtnConfiguracion);
            this.PanMenuMain.Controls.Add(this.MBtnBuscar);
            this.PanMenuMain.Controls.Add(this.MBtnTags);
            this.PanMenuMain.Controls.Add(this.MBtnEditoriales);
            this.PanMenuMain.Controls.Add(this.MBtnSeries);
            this.PanMenuMain.Controls.Add(this.MBtnGeneros);
            this.PanMenuMain.Controls.Add(this.MBtnTítulos);
            this.PanMenuMain.Controls.Add(this.MBtnAutores);
            this.PanMenuMain.Controls.Add(this.MBtnMiBiblioteca);
            this.PanMenuMain.Controls.Add(this.PanFotoUsuario);
            this.PanMenuMain.Location = new System.Drawing.Point(1, 40);
            this.PanMenuMain.Name = "PanMenuMain";
            this.PanMenuMain.Size = new System.Drawing.Size(249, 759);
            this.PanMenuMain.TabIndex = 2;
            // 
            // PanSeparadorMain
            // 
            this.PanSeparadorMain.BackColor = System.Drawing.Color.Gainsboro;
            this.PanSeparadorMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanSeparadorMain.Enabled = false;
            this.PanSeparadorMain.Location = new System.Drawing.Point(0, 710);
            this.PanSeparadorMain.Name = "PanSeparadorMain";
            this.PanSeparadorMain.Size = new System.Drawing.Size(249, 4);
            this.PanSeparadorMain.TabIndex = 12;
            // 
            // MBtnSalir
            // 
            this.MBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MBtnSalir.FlatAppearance.BorderSize = 0;
            this.MBtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.MBtnSalir.Font = new System.Drawing.Font("Merienda One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnSalir.IconChar = FontAwesome.Sharp.MaterialIcons.ExitRun;
            this.MBtnSalir.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnSalir.IconSize = 40;
            this.MBtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnSalir.Location = new System.Drawing.Point(0, 714);
            this.MBtnSalir.Name = "MBtnSalir";
            this.MBtnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MBtnSalir.Size = new System.Drawing.Size(249, 45);
            this.MBtnSalir.TabIndex = 11;
            this.MBtnSalir.Text = "Salir";
            this.MBtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnSalir.UseVisualStyleBackColor = true;
            this.MBtnSalir.Click += new System.EventHandler(this.MBtnSalir_Click);
            // 
            // MBtnConfiguracion
            // 
            this.MBtnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.MBtnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnConfiguracion.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnConfiguracion.IconChar = FontAwesome.Sharp.MaterialIcons.CogOutline;
            this.MBtnConfiguracion.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnConfiguracion.IconSize = 40;
            this.MBtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnConfiguracion.Location = new System.Drawing.Point(0, 577);
            this.MBtnConfiguracion.Name = "MBtnConfiguracion";
            this.MBtnConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MBtnConfiguracion.Size = new System.Drawing.Size(249, 45);
            this.MBtnConfiguracion.TabIndex = 10;
            this.MBtnConfiguracion.Text = "Configuración";
            this.MBtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnConfiguracion.UseVisualStyleBackColor = true;
            this.MBtnConfiguracion.Click += new System.EventHandler(this.MBtnConfiguracion_Click);
            // 
            // MBtnBuscar
            // 
            this.MBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnBuscar.FlatAppearance.BorderSize = 0;
            this.MBtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscar.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscar.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscar.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscar.IconSize = 40;
            this.MBtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnBuscar.Location = new System.Drawing.Point(0, 532);
            this.MBtnBuscar.Name = "MBtnBuscar";
            this.MBtnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MBtnBuscar.Size = new System.Drawing.Size(249, 45);
            this.MBtnBuscar.TabIndex = 9;
            this.MBtnBuscar.Text = "Buscar";
            this.MBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnBuscar.UseVisualStyleBackColor = true;
            this.MBtnBuscar.Click += new System.EventHandler(this.MBtnBuscar_Click);
            // 
            // MBtnTags
            // 
            this.MBtnTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.MBtnTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnTags.FlatAppearance.BorderSize = 0;
            this.MBtnTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnTags.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnTags.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnTags.IconChar = FontAwesome.Sharp.MaterialIcons.TagMultiple;
            this.MBtnTags.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnTags.IconSize = 40;
            this.MBtnTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnTags.Location = new System.Drawing.Point(0, 487);
            this.MBtnTags.Name = "MBtnTags";
            this.MBtnTags.Padding = new System.Windows.Forms.Padding(45, 0, 20, 0);
            this.MBtnTags.Size = new System.Drawing.Size(249, 45);
            this.MBtnTags.TabIndex = 8;
            this.MBtnTags.Text = "Tags";
            this.MBtnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnTags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnTags.UseVisualStyleBackColor = false;
            this.MBtnTags.Click += new System.EventHandler(this.MBtnTags_Click);
            // 
            // MBtnEditoriales
            // 
            this.MBtnEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.MBtnEditoriales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnEditoriales.FlatAppearance.BorderSize = 0;
            this.MBtnEditoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnEditoriales.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnEditoriales.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnEditoriales.IconChar = FontAwesome.Sharp.MaterialIcons.BankOutline;
            this.MBtnEditoriales.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnEditoriales.IconSize = 40;
            this.MBtnEditoriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnEditoriales.Location = new System.Drawing.Point(0, 442);
            this.MBtnEditoriales.Name = "MBtnEditoriales";
            this.MBtnEditoriales.Padding = new System.Windows.Forms.Padding(45, 0, 20, 0);
            this.MBtnEditoriales.Size = new System.Drawing.Size(249, 45);
            this.MBtnEditoriales.TabIndex = 7;
            this.MBtnEditoriales.Text = "Editoriales";
            this.MBtnEditoriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnEditoriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnEditoriales.UseVisualStyleBackColor = false;
            this.MBtnEditoriales.Click += new System.EventHandler(this.MBtnEditoriales_Click);
            // 
            // MBtnSeries
            // 
            this.MBtnSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.MBtnSeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnSeries.FlatAppearance.BorderSize = 0;
            this.MBtnSeries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnSeries.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnSeries.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnSeries.IconChar = FontAwesome.Sharp.MaterialIcons.Bookshelf;
            this.MBtnSeries.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnSeries.IconSize = 40;
            this.MBtnSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnSeries.Location = new System.Drawing.Point(0, 397);
            this.MBtnSeries.Name = "MBtnSeries";
            this.MBtnSeries.Padding = new System.Windows.Forms.Padding(45, 0, 20, 0);
            this.MBtnSeries.Size = new System.Drawing.Size(249, 45);
            this.MBtnSeries.TabIndex = 6;
            this.MBtnSeries.Text = "Series";
            this.MBtnSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnSeries.UseVisualStyleBackColor = false;
            this.MBtnSeries.Click += new System.EventHandler(this.MBtnSeries_Click);
            // 
            // MBtnGeneros
            // 
            this.MBtnGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.MBtnGeneros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnGeneros.FlatAppearance.BorderSize = 0;
            this.MBtnGeneros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnGeneros.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnGeneros.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnGeneros.IconChar = FontAwesome.Sharp.MaterialIcons.DramaMasks;
            this.MBtnGeneros.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnGeneros.IconSize = 40;
            this.MBtnGeneros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnGeneros.Location = new System.Drawing.Point(0, 352);
            this.MBtnGeneros.Name = "MBtnGeneros";
            this.MBtnGeneros.Padding = new System.Windows.Forms.Padding(45, 0, 20, 0);
            this.MBtnGeneros.Size = new System.Drawing.Size(249, 45);
            this.MBtnGeneros.TabIndex = 5;
            this.MBtnGeneros.Text = "Géneros";
            this.MBtnGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnGeneros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnGeneros.UseVisualStyleBackColor = false;
            this.MBtnGeneros.Click += new System.EventHandler(this.MBtnGeneros_Click);
            // 
            // MBtnTítulos
            // 
            this.MBtnTítulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.MBtnTítulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnTítulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnTítulos.FlatAppearance.BorderSize = 0;
            this.MBtnTítulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnTítulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnTítulos.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnTítulos.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnTítulos.IconChar = FontAwesome.Sharp.MaterialIcons.TextShadow;
            this.MBtnTítulos.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnTítulos.IconSize = 40;
            this.MBtnTítulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnTítulos.Location = new System.Drawing.Point(0, 307);
            this.MBtnTítulos.Name = "MBtnTítulos";
            this.MBtnTítulos.Padding = new System.Windows.Forms.Padding(45, 0, 20, 0);
            this.MBtnTítulos.Size = new System.Drawing.Size(249, 45);
            this.MBtnTítulos.TabIndex = 4;
            this.MBtnTítulos.Text = "Títulos";
            this.MBtnTítulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnTítulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnTítulos.UseVisualStyleBackColor = false;
            this.MBtnTítulos.Click += new System.EventHandler(this.MBtnTitulos_Click);
            // 
            // MBtnAutores
            // 
            this.MBtnAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.MBtnAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnAutores.FlatAppearance.BorderSize = 0;
            this.MBtnAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAutores.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnAutores.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnAutores.IconChar = FontAwesome.Sharp.MaterialIcons.AccountGroup;
            this.MBtnAutores.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnAutores.IconSize = 40;
            this.MBtnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnAutores.Location = new System.Drawing.Point(0, 262);
            this.MBtnAutores.Name = "MBtnAutores";
            this.MBtnAutores.Padding = new System.Windows.Forms.Padding(45, 0, 20, 0);
            this.MBtnAutores.Size = new System.Drawing.Size(249, 45);
            this.MBtnAutores.TabIndex = 3;
            this.MBtnAutores.Text = "Autores";
            this.MBtnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnAutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnAutores.UseVisualStyleBackColor = false;
            this.MBtnAutores.Click += new System.EventHandler(this.MBtnAutores_Click);
            // 
            // MBtnMiBiblioteca
            // 
            this.MBtnMiBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMiBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtnMiBiblioteca.FlatAppearance.BorderSize = 0;
            this.MBtnMiBiblioteca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(237)))));
            this.MBtnMiBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMiBiblioteca.Font = new System.Drawing.Font("Merienda One", 12F);
            this.MBtnMiBiblioteca.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnMiBiblioteca.IconChar = FontAwesome.Sharp.MaterialIcons.BookOpenPageVariant;
            this.MBtnMiBiblioteca.IconColor = System.Drawing.Color.Gainsboro;
            this.MBtnMiBiblioteca.IconSize = 40;
            this.MBtnMiBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnMiBiblioteca.Location = new System.Drawing.Point(0, 217);
            this.MBtnMiBiblioteca.Name = "MBtnMiBiblioteca";
            this.MBtnMiBiblioteca.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MBtnMiBiblioteca.Size = new System.Drawing.Size(249, 45);
            this.MBtnMiBiblioteca.TabIndex = 1;
            this.MBtnMiBiblioteca.Text = "Mi Biblioteca";
            this.MBtnMiBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtnMiBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtnMiBiblioteca.UseVisualStyleBackColor = true;
            this.MBtnMiBiblioteca.Click += new System.EventHandler(this.MBtnMiBiblioteca_Click);
            // 
            // PanFotoUsuario
            // 
            this.PanFotoUsuario.Controls.Add(this.LlLogIn);
            this.PanFotoUsuario.Controls.Add(this.AciFotoUsuario);
            this.PanFotoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanFotoUsuario.Location = new System.Drawing.Point(0, 0);
            this.PanFotoUsuario.Name = "PanFotoUsuario";
            this.PanFotoUsuario.Size = new System.Drawing.Size(249, 217);
            this.PanFotoUsuario.TabIndex = 0;
            // 
            // LlLogIn
            // 
            this.LlLogIn.AutoSize = true;
            this.LlLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LlLogIn.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlLogIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.LlLogIn.LinkColor = System.Drawing.Color.Gainsboro;
            this.LlLogIn.Location = new System.Drawing.Point(65, 168);
            this.LlLogIn.Name = "LlLogIn";
            this.LlLogIn.Size = new System.Drawing.Size(117, 23);
            this.LlLogIn.TabIndex = 2;
            this.LlLogIn.TabStop = true;
            this.LlLogIn.Text = "Iniciar sesión";
            // 
            // AciFotoUsuario
            // 
            this.AciFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.AciFotoUsuario.Image = global::OpenLibraryEditor.Properties.Resources.desconocido;
            this.AciFotoUsuario.Location = new System.Drawing.Point(60, 25);
            this.AciFotoUsuario.Name = "AciFotoUsuario";
            this.AciFotoUsuario.Size = new System.Drawing.Size(130, 130);
            this.AciFotoUsuario.TabIndex = 0;
            this.AciFotoUsuario.TabStop = false;
            this.ToolTipMain.SetToolTip(this.AciFotoUsuario, "Imagen usuaario");
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.ToolStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolStripMain.AutoSize = false;
            this.ToolStripMain.BackColor = System.Drawing.Color.Navy;
            this.ToolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.ToolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripMain.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAniadirLibroMsb,
            this.BtnModificarLibroMsb,
            this.BtnBorrarLibroMsb,
            this.toolStripSeparator1,
            this.BtnAutoresMsb,
            this.BtnGenerosMsb,
            this.BtnSeriesMsb,
            this.BtnEditorialesMsb,
            this.BtnTagsMsb});
            this.ToolStripMain.Location = new System.Drawing.Point(250, 40);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStripMain.Size = new System.Drawing.Size(949, 65);
            this.ToolStripMain.Stretch = true;
            this.ToolStripMain.TabIndex = 3;
            // 
            // BtnAniadirLibroMsb
            // 
            this.BtnAniadirLibroMsb.BackColor = System.Drawing.Color.Transparent;
            this.BtnAniadirLibroMsb.DropDownButtonWidth = 0;
            this.BtnAniadirLibroMsb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAniadirLibroMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAniadirLibroMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAniadirLibroMsb.IconChar = FontAwesome.Sharp.MaterialIcons.BookCheck;
            this.BtnAniadirLibroMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAniadirLibroMsb.IconSize = 48;
            this.BtnAniadirLibroMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAniadirLibroMsb.Name = "BtnAniadirLibroMsb";
            this.BtnAniadirLibroMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAniadirLibroMsb.Rotation = 0D;
            this.BtnAniadirLibroMsb.Size = new System.Drawing.Size(146, 62);
            this.BtnAniadirLibroMsb.Text = "Añadir nuevo libro";
            this.BtnAniadirLibroMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAniadirLibroMsb.ButtonClick += new System.EventHandler(this.BtnAniadirLibroMsb_ButtonClick);
            // 
            // BtnModificarLibroMsb
            // 
            this.BtnModificarLibroMsb.DropDownButtonWidth = 0;
            this.BtnModificarLibroMsb.Enabled = false;
            this.BtnModificarLibroMsb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnModificarLibroMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold);
            this.BtnModificarLibroMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnModificarLibroMsb.IconChar = FontAwesome.Sharp.MaterialIcons.BookEdit;
            this.BtnModificarLibroMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnModificarLibroMsb.IconSize = 48;
            this.BtnModificarLibroMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificarLibroMsb.Name = "BtnModificarLibroMsb";
            this.BtnModificarLibroMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnModificarLibroMsb.Rotation = 0D;
            this.BtnModificarLibroMsb.Size = new System.Drawing.Size(125, 62);
            this.BtnModificarLibroMsb.Text = "Modificar libro";
            this.BtnModificarLibroMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnModificarLibroMsb.ButtonClick += new System.EventHandler(this.BtnModificarLibroMsb_ButtonClick);
            // 
            // BtnBorrarLibroMsb
            // 
            this.BtnBorrarLibroMsb.DropDownButtonWidth = 0;
            this.BtnBorrarLibroMsb.Enabled = false;
            this.BtnBorrarLibroMsb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnBorrarLibroMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBorrarLibroMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnBorrarLibroMsb.IconChar = FontAwesome.Sharp.MaterialIcons.FileExcel;
            this.BtnBorrarLibroMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnBorrarLibroMsb.IconSize = 48;
            this.BtnBorrarLibroMsb.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrarLibroMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBorrarLibroMsb.Name = "BtnBorrarLibroMsb";
            this.BtnBorrarLibroMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnBorrarLibroMsb.Rotation = 0D;
            this.BtnBorrarLibroMsb.Size = new System.Drawing.Size(119, 62);
            this.BtnBorrarLibroMsb.Text = "Eliminar libro";
            this.BtnBorrarLibroMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBorrarLibroMsb.ButtonClick += new System.EventHandler(this.BtnBorrarLibroMsb_ButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(214)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 65);
            // 
            // BtnAutoresMsb
            // 
            this.BtnAutoresMsb.BackColor = System.Drawing.Color.Navy;
            this.BtnAutoresMsb.DropDownButtonWidth = 0;
            this.BtnAutoresMsb.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnAutoresMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutoresMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAutoresMsb.IconChar = FontAwesome.Sharp.MaterialIcons.AccountMultiplePlus;
            this.BtnAutoresMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAutoresMsb.IconSize = 48;
            this.BtnAutoresMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAutoresMsb.Name = "BtnAutoresMsb";
            this.BtnAutoresMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAutoresMsb.Rotation = 0D;
            this.BtnAutoresMsb.Size = new System.Drawing.Size(79, 62);
            this.BtnAutoresMsb.Text = "Autores";
            this.BtnAutoresMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAutoresMsb.ButtonClick += new System.EventHandler(this.BtnAutoresMsb_ButtonClick);
            // 
            // BtnGenerosMsb
            // 
            this.BtnGenerosMsb.DropDownButtonWidth = 0;
            this.BtnGenerosMsb.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnGenerosMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerosMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnGenerosMsb.IconChar = FontAwesome.Sharp.MaterialIcons.DramaMasks;
            this.BtnGenerosMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnGenerosMsb.IconSize = 48;
            this.BtnGenerosMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGenerosMsb.Name = "BtnGenerosMsb";
            this.BtnGenerosMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnGenerosMsb.Rotation = 0D;
            this.BtnGenerosMsb.Size = new System.Drawing.Size(82, 62);
            this.BtnGenerosMsb.Text = "Géneros";
            this.BtnGenerosMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGenerosMsb.ButtonClick += new System.EventHandler(this.BtnGenerosMsb_ButtonClick);
            // 
            // BtnSeriesMsb
            // 
            this.BtnSeriesMsb.DropDownButtonWidth = 0;
            this.BtnSeriesMsb.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnSeriesMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeriesMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSeriesMsb.IconChar = FontAwesome.Sharp.MaterialIcons.Bookshelf;
            this.BtnSeriesMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnSeriesMsb.IconSize = 48;
            this.BtnSeriesMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSeriesMsb.Name = "BtnSeriesMsb";
            this.BtnSeriesMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnSeriesMsb.Rotation = 0D;
            this.BtnSeriesMsb.Size = new System.Drawing.Size(71, 62);
            this.BtnSeriesMsb.Text = "Series";
            this.BtnSeriesMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSeriesMsb.ButtonClick += new System.EventHandler(this.BtnSeriesMsb_ButtonClick);
            // 
            // BtnEditorialesMsb
            // 
            this.BtnEditorialesMsb.DropDownButtonWidth = 0;
            this.BtnEditorialesMsb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEditorialesMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditorialesMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEditorialesMsb.IconChar = FontAwesome.Sharp.MaterialIcons.BankPlus;
            this.BtnEditorialesMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnEditorialesMsb.IconSize = 48;
            this.BtnEditorialesMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditorialesMsb.Name = "BtnEditorialesMsb";
            this.BtnEditorialesMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnEditorialesMsb.Rotation = 0D;
            this.BtnEditorialesMsb.Size = new System.Drawing.Size(99, 62);
            this.BtnEditorialesMsb.Text = "Editoriales";
            this.BtnEditorialesMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditorialesMsb.ButtonClick += new System.EventHandler(this.BtnEditorialesMsb_ButtonClick);
            // 
            // BtnTagsMsb
            // 
            this.BtnTagsMsb.DropDownButtonWidth = 0;
            this.BtnTagsMsb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTagsMsb.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTagsMsb.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnTagsMsb.IconChar = FontAwesome.Sharp.MaterialIcons.TagPlus;
            this.BtnTagsMsb.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnTagsMsb.IconSize = 48;
            this.BtnTagsMsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnTagsMsb.Name = "BtnTagsMsb";
            this.BtnTagsMsb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnTagsMsb.Rotation = 0D;
            this.BtnTagsMsb.Size = new System.Drawing.Size(61, 62);
            this.BtnTagsMsb.Text = "Tags";
            this.BtnTagsMsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTagsMsb.ButtonClick += new System.EventHandler(this.BtnTagsMsb_ButtonClick);
            // 
            // PanFormHijos
            // 
            this.PanFormHijos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanFormHijos.BackColor = System.Drawing.Color.Gainsboro;
            this.PanFormHijos.Controls.Add(this.pictureBox1);
            this.PanFormHijos.Location = new System.Drawing.Point(250, 105);
            this.PanFormHijos.Name = "PanFormHijos";
            this.PanFormHijos.Size = new System.Drawing.Size(948, 693);
            this.PanFormHijos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.pictureBox1.Location = new System.Drawing.Point(274, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanFormHijos);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.PanMenuMain);
            this.Controls.Add(this.PanTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 750);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanTitulo.PerformLayout();
            this.PanButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoMain)).EndInit();
            this.PanMenuMain.ResumeLayout(false);
            this.PanFotoUsuario.ResumeLayout(false);
            this.PanFotoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AciFotoUsuario)).EndInit();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.PanFormHijos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTitulo;
        private System.Windows.Forms.Panel PanMenuMain;
        private System.Windows.Forms.Label LblTituloMain;
        private System.Windows.Forms.PictureBox PcbLogoMain;
        private System.Windows.Forms.Panel PanButtons;
        private System.Windows.Forms.Panel PanFotoUsuario;
        private AfriCircleImage.AfriCircleImage AciFotoUsuario;
        private System.Windows.Forms.LinkLabel LlLogIn;
        private FontAwesome.Sharp.Material.MaterialButton MBtnEditoriales;
        private FontAwesome.Sharp.Material.MaterialButton MBtnSeries;
        private FontAwesome.Sharp.Material.MaterialButton MBtnGeneros;
        private FontAwesome.Sharp.Material.MaterialButton MBtnTítulos;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAutores;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMiBiblioteca;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnAniadirLibroMsb;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnModificarLibroMsb;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnBorrarLibroMsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnGenerosMsb;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnSeriesMsb;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnEditorialesMsb;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnTagsMsb;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarMain;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMaximizarMain;
        private FontAwesome.Sharp.Material.MaterialButton MBtnTags;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMinimizarMain;
        private FontAwesome.Sharp.Material.MaterialButton MBtnConfiguracion;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscar;
        private FontAwesome.Sharp.Material.MaterialSplitButton BtnAutoresMsb;
        private FontAwesome.Sharp.Material.MaterialButton MBtnRestaurarMain;
        private FontAwesome.Sharp.Material.MaterialButton MBtnSalir;
        private System.Windows.Forms.Panel PanSeparadorMain;
        private System.Windows.Forms.Panel PanFormHijos;
        private System.Windows.Forms.ToolTip ToolTipMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}