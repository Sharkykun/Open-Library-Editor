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
        private bool isOk;

        public bool IsOk { get => isOk; set => isOk = value; }
        private int numero = 0;
        public FrmCrearBD()
        {
            InitializeComponent();
        }

        private void FrmCrearBD_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
        }

        private void IdiomaTexto()
        {
            LblTitulo.Text = ControladorIdioma.GetTexto("BD_Titulo");
            KgbDatosServidor.Values.Heading= ControladorIdioma.GetTexto("BD_DServidor");
            LblUrl.Text= ControladorIdioma.GetTexto("BD_Url");
            LblNombreSer.Text= ControladorIdioma.GetTexto("Adm_NombreUsu");
            LblPuerto.Text= ControladorIdioma.GetTexto("BD_Puerto");
            LblContraSer.Text= ControladorIdioma.GetTexto("Reg_Contra");
            KgbDatosApp.Values.Heading = ControladorIdioma.GetTexto("BD_DApp");
            LblNombreApp.Text= ControladorIdioma.GetTexto("Adm_NombreUsu");
            LblContraApp.Text= ControladorIdioma.GetTexto("Reg_Contra");
            LblEmailApp.Text= ControladorIdioma.GetTexto("Reg_Email");
            GBtnCancelar.Text= ControladorIdioma.GetTexto("Cancelar");
            GBtnCrear.Text = ControladorIdioma.GetTexto("Crear");
        }

        private void MBtnCerrarAutores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBtnCrear_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(KTxtUrl.Text) && !String.IsNullOrWhiteSpace(KTxtNombreUSer.Text)
              && !String.IsNullOrWhiteSpace(KNudPuerto.ToString()) && !String.IsNullOrWhiteSpace(KTxtNombreApp.Text)
              && !String.IsNullOrWhiteSpace(KTxtEmailApp.Text) && !String.IsNullOrWhiteSpace(KTxtContraApp.Text)) 
            {
                DialogResult result = DialogResult.No;
                do
                {
                    ValidarEmail mail = new ValidarEmail();
                    numero = mail.Send("openlibraryeditor@gmail.com", "oleOLEole", KTxtEmailApp.Text);

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
                    BaseDatos.ConexionBD.CrearBD(KTxtUrl.Text, KTxtNombreUSer.Text, KTxtCSer.Text, KNudPuerto.Value.ToString());
                    BaseDatos.ConexionBD.AbrirConexion();
                    BaseDatos.ConexionBD.CrearAdminBD(KTxtNombreApp.Text, KTxtContraApp.Text, KTxtEmailApp.Text);
                    BaseDatos.ConexionBD.CerrarConexion();
                    FrmLogin.ObtenerInfoBD(KTxtNombreApp.Text, KTxtUrl.Text, (int)KNudPuerto.Value);
                    BaseDatos.ConexionBD.EstablecerConexion(KTxtUrl.Text, ConexionBD.ANTENOMBRE_USUARIO_BD+
                        KTxtNombreApp.Text, KTxtContraApp.Text, KNudPuerto.Value.ToString());
                    isOk = true;
                    Close();
                }
                //BaseDatos.EscrituraBD.InsertOcupacion("Escritor");
                //BaseDatos.EscrituraBD.InsertAutor(testA);
                //testA.Nombre = "Jose";
                //BaseDatos.EscrituraBD.UpdateOcupacion("Escritor", "Escritor/a");
                //BaseDatos.EscrituraBD.UpdateAutor("pepe", testA);
                //BaseDatos.EscrituraBD.DeleteAutor(testA);
                //BaseDatos.EscrituraBD.UpdateOcupacion("Escritor", "Escritor/a");
                //BaseDatos.EscrituraBD.DeleteOcupacion("Escritor/a");
                //BaseDatos.ConexionBD.CerrarConexion();
            }
            else
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorCamposVacios"));
            }
        }

        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

    }
}
