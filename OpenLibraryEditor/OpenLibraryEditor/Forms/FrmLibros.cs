
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.Controles;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic;
using ComponentFactory.Krypton.Navigator;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmLibros : Form
    {
        #region atributos
        private const string NOMBRE_OBJETO = "la acción";
        private Libro libroActual;
        private BindingSource tipoBinding = new BindingSource();

        //listas
        private List<string> listaTipoLibro = Biblioteca.biblioteca.ListaTipoLibro;
        private List<Editorial> listaEditorial = Biblioteca.biblioteca.ListaEditorial;
        private List<Genero> listaGenero = Biblioteca.biblioteca.ListaGenero;
        private List<Autor> listaPersona = Biblioteca.biblioteca.ListaAutor;
        private List<Serie> listaSerie = Biblioteca.biblioteca.ListaSerie;
        private List<Etiqueta> listaEtiqueta = Biblioteca.biblioteca.ListaEtiqueta;
        private List<Idioma> listaIdioma = Biblioteca.biblioteca.ListaIdioma;
        private List<UsuarioEjecutable> listaEjecutable = Biblioteca.biblioteca.ListaEjecutable;
        private List<UsuarioAccion> listaAccion = new List<UsuarioAccion>();
        private UsuarioAccion accionActual = new UsuarioAccion();
        private ListViewItem itemActual;
        private string rutaImagenPortada;
        private string rutaImagenContraportada;
        #endregion
        public FrmLibros(Libro libro)
        {
            InitializeComponent();
            libroActual = libro;
        }
        #region metodos propios

        private void IdiomaTexto()
        {
            TTnuevoLibro.SetToolTip(this.MBtnCerrarTitulos, ControladorIdioma.GetTexto("Cerrar"));
            TTnuevoLibro.SetToolTip(this.LblTituloForm, ControladorIdioma.GetTexto("Al_Titulo"));
            LblTituloForm.Text = ControladorIdioma.GetTexto("Al_Titulo");
            KpageDatosGenerales.Text = ControladorIdioma.GetTexto("Al_TabDatosGen");
            KgbDatosGeneralesNL.Values.Heading = ControladorIdioma.GetTexto("Al_TabDatosGen");
            LblTituloNL.Text = ControladorIdioma.GetTexto("Al_DGTitulo");
            TTnuevoLibro.SetToolTip(this.KTxtTituloNL, ControladorIdioma.GetTexto("Al_TTTxtTitulo"));
            LblSubtituloNL.Text = ControladorIdioma.GetTexto("Al_DGSubtitulo");
            TTnuevoLibro.SetToolTip(this.KTxtSubtituloNL, ControladorIdioma.GetTexto("Al_TTTxtSubti"));
            LblTituAlternativoNL.Text = ControladorIdioma.GetTexto("Al_DGTituAlt");
            TTnuevoLibro.SetToolTip(this.KTxtTituAlternativoNL, ControladorIdioma.GetTexto("Al_TTTxtTAlt"));
            LblEdicionNL.Text = ControladorIdioma.GetTexto("Al_DGEditorial");
            TTnuevoLibro.SetToolTip(this.KCCEditorialNL, ControladorIdioma.GetTexto("Al_TTCmbEdi"));
            TTnuevoLibro.SetToolTip(this.MBtnMasEditorialNL, ControladorIdioma.GetTexto("Al_TTBtnMasEdi"));
            LblEdicionNL.Text = ControladorIdioma.GetTexto("Al_DGEdicion");
            TTnuevoLibro.SetToolTip(this.KNudEdicionNL, ControladorIdioma.GetTexto("Al_TTEdicion"));
            LblVolumenNL.Text = ControladorIdioma.GetTexto("Al_DGVolumen");
            TTnuevoLibro.SetToolTip(this.KNudVolumenNL, ControladorIdioma.GetTexto("Al_TTVolumen"));
            LblTipoNL.Text = ControladorIdioma.GetTexto("Al_DGTipo");
            TTnuevoLibro.SetToolTip(this.KCmbTipoNL, ControladorIdioma.GetTexto("Al_TTCmbTipo"));
            LblNumeroCapNL.Text = ControladorIdioma.GetTexto("Al_DGCapi");
            TTnuevoLibro.SetToolTip(this.KNudCapiActualNL, ControladorIdioma.GetTexto("Al_TTCapi"));
            LblNumPagNL.Text = ControladorIdioma.GetTexto("Al_DGPag");
            TTnuevoLibro.SetToolTip(this.KNudNumPagNL, ControladorIdioma.GetTexto("Al_TTPag"));
            LblMAyores18NL.Text = ControladorIdioma.GetTexto("Al_DG18");
            TTnuevoLibro.SetToolTip(this.TBtnMayores18NL, ControladorIdioma.GetTexto("Al_TT18"));
            LblEnlaceNL.Text = ControladorIdioma.GetTexto("Al_DGEnlace");
            TTnuevoLibro.SetToolTip(this.KTxtEnlaceNL, ControladorIdioma.GetTexto("Al_TTEnlace"));
            LblSinopsisNL.Text = ControladorIdioma.GetTexto("Al_DGSinopsis");
            TTnuevoLibro.SetToolTip(this.KTxtSinopsisNL, ControladorIdioma.GetTexto("Al_TTSinopsis"));
            LblIsbn10NL.Text = ControladorIdioma.GetTexto("Al_DG10");
            TTnuevoLibro.SetToolTip(this.KTxtIsbn10, ControladorIdioma.GetTexto("Al_TT10"));
            LblIsbn13NL.Text = ControladorIdioma.GetTexto("Al_DG13");
            TTnuevoLibro.SetToolTip(this.KTxtIsbn13, ControladorIdioma.GetTexto("Al_TT13"));
            LblPublicacionNL.Text = ControladorIdioma.GetTexto("Al_DGPub");
            TTnuevoLibro.SetToolTip(this.KMtxtFecPublicacionNL, ControladorIdioma.GetTexto("FormatoFecha"));
            LblFechaInclusionNL.Text = ControladorIdioma.GetTexto("Al_DGInclusion");
            TTnuevoLibro.SetToolTip(this.KMtxtInclusionbbddNL, ControladorIdioma.GetTexto("FormatoFecha"));
            LblPersonasNL.Text = ControladorIdioma.GetTexto("Al_DGPersonas");
            TTnuevoLibro.SetToolTip(this.KCCPersonasNL, ControladorIdioma.GetTexto("Al_TTPersonas"));
            TTnuevoLibro.SetToolTip(this.MBtnMasPersonasNL, ControladorIdioma.GetTexto("Al_TTBtnMasPer"));
            LblGenerosNL.Text = ControladorIdioma.GetTexto("Al_DGGeneros");
            TTnuevoLibro.SetToolTip(this.KCCGenerosNL, ControladorIdioma.GetTexto("Al_TTGeneros"));
            TTnuevoLibro.SetToolTip(this.MBtnMasGenerosNL, ControladorIdioma.GetTexto("Al_TTBtnMasGen"));
            LblSerieNL.Text = ControladorIdioma.GetTexto("Al_DGSerie");
            TTnuevoLibro.SetToolTip(this.KCCSerieNL, ControladorIdioma.GetTexto("Al_TTSerie"));
            TTnuevoLibro.SetToolTip(this.MBtnMasSerieNL, ControladorIdioma.GetTexto("Al_TTBtnMasSer"));
            LblEtiquetasNL.Text = ControladorIdioma.GetTexto("Al_DGEtiquetas");
            TTnuevoLibro.SetToolTip(this.KCCEtiquetaNL, ControladorIdioma.GetTexto("Al_TTEtiquetas"));
            TTnuevoLibro.SetToolTip(this.MBtnMasEtiquetasNL, ControladorIdioma.GetTexto("Al_TTBtnMasEti"));
            LblIdiomaOriginalNL.Text = ControladorIdioma.GetTexto("Al_DGIdiOri");
            TTnuevoLibro.SetToolTip(this.KCmbIdiomaOriginalNL, ControladorIdioma.GetTexto("Al_TTIdiOri"));
            LblIdiomaNL.Text = ControladorIdioma.GetTexto("Al_DGIdioma");
            TTnuevoLibro.SetToolTip(this.KCmbIdiomaNL, ControladorIdioma.GetTexto("Al_TTIdi"));
            
            KPageDatosUsuario.Text = ControladorIdioma.GetTexto("Al_TabDatosUsu");
            KGbDatosUsuarioNL.Values.Heading = ControladorIdioma.GetTexto("Al_TabDatosUsu");
            LblPuntuacionNL.Text = ControladorIdioma.GetTexto("Al_DUPunt");
            TTnuevoLibro.SetToolTip(this.KNudPuntuacionNL, ControladorIdioma.GetTexto("Al_TTPunt"));
            LblVecesLeidoNL.Text = ControladorIdioma.GetTexto("Al_DUleido");
            TTnuevoLibro.SetToolTip(this.KNudVecesLeidoNL, ControladorIdioma.GetTexto("Al_TTVecLeido"));
            LblEstadoLecturaNL.Text = ControladorIdioma.GetTexto("Al_DUEstado");
            TTnuevoLibro.SetToolTip(this.KCmbEstadoLecturaNL, ControladorIdioma.GetTexto("Al_TTEstado"));
            LblTiempoLecNL.Text = ControladorIdioma.GetTexto("Al_DUTiempoLec");
            TTnuevoLibro.SetToolTip(this.KMtxtTiempoLecturaNL, ControladorIdioma.GetTexto("Al_TTTiempo"));
            LblCapituloActualNL.Text = ControladorIdioma.GetTexto("Al_DUCap");
            TTnuevoLibro.SetToolTip(this.KNudCapiActualNL, ControladorIdioma.GetTexto("Al_TTCapiActual"));
            LblFecComiNL.Text = ControladorIdioma.GetTexto("Al_DUComienzo");
            TTnuevoLibro.SetToolTip(this.KMtxtFecComienzoNL, ControladorIdioma.GetTexto("FormatoFecha"));
            LblFecFinalNL.Text = ControladorIdioma.GetTexto("Al_DUFin");
            TTnuevoLibro.SetToolTip(this.KMtxtFecFinalNL, ControladorIdioma.GetTexto("FormatoFecha"));
            LblFavoritoNL.Text = ControladorIdioma.GetTexto("Al_DUFav");
            TTnuevoLibro.SetToolTip(this.TBtnFavNL, ControladorIdioma.GetTexto("Al_TTFav"));
            LblOcultarNL.Text = ControladorIdioma.GetTexto("Al_DUOcultar");
            TTnuevoLibro.SetToolTip(this.TBtnOcultarNL, ControladorIdioma.GetTexto("Al_TTOcu"));
            LblComentarioNL.Text = ControladorIdioma.GetTexto("Al_DUComentario");
            TTnuevoLibro.SetToolTip(this.KTxtComentarioUsuarioNL, ControladorIdioma.GetTexto("Al_TTCome"));

            KPageImagenes.Text = ControladorIdioma.GetTexto("Al_TabImg");
            KGbImagenesNL.Values.Heading = ControladorIdioma.GetTexto("Al_TabImg");
            LblImgPortadaNL.Text = ControladorIdioma.GetTexto("Al_IMPortada");
            TTnuevoLibro.SetToolTip(this.IBtnPortadaNL, ControladorIdioma.GetTexto("Al_TTBtnPortada"));
            LblImgContraNL.Text = ControladorIdioma.GetTexto("Al_IMContra");
            TTnuevoLibro.SetToolTip(this.IBtnContraportadaNL, ControladorIdioma.GetTexto("Al_TTBtnContra"));

            KPageAcciones.Text = ControladorIdioma.GetTexto("Al_TabAcciones");
            KGbAccionesNL.Values.Heading = ControladorIdioma.GetTexto("Al_TabAcciones");
            LsvAccionesNL.Columns[0].Text = ControladorIdioma.GetTexto("Al_ACFic");
            LsvAccionesNL.Columns[1].Text = ControladorIdioma.GetTexto("Al_ACEje");
            LblFicheroNL.Text = ControladorIdioma.GetTexto("Al_ACFic");
            LblEjecutableNL.Text = ControladorIdioma.GetTexto("Al_ACEje");
            BtnGuardarAccionesNL.Text= ControladorIdioma.GetTexto("Al_ACGuardar");
            TTnuevoLibro.SetToolTip(this.BtnGuardarAccionesNL, ControladorIdioma.GetTexto("Al_ACGuardar"));
            TTnuevoLibro.SetToolTip(this.IbtnFichero, ControladorIdioma.GetTexto("Al_TTBtnBuscarFichero"));
            TTnuevoLibro.SetToolTip(this.MBtnMasLsvAccionesNL, ControladorIdioma.GetTexto("Al_TTBtnMasAcc"));
            TTnuevoLibro.SetToolTip(this.MBtnMenosLsvAccionesNL, ControladorIdioma.GetTexto("Al_TTBtnMenosAcc"));
            TTnuevoLibro.SetToolTip(this.LsvAccionesNL, ControladorIdioma.GetTexto("Al_TTLsvAcciones"));

            BtnGuardarNL.Text = ControladorIdioma.GetTexto("Al_Guardar");
            TTnuevoLibro.SetToolTip(this.BtnGuardarNL, ControladorIdioma.GetTexto("Al_Guardar"));
        }
        private int AgregarComboCheckItem(CheckedComboBox checkedCombo, object item)
        {
            return checkedCombo.Items.Add(new CCBoxItem(item.ToString(), 0, item));
        }
        
        private int AgregarComboItem(KryptonComboBox comboBox, object item)
        {
            return comboBox.Items.Add(item);
        }

        private ListViewItem AniadirAccion(UsuarioAccion accion)
        {
            var item = LsvAccionesNL.Items.Add(Path.GetFileName(accion.RutaFichero));
            if (accion.Ejecutable != null) 
                item.SubItems.Add(accion.Ejecutable.ToString());
            else 
                item.SubItems.Add("");
            item.Tag = accion;
            if (accionActual == accion) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtFicheroNL.Text == accionActual.RutaFichero &&
                KCmbEjecutableNL.SelectedItem == accionActual.Ejecutable)
                return false;
            else
                return true;
        }

        private void ActualizarTipoLibro()
        {
            listaTipoLibro.Sort();
            tipoBinding.ResetBindings(false);
            KCmbTipoNL.SelectedItem = libroActual.NombreTipo == "" ?
                    null : libroActual.NombreTipo;
        }

        private void CargarImagen(PictureBox pictureBox, string rutaImagen)
        {
            try
            {
                pictureBox.Image = Image.FromFile(rutaImagen);
            }
            catch (FileNotFoundException)
            {
                pictureBox.Image = pictureBox.ErrorImage;
            }
            catch (ArgumentException)
            {
                pictureBox.Image = pictureBox.ErrorImage;
            }
        }

        private void RellenarPersona(List<Autor> listaComparador)
        {
            KCCPersonasNL.Items.Clear();
            listaPersona.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCPersonasNL, p);
                if (listaComparador.Contains(p)) KCCPersonasNL.SetItemChecked(i, true);
            });
        }

        private void RellenarEditorial(List<Editorial> listaComparador)
        {
            KCCEditorialNL.Items.Clear();
            listaEditorial.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCEditorialNL, p);
                if (listaComparador.Contains(p)) KCCEditorialNL.SetItemChecked(i, true);
            });
        }

        private void RellenarEjecutable()
        {
            KCmbEjecutableNL.Items.Clear();
            listaEjecutable.ForEach(p => AgregarComboItem(KCmbEjecutableNL, p));
        }

        private void RellenarEtiqueta(List<Etiqueta> listaComparador)
        {
            KCCEtiquetaNL.Items.Clear();
            listaEtiqueta.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCEtiquetaNL, p);
                if (listaComparador.Contains(p)) KCCEtiquetaNL.SetItemChecked(i, true);
            });
        }

        private void RellenarGenero(List<Genero> listaComparador)
        {
            KCCGenerosNL.Items.Clear();
            listaGenero.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCGenerosNL, p);
                if (listaComparador.Contains(p)) KCCGenerosNL.SetItemChecked(i, true);
            });
        }

        private void RellenarSerie(List<Serie> listaComparador)
        {
            KCCSerieNL.Items.Clear();
            listaSerie.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCSerieNL, p);
                if (listaComparador.Contains(p)) KCCSerieNL.SetItemChecked(i, true);
            });
        }
        #endregion
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void FrmAniadirLibro_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            if (this.Text.Equals(ControladorIdioma.GetTexto("Al_Titulo")))
            {
                LblTituloForm.Text = ControladorIdioma.GetTexto("Al_Titulo");
            }
            else
            {
                LblTituloForm.Text = ControladorIdioma.GetTexto("Al_Modificar");
            }
            KcellTabs.SelectedPage = KpageDatosGenerales;
            //Agregar valores de listas
            RellenarEditorial(libroActual.ListaEditorial);
            RellenarEjecutable();
            RellenarEtiqueta(libroActual.ListaEtiqueta);
            RellenarGenero(libroActual.ListaGenero);
            RellenarSerie(libroActual.ListaSerie);
            listaIdioma.ForEach(p => {
                AgregarComboItem(KCmbIdiomaNL, p);
                AgregarComboItem(KCmbIdiomaOriginalNL, p);
            });
            RellenarPersona(libroActual.ListaAutor);

            //Vincular lista de tipo libro con Combobox
            tipoBinding.DataSource = listaTipoLibro;
            KCmbTipoNL.DataSource = tipoBinding;

            //Cargar valores de libro
            KTxtTituloNL.Text = libroActual.Titulo;
            KTxtSubtituloNL.Text = libroActual.Subtitulo;
            KTxtTituAlternativoNL.Text = libroActual.TituloAlternativo;
            KNudEdicionNL.Value = libroActual.Edicion;
            KNudVolumenNL.Value = (decimal)libroActual.NumeroVolumen;
            KCmbTipoNL.Text = libroActual.NombreTipo;
            KNudNumCapNL.Value = libroActual.NumeroCapitulos;
            KNudNumPagNL.Value = libroActual.NumeroPaginas;
            KTxtIsbn10.Text = libroActual.Isbn_10;
            KTxtIsbn13.Text = libroActual.Isbn_13;
            KMtxtFecPublicacionNL.Text = libroActual.FechaPublicacion.Date.ToShortDateString();
            KMtxtInclusionbbddNL.Text = libroActual.FechaAdicionBD.Date.ToShortDateString();
            TBtnMayores18NL.Checked = libroActual.MayorEdad;
            KTxtEnlaceNL.Text = libroActual.EnlaceReferencia;
            KCmbIdiomaOriginalNL.SelectedItem = libroActual.IdiomaOriginal;
            KCmbIdiomaNL.SelectedItem = libroActual.Idioma;
            KNudPuntuacionNL.Value = (decimal)libroActual.Puntuacion;
            KNudVecesLeidoNL.Value = libroActual.VecesLeido;
            KCmbEstadoLecturaNL.Text = libroActual.EstadoLectura;
            KMtxtTiempoLecturaNL.Text = libroActual.TiempoLectura.TimeOfDay.ToString();
            KNudCapiActualNL.Value = libroActual.CapituloActual;
            KMtxtFecComienzoNL.Text = libroActual.FechaComienzo.Date.ToShortDateString();
            KMtxtFecFinalNL.Text = libroActual.FechaTerminado.Date.ToShortDateString();
            TBtnOcultarNL.Checked = libroActual.Ocultar;
            TBtnFavNL.Checked = libroActual.Favorito;
            KTxtComentarioUsuarioNL.Text = libroActual.Comentario;
            rutaImagenPortada = libroActual.ImagenPortada;
            CargarImagen(PcbImgPortadaNL, rutaImagenPortada);
            rutaImagenContraportada = libroActual.ImagenContraportada;
            CargarImagen(PcbImgContraNL, rutaImagenContraportada);
            libroActual.ListaAccion.Clear();
            libroActual.ListaAccion.ForEach(p => listaAccion.Add(p));
        }
        #region Datos generales
        private void MBtnMasEditorialNL_Click(object sender, EventArgs e)
        {
            FrmEditoriales editoriales = new FrmEditoriales(true);
            editoriales.FormBorderStyle = FormBorderStyle.None;
            editoriales.ShowDialog();
            List<Editorial> temp = new List<Editorial>();
            foreach (CCBoxItem p in KCCEditorialNL.CheckedItems)
            {
                temp.Add((Editorial)p.Item);
            }
            RellenarEditorial(temp);
        }    
        private void MBtnMasPersonasNL_Click(object sender, EventArgs e)
        {
            FrmAutores autores = new FrmAutores(true);
            autores.FormBorderStyle = FormBorderStyle.None;
            autores.ShowDialog();
            List<Autor> temp = new List<Autor>();
            foreach (CCBoxItem p in KCCPersonasNL.CheckedItems)
            {
                temp.Add((Autor)p.Item);
            }
            RellenarPersona(temp);
        }

        private void MBtnMasGenerosNL_Click(object sender, EventArgs e)
        {
            FrmGeneros generos = new FrmGeneros(true);
            generos.FormBorderStyle = FormBorderStyle.None;
            generos.ShowDialog();
            List<Genero> temp = new List<Genero>();
            foreach (CCBoxItem p in KCCGenerosNL.CheckedItems)
            {
                temp.Add((Genero)p.Item);
            }
            RellenarGenero(temp);
        }

        private void MBtnMasSerieNL_Click(object sender, EventArgs e)
        {
            FrmSeries series = new FrmSeries(true);
            series.FormBorderStyle = FormBorderStyle.None;
            series.ShowDialog();
            List<Serie> temp = new List<Serie>();
            foreach (CCBoxItem p in KCCSerieNL.CheckedItems)
            {
                temp.Add((Serie)p.Item);
            }
            RellenarSerie(temp);
        }

        private void MBtnMasEtiquetasNL_Click(object sender, EventArgs e)
        {
            FrmTags tags = new FrmTags(true);
            tags.FormBorderStyle = FormBorderStyle.None;
            tags.ShowDialog();
            List<Etiqueta> temp = new List<Etiqueta>();
            foreach (CCBoxItem p in KCCEtiquetaNL.CheckedItems)
            {
                temp.Add((Etiqueta)p.Item);
            }
            RellenarEtiqueta(temp);
        }
        private void MBtnMasTipoLibroNL_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Escribe el nombre del tipo de libro.",
               "Añadir Tipo de Libro", "", Location.X, Location.Y + 10);
            //Comprobar que no esté en blanco
            if (!String.IsNullOrWhiteSpace(x))
            {
                listaTipoLibro.Add(x);
                ActualizarTipoLibro();
                KCmbTipoNL.SelectedItem = x;
            }
        }

        private void MBtnMenosTipoLibroNL_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto("el tipo de libro") == DialogResult.Yes)
            {
                listaTipoLibro.Remove((string)KCmbTipoNL.SelectedItem);
                ActualizarTipoLibro();
                KCmbTipoNL.SelectedItem = null;
            }
        }
        #endregion
        #region Imagenes
        private void IBtnPortadaNL_Click(object sender, EventArgs e)
        {
            string s = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_IMAGEN);
            if (s != "")
            {
                rutaImagenPortada = s;
                CargarImagen(PcbImgPortadaNL, s);
            }
        }

        private void IBtnContraportadaNL_Click(object sender, EventArgs e)
        {
            string s = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_IMAGEN);
            if (s != "")
            {
                rutaImagenContraportada = s;
                CargarImagen(PcbImgContraNL, rutaImagenContraportada);
            }
        }
        #endregion
        #region Acciones
        private void LsvAccionesNL_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Comparar objetos para preguntar si guardar
            if (!e.IsSelected && accionActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto("");
                if (result == DialogResult.Yes)
                    BtnGuardarAccionesNL_Click(null, null);
            }

            //Comprobar selección item
            if (e.IsSelected && LsvAccionesNL.SelectedItems.Count == 1)
            {
                KGbFicheroEjeNL.Visible = true;
                itemActual = LsvAccionesNL.SelectedItems[0];
                accionActual = (UsuarioAccion)itemActual.Tag;
                KTxtFicheroNL.Text = accionActual.RutaFichero;
                KCmbEjecutableNL.SelectedItem = accionActual.Ejecutable == KCmbEjecutableNL.SelectedItem ?
                    null : accionActual.Ejecutable;
            }
            else
            {
                //Ocultar edición cuando no hay selección
                KGbFicheroEjeNL.Visible = false;
            }
        }

        private void MBtnMasLsvAccionesNL_Click(object sender, EventArgs e)
        {
            UsuarioAccion ua = new UsuarioAccion(libroActual, "Ruta fichero aquí", null);
            libroActual.ListaAccion.Add(ua);
            var item = AniadirAccion(ua);
            item.Selected = true;
        }
        private void MBtnMenosLsvAccionesNL_Click(object sender, EventArgs e)
        {
            if (LsvAccionesNL.SelectedItems.Count == 1 &&
              VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                var item = LsvAccionesNL.SelectedItems[0];
                libroActual.ListaAccion.Remove(accionActual);
                LsvAccionesNL.Items.Remove(item);
            }
        }
        private void BtnGuardarAccionesNL_Click(object sender, EventArgs e)
        {
            //Actualizar libro
            accionActual.RutaFichero = KTxtFicheroNL.Text;
            accionActual.Ejecutable = (UsuarioEjecutable)KCmbEjecutableNL.SelectedItem;

            //Actualizar listview
            itemActual.Text = accionActual.RutaFichero;
            if (accionActual.Ejecutable != null)
                itemActual.SubItems[1].Text = accionActual.Ejecutable.ToString();
        }
        private void IbtnFichero_Click(object sender, EventArgs e)
        {
            KTxtFicheroNL.Text = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_TODO);

        }
        private void MBtnMasEjecutableNL_Click(object sender, EventArgs e)
        {
            FrmEjecutable ejecutable = new FrmEjecutable(true);
            ejecutable.FormBorderStyle=FormBorderStyle.None;
            ejecutable.ShowDialog();
            RellenarEjecutable();
        }
        #endregion


        private void BtnGuardarNL_Click(object sender, EventArgs e)
        {
            object obj = Biblioteca.biblioteca.ListaLibro.Find(p => p.Isbn_13 == KTxtIsbn13.Text);
            if (!String.IsNullOrWhiteSpace(KTxtIsbn13.Text) &&
               ( obj == libroActual || obj == null )
               && !String.IsNullOrWhiteSpace(KTxtTituloNL.Text))
            {
                //Actualizar libro
                libroActual.Titulo = KTxtTituloNL.Text;
                libroActual.Subtitulo = KTxtSubtituloNL.Text;
                libroActual.TituloAlternativo = KTxtTituAlternativoNL.Text;
                libroActual.ListaEditorial.Clear();
                foreach (var c in KCCEditorialNL.CheckedItems)
                    libroActual.ListaEditorial.Add((Editorial)(c as CCBoxItem).Item);
                libroActual.Edicion = (int)KNudEdicionNL.Value;
                libroActual.NumeroVolumen = (double)KNudVolumenNL.Value;
                libroActual.NombreTipo = KCmbTipoNL.Text;
                libroActual.NumeroCapitulos = (int)KNudNumCapNL.Value;
                libroActual.NumeroPaginas = (int)KNudNumPagNL.Value;
                libroActual.Isbn_10 = KTxtIsbn10.Text;
                libroActual.Isbn_13 = KTxtIsbn13.Text;
                libroActual.FechaPublicacion = DateTime.Parse(KMtxtFecPublicacionNL.Text);
                libroActual.FechaAdicionBD = DateTime.Parse(KMtxtInclusionbbddNL.Text);
                libroActual.MayorEdad = TBtnMayores18NL.Checked;
                libroActual.EnlaceReferencia = KTxtEnlaceNL.Text;
                libroActual.ListaAutor.Clear();
                foreach (var c in KCCPersonasNL.CheckedItems)
                    libroActual.ListaAutor.Add((Autor)(c as CCBoxItem).Item);
                libroActual.ListaGenero.Clear();
                foreach (var c in KCCGenerosNL.CheckedItems)
                    libroActual.ListaGenero.Add((Genero)(c as CCBoxItem).Item);
                libroActual.ListaEtiqueta.Clear();
                foreach (var c in KCCEtiquetaNL.CheckedItems)
                    libroActual.ListaEtiqueta.Add((Etiqueta)(c as CCBoxItem).Item);
                libroActual.ListaSerie.Clear();
                foreach (var c in KCCSerieNL.CheckedItems)
                    libroActual.ListaSerie.Add((Serie)(c as CCBoxItem).Item);
                libroActual.IdiomaOriginal = (Idioma)KCmbIdiomaOriginalNL.SelectedItem;
                libroActual.Idioma = (Idioma)KCmbIdiomaNL.SelectedItem;
                libroActual.Puntuacion = (double)KNudPuntuacionNL.Value;
                libroActual.VecesLeido = (int)KNudVecesLeidoNL.Value;
                libroActual.EstadoLectura = KCmbEstadoLecturaNL.Text;
                libroActual.TiempoLectura = DateTime.Parse(KMtxtTiempoLecturaNL.Text);
                libroActual.CapituloActual = (int)KNudCapiActualNL.Value;
                libroActual.FechaComienzo = DateTime.Parse(KMtxtFecComienzoNL.Text);
                libroActual.FechaTerminado = DateTime.Parse(KMtxtFecFinalNL.Text);
                libroActual.Ocultar = TBtnOcultarNL.Checked;
                libroActual.Favorito = TBtnFavNL.Checked;
                libroActual.Comentario = KTxtComentarioUsuarioNL.Text;
                if (rutaImagenPortada != libroActual.ImagenPortada)
                {
                    libroActual.ImagenPortada = ControladorImagen.GuardarImagen(rutaImagenPortada,
                        ControladorImagen.RUTA_LIBRO, libroActual.Isbn_13 + "_c");
                    rutaImagenPortada = libroActual.ImagenPortada;
                }
                if (rutaImagenContraportada != libroActual.ImagenContraportada)
                {
                    libroActual.ImagenContraportada = ControladorImagen.GuardarImagen(rutaImagenContraportada,
                        ControladorImagen.RUTA_LIBRO, libroActual.Isbn_13 + "_b");
                    rutaImagenContraportada = libroActual.ImagenContraportada;
                }
                libroActual.ListaAccion.Clear();
                foreach (ListViewItem c in LsvAccionesNL.Items)
                    libroActual.ListaAccion.Add((UsuarioAccion)c.Tag);

                Close();
            }
            else
                VentanaWindowsComun.MensajeError("El título y el ISBN no puede estar vacío." +
                    "\nTampoco puede estar el ISBN repetido.");
        }

        private void MBtnCerrarTitulos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAniadirLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Comparar objetos para preguntar si guardar
            if (libroActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto("el libro");
                if (result == DialogResult.Yes)
                    BtnGuardarNL_Click(null, null);
            }
        }
    }
}
