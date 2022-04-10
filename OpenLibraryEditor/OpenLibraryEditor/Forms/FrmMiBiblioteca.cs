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
    
    public partial class FrmMiBiblioteca : Form
    {
     
        public FrmMiBiblioteca()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FrmMiBiblioteca_Load(object sender, EventArgs e)
        {
            int tamPanel = PanPcbLibrosMBI.Width;
            int altoPanel = PanPcbLibrosMBI.Height;

            int x = 20;
            int y = 20;
            for (int i = 0; i < 40; i++)
            {
                var imgPictureBox = new PictureBox();
                if (x < (tamPanel-50))
                {
                    
                    imgPictureBox.Location = new System.Drawing.Point(x, y);
                    imgPictureBox.Size = new System.Drawing.Size(140, 170);
                    imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgPictureBox.Image = Image.FromFile(@"C:\Users\Yolanda\Documents\Yolanda\DAM\ProyectoFinal\img\harrypotter.jpg");
                    PanPcbLibrosMBI.Controls.Add(imgPictureBox);
                    imgPictureBox.Visible = true;
                    x = x + 150;
                }
                else
                {
                    x = 20;
                    y = y+180;
                    imgPictureBox.Location = new System.Drawing.Point(x, y);
                    imgPictureBox.Size = new System.Drawing.Size(140, 170);
                    imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    imgPictureBox.Image = Image.FromFile(@"C:\Users\Yolanda\Documents\Yolanda\DAM\ProyectoFinal\img\harrypotter.jpg");
                    PanPcbLibrosMBI.Controls.Add(imgPictureBox);
                    imgPictureBox.Visible = true;

                    x = x + 150;
                }

            }
        }
    }
}
