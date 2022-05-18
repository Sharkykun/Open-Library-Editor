using FontAwesome.Sharp;
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
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using OpenLibraryEditor.BaseDatos;

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
        private List<Libro> titulos;
        private Libro libroActual;
        private int segundosRedimensionar;
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            titulos = SacarListaLibro();
            bordeIzqBoton = new Panel();
            bordeIzqBoton.Size = new Size(7, 45);
            PanMenuMain.Controls.Add(bordeIzqBoton);
            //Quitar borde del formulario, evitar el parpadeo y permitir redimensionar
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

            
           
        }
         private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (ControladorIdioma.idioma.Equals("Strings_fr_FR"))
                LlLogIn.Location = new Point(30,168);
            else if (ControladorIdioma.idioma.Equals("Strings_en_US"))
                LlLogIn.Location = new Point(88, 168);
            else
                LlLogIn.Location = new Point(65, 168);

            //TitulosPrueba();
            //RecolocarLibros(false);
            SeleccionarVista();


            //Dejar marcado mi biblioteca como opción inicial
            MBtnMiBiblioteca_Click(MBtnMiBiblioteca, null);
            
            IdiomaTexto();
            
        }
        private void SeleccionarVista()
        {
            if (UsuarioDatos.configuracionUsuario.TipoVista == 0)
            {
                PanVistaMosaico.Visible = true;
                PanVistaDetalles.Visible = false;
                PanVistaMosaico.BringToFront();
            }
            else
            {
                PanVistaMosaico.Visible = false;
                PanVistaDetalles.Visible = true;
                PanVistaDetalles.BringToFront();
            }
        }

        private List<Libro> SacarListaLibro()
        {
            List<Libro> libro;
            if (UsuarioDatos.configuracionUsuario.ContenidoExplicito)
                libro = Biblioteca.biblioteca.ListaLibro;
            else
                libro = Biblioteca.biblioteca.ListaLibro.FindAll(
                    p => !p.MayorEdad);
            return libro;
        }

        private void GenerarPortadaLibro(Libro libro, Button botonLibro)
        {
            if (File.Exists(libro.ImagenPortada))
            {
                botonLibro.BackgroundImage = Image.FromFile(libro.ImagenPortada);
            }
            else
            {
                botonLibro.BackgroundImage = Properties.Resources.PortadaLogo;
                botonLibro.Text = libro.Titulo;
                botonLibro.Font = new Font("Merienda One", 9, FontStyle.Bold);
                botonLibro.ForeColor = Color.Gainsboro;
                botonLibro.Padding = new Padding(15, 0, 5, 0);
            }
        }

        private void RecolocarLibros(bool ignorarOrdenar) {
            SeleccionarVista();
            if (!ignorarOrdenar)
                titulos.Sort();
            if (PanVistaMosaico.Visible == true)
                ColocarLibrosMosaico();
            else
                ColocarLibrosDetalles();
        }
       
        #region Mostrar libros de la biblioteca
        private void ColocarLibrosMosaico()
        {
            //PanVistaMosaico.BringToFront();
            //PanVistaMosaico.Visible = true;
            //PanVistaDetalles.Visible = false;
            PanVistaMosaico.Controls.Clear();
            int tamPanel = PanVistaMosaico.Width;
            int altoPanel = PanVistaMosaico.Height;

            int x = 10;
            int y = 10;
            foreach (Libro libro in titulos)
            {
                DoubleClickButton botonLibro = new DoubleClickButton();
                if (x < (tamPanel - 135))
                {
                    botonLibro.Location = new Point(x, y);
                    botonLibro.Size = new Size(130, 170);
                    botonLibro.BackgroundImageLayout = ImageLayout.Stretch;
                    botonLibro.Tag = libro;
                    GenerarPortadaLibro(libro, botonLibro);
                    PanVistaMosaico.Controls.Add(botonLibro);
                    botonLibro.Visible = true;
                    botonLibro.Click += new EventHandler(ManejadorLibro_Click);
                    botonLibro.DoubleClick += new EventHandler(DobleClickLibro);
                    x = x + 135;
                }
                else
                {
                    x = 10;
                    y = y + 175;
                    botonLibro.Location = new Point(x, y);
                    botonLibro.Size = new Size(130, 170);
                    botonLibro.BackgroundImageLayout = ImageLayout.Stretch;
                    botonLibro.Tag = libro;
                    GenerarPortadaLibro(libro, botonLibro);
                    PanVistaMosaico.Controls.Add(botonLibro);
                    botonLibro.Visible = true;
                    botonLibro.Click += new EventHandler(ManejadorLibro_Click);
                    botonLibro.DoubleClick += new EventHandler(DobleClickLibro);
                    x = x + 135;
                }
            }
        }
        private void ColocarLibrosDetalles()
        {
            PanVistaDetalles.Controls.Clear();
            //PanVistaDetalles.BringToFront();
            //PanVistaDetalles.Visible = true;
            //PanVistaMosaico.Visible = false;
            int tamPanel = PanVistaDetalles.Width;
            int altoPanel = PanVistaDetalles.Height;

            int x = 10;
            int y = 10;
            foreach (Libro libro in titulos)
            {
                VistaDetallesV vista = new VistaDetallesV();
                if (x < (tamPanel - 400))
                {
                    vista.Location = new Point(x, y);
                    vista.setTituloLibro(libro.Titulo + " " + libro.Subtitulo);
                    vista.Tag = libro;
                    if (libro.ImagenPortada!=null &&
                        File.Exists(libro.ImagenPortada))
                        vista.setImagen(Image.FromFile(libro.ImagenPortada));
                    else
                        vista.setImagen(Properties.Resources.PortadaLogo);

                    foreach (Autor a in libro.ListaAutor)
                    {
                        vista.setAutores(a.Nombre);
                    }
                    foreach (Editorial ed in libro.ListaEditorial)
                    {
                        vista.setEditoriales(ed.Nombre);
                    }
                    if (!String.IsNullOrWhiteSpace(libro.Idioma))
                        vista.setIdioma(libro.Idioma);
                    if (!String.IsNullOrWhiteSpace(libro.NumeroPaginas.ToString()))
                        vista.setPaginas(libro.NumeroPaginas.ToString());

                    if (!String.IsNullOrWhiteSpace(libro.NombreTipo))
                        vista.setFormato(libro.NombreTipo);

                    if (!String.IsNullOrWhiteSpace(libro.FechaPublicacion.ToShortDateString()))
                        vista.setFecha(libro.FechaPublicacion.ToShortDateString());

                    if (String.IsNullOrWhiteSpace(libro.Isbn_10))
                        vista.setIsbn10(ControladorIdioma.GetTexto("Main_NoDis"));
                    else
                        vista.setIsbn10(libro.Isbn_10);

                    if (String.IsNullOrWhiteSpace(libro.Isbn_13))
                        vista.setIsbn13(ControladorIdioma.GetTexto("Main_NoDis"));
                    else
                        vista.setIsbn13(libro.Isbn_13);

                    PanVistaDetalles.Controls.Add(vista);
                    vista.Visible = true;
                    vista.Click += new EventHandler(ManejadorLibroDet_Click);
                    vista.DoubleClick += new EventHandler(DobleClickLibro);
                    x = x + 420;
                }
                else
                {
                    x = 10;
                    y = y + 260;
                    vista.Location = new Point(x, y);
                    vista.setTituloLibro(libro.Titulo + " " + libro.Subtitulo);
                    vista.Tag = libro;
                    if (libro.ImagenPortada != null &&
                        File.Exists(libro.ImagenPortada))
                        vista.setImagen(Image.FromFile(libro.ImagenPortada));
                    else
                        vista.setImagen(Properties.Resources.PortadaLogo);

                    foreach (Autor a in libro.ListaAutor)
                    {
                        vista.setAutores(a.Nombre);
                    }
                    foreach (Editorial ed in libro.ListaEditorial)
                    {
                        vista.setEditoriales(ed.Nombre);
                    }
                    if(!String.IsNullOrWhiteSpace(libro.Idioma))
                        vista.setIdioma(libro.Idioma);
                    if (!String.IsNullOrWhiteSpace(libro.NumeroPaginas.ToString()))
                        vista.setPaginas(libro.NumeroPaginas.ToString());

                    if (!String.IsNullOrWhiteSpace(libro.NombreTipo))
                        vista.setFormato(libro.NombreTipo);

                    if (!String.IsNullOrWhiteSpace(libro.FechaPublicacion.ToShortDateString()))
                        vista.setFecha(libro.FechaPublicacion.ToShortDateString());

                    if (String.IsNullOrWhiteSpace(libro.Isbn_10))
                        vista.setIsbn10(ControladorIdioma.GetTexto("Main_NoDis"));
                    else
                        vista.setIsbn10(libro.Isbn_10);

                    if (String.IsNullOrWhiteSpace(libro.Isbn_13))
                        vista.setIsbn13(ControladorIdioma.GetTexto("Main_NoDis")); 
                    else
                        vista.setIsbn13(libro.Isbn_13);
                    
                    PanVistaDetalles.Controls.Add(vista);
                    vista.Visible = true;
                    vista.Click += new EventHandler(ManejadorLibroDet_Click);
                    vista.DoubleClick += new EventHandler(DobleClickLibro);
                    x = x + 420;
                }
            }
        }
        private void ResetearDetallesLibro()
        {
            TxtSinopsis.Clear();
            TxtAutores.Clear();
            LblEscribirGenero.Text="";
            LblEscribirEditorial.Text = "";
            LblEscribirEtiquetas.Text = "";
            LblEscribirCapiAct.Text = "";
            LblEscribirCapitulos.Text = "";
            LblEscribirEstadoLectura.Text = "";
            LblEscribirEtiquetas.Text = "";
            LblEscribirFavorito.Text = "";
            LblEscribirFecComienzo.Text = "";
            LblEscribirFecFin.Text = "";
            LblEscribirFechaPub.Text = "";
            LblEscribirIdioma.Text = "";
            LblEscribirIdiOri.Text = "";
            LblEscribirIs10.Text = "";
            LblEscribirIs13.Text = "";
            LblEscribirOculto.Text = "";
            LblEscribirPag.Text = "";
            LblEscribirPuntuacion.Text = "";
            LblEscribirTiempoLec.Text = "";
            LblEscribirTipoLibro.Text = "";
            LblEscribirVecesLeido.Text = "";
            LblFin.Text = "";
        }
        private void ManejadorLibro_Click(object sender, EventArgs e)
        {
            //KTabDetalles.SelectedPage = KpDetalles;
            ResetearDetallesLibro();
            Button libroSeleccionado = (Button)sender;
            libroActual = (Libro)libroSeleccionado.Tag;
            if (PanDetallesLibro.Visible == false) { 
                MostrarDetallesLibro(libroActual);
                RecolocarLibros(false);
            }
            else
            {
                MostrarDetallesLibro(libroActual);
            }
        }
        private void MostrarDetallesLibro(Libro l)
        {
            PanDetallesLibro.Visible = true;
            BtnBorrarLibroMsb.Enabled = true;
            BtnModificarLibroMsb.Enabled = true;
            //PanVistaMosaico_Resize(null,null);

            if (File.Exists(l.ImagenPortada))
                PcbLibro.Image = Image.FromFile(l.ImagenPortada);
            else
                PcbLibro.Image = Properties.Resources.PortadaLogo;

            TxtTituloLibro.Text = l.Titulo + " " + l.Subtitulo;
            string quitarComa = null;
            foreach (Autor a in l.ListaAutor)
            {
                quitarComa += a.Nombre + ", ";
            }
            if(!String.IsNullOrWhiteSpace(quitarComa))
                TxtAutores.Text = quitarComa.Substring(0, (quitarComa.LastIndexOf(", ")));

            TxtSinopsis.Text = l.Sinopsis;
            foreach (Editorial ed in l.ListaEditorial)
            {
                LblEscribirEditorial.AutoSize = true;
                LblEscribirEditorial.MaximumSize = new Size(109, 0);
                if (l.ListaEditorial.Count > 1 || LblEscribirEditorial.Width > 109)
                {
                    LblEscribirEditorial.Text += ed.Nombre.ToUpper() + "\r\n";
                }
                else
                {
                    LblEscribirEditorial.Text += ed.Nombre.ToUpper();
                }
            }
            if (String.IsNullOrWhiteSpace(l.Isbn_10))
                LblEscribirIs10.Text = ControladorIdioma.GetTexto("Main_NoDis");
            else
                LblEscribirIs10.Text = l.Isbn_10;
            if (String.IsNullOrWhiteSpace(l.Isbn_13))
                LblEscribirIs13.Text = ControladorIdioma.GetTexto("Main_NoDis");
            else
                LblEscribirIs13.Text = l.Isbn_13;

            LblEscribirCapitulos.Text = l.NumeroCapitulos.ToString();
            LblEscribirPag.Text = l.NumeroPaginas.ToString();
            foreach (Genero g in l.ListaGenero)
            {
                LblEscribirGenero.AutoSize = true;
                LblEscribirGenero.MaximumSize = new Size(109, 0);
                if (l.ListaGenero.Count > 1 || LblEscribirGenero.Width > 109)
                    LblEscribirGenero.Text += g.Nombre.ToUpper() + "\r\n";
                else
                    LblEscribirGenero.Text += g.Nombre.ToUpper();
            }
            //foreach (Etiqueta et in libro.ListaEtiqueta)
            //{
            //    LblEscribirEtiquetas.AutoSize = true;
            //    LblEscribirEtiquetas.MaximumSize = new Size(109, 0);
            //    if (libro.ListaEtiqueta.Count > 1 || LblEscribirEtiquetas.Width > 109)
            //        LblEscribirEtiquetas.Text += et.Nombre.ToUpper() + "\r\n";
            //    else
            //        LblEscribirEtiquetas.Text += et.Nombre.ToUpper();
            //}
            if (!String.IsNullOrWhiteSpace(l.Idioma))
                LblEscribirIdioma.Text = l.Idioma.ToUpper();
            if (!String.IsNullOrWhiteSpace(l.IdiomaOriginal))
                LblEscribirIdiOri.Text = l.IdiomaOriginal.ToUpper();
            if (l.NombreTipo != null)
                LblEscribirTipoLibro.Text = l.NombreTipo.ToUpper();
            LblEscribirFechaPub.Text = l.FechaPublicacion.ToShortDateString();
            LblEscribirPuntuacion.Text = l.Puntuacion.ToString();
            LblEscribirVecesLeido.Text = l.VecesLeido.ToString();
            LblEscribirEstadoLectura.Text = l.EstadoLectura;
            LblEscribirTiempoLec.Text = l.TiempoLectura.ToString(@"hh\:mm\:ss");
            LblEscribirCapiAct.Text = l.CapituloActual.ToString();
            LblEscribirFecComienzo.Text = l.FechaComienzo.ToShortDateString();
            LblEscribirFecFin.Text = l.FechaTerminado.ToShortDateString();
            if (l.Favorito == true)
                LblEscribirFavorito.Text = ControladorIdioma.GetTexto("Main_Si");
            else
                LblEscribirFavorito.Text = ControladorIdioma.GetTexto("Main_No");
            if (l.Ocultar == true)
                LblEscribirOculto.Text = ControladorIdioma.GetTexto("Main_Si");
            else
                LblEscribirOculto.Text = ControladorIdioma.GetTexto("Main_No");

            TxtEscribirComentario.Text = l.Comentario;
           
        }
        private void ManejadorLibroDet_Click(object sender, EventArgs e)
        {
            //KTabDetalles.SelectedPage = KpDetalles;
            ResetearDetallesLibro();
            VistaDetallesV libroSeleccionado = (VistaDetallesV)sender;
            libroActual = (Libro)libroSeleccionado.Tag;
            if (PanDetallesLibro.Visible == false)
            {
                MostrarDetallesLibro(libroActual);
                RecolocarLibros(false);
            }
            else
            {
                MostrarDetallesLibro(libroActual);
            }
        }

        private void EsperarHastaFinDeProcesos(List<Process> listaProcesos)
        {
            FormWindowState state = this.WindowState;
            this.WindowState = FormWindowState.Minimized;

            //Calcular tiempo de lectura = lo que tarda en cerrar los procesos
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (!listaProcesos.All(p => p.HasExited))
            {
                Thread.Sleep(100);
            }

            //Obtener y establecer tiempo de lectura
            watch.Stop();
            TimeSpan time;
            if(libroActual.TiempoLectura != null)
                time = libroActual.TiempoLectura;
            else
                time = new TimeSpan();
            libroActual.TiempoLectura = time.Add(watch.Elapsed);
            LblEscribirTiempoLec.Text = libroActual.TiempoLectura.ToString(@"hh\:mm\:ss");

            //Reactivar ventana y desbloquear
            Enabled = true;
            Cursor.Current = Cursors.Default;
            this.WindowState = state;
            Activate();
        }

        private void DobleClickLibro(object sender, EventArgs e)
        {
            //Determinar acción en base a configuración de usuarioFormResize
            switch (UsuarioDatos.configuracionUsuario.AccionDobleClick)
            {
                case 0:
                    //Ejecutar libro
                    
                    if (libroActual.ListaAccion.Count > 0)
                    {
                        List<Process> listaProcesos = new List<Process>();
                        //Ocultar ventana y bloquear
                        Cursor.Current = Cursors.WaitCursor;
                        Enabled = false;

                        foreach (UsuarioAccion ac in libroActual.ListaAccion)
                        {
                            Process p = ac.EjecutarAccion();
                            if (p != null)
                                listaProcesos.Add(p);
                            else
                            {
                                VentanaWindowsComun.MensajeError("No se pudo ejecutar. Compruebe que la ruta del fichero" +
                                    "\ny el ejecutable son correctas.");
                            }
                        }
                        EsperarHastaFinDeProcesos(listaProcesos);
                    }
                    
                    break;
                case 1:
                    //Modificar información libro
                    BtnModificarLibroMsb_ButtonClick(null, null);
                    break;
            }
        }

        private void LinkEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(libroActual.EnlaceReferencia))
            {
                FrmWebView wv = new FrmWebView(libroActual.EnlaceReferencia);
                wv.FormBorderStyle = FormBorderStyle.None;
                wv.ShowDialog();
                //Process.Start(libroActual.EnlaceReferencia);
            }

            else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_NoEnlace"));
        }

        private void TitulosPrueba()
        {
            if (titulos.Count == 0)
            {
                titulos.Add(new Libro("Caballero Luna"));
                titulos.Add(new Libro("Spiderman Homecoming"));
                titulos.Add(new Libro("Thor"));
                //titulos.Add(new Libro("Capitán América"));
                //titulos.Add(new Libro("Los Vengadores"));
                //titulos.Add(new Libro("Iron Man"));
                //titulos.Add(new Libro("Viuda negra"));
                //titulos.Add(new Libro("Black Panther"));
                //titulos.Add(new Libro("Guardianes de la Galaxia"));
                //titulos.Add(new Libro("Wanda y Visión"));
                //titulos.Add(new Libro("Ojo de Halcón"));
                //titulos.Add(new Libro("Loki"));
                //titulos.Add(new Libro("Bruja Escarlata"));
                //titulos.Add(new Libro("Capitana Marvel"));
                //titulos.Add(new Libro("Shan-Chi la leyenda de los 10 anillos"));
                //titulos.Add(new Libro("Ant-Man"));
                //titulos.Add(new Libro("Eternals"));
                //titulos.Add(new Libro("Doctor Strange"));
                //titulos.Add(new Libro("Hulk"));
                //titulos.Add(new Libro("Falcon y el Soldado de invierno"));
            }
        }
        private void MBtnVistaDetallesMBI_Click(object sender, EventArgs e)
        {
            //PanVistaDetalles.Visible = true;
            //PanVistaMosaico.Visible = false;
            //PanDetallesLibro.Visible = false;
            //PanVistaDetalles.BringToFront();
            UsuarioDatos.configuracionUsuario.TipoVista = 1;
            RecolocarLibros(false);
        }

        private void FormResize()
        {
            if (formHijoActual != null)
            {
                formHijoActual.WindowState = FormWindowState.Normal;
                formHijoActual.WindowState = FormWindowState.Maximized;
            }
        }
        private void MBtnVistaMosaicoMBI_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.TipoVista = 0;
            //PanVistaDetalles.Visible = false;
            //PanVistaMosaico.Visible = true;
            //PanDetallesLibro.Visible = false;
            //PanVistaMosaico.BringToFront();
            RecolocarLibros(false);
            
        }

        private void FrmMenuPrincipal_ResizeEnd(object sender, EventArgs e)
        {   
            RecolocarLibros(false);
        }
        private void MBtncerrarDetallesLibro_Click(object sender, EventArgs e)
        {
            PanDetallesLibro.Visible = false;
            BtnBorrarLibroMsb.Enabled = false;
            BtnModificarLibroMsb.Enabled = false;
            RecolocarLibros(false);
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
            MBtnGeneros.Text = ControladorIdioma.GetTexto("Main_Generos");
            ToolTipMain.SetToolTip(this.MBtnGeneros, ControladorIdioma.GetTexto("Main_TTGeneros"));
            MBtnEditoriales.Text = ControladorIdioma.GetTexto("Main_Editoriales");
            ToolTipMain.SetToolTip(this.MBtnEditoriales, ControladorIdioma.GetTexto("Main_TTEditoriales"));
            MBtnSeries.Text = ControladorIdioma.GetTexto("Main_Series");
            ToolTipMain.SetToolTip(this.MBtnSeries, ControladorIdioma.GetTexto("Main_TTSeries"));
            MBtnTags.Text = ControladorIdioma.GetTexto("Main_Tags");
            ToolTipMain.SetToolTip(this.MBtnTags, ControladorIdioma.GetTexto("Main_TTTags"));
            MBtnBuscar.Text = ControladorIdioma.GetTexto("Main_Buscar");
            ToolTipMain.SetToolTip(this.MBtnBuscar, ControladorIdioma.GetTexto("Main_TTBuscar"));
            MBtnFavoritos.Text= ControladorIdioma.GetTexto("Favoritos");
            ToolTipMain.SetToolTip(this.MBtnFavoritos, ControladorIdioma.GetTexto("Main_Favoritos"));
            MBtnConfiguracion.Text = ControladorIdioma.GetTexto("Main_Confi");
            ToolTipMain.SetToolTip(this.MBtnConfiguracion, ControladorIdioma.GetTexto("Main_TTConfi"));
            MBtnSalir.Text = ControladorIdioma.GetTexto("Main_Salir");
            ToolTipMain.SetToolTip(this.MBtnSalir, ControladorIdioma.GetTexto("Main_TTSalir"));
            BtnAniadirLibroMsb.Text = ControladorIdioma.GetTexto("Main_NuevoLibro");
            BtnModificarLibroMsb.Text = ControladorIdioma.GetTexto("Main_Modificar");
            BtnBorrarLibroMsb.Text = ControladorIdioma.GetTexto("Main_Eliminar");
            BtnAutoresMsb.Text = ControladorIdioma.GetTexto("Main_MasAutor");
            BtnGenerosMsb.Text = ControladorIdioma.GetTexto("Main_MasGenero");
            BtnSeriesMsb.Text = ControladorIdioma.GetTexto("Main_MasSerie");
            BtnEditorialesMsb.Text = ControladorIdioma.GetTexto("Main_MasEdi");
            BtnTagsMsb.Text = ControladorIdioma.GetTexto("Main_MasEtiqueta");
            ToolTipMain.SetToolTip(this.PcbLogoMain, ControladorIdioma.GetTexto("Main_TTLogo"));
            ToolTipMain.SetToolTip(this.LblTituloMain, ControladorIdioma.GetTexto("Main_TTFormTitulo"));
            ToolTipMain.SetToolTip(this.MBtnMinimizarMain, ControladorIdioma.GetTexto("Main_TTMinimizar"));
            ToolTipMain.SetToolTip(this.MBtnMaximizarMain, ControladorIdioma.GetTexto("Main_TTMaximizar"));
            ToolTipMain.SetToolTip(this.MBtnRestaurarMain, ControladorIdioma.GetTexto("Main_TTRestaurar"));
            ToolTipMain.SetToolTip(this.MBtnCerrarMain, ControladorIdioma.GetTexto("Main_TTCerrar"));
            LblBuscarPorMBI.Text = ControladorIdioma.GetTexto("BuscarPor");
            LblPaginasEntre.Text = ControladorIdioma.GetTexto("Main_PagEntre");
            KpDetalles.Text = ControladorIdioma.GetTexto("Main_DetallesGenerales");
            LblSinopsis.Text = ControladorIdioma.GetTexto("Main_Sinopsis");
            LblEditorial.Text = ControladorIdioma.GetTexto("Main_Editorial");
            LblIs10.Text = ControladorIdioma.GetTexto("Main_is10");
            LblIs13.Text = ControladorIdioma.GetTexto("Main_is13");
            LblCapitulos.Text = ControladorIdioma.GetTexto("Main_Capi");
            LblPag.Text = ControladorIdioma.GetTexto("Main_Pag");
            LblGenero.Text = ControladorIdioma.GetTexto("Main_Gen");
            LblEtiquetas.Text = ControladorIdioma.GetTexto("Main_Eti");
            LblIdioma.Text = ControladorIdioma.GetTexto("Main_Idioma");
            LblIdiOri.Text = ControladorIdioma.GetTexto("Main_IdiOri");
            LblTipoLibro.Text = ControladorIdioma.GetTexto("Main_TipoLibro");
            LblPublicado.Text = ControladorIdioma.GetTexto("Main_Publicado");
            LinkEnlace.Text = ControladorIdioma.GetTexto("Main_Enlace");
            MBtnAdminUsuarios.Text = ControladorIdioma.GetTexto("Adm_Administrar");
            ToolTipMain.SetToolTip(this.MBtnAdminUsuarios, ControladorIdioma.GetTexto("Adm_Administrar"));

            KpUsuario.Text = ControladorIdioma.GetTexto("Main_DetallesUsuario");
            LblPuntuacion.Text = ControladorIdioma.GetTexto("Main_Punt");
            LblVecesLeido.Text = ControladorIdioma.GetTexto("Main_VecesLeido");
            LblEstadoLectura.Text = ControladorIdioma.GetTexto("Main_EstadoLec");
            LblTiempoLec.Text = ControladorIdioma.GetTexto("Main_TiempoLec");
            LblCapAct.Text = ControladorIdioma.GetTexto("Main_CapAct");
            LblComienzo.Text = ControladorIdioma.GetTexto("Main_Comienzo");
            LblFin.Text = ControladorIdioma.GetTexto("Main_Fin");
            LblFavorito.Text = ControladorIdioma.GetTexto("Main_Fav");
            LblOculto.Text = ControladorIdioma.GetTexto("Main_Ocu");
            LblComentario.Text = ControladorIdioma.GetTexto("Main_Com");
            KCmbBuscarPorMBI.Items.Clear();
            //Agregar filtros de libro
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGTitulo"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGSubtitulo"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Isbn"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGTituAlt"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGIdioma"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGIdiOri"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGTipo"));
            //KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Favoritos"));
            KCmbBuscarPorMBI.Items.Add(ControladorIdioma.GetTexto("Al_DGPag"));
            KCmbBuscarPorMBI.SelectedIndex = 0;
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
                botonActual.ForeColor = Color.FromArgb(4, 5, 100);
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.FromArgb(4, 5, 100);
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
            if (toolSeleccionado!=null)
            {
                toolSeleccionado.ForeColor = Color.FromArgb(4, 5, 100);
                toolSeleccionado.IconColor = Color.FromArgb(4, 5, 100);
            }
        }
        
        //Estructura colores
        private struct Colores
        {
            public static Color colorBiblioteca = Color.Red;
            public static Color colorSubmenu = Color.DarkOrange;
            public static Color colorBuscar = Color.Magenta;
            public static Color colorConfi = Color.SaddleBrown;
            public static Color colorAdmin = Color.DarkViolet;
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
            //this.DoubleBuffered = true;
            PanHijos.Controls.Add(fhijo);
            PanHijos.Tag = fhijo;
            fhijo.BringToFront();
            fhijo.Show();

        }
        #endregion
        #region Botones menu lateral
        private void MBtnMiBiblioteca_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            //AbrirFormularios(new FrmMiBiblioteca());
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = false;
            titulos = SacarListaLibro();
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_MiBiblioteca");
            MPcbTituloFrm.IconChar = MaterialIcons.BookOpenPageVariant;
            BotonActivo(sender, Colores.colorBiblioteca);
            MBtncerrarDetallesLibro_Click(sender, e);
            RecolocarLibros(false);
        }
        private void MBtnAutores_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            //AbrirFormularios(new FrmMisAutores());
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = true;
            MBtncerrarDetallesLibro_Click(sender, e);
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_TTAutores");
            MPcbTituloFrm.IconChar = MaterialIcons.AccountGroup;

            //Añadir autores a la listview
            LsvOpciones.Items.Clear();
            LsvOpciones.Columns.Clear();
            ImageList imglist = new ImageList();
            imglist.ColorDepth = ColorDepth.Depth32Bit;
            imglist.ImageSize = new Size(50, 70);

            LsvOpciones.SmallImageList = imglist;
            var col = LsvOpciones.Columns.Add(ControladorIdioma.GetTexto("Se_LsvNombre"));
            col.Width = 200;
            foreach (Autor autor in Biblioteca.biblioteca.ListaAutor)
            {
                if (!String.IsNullOrWhiteSpace(autor.Imagen))
                    imglist.Images.Add("image",
                        Image.FromFile(autor.Imagen));
                else
                    imglist.Images.Add("image",
                        Properties.Resources.silueta);

                var i = LsvOpciones.Items.Add(autor.Nombre, imglist.Images.Count-1);
                i.Tag = autor;
            }
            if (LsvOpciones.Items.Count > 0) 
                LsvOpciones.Items[0].Selected = true;

            BotonActivo(sender, Colores.colorSubmenu);
        }
     
        private void MBtnGeneros_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = true;
            MBtncerrarDetallesLibro_Click(sender, e);
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_TTGeneros");
            MPcbTituloFrm.IconChar = MaterialIcons.DramaMasks;

            //Añadir generos a la listview
            LsvOpciones.Items.Clear();
            LsvOpciones.Columns.Clear();
            LsvOpciones.SmallImageList = null;
            var col = LsvOpciones.Columns.Add("Nombre");
            col.Width = 200;
            foreach (Genero genero in Biblioteca.biblioteca.ListaGenero)
            {
                var i = LsvOpciones.Items.Add(genero.Nombre);
                i.Tag = genero;
            }
            if (LsvOpciones.Items.Count > 0)
                LsvOpciones.Items[0].Selected = true;

            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnSeries_Click(object sender, EventArgs e)
        {
            //PanFormHijos.BringToFront();
            //PanListViewsOpciones.Visible = true;
            //LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_TTAutores");
            //MPcbTituloFrm.IconChar = FontAwesome.Sharp.MaterialIcons.AccountGroup;
            //BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnEditoriales_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = true;
            MBtncerrarDetallesLibro_Click(sender, e);
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_TTEditoriales");
            MPcbTituloFrm.IconChar = MaterialIcons.BankOutline;

            //Añadir editoriales a la listview
            LsvOpciones.Items.Clear();
            LsvOpciones.Columns.Clear();
            ImageList imglist = new ImageList();
            imglist.ColorDepth = ColorDepth.Depth32Bit;
            imglist.ImageSize = new Size(50, 70);
            LsvOpciones.SmallImageList = imglist;

            var col = LsvOpciones.Columns.Add("Nombre");
            col.Width = 200;

            foreach (Editorial editorial in Biblioteca.biblioteca.ListaEditorial)
            {
                if (!String.IsNullOrWhiteSpace(editorial.Imagen))
                    imglist.Images.Add("image",
                        Image.FromFile(editorial.Imagen));
                else
                    imglist.Images.Add("image",
                        Properties.Resources.libros);

                var i = LsvOpciones.Items.Add(editorial.Nombre, imglist.Images.Count - 1);
                i.Tag = editorial;
            }
            if (LsvOpciones.Items.Count > 0)
                LsvOpciones.Items[0].Selected = true;

            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnTags_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = true;
            MBtncerrarDetallesLibro_Click(sender, e);
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_TTTags");
            MPcbTituloFrm.IconChar = MaterialIcons.TagMultiple;
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnFavoritos_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            PanFormHijos.BringToFront();
            PanListViewsOpciones.Visible = false;
            MBtncerrarDetallesLibro_Click(sender, e);
            titulos = SacarListaLibro();
            titulos = titulos.FindAll(p => p.Favorito);
            RecolocarLibros(false);
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Main_Favoritos");
            MPcbTituloFrm.IconChar = MaterialIcons.StarCircle;
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
        private void MBtnAdminUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmAdministrarUsuarios());
            BotonActivo(sender, Colores.colorAdmin);
        }

        #endregion
        #region botones tool
        private void ToolStripMain_Paint(object sender, PaintEventArgs e)
        {
            MaterialSplitButton btn = (MaterialSplitButton)sender;
            ControlPaint.DrawBorder(
                       e.Graphics,
                       new Rectangle(0, 0, btn.Width, btn.Height),
                        //btn.ContentRectangle,
                       Color.Red,
                       ButtonBorderStyle.Solid);
        }
        private void BtnAniadirLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            Libro nuevoLibro = new Libro(ControladorIdioma.GetTexto("NuevoLibro"));
            FrmLibros al = new FrmLibros(nuevoLibro);
            al.FormBorderStyle=FormBorderStyle.None;
            al.Text = ControladorIdioma.GetTexto("Al_Titulo");
            al.ShowDialog();

            //Comprobar si el libro se ha aceptado o no para guardarlo
            if (al.EsOk)
                Biblioteca.biblioteca.ListaLibro.Add(nuevoLibro);

            //BotonActivoTool(sender,Colores.colorBiblioteca);
            RecolocarLibros(false);
        }
        private void BtnModificarLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmLibros al = new FrmLibros(libroActual);
            al.FormBorderStyle = FormBorderStyle.None;
            al.Text = ControladorIdioma.GetTexto("Al_Modificar");
            al.ShowDialog();
            MBtncerrarDetallesLibro_Click(sender, e);
            //BotonActivoTool(sender, Colores.colorBiblioteca);
            RecolocarLibros(false);
        }
        private void BtnBorrarLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            //BotonActivoTool(sender,Colores.colorBiblioteca);
            if (VentanaWindowsComun.MensajeBorrarObjeto(libroActual.Titulo) == DialogResult.Yes)
            {
                Biblioteca.biblioteca.ListaLibro.Remove(libroActual);
                RecolocarLibros(false);
                MBtncerrarDetallesLibro_Click(sender,e);
            }
        }
        private void BtnAniadirLibroMsb_Paint(object sender, PaintEventArgs e)
        {
            MaterialSplitButton btn = (MaterialSplitButton)sender;
            ControlPaint.DrawBorder(
                       e.Graphics,
                       new Rectangle(0, 0, btn.Width, btn.Height),
                       //  btn.ContentRectangle,
                       Color.Transparent,
                       ButtonBorderStyle.Outset);
        }
        private void BtnAutoresMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmAutores autores = new FrmAutores(false);
            autores.FormBorderStyle = FormBorderStyle.None;
            autores.ShowDialog();
            MBtnAutores_Click(MBtnAutores, null);
            //BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnGenerosMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmGeneros generos = new FrmGeneros(false);
            generos.FormBorderStyle = FormBorderStyle.None;
            generos.ShowDialog();
            MBtnGeneros_Click(MBtnGeneros, null);
            //BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnSeriesMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmSeries series = new FrmSeries(false);
            series.FormBorderStyle = FormBorderStyle.None;
            series.ShowDialog();
            MBtnSeries_Click(MBtnSeries, null);
            // BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnEditorialesMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmEditoriales editoriales = new FrmEditoriales(false);
            editoriales.FormBorderStyle = FormBorderStyle.None;
            editoriales.ShowDialog();
            MBtnEditoriales_Click(MBtnEditoriales, null);
            //BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnTagsMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmTags tags = new FrmTags(false);
            tags.FormBorderStyle = FormBorderStyle.None;
            tags.ShowDialog();
            MBtnTags_Click(MBtnTags, null);
            //BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        #endregion
        #region panel busqueda

        private void KCmbBuscarPorMBI_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (KCmbBuscarPorMBI.SelectedIndex)
            {
                case 7:
                    //Buscar por número de páginas
                    PanNumPaginas.Visible = true;
                    MBtnBuscarMBI.Visible = true;
                    KTxtBuscarMBI.Visible = false;
                    break;
                default:
                    MostrarCajaBusqueda(0);
                    break;
            }
        }

        private void MostrarCajaBusqueda(int tipo)
        {
            KTxtBuscarMBI.Text = "";
            PanNumPaginas.Visible = false;
            switch (tipo)
            {
                case 0:
                    //Busqueda por texto
                    KTxtBuscarMBI.Visible = true;
                    MBtnBuscarMBI.Visible = true;
                    break;
            }
        }

        private void MBtnBuscarMBI_Click(object sender, EventArgs e)
        {
            //Filtrar por categoría si se está usando, si no por la lista completa
            if (PanListViewsOpciones.Visible == true)
                LsvOpciones_ItemSelectionChanged(null, null);
            else
                titulos = SacarListaLibro();
         
                if (KCmbBuscarPorMBI.Items[0] == KCmbBuscarPorMBI.SelectedItem)
                {
                //Buscar por título
                    titulos = titulos
                    .FindAll(p => p.Titulo.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1);
                
                 }
                else if (KCmbBuscarPorMBI.Items[1] == KCmbBuscarPorMBI.SelectedItem)
                {
                    //Buscar por subtítulo
                    titulos = titulos
                        .FindAll(p => p.Subtitulo != null ? 
                        p.Subtitulo.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false);
                }
                else if (KCmbBuscarPorMBI.Items[2] == KCmbBuscarPorMBI.SelectedItem)
                {
                    //Buscar por ISBN
                    List<Libro> l;
                    l = titulos
                        .FindAll(p => p.Isbn_10 != null ?
                        p.Isbn_10.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false);
                    l.AddRange(titulos
                        .FindAll(p => p.Isbn_13 != null && !l.Contains(p) ?
                        p.Isbn_13.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false));
                    titulos = l;
                }
                else if (KCmbBuscarPorMBI.Items[3] == KCmbBuscarPorMBI.SelectedItem)
                {
                    //Buscar por título alternativo
                    titulos = titulos
                        .FindAll(p => p.TituloAlternativo != null ?
                        p.TituloAlternativo.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false);
                }
                else if (KCmbBuscarPorMBI.Items[4] == KCmbBuscarPorMBI.SelectedItem)
                {
                    //Buscar por idioma
                    titulos = titulos
                        .FindAll(p => p.Idioma != null ?
                        p.Idioma.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false);
                }
                else if (KCmbBuscarPorMBI.Items[5] == KCmbBuscarPorMBI.SelectedItem)
                {
                    //Buscar por idioma original
                    titulos = titulos
                        .FindAll(p => p.IdiomaOriginal != null ?
                        p.IdiomaOriginal.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false);
                }
                else if (KCmbBuscarPorMBI.Items[6] == KCmbBuscarPorMBI.SelectedItem)
                {
                    //Buscar por tipo de libro
                    titulos = titulos
                        .FindAll(p => p.NombreTipo != null ?
                        p.NombreTipo.IndexOf(KTxtBuscarMBI.Text, StringComparison.OrdinalIgnoreCase) > -1
                        : false);
                }
              
            else if (KCmbBuscarPorMBI.Items[7] == KCmbBuscarPorMBI.SelectedItem)
            {
                //Buscar por número de páginas
                titulos=titulos.FindAll(p => p.NumeroPaginas >= KNudPagMin.Value 
                && p.NumeroPaginas <= KNudPagMax.Value);    
            }   
            //if (KTxtBuscarMBI.Visible && !String.IsNullOrWhiteSpace(KTxtBuscarMBI.Text))
            //{
            //    titulos = SacarListaLibro();
            //}
            RecolocarLibros(false);
        }
        private void KTxtBuscarMBI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MBtnBuscarMBI_Click(sender,e);
            }
        }
        private void MbtnBorrarTxtBuscar_Click(object sender, EventArgs e)
        {
            KTxtBuscarMBI.Text = "";
            MBtnBuscarMBI_Click(sender, e);
        }
       
       

        private void MBtnOrdenMBI_Click(object sender, EventArgs e)
        {
            titulos = new List<Libro>(titulos);
            titulos.Reverse();
            RecolocarLibros(true);
        }

        #endregion
        #region listview
        private void LsvOpciones_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (LsvOpciones.SelectedItems.Count == 1)
            {
                titulos = SacarListaLibro();
                object obj = LsvOpciones.SelectedItems[0].Tag;
                if (obj.GetType() == typeof(Autor))
                    titulos = titulos.FindAll(p => p.ListaAutor.Contains((Autor)obj));
                else if (obj.GetType() == typeof(Genero))
                    titulos = titulos.FindAll(p => p.ListaGenero.Contains((Genero)obj));
                else if (obj.GetType() == typeof(Editorial))
                    titulos = titulos.FindAll(p => p.ListaEditorial.Contains((Editorial)obj));

                //truco para que no pinte al usar la busqueda con las categorias
                if (sender != null)
                    RecolocarLibros(false);
            }
        }
        private void LsvOpciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Al hacer doble click en un elemento del listview
            ListViewHitTestInfo info = LsvOpciones.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                object obj = LsvOpciones.SelectedItems[0].Tag;
                if (obj.GetType() == typeof(Autor))
                {
                    FrmAutores au = new FrmAutores(false, (Autor)item.Tag);
                    au.FormBorderStyle = FormBorderStyle.None;
                    au.ShowDialog();
                    MBtnAutores_Click(MBtnAutores, null);
                }
                else if (obj.GetType() == typeof(Genero))
                {
                    FrmGeneros ge = new FrmGeneros(false, (Genero)item.Tag);
                    ge.FormBorderStyle = FormBorderStyle.None;
                    ge.ShowDialog();
                    MBtnGeneros_Click(MBtnGeneros, null);
                }
                else if (obj.GetType() == typeof(Editorial))
                {
                    FrmEditoriales ed = new FrmEditoriales(false, (Editorial)item.Tag);
                    ed.FormBorderStyle = FormBorderStyle.None;
                    ed.ShowDialog();
                    MBtnEditoriales_Click(MBtnEditoriales, null);
                }
            }
        }
        #endregion
        #region Botones minimizar, maximizar, restaurar, redimensionar y salir
        //Para saber el tamaño y la posicion inicial de la pantalla y poder restaurarla en
        //el centro de la pantalla
        private int lx, ly;
        private int sw, sh;
        private void MBtnRestaurar_Click(object sender, EventArgs e)
        {
            MBtnMaximizarMain.Visible = true;
            MBtnRestaurarMain.Visible = false;
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            //FormResize();
            RecolocarLibros(false);
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
            //FormResize();
            RecolocarLibros(false);
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
            Biblioteca.biblioteca.GuardarJson(); 
        }
        private void CerrarFormulario()
        {
            string mensaje = ControladorIdioma.GetTexto("ShowDialogCerrar");

            DialogResult boton = VentanaWindowsComun.MensajeSalir(mensaje);

            if (boton == DialogResult.Yes)
                Application.Exit();
        }
        private void MBtnCerrarMain_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
           
        }
        private void MBtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
            
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
