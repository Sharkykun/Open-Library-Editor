﻿using System;
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
    public partial class FrmMisTags : Form
    {
        public FrmMisTags()
        {
            InitializeComponent();
        }

        private void MBtnMasTagMTA_Click(object sender, EventArgs e)
        {
            FrmTags t=new FrmTags();
            t.FormBorderStyle = FormBorderStyle.None;
            t.ShowDialog();
        }
    }
}
