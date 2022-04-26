using OpenLibraryEditor.Clases;
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

        public FrmBuscar()
        {
            InitializeComponent();
        }
        private void IdiomaTexto()
        {
            LblTituloBuscar.Text = ControladorIdioma.GetTexto("Main_Buscar");
            LblBuscarPorBUS.Text = ControladorIdioma.GetTexto("Bus_BuscarEn");
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
                    query = "inauthor:\""+KTxtBuscarBUS.Text+"\"";
                    break;
                case 2:
                    query = "subject:\"" + KTxtBuscarBUS.Text + "\"";
                    break;
                case 3:
                    query = "inpublisher:\"" + KTxtBuscarBUS.Text + "\"";
                    break;
            }
            return query;
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            KCmbServidoresBUS.Items.Add(NOMBRE_GOOGLE);
            UsuarioDatos.configuracionUsuario.ListaInfoBD.ForEach(p => KCmbServidoresBUS.Items.Add(p));
            KCmbServidoresBUS.SelectedIndex = 0;
            IdiomaTexto();
        }

        private void MBtnBuscarBUS_Click(object sender, EventArgs e)
        {
            string query;
            switch (KCmbServidoresBUS.SelectedItem)
            {
                case NOMBRE_GOOGLE:
                    query = QueryGoogle();
                    //Iniciar API
                    GoogleBooksController gBooks = new GoogleBooksController("OpenLibraryEditor",
                        UsuarioDatos.configuracionUsuario.GoogleBooksApiKey);
                    //Realizar Query
                    gBooks.SearchBook(query,40,UsuarioDatos.configuracionUsuario.ContenidoExplicito);
                    //Listar libros
                    _ = gBooks.BookCollection;
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
    }
}
