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
    
    public partial class FrmMiBiblioteca : Form
    {
        
        public FrmMiBiblioteca()
        {
            InitializeComponent();
        
        }

        private void FrmMiBiblioteca_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            string tipoUsu;
            if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual != null) { 
                switch (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario)
                {
                    case "Administrador":
                        tipoUsu = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Adm");
                        break;
                    case "Usuario":
                        tipoUsu = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Usu");
                        break;
                    case "Editor":
                        tipoUsu = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Editor");
                        break;
                    default:
                        tipoUsu = ControladorIdioma.GetTexto("ModoSinConexion");
                        break;
                }
                LblTipoUsuarioConectado.Text = tipoUsu;
            }
            else
            {
                LblTipoUsuarioConectado.Text= ControladorIdioma.GetTexto("ModoSinConexion");
            }
            
        }

        private void IdiomaTexto()
        {
            if (ControladorIdioma.idioma.Equals("Strings_fr_FR"))
            {
                LblNoLibros.Location = new Point(172,572);
            }
            else
            {
                LblNoLibros.Location = new Point(230, 572);
            }
            LblBienvenido.Text = ControladorIdioma.GetTexto("Bienvenido");
            LblNoLibros.Text = ControladorIdioma.GetTexto("NoLibros");
        }
    }
}
