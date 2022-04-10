using System;
using System.Collections;
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
    public partial class FrmConfiguracion : Form
    {
        private List<string> idiomas;
        public FrmConfiguracion()
        {
            InitializeComponent();
            CmbIdiomaConfi.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIdiomaConfi.DrawMode = DrawMode.OwnerDrawFixed;
            CmbIdiomaConfi.Items.AddRange(Enumerable.Repeat<string>(" ", ImlIdiomas.Images.Count).ToArray());
            idiomas = new List<string>();
            idiomas.Add("Español de España (European Spanish)");
            idiomas.Add("English (EEUU)");
            idiomas.Add("Français (French)");
            
        }

        private void CmbIdiomaConfi_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index >= 0)
            {
                if (e.Index < ImlIdiomas.Images.Count)
                {
                    Image img = new Bitmap(ImlIdiomas.Images[e.Index], new Size(20, 20));
                    e.Graphics.DrawImage(img, new PointF(e.Bounds.Left+4, e.Bounds.Top+2));
                }
                e.Graphics.DrawString(string.Format(idiomas[e.Index], e.Index + 1)
                 , e.Font, new SolidBrush(e.ForeColor)
                 , e.Bounds.Left + 36, e.Bounds.Top+2);
            }
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {

        }

      
    }
}
