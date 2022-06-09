using MySql.Data.MySqlClient;
using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.Metodos;
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
    public partial class FrmCrearBD : Form
    {
        #region atributos
        private bool isOk;

        public bool IsOk { get => isOk; set => isOk = value; }
        private int numero = 0;
        #endregion
        #region constructor y load
        public FrmCrearBD()
        {
            InitializeComponent();
        }

        private void FrmCrearBD_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
        }
        #endregion
        #region idioma
        private void IdiomaTexto()
        {
            LblTitulo.Text = ControladorIdioma.GetTexto("BD_Titulo");
            this.Text= ControladorIdioma.GetTexto("BD_Titulo");
            KgbDatosServidor.Values.Heading= ControladorIdioma.GetTexto("BD_DServidor");
            LblUrl.Text= ControladorIdioma.GetTexto("BD_Url");
            TTCrearBD.SetToolTip(this.KTxtUrl, ControladorIdioma.GetTexto("UrlServidor"));
            LblNombreSer.Text= ControladorIdioma.GetTexto("NombreObligatorio");
            TTCrearBD.SetToolTip(this.KTxtNombreUSer, ControladorIdioma.GetTexto("NombreUsuServidor"));
            LblPuerto.Text= ControladorIdioma.GetTexto("BD_Puerto");
            TTCrearBD.SetToolTip(this.KNudPuerto, ControladorIdioma.GetTexto("NumeroPuerto"));
            LblContraSer.Text= ControladorIdioma.GetTexto("Reg_Contra");
            TTCrearBD.SetToolTip(this.KTxtCSer, ControladorIdioma.GetTexto("ContraServidor"));
            KgbDatosApp.Values.Heading = ControladorIdioma.GetTexto("BD_DApp");
            LblNombreApp.Text= ControladorIdioma.GetTexto("NombreObligatorio");
            TTCrearBD.SetToolTip(this.KTxtNombreApp, ControladorIdioma.GetTexto("NombreUsuApp"));
            LblContraApp.Text= ControladorIdioma.GetTexto("ContraObligatoria");
            TTCrearBD.SetToolTip(this.KTxtContraApp, ControladorIdioma.GetTexto("ContraUsuApp"));
            LblEmailApp.Text= ControladorIdioma.GetTexto("EmailObligatorio");
            TTCrearBD.SetToolTip(this.KTxtEmailApp, ControladorIdioma.GetTexto("EmailUsuApp"));
            GBtnCancelar.Text= ControladorIdioma.GetTexto("Cancelar");
            TTCrearBD.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnCrear.Text = ControladorIdioma.GetTexto("Crear");
            TTCrearBD.SetToolTip(this.GBtnCrear, ControladorIdioma.GetTexto("TT_CrearBD"));
            TTCrearBD.SetToolTip(this.MBtnCerrarAutores, ControladorIdioma.GetTexto("Cerrar"));

            TTCrearBD.SetToolTip(this.IpcbMostrarContraSer, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTCrearBD.SetToolTip(this.IpcbMostrarContraUsu, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTCrearBD.SetToolTip(this.IpcbOcultarContraSer, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTCrearBD.SetToolTip(this.IpcbOcultarContraUsu, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));

            LblObligatorio.Text = ControladorIdioma.GetTexto("CamposObligatorios");
        }
        #endregion
        #region crear bd
        private void GBtnCrear_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(KTxtUrl.Text) && !String.IsNullOrWhiteSpace(KTxtNombreUSer.Text)
              && !String.IsNullOrWhiteSpace(KNudPuerto.ToString()) && !String.IsNullOrWhiteSpace(KTxtNombreApp.Text)
              && !String.IsNullOrWhiteSpace(KTxtEmailApp.Text) && !String.IsNullOrWhiteSpace(KTxtContraApp.Text)) 
            {
                if (ConexionBD.TestConexionServidor(KTxtUrl.Text, KTxtNombreUSer.Text, KTxtCSer.Text, KNudPuerto.Value.ToString()))
                {
                    if (MetodosComunes.EsEmailValido(KTxtEmailApp.Text))
                    {
                        DialogResult result = DialogResult.No;
                        do
                        {
                            EnvioEmail mail = new EnvioEmail();
                            numero = mail.Send("openlibraryeditor@gmail.com", "bjsx jern dlfa hkqe", KTxtEmailApp.Text);

                            if (numero == 0)
                            {
                                VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_ReenviarMail"));
                            }
                        } while (result == DialogResult.Yes);
                        FrmVerificacionMail verificar = new FrmVerificacionMail(numero);
                        verificar.FormBorderStyle = FormBorderStyle.None;
                        verificar.ShowDialog();
                        if (verificar.MailVerificado)
                        {
                            if (ConexionBD.CrearBD(KTxtUrl.Text, KTxtNombreUSer.Text, KTxtCSer.Text, KNudPuerto.Value.ToString()))
                            {
                                ConexionBD.AbrirConexion();
                                ConexionBD.CrearAdminBD(KTxtNombreApp.Text, KTxtContraApp.Text, KTxtEmailApp.Text);
                                ConexionBD.CerrarConexion();
                                FrmLogin.ObtenerInfoBD(KTxtNombreApp.Text, KTxtUrl.Text, (int)KNudPuerto.Value);
                                ConexionBD.EstablecerConexion(KTxtUrl.Text, ConexionBD.ANTENOMBRE_USUARIO_BD + KTxtNombreApp.Text,
                                    KTxtContraApp.Text, KNudPuerto.Value.ToString());
                                isOk = true;
                                Close();
                            }
                            else
                                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexion"));
                        }
                    }
                    else
                    {
                        VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("MailNoValido"));
                    }
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorCredencialesBD"));
            }
            else
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorCamposVacios"));
            }
        }
        #endregion
        #region mostrar/ocultar password
        private void IpcbMostrarContraSer_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtCSer, true, false, IpcbOcultarContraSer, IpcbMostrarContraSer);
        }
        private void IpcbOcultarContraSer_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtCSer, false, true, IpcbMostrarContraSer, IpcbOcultarContraSer);
        }
        private void IpcbMostrarContraUsu_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraApp, true, false, IpcbOcultarContraUsu, IpcbMostrarContraUsu);
        }
        private void IpcbOcultarContraUsu_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraApp, false, true, IpcbMostrarContraUsu, IpcbOcultarContraUsu);
        }

        #endregion
        #region cerrar
        private void MBtnCerrarAutores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Mover formulario por la pantalla

        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloAutores_MouseDown(object sender, MouseEventArgs e)
        {
            //Para poder mover el formulario por la pantalla
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
       

      
    }
}
