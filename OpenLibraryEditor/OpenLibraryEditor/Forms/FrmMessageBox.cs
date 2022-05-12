using ComponentFactory.Krypton.Toolkit;
using OpenLibraryEditor.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmMessageBox : Form
    {
       //enlace del codigo: https://rjcodeadvance.com/cuadro-de-mensaje-personalizado-c-winforms/

        //Fields
        private Color primaryColor = Color.Gainsboro;
        private int borderSize = 2;
        //Properties
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Form Border Color
                this.PanTitulo.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }
        //Constructors
        public FrmMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.LblMensaje.Text = text;
            this.LblCaption.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FrmMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.LblMensaje.Text = text;
            this.LblCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public FrmMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.LblMensaje.Text = text;
            this.LblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public FrmMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.LblMensaje.Text = text;
            this.LblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public FrmMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.LblMensaje.Text = text;
            this.LblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }
        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size
            this.LblMensaje.MaximumSize = new Size(550, 0);
            this.MBtnCerrarDialog.DialogResult = DialogResult.Cancel;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }
        private void SetFormSize()
        {
            int widht = this.LblMensaje.Width + this.PcbIcono.Width + this.PanTexto.Padding.Left;
            int height = this.PanTitulo.Height + this.LblMensaje.Height + this.PanBotones.Height + this.PanTexto.Padding.Top+this.PanTexto.Padding.Bottom;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.PanBotones.Width - button1.Width) / 2;
            int yCenter = (this.PanBotones.Height - button1.Height) / 2;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = ControladorIdioma.GetTexto("Ms_Aceptar");
                    button1.DialogResult = DialogResult.OK;//Set DialogResult
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = ControladorIdioma.GetTexto("Ms_Aceptar");
                    button1.DialogResult = DialogResult.OK;//Set DialogResult
                   //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = ControladorIdioma.GetTexto("Ms_Cancelar");
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    EstiloCancelar(button2);
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = ControladorIdioma.GetTexto("Ms_Reintentar");
                    button1.DialogResult = DialogResult.Retry;//Set DialogResult
                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = ControladorIdioma.GetTexto("Ms_Cancelar");
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    EstiloCancelar(button2);
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNo:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = ControladorIdioma.GetTexto("Ms_Si");
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = ControladorIdioma.GetTexto("Ms_No");
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    EstiloNo(button2);
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = ControladorIdioma.GetTexto("Ms_Si");
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult
                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = ControladorIdioma.GetTexto("Ms_No");
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    EstiloNo(button2);
                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = ControladorIdioma.GetTexto("Ms_Cancelar");
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    EstiloCancelar(button3);
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = ControladorIdioma.GetTexto("Ms_Cancelar");
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    EstiloAbort(button1);
                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = ControladorIdioma.GetTexto("Ms_Reintentar");
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                    //Ignore Button
                    button3.Visible = false;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = ControladorIdioma.GetTexto("Ms_Ignorar");
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    EstiloCancelar(button3);
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    EstiloBotonDefault(button1);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    EstiloBotonDefault(button2);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    EstiloBotonDefault(button3);
                    break;
            }
        }
        private void EstiloBotonDefault(KryptonButton btn)
        {
            btn.Select();
            btn.OverrideDefault.Back.Color1 = Color.FromArgb(0, 0, 150);
            btn.OverrideDefault.Back.Color2 = Color.FromArgb(0, 0, 150);
            btn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(205, 231, 253);
            btn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(205, 231, 253);
            btn.OverrideDefault.Border.Width = 2;
            btn.OverrideDefault.Border.Color1 = Color.FromArgb(205, 231, 253);
            btn.OverrideDefault.Border.Color2 = Color.FromArgb(205, 231, 253);

            btn.OverrideFocus.Back.Color1 = Color.FromArgb(205, 231, 253);
            btn.OverrideFocus.Back.Color2 = Color.FromArgb(205, 231, 253);
            btn.OverrideFocus.Border.Width = 2;
            btn.OverrideFocus.Border.Color1 = Color.FromArgb(0, 0, 150);
            btn.OverrideFocus.Border.Color2 = Color.FromArgb(0, 0, 150);
            btn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(0, 0, 150);
            btn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(0, 0, 150);
            btn.OverrideDefault.Content.ShortText.Font = new Font(btn.StateCommon.Content.ShortText.Font, FontStyle.Underline);
        }
        private void EstiloAbort(KryptonButton btn)
        {
            btn.StateCommon.Back.Color1 = Color.Goldenrod;
            btn.StateCommon.Back.Color2 = Color.Goldenrod;
            btn.StateCommon.Content.ShortText.Color1 = Color.Black;
            btn.StateCommon.Content.ShortText.Color2 = Color.Black;

            btn.StateTracking.Back.Color1 = Color.Black;
            btn.StateTracking.Back.Color2 = Color.Black;
            btn.StateTracking.Border.Color1 = Color.Goldenrod;
            btn.StateTracking.Border.Color2 = Color.Goldenrod;
            btn.StateTracking.Content.ShortText.Color1 = Color.Goldenrod;
            btn.StateTracking.Content.ShortText.Color2 = Color.Goldenrod;
        }
        private void EstiloNo(KryptonButton btn)
        {
            btn.StateCommon.Back.Color1 = Color.IndianRed;
            btn.StateCommon.Back.Color2 = Color.IndianRed;
            btn.StateCommon.Content.ShortText.Color1 = Color.AliceBlue;
            btn.StateCommon.Content.ShortText.Color2 = Color.AliceBlue;

            btn.StateTracking.Back.Color1 = Color.AliceBlue;
            btn.StateTracking.Back.Color2 = Color.AliceBlue;
            btn.StateTracking.Border.Color1 = Color.IndianRed;
            btn.StateTracking.Border.Color2 = Color.IndianRed;
            btn.StateTracking.Content.ShortText.Color1 = Color.IndianRed;
            btn.StateTracking.Content.ShortText.Color2 = Color.IndianRed;
        }
        private void EstiloCancelar(KryptonButton btn)
        {
            btn.StateCommon.Back.Color1 = Color.DimGray;
            btn.StateCommon.Back.Color2 = Color.DimGray;
            btn.StateCommon.Content.ShortText.Color1 = Color.White;
            btn.StateCommon.Content.ShortText.Color2 = Color.White;

            btn.StateTracking.Back.Color1 = Color.White;
            btn.StateTracking.Back.Color2 = Color.White;
            btn.StateTracking.Border.Color1 = Color.DimGray;
            btn.StateTracking.Border.Color2 = Color.DimGray;
            btn.StateTracking.Content.ShortText.Color1 = Color.DimGray;
            btn.StateTracking.Content.ShortText.Color2 = Color.DimGray;
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.PcbIcono.Image = Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(228, 53, 57);
                    //this.MBtnCerrarDialog.FlatAppearance.MouseOverBackColor = Color.Navy;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.PcbIcono.Image = Properties.Resources.info;
                    PrimaryColor = Color.FromArgb(37, 183, 211);
                    break;
                case MessageBoxIcon.Question://Question
                    this.PcbIcono.Image = Properties.Resources.question_mark;
                    PrimaryColor = Color.FromArgb(70, 198, 164);
                    break;
                case MessageBoxIcon.Warning://Exclamation
                    this.PcbIcono.Image = Properties.Resources.warning;
                    PrimaryColor = Color.FromArgb(238, 144, 23);
                    break;
                case MessageBoxIcon.None: //None
                    this.PcbIcono.Image = Properties.Resources.LogoFinal;
                    PrimaryColor = Color.Navy;
                    break;
            }
        }
        //-> Events Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void PanTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
