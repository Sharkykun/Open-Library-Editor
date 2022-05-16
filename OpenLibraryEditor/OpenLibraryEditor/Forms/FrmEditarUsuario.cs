using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmEditarUsuario : Form
    {
        private bool esEditar;
        private InfoUsuarioBD usuario;

        public FrmEditarUsuario(InfoUsuarioBD usuario, bool esEditar)
        {
            InitializeComponent();
            IdiomaTexto();
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
                    KCmbTipoEditUsu.SelectedIndex = 0;
                    break;
                case "Editor":
                    KCmbTipoEditUsu.SelectedIndex = 1;
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
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            KCmbTipoEditUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Editor"));
            KCmbTipoEditUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Usu"));
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
                    usuario.Nombre = KTxtNombreEditUsu.Text;
                    usuario.Correo = KTxtEmailEditUsu.Text;
                    if(KCmbTipoEditUsu.SelectedIndex == 0)
                        usuario.TipoUsuario = "Editor";
                    if (KCmbTipoEditUsu.SelectedIndex == 1)
                        usuario.TipoUsuario = "Usuario";
                    if (esEditar)
                    {
                        EscrituraBD.UpdateUsuario(usuario.Nombre, usuario, KTxtContraEditUsu.Text);
                    }
                    else
                    {
                        EscrituraBD.InsertUsuario(usuario, KTxtContraEditUsu.Text);
                    }
                    ConexionBD.CerrarConexion();
                    Close();
                }
            }
            else
                VentanaWindowsComun.MensajeError("Todos los campos deben estar rellenados.");
        }

        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
