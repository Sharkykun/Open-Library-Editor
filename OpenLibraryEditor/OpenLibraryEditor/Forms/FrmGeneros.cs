using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmGeneros : Form
    {
        #region atributos
        private string NOMBRE_OBJETO = ControladorIdioma.GetTexto("Ge_Gen");
        private bool setNew;
        private Genero generoNuevo;
        private List<Genero> listaGenero = Biblioteca.biblioteca.ListaGenero;
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
        public FrmGeneros(bool setNew, Genero generoActual)
        {
            InitializeComponent();
            this.setNew = setNew;
            this.generoActual = generoActual;
            EditarGeneroDesdeMain();
        }
        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
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
        private void EditarGeneroDesdeMain()
        {
            PanOpcionesGE.Visible = true;
            KTxtNombreGe.Text = generoActual.Nombre;
            KTxtComentarioGe.Text = generoActual.Comentario;
            KCmbGeneroPadreGe.SelectedItem = generoActual.GeneroPadre;
        }
        private void IdiomaTexto()
        {
            TTGeneros.SetToolTip(this.PcbLogoGeneros,ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloGeneros.Text = ControladorIdioma.GetTexto("Ge_TituloFrm");
            TTGeneros.SetToolTip(this.LblTituloGeneros, ControladorIdioma.GetTexto("Ge_TituloFrm"));
            TTGeneros.SetToolTip(this.LsvGeneroNG, ControladorIdioma.GetTexto("Ge_TTLsv"));
            LsvGeneroNG.Columns[0].Text = ControladorIdioma.GetTexto("Ge_LsvNombre");
            LsvGeneroNG.Columns[1].Text = ControladorIdioma.GetTexto("Ge_Genero");
            TTGeneros.SetToolTip(this.MBtnMasLsvNG, ControladorIdioma.GetTexto("Ge_TTMas"));
            TTGeneros.SetToolTip(this.MBtnMenosLsvNG, ControladorIdioma.GetTexto("Ge_TTMenos"));
            LblNombreGe.Text = ControladorIdioma.GetTexto("Ge_Nombre");
            TTGeneros.SetToolTip(this.KTxtNombreGe, ControladorIdioma.GetTexto("Ge_TTNombre"));
            LblGeneroPadreGe.Text = ControladorIdioma.GetTexto("Ge_Genero");
            TTGeneros.SetToolTip(this.KCmbGeneroPadreGe, ControladorIdioma.GetTexto("Ge_TTGenero"));
            LblComentarioGe.Text = ControladorIdioma.GetTexto("Ge_Comentario");
            TTGeneros.SetToolTip(this.KTxtComentarioGe, ControladorIdioma.GetTexto("Ge_TTComentario"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTGeneros.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Guardar");
            TTGeneros.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Guardar"));
            TTGeneros.SetToolTip(this.MBtnCerrarGeneros, ControladorIdioma.GetTexto("Cerrar")); 
        }
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

        private void ComprobarGuardado()
        {
            //Comparar objetos para preguntar si guardar
            if (generoActual != null && EsObjetoCambiado())
            {
                //VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                {
                    GBtnAceptar_Click(null, null);
                }   
            }
        }
        #endregion
        private void MBtnCerrarGeneros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBtnCancelar_Click(object sender, EventArgs e)
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
            if (!e.IsSelected)
                ComprobarGuardado();

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
            Genero gen = new Genero(ControladorIdioma.GetTexto("Ge_NuevoGen"));
            listaGenero.Add(gen);
            var item = AniadirGenero(gen);
            item.Selected = true;
            ActualizarGeneroPadre();
        }

        private void MBtnMenosLsvNG_Click(object sender, EventArgs e)
        {
            if (LsvGeneroNG.SelectedItems.Count == 1 &&
               VentanaWindowsComun.MensajeBorrarObjeto(ControladorIdioma.GetTexto("Ge_Gen")) == DialogResult.Yes)
            {
                var item = LsvGeneroNG.SelectedItems[0];
                listaGenero.Remove(generoActual);
                LsvGeneroNG.Items.Remove(item);
                ActualizarGeneroPadre();
                VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO + ControladorIdioma.GetTexto("BorradoCorrectamente"));
            }
        }

        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesGE.Visible == true)
            {
                if (!String.IsNullOrWhiteSpace(KTxtNombreGe.Text) &&
                KCmbGeneroPadreGe.SelectedItem != generoActual)
                {
                    //Actualizar etiqueta
                    generoActual.Nombre = KTxtNombreGe.Text;
                    generoActual.GeneroPadre = (Genero)KCmbGeneroPadreGe.SelectedItem;
                    generoActual.Comentario = KTxtComentarioGe.Text;

                    //Actualizar listview
                    itemActual.Text = KTxtNombreGe.Text;
                    itemActual.SubItems[1].Text = KCmbGeneroPadreGe.Text;
                    foreach (ListViewItem item in LsvGeneroNG.Items)
                    {
                        Genero gp = (item.Tag as Genero).GeneroPadre;
                        if (gp == generoActual && gp != null)
                            item.SubItems[1].Text = generoActual.Nombre;
                    }

                    ActualizarGeneroPadre();
                    VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO + ControladorIdioma.GetTexto("GuardadoCorrectamente"));

                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_Genero"));
            }
        }

        private void FrmGeneros_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }
    }
}
