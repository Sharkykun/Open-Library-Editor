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
    public partial class FrmRegistro : Form
    {
     
        public FrmRegistro()
        {
            InitializeComponent();
        }
       

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
        }

        private void IdiomaTexto()
        {
            TTRegistro.SetToolTip(this.PcbLogoRegistro, ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloFrm.Text = ControladorIdioma.GetTexto("Reg_TituloForm");
            TTRegistro.SetToolTip(this.LblTituloFrm, ControladorIdioma.GetTexto("Reg_TituloForm"));
            LblUrlReg.Text = ControladorIdioma.GetTexto("Reg_Url");
            TTRegistro.SetToolTip(this.TxtUrlReg, ControladorIdioma.GetTexto("Reg_TTUrl"));
            LblNombreReg.Text = ControladorIdioma.GetTexto("Reg_Nombre");
            TTRegistro.SetToolTip(this.TxtNombreReg, ControladorIdioma.GetTexto("Reg_TTNombre"));
            LblMailReg.Text = ControladorIdioma.GetTexto("Reg_Email");
            TTRegistro.SetToolTip(this.TxtMailReg, ControladorIdioma.GetTexto("Reg_TTEmail"));
            LblContraReg.Text = ControladorIdioma.GetTexto("Reg_Contra");
            TTRegistro.SetToolTip(this.KTxtContraReg, ControladorIdioma.GetTexto("Reg_TTContra"));
            LblContra1Reg.Text = ControladorIdioma.GetTexto("Reg_Contra1");
            TTRegistro.SetToolTip(this.KTxtContra1Reg, ControladorIdioma.GetTexto("Reg_TTContra1"));
            BtnRegistrarme.Text = ControladorIdioma.GetTexto("Reg_BtnRegistro");
            TTRegistro.SetToolTip(this.BtnRegistrarme, ControladorIdioma.GetTexto("Reg_BtnRegistro"));
            TTRegistro.SetToolTip(this.IpcbMostrarContraReg, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTRegistro.SetToolTip(this.IpcbOcultarContra1Reg, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTRegistro.SetToolTip(this.IpcbOcultarContraReg, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTRegistro.SetToolTip(this.IpcbOcultarContra1Reg, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTRegistro.SetToolTip(this.MBtnCerrarRegistro, ControladorIdioma.GetTexto("Cerrar"));
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
            MetodosComunes.MostrarOcultarContra(KTxtContraReg, true, false, IpcbOcultarContraReg, IpcbMostrarContraReg);
        }
        private void IpcbOcultarContraReg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraReg, false, true, IpcbMostrarContraReg, IpcbOcultarContraReg);
        }
        private void IpcbMostrarContra1Reg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContra1Reg, true, false, IpcbOcultarContra1Reg, IpcbMostrarContra1Reg);
        }

        private void IpcbOcultarContra1Reg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContra1Reg,false,true,IpcbMostrarContra1Reg,IpcbOcultarContra1Reg);

        }

        
    }
}
