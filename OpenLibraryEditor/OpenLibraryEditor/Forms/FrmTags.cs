using Microsoft.VisualBasic;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
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
    public partial class FrmTags : Form
    {
        #region atributos
        private const string NOMBRE_OBJETO = "la etiqueta";
        private bool setNew;
        private Etiqueta etiquetaNueva;
        private List<Etiqueta> listaEtiqueta = UsuarioDatos.listaEtiqueta;
        private List<string> listaCategoria = Etiqueta.categoriaLista;
        private Etiqueta etiquetaActual;
        private ListViewItem itemActual;
        private BindingSource categoriaBinding = new BindingSource();

        public Etiqueta EtiquetaNueva { get => etiquetaNueva; set => etiquetaNueva = value; }
        #endregion
        public FrmTags(bool setNew)
        {
            InitializeComponent();
            this.setNew = setNew;
        }
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloTags_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void MBtnCerrarTags_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KBtnCancelarTa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTags_Load(object sender, EventArgs e)
        {
            //Cargar etiquetas
            foreach (Etiqueta et in listaEtiqueta)
            {
                AniadirEtiqueta(et);
            }

            //Vincular lista de categorias con Combobox
            categoriaBinding.DataSource = listaCategoria;
            KCmbCategoriaNE.DataSource = categoriaBinding;

            if (setNew)
            {
                MBtnMasLsvNT_Click(null, null);
                etiquetaNueva = etiquetaActual;
            }
        }
        #region metodos propios
        private void ActualizarCategoria()
        {
            listaCategoria.Sort();
            categoriaBinding.ResetBindings(false);
            KCmbCategoriaNE.SelectedItem = etiquetaActual.NombreCategoria == "" ?
                null : etiquetaActual.NombreCategoria;
        }

        private ListViewItem AniadirEtiqueta(Etiqueta etiqueta)
        {
            var item = LsvTagsNT.Items.Add(etiqueta.Nombre);
            item.SubItems.Add(etiqueta.NombreCategoria);
            item.Tag = etiqueta;
            if (etiquetaActual == etiqueta) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreNE.Text == etiquetaActual.Nombre &&
                KTxtComentarioTa.Text == etiquetaActual.Comentario &&
                KCmbCategoriaNE.Text == etiquetaActual.NombreCategoria)
                return false;
            else
                return true;
        }
        #endregion

        private void LsvTagsNT_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Comparar objetos para preguntar si guardar
            if (!e.IsSelected && etiquetaActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                    KBtnAceptarTa_Click(null, null);
            }

            //Comprobar selección item
            if (e.IsSelected && LsvTagsNT.SelectedItems.Count == 1)
            {
                PanOpcionesTag.Visible = true;
                itemActual = LsvTagsNT.SelectedItems[0];
                etiquetaActual = (Etiqueta)itemActual.Tag;
                KTxtNombreNE.Text = etiquetaActual.Nombre;
                KTxtComentarioTa.Text = etiquetaActual.Comentario;
                KCmbCategoriaNE.SelectedItem = etiquetaActual.NombreCategoria == "" ?
                    null : etiquetaActual.NombreCategoria;
            }
            else
            {
                //Ocultar edición cuando no hay selección
                PanOpcionesTag.Visible = false;
            }
        }

        private void MBtnMasLsvNT_Click(object sender, EventArgs e)
        {
            Etiqueta et = new Etiqueta("Nueva Etiqueta");
            listaEtiqueta.Add(et);
            var item = AniadirEtiqueta(et);
            item.Selected = true;
        }

        private void MBtnMenosLsvNT_Click(object sender, EventArgs e)
        {
            if (LsvTagsNT.SelectedItems.Count == 1 &&
                VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                var item = LsvTagsNT.SelectedItems[0];
                listaEtiqueta.Remove(etiquetaActual);
                LsvTagsNT.Items.Remove(item);
            }
        }

        private void MBtnMasCategoriaTa_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Escribe el nombre de la categoría.",
                "Añadir Categoría", "", Location.X, Location.Y + 10);
            //Comprobar que no esté en blanco
            if (!String.IsNullOrWhiteSpace(x))
            {
                listaCategoria.Add(x);
                ActualizarCategoria();
                KCmbCategoriaNE.SelectedItem = x;
            }
        }

        private void MBtnMenosCategoriaTag_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto("la categoría") == DialogResult.Yes)
            {
                listaCategoria.Remove((string)KCmbCategoriaNE.SelectedItem);
                ActualizarCategoria();
                KCmbCategoriaNE.SelectedItem = null;
            }
        }

        private void KBtnAceptarTa_Click(object sender, EventArgs e)
        {
            if (PanOpcionesTag.Visible == true) { 
                //Actualizar etiqueta
                etiquetaActual.Nombre = KTxtNombreNE.Text;
                etiquetaActual.NombreCategoria = KCmbCategoriaNE.Text;
                etiquetaActual.Comentario = KTxtComentarioTa.Text;

                //Actualizar listview
                itemActual.Text = KTxtNombreNE.Text;
                itemActual.SubItems[1].Text = KCmbCategoriaNE.Text;
            }
        }
    }
}
