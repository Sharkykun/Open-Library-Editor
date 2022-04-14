using OpenLibraryEditor.Clases;
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
    public partial class FrmEditoriales : Form
    {
        #region atributos
        private const string NOMBRE_OBJETO = "la editorial";
        private List<Editorial> listaEditorial = UsuarioDatos.listaEditorial;
        private Editorial editorialActual;
        private ListViewItem itemActual;

        private string rutaImagen;

        private bool setNew;
        private Editorial editorialNueva;

        public Editorial EditorialNueva { get => editorialNueva; set => editorialNueva = value; }
        #endregion
        public FrmEditoriales(bool setNew)
        {
            InitializeComponent();
            this.setNew = setNew;
        }
        private void MBtnCerrarEditoriales_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KBtnCancelarEd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmEditoriales_Load(object sender, EventArgs e)
        {
            //Cargar editorial
            foreach (Editorial p in listaEditorial)
            {
                AniadirEditorial(p);
            }

            if (setNew)
            {
                MBtnMasLsvNE_Click(null, null);
                editorialNueva = editorialActual;
            }
        }
        #region metodos propios
        private ListViewItem AniadirEditorial(Editorial editorial)
        {
            var item = LsvEditorialNE.Items.Add(editorial.Nombre);
            item.Tag = editorial;
            if (editorial == editorialActual) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreEd.Text == editorialActual.Nombre &&
                KTxtComentarioEd.Text == editorialActual.Comentario &&
                rutaImagen == editorialActual.Imagen)
                return false;
            else
                return true;
        }

        private void CargarImagen(string rutaImagen)
        {
            try
            {
                PcbEditorialesEd.Image = Image.FromFile(rutaImagen);
            }
            catch (FileNotFoundException)
            {
                PcbEditorialesEd.Image = PcbEditorialesEd.ErrorImage;
            }
            catch (ArgumentException)
            {
                PcbEditorialesEd.Image = PcbEditorialesEd.ErrorImage;
            }
        }
        #endregion

        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloEditoriales_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

     

        private void LsvEditorialNE_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Comparar objetos para preguntar si guardar
            if (!e.IsSelected && editorialActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                    KBtnAceptarEd_Click(null, null);
            }

            //Comprobar selección item
            if (e.IsSelected && LsvEditorialNE.SelectedItems.Count == 1)
            {
                PanOpcionesED.Visible = true;
                itemActual = LsvEditorialNE.SelectedItems[0];
                editorialActual = (Editorial)itemActual.Tag;
                KTxtNombreEd.Text = editorialActual.Nombre;
                KTxtComentarioEd.Text = editorialActual.Comentario;
                rutaImagen = editorialActual.Imagen;
                CargarImagen(rutaImagen);
            }
            else
            {
                //Ocultar edición cuando no hay selección
                PanOpcionesED.Visible = false;
            }
        }


        private void MBtnMasLsvNE_Click(object sender, EventArgs e)
        {
            Editorial p = new Editorial("Nueva Editorial");
            listaEditorial.Add(p);
            var item = AniadirEditorial(p);
            item.Selected = true;
        }

        private void MBtnMenosLsvNE_Click(object sender, EventArgs e)
        {
            if (LsvEditorialNE.SelectedItems.Count == 1 &&
              VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                var item = LsvEditorialNE.SelectedItems[0];
                listaEditorial.Remove(editorialActual);
                LsvEditorialNE.Items.Remove(item);
            }
        }

        private void MBtnAniadirImagenEd_Click(object sender, EventArgs e)
        {
            string s = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_IMAGEN);
            if (s != "")
            {
                rutaImagen = s;
                CargarImagen(rutaImagen);
            }
        }
        private void MBtnBorrarImagenEd_Click(object sender, EventArgs e)
        {
            PcbEditorialesEd.Image = PcbEditorialesEd.ErrorImage;
        }

        private void KBtnAceptarEd_Click(object sender, EventArgs e)
        {
            if (PanOpcionesED.Visible == true) { 
                //Actualizar etiqueta
                editorialActual.Nombre = KTxtNombreEd.Text;
                editorialActual.Comentario = KTxtComentarioEd.Text;
                if (rutaImagen != editorialActual.Imagen)
                {
                    editorialActual.Imagen = ControladorImagen.GuardarImagen(rutaImagen,
                        ControladorImagen.RUTA_EDITORIAL, editorialActual.IdEditorial.ToString());
                    rutaImagen = editorialActual.Imagen;
                }

                //Actualizar listview
                itemActual.Text = KTxtNombreEd.Text;
            }
        }

       
    }
}
