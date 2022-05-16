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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmWebView : Form
    {
        private string enlace;
        public FrmWebView(string enlacePasado)
        {
            InitializeComponent();
            enlace = enlacePasado;
        }
        private void WebView_Load(object sender, EventArgs e)
        {
            IniciarBrowser();
        }
        private async Task Iniciar()
        {
            await webView2Enlace.EnsureCoreWebView2Async(null);
        }
        public async void IniciarBrowser()
        {
            await Iniciar();
            webView2Enlace.CoreWebView2.Navigate(enlace);
        }
        
       
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
   
        private void PanTituloTitulos_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region maximizar, minimizar, restaurar y cerrar
        //Para saber el tamaño y la posicion inicial de la pantalla y poder restaurarla en
        //el centro de la pantalla
        private int lx, ly;
        private int sw, sh;
        private void MBtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            MBtnMaximizar.Visible = false;
            MBtnRestaurar.Visible = true;
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void MBtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MBtnRestaurar_Click(object sender, EventArgs e)
        {
            MBtnMaximizar.Visible = true;
            MBtnRestaurar.Visible = false;
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        private void MBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
