namespace OpenLibraryEditor.Forms
{
    partial class FrmGeneros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneros));
            this.PanTituloGeneros = new System.Windows.Forms.Panel();
            this.MBtnCerrarGeneros = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTituloGeneros = new System.Windows.Forms.Label();
            this.PcbLogoGeneros = new System.Windows.Forms.PictureBox();
            this.PanBtnGe = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GBtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.GBtnActualizar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.LsvGeneroNG = new System.Windows.Forms.ListView();
            this.ChNombreNG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MBtnMasLsvNG = new FontAwesome.Sharp.Material.MaterialButton();
            this.MBtnMenosLsvNG = new FontAwesome.Sharp.Material.MaterialButton();
            this.PanOpcionesGE = new System.Windows.Forms.Panel();
            this.LblObligatorio = new System.Windows.Forms.Label();
            this.LblNombreGe = new System.Windows.Forms.Label();
            this.KTxtNombreGe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblComentarioGe = new System.Windows.Forms.Label();
            this.KTxtComentarioGe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TTGeneros = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanTituloGeneros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoGeneros)).BeginInit();
            this.PanBtnGe.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanOpcionesGE.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTituloGeneros
            // 
            this.PanTituloGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloGeneros.Controls.Add(this.MBtnCerrarGeneros);
            this.PanTituloGeneros.Controls.Add(this.LblTituloGeneros);
            this.PanTituloGeneros.Controls.Add(this.PcbLogoGeneros);
            this.PanTituloGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloGeneros.Location = new System.Drawing.Point(0, 0);
            this.PanTituloGeneros.Name = "PanTituloGeneros";
            this.PanTituloGeneros.Size = new System.Drawing.Size(805, 40);
            this.PanTituloGeneros.TabIndex = 2;
            this.PanTituloGeneros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloGeneros_MouseDown);
            // 
            // MBtnCerrarGeneros
            // 
            this.MBtnCerrarGeneros.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarGeneros.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarGeneros.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarGeneros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarGeneros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarGeneros.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarGeneros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarGeneros.IconSize = 40;
            this.MBtnCerrarGeneros.Location = new System.Drawing.Point(773, 0);
            this.MBtnCerrarGeneros.Name = "MBtnCerrarGeneros";
            this.MBtnCerrarGeneros.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarGeneros.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarGeneros.TabIndex = 0;
            this.MBtnCerrarGeneros.UseVisualStyleBackColor = false;
            this.MBtnCerrarGeneros.Click += new System.EventHandler(this.MBtnCerrarGeneros_Click);
            // 
            // LblTituloGeneros
            // 
            this.LblTituloGeneros.AutoSize = true;
            this.LblTituloGeneros.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloGeneros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTituloGeneros.Location = new System.Drawing.Point(54, 9);
            this.LblTituloGeneros.Name = "LblTituloGeneros";
            this.LblTituloGeneros.Size = new System.Drawing.Size(295, 23);
            this.LblTituloGeneros.TabIndex = 4;
            this.LblTituloGeneros.Text = "Open Library Editor - Nuevo Género";
            this.LblTituloGeneros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloGeneros_MouseDown);
            // 
            // PcbLogoGeneros
            // 
            this.PcbLogoGeneros.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoGeneros.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoGeneros.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoGeneros.Name = "PcbLogoGeneros";
            this.PcbLogoGeneros.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoGeneros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoGeneros.TabIndex = 3;
            this.PcbLogoGeneros.TabStop = false;
            this.PcbLogoGeneros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanTituloGeneros_MouseDown);
            // 
            // PanBtnGe
            // 
            this.PanBtnGe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtnGe.Controls.Add(this.flowLayoutPanel1);
            this.PanBtnGe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtnGe.Location = new System.Drawing.Point(0, 454);
            this.PanBtnGe.Name = "PanBtnGe";
            this.PanBtnGe.Size = new System.Drawing.Size(805, 45);
            this.PanBtnGe.TabIndex = 98;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GBtnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.GBtnActualizar);
            this.flowLayoutPanel1.Controls.Add(this.GBtnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(232, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(573, 45);
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
            this.GBtnAceptar.Location = new System.Drawing.Point(439, 5);
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
            this.GBtnActualizar.Location = new System.Drawing.Point(263, 5);
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
            this.GBtnCancelar.Location = new System.Drawing.Point(131, 5);
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
            // LsvGeneroNG
            // 
            this.LsvGeneroNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LsvGeneroNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvGeneroNG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNombreNG});
            this.LsvGeneroNG.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvGeneroNG.HideSelection = false;
            this.LsvGeneroNG.Location = new System.Drawing.Point(25, 70);
            this.LsvGeneroNG.MultiSelect = false;
            this.LsvGeneroNG.Name = "LsvGeneroNG";
            this.LsvGeneroNG.Size = new System.Drawing.Size(283, 313);
            this.LsvGeneroNG.TabIndex = 0;
            this.LsvGeneroNG.UseCompatibleStateImageBehavior = false;
            this.LsvGeneroNG.View = System.Windows.Forms.View.Details;
            this.LsvGeneroNG.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvGeneroNG_ItemSelectionChanged);
            // 
            // ChNombreNG
            // 
            this.ChNombreNG.Text = "Nombre";
            this.ChNombreNG.Width = 193;
            // 
            // MBtnMasLsvNG
            // 
            this.MBtnMasLsvNG.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMasLsvNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMasLsvNG.FlatAppearance.BorderSize = 0;
            this.MBtnMasLsvNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMasLsvNG.IconChar = FontAwesome.Sharp.MaterialIcons.PlusBox;
            this.MBtnMasLsvNG.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMasLsvNG.IconSize = 65;
            this.MBtnMasLsvNG.Location = new System.Drawing.Point(25, 389);
            this.MBtnMasLsvNG.Name = "MBtnMasLsvNG";
            this.MBtnMasLsvNG.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMasLsvNG.Size = new System.Drawing.Size(45, 45);
            this.MBtnMasLsvNG.TabIndex = 1;
            this.MBtnMasLsvNG.UseVisualStyleBackColor = false;
            this.MBtnMasLsvNG.Click += new System.EventHandler(this.MBtnMasLsvNG_Click);
            // 
            // MBtnMenosLsvNG
            // 
            this.MBtnMenosLsvNG.BackColor = System.Drawing.Color.Transparent;
            this.MBtnMenosLsvNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBtnMenosLsvNG.FlatAppearance.BorderSize = 0;
            this.MBtnMenosLsvNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnMenosLsvNG.IconChar = FontAwesome.Sharp.MaterialIcons.MinusBoxOutline;
            this.MBtnMenosLsvNG.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.MBtnMenosLsvNG.IconSize = 65;
            this.MBtnMenosLsvNG.Location = new System.Drawing.Point(82, 389);
            this.MBtnMenosLsvNG.Name = "MBtnMenosLsvNG";
            this.MBtnMenosLsvNG.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MBtnMenosLsvNG.Size = new System.Drawing.Size(45, 45);
            this.MBtnMenosLsvNG.TabIndex = 2;
            this.MBtnMenosLsvNG.UseVisualStyleBackColor = false;
            this.MBtnMenosLsvNG.Click += new System.EventHandler(this.MBtnMenosLsvNG_Click);
            // 
            // PanOpcionesGE
            // 
            this.PanOpcionesGE.Controls.Add(this.LblObligatorio);
            this.PanOpcionesGE.Controls.Add(this.LblNombreGe);
            this.PanOpcionesGE.Controls.Add(this.KTxtNombreGe);
            this.PanOpcionesGE.Controls.Add(this.LblComentarioGe);
            this.PanOpcionesGE.Controls.Add(this.KTxtComentarioGe);
            this.PanOpcionesGE.Location = new System.Drawing.Point(351, 60);
            this.PanOpcionesGE.Name = "PanOpcionesGE";
            this.PanOpcionesGE.Size = new System.Drawing.Size(442, 374);
            this.PanOpcionesGE.TabIndex = 139;
            this.PanOpcionesGE.Visible = false;
            // 
            // LblObligatorio
            // 
            this.LblObligatorio.AutoSize = true;
            this.LblObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.LblObligatorio.Font = new System.Drawing.Font("Merienda One", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblObligatorio.Location = new System.Drawing.Point(15, 344);
            this.LblObligatorio.Name = "LblObligatorio";
            this.LblObligatorio.Size = new System.Drawing.Size(150, 16);
            this.LblObligatorio.TabIndex = 168;
            this.LblObligatorio.Text = "( * ) Campos obligatorios";
            // 
            // LblNombreGe
            // 
            this.LblNombreGe.AutoSize = true;
            this.LblNombreGe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreGe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblNombreGe.Location = new System.Drawing.Point(14, 10);
            this.LblNombreGe.Name = "LblNombreGe";
            this.LblNombreGe.Size = new System.Drawing.Size(120, 20);
            this.LblNombreGe.TabIndex = 114;
            this.LblNombreGe.Text = "Nombre género";
            // 
            // KTxtNombreGe
            // 
            this.KTxtNombreGe.Location = new System.Drawing.Point(14, 31);
            this.KTxtNombreGe.Name = "KTxtNombreGe";
            this.KTxtNombreGe.Size = new System.Drawing.Size(402, 33);
            this.KTxtNombreGe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreGe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreGe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreGe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreGe.StateCommon.Border.Rounding = 10;
            this.KTxtNombreGe.StateCommon.Border.Width = 2;
            this.KTxtNombreGe.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreGe.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreGe.TabIndex = 0;
            this.KTxtNombreGe.Enter += new System.EventHandler(this.KTxtNombreGe_Enter);
            this.KTxtNombreGe.Leave += new System.EventHandler(this.KTxtNombreGe_Leave);
            // 
            // LblComentarioGe
            // 
            this.LblComentarioGe.AutoSize = true;
            this.LblComentarioGe.Font = new System.Drawing.Font("Merienda One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentarioGe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LblComentarioGe.Location = new System.Drawing.Point(14, 78);
            this.LblComentarioGe.Name = "LblComentarioGe";
            this.LblComentarioGe.Size = new System.Drawing.Size(91, 20);
            this.LblComentarioGe.TabIndex = 112;
            this.LblComentarioGe.Text = "Comentario";
            // 
            // KTxtComentarioGe
            // 
            this.KTxtComentarioGe.Location = new System.Drawing.Point(14, 101);
            this.KTxtComentarioGe.Multiline = true;
            this.KTxtComentarioGe.Name = "KTxtComentarioGe";
            this.KTxtComentarioGe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KTxtComentarioGe.Size = new System.Drawing.Size(402, 222);
            this.KTxtComentarioGe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtComentarioGe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioGe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtComentarioGe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtComentarioGe.StateCommon.Border.Rounding = 10;
            this.KTxtComentarioGe.StateCommon.Border.Width = 2;
            this.KTxtComentarioGe.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtComentarioGe.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtComentarioGe.TabIndex = 1;
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
            // FrmGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MBtnMasLsvNG);
            this.Controls.Add(this.MBtnMenosLsvNG);
            this.Controls.Add(this.LsvGeneroNG);
            this.Controls.Add(this.PanBtnGe);
            this.Controls.Add(this.PanTituloGeneros);
            this.Controls.Add(this.PanOpcionesGE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGeneros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGeneros_FormClosing);
            this.Load += new System.EventHandler(this.FrmGeneros_Load);
            this.PanTituloGeneros.ResumeLayout(false);
            this.PanTituloGeneros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoGeneros)).EndInit();
            this.PanBtnGe.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanOpcionesGE.ResumeLayout(false);
            this.PanOpcionesGE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanTituloGeneros;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarGeneros;
        private System.Windows.Forms.Label LblTituloGeneros;
        private System.Windows.Forms.PictureBox PcbLogoGeneros;
        private System.Windows.Forms.Panel PanBtnGe;
        private System.Windows.Forms.ListView LsvGeneroNG;
        private System.Windows.Forms.ColumnHeader ChNombreNG;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMasLsvNG;
        private FontAwesome.Sharp.Material.MaterialButton MBtnMenosLsvNG;
        private System.Windows.Forms.Panel PanOpcionesGE;
        private System.Windows.Forms.Label LblNombreGe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreGe;
        private System.Windows.Forms.Label LblComentarioGe;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtComentarioGe;
        private System.Windows.Forms.ToolTip TTGeneros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton GBtnAceptar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
        private Guna.UI.WinForms.GunaButton GBtnActualizar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblObligatorio;
    }
}