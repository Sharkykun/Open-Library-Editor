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
    public partial class FrmMisAutores : Form
    {
        public FrmMisAutores()
        {
            InitializeComponent();
        }

        private void MBtnMasAutorMAU_Click(object sender, EventArgs e)
        {
            FrmAutores a=new FrmAutores(true);
            a.FormBorderStyle = FormBorderStyle.None;
            a.ShowDialog();
        }
    }
}
