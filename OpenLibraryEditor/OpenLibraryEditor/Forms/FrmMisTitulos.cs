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
    public partial class FrmMisTitulos : Form
    {
        public FrmMisTitulos()
        {
            InitializeComponent();
        }

        private void MBtnMasTituloMTI_Click(object sender, EventArgs e)
        {
            Libro l = new Libro();
            FrmLibros t=new FrmLibros(l);
            t.FormBorderStyle = FormBorderStyle.None;
            t.ShowDialog();
        }
    }
}
