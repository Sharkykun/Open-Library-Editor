using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor
{
    public partial class FrmSplashScreen : Form
    {
        #region atributos
        private int contador = 0;
        #endregion
        #region constructor y load
        public FrmSplashScreen()
        {
            InitializeComponent();
        }
        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            TimEntrada.Start();
            PcbLogo.Width = 0;
            PcbLogo.Height = 0;
        }
        #endregion
        #region timer entrada y salida
        private void TimEntrada_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.02;
                PcbLogo.Width += 10;
                PcbLogo.Height += 10;

            }
            contador += 1;
            if (contador == 100)
            {
                TimEntrada.Stop();
                TimSalida.Start();
            }
        }
        private void TimSalida_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                Forms.FrmLogin log = new Forms.FrmLogin();
                log.Show();
                TimSalida.Stop();
                this.Hide();
            }
        }
        #endregion

    }
}
