
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

namespace OpenLibraryEditor.Forms
{
    public partial class FrmAniadirLibro : Form
    {
        #region atributos
        private const string NOMBRE_OBJETO = "la acción";
        private Libro libroActual;
        private BindingSource tipoBinding = new BindingSource();

        //listas
        private List<string> listaTipoLibro = Libro.tipoLibroLista;
        private List<Editorial> listaEditorial = UsuarioDatos.listaEditorial;
        private List<Genero> listaGenero = UsuarioDatos.listaGenero;
        private List<Persona> listaPersona = UsuarioDatos.listaPersona;
        private List<Serie> listaSerie = UsuarioDatos.listaSerie;
        private List<Etiqueta> listaEtiqueta = UsuarioDatos.listaEtiqueta;
        private List<Idioma> listaIdioma = UsuarioDatos.listaIdioma;
        private List<UsuarioEjecutable> listaEjecutable = UsuarioDatos.listaEjecutable;
        private List<UsuarioAccion> listaAccion = new List<UsuarioAccion>();
        private UsuarioAccion accionActual;
        private ListViewItem itemActual;
        private string rutaImagenPortada;
        private string rutaImagenContraportada;
        #endregion
        public FrmAniadirLibro(Libro libro)
        {
            InitializeComponent();
            libroActual = libro;
        }
        #region metodos propios
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
            if (accion.Ejecutable != null) item.SubItems.Add(accion.Ejecutable.ToString());
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

        private void RellenarPersona()
        {
            KCCPersonasNL.Items.Clear();
            listaPersona.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCPersonasNL, p);
                if (libroActual.ListaPersona.Contains(p)) KCCPersonasNL.SetItemChecked(i, true);
            });
        }

        private void RellenarEditorial()
        {
            KCCEditorialNL.Items.Clear();
            listaEditorial.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCEditorialNL, p);
                if (libroActual.ListaEditorial.Contains(p)) KCCEditorialNL.SetItemChecked(i, true);
            });
        }

        private void RellenarEjecutable()
        {
            KCmbEjecutableNL.Items.Clear();
            listaEjecutable.ForEach(p => AgregarComboItem(KCmbEjecutableNL, p));
        }

        private void RellenarEtiqueta()
        {
            KCCEtiquetaNL.Items.Clear();
            listaEtiqueta.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCEtiquetaNL, p);
                if (libroActual.ListaEtiqueta.Contains(p)) KCCEtiquetaNL.SetItemChecked(i, true);
            });
        }

        private void RellenarGenero()
        {
            KCCGenerosNL.Items.Clear();
            listaGenero.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCGenerosNL, p);
                if (libroActual.ListaGenero.Contains(p)) KCCGenerosNL.SetItemChecked(i, true);
            });
        }

        private void RellenarSerie()
        {
            KCCSerieNL.Items.Clear();
            listaSerie.ForEach(p =>
            {
                int i = AgregarComboCheckItem(KCCSerieNL, p);
                if (libroActual.ListaSerie.Contains(p)) KCCSerieNL.SetItemChecked(i, true);
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
            //Agregar valores de listas
            RellenarEditorial();
            RellenarEjecutable();
            RellenarEtiqueta();
            RellenarGenero();
            RellenarSerie();
            listaIdioma.ForEach(p => {
                AgregarComboItem(KCmbIdiomaNL, p);
                AgregarComboItem(KCmbIdiomaOriginalNL, p);
            });
            RellenarPersona();

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
            RellenarEditorial();
        }    
        private void MBtnMasPersonasNL_Click(object sender, EventArgs e)
        {
            FrmAutores autores = new FrmAutores(true);
            autores.FormBorderStyle = FormBorderStyle.None;
            autores.ShowDialog();
            RellenarPersona();
        }

        private void MBtnMasGenerosNL_Click(object sender, EventArgs e)
        {
            FrmGeneros generos = new FrmGeneros(true);
            generos.FormBorderStyle = FormBorderStyle.None;
            generos.ShowDialog();
            RellenarGenero();
        }

        private void MBtnMasSerieNL_Click(object sender, EventArgs e)
        {
            FrmSeries series = new FrmSeries(true);
            series.FormBorderStyle = FormBorderStyle.None;
            series.ShowDialog();
            RellenarSerie();
        }

        private void MBtnMasEtiquetasNL_Click(object sender, EventArgs e)
        {
            FrmTags tags = new FrmTags(true);
            tags.FormBorderStyle = FormBorderStyle.None;
            tags.ShowDialog();
            RellenarEtiqueta();
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
            itemActual.SubItems[1].Text = accionActual.Ejecutable.ToString();
        }
        private void IBtnBuscarFicheroAccionesNL_Click(object sender, EventArgs e)
        {
            
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
            if (!String.IsNullOrWhiteSpace(KTxtIsbn13.Text) &&
               !UsuarioDatos.biblioteca.ListaLibro.Any(p => p.Isbn_13 == KTxtIsbn13.Text)
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
                libroActual.ListaPersona.Clear();
                foreach (var c in KCCPersonasNL.CheckedItems)
                    libroActual.ListaPersona.Add((Persona)(c as CCBoxItem).Item);
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

        
    }
}
