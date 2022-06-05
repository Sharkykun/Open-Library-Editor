using Google.Apis.Books.v1.Data;
using MySql.Data.MySqlClient;
using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.Controles;
using OpenLibraryEditor.DatosLibros;
using OpenLibraryEditor.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static OpenLibraryEditor.DatosLibros.Libro;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmBuscar : Form
    {
        /*TODO:
        - Al añadir libro, generar autores y otras cosas en la BD. Creo que no lo hice.
        - La primera imagen no carga en el listview, pero se descargan bien al añadir el libro.
         */

        private const string NOMBRE_GOOGLE = "Google Books";
        private int contadorLibros = 0;
        private ArrayList autores = new ArrayList();
        private bool puedeEditar;

        public FrmBuscar()
        {
            InitializeComponent();
            Thread th = new Thread(() => ColocarLibrosRecomendados());
            th.Start();
        }
        public FrmBuscar(bool puedeEditar)
        {
            InitializeComponent();
            this.puedeEditar = puedeEditar;
            Thread th = new Thread(() => ColocarLibrosRecomendados());
            th.Start();
        }
        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            KCmbServidoresBUS.Items.Add(NOMBRE_GOOGLE);
            if(UsuarioDatos.configuracionUsuario.BDActual != null)
                KCmbServidoresBUS.Items.Add(UsuarioDatos.configuracionUsuario.BDActual);
            UsuarioDatos.configuracionUsuario.ListaInfoBD.ForEach(p => KCmbServidoresBUS.Items.Add(p));
            KCmbServidoresBUS.SelectedIndex = 0;
            IdiomaTexto();

            MbtnAtrasLibro.Enabled = false;
            MBtnAvanzarLibro.Enabled = false;
           
            TxtBusqueda.MbtnBorrar().Click += new EventHandler(MbtnBorrarTxtBuscar_Click);
            TxtBusqueda.TxtBuscar().KeyDown += KTxtBuscarBUS_KeyDown;

            if (puedeEditar)
            {
                LblTipoUsuarioConectado.Visible = true;
                if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Administrador"))
                {
                    LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Adm");
                }
                else if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Usuario"))
                {
                    LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Usu");
                }
                else if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Editor"))
                {
                    LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Editor");
                }
            }
            else
            {
                LblTipoUsuarioConectado.Text= ControladorIdioma.GetTexto("ModoSinConexion");
            }     
        }

        public bool PingAGoogle()
        {
            try
            {
                Uri host = new Uri("http://www.google.es/");
                Ping p = new Ping();
                PingReply respuesta = p.Send(host.Host, 3000);
                if (respuesta.Status == IPStatus.Success)
                    return true;
            }
            catch (Exception) { }
            return false;
        }

        private void IdiomaTexto()
        {
            LblTituloBuscar.Text = ControladorIdioma.GetTexto("Main_Buscar");
            LblBuscarPorBUS.Text = ControladorIdioma.GetTexto("Bus_BuscarEn");
            LblRecomendaciones.Text= ControladorIdioma.GetTexto("Bus_Recomendaciones");
            TTBuscar.SetToolTip(this.PanRecomendaciones, ControladorIdioma.GetTexto("Bus_TTDobleClick"));
            TTBuscar.SetToolTip(this.LsvBuscarLibros, ControladorIdioma.GetTexto("Bus_TTDobleClick"));
            TTBuscar.SetToolTip(this.KCmbServidoresBUS, ControladorIdioma.GetTexto("Bus_BusquedaEn"));
            TTBuscar.SetToolTip(this.KCmbTipoBusquedaBUS, ControladorIdioma.GetTexto("BusquedaPor"));
            TTBuscar.SetToolTip(this.TxtBusqueda, ControladorIdioma.GetTexto("TextoBuscar"));
            TTBuscar.SetToolTip(this.MBtnBuscarBUS, ControladorIdioma.GetTexto("LupaBuscar"));
            TTBuscar.SetToolTip(this.MbtnAtrasLibro, ControladorIdioma.GetTexto("VerMasLibros"));
            TTBuscar.SetToolTip(this.MBtnAvanzarLibro, ControladorIdioma.GetTexto("VerMasLibros"));
        }
        private string QueryGoogle()
        {
            string query = "";
            switch (KCmbTipoBusquedaBUS.SelectedIndex)
            {
                case 0:
                    query = TxtBusqueda.getTextobuscar();
                    break;
                case 1:
                    query = "inauthor:\"" + TxtBusqueda.getTextobuscar() + "\"";
                    break;
                case 2:
                    query = "inpublisher:" + TxtBusqueda.getTextobuscar();
                    break;
                case 3:
                    query = "subject:\"" + TxtBusqueda.getTextobuscar() + "\"";
                    break;
            }
            
            return query;
        }


        private void MbtnBorrarTxtBuscar_Click(object sender, EventArgs e)
        {
            //KTxtBuscarMBI.Text = "";
            TxtBusqueda.setTextobuscar("");
            MBtnBuscarBUS_Click(sender, e);
        }


        private void MBtnBuscarBUS_Click(object sender, EventArgs e)
        {
            if (PingAGoogle())
            {
                string query;
                ImageList imglist = new ImageList();
                LsvBuscarLibros.Items.Clear();

                try
                {
                    switch (KCmbServidoresBUS.SelectedItem)
                    {
                        case NOMBRE_GOOGLE:
                            query = QueryGoogle();
                            //Iniciar API
                            GoogleBooksController gBooks = new GoogleBooksController("OpenLibraryEditor",
                                UsuarioDatos.configuracionUsuario.GoogleBooksApiKey);
                            //Realizar Query
                            if (gBooks.SearchBook(query, 10, UsuarioDatos.configuracionUsuario.ContenidoExplicito))
                            {
                                //Listar libros
                                if (gBooks.BookCollection != null)
                                {
                                    foreach (var libro in gBooks.BookCollection.Items)
                                    {
                                        var info = libro.VolumeInfo;
                                        if (info.ImageLinks != null)
                                            imglist.Images.Add("image",
                                                GoogleBooksController.SaveImageFromURL(info.ImageLinks.Thumbnail));
                                        else
                                            imglist.Images.Add("image",
                                                Resources.portada);
                                        imglist.ColorDepth = ColorDepth.Depth32Bit;
                                        imglist.ImageSize = new Size(150, 200);

                                        LsvBuscarLibros.SmallImageList = imglist;
                                        LsvBuscarLibros.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.None);
                                        ListViewItem lvi =
                                            LsvBuscarLibros.Items.Add(info.Title + "\n" +
                                            info.PublishedDate + "\n" + info.Description,
                                            imglist.Images.Count - 1);
                                        lvi.Tag = libro;

                                    }
                                }
                            }
                            else
                                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorGoogleBooks"));
                            break;
                        default:
                            if (KCmbServidoresBUS.SelectedItem != null)
                            {
                                //Lanzar sentencia SQL adecuada según el Combo de tipo
                                //Respaldar conexión actual
                                MySqlConnection conexionCopia = ConexionBD.Conexion;

                                //Establecer conexión en anonimo a la BD compartida elegida
                                InfoBaseDatos bdInfo = (InfoBaseDatos)KCmbServidoresBUS.SelectedItem;
                                ConexionBD.EstablecerConexion(bdInfo.ServidorIP, "ole_anon", "", bdInfo.Puerto.ToString());

                                //Conectarse y sacar libros según el criterio de busqueda
                                List<Libro> listaLibro = new List<Libro>();
                                if (ConexionBD.AbrirConexion())
                                {
                                    switch (KCmbTipoBusquedaBUS.SelectedIndex)
                                    {
                                        case 0:
                                            listaLibro = LecturaBD.SelectBuscarLibro(
                                                "titulo", TxtBusqueda.getTextobuscar(), UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                            break;
                                        case 1:
                                            listaLibro = LecturaBD.SelectBuscarLibro(
                                                "isbn13", TxtBusqueda.getTextobuscar(), UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                            break;
                                        case 2:
                                            listaLibro = LecturaBD.SelectBuscarElementoPorNombre(TxtBusqueda.getTextobuscar(), "Autor",
                                                "idAutor", "nombreAutor",
                                                UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                            break;
                                        case 3:
                                            listaLibro = LecturaBD.SelectBuscarElementoPorNombre(
                                                TxtBusqueda.getTextobuscar(), "Editorial", "idEditorial", "nombreEditorial",
                                                UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                            break;
                                        case 4:
                                            listaLibro = LecturaBD.SelectBuscarElementoPorNombre(
                                                TxtBusqueda.getTextobuscar(), "Genero", "idGenero", "nombreGenero",
                                                UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                            break;
                                    }

                                    //Recorremos lista para meter en Listview
                                    LsvBuscarLibros.SmallImageList = imglist;
                                    LsvBuscarLibros.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.None);
                                    imglist.ColorDepth = ColorDepth.Depth32Bit;
                                    imglist.ImageSize = new Size(150, 200);
                                    foreach (Libro libro in listaLibro)
                                    {
                                        if (libro.PortadaTemp != null)
                                            imglist.Images.Add("image",
                                                ControladorImagen.ObtenerImagenStream(libro.PortadaTemp));
                                        else
                                            imglist.Images.Add("image",
                                                new Bitmap(Resources.portada));

                                        ListViewItem lvi =
                                            LsvBuscarLibros.Items.Add(libro.Titulo + "\n" +
                                            libro.FechaPublicacion.Date.ToShortDateString()
                                            + "\n" + libro.Sinopsis, imglist.Images.Count - 1);
                                        lvi.Tag = libro;
                                    }

                                    ConexionBD.CerrarConexion();
                                }

                                //Recuperar conexión con nuestra BD
                                ConexionBD.Conexion = conexionCopia;
                            }
                            break;
                    }
                }
                catch (HttpRequestException)
                {
                    //-------------
                    VentanaWindowsComun.MensajeError("Se ha interrumpido la conexión con el servidor.\nCompruebe si tiene conexión a internet.");
                }
            }
            else
                //--------------
                VentanaWindowsComun.MensajeError("No se ha podido establecer la conexión con el servidor.\nCompruebe si tiene conexión a internet.");
        }

        private void KCmbServidoresBUS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Buscar por nombre, y en default, buscar por objeto InfoBaseDatos almacenado en SelectedItem
            //Se añaden posibles formas de búsqueda de acuerdo a las query posibles.
            KCmbTipoBusquedaBUS.Items.Clear();
            switch (KCmbServidoresBUS.SelectedItem)
            {
                case NOMBRE_GOOGLE:
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_TituloIsbn"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_Autor"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_Editorial"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_Genero"));
                    break;
                default:
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("Al_DGTitulo"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("Isbn"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_Autor"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_Editorial"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("CmbBuscar_Genero"));
                    //KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("Etiqueta"));
                    //KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("RS_Serie"));
                    break;
            }
            KCmbTipoBusquedaBUS.SelectedIndex = 0;
        }

        private void LsvSeriesNS_DoubleClick(object sender, EventArgs e)
        {
            switch (KCmbServidoresBUS.SelectedItem)
            {
                case NOMBRE_GOOGLE:
                    //Pregunta si añadir libro a la lista local,
                    //y convertir en caso afirmativo
                    if (VentanaWindowsComun.MensajeGuardarObjeto(ControladorIdioma.GetTexto("Bus_libro")) == DialogResult.Yes)
                    {
                        try
                        {
                            Biblioteca.biblioteca.ListaLibro.Add(GoogleBooksController.ParseBook((Volume)LsvBuscarLibros.SelectedItems[0].Tag,
                                UsuarioDatos.configuracionUsuario.DescargaDetallesLibro[0],
                                UsuarioDatos.configuracionUsuario.DescargaDetallesLibro[3],
                                UsuarioDatos.configuracionUsuario.DescargaDetallesLibro[1]));
                        }
                        catch (IdRepetidoException)
                        {
                            VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_LibroExiste"));
                        }
                    }
                    break;
                default:
                    //Pregunta si añadir libro a la lista local,
                    //y convertir en caso afirmativo
                    if (VentanaWindowsComun.MensajeGuardarObjeto(ControladorIdioma.GetTexto("Bus_libro")) == DialogResult.Yes)
                    {
                        try
                        {
                            Libro libro = (Libro)LsvBuscarLibros.SelectedItems[0].Tag;
                            libro.SetRandomId();
                            Biblioteca.biblioteca.ListaLibro.Add(libro);
                            libro.ImagenPortada = libro.PortadaTemp == null ? null :
                                ControladorImagen.RUTA_LIBRO + libro.IdLibro + "_c";
                            libro.ImagenContraportada = libro.ContraportadaTemp == null ? null :
                                ControladorImagen.RUTA_LIBRO + libro.IdLibro + "_b";
                            if (libro.ImagenPortada != null)
                            {
                                File.WriteAllBytes(libro.ImagenPortada, libro.PortadaTemp);
                            }
                            if (libro.ImagenContraportada != null)
                            {
                                File.WriteAllBytes(libro.ImagenPortada, libro.ContraportadaTemp);
                            }

                            //Recuperar listas
                            if (ConexionBD.AbrirConexion()) {
                                List<Autor> listaAutor = LecturaBD.SelectAutoresDesdeListaAutor(
                                        EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido));
                                foreach (Autor a in listaAutor)
                                {
                                    Autor autor = Biblioteca.biblioteca.ListaAutor.Find(p =>
                                        p.ListaIdCompartido.Contains(a.ListaIdCompartido[0]));
                                    if (autor != null)
                                    {
                                        //Existe en la biblioteca local, así que añadelo
                                        libro.ListaAutor.Add(autor);
                                    }
                                    else
                                    {
                                        //No existe en el local, añádelo como nuevo objeto.
                                        Biblioteca.biblioteca.ListaAutor.Add(a);
                                       libro.ListaAutor.Add(a);
                                    }
                                }

                                List<Genero> listaGenero = LecturaBD.SelectGenerosDesdeListaGenero(
                                        EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido));
                                foreach (Genero g in listaGenero)
                                {
                                    Genero genero = Biblioteca.biblioteca.ListaGenero.Find(p =>
                                        p.ListaIdCompartido.Contains(g.ListaIdCompartido[0]));
                                    if (genero != null)
                                    {
                                        //Existe en la biblioteca local, así que añadelo
                                        libro.ListaGenero.Add(genero);
                                    }
                                    else
                                    {
                                        //No existe en el local, añádelo como nuevo objeto.
                                        Biblioteca.biblioteca.ListaGenero.Add(g);
                                        libro.ListaGenero.Add(g);
                                    }
                                }

                                List<Editorial> listaEditorial = LecturaBD.SelectEditorialesDesdeListaEditorial(
                                        EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido));
                                foreach (Editorial ed in listaEditorial)
                                {
                                    Editorial editorial = Biblioteca.biblioteca.ListaEditorial.Find(p =>
                                        p.ListaIdCompartido.Contains(ed.ListaIdCompartido[0]));
                                    if (editorial != null)
                                    {
                                        //Existe en la biblioteca local, así que añadelo
                                        libro.ListaEditorial.Add(editorial);
                                    }
                                    else
                                    {
                                        //No existe en el local, añádelo como nuevo objeto.
                                        Biblioteca.biblioteca.ListaEditorial.Add(ed);
                                        libro.ListaEditorial.Add(ed);
                                    }

                                    
                                }
                                ConexionBD.CerrarConexion();
                            }
                        }
                        catch (IdRepetidoException)
                        {
                            VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_LibroExiste"));
                        }
                    }
                    break;
            }
        }
        private void AniadirAutores()
        {
            autores.Add("Stephen King");
            autores.Add("Isabel Allende");
            autores.Add("Ildefonso Falcones");
            autores.Add("J. R. R. Tolkien");
            autores.Add("Javier Marías");
            autores.Add("Carlos Ruiz Zafón");
            autores.Add("Arturo Pérez-Reverte");
            autores.Add("Miguel de Cervantes");
            autores.Add("Koyoharu Gotouge");
            autores.Add("George R. R. Martin");
            autores.Add("Brandon Sanderson");
            autores.Add("Hajime Isayama");
            autores.Add("Ken Follett");
            autores.Add("Camilla Läckberg");
            autores.Add("Akira Toriyama");
            autores.Add("Ken Wakui");
            autores.Add("Kohei Horikoshi");
            autores.Add("La Vecina Rubia");
            autores.Add("Julia Quinn");
            autores.Add("Geronimo Stilton");
        }
        private void ColocarLibrosRecomendados()
        {
            if (PingAGoogle())
            {
                GoogleBooksController gBooks = new GoogleBooksController("OpenLibraryEditor",
                           UsuarioDatos.configuracionUsuario.GoogleBooksApiKey);
                
                AniadirAutores();
                int x = 5;
                int y = 5;
                string query = "";
                for (int i = 0; i < autores.Count; i++)
                {
                    query = "inauthor:\"" + autores[i] + "\"";

                    ImageList imglist = new ImageList();
                    if (gBooks.SearchBook(query, 1, UsuarioDatos.configuracionUsuario.ContenidoExplicito))
                    {
                        //Listar libros
                        if (gBooks.BookCollection != null)
                        {
                            var libro = gBooks.BookCollection.Items[0];

                            var info = libro.VolumeInfo;
                            if (info.ImageLinks != null)
                            {
                                DoubleClickButton dcb = new DoubleClickButton();
                                dcb.Size = new Size(105, 135);
                                dcb.Location = new Point(x, y);
                                dcb.BackgroundImageLayout = ImageLayout.Stretch;
                                //imglist.Images.Add("image",GoogleBooksController.SaveImageFromURL(info.ImageLinks.Thumbnail));
                                dcb.BackgroundImage = (GoogleBooksController.SaveImageFromURL(info.ImageLinks.Thumbnail));
                                //dcb.ImageList = imglist;
                                dcb.Tag = libro;
                                try
                                {
                                    Invoke(new Action(() => PanLibrosBuscar.Controls.Add(dcb)));
                                    Invoke(new Action(() => dcb.Visible = true));
                                    Invoke(new Action(() => dcb.DoubleClick += new EventHandler(DobleClickLibro)));
                                    x = x + 115;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }
                    }
                }
                try
                {
                    if (PanLibrosBuscar.Controls.Count > 0)
                    {
                        Invoke(new Action(() => MbtnAtrasLibro.Enabled = true));
                        Invoke(new Action(() => MBtnAvanzarLibro.Enabled = true));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                //--------------
                VentanaWindowsComun.MensajeError("No se pudo realizar ping con el servidor.\nCompruebe si tiene conexión a internet.");
        }
        private static void DobleClickLibro(object sender, EventArgs e)
        {
            DoubleClickButton libroSeleccionado = (DoubleClickButton)sender;
            if (VentanaWindowsComun.MensajeGuardarObjeto(ControladorIdioma.GetTexto("Bus_libro")) == DialogResult.Yes)
            {
                try
                {
                    Biblioteca.biblioteca.ListaLibro.Add(GoogleBooksController.ParseBook((Volume)libroSeleccionado.Tag,
                                 UsuarioDatos.configuracionUsuario.DescargaDetallesLibro[0],
                                 UsuarioDatos.configuracionUsuario.DescargaDetallesLibro[3],
                                 UsuarioDatos.configuracionUsuario.DescargaDetallesLibro[1]));
                }
                catch (IdRepetidoException)
                {
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_LibroExiste"));
                }
            }
        }


        private void MbtnAtrasLibro_Click(object sender, EventArgs e)
        {
            int posicion = PanLibrosBuscar.Controls[0].Location.X;
            //Point posicion = new Point(110,5);
            if ((posicion + 70) < PanLibrosBuscar.Width && contadorLibros >= 1)
            {
                foreach (DoubleClickButton dcb in PanLibrosBuscar.Controls)
                {
                    int posX = dcb.Location.X;
                    dcb.Location = new Point((posX + 115), 5);
                }
                contadorLibros--;
            }
        }


        private void MBtnAvanzarLibro_Click(object sender, EventArgs e)
        {
            int posicion = PanLibrosBuscar.Controls[PanLibrosBuscar.Controls.Count - 1].Location.X;
            if ((posicion + 70) > PanLibrosBuscar.Width)
            {
                foreach (DoubleClickButton dcb in PanLibrosBuscar.Controls)
                {
                    int posX = dcb.Location.X;
                    dcb.Location = new Point((posX - 115), 5);
                }
                contadorLibros++;
            }
        }

        private void PanLibrosBuscar_SizeChanged(object sender, EventArgs e)
        {
            int posX = 5;
            foreach (DoubleClickButton dcb in PanLibrosBuscar.Controls)
            {
                dcb.Location = new Point(posX, 5);
                posX = posX + 115;
            }
            contadorLibros = 0;
        }

        private void KTxtBuscarBUS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MBtnBuscarBUS_Click(sender,e);
            }

        }

    }
}
