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
        private bool esAdmin = false;
        private bool esUsuarioPropio = false;

        public FrmEditarUsuario(InfoUsuarioBD usuario, bool esAdmin)
        {
            InitializeComponent();
            this.esAdmin = esAdmin;
            IdiomaTexto();
            KTxtEmailEditUsu.Text = usuario.Nombre;
            //Lo devuelve del servidor si es el usuario propio el que se edita
            //if(esUsuarioPropio) KTxtContraEditUsu.Text =
            if (esAdmin)
            {
                LblTipoEditUsu.Visible = true;
                KCmbTipoEditUsu.Visible = true;
                SeleccionarTipoUsuario(usuario);
            }
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
        }
    }
}
