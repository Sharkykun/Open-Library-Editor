namespace OpenLibraryEditor.Forms
{
    partial class FrmEjecutable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjecutable));
            this.PanBtnEje = new System.Windows.Forms.Panel();
            this.GBtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.PanTituloEjecutables = new System.Windows.Forms.Panel();
            this.MBtnCerrarEjecutable = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloEjecutable = new System.Windows.Forms.Label();
            this.PcbLogoEjecutable = new System.Windows.Forms.PictureBox();
            this.MBtnMasLsvEJ = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvEJ = new FontAwesome.Sharp.Material.MaterialButton();
            this.LsvEjecutable = new System.Windows.Forms.ListView();
            this.ChNombreEJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChExtensionEJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanOpcionesEJ = new System.Windows.Forms.Panel();
            this.IBtnBuscarRutaEJ = new FontAwesome.Sharp.IconButton();
            this.LblArgumentosEJ = new System.Windows.Forms.Label();
            this.KTxtArgumentosEJ = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblRutaEJ = new System.Windows.Forms.Label();
            this.LblExtensionEJ = new System.Windows.Forms.Label();
            this.KTxtExtensionEJ = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblNombreEJ = new System.Windows.Forms.Label();
            this.KTxtNombreEJ = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtRutaEJ = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TTEjecutable = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanBtnEje.SuspendLayout();
            this.PanTituloEjecutables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEjecutable)).BeginInit();
            this.PanOpcionesEJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanBtnEje
            // 
            this.PanBtnEje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtnEje.Controls.Add(this.GBtnAceptar);
            this.PanBtnEje.Controls.Add(this.GBtnCancelar);
            this.PanBtnEje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnEje.Location = new System.Drawing.Point(0, 454);
            this.PanBtnEje.Name = "PanBtnEje";
            this.PanBtnEje.Size = new System.Drawing.Size(812, 45);
            this.PanBtnEje.TabIndex = 100;
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
            this.GBtnAceptar.Location = new System.Drawing.Point(670, 5);
            this.GBtnAceptar.Name = "GBtnAceptar";
            this.GBtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnAceptar.OnHoverImage = null;
            this.GBtnAceptar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.Radius = 15;
            this.GBtnAceptar.Size = new System.Drawing.Size(126, 35);
            this.GBtnAceptar.TabIndex = 5;
            this.GBtnAceptar.Text = "Aceptar";
            this.GBtnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnAceptar.Click += new System.EventHandler(this.GBtnAceptar_Click);
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
            this.GBtnCancelar.Location = new System.Drawing.Point(532, 5);
            this.GBtnCancelar.Name = "GBtnCancelar";
            this.GBtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.OnHoverForeColor = System.Drawing.Color.Black;
            this.GBtnCancelar.OnHoverImage = null;
            this.GBtnCancelar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.Radius = 15;
            this.GBtnCancelar.Size = new System.Drawing.Size(126, 35);
            this.GBtnCancelar.TabIndex = 4;
            this.GBtnCancelar.Text = "Cancelar";
            this.GBtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCancelar.Click += new System.EventHandler(this.GBtnCancelar_Click);
            // 
            // PanTituloEjecutables
            // 
            this.PanTituloEjecutables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloEjecutables.Controls.Add(this.MBtnCerrarEjecutable);
            this.PanTituloEjecutables.Controls.Add(this.LblTituloEjecutable);
            this.PanTituloEjecutables.Controls.Add(this.PcbLogoEjecutable);
            this.PanTituloEjecutables.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloEjecutables.Location = new System.Drawing.Point(0, 0);
            this.PanTituloEjecutables.Name = "PanTituloEjecutables";
            this.PanTituloEjecutables.Size = new System.Drawing.Size(812, 40);
            this.PanTituloEjecutables.TabIndex = 99;
            this.PanTituloEjecutables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloEjecutables_MouseDown);
            // 
            // MBtnCerrarEjecutable
            // 
            this.MBtnCerrarEjecutable.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarEjecutable.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarEjecutable.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarEjecutable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarEjecutable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarEjecutable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarEjecutable.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarEjecutable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarEjecutable.IconSize = 40;
            this.MBtnCerrarEjecutable.Location = new System.Drawing.Point(780, 0);
            this.MBtnCerrarEjecutable.Name = "MBtnCerrarEjecutable";
            this.MBtnCerrarEjecutable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarEjecutable.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarEjecutable.TabIndex = 28;
            this.MBtnCerrarEjecutable.UseVisualStyleBackColor = false;
            this.MBtnCerrarEjecutable.Click += new System.EventHandler(this.MBtnCerrarEjecutable_Click);
            // 
            // LblTituloEjecutable
            // 
            this.LblTituloEjecutable.AutoSize = true;
            this.LblTituloEjecutable.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloEjecutable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTituloEjecutable.Location = new System.Drawing.Point(54, 9);
            this.LblTituloEjecutable.Name = "LblTituloEjecutable";
            this.LblTituloEjecutable.Size = new System.Drawing.Size(267, 23);
            this.LblTituloEjecutable.TabIndex = 4;
            this.LblTituloEjecutable.Text = "Open Library Editor - Ejecutable";
            // 
            // PcbLogoEjecutable
            // 
            this.PcbLogoEjecutable.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoEjecutable.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoEjecutable.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoEjecutable.Name = "PcbLogoEjecutable";
            this.PcbLogoEjecutable.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoEjecutable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoEjecutable.TabIndex = 3;
            this.PcbLogoEjecutable.TabStop = false;
            // 
            // MBtnMasLsvEJ
            // 
            this.MBtnMasLsvEJ.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvEJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvEJ.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvEJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvEJ.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvEJ.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvEJ.IconSize = 65;
            this.MBtnMasLsvEJ.Location = new System.Drawing.Point(25, 389);
            this.MBtnMasLsvEJ.Name = "MBtnMasLsvEJ";
            this.MBtnMasLsvEJ.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvEJ.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvEJ.TabIndex = 142;
            this.MBtnMasLsvEJ.UseVisualStyleBackColor = false;
            this.MBtnMasLsvEJ.Click += new System.EventHandler(this.MBtnMasLsvEJ_Click);
            // 
            // MBtnMenosLsvEJ
            // 
            this.MBtnMenosLsvEJ.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvEJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvEJ.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvEJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvEJ.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvEJ.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvEJ.IconSize = 65;
            this.MBtnMenosLsvEJ.Location = new System.Drawing.Point(76, 389);
            this.MBtnMenosLsvEJ.Name = "MBtnMenosLsvEJ";
            this.MBtnMenosLsvEJ.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvEJ.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvEJ.TabIndex = 143;
            this.MBtnMenosLsvEJ.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvEJ.Click += new System.EventHandler(this.MBtnMenosLsvEJ_Click);
            // 
            // LsvEjecutable
            // 
            this.LsvEjecutable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LsvEjecutable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvEjecutable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreEJ,
            this.ChExtensionEJ});
            this.LsvEjecutable.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvEjecutable.HideSelection = false;
            this.LsvEjecutable.Location = new System.Drawing.Point(25, 70);
            this.LsvEjecutable.MultiSelect = false;
            this.LsvEjecutable.Name = "LsvEjecutable";
            this.LsvEjecutable.Size = new System.Drawing.Size(336, 313);
            this.LsvEjecutable.TabIndex = 141;
            this.LsvEjecutable.UseCompatibleStateImageBehavior = false;
            this.LsvEjecutable.View = System.Windows.Forms.View.Details;
            this.LsvEjecutable.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvEjecutable_ItemSelectionChanged);
            // 
            // ChNombreEJ
            // 
            this.ChNombreEJ.Text = "Nombre";
            this.ChNombreEJ.Width = 127;
            // 
            // ChExtensionEJ
            // 
            this.ChExtensionEJ.Text = "Extensión";
            this.ChExtensionEJ.Width = 196;
            // 
            // PanOpcionesEJ
            // 
            this.PanOpcionesEJ.Controls.Add(this.IBtnBuscarRutaEJ);
            this.PanOpcionesEJ.Controls.Add(this.LblArgumentosEJ);
            this.PanOpcionesEJ.Controls.Add(this.KTxtArgumentosEJ);
            this.PanOpcionesEJ.Controls.Add(this.LblRutaEJ);
            this.PanOpcionesEJ.Controls.Add(this.LblExtensionEJ);
            this.PanOpcionesEJ.Controls.Add(this.KTxtExtensionEJ);
            this.PanOpcionesEJ.Controls.Add(this.LblNombreEJ);
            this.PanOpcionesEJ.Controls.Add(this.KTxtNombreEJ);
            this.PanOpcionesEJ.Controls.Add(this.KTxtRutaEJ);
            this.PanOpcionesEJ.Location = new System.Drawing.Point(377, 58);
            this.PanOpcionesEJ.Name = "PanOpcionesEJ";
            this.PanOpcionesEJ.Size = new System.Drawing.Size(402, 348);
            this.PanOpcionesEJ.TabIndex = 151;
            this.PanOpcionesEJ.Visible = false;
            // 
            // IBtnBuscarRutaEJ
            // 
            this.IBtnBuscarRutaEJ.BackColor = System.Drawing.Color.Transparent;
            this.IBtnBuscarRutaEJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnBuscarRutaEJ.FlatAppearance.BorderSize = 0;
            this.IBtnBuscarRutaEJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnBuscarRutaEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.IBtnBuscarRutaEJ.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.IBtnBuscarRutaEJ.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.IBtnBuscarRutaEJ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnBuscarRutaEJ.IconSize = 25;
            this.IBtnBuscarRutaEJ.Location = new System.Drawing.Point(340, 189);
            this.IBtnBuscarRutaEJ.Name = "IBtnBuscarRutaEJ";
            this.IBtnBuscarRutaEJ.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.IBtnBuscarRutaEJ.Size = new System.Drawing.Size(20, 20);
            this.IBtnBuscarRutaEJ.TabIndex = 159;
            this.IBtnBuscarRutaEJ.UseVisualStyleBackColor = false;
            this.IBtnBuscarRutaEJ.Click += new System.EventHandler(this.IBtnBuscarRutaEJ_Click);
            // 
            // LblArgumentosEJ
            // 
            this.LblArgumentosEJ.AutoSize = true;
            this.LblArgumentosEJ.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArgumentosEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblArgumentosEJ.Location = new System.Drawing.Point(25, 232);
            this.LblArgumentosEJ.Name = "LblArgumentosEJ";
            this.LblArgumentosEJ.Size = new System.Drawing.Size(92, 20);
            this.LblArgumentosEJ.TabIndex = 158;
            this.LblArgumentosEJ.Text = "Argumentos";
            // 
            // KTxtArgumentosEJ
            // 
            this.KTxtArgumentosEJ.Location = new System.Drawing.Point(25, 257);
            this.KTxtArgumentosEJ.Name = "KTxtArgumentosEJ";
            this.KTxtArgumentosEJ.Size = new System.Drawing.Size(346, 33);
            this.KTxtArgumentosEJ.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtArgumentosEJ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtArgumentosEJ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtArgumentosEJ.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtArgumentosEJ.StateCommon.Border.Rounding = 10;
            this.KTxtArgumentosEJ.StateCommon.Border.Width = 2;
            this.KTxtArgumentosEJ.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtArgumentosEJ.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtArgumentosEJ.TabIndex = 157;
            // 
            // LblRutaEJ
            // 
            this.LblRutaEJ.AutoSize = true;
            this.LblRutaEJ.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutaEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblRutaEJ.Location = new System.Drawing.Point(25, 157);
            this.LblRutaEJ.Name = "LblRutaEJ";
            this.LblRutaEJ.Size = new System.Drawing.Size(143, 20);
            this.LblRutaEJ.TabIndex = 156;
            this.LblRutaEJ.Text = "Ruta del ejecutable";
            // 
            // LblExtensionEJ
            // 
            this.LblExtensionEJ.AutoSize = true;
            this.LblExtensionEJ.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExtensionEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblExtensionEJ.Location = new System.Drawing.Point(25, 83);
            this.LblExtensionEJ.Name = "LblExtensionEJ";
            this.LblExtensionEJ.Size = new System.Drawing.Size(146, 20);
            this.LblExtensionEJ.TabIndex = 154;
            this.LblExtensionEJ.Text = "Extensión asociada";
            // 
            // KTxtExtensionEJ
            // 
            this.KTxtExtensionEJ.Location = new System.Drawing.Point(25, 108);
            this.KTxtExtensionEJ.Name = "KTxtExtensionEJ";
            this.KTxtExtensionEJ.Size = new System.Drawing.Size(346, 33);
            this.KTxtExtensionEJ.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtExtensionEJ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtExtensionEJ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtExtensionEJ.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtExtensionEJ.StateCommon.Border.Rounding = 10;
            this.KTxtExtensionEJ.StateCommon.Border.Width = 2;
            this.KTxtExtensionEJ.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtExtensionEJ.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtExtensionEJ.TabIndex = 153;
            // 
            // LblNombreEJ
            // 
            this.LblNombreEJ.AutoSize = true;
            this.LblNombreEJ.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblNombreEJ.Location = new System.Drawing.Point(25, 12);
            this.LblNombreEJ.Name = "LblNombreEJ";
            this.LblNombreEJ.Size = new System.Drawing.Size(143, 20);
            this.LblNombreEJ.TabIndex = 152;
            this.LblNombreEJ.Text = "Nombre ejecutable";
            // 
            // KTxtNombreEJ
            // 
            this.KTxtNombreEJ.Location = new System.Drawing.Point(25, 37);
            this.KTxtNombreEJ.Name = "KTxtNombreEJ";
            this.KTxtNombreEJ.Size = new System.Drawing.Size(346, 33);
            this.KTxtNombreEJ.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreEJ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreEJ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreEJ.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreEJ.StateCommon.Border.Rounding = 10;
            this.KTxtNombreEJ.StateCommon.Border.Width = 2;
            this.KTxtNombreEJ.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreEJ.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreEJ.TabIndex = 151;
            // 
            // KTxtRutaEJ
            // 
            this.KTxtRutaEJ.Location = new System.Drawing.Point(25, 182);
            this.KTxtRutaEJ.Name = "KTxtRutaEJ";
            this.KTxtRutaEJ.Size = new System.Drawing.Size(346, 33);
            this.KTxtRutaEJ.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtRutaEJ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtRutaEJ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtRutaEJ.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtRutaEJ.StateCommon.Border.Rounding = 10;
            this.KTxtRutaEJ.StateCommon.Border.Width = 2;
            this.KTxtRutaEJ.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtRutaEJ.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtRutaEJ.TabIndex = 155;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(809, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 414);
            this.panel2.TabIndex = 152;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 414);
            this.panel1.TabIndex = 153;
            // 
            // FrmEjecutable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(812, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MBtnMasLsvEJ);
            this.Controls.Add(this.MBtnMenosLsvEJ);
            this.Controls.Add(this.LsvEjecutable);
            this.Controls.Add(this.PanBtnEje);
            this.Controls.Add(this.PanTituloEjecutables);
            this.Controls.Add(this.PanOpcionesEJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEjecutable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjecutable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEjecutable_FormClosing);
            this.Load += new System.EventHandler(this.FrmEjecutable_Load);
            this.PanBtnEje.ResumeLayout(false);
            this.PanTituloEjecutables.ResumeLayout(false);
            this.PanTituloEjecutables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEjecutable)).EndInit();
            this.PanOpcionesEJ.ResumeLayout(false);
            this.PanOpcionesEJ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBtnEje;
        private System.Windows.Forms.Panel PanTituloEjecutables;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarEjecutable;
        private System.Windows.Forms.Label LblTituloEjecutable;
        private System.Windows.Forms.PictureBox PcbLogoEjecutable;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvEJ;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvEJ;
        private System.Windows.Forms.ListView LsvEjecutable;
        private System.Windows.Forms.ColumnHeader ChNombreEJ;
        private System.Windows.Forms.ColumnHeader ChExtensionEJ;
        private System.Windows.Forms.Panel PanOpcionesEJ;
        private FontAwesome.Sharp.IconButton IBtnBuscarRutaEJ;
        private System.Windows.Forms.Label LblArgumentosEJ;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtArgumentosEJ;
        private System.Windows.Forms.Label LblRutaEJ;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtRutaEJ;
        private System.Windows.Forms.Label LblExtensionEJ;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtExtensionEJ;
        private System.Windows.Forms.Label LblNombreEJ;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreEJ;
        private System.Windows.Forms.ToolTip TTEjecutable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton GBtnAceptar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
    }
}