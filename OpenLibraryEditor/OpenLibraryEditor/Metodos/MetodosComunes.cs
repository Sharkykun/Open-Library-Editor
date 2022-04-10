using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Metodos
{
    public class MetodosComunes
    {
        public static void MostrarOcultarContra(KryptonTextBox txt, bool bTrue, bool bFalse, IconPictureBox ipcbS, IconPictureBox ipcbH)
        {
            if (txt.UseSystemPasswordChar == bTrue)
            {
                txt.UseSystemPasswordChar = bFalse;
                txt.PasswordChar = '\0';
                ipcbH.Hide();
                ipcbS.Show();
            }
            else
                txt.PasswordChar = '●';
        }

       

    }
}
