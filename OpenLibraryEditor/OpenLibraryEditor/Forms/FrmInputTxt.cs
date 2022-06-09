using OpenLibraryEditor.Clases;
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
    public partial class FrmInputTxt : Form
    {
        #region atributos
        public string tipo;
        public bool editable;
        #endregion
        #region constructor y load
        public FrmInputTxt(string s)
        {
            InitializeComponent();
            tipo = s;
        }
        private void FrmInputTxt_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            KTxtNombreTipo.Focus();
            if (!String.IsNullOrWhiteSpace(tipo))
            {
                KTxtNombreTipo.Text = tipo;
                GBtnGuardar.Enabled = false;
                GBtnModificar.Enabled = true;
                GBtnEliminar.Enabled = true;
            }
            else
            {
                GBtnGuardar.Enabled = true;
                GBtnModificar.Enabled = false;
                GBtnEliminar.Enabled = false;
            }
        }
        #endregion
        #region idioma
        private void IdiomaTexto()
        {
            if(this.Text.Equals("Tipo libro")) { 
                LblTitulo.Text = ControladorIdioma.GetTexto("InputL_Titulo");
                this.Text = ControladorIdioma.GetTexto("InputL_Titulo");
                LblNombre.Text = ControladorIdioma.GetTexto("InputL_Texto");
            }
            else if(this.Text.Equals("Ocupación"))
            {
                LblTitulo.Text = ControladorIdioma.GetTexto("InputA_Titulo");
                this.Text = ControladorIdioma.GetTexto("InputA_Titulo");
                LblNombre.Text = ControladorIdioma.GetTexto("InputA_Texto");
            }
            else
            {
                LblTitulo.Text = ControladorIdioma.GetTexto("InputC_Titulo");
                LblNombre.Text = ControladorIdioma.GetTexto("InputC_Texto");
            }
            GBtnGuardar.Text = ControladorIdioma.GetTexto("Guardar");
            TTInput.SetToolTip(this.GBtnGuardar, ControladorIdioma.GetTexto("Guardar"));
            GBtnModificar.Text = ControladorIdioma.GetTexto("Input_Modificar");
            TTInput.SetToolTip(this.GBtnModificar, ControladorIdioma.GetTexto("Input_Modificar"));
            GBtnEliminar.Text = ControladorIdioma.GetTexto("Input_Eliminar");
            TTInput.SetToolTip(this.GBtnEliminar, ControladorIdioma.GetTexto("Input_Eliminar"));
            TTInput.SetToolTip(this.KTxtNombreTipo, ControladorIdioma.GetTexto("Input_TT"));
        }
        #endregion

        #region botones
        private void GBtnGuardar_Click(object sender, EventArgs e)
        {
            tipo = KTxtNombreTipo.Text;
            editable = false;
            VentanaWindowsComun.MensajeInformacion(tipo + " " + ControladorIdioma.GetTexto("VWC_Guardado"));
            this.Close();
        }

        private void GBtnModificar_Click(object sender, EventArgs e)
        {
            tipo=KTxtNombreTipo.Text;
            editable = true;
            VentanaWindowsComun.MensajeInformacion(tipo + " " + ControladorIdioma.GetTexto("VWC_Modificado"));
            this.Close();
        }

        private void GBtnEliminar_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto(KTxtNombreTipo.Text) == DialogResult.Yes)
            {
                VentanaWindowsComun.MensajeInformacion(tipo + " " + ControladorIdioma.GetTexto("VWC_Borrado"));
                tipo = null;
                this.Close();
                
            }
            
        }
        private void MBtnCerrarAutores_Click(object sender, EventArgs e)
        {
            tipo = "";
            this.Close();
        }
        #endregion
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloAutores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
