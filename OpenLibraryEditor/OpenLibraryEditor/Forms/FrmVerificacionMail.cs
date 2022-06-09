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
    public partial class FrmVerificacionMail : Form
    {
        #region atributos
        private int numero;
        private bool mailVerificado;
        public bool MailVerificado { get => mailVerificado; set => mailVerificado = value; }
        #endregion
        #region constructor y load
        public FrmVerificacionMail(int numero)
        {
            InitializeComponent();
            this.numero = numero;
        }
        private void FrmVerificacionMail_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            KMaskTxt.Focus();
        }
        #endregion
        #region verificar email
        private void GBtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (KMaskTxt.MaskCompleted)
                {
                    int resultado = Convert.ToInt32(KMaskTxt.Text);
                    if (resultado == numero)
                    {
                        VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("VWC_Bienvenido"));
                        MailVerificado = true;
                        this.Close();
                    }
                    else
                        VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_CodigoMal"));
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_CodigoMal"));
                
            }
            catch (Exception)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_CaracteresMal"));
            }

        }
        #endregion
        #region idioma
        private void IdiomaTexto()
        {
            LblTituloFrm.Text = ControladorIdioma.GetTexto("Verificar_Titulo");
            this.Text = ControladorIdioma.GetTexto("Verificar_Titulo");
            Lblcodigo.Text = ControladorIdioma.GetTexto("Verificar_lbl");
            TTVerificar.SetToolTip(this.KMaskTxt, ControladorIdioma.GetTexto("Verificar_TTMask"));
            GBtnVerificar.Text = ControladorIdioma.GetTexto("Verificar_btn");
            TTVerificar.SetToolTip(this.GBtnVerificar, ControladorIdioma.GetTexto("Verificar_TTbtn"));
            LblMirarSpam.Text=ControladorIdioma.GetTexto("Verificar_Spam");
        }
        #endregion
        #region cerrar
        private void MBtnCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


    }
}
