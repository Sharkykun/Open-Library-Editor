using OpenLibraryEditor.BaseDatos;
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
        /*
         TODO:
         - Corregir problema de quitar genero padre al borrarlo en los hijos. Se descuadra, y pregunta si quieres guardar en cada uno que cambia
         */
        #region atributos
        private string NOMBRE_OBJETO = ControladorIdioma.GetTexto("Ge_Gen");
        private bool setNew;
        private Genero generoNuevo;
        private List<Genero> listaGenero = Biblioteca.biblioteca.ListaGenero;
        private Genero generoActual;
        private ListViewItem itemActual;
        private BindingSource generoBinding = new BindingSource();
        private bool puedeEditar;

        public Genero GeneroNuevo { get => generoNuevo; set => generoNuevo = value; }
        #endregion
        #region constructores y load
        public FrmGeneros(bool setNew)
        {
            InitializeComponent();
            this.setNew=setNew;
        }
        public FrmGeneros(bool setNew, bool puedeEditar)
        {
            InitializeComponent();
            this.setNew = setNew;
            this.puedeEditar = puedeEditar;
        }
        public FrmGeneros(bool setNew, Genero generoActual, bool puedeEditar)
        {
            InitializeComponent();
            this.setNew = setNew;
            this.generoActual = generoActual;
            this.puedeEditar = puedeEditar;
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
            //KCmbGeneroPadreGe.DataSource = generoBinding;

            if (setNew)
            {
                MBtnMasLsvNG_Click(null, null);
                generoNuevo = generoActual;
            }
            if (puedeEditar)
            {
                GBtnActualizar.Visible = true;
            }
        }
        #endregion
        #region metodos propios
        private void EditarGeneroDesdeMain()
        {
            PanOpcionesGE.Visible = true;
            KTxtNombreGe.Text = generoActual.Nombre;
            KTxtComentarioGe.Text = generoActual.Comentario;
        }
        private void IdiomaTexto()
        {
            TTGeneros.SetToolTip(this.PcbLogoGeneros,ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloGeneros.Text = ControladorIdioma.GetTexto("Ge_TituloFrm");
            TTGeneros.SetToolTip(this.LblTituloGeneros, ControladorIdioma.GetTexto("Ge_TituloFrm"));
            TTGeneros.SetToolTip(this.LsvGeneroNG, ControladorIdioma.GetTexto("Ge_TTLsv"));
            LsvGeneroNG.Columns[0].Text = ControladorIdioma.GetTexto("Ge_LsvNombre");
            TTGeneros.SetToolTip(this.MBtnMasLsvNG, ControladorIdioma.GetTexto("Ge_TTMas"));
            TTGeneros.SetToolTip(this.MBtnMenosLsvNG, ControladorIdioma.GetTexto("Ge_TTMenos"));
            LblNombreGe.Text = ControladorIdioma.GetTexto("Ge_Nombre");
            TTGeneros.SetToolTip(this.KTxtNombreGe, ControladorIdioma.GetTexto("Ge_TTNombre"));
            LblComentarioGe.Text = ControladorIdioma.GetTexto("Ge_Comentario");
            TTGeneros.SetToolTip(this.KTxtComentarioGe, ControladorIdioma.GetTexto("Ge_TTComentario"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTGeneros.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Guardar");
            TTGeneros.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Guardar"));
            TTGeneros.SetToolTip(this.MBtnCerrarGeneros, ControladorIdioma.GetTexto("Cerrar"));
            LblObligatorio.Text = ControladorIdioma.GetTexto("CamposObligatorios");
            GBtnActualizar.Text = ControladorIdioma.GetTexto("ActualizarConBD");
            TTGeneros.SetToolTip(this.GBtnActualizar, ControladorIdioma.GetTexto("Au_TTActualizar"));
        }
        
        private ListViewItem AniadirGenero(Genero genero)
        {
            var item = LsvGeneroNG.Items.Add(genero.Nombre);
            item.Tag = genero;
            if (generoActual == genero) item.Selected = true;
            return item;

        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreGe.Text == generoActual.Nombre &&
                KTxtComentarioGe.Text == generoActual.Comentario)
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
        #region añadir/modificar género
        private void LsvGeneroNG_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e != null && !e.IsSelected)
                ComprobarGuardado();

            //Comprobar selección item
            if ((e == null || e.IsSelected) && LsvGeneroNG.SelectedItems.Count == 1)
            {
                PanOpcionesGE.Visible = true;
                itemActual = LsvGeneroNG.SelectedItems[0];
                generoActual = (Genero)itemActual.Tag;
                KTxtNombreGe.Text = generoActual.Nombre;
                KTxtComentarioGe.Text = generoActual.Comentario;
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
            Biblioteca.biblioteca.GuardarJson();
        }

        private void MBtnMenosLsvNG_Click(object sender, EventArgs e)
        {
            if (LsvGeneroNG.SelectedItems.Count == 1 &&
               VentanaWindowsComun.MensajeBorrarObjeto(ControladorIdioma.GetTexto("Ge_Gen")) == DialogResult.Yes)
            {
                //Actualizar en BD compartida si se puede
                if (ConexionBD.Conexion != null &&
                    UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario != "Usuario")
                {
                    if (VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_BorrarGeneroBD"))
                        == DialogResult.Yes)
                    {
                        if (ConexionBD.AbrirConexion())
                        {
                            if (generoActual.BorraDeBDCompartida())
                            {
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("BorradoOK"));
                            }
                            ConexionBD.CerrarConexion();
                        }
                    }
                }

                var item = LsvGeneroNG.SelectedItems[0];

                //Borrar de los libros que tienen referencia al objeto
                Biblioteca.biblioteca.ListaLibro.ForEach(p =>
                {
                    if (p.ListaGenero.Contains(generoActual))
                        p.ListaGenero.Remove(generoActual);
                });

                listaGenero.Remove(generoActual);
                LsvGeneroNG.Items.Remove(item);
                Biblioteca.biblioteca.GuardarJson();
                VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO + ControladorIdioma.GetTexto("BorradoCorrectamente"));
            }
            else
                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("SeleccionaGenero"));
        }
        private void KTxtNombreGe_Enter(object sender, EventArgs e)
        {
            if (KTxtNombreGe.Text.Equals(ControladorIdioma.GetTexto("Ge_NuevoGen")))
            {
                KTxtNombreGe.Text = "";
            }
        }

        private void KTxtNombreGe_Leave(object sender, EventArgs e)
        {
            if (KTxtNombreGe.Text.Equals(""))
            {
                KTxtNombreGe.Text = ControladorIdioma.GetTexto("Ge_NuevoGen");
            }
        }
        #endregion
        #region botones aceptar y actualizar
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesGE.Visible == true)
            {
                if (!String.IsNullOrWhiteSpace(KTxtNombreGe.Text))
                {
                    //Actualizar etiqueta
                    generoActual.Nombre = KTxtNombreGe.Text;
                    generoActual.Comentario = KTxtComentarioGe.Text;

                    //Actualizar en BD compartida si se puede
                    if (ConexionBD.Conexion != null &&
                        UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario != "Usuario")
                    {
                        if (VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_GuardarGeneroBD"))
                            == DialogResult.Yes)
                        {
                            if (ConexionBD.AbrirConexion())
                            {
                               generoActual.MeterEnBDCompartida();
                                ConexionBD.CerrarConexion();
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("GuardadoOK"));
                            }
                        }
                    }

                    ActualizarListView();
                    Biblioteca.biblioteca.GuardarJson();
                    VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO + ControladorIdioma.GetTexto("GuardadoCorrectamente"));

                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_Genero"));
            }
            else
                VentanaWindowsComun.MensajeWarning(ControladorIdioma.GetTexto("SeleccionaGenero"));
        }


        private void GBtnActualizar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesGE.Visible == true)
            {
                //Actualizar en BD compartida si se puede
                if (ConexionBD.Conexion != null)
                {

                    if (VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_ActualizarGeneroBD"))
                        == DialogResult.Yes)
                    {
                        if (ConexionBD.AbrirConexion())
                        {
                            Genero genero = LecturaBD.SelectGenero(EscrituraBD.GetObjetoIdDeLocal(
                                generoActual.ListaIdCompartido));
                            ConexionBD.CerrarConexion();
                            generoActual.Comentario = genero.Comentario;
                            generoActual.Nombre = genero.Nombre;
                            LsvGeneroNG_ItemSelectionChanged(null, null);
                            ActualizarListView();
                            Biblioteca.biblioteca.GuardarJson();
                            VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("DescargaOK"));
                        }
                    }
                }
            }
            else
                VentanaWindowsComun.MensajeWarning(ControladorIdioma.GetTexto("SeleccionaGenero"));
        }
        private void ActualizarListView()
        {
            //Actualizar listview
            itemActual.Text = KTxtNombreGe.Text;
        }
        #endregion
        #region cerrar formulario

        private void FrmGeneros_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }
        private void MBtnCerrarGeneros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
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
    }
}
