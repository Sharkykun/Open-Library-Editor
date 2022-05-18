using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
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
        private bool esEditar;
        private InfoUsuarioBD usuario;
        private bool esOk = false;

        public bool EsOk { get => esOk; set => esOk = value; }

        public FrmEditarUsuario(InfoUsuarioBD usuario, bool esEditar)
        {
            InitializeComponent();
            this.usuario = usuario;
            KTxtNombreEditUsu.Text = usuario.Nombre;
            KTxtEmailEditUsu.Text = usuario.Correo;
            this.esEditar = esEditar;
        }

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

        private void IdiomaTexto()
        {
            LblTitulo.Text = ControladorIdioma.GetTexto("BD_Titulo");
            KgbDatosEditUsu.Values.Heading = ControladorIdioma.GetTexto("BD_DApp");
            LblContraEditUsu.Text = ControladorIdioma.GetTexto("Reg_Contra");
            LblEmailEditUsu.Text = ControladorIdioma.GetTexto("Reg_Email");
            LblTipoEditUsu.Text = ControladorIdioma.GetTexto("Adm_Tipo");
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Aceptar");
            KCmbTipoEditUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Editor"));
            KCmbTipoEditUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Usu"));
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            SeleccionarTipoUsuario(usuario);
        }

        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(KTxtNombreEditUsu.Text) &&
                !String.IsNullOrWhiteSpace(KTxtContraEditUsu.Text) &&
               !String.IsNullOrWhiteSpace(KTxtEmailEditUsu.Text))
            {
                if (ConexionBD.AbrirConexion())
                {
                    string nombreAntiguo = usuario.Nombre;
                    usuario.Nombre = KTxtNombreEditUsu.Text;
                    usuario.Correo = KTxtEmailEditUsu.Text;
                    if(KCmbTipoEditUsu.SelectedIndex == 0)
                        usuario.TipoUsuario = ControladorIdioma.GetTexto("Adm_Editor");
                    if (KCmbTipoEditUsu.SelectedIndex == 1)
                        usuario.TipoUsuario = ControladorIdioma.GetTexto("Adm_Usu");
                    if (esEditar)
                    {
                        EscrituraBD.UpdateUsuario(nombreAntiguo, usuario, KTxtContraEditUsu.Text);
                    }
                    else
                    {
                        EscrituraBD.InsertUsuario(usuario, KTxtContraEditUsu.Text);
                    }
                    ConexionBD.CerrarConexion();
                    esOk = true;
                    VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("UsuarioModificado"));
                    Close();
                }
            }
            else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("TodosCamposRellenos"));
        }

        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MBtnCerrarEditUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
