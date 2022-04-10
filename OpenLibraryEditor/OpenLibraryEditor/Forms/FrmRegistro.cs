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
    public partial class FrmRegistro : Form
    {
        private string idioma;
        public FrmRegistro(string idiomaSeleccionado)
        {
            InitializeComponent();
            idioma = idiomaSeleccionado;
        }
       

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            if (idioma.Equals("spanish"))
            {
                Clases.ControladorIdioma.idioma = "Strings_es_ES";
                IdiomaTexto();
            }
            else if (idioma.Equals("english"))
            {
                Clases.ControladorIdioma.idioma = "Strings_en_US";
                IdiomaTexto();
            }
            else 
            {
                Clases.ControladorIdioma.idioma = "Strings_fr_FR";
                IdiomaTexto();
            }
        }

        private void IdiomaTexto()
        {
            LblTituloFrm.Text = Clases.ControladorIdioma.GetTexto("Reg_TituloForm");
            LblUrlReg.Text = Clases.ControladorIdioma.GetTexto("Reg_Url");
            LblNombreReg.Text = Clases.ControladorIdioma.GetTexto("Reg_Nombre");
            LblContraReg.Text = Clases.ControladorIdioma.GetTexto("Reg_Contra");
            LblContra1Reg.Text = Clases.ControladorIdioma.GetTexto("Reg_Contra1");
            BtnRegistrarme.Text = Clases.ControladorIdioma.GetTexto("Reg_BtnRegistro");
        }
        private void MBtnCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrarme_Click(object sender, EventArgs e)
        {

        }
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //Para poder mover el formulario por la pantalla
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void IpcbMostrarContraReg_Click(object sender, EventArgs e)
        {
            Metodos.MetodosComunes.MostrarOcultarContra(KTxtContraReg, true, false, IpcbOcultarContraReg, IpcbMostrarContraReg);
        }
        private void IpcbOcultarContraReg_Click(object sender, EventArgs e)
        {
            Metodos.MetodosComunes.MostrarOcultarContra(KTxtContraReg, false, true, IpcbMostrarContraReg, IpcbOcultarContraReg);
        }
        private void IpcbMostrarContra1Reg_Click(object sender, EventArgs e)
        {
            Metodos.MetodosComunes.MostrarOcultarContra(KTxtContra1Reg, true, false, IpcbOcultarContra1Reg, IpcbMostrarContra1Reg);
        }

        private void IpcbOcultarContra1Reg_Click(object sender, EventArgs e)
        {
            Metodos.MetodosComunes.MostrarOcultarContra(KTxtContra1Reg,false,true,IpcbMostrarContra1Reg,IpcbOcultarContra1Reg);

        }

        
    }
}
