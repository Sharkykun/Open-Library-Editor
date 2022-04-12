
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

namespace OpenLibraryEditor.Forms
{
    public partial class FrmAniadirLibro : Form
    {
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
        public FrmAniadirLibro(Libro libro)
        {
            InitializeComponent();
            libroActual = libro;
        }
        #region metodos propios
        //private int AgregarComboCheckItem(CheckedComboBox checkedCombo, object item)
        //{
        //    return checkedCombo.Items.Add(new CCBoxItem(item.ToString(), 0, item));
        //}
        //private int AgregarComboCheckItem(ComboBox checkedCombo, object item)
        //{
        //    return checkedCombo.Items.Add(new CCBoxItem(item.ToString(), 0, item));
        //}

        //private int AgregarComboItem(ComboBox comboBox, object item)
        //{
        //    return comboBox.Items.Add(item);
        //}

        //private ListViewItem AniadirAccion(UsuarioAccion accion)
        //{
        //    var item = LsvAccionesNL.Items.Add(Path.GetFileName(accion.RutaFichero));
        //    if (accion.Ejecutable != null) item.SubItems.Add(accion.Ejecutable.ToString());
        //    item.Tag = accion;
        //    if (accionActual == accion) item.Selected = true;
        //    return item;
        //}

        //private bool EsObjetoCambiado()
        //{
        //    //Comprobar si el objeto actual tiene algo cambiado
        //    if (KTxtFicheroNL.Text == accionActual.RutaFichero &&
        //        KCmbEjecutableNL.SelectedItem == accionActual.Ejecutable)
        //        return false;
        //    else
        //        return true;
        //}

        //private void ActualizarTipoLibro()
        //{
        //    listaTipoLibro.Sort();
        //    tipoBinding.ResetBindings(false);
        //    KCmbTipoNL.SelectedItem = libroActual.NombreTipo == "" ?
        //            null : libroActual.NombreTipo;
        //}

        //private void CargarImagen(PictureBox pictureBox, string rutaImagen)
        //{
        //    try
        //    {
        //        pictureBox.Image = Image.FromFile(rutaImagen);
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        pictureBox.Image = pictureBox.ErrorImage;
        //    }
        //    catch (ArgumentException)
        //    {
        //        pictureBox.Image = pictureBox.ErrorImage;
        //    }
        //}

        //private void RellenarPersona()
        //{
        //    KCmbPersonasNL.Items.Clear();
        //    listaPersona.ForEach(p => {
        //        int i = AgregarComboCheckItem(KCmbPersonasNL, p);
        //        if (libroActual.ListaPersona.Contains(p)) CmbPersona.SetItemChecked(i, true);
        //    });
        //}

        //private void RellenarEditorial()
        //{
        //    KCmbEditorialNL.Items.Clear();
        //    listaEditorial.ForEach(p =>
        //    {
        //        int i = AgregarComboCheckItem(KCmbEditorialNL, p);
        //        if (libroActual.ListaEditorial.Contains(p)) KCmbEditorialNL.SetItemChecked(i, true);
        //    });
        //}

        //private void RellenarEjecutable()
        //{
        //    KCmbEjecutableNL.Items.Clear();
        //    listaEjecutable.ForEach(p => AgregarComboItem(KCmbEjecutableNL, p));
        //}

        //private void RellenarEtiqueta()
        //{
        //    KCmbEtiquetaNL.Items.Clear();
        //    listaEtiqueta.ForEach(p => {
        //        int i = AgregarComboCheckItem(KCmbEtiquetaNL, p);
        //        if (libroActual.ListaEtiqueta.Contains(p)) KCmbEtiquetaNL.SetItemChecked(i, true);
        //    });
        //}

        //private void RellenarGenero()
        //{
        //    KCmbGeneroNL.Items.Clear();
        //    listaGenero.ForEach(p => {
        //        int i = AgregarComboCheckItem(KCmbGeneroNL, p);
        //        if (libroActual.ListaGenero.Contains(p)) KCmbGeneroNL.SetItemChecked(i, true);
        //    });
        //}

        //private void RellenarSerie()
        //{
        //    KCmbSerieNL.Items.Clear();
        //    listaSerie.ForEach(p => {
        //        int i = AgregarComboCheckItem(KCmbSerieNL, p);
        //        if (libroActual.ListaSerie.Contains(p)) KCmbSerieNL.SetItemChecked(i, true);
        //    });
        //}
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


        private void MBtnCerrarTitulos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IBtntMasEditorialNL_Click(object sender, EventArgs e)
        {

        }
    }
}
