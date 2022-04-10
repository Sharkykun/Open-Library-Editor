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
    public partial class FrmMisEditoriales : Form
    {
        public FrmMisEditoriales()
        {
            InitializeComponent();
        }

        private void MBtnMasEditorialMED_Click(object sender, EventArgs e)
        {
            FrmEditoriales ed=new FrmEditoriales();
            ed.FormBorderStyle = FormBorderStyle.None;
            ed.ShowDialog();
        }
    }
}
