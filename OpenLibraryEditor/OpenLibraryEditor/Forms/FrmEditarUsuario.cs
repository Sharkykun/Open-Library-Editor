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
    public partial class FrmEditarUsuario : Form
    {
        #region atributos
        private bool esEditar;
        private InfoUsuarioBD usuario;
        private bool esOk = false;
       
        public bool EsOk { get => esOk; set => esOk = value; }
        #endregion
        #region constructor y load
        public FrmEditarUsuario(InfoUsuarioBD usuario, bool esEditar)
        {
            InitializeComponent();
            this.usuario = usuario;
            KTxtNombreEditUsu.Text = usuario.Nombre;
            KTxtEmailEditUsu.Text = usuario.Correo;
            this.esEditar = esEditar;
        }
        public FrmEditarUsuario()
        {
            InitializeComponent();
            

        }
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            SeleccionarTipoUsuario(usuario);
        }
        #endregion
        #region seleccionar tipo usuario
        private void SeleccionarTipoUsuario(InfoUsuarioBD usuario)
        {
            switch (usuario.TipoUsuario)
            {
                case "Usuario":
                    KCmbTipoEditUsu.SelectedIndex = 1;
                    break;
                case "Editor":
                    KCmbTipoEditUsu.SelectedIndex = 0;
                    break;
            }
        }
        #endregion
        #region idioma
        private void IdiomaTexto()
        {
            LblTitulo.Text = ControladorIdioma.GetTexto("CrearUsuario");
            this.Text= ControladorIdioma.GetTexto("CrearUsuario");
            KgbDatosEditUsu.Values.Heading = ControladorIdioma.GetTexto("BD_DApp");
            LblNombreEditUsu.Text = ControladorIdioma.GetTexto("Edit_Nombre");
            TTEditarUsu.SetToolTip(this.KTxtNombreEditUsu, ControladorIdioma.GetTexto("NombreUsu"));
            LblContraEditUsu.Text = ControladorIdioma.GetTexto("ContraObligatoria");
            TTEditarUsu.SetToolTip(this.KTxtContraEditUsu, ControladorIdioma.GetTexto("ContraUsu"));
            LblEmailEditUsu.Text = ControladorIdioma.GetTexto("EmailObligatorio");
            TTEditarUsu.SetToolTip(this.KTxtEmailEditUsu, ControladorIdioma.GetTexto("EmailUsu"));
            LblTipoEditUsu.Text = ControladorIdioma.GetTexto("TipoObligatorio");
            TTEditarUsu.SetToolTip(this.KCmbTipoEditUsu, ControladorIdioma.GetTexto("SeleccionarTipoUsu"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTEditarUsu.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Aceptar");
            TTEditarUsu.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Aceptar"));
            KCmbTipoEditUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Editor"));
            KCmbTipoEditUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Usu"));
            TTEditarUsu.SetToolTip(this.MBtnCerrarEditUsu, ControladorIdioma.GetTexto("Cerrar"));
            LblObligatorio.Text= ControladorIdioma.GetTexto("CamposObligatorios");

        }
        #endregion
        #region registrar usuario
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(KTxtNombreEditUsu.Text) &&
                !String.IsNullOrWhiteSpace(KTxtContraEditUsu.Text) &&
               !String.IsNullOrWhiteSpace(KTxtEmailEditUsu.Text)
               && KCmbTipoEditUsu.SelectedIndex != -1)
            {
                if (MetodosComunes.EsEmailValido(KTxtEmailEditUsu.Text))
                {

                    if (ConexionBD.AbrirConexion())
                    {
                        if (LecturaBD.SelectUsuarioCorreo(KTxtEmailEditUsu.Text) == 0)
                        {
                            //usuario = new InfoUsuarioBD();
                            string nombreAntiguo = usuario.Nombre;
                            usuario.Nombre = KTxtNombreEditUsu.Text;
                            usuario.Correo = KTxtEmailEditUsu.Text;

                            if (KCmbTipoEditUsu.SelectedIndex == 0)
                                usuario.TipoUsuario = "Editor";
                            if (KCmbTipoEditUsu.SelectedIndex == 1)
                            {
                                usuario.TipoUsuario = "Usuario";
                            }

                            //if (esEditar)
                            //{
                            //    EscrituraBD.UpdateUsuario(nombreAntiguo, usuario, KTxtContraEditUsu.Text);
                            //}
                            //else
                            //{
                            //Evitar error de corrupción de esta tabla
                            ConexionBD.RepararTablesPriv();
                            EscrituraBD.InsertUsuario(usuario, KTxtContraEditUsu.Text);
                            //}
                            esOk = true;
                            VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("UsuarioModificado"));
                            Close();
                            EnvioEmail.RegistrarUsuario("openlibraryeditor@gmail.com", "bjsxjerndlfahkqe", KTxtEmailEditUsu.Text, KTxtNombreEditUsu.Text, KTxtContraEditUsu.Text, usuario.TipoUsuario, UsuarioDatos.configuracionUsuario.InfoUsuarioActual.Nombre + " (" + UsuarioDatos.configuracionUsuario.InfoUsuarioActual.Correo + ") ");
                        }
                        else
                            VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_ErrorMail"));
                        ConexionBD.CerrarConexion();
                    }
                    else
                        VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexion"));
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("MailNoValido"));
            }
            else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("TodosCamposRellenos"));
        }
        #endregion
        #region cerrar
        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void MBtnCerrarEditUsu_Click(object sender, EventArgs e)
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
        private void PanTituloEditUsu_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}
