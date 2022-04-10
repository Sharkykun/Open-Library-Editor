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
    public partial class FrmMisGeneros : Form
    {
        public FrmMisGeneros()
        {
            InitializeComponent();
        }

        private void MBtnMasGeneroMGE_Click(object sender, EventArgs e)
        {
            FrmGeneros g=new FrmGeneros();
            g.FormBorderStyle= FormBorderStyle.None;
            g.ShowDialog();
        }
    }
}
