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
    
    public partial class FrmMiBiblioteca : Form
    {
        private List<Libro> titulos = Biblioteca.biblioteca.ListaLibro;
        Button mas = new Button();
        public FrmMiBiblioteca()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            PanDetalles.Visible = false;
            PanMosaico.Visible = true;
            PanMosaico.BringToFront();
        }

        private void FrmMiBiblioteca_Load(object sender, EventArgs e)
        {
            //imgPictureBox.Location = new System.Drawing.Point(x, y);
            //imgPictureBox.Size = new System.Drawing.Size(140, 180);
            //imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //imgPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //imgPictureBox.Image = Image.FromFile(@"C:\Users\Yolanda\Documents\Yolanda\DAM\ProyectoFinal\img\harrypotter.jpg");
            //PanMosaico.Controls.Add(imgPictureBox);
            //imgPictureBox.Visible = true;
            TitulosPrueba();
            if (PanMosaico.Visible == true)
                ColocarLibrosMosaico();
            else
                ColocarLibrosDetalles();
        }
        private void ColocarLibrosMosaico()
        {
            PanMosaico.Controls.Clear();
            int tamPanel = PanMosaico.Width;
            int altoPanel = PanMosaico.Height;

            int x = 20;
            int y = 10;
            foreach (Libro s in titulos)
            {
                //var imgPictureBox = new PictureBox();
                //Panel estante = new Panel();
                //estante.Height = 5;
                //estante.Width = tamPanel;
                //estante.BackColor = Color.Navy;
                //estante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                //PanMosaico.Controls.Add(estante);
                //estante.Visible = true;
                Button botonLibro = new Button();
                if (x < (tamPanel - 140))
                {
                    botonLibro.Location = new System.Drawing.Point(x, y);
                    botonLibro.Size = new System.Drawing.Size(140, 180);
                    botonLibro.BackgroundImageLayout = ImageLayout.Stretch;
                    botonLibro.BackgroundImage = OpenLibraryEditor.Properties.Resources.PortadaLogo;
                    botonLibro.Text = s.Titulo;
                    botonLibro.Font = new Font("Merienda One", 10, FontStyle.Bold);
                    botonLibro.ForeColor = Color.Gainsboro;
                    botonLibro.Padding = new Padding(15, 0, 5, 0);
                    PanMosaico.Controls.Add(botonLibro);
                    botonLibro.Visible = true;
                    botonLibro.Click += new EventHandler(ManejadorLibro_Click);
                    x = x + 150;
                    //estante.Location = new Point(x-10, y + 180);
                }
                else
                {
                    x = 20;
                    y = y + 190;
                    botonLibro.Location = new System.Drawing.Point(x, y);
                    botonLibro.Size = new System.Drawing.Size(140, 180);
                    botonLibro.BackgroundImageLayout = ImageLayout.Stretch;
                    botonLibro.BackgroundImage = OpenLibraryEditor.Properties.Resources.PortadaLogo;
                    botonLibro.Text = s.Titulo;
                    botonLibro.Font = new Font("Merienda One", 10, FontStyle.Bold);
                    botonLibro.ForeColor = Color.Gainsboro;
                    botonLibro.Padding = new Padding(15, 0, 5, 0);
                    PanMosaico.Controls.Add(botonLibro);
                    botonLibro.Visible = true;
                    botonLibro.Click += new EventHandler(ManejadorLibro_Click);
                    x = x + 150;
                }
            }
        }
        private void ManejadorLibro_Click(object sender, EventArgs e)
        {
            Button libroSeleccionado = (Button)sender;
            PanDetallesLibro.Visible = true;
            PcbLibro.Image=libroSeleccionado.BackgroundImage;
            TxtTituloLibro.Text=libroSeleccionado.Text;
            //ColocarLibros();
        }
        private void ColocarLibrosDetalles() 
        {
            string mostrar;
            string ocultar;
            string sinopsis= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Pellentesque fringilla at nibh eget scelerisque. Aliquam luctus ac mi id vehicula. " +
                "Mauris tortor sem, aliquet in mauris non, tempus fringilla eros. Aliquam justo ante, placerat et " +
                "vestibulum a, egestas id sapien. Nam tincidunt metus id metus eleifend elementum. Donec elit nibh, " +
                "aliquam vel facilisis ac, ultrices ut quam. Etiam tincidunt, arcu ut finibus pretium, metus ante " +
                "hendrerit ante, nec eleifend dui mi eu odio. Vivamus vulputate lectus quis suscipit rutrum. Ut " +
                "tincidunt et enim ac ultrices.";
            TxtPrueba.ForeColor = Color.Gainsboro;
            TxtPrueba.Cursor = Cursors.Arrow;
            mas.Width = 90;
            mas.Height = 30;
            mas.FlatStyle = FlatStyle.Standard;
            mas.Cursor = Cursors.Hand;
            TxtPrueba.Font = new Font("Merienda", 10, FontStyle.Regular);
            mas.Location = new Point((TxtPrueba.Width - mas.Width - 5), (TxtPrueba.Height - mas.Height - 5));
            mas.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            mas.Font = new Font("Merienda", 10, FontStyle.Bold);
            mas.ForeColor = Color.Navy;
            mas.BackColor = Color.Gainsboro;
            if (sinopsis.Length > 250)
            {
                mostrar = sinopsis.Substring(0, 250);
                ocultar = sinopsis.Substring(251);
                TxtPrueba.Text = mostrar + " ...";
                mas.Text = "Ver más";
                TxtPrueba.Controls.Add(mas);
                mas.Show();
                mas.Click += new EventHandler(VerMas_Click);
            }
            else
            {
                TxtPrueba.Text = sinopsis;
            }

            void VerMas_Click(object sender, EventArgs e)
            {
                if (mas.Text.Equals("Ver más"))
                {
                    PanDetallesLibro.Visible = true;
                    PcbLibro.Image = button1.BackgroundImage;
                    TxtTituloLibro.Text = TxtTituloDetalles.Text;
                    TxtTituloLibro.Font = new Font("Merienda One", 10, FontStyle.Bold);
                    label1.Font = new Font("Merienda", 10, FontStyle.Regular);
                    label1.Text = sinopsis;
                    label1.ForeColor = Color.Gainsboro;
                    mas.Text = "Ocultar";
                }
                else
                {
                    PanDetallesLibro.Visible = false;
                    TxtPrueba.Text = mostrar + " .....";
                    mas.Text = "Ver más";
                }
                //mas.Click += new EventHandler(Ocultar_Click);
            }
        }
       
        private void TitulosPrueba()
        {
            titulos.Add(new Libro("1", "Caballero Luna"));
            titulos.Add(new Libro("2", "Spiderman Homecoming"));
            titulos.Add(new Libro("3", "Thor"));
            //titulos.Add("Capitán América");
            //titulos.Add("Los Vengadores");
            //titulos.Add("Iron Man");
            //titulos.Add("Viuda negra");
            //titulos.Add("Black Panther");
            //titulos.Add("Guardianes de la Galaxia");
            //titulos.Add("Wanda y Visión");
            //titulos.Add("Ojo de Halcón");
            //titulos.Add("Loki");
            //titulos.Add("Bruja Escarlata");
            //titulos.Add("Capitana Marvel");
            //titulos.Add("Shan-Chi la leyenda de los 10 anillos ");
            //titulos.Add("Ant-Man");
            //titulos.Add("Eternals");
            //titulos.Add("Doctor Strange");
            //titulos.Add("Hulk");
            //titulos.Add("Falcon y el Soldado de invierno");
        }

        private void MBtnVistaDetallesMBI_Click(object sender, EventArgs e)
        {
            PanDetalles.Visible = true;
            PanMosaico.Visible = false; 
            ColocarLibrosDetalles();
            PanDetalles.BringToFront();
        }

        private void MBtnVistaMosaicoMBI_Click(object sender, EventArgs e)
        {
            PanDetalles.Visible = false;
            PanMosaico.Visible = true;
            PanMosaico.BringToFront();
        }

        private void PanMosaico_Resize(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ColocarLibrosMosaico();
        }

        private void MBtncerrarDetallesLibro_Click(object sender, EventArgs e)
        {
            PanDetallesLibro.Visible = false;
        }

       
    }
}
