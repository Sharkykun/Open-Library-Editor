using MySql.Data.MySqlClient;
using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
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
    public partial class FrmRecuperarContra : Form
    {
        #region atributos
        private InfoUsuarioBD usuario = new InfoUsuarioBD();
        #endregion
        #region constructor y load
        public FrmRecuperarContra()
        {
            InitializeComponent();
        }
        private void FrmRecuperarContra_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
        }
        #endregion
        #region idioma
        private void IdiomaTexto()
        {
            LblTitulo.Text = ControladorIdioma.GetTexto("Recu_Titulo");
            this.Text = ControladorIdioma.GetTexto("Recu_Titulo");
            LblUrl.Text = ControladorIdioma.GetTexto("Reg_Url");
            TTRecuperarContra.SetToolTip(this.KTxtUrl, ControladorIdioma.GetTexto("UrlServidor"));
            LblPuerto.Text = ControladorIdioma.GetTexto("BD_Puerto");
            TTRecuperarContra.SetToolTip(this.KNudPuerto, ControladorIdioma.GetTexto("NumeroPuerto"));
            LblMail.Text = ControladorIdioma.GetTexto("Reg_Email");
            TTRecuperarContra.SetToolTip(this.KTxtMail, ControladorIdioma.GetTexto("Recu_TTmail"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTRecuperarContra.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnRecuperar.Text = ControladorIdioma.GetTexto("Recuperar");
            TTRecuperarContra.SetToolTip(this.GBtnRecuperar, ControladorIdioma.GetTexto("Recuperar"));
        }
        #endregion
        #region recuperar password
        private string PasswordAleatoria()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 10;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }

        private void GBtnRecuperar_Click(object sender, EventArgs e)
        {
            string contraNueva = PasswordAleatoria();
            /*
            Si el email existe, sacar su nombre de usuario, mandarle email con la nueva contraseña
            y actualizar en bd la contraseña de ese usuario por la nueva que le hemos mandado
            */
            
            if (!String.IsNullOrWhiteSpace(KTxtUrl.Text) && !String.IsNullOrWhiteSpace(KTxtMail.Text))
            {
                if (MetodosComunes.EsEmailValido(KTxtMail.Text))
                {
                    ConexionBD.EstablecerConexion(KTxtUrl.Text,
                    "ole_register", "ole123Ole", KNudPuerto.Value.ToString());
                    if (ConexionBD.AbrirConexion())
                    {
                        MySqlCommand comprobacion = EscrituraBD.ComprobarMailExiste(KTxtMail.Text);
                        usuario = LecturaBD.SelectUsuarioSegunMail(KTxtMail.Text);
                        if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                            VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Recu_Error"));
                        else
                        {
                            if(EscrituraBD.UpdatePasswordUsuario(contraNueva, usuario))
                            {
                                EnvioEmail.RecuperarPassword("openlibraryeditor@gmail.com", "bjsxjerndlfahkqe", KTxtMail.Text, contraNueva, usuario.Nombre);
                                ConexionBD.CerrarConexion();
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("MailNuevaContra"));
                                this.Close();
                            }  
                        }
                    }
                }
                else
                {
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("MailNoValido"));
                }
            }
            else
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Log_Error4"));
            }
        }
        #endregion
        #region cerrar/cancelar
        private void MBtnCerrarEditUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBtnCancelar_Click(object sender, EventArgs e)
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
        private void PanTituloEditUsu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
