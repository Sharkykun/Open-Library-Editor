using Google.Apis.Books.v1.Data;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.Controles;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenLibraryEditor.DatosLibros.Libro;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmBuscar : Form
    {
        /*TODO:
        - Añadir creación de paneles, uno por cada resultado de la busqueda.
        El doble click hará una pregunta al usuario de si quieres añadir ese libro a su lista de libro actual.
        - Crear llamadas a busqueda SQL para las BDs de este programa
        - Añadir más criterios de busqueda para Google Books (Autor, género).
        - OPCIONAL: Añadir recomendaciones en base a lo que predomina en tu lista local.
        La lista sería creada con una busqueda a la BD/API elegida en el Combo.
         */

        private const string NOMBRE_GOOGLE = "Google Books";
        private int contadorLibros = 0;
        private List<Libro> titulos;
        private ArrayList autores = new ArrayList();

        public FrmBuscar()
        {
            InitializeComponent();
            titulos = SacarListaLibro();
        }
        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            KCmbServidoresBUS.Items.Add(NOMBRE_GOOGLE);
            UsuarioDatos.configuracionUsuario.ListaInfoBD.ForEach(p => KCmbServidoresBUS.Items.Add(p));
            KCmbServidoresBUS.SelectedIndex = 0;
            IdiomaTexto();
            AniadirAutores();
            ColocarLibrosRecomendados();

            //ponerLibrosRecomendados();
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
        private void IdiomaTexto()
        {
            LblTituloBuscar.Text = ControladorIdioma.GetTexto("Main_Buscar");
            LblBuscarPorBUS.Text = ControladorIdioma.GetTexto("Bus_BuscarEn");
            LblRecomendaciones.Text= ControladorIdioma.GetTexto("Bus_Recomendaciones");
            TTBuscar.SetToolTip(this.PanRecomendaciones, ControladorIdioma.GetTexto("Bus_TTDobleClick"));
            TTBuscar.SetToolTip(this.LsvBuscarLibros, ControladorIdioma.GetTexto("Bus_TTDobleClick"));


        }
        private string QueryGoogle()
        {
            string query = "";
            switch (KCmbTipoBusquedaBUS.SelectedIndex)
            {
                case 0:
                    query = KTxtBuscarBUS.Text;
                    break;
                case 1:
                    query = "inauthor:\"" + KTxtBuscarBUS.Text + "\"";
                    break;
                case 2:
                    query = "inpublisher:" + KTxtBuscarBUS.Text;
                    break;
                case 3:
                    query = "subject:\"" + KTxtBuscarBUS.Text + "\"";
                    break;
            }
            
            return query;
        }

      

        private void MBtnBuscarBUS_Click(object sender, EventArgs e)
        {
            string query;
            switch (KCmbServidoresBUS.SelectedItem)
            {
                case NOMBRE_GOOGLE:
                    query = QueryGoogle();
                    ImageList imglist = new ImageList();
                    LsvBuscarLibros.Items.Clear();
                    //Iniciar API
                    GoogleBooksController gBooks = new GoogleBooksController("OpenLibraryEditor",
                        UsuarioDatos.configuracionUsuario.GoogleBooksApiKey);
                    //Realizar Query
                    gBooks.SearchBook(query, 10, UsuarioDatos.configuracionUsuario.ContenidoExplicito);
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
                                    new PictureBox().ErrorImage);
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
                    break;
                default:
                    //Lanzar sentencia SQL adecuada según el Combo de tipo
                    break;
            }


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
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("Etiqueta"));
                    KCmbTipoBusquedaBUS.Items.Add(ControladorIdioma.GetTexto("RS_Serie"));
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
           
            int x = 5;
            int y = 5;
            string query = "";
            for (int i = 0; i < autores.Count; i++)
            {
                query = "inauthor:\"" + autores[i] + "\"";
                DoubleClickButton dcb = new DoubleClickButton();
                dcb.Size = new Size(105,135);
                dcb.Location = new Point(x, y);
                dcb.BackgroundImageLayout = ImageLayout.Stretch;
                ImageList imglist = new ImageList();
                GoogleBooksController gBooks = new GoogleBooksController("OpenLibraryEditor",
                       UsuarioDatos.configuracionUsuario.GoogleBooksApiKey);
                //Realizar Query
                gBooks.SearchBook(query, 1, UsuarioDatos.configuracionUsuario.ContenidoExplicito);
                //Listar libros
                if (gBooks.BookCollection != null)
                {
                    foreach (var libro in gBooks.BookCollection.Items)
                    {
                        var info = libro.VolumeInfo;
                        if (info.ImageLinks != null) { 
                            imglist.Images.Add("image",GoogleBooksController.SaveImageFromURL(info.ImageLinks.Thumbnail));
                            dcb.BackgroundImage = (GoogleBooksController.SaveImageFromURL(info.ImageLinks.Thumbnail));
                            dcb.ImageList = imglist;
                        }
                        dcb.Tag = libro;
                    }
                }
                PanLibrosBuscar.Controls.Add(dcb);
                dcb.Visible = true;
                dcb.DoubleClick += new EventHandler(DobleClickLibro);
                x = x + 115;
            }
            
        }
        private void DobleClickLibro(object sender, EventArgs e)
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
            int posicion = PanLibrosBuscar.Controls[PanLibrosBuscar.Controls.Count - 19].Location.X;
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
        //private void ponerLibrosRecomendados()
        //{
        //    int contador = 0;

        //    foreach (PictureBox pc in PanLibrosBuscar.Controls)
        //    {
        //        pc.BorderStyle = BorderStyle.FixedSingle;
        //        pc.Image = Image.FromFile(titulos[contador].ImagenPortada);
        //        contador++;
        //    }
        //}
    }
}
