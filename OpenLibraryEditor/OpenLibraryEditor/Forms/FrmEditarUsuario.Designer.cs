
namespace OpenLibraryEditor.Forms
{
    partial class FrmEditarUsuario
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
            this.PanBtn = new System.Windows.Forms.Panel();
            this.GBtnAceptar = new Guna.UI.WinForms.GunaButton();
            this.GBtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.PanTituloEditUsu = new System.Windows.Forms.Panel();
            this.MBtnCerrarEditUsu = new FontAwesome.Sharp.Material.MaterialButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcbLogoEditUsu = new System.Windows.Forms.PictureBox();
            this.KgbDatosEditUsu = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.KTxtNombreEditUsu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KCmbTipoEditUsu = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.LblTipoEditUsu = new System.Windows.Forms.Label();
            this.KTxtContraEditUsu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.KTxtEmailEditUsu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LblContraEditUsu = new System.Windows.Forms.Label();
            this.LblEmailEditUsu = new System.Windows.Forms.Label();
            this.PanBtn.SuspendLayout();
            this.PanTituloEditUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosEditUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosEditUsu.Panel)).BeginInit();
            this.KgbDatosEditUsu.Panel.SuspendLayout();
            this.KgbDatosEditUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoEditUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBtn
            // 
            this.PanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanBtn.Controls.Add(this.GBtnAceptar);
            this.PanBtn.Controls.Add(this.GBtnCancelar);
            this.PanBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBtn.Location = new System.Drawing.Point(0, 255);
            this.PanBtn.Name = "PanBtn";
            this.PanBtn.Size = new System.Drawing.Size(591, 45);
            this.PanBtn.TabIndex = 158;
            // 
            // GBtnAceptar
            // 
            this.GBtnAceptar.AnimationHoverSpeed = 0.07F;
            this.GBtnAceptar.AnimationSpeed = 0.03F;
            this.GBtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.GBtnAceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.BorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.GBtnAceptar.Image = null;
            this.GBtnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnAceptar.Location = new System.Drawing.Point(451, 5);
            this.GBtnAceptar.Name = "GBtnAceptar";
            this.GBtnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.GBtnAceptar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnAceptar.OnHoverImage = null;
            this.GBtnAceptar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnAceptar.Radius = 15;
            this.GBtnAceptar.Size = new System.Drawing.Size(126, 35);
            this.GBtnAceptar.TabIndex = 0;
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
            this.GBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GBtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Font = new System.Drawing.Font("Merienda", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.GBtnCancelar.Image = null;
            this.GBtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.GBtnCancelar.Location = new System.Drawing.Point(319, 5);
            this.GBtnCancelar.Name = "GBtnCancelar";
            this.GBtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.GBtnCancelar.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.OnHoverForeColor = System.Drawing.Color.Black;
            this.GBtnCancelar.OnHoverImage = null;
            this.GBtnCancelar.OnPressedColor = System.Drawing.Color.Empty;
            this.GBtnCancelar.Radius = 15;
            this.GBtnCancelar.Size = new System.Drawing.Size(126, 35);
            this.GBtnCancelar.TabIndex = 1;
            this.GBtnCancelar.Text = "Cancelar";
            this.GBtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBtnCancelar.Click += new System.EventHandler(this.GBtnCancelar_Click);
            // 
            // PanTituloEditUsu
            // 
            this.PanTituloEditUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.PanTituloEditUsu.Controls.Add(this.MBtnCerrarEditUsu);
            this.PanTituloEditUsu.Controls.Add(this.LblTitulo);
            this.PanTituloEditUsu.Controls.Add(this.PcbLogoEditUsu);
            this.PanTituloEditUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTituloEditUsu.Location = new System.Drawing.Point(0, 0);
            this.PanTituloEditUsu.Name = "PanTituloEditUsu";
            this.PanTituloEditUsu.Size = new System.Drawing.Size(591, 40);
            this.PanTituloEditUsu.TabIndex = 157;
            // 
            // MBtnCerrarEditUsu
            // 
            this.MBtnCerrarEditUsu.BackColor = System.Drawing.Color.Transparent;
            this.MBtnCerrarEditUsu.Dock = System.Windows.Forms.DockStyle.Right;
            this.MBtnCerrarEditUsu.FlatAppearance.BorderSize = 0;
            this.MBtnCerrarEditUsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MBtnCerrarEditUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.MBtnCerrarEditUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnCerrarEditUsu.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
            this.MBtnCerrarEditUsu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.MBtnCerrarEditUsu.IconSize = 40;
            this.MBtnCerrarEditUsu.Location = new System.Drawing.Point(559, 0);
            this.MBtnCerrarEditUsu.Name = "MBtnCerrarEditUsu";
            this.MBtnCerrarEditUsu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.MBtnCerrarEditUsu.Size = new System.Drawing.Size(32, 40);
            this.MBtnCerrarEditUsu.TabIndex = 28;
            this.MBtnCerrarEditUsu.UseVisualStyleBackColor = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Merienda", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.LblTitulo.Location = new System.Drawing.Point(54, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(297, 23);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Open Library Editor - Editar usuario";
            // 
            // PcbLogoEditUsu
            // 
            this.PcbLogoEditUsu.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogoEditUsu.Image = global::OpenLibraryEditor.Properties.Resources.LogoFinal;
            this.PcbLogoEditUsu.Location = new System.Drawing.Point(5, 2);
            this.PcbLogoEditUsu.Name = "PcbLogoEditUsu";
            this.PcbLogoEditUsu.Size = new System.Drawing.Size(36, 36);
            this.PcbLogoEditUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogoEditUsu.TabIndex = 3;
            this.PcbLogoEditUsu.TabStop = false;
            // 
            // KgbDatosEditUsu
            // 
            this.KgbDatosEditUsu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KgbDatosEditUsu.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.KgbDatosEditUsu.Location = new System.Drawing.Point(33, 46);
            this.KgbDatosEditUsu.Name = "KgbDatosEditUsu";
            // 
            // KgbDatosEditUsu.Panel
            // 
            this.KgbDatosEditUsu.Panel.Controls.Add(this.KTxtNombreEditUsu);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.label1);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.KCmbTipoEditUsu);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.LblTipoEditUsu);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.KTxtContraEditUsu);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.KTxtEmailEditUsu);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.LblContraEditUsu);
            this.KgbDatosEditUsu.Panel.Controls.Add(this.LblEmailEditUsu);
            this.KgbDatosEditUsu.Size = new System.Drawing.Size(521, 203);
            this.KgbDatosEditUsu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosEditUsu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.KgbDatosEditUsu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosEditUsu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KgbDatosEditUsu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KgbDatosEditUsu.StateCommon.Border.Rounding = 0;
            this.KgbDatosEditUsu.StateCommon.Border.Width = 2;
            this.KgbDatosEditUsu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosEditUsu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KgbDatosEditUsu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Merienda One", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgbDatosEditUsu.TabIndex = 159;
            this.KgbDatosEditUsu.Values.Heading = "Datos para registrarse en la aplicación";
            // 
            // KTxtNombreEditUsu
            // 
            this.KTxtNombreEditUsu.Location = new System.Drawing.Point(175, 3);
            this.KTxtNombreEditUsu.Name = "KTxtNombreEditUsu";
            this.KTxtNombreEditUsu.Size = new System.Drawing.Size(322, 33);
            this.KTxtNombreEditUsu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtNombreEditUsu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreEditUsu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtNombreEditUsu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtNombreEditUsu.StateCommon.Border.Rounding = 10;
            this.KTxtNombreEditUsu.StateCommon.Border.Width = 2;
            this.KTxtNombreEditUsu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtNombreEditUsu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtNombreEditUsu.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 167;
            this.label1.Text = "Nombre:";
            // 
            // KCmbTipoEditUsu
            // 
            this.KCmbTipoEditUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KCmbTipoEditUsu.DropDownWidth = 228;
            this.KCmbTipoEditUsu.Location = new System.Drawing.Point(175, 115);
            this.KCmbTipoEditUsu.Name = "KCmbTipoEditUsu";
            this.KCmbTipoEditUsu.Size = new System.Drawing.Size(322, 33);
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Border.Rounding = 10;
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Border.Width = 2;
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoEditUsu.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Merienda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoEditUsu.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoEditUsu.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KCmbTipoEditUsu.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Merienda", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCmbTipoEditUsu.TabIndex = 165;
            // 
            // LblTipoEditUsu
            // 
            this.LblTipoEditUsu.AutoSize = true;
            this.LblTipoEditUsu.Font = new System.Drawing.Font("Merienda One", 11F);
            this.LblTipoEditUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblTipoEditUsu.Location = new System.Drawing.Point(19, 122);
            this.LblTipoEditUsu.Name = "LblTipoEditUsu";
            this.LblTipoEditUsu.Size = new System.Drawing.Size(130, 22);
            this.LblTipoEditUsu.TabIndex = 164;
            this.LblTipoEditUsu.Text = "Tipo de usuario:";
            // 
            // KTxtContraEditUsu
            // 
            this.KTxtContraEditUsu.Location = new System.Drawing.Point(175, 76);
            this.KTxtContraEditUsu.Name = "KTxtContraEditUsu";
            this.KTxtContraEditUsu.Size = new System.Drawing.Size(322, 33);
            this.KTxtContraEditUsu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtContraEditUsu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtContraEditUsu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtContraEditUsu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtContraEditUsu.StateCommon.Border.Rounding = 10;
            this.KTxtContraEditUsu.StateCommon.Border.Width = 2;
            this.KTxtContraEditUsu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtContraEditUsu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtContraEditUsu.TabIndex = 2;
            // 
            // KTxtEmailEditUsu
            // 
            this.KTxtEmailEditUsu.Location = new System.Drawing.Point(175, 40);
            this.KTxtEmailEditUsu.Name = "KTxtEmailEditUsu";
            this.KTxtEmailEditUsu.Size = new System.Drawing.Size(322, 33);
            this.KTxtEmailEditUsu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.KTxtEmailEditUsu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtEmailEditUsu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.KTxtEmailEditUsu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KTxtEmailEditUsu.StateCommon.Border.Rounding = 10;
            this.KTxtEmailEditUsu.StateCommon.Border.Width = 2;
            this.KTxtEmailEditUsu.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.KTxtEmailEditUsu.StateCommon.Content.Font = new System.Drawing.Font("Merienda", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KTxtEmailEditUsu.TabIndex = 1;
            // 
            // LblContraEditUsu
            // 
            this.LblContraEditUsu.AutoSize = true;
            this.LblContraEditUsu.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraEditUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblContraEditUsu.Location = new System.Drawing.Point(20, 82);
            this.LblContraEditUsu.Name = "LblContraEditUsu";
            this.LblContraEditUsu.Size = new System.Drawing.Size(100, 22);
            this.LblContraEditUsu.TabIndex = 29;
            this.LblContraEditUsu.Text = "Contraseña:";
            // 
            // LblEmailEditUsu
            // 
            this.LblEmailEditUsu.AutoSize = true;
            this.LblEmailEditUsu.Font = new System.Drawing.Font("Merienda One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailEditUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.LblEmailEditUsu.Location = new System.Drawing.Point(20, 46);
            this.LblEmailEditUsu.Name = "LblEmailEditUsu";
            this.LblEmailEditUsu.Size = new System.Drawing.Size(55, 22);
            this.LblEmailEditUsu.TabIndex = 23;
            this.LblEmailEditUsu.Text = "Email:";
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(591, 300);
            this.Controls.Add(this.KgbDatosEditUsu);
            this.Controls.Add(this.PanBtn);
            this.Controls.Add(this.PanTituloEditUsu);
            this.Name = "FrmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarUsuario";
            this.Load += new System.EventHandler(this.FrmEditarUsuario_Load);
            this.PanBtn.ResumeLayout(false);
            this.PanTituloEditUsu.ResumeLayout(false);
            this.PanTituloEditUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogoEditUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosEditUsu.Panel)).EndInit();
            this.KgbDatosEditUsu.Panel.ResumeLayout(false);
            this.KgbDatosEditUsu.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KgbDatosEditUsu)).EndInit();
            this.KgbDatosEditUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KCmbTipoEditUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBtn;
        private Guna.UI.WinForms.GunaButton GBtnAceptar;
        private Guna.UI.WinForms.GunaButton GBtnCancelar;
        private System.Windows.Forms.Panel PanTituloEditUsu;
        private FontAwesome.Sharp.Material.MaterialButton MBtnCerrarEditUsu;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PcbLogoEditUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox KgbDatosEditUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtContraEditUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtEmailEditUsu;
        private System.Windows.Forms.Label LblContraEditUsu;
        private System.Windows.Forms.Label LblEmailEditUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox KCmbTipoEditUsu;
        private System.Windows.Forms.Label LblTipoEditUsu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KTxtNombreEditUsu;
        private System.Windows.Forms.Label label1;
    }
}