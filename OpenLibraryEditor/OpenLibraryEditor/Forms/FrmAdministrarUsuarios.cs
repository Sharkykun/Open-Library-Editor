using OpenLibraryEditor.Clases;
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
    public partial class FrmAdministrarUsuarios : Form
    {
        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            KCmbBuscarPorUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Nombre"));
            KCmbBuscarPorUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Email"));
            KCmbBuscarPorUsu.Items.Add(ControladorIdioma.GetTexto("Adm_CmbTipo"));
            KCmbBuscarPorUsu.SelectedIndex = 0;

            KCmbTipoUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Editor"));
            KCmbTipoUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Usu"));
        }

        private void IdiomaTexto()
        {
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Adm_FrmTitulo");
            LblBuscarPor.Text= ControladorIdioma.GetTexto("BuscarPor");
            KgbDatosUsuario.Values.Heading = ControladorIdioma.GetTexto("Adm_DatosUsu");
            LblNombreUsu.Text = ControladorIdioma.GetTexto("Adm_NombreUsu");
            LblEmail.Text= ControladorIdioma.GetTexto("Reg_Email");
            LblContra.Text= ControladorIdioma.GetTexto("Reg_Contra");
            LblTipoUsu.Text = ControladorIdioma.GetTexto("Adm_Tipo");
        }

        private void LsvUsuariosBD_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            KgbDatosUsuario.Visible = true;
            
            //foreach(Usuario u in listaUsuariosBD) { 
            //    LblEscribirNombreUsu.Text = u.Nombre;
            //    LblEscribirEmail.Text = u.Email;
            //    LblEscribirContra.Text = u.Contra;
            //    KCmbTipoUsu.SelectedItem = u.Tipo;
            //}
        }
    }
}
