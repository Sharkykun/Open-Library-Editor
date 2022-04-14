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
    public partial class FrmMisSeries : Form
    {
        public FrmMisSeries()
        {
            InitializeComponent();
        }

        private void MBtnMasSerieMSE_Click(object sender, EventArgs e)
        {
            FrmSeries s=new FrmSeries(true);
            s.FormBorderStyle = FormBorderStyle.None;
            s.ShowDialog();
        }
    }
}
