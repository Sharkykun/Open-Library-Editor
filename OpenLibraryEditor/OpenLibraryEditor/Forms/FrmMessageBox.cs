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
                    button2.StateCommon.Back.Color1 = Color.DimGray;
                    button2.StateCommon.Back.Color2 = Color.DimGray;
                    //button2.BackColor = Color.DimGray;
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
                    button2.StateCommon.Back.Color1 = Color.DimGray;
                    button2.StateCommon.Back.Color2 = Color.DimGray;
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
                    button2.StateCommon.Back.Color1 = Color.IndianRed;
                    button2.StateCommon.Back.Color2 = Color.IndianRed;
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
                    button2.StateCommon.Back.Color1 = Color.IndianRed;
                    button2.StateCommon.Back.Color2 = Color.IndianRed;
                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = ControladorIdioma.GetTexto("Ms_Cancelar");
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.StateCommon.Back.Color1 = Color.DimGray;
                    button3.StateCommon.Back.Color2 = Color.DimGray;
                    //Set Default Button
                    //SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Cancelar";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Color.Goldenrod;
                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Retry";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                                                              //Ignore Button
                    button3.Visible = false;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Ignore";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;
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
                    button1.Select();
                    button1.OverrideDefault.Content.ShortText.Color1 = Color.Gainsboro;
                    button1.OverrideDefault.Content.ShortText.Color2 = Color.Gainsboro;
                    button1.OverrideDefault.Content.ShortText.Font = new Font(button1.StateCommon.Content.ShortText.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    button2.OverrideDefault.Content.ShortText.Color1 = Color.Gainsboro;
                    button2.OverrideDefault.Content.ShortText.Color2 = Color.Gainsboro;
                    button2.OverrideDefault.Content.ShortText.Font = new Font(button2.StateCommon.Content.ShortText.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    button3.OverrideDefault.Content.ShortText.Color1 = Color.Gainsboro;
                    button3.OverrideDefault.Content.ShortText.Color2 = Color.Gainsboro;
                    button3.OverrideDefault.Content.ShortText.Font = new Font(button3.StateCommon.Content.ShortText.Font, FontStyle.Underline);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.PcbIcono.Image = Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    //this.MBtnCerrarDialog.FlatAppearance.MouseOverBackColor = Color.Navy;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.PcbIcono.Image = Properties.Resources.info;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.PcbIcono.Image = Properties.Resources.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Warning://Exclamation
                    this.PcbIcono.Image = Properties.Resources.warning;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
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
