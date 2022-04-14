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
    public partial class FrmGeneros : Form
    {
        #region atributos
        private const string NOMBRE_OBJETO = "el género";
        private bool setNew;
        private Genero generoNuevo;
        private List<Genero> listaGenero = UsuarioDatos.listaGenero;
        private Genero generoActual;
        private ListViewItem itemActual;
        private BindingSource generoBinding = new BindingSource();

        public Genero GeneroNuevo { get => generoNuevo; set => generoNuevo = value; }
        #endregion
        public FrmGeneros(bool setNew)
        {
            InitializeComponent();
            this.setNew=setNew;
        }
        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            //Cargar etiquetas
            foreach (Genero gen in listaGenero)
            {
                AniadirGenero(gen);
            }

            //Vincular lista de categorias con Combobox
            generoBinding.DataSource = listaGenero;
            KCmbGeneroPadreGe.DataSource = generoBinding;

            if (setNew)
            {
                MBtnMasLsvNG_Click(null, null);
                generoNuevo = generoActual;
            }
        }
        #region metodos propios
        private void ActualizarGeneroPadre()
        {
            generoBinding.ResetBindings(false);
            KCmbGeneroPadreGe.SelectedItem = generoActual.GeneroPadre;
        }

        private ListViewItem AniadirGenero(Genero genero)
        {
            var item = LsvGeneroNG.Items.Add(genero.Nombre);
            string nombre = genero.GeneroPadre == null ? "" : genero.GeneroPadre.Nombre;
            item.SubItems.Add(nombre);
            item.Tag = genero;
            if (generoActual == genero) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreGe.Text == generoActual.Nombre &&
                KTxtComentarioGe.Text == generoActual.Comentario &&
                KCmbGeneroPadreGe.SelectedItem == generoActual.GeneroPadre)
                return false;
            else
                return true;
        }
        #endregion
        private void MBtnCerrarGeneros_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KBtnCancelarGe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloGeneros_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        private void LsvGeneroNG_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Comparar objetos para preguntar si guardar
            if (!e.IsSelected && generoActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                    KBtnAceptarGe_Click(null, null);
            }

            //Comprobar selección item
            if (e.IsSelected && LsvGeneroNG.SelectedItems.Count == 1)
            {
                PanOpcionesGE.Visible = true;
                itemActual = LsvGeneroNG.SelectedItems[0];
                generoActual = (Genero)itemActual.Tag;
                KTxtNombreGe.Text = generoActual.Nombre;
                KTxtComentarioGe.Text = generoActual.Comentario;
                KCmbGeneroPadreGe.SelectedItem = generoActual.GeneroPadre;
            }
            else
            {
                //Ocultar edición cuando no hay selección
                PanOpcionesGE.Visible = false;
            }
        }
        private void MBtnMasLsvNG_Click(object sender, EventArgs e)
        {
            Genero gen = new Genero("Nuevo Género");
            listaGenero.Add(gen);
            var item = AniadirGenero(gen);
            item.Selected = true;
            ActualizarGeneroPadre();
        }

        private void MBtnMenosLsvNG_Click(object sender, EventArgs e)
        {
            if (LsvGeneroNG.SelectedItems.Count == 1 &&
               VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                var item = LsvGeneroNG.SelectedItems[0];
                listaGenero.Remove(generoActual);
                LsvGeneroNG.Items.Remove(item);
                ActualizarGeneroPadre();
            }
        }

        private void KBtnAceptarGe_Click(object sender, EventArgs e)
        {
            if (PanOpcionesGE.Visible == true) { 
                //Actualizar etiqueta
                generoActual.Nombre = KTxtNombreGe.Text;
                generoActual.GeneroPadre = (Genero)KCmbGeneroPadreGe.SelectedItem;
                generoActual.Comentario = KTxtComentarioGe.Text;

                //Actualizar listview
                itemActual.Text = KTxtNombreGe.Text;
                foreach (ListViewItem item in LsvGeneroNG.Items)
                {
                    if (item.Tag == generoActual)
                        item.SubItems[1].Text = generoActual.GeneroPadre.Nombre;
                }

                ActualizarGeneroPadre();
            }
        }

       
    }
}
