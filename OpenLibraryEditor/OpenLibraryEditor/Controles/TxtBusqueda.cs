using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp.Material;
using ComponentFactory.Krypton.Toolkit;

namespace OpenLibraryEditor.Controles
{
    public partial class TxtBusqueda : UserControl
    {
        public TxtBusqueda()
        {
            InitializeComponent();
        }
        public string getTextobuscar()
        {
            return KTxtBuscarMBI.Text;
        }
        public void setTextobuscar(string s)
        {
            KTxtBuscarMBI.Text=s;
        }
        public MaterialButton MbtnBorrar()
        {
            return MbtnBorrarTxtBuscar;
        }
        private void MbtnBorrarTxtBuscar_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public KryptonTextBox TxtBuscar()
        {
            return KTxtBuscarMBI;
        }
        private void KTxtBuscarMBI_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
    }
}
