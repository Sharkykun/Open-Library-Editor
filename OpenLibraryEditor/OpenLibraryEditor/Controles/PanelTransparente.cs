using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace OpenLibraryEditor.Controles
{
    public class PanelTransparente : Panel
    {
        private int tamBorde = 0;
        private Color colorBorde = Color.FromArgb(4,5,214);

        public PanelTransparente()
        {
            this.Size = new Size(542,202);
            this.BackColor = Color.FromArgb(100,Color.Black);
        }
        //Properties
        [Category("Mis propiedades")]
        public int TamBorde
        {
            get { return tamBorde; }
            set
            {
                tamBorde = value;
                this.Invalidate();
            }
        }

        [Category("Mis Propiedades")]
        public Color ColorBorde
        {
            get { return colorBorde; }
            set
            {
                colorBorde = value;
                this.Invalidate();
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.None;
            //Button surface
            //this.Region = new Region(rectSurface);
            //Button border
            if (tamBorde >= 1)
            {
                using (Pen penBorder = new Pen(colorBorde, tamBorde))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
           // ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Navy, ButtonBorderStyle.Solid);
        }
        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //e.Graphics.DrawLines(pen,points);
            //Pen p = new Pen(Color.Navy); // Esto puede venir de una variable si necesitas un color cambiante
            //e.Graphics.DrawRectangle(p, this.Left - 1, this.Top - 1, this.Width + 1, this.Height + 1);
        }
    }
}
