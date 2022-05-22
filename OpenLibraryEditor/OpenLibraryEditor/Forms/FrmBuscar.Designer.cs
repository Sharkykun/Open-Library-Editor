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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.KCmbTipoBusquedaBUS = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.KTxtBuscarBUS = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PanTituloBuscar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloBuscar = new System.Windows.Forms.Label();
            this.MPcbBuscar = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.LsvBuscarLibros = new System.Windows.Forms.ListView();
            this.ChPortada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanPiePagina = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KCmbServidoresBUS = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblBuscarPorBUS = new System.Windows.Forms.Label();
            this.FlPanBuscar = new System.Windows.Forms.FlowLayoutPanel();
            this.MBtnBuscarBUS = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanRecomendaciones = new System.Windows.Forms.Panel();
            this.LblRecomendaciones = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanLibrosBuscar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MBtnAvanzarLibro = new FontAwesome.Sharp.Material.MaterialButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MbtnAtrasLibro = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanLsvBusqueda = new System.Windows.Forms.Panel();
            this.TTBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.TxtBusqueda = new OpenLibraryEditor.Controles.TxtBusqueda();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoBusquedaBUS)).BeginInit();
            this.PanTituloBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbBuscar)).BeginInit();
            this.PanPiePagina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbServidoresBUS)).BeginInit();
            this.FlPanBuscar.SuspendLayout();
            this.PanRecomendaciones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PanLsvBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // KCmbTipoBusquedaBUS
            // 
            this.KCmbTipoBusquedaBUS.DropDownWidth = 160;
            this.KCmbTipoBusquedaBUS.Location = new System.Drawing.Point(282, 3);
            this.KCmbTipoBusquedaBUS.Name = "KCmbTipoBusquedaBUS";
            this.KCmbTipoBusquedaBUS.Size = new System.Drawing.Size(161, 33);
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoBusquedaBUS.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoBusquedaBUS.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoBusquedaBUS.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoBusquedaBUS.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoBusquedaBUS.TabIndex = 127;
            // 
            // KTxtBuscarBUS
            // 
            this.KTxtBuscarBUS.Location = new System.Drawing.Point(0, 45);
            this.KTxtBuscarBUS.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.KTxtBuscarBUS.Name = "KTxtBuscarBUS";
            this.KTxtBuscarBUS.Size = new System.Drawing.Size(349, 33);
            this.KTxtBuscarBUS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.KTxtBuscarBUS.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarBUS.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarBUS.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtBuscarBUS.StateCommon.Border.Rounding = 10;
            this.KTxtBuscarBUS.StateCommon.Border.Width = 2;
            this.KTxtBuscarBUS.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtBuscarBUS.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtBuscarBUS.TabIndex = 125;
            this.KTxtBuscarBUS.Visible = false;
            this.KTxtBuscarBUS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KTxtBuscarBUS_KeyDown);
            // 
            // PanTituloBuscar
            // 
            this.PanTituloBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.PanTituloBuscar.Controls.Add(this.panel2);
            this.PanTituloBuscar.Controls.Add(this.LblTituloBuscar);
            this.PanTituloBuscar.Controls.Add(this.MPcbBuscar);
            this.PanTituloBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloBuscar.Location = new System.Drawing.Point(0, 0);
            this.PanTituloBuscar.Name = "PanTituloBuscar";
            this.PanTituloBuscar.Size = new System.Drawing.Size(948, 64);
            this.PanTituloBuscar.TabIndex = 10;
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
            this.LblTituloBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblTituloBuscar.Location = new System.Drawing.Point(75, 18);
            this.LblTituloBuscar.Name = "LblTituloBuscar";
            this.LblTituloBuscar.Size = new System.Drawing.Size(95, 32);
            this.LblTituloBuscar.TabIndex = 10;
            this.LblTituloBuscar.Text = "Buscar";
            // 
            // MPcbBuscar
            // 
            this.MPcbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.MPcbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MPcbBuscar.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MPcbBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MPcbBuscar.IconSize = 40;
            this.MPcbBuscar.Location = new System.Drawing.Point(40, 15);
            this.MPcbBuscar.Name = "MPcbBuscar";
            this.MPcbBuscar.Size = new System.Drawing.Size(40, 40);
            this.MPcbBuscar.TabIndex = 12;
            this.MPcbBuscar.TabStop = false;
            // 
            // LsvBuscarLibros
            // 
            this.LsvBuscarLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvBuscarLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LsvBuscarLibros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvBuscarLibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChPortada});
            this.LsvBuscarLibros.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvBuscarLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LsvBuscarLibros.HideSelection = false;
            this.LsvBuscarLibros.Location = new System.Drawing.Point(15, 6);
            this.LsvBuscarLibros.MultiSelect = false;
            this.LsvBuscarLibros.Name = "LsvBuscarLibros";
            this.LsvBuscarLibros.Size = new System.Drawing.Size(918, 278);
            this.LsvBuscarLibros.TabIndex = 140;
            this.LsvBuscarLibros.UseCompatibleStateImageBehavior = false;
            this.LsvBuscarLibros.View = System.Windows.Forms.View.Details;
            this.LsvBuscarLibros.DoubleClick += new System.EventHandler(this.LsvSeriesNS_DoubleClick);
            // 
            // ChPortada
            // 
            this.ChPortada.Text = "";
            this.ChPortada.Width = 875;
            // 
            // PanPiePagina
            // 
            this.PanPiePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanPiePagina.Controls.Add(this.panel1);
            this.PanPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanPiePagina.Location = new System.Drawing.Point(0, 646);
            this.PanPiePagina.Name = "PanPiePagina";
            this.PanPiePagina.Size = new System.Drawing.Size(948, 47);
            this.PanPiePagina.TabIndex = 141;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 4);
            this.panel1.TabIndex = 0;
            // 
            // KCmbServidoresBUS
            // 
            this.KCmbServidoresBUS.DropDownWidth = 160;
            this.KCmbServidoresBUS.Location = new System.Drawing.Point(115, 3);
            this.KCmbServidoresBUS.Name = "KCmbServidoresBUS";
            this.KCmbServidoresBUS.Size = new System.Drawing.Size(161, 33);
            this.KCmbServidoresBUS.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbServidoresBUS.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbServidoresBUS.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbServidoresBUS.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbServidoresBUS.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbServidoresBUS.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbServidoresBUS.TabIndex = 108;
            this.KCmbServidoresBUS.SelectedIndexChanged += new System.EventHandler(this.KCmbServidoresBUS_SelectedIndexChanged);
            // 
            // LblBuscarPorBUS
            // 
            this.LblBuscarPorBUS.AutoSize = true;
            this.LblBuscarPorBUS.Font = new System.Drawing.Font("Merienda One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarPorBUS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblBuscarPorBUS.Location = new System.Drawing.Point(3, 0);
            this.LblBuscarPorBUS.Name = "LblBuscarPorBUS";
            this.LblBuscarPorBUS.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.LblBuscarPorBUS.Size = new System.Drawing.Size(106, 28);
            this.LblBuscarPorBUS.TabIndex = 8;
            this.LblBuscarPorBUS.Text = "Buscar en:";
            // 
            // FlPanBuscar
            // 
            this.FlPanBuscar.AutoSize = true;
            this.FlPanBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlPanBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.FlPanBuscar.Controls.Add(this.LblBuscarPorBUS);
            this.FlPanBuscar.Controls.Add(this.KCmbServidoresBUS);
            this.FlPanBuscar.Controls.Add(this.KCmbTipoBusquedaBUS);
            this.FlPanBuscar.Controls.Add(this.TxtBusqueda);
            this.FlPanBuscar.Controls.Add(this.MBtnBuscarBUS);
            this.FlPanBuscar.Controls.Add(this.KTxtBuscarBUS);
            this.FlPanBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlPanBuscar.Location = new System.Drawing.Point(0, 64);
            this.FlPanBuscar.Name = "FlPanBuscar";
            this.FlPanBuscar.Size = new System.Drawing.Size(948, 78);
            this.FlPanBuscar.TabIndex = 142;
            // 
            // MBtnBuscarBUS
            // 
            this.MBtnBuscarBUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnBuscarBUS.FlatAppearance.BorderSize = 0;
            this.MBtnBuscarBUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnBuscarBUS.ForeColor = System.Drawing.Color.Gainsboro;
            this.MBtnBuscarBUS.IconChar = FontAwesome.Sharp.MaterialIcons.Magnify;
            this.MBtnBuscarBUS.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnBuscarBUS.IconSize = 45;
            this.MBtnBuscarBUS.Location = new System.Drawing.Point(718, 3);
            this.MBtnBuscarBUS.Name = "MBtnBuscarBUS";
            this.MBtnBuscarBUS.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnBuscarBUS.Size = new System.Drawing.Size(34, 34);
            this.MBtnBuscarBUS.TabIndex = 126;
            this.MBtnBuscarBUS.UseVisualStyleBackColor = true;
            this.MBtnBuscarBUS.Click += new System.EventHandler(this.MBtnBuscarBUS_Click);
            // 
            // PanRecomendaciones
            // 
            this.PanRecomendaciones.Controls.Add(this.LblRecomendaciones);
            this.PanRecomendaciones.Controls.Add(this.panel3);
            this.PanRecomendaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanRecomendaciones.Location = new System.Drawing.Point(0, 142);
            this.PanRecomendaciones.Name = "PanRecomendaciones";
            this.PanRecomendaciones.Size = new System.Drawing.Size(948, 214);
            this.PanRecomendaciones.TabIndex = 144;
            // 
            // LblRecomendaciones
            // 
            this.LblRecomendaciones.AutoSize = true;
            this.LblRecomendaciones.Font = new System.Drawing.Font("Merienda One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecomendaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblRecomendaciones.Location = new System.Drawing.Point(11, 15);
            this.LblRecomendaciones.Name = "LblRecomendaciones";
            this.LblRecomendaciones.Size = new System.Drawing.Size(168, 23);
            this.LblRecomendaciones.TabIndex = 11;
            this.LblRecomendaciones.Text = "Recomendaciones";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.PanLibrosBuscar);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(12, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 145);
            this.panel3.TabIndex = 0;
            // 
            // PanLibrosBuscar
            // 
            this.PanLibrosBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLibrosBuscar.Location = new System.Drawing.Point(40, 0);
            this.PanLibrosBuscar.Name = "PanLibrosBuscar";
            this.PanLibrosBuscar.Size = new System.Drawing.Size(838, 145);
            this.PanLibrosBuscar.TabIndex = 2;
            this.PanLibrosBuscar.SizeChanged += new System.EventHandler(this.PanLibrosBuscar_SizeChanged);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.MBtnAvanzarLibro);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(878, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 145);
            this.panel6.TabIndex = 1;
            // 
            // MBtnAvanzarLibro
            // 
            this.MBtnAvanzarLibro.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnAvanzarLibro.FlatAppearance.BorderSize = 0;
            this.MBtnAvanzarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnAvanzarLibro.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.MBtnAvanzarLibro.IconChar = FontAwesome.Sharp.MaterialIcons.ArrowLeftBoldCircle;
            this.MBtnAvanzarLibro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MBtnAvanzarLibro.IconSize = 55;
            this.MBtnAvanzarLibro.Location = new System.Drawing.Point(0, 0);
            this.MBtnAvanzarLibro.Name = "MBtnAvanzarLibro";
            this.MBtnAvanzarLibro.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MBtnAvanzarLibro.Size = new System.Drawing.Size(40, 145);
            this.MBtnAvanzarLibro.TabIndex = 1;
            this.MBtnAvanzarLibro.UseVisualStyleBackColor = true;
            this.MBtnAvanzarLibro.Click += new System.EventHandler(this.MBtnAvanzarLibro_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.MbtnAtrasLibro);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 145);
            this.panel5.TabIndex = 0;
            // 
            // MbtnAtrasLibro
            // 
            this.MbtnAtrasLibro.Dock = System.Windows.Forms.DockStyle.Left;
            this.MbtnAtrasLibro.FlatAppearance.BorderSize = 0;
            this.MbtnAtrasLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbtnAtrasLibro.IconChar = FontAwesome.Sharp.MaterialIcons.ArrowLeftBoldCircle;
            this.MbtnAtrasLibro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.MbtnAtrasLibro.IconSize = 55;
            this.MbtnAtrasLibro.Location = new System.Drawing.Point(0, 0);
            this.MbtnAtrasLibro.Name = "MbtnAtrasLibro";
            this.MbtnAtrasLibro.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MbtnAtrasLibro.Size = new System.Drawing.Size(40, 145);
            this.MbtnAtrasLibro.TabIndex = 0;
            this.MbtnAtrasLibro.UseVisualStyleBackColor = true;
            this.MbtnAtrasLibro.Click += new System.EventHandler(this.MbtnAtrasLibro_Click);
            // 
            // PanLsvBusqueda
            // 
            this.PanLsvBusqueda.Controls.Add(this.LsvBuscarLibros);
            this.PanLsvBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLsvBusqueda.Location = new System.Drawing.Point(0, 356);
            this.PanLsvBusqueda.Name = "PanLsvBusqueda";
            this.PanLsvBusqueda.Size = new System.Drawing.Size(948, 290);
            this.PanLsvBusqueda.TabIndex = 145;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.TxtBusqueda.Location = new System.Drawing.Point(449, 3);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(263, 36);
            this.TxtBusqueda.TabIndex = 128;
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KTxtBuscarBUS_KeyDown);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(948, 693);
            this.Controls.Add(this.PanLsvBusqueda);
            this.Controls.Add(this.PanRecomendaciones);
            this.Controls.Add(this.FlPanBuscar);
            this.Controls.Add(this.PanPiePagina);
            this.Controls.Add(this.PanTituloBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoBusquedaBUS)).EndInit();
            this.PanTituloBuscar.ResumeLayout(false);
            this.PanTituloBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPcbBuscar)).EndInit();
            this.PanPiePagina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbServidoresBUS)).EndInit();
            this.FlPanBuscar.ResumeLayout(false);
            this.FlPanBuscar.PerformLayout();
            this.PanRecomendaciones.ResumeLayout(false);
            this.PanRecomendaciones.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.PanLsvBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtBuscarBUS;
        private System.Windows.Forms.Panel PanTituloBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloBuscar;
        private FontAwesome.Sharp.Material.MaterialPictureBox MPcbBuscar;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbTipoBusquedaBUS;
        private System.Windows.Forms.ListView LsvBuscarLibros;
        private System.Windows.Forms.ColumnHeader ChPortada;
        private System.Windows.Forms.Panel PanPiePagina;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbServidoresBUS;
        private System.Windows.Forms.Label LblBuscarPorBUS;
        private System.Windows.Forms.FlowLayoutPanel FlPanBuscar;
        private FontAwesome.Sharp.Material.MaterialButton MBtnBuscarBUS;
        private System.Windows.Forms.Panel PanRecomendaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanLsvBusqueda;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.Material.MaterialButton MBtnAvanzarLibro;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.Material.MaterialButton MbtnAtrasLibro;
        private System.Windows.Forms.Label LblRecomendaciones;
        private System.Windows.Forms.Panel PanLibrosBuscar;
        private System.Windows.Forms.ToolTip TTBuscar;
        private Controles.TxtBusqueda TxtBusqueda;
    }
}