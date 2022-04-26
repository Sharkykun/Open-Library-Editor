﻿using FontAwesome.Sharp;
using FontAwesome.Sharp.Material;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using OpenLibraryEditor.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        private MaterialButton botonActual;
        private MaterialSplitButton toolSeleccionado;
        private Panel bordeIzqBoton;
        private Form formHijoActual;

        private int altoPantalla;
        private int anchoPantalla;
        private List<Libro> titulos = UsuarioDatos.biblioteca.ListaLibro;
        private Libro libroActual;
        private Button mas = new Button();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
           
            bordeIzqBoton = new Panel();
            bordeIzqBoton.Size = new Size(7, 45);
            PanMenuMain.Controls.Add(bordeIzqBoton);
            //Quitar borde del formulario y evitar el parpadeo y permitir redimensionar
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            anchoPantalla = Screen.FromHandle(this.Handle).WorkingArea.Width;
            altoPantalla = Screen.FromHandle(this.Handle).WorkingArea.Height;
            this.MaximumSize = new Size(anchoPantalla,altoPantalla);
            this.DoubleBuffered = true;
            PanVistaDetalles.Visible = false;
            PanVistaMosaico.Visible = true;
            PanVistaMosaico.BringToFront();
           //vistaDetallesH.setEditoriales("prueba1, prueba 2");

            //Quitar el texto del borde para que simule que no hay, pero se nota
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void RecolocarLibros() {
            if (PanVistaMosaico.Visible == true)
                ColocarLibrosMosaico();
            else
                ColocarLibrosDetalles();
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (ControladorIdioma.idioma.Equals("Strings_fr_FR"))
                LlLogIn.Location = new Point(30,168);
            else if (ControladorIdioma.idioma.Equals("Strings_en_US"))
                LlLogIn.Location = new Point(88, 168);
            else
                LlLogIn.Location = new Point(65, 168);

            TitulosPrueba();
            RecolocarLibros();

            IdiomaTexto();
            PanDetallesLibro.VerticalScroll.Visible = false;
            PanDetallesLibro.HorizontalScroll.Maximum = 0;
            PanDetallesLibro.HorizontalScroll.Visible = false;
            KpDetalles.VerticalScroll.Enabled = false;
            KpDetalles.VerticalScroll.Visible = false;
           
        }
        #region Mostrar libros de la biblioteca
        private void ColocarLibrosMosaico()
        {
            titulos.Sort();
            PanVistaMosaico.Controls.Clear();
            int tamPanel = PanVistaMosaico.Width;
            int altoPanel = PanVistaMosaico.Height;

            int x = 10;
            int y = 10;
            foreach (Libro s in titulos)
            {
                Button botonLibro = new Button();
                if (x < (tamPanel - 135))
                {
                    botonLibro.Location = new Point(x, y);
                    botonLibro.Size = new Size(130, 170);
                    botonLibro.BackgroundImageLayout = ImageLayout.Stretch;
                    botonLibro.BackgroundImage = OpenLibraryEditor.Properties.Resources.PortadaLogo;
                    botonLibro.Text = s.Titulo;
                    botonLibro.Font = new Font("Merienda One", 9, FontStyle.Bold);
                    botonLibro.ForeColor = Color.Gainsboro;
                    botonLibro.Padding = new Padding(15, 0, 5, 0);
                    PanVistaMosaico.Controls.Add(botonLibro);
                    botonLibro.Visible = true;
                    botonLibro.Tag = s;
                    botonLibro.Click += new EventHandler(ManejadorLibro_Click);
                    x = x + 135;
                }
                else
                {
                    x = 10;
                    y = y + 175;
                    botonLibro.Location = new Point(x, y);
                    botonLibro.Size = new Size(130, 170);
                    botonLibro.BackgroundImageLayout = ImageLayout.Stretch;
                    botonLibro.BackgroundImage = OpenLibraryEditor.Properties.Resources.PortadaLogo;
                    botonLibro.Text = s.Titulo;
                    botonLibro.Font = new Font("Merienda One", 9, FontStyle.Bold);
                    botonLibro.ForeColor = Color.Gainsboro;
                    botonLibro.Padding = new Padding(15, 0, 5, 0);
                    PanVistaMosaico.Controls.Add(botonLibro);
                    botonLibro.Visible = true;
                    botonLibro.Tag = s;
                    botonLibro.Click += new EventHandler(ManejadorLibro_Click);
                    x = x + 135;
                }
            }
        }
        private void ManejadorLibro_Click(object sender, EventArgs e)
        {
            
            Button libroSeleccionado = (Button)sender;
            libroActual = (Libro)libroSeleccionado.Tag;
            PanDetallesLibro.Visible = true;
            PcbLibro.Image = libroSeleccionado.BackgroundImage;
            TxtTituloLibro.Text = libroSeleccionado.Text;
            //ColocarLibros();
        }
        private void ManejadorLibroDet_Click(object sender, EventArgs e)
        {

            VistaDetallesV libroSeleccionado = (VistaDetallesV)sender;
            libroActual = (Libro)libroSeleccionado.Tag;
            PanDetallesLibro.Visible = true;
            PcbLibro.Image = libroSeleccionado.getImagen();
            TxtTituloLibro.Text = libroSeleccionado.getTituloLibro();
            TxtPersonas.Text = libroSeleccionado.getPersonas();
            //ColocarLibros();
        }
        private void ColocarLibrosDetalles()
        {
            titulos.Sort();
            PanVistaDetalles.Controls.Clear();
            int tamPanel = PanVistaDetalles.Width;
            int altoPanel = PanVistaDetalles.Height;

            int x = 10;
            int y = 10;
            foreach (Libro s in titulos)
            {
                VistaDetallesV vista = new VistaDetallesV();
                if (x < (tamPanel - 400))
                {
                    vista.Location = new Point(x, y);
                    vista.setTituloLibro(s.Titulo);
                    PanVistaDetalles.Controls.Add(vista);
                    vista.Visible = true;
                    vista.Tag = s;
                    vista.Click += new EventHandler(ManejadorLibroDet_Click);
                    x = x + 439;
                }
                else
                {
                    x = 10;
                    y = y + 255;
                    vista.Location = new Point(x, y);
                    vista.setTituloLibro(s.Titulo);
                    PanVistaDetalles.Controls.Add(vista);
                    vista.Visible = true;
                    vista.Tag = s;
                    vista.Click += new EventHandler(ManejadorLibroDet_Click);
                    x = x + 439;
                }
            }
        }
        private void PruebaDetalles()
        {
            //PanVistaDetalles.Controls.Clear();
            //int tamPanel = PanVistaDetalles.Width;
            //int altoPanel = PanVistaDetalles.Height;

            //int x = 10;
            //int y = 10;
            //foreach (string s in titulos)
            //{
            //    Panel panel = new Panel();
            //    PanelTransparente transparente = new PanelTransparente();
            //    PictureBox pic = new PictureBox();
            //    Label titulo = new Label();
            //    Label personas = new Label();
            //    Label editoriales = new Label();
            //    Label series = new Label();
            //    Label isbn10 = new Label();
            //    Label isbn13=new Label();
            //    Label paginas=new Label();
            //    Label publicado=new Label();
            //    Label idioma = new Label();
            //    Label formato = new Label();
            //    Label escribirEdi = new Label();
            //    Label escribirSer = new Label();
            //    Label escribirIs10 = new Label();
            //    Label escribirIs13 = new Label();
            //    Label escribirPag = new Label();
            //    Label escribirFec = new Label();
            //    Label escribirIdi = new Label();
            //    Label escribirFor = new Label();
            //    if (x < (tamPanel - 419))
            //    {
            //        panel.Location = new Point(x, y);
            //        panel.Size = new Size(419,240);
            //        panel.BackColor = Color.Gainsboro;
            //        pic.Size = new Size(120,160);
            //        pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //        pic.Location=new Point(5, 59);

            //        titulo.ForeColor = Color.Navy;
            //        titulo.BackColor = Color.Transparent;
            //        titulo.Font = new Font("Merienda One",11, FontStyle.Bold);
            //        titulo.Location = new Point(5,5);
            //        titulo.Text = s;

            //        personas.ForeColor = Color.Navy;
            //        personas.BackColor = Color.Transparent;
            //        personas.Font = new Font("Merienda", 9, FontStyle.Italic);
            //        personas.Location=new Point(10,33);
            //        //personas.Text = s.Personas;

            //        editoriales.ForeColor = Color.FromArgb(4,5,214);
            //        editoriales.BackColor = Color.Transparent;
            //        editoriales.Text = ControladorIdioma.GetTexto("Main_Edi");
            //        editoriales.Font = new Font("Merienda",9,FontStyle.Bold);
            //        editoriales.Location = new Point(137,61);
            //        escribirEdi.ForeColor = Color.Black;
            //        escribirEdi.BackColor = Color.Transparent;
            //        //escribirEdi.Text = s.Editoriales;
            //        escribirEdi.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirEdi.Location = new Point(210, 61);

            //        series.ForeColor = Color.FromArgb(4, 5, 214);
            //        series.BackColor = Color.Transparent;
            //        series.Text = ControladorIdioma.GetTexto("Main_Ser");
            //        series.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        series.Location = new Point(165, 81);
            //        escribirSer.ForeColor = Color.Black;
            //        escribirSer.BackColor = Color.Transparent;
            //        //escribirSer.Text = s.Series;
            //        escribirSer.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirSer.Location = new Point(210, 81);

            //        isbn10.ForeColor = Color.FromArgb(4, 5, 214);
            //        isbn10.BackColor = Color.Transparent;
            //        isbn10.Text = ControladorIdioma.GetTexto("Main_is10");
            //        isbn10.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        isbn10.Location = new Point(155, 101);
            //        escribirIs10.ForeColor = Color.Black;
            //        escribirIs10.BackColor = Color.Transparent;
            //        //escribirIs10.Text = s.Isbn10;
            //        escribirIs10.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirIs10.Location = new Point(210, 101);

            //        isbn13.ForeColor = Color.FromArgb(4, 5, 214);
            //        isbn13.BackColor = Color.Transparent;
            //        isbn13.Text = ControladorIdioma.GetTexto("Main_is13");
            //        isbn13.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        isbn13.Location = new Point(155, 121);
            //        escribirIs13.ForeColor = Color.Black;
            //        escribirIs13.BackColor = Color.Transparent;
            //        //escribirIs13.Text = s.Isbn13;
            //        escribirIs13.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirIs13.Location = new Point(210, 121);

            //        paginas.ForeColor = Color.FromArgb(4, 5, 214);
            //        paginas.BackColor = Color.Transparent;
            //        paginas.Text = ControladorIdioma.GetTexto("Main_Pag");
            //        paginas.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        paginas.Location = new Point(155, 141);
            //        escribirPag.ForeColor = Color.Black;
            //        escribirPag.BackColor = Color.Transparent;
            //        //escribirPag.Text = s.Paginas;
            //        escribirPag.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirPag.Location = new Point(210, 141);

            //        publicado.ForeColor = Color.FromArgb(4, 5, 214);
            //        publicado.BackColor = Color.Transparent;
            //        publicado.Text = ControladorIdioma.GetTexto("Main_Publicado");
            //        publicado.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        publicado.Location = new Point(144, 161);
            //        escribirFec.ForeColor = Color.Black;
            //        escribirFec.BackColor = Color.Transparent;
            //        //escribirFec.Text = s.Fecha;
            //        escribirFec.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirFec.Location = new Point(210, 161);

            //        idioma.ForeColor = Color.FromArgb(4, 5, 214);
            //        idioma.BackColor = Color.Transparent;
            //        idioma.Text = ControladorIdioma.GetTexto("Main_Idioma");
            //        idioma.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        idioma.Location = new Point(162, 181);
            //        escribirIdi.ForeColor = Color.Black;
            //        escribirIdi.BackColor = Color.Transparent;
            //        //escribirIdi.Text = s.Idioma;
            //        escribirIdi.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirIdi.Location = new Point(210, 181);

            //        formato.ForeColor = Color.FromArgb(4, 5, 214);
            //        formato.BackColor = Color.Transparent;
            //        formato.Text = ControladorIdioma.GetTexto("Main_Formato");
            //        formato.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        formato.Location = new Point(153, 201);
            //        escribirFor.ForeColor = Color.Black;
            //        escribirFor.BackColor = Color.Transparent;
            //        //escribirFor.Text = s.Formato;
            //        escribirFor.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirFor.Location = new Point(210, 201);

            //        transparente.Location = new Point(x-5, y-5);
            //        transparente.Size = new Size(429,250);
            //        transparente.BringToFront();
            //        transparente.TamBorde = 5;
            //        transparente.ColorBorde = Color.Navy;

            //        panel.Controls.Add(titulo);
            //        titulo.Visible = true;
            //        panel.Controls.Add(personas);
            //        personas.Visible = true;
            //        panel.Controls.Add(editoriales);
            //        editoriales.Visible = true;
            //        panel.Controls.Add(escribirEdi);
            //        escribirEdi.Visible = true;
            //        panel.Controls.Add(series);
            //        series.Visible = true;
            //        panel.Controls.Add(escribirSer);
            //        escribirSer.Visible = true;
            //        panel.Controls.Add(isbn10);
            //        isbn10.Visible = true;
            //        panel.Controls.Add(escribirIs10);
            //        escribirIs10.Visible = true;
            //        panel.Controls.Add(isbn13);
            //        isbn13.Visible = true;
            //        panel.Controls.Add(escribirIs13);
            //        escribirIs13.Visible = true;
            //        panel.Controls.Add(paginas);
            //        paginas.Visible = true;
            //        panel.Controls.Add(escribirPag);
            //        escribirPag.Visible = true;
            //        panel.Controls.Add(publicado);
            //        publicado.Visible = true;
            //        panel.Controls.Add(escribirFec);
            //        escribirFec.Visible = true;
            //        panel.Controls.Add(idioma);
            //        idioma.Visible = true;
            //        panel.Controls.Add(escribirIdi);
            //        escribirIdi.Visible = true;
            //        panel.Controls.Add(formato);
            //        formato.Visible = true;
            //        panel.Controls.Add(escribirFor);
            //        escribirFor.Visible = true;

            //        PanVistaDetalles.Controls.Add(panel);
            //        panel.Visible = true;
            //        PanVistaDetalles.Controls.Add(transparente);
            //        transparente.Visible = true;
            //        transparente.Click += new EventHandler(ManejadorLibroDet_Click);
            //        transparente.MouseEnter += new EventHandler(CambiarColorPanel_Enter);
            //        transparente.MouseLeave += new EventHandler(CambiarColorPanel_Leave);
            //        x = x + 439;
            //    }
            //    else
            //    {
            //        x = 10;
            //        y = y + 255;

            //        panel.Location = new Point(x, y);
            //        panel.Size = new Size(419, 240);
            //        panel.BackColor = Color.Gainsboro;
            //        pic.Size = new Size(120, 160);
            //        pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //        pic.Location = new Point(5, 59);

            //        titulo.ForeColor = Color.Navy;
            //        titulo.BackColor = Color.Transparent;
            //        titulo.Font = new Font("Merienda One", 11, FontStyle.Bold);
            //        titulo.Location = new Point(5, 5);
            //        titulo.Text = s;

            //        personas.ForeColor = Color.Navy;
            //        personas.BackColor = Color.Transparent;
            //        personas.Font = new Font("Merienda", 9, FontStyle.Italic);
            //        personas.Location = new Point(10, 33);
            //        //personas.Text = s.Personas;

            //        editoriales.ForeColor = Color.FromArgb(4, 5, 214);
            //        editoriales.BackColor = Color.Transparent;
            //        editoriales.Text = ControladorIdioma.GetTexto("Main_Edi");
            //        editoriales.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        editoriales.Location = new Point(137, 61);
            //        escribirEdi.ForeColor = Color.Black;
            //        escribirEdi.BackColor = Color.Transparent;
            //        //escribirEdi.Text = s.Editoriales;
            //        escribirEdi.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirEdi.Location = new Point(210, 61);

            //        series.ForeColor = Color.FromArgb(4, 5, 214);
            //        series.BackColor = Color.Transparent;
            //        series.Text = ControladorIdioma.GetTexto("Main_Ser");
            //        series.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        series.Location = new Point(165, 81);
            //        escribirSer.ForeColor = Color.Black;
            //        escribirSer.BackColor = Color.Transparent;
            //        //escribirSer.Text = s.Series;
            //        escribirSer.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirSer.Location = new Point(210, 81);

            //        isbn10.ForeColor = Color.FromArgb(4, 5, 214);
            //        isbn10.BackColor = Color.Transparent;
            //        isbn10.Text = ControladorIdioma.GetTexto("Main_is10");
            //        isbn10.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        isbn10.Location = new Point(155, 101);
            //        escribirIs10.ForeColor = Color.Black;
            //        escribirIs10.BackColor = Color.Transparent;
            //        //escribirIs10.Text = s.Isbn10;
            //        escribirIs10.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirIs10.Location = new Point(210, 101);

            //        isbn13.ForeColor = Color.FromArgb(4, 5, 214);
            //        isbn13.BackColor = Color.Transparent;
            //        isbn13.Text = ControladorIdioma.GetTexto("Main_is13");
            //        isbn13.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        isbn13.Location = new Point(155, 121);
            //        escribirIs13.ForeColor = Color.Black;
            //        escribirIs13.BackColor = Color.Transparent;
            //        //escribirIs13.Text = s.Isbn13;
            //        escribirIs13.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirIs13.Location = new Point(210, 121);

            //        paginas.ForeColor = Color.FromArgb(4, 5, 214);
            //        paginas.BackColor = Color.Transparent;
            //        paginas.Text = ControladorIdioma.GetTexto("Main_Pag");
            //        paginas.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        paginas.Location = new Point(155, 141);
            //        escribirPag.ForeColor = Color.Black;
            //        escribirPag.BackColor = Color.Transparent;
            //        //escribirPag.Text = s.Paginas;
            //        escribirPag.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirPag.Location = new Point(210, 141);

            //        publicado.ForeColor = Color.FromArgb(4, 5, 214);
            //        publicado.BackColor = Color.Transparent;
            //        publicado.Text = ControladorIdioma.GetTexto("Main_Publicado");
            //        publicado.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        publicado.Location = new Point(144, 161);
            //        escribirFec.ForeColor = Color.Black;
            //        escribirFec.BackColor = Color.Transparent;
            //        //escribirFec.Text = s.Fecha;
            //        escribirFec.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirFec.Location = new Point(210, 161);

            //        idioma.ForeColor = Color.FromArgb(4, 5, 214);
            //        idioma.BackColor = Color.Transparent;
            //        idioma.Text = ControladorIdioma.GetTexto("Main_Idioma");
            //        idioma.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        idioma.Location = new Point(162, 181);
            //        escribirIdi.ForeColor = Color.Black;
            //        escribirIdi.BackColor = Color.Transparent;
            //        //escribirIdi.Text = s.Idioma;
            //        escribirIdi.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirIdi.Location = new Point(210, 181);

            //        formato.ForeColor = Color.FromArgb(4, 5, 214);
            //        formato.BackColor = Color.Transparent;
            //        formato.Text = ControladorIdioma.GetTexto("Main_Formato");
            //        formato.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        formato.Location = new Point(153, 201);
            //        escribirFor.ForeColor = Color.Black;
            //        escribirFor.BackColor = Color.Transparent;
            //        //escribirFor.Text = s.Formato;
            //        escribirFor.Font = new Font("Merienda", 9, FontStyle.Bold);
            //        escribirFor.Location = new Point(210, 201);

            //        transparente.Location = new Point(x - 5, y - 5);
            //        transparente.Size = new Size(429, 250);
            //        transparente.BringToFront();
            //        transparente.TamBorde = 5;
            //        transparente.ColorBorde = Color.Navy;

            //        panel.Controls.Add(titulo);
            //        titulo.Visible = true;
            //        panel.Controls.Add(personas);
            //        personas.Visible = true;
            //        panel.Controls.Add(editoriales);
            //        editoriales.Visible = true;
            //        panel.Controls.Add(escribirEdi);
            //        escribirEdi.Visible = true;
            //        panel.Controls.Add(series);
            //        series.Visible = true;
            //        panel.Controls.Add(escribirSer);
            //        escribirSer.Visible = true;
            //        panel.Controls.Add(isbn10);
            //        isbn10.Visible = true;
            //        panel.Controls.Add(escribirIs10);
            //        escribirIs10.Visible = true;
            //        panel.Controls.Add(isbn13);
            //        isbn13.Visible = true;
            //        panel.Controls.Add(escribirIs13);
            //        escribirIs13.Visible = true;
            //        panel.Controls.Add(paginas);
            //        paginas.Visible = true;
            //        panel.Controls.Add(escribirPag);
            //        escribirPag.Visible = true;
            //        panel.Controls.Add(publicado);
            //        publicado.Visible = true;
            //        panel.Controls.Add(escribirFec);
            //        escribirFec.Visible = true;
            //        panel.Controls.Add(idioma);
            //        idioma.Visible = true;
            //        panel.Controls.Add(escribirIdi);
            //        escribirIdi.Visible = true;
            //        panel.Controls.Add(formato);
            //        formato.Visible = true;
            //        panel.Controls.Add(escribirFor);
            //        escribirFor.Visible = true;

            //        PanVistaDetalles.Controls.Add(panel);
            //        panel.Visible = true;
            //        PanVistaDetalles.Controls.Add(transparente);
            //        transparente.Visible = true;
            //        transparente.Click += new EventHandler(ManejadorLibroDet_Click);
            //        transparente.MouseEnter += new EventHandler(CambiarColorPanel_Enter);
            //        transparente.MouseLeave += new EventHandler(CambiarColorPanel_Leave);
            //        x = x + 439;
            //    }
            //    void CambiarColorPanel_Enter(object sender, EventArgs e)
            //    {
            //        panel.BackColor = Color.Silver;
            //    }
            //    void CambiarColorPanel_Leave(object sender, EventArgs e)
            //    {
            //        panel.BackColor = Color.Gainsboro;
            //    }
            //}
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
            PanVistaDetalles.Visible = true;
            PanVistaMosaico.Visible = false;
            ColocarLibrosDetalles();
            PanVistaDetalles.BringToFront();
        }

        private void MBtnVistaMosaicoMBI_Click(object sender, EventArgs e)
        {
            PanVistaDetalles.Visible = false;
            PanVistaMosaico.Visible = true;
            PanVistaMosaico.BringToFront();
        }
        private void PanVistaMosaico_Resize(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ColocarLibrosMosaico();
        }
        private void PanVistaDetalles_Resize(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            //PruebaDetalles();
            ColocarLibrosDetalles();
        }
        private void MBtncerrarDetallesLibro_Click(object sender, EventArgs e)
        {
            PanDetallesLibro.Visible = false;
        }

        #endregion
        #region texto segun idioma seleccionado
        public void IdiomaTexto()
        {
            ToolTipMain.SetToolTip(this.AciFotoUsuario, ControladorIdioma.GetTexto("Main_TTFotoUsuario"));
            LlLogIn.Text = ControladorIdioma.GetTexto("Main_LinkSesion");
            ToolTipMain.SetToolTip(this.LlLogIn, ControladorIdioma.GetTexto("Main_TTLink"));
            MBtnMiBiblioteca.Text= ControladorIdioma.GetTexto("Main_MiBiblioteca");
            ToolTipMain.SetToolTip(this.MBtnMiBiblioteca, ControladorIdioma.GetTexto("Main_MiBiblioteca"));
            MBtnAutores.Text = ControladorIdioma.GetTexto("Main_Autores");
            ToolTipMain.SetToolTip(this.MBtnAutores, ControladorIdioma.GetTexto("Main_TTAutores"));
            MBtnTítulos.Text = ControladorIdioma.GetTexto("Main_Titulos");
            ToolTipMain.SetToolTip(this.MBtnTítulos, ControladorIdioma.GetTexto("Main_TTTitulos"));
            MBtnGeneros.Text = ControladorIdioma.GetTexto("Main_Generos");
            ToolTipMain.SetToolTip(this.MBtnGeneros, ControladorIdioma.GetTexto("Main_TTGeneros"));
            MBtnSeries.Text = ControladorIdioma.GetTexto("Main_Series");
            ToolTipMain.SetToolTip(this.MBtnSeries, ControladorIdioma.GetTexto("Main_TTSeries"));
            MBtnEditoriales.Text = ControladorIdioma.GetTexto("Main_Editoriales");
            ToolTipMain.SetToolTip(this.MBtnEditoriales, ControladorIdioma.GetTexto("Main_TTEditoriales"));
            MBtnTags.Text = ControladorIdioma.GetTexto("Main_Tags");
            ToolTipMain.SetToolTip(this.MBtnTags, ControladorIdioma.GetTexto("Main_TTTags"));
            MBtnBuscar.Text = ControladorIdioma.GetTexto("Main_Buscar");
            ToolTipMain.SetToolTip(this.MBtnBuscar, ControladorIdioma.GetTexto("Main_TTBuscar"));
            MBtnConfiguracion.Text = ControladorIdioma.GetTexto("Main_Confi");
            ToolTipMain.SetToolTip(this.MBtnConfiguracion, ControladorIdioma.GetTexto("Main_TTConfi"));
            MBtnSalir.Text = ControladorIdioma.GetTexto("Main_Salir");
            ToolTipMain.SetToolTip(this.MBtnSalir, ControladorIdioma.GetTexto("Main_TTSalir"));
            BtnAniadirLibroMsb.Text = ControladorIdioma.GetTexto("Main_NuevoLibro");
            BtnModificarLibroMsb.Text = ControladorIdioma.GetTexto("Main_Modificar");
            BtnBorrarLibroMsb.Text = ControladorIdioma.GetTexto("Main_Eliminar");
            BtnAutoresMsb.Text = ControladorIdioma.GetTexto("Main_Autores");
            BtnGenerosMsb.Text = ControladorIdioma.GetTexto("Main_Generos");
            BtnSeriesMsb.Text = ControladorIdioma.GetTexto("Main_Series");
            BtnEditorialesMsb.Text = ControladorIdioma.GetTexto("Main_Editoriales");
            BtnTagsMsb.Text = ControladorIdioma.GetTexto("Main_Tags");
            ToolTipMain.SetToolTip(this.PcbLogoMain, ControladorIdioma.GetTexto("Main_TTLogo"));
            ToolTipMain.SetToolTip(this.LblTituloMain, ControladorIdioma.GetTexto("Main_TTFormTitulo"));
            ToolTipMain.SetToolTip(this.MBtnMinimizarMain, ControladorIdioma.GetTexto("Main_TTMinimizar"));
            ToolTipMain.SetToolTip(this.MBtnMaximizarMain, ControladorIdioma.GetTexto("Main_TTMaximizar"));
            ToolTipMain.SetToolTip(this.MBtnRestaurarMain, ControladorIdioma.GetTexto("Main_TTRestaurar"));
            ToolTipMain.SetToolTip(this.MBtnCerrarMain, ControladorIdioma.GetTexto("Main_TTCerrar"));
        }
        #endregion
        #region Colores boton seleccionado
        private void BotonActivo(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
                DesactivarBoton();
                //Boton
                botonActual = (MaterialButton)senderBtn;
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                //Borde izquierdo
                bordeIzqBoton.BackColor = color;
                bordeIzqBoton.Location = new Point(0, botonActual.Location.Y);
                bordeIzqBoton.Visible = true;
                bordeIzqBoton.BringToFront();
            }
        }
        private void BotonActivoTool(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                toolSeleccionado = (MaterialSplitButton)senderBtn;
                toolSeleccionado.ForeColor = color;
                toolSeleccionado.IconColor = color;
            }
        }

        private void DesactivarBoton()
        {
            if (botonActual != null)
            {
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
            if (toolSeleccionado!=null)
            {
                toolSeleccionado.ForeColor = Color.Gainsboro;
                toolSeleccionado.IconColor = Color.Gainsboro;
            }
        }
     
        //Estructura colores
        private struct Colores
        {
            public static Color colorBiblioteca = Color.FromArgb(239, 184, 16);
            public static Color colorSubmenu = Color.FromArgb(0, 201, 142);
            public static Color colorBuscar = Color.FromArgb(249, 88, 155);
            public static Color colorConfi = Color.FromArgb(164, 204, 255);
            public static Color colorTool = Color.FromArgb(164, 204, 255);
        }
        private void ResetColores()
        {
            DesactivarBoton();
            bordeIzqBoton.Visible = false;
        }

        #endregion
        #region Abrir formularios hijos
        private void AbrirFormularios(Form fhijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = fhijo;
            fhijo.TopLevel = false;
            fhijo.FormBorderStyle=FormBorderStyle.None;
            fhijo.Dock=DockStyle.Fill;
            this.DoubleBuffered = true;
            PanHijos.Controls.Add(fhijo);
            PanHijos.Tag = fhijo;
            fhijo.BringToFront();
            fhijo.Show();

        }
        #endregion
        #region Botones menu lateral
        private void MBtnMiBiblioteca_Click(object sender, EventArgs e)
        {
            //AbrirFormularios(new FrmMiBiblioteca());
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = false;
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_MiBiblioteca");
            MPcbTituloFrm.IconChar = FontAwesome.Sharp.MaterialIcons.BookOpenPageVariant;
            BotonActivo(sender, Colores.colorBiblioteca);
        }
        private void MBtnAutores_Click(object sender, EventArgs e)
        {
            //AbrirFormularios(new FrmMisAutores());
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = true;
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_TTAutores");
            MPcbTituloFrm.IconChar = FontAwesome.Sharp.MaterialIcons.AccountGroup;
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnTitulos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisTitulos());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnGeneros_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisGeneros());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnSeries_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisSeries());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisEditoriales());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnTags_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisTags());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmBuscar());
            BotonActivo(sender, Colores.colorBuscar);
        }
        private void MBtnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmConfiguracion());
            BotonActivo(sender, Colores.colorConfi);
        }

        #endregion
        #region botones tool
        private void BtnAniadirLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            Libro nuevoLibro = new Libro();
            FrmLibros al = new FrmLibros(nuevoLibro);
            if (nuevoLibro.Isbn_13 == null)
                titulos.Add(nuevoLibro);
            al.FormBorderStyle=FormBorderStyle.None;
            al.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
            RecolocarLibros();
        }
        private void BtnModificarLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmLibros al = new FrmLibros(libroActual);
            al.FormBorderStyle = FormBorderStyle.None;
            al.ShowDialog();
            BotonActivoTool(sender, Colores.colorBiblioteca);
            RecolocarLibros();
        }
        private void BtnBorrarLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            BotonActivoTool(sender,Colores.colorBiblioteca);
            if (VentanaWindowsComun.MensajeBorrarObjeto("el libro") == DialogResult.Yes)
            {
                titulos.Remove(libroActual);
                RecolocarLibros();
            }
        }
        private void BtnAutoresMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmAutores autores = new FrmAutores(true);
            autores.FormBorderStyle = FormBorderStyle.None;
            autores.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnGenerosMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmGeneros generos = new FrmGeneros(true);
            generos.FormBorderStyle = FormBorderStyle.None;
            generos.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnSeriesMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmSeries series = new FrmSeries(true);
            series.FormBorderStyle = FormBorderStyle.None;
            series.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnEditorialesMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmEditoriales editoriales = new FrmEditoriales(true);
            editoriales.FormBorderStyle = FormBorderStyle.None;
            editoriales.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnTagsMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmTags tags = new FrmTags(true);
            tags.FormBorderStyle = FormBorderStyle.None;
            tags.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        #endregion
        #region Botones minimizar, maximizar, restaurar, redimensionar y salir
        //Para saber el tamaño y la posicion inicial de la pantalla y poder restaurarla en el centro de la pantalla
        private int lx, ly;
        private int sw, sh;
        private void MBtnRestaurar_Click(object sender, EventArgs e)
        {
            MBtnMaximizarMain.Visible = true;
            MBtnRestaurarMain.Visible = false;
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void MBtnMinimizarMain_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void MBtnMaximizarMain_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            MBtnMaximizarMain.Visible = false;
            MBtnRestaurarMain.Visible = true;
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            e.Graphics.FillRectangle(Brushes.Navy, Superior);
            e.Graphics.FillRectangle(Brushes.Navy, Izquierda);
            e.Graphics.FillRectangle(Brushes.Navy, Derecha);
            e.Graphics.FillRectangle(Brushes.Navy, Inferior);
        }

        //método para poder redimensionar el formulario sin borde
        private const int
            IZQUIERDA = 10,
            DERECHA = 11,
            SUPERIOR = 12,
            SUPERIORIZQDA = 13,
            SUPERIORDCHA = 14,
            INFERIOR = 15,
            INFERIORIZQDA = 16,
            INFERIORDCHA = 17;

        private const int MARGEN = 10;
        Rectangle Superior { get { return new Rectangle(0, 0, this.ClientSize.Width, MARGEN); } }
        Rectangle Izquierda { get { return new Rectangle(0, 0, MARGEN, this.ClientSize.Height); } }
        Rectangle Inferior { get { return new Rectangle(0, this.ClientSize.Height - MARGEN, this.ClientSize.Width, MARGEN); } }
        Rectangle Derecha { get { return new Rectangle(this.ClientSize.Width - MARGEN, 0, MARGEN, this.ClientSize.Height); } }

        Rectangle SupIzqda { get { return new Rectangle(0, 0, MARGEN, MARGEN); } }
        Rectangle SupDcha { get { return new Rectangle(this.ClientSize.Width - MARGEN, 0, MARGEN, MARGEN); } }
        Rectangle InfIzqda { get { return new Rectangle(0, this.ClientSize.Height - MARGEN, MARGEN, MARGEN); } }
        Rectangle InfDcha { get { return new Rectangle(this.ClientSize.Width - MARGEN, this.ClientSize.Height - MARGEN, MARGEN, MARGEN); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (SupIzqda.Contains(cursor)) message.Result = (IntPtr)SUPERIORIZQDA;
                else if (SupDcha.Contains(cursor)) message.Result = (IntPtr)SUPERIORDCHA;
                else if (InfIzqda.Contains(cursor)) message.Result = (IntPtr)INFERIORIZQDA;
                else if (InfDcha.Contains(cursor)) message.Result = (IntPtr)INFERIORDCHA;

                else if (Superior.Contains(cursor)) message.Result = (IntPtr)SUPERIOR;
                else if (Izquierda.Contains(cursor)) message.Result = (IntPtr)IZQUIERDA;
                else if (Derecha.Contains(cursor)) message.Result = (IntPtr)DERECHA;
                else if (Inferior.Contains(cursor)) message.Result = (IntPtr)INFERIOR;
            }
        }


        #endregion
        #region cerrar formulario
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = Clases.ControladorIdioma.GetTexto("ShowDialogCerrar");
            
            DialogResult boton = MessageBox.Show(mensaje, "Open Library Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (boton == DialogResult.Yes)
            {
                //Guardar datos en la base de datos local
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void MBtnCerrarMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MBtnSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        #endregion
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
