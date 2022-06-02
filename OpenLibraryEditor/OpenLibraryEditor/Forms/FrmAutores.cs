using Microsoft.VisualBasic;
using OpenLibraryEditor.BaseDatos;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmAutores : Form
    {
        /*
         ToDo
         */

        #region atributos
        //private const string NOMBRE_OBJETO = "el autor";
        private string NOMBRE_OBJETO = ControladorIdioma.GetTexto("Au_ElAutor");
        private bool setNew;
        private Autor personaNueva;
        private List<Autor> listaPersona = Biblioteca.biblioteca.ListaAutor;
        private List<string> listaOcupacion = Biblioteca.biblioteca.ListaOcupacion;
        private Autor autorActual;
        private ListViewItem itemActual;
        private BindingSource ocupacionBinding = new BindingSource();

        private string rutaImagen;
        private bool puedeEditar;

        public Autor PersonaNueva { get => personaNueva; set => personaNueva = value; }
        #endregion
        #region constructores y load
        public FrmAutores(bool setNew)
        {
            InitializeComponent();
            this.setNew = setNew;
        }
        public FrmAutores(bool setNew, bool puedeEditar)
        {
            InitializeComponent();
            this.setNew = setNew;
            this.puedeEditar = puedeEditar;
        }
        public FrmAutores(bool setNew, Autor autorActual, bool puedeEditar)
        {
            InitializeComponent();
            this.setNew = setNew;
            this.autorActual = autorActual;
            this.puedeEditar = puedeEditar;
            
        }
        private void FrmAutores_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            //Cargar personas
            foreach (Autor p in listaPersona)
            {
                AniadirPersona(p);
            }

            //Vincular lista de ocupacion con Combobox
            //Limpiar objetos nulos o vacios si se cuela alguno
            listaOcupacion.RemoveAll(p => String.IsNullOrWhiteSpace(p));
            ocupacionBinding.DataSource = listaOcupacion;
            KCmbOcupacionNA.DataSource = ocupacionBinding;

            if (setNew)
            {
                MBtnMasLsvNA_Click(null, null);
                personaNueva = autorActual;
            }
            if (puedeEditar)
            {
                GBtnActualizar.Visible = true;
            }
            LsvAutoresNA_ItemSelectionChanged(null, null);
        }
        #endregion
        #region metodos propios
        //private void EditarAutorDesdeMain()
        //{
        //    PanOpcionesNA.Visible = true;
        //    KTxtNombreAu.Text = autorActual.Nombre;
        //    KTxtComentarioAu.Text = autorActual.Comentario;
        //    KCmbOcupacionNA.SelectedItem = String.IsNullOrWhiteSpace(autorActual.NombreOcupacion)
        //            ?
        //            null : autorActual.NombreOcupacion;
        //    KtxtAliasAu.Text = autorActual.Alias;
        //    KTxtEnlaceAu.Text = autorActual.EnlaceReferencia;
        //    rutaImagen = autorActual.Imagen;
        //    CargarImagen(rutaImagen);
        //    if (!autorActual.FechaDefuncion.Date.Equals(new DateTime()))
        //        KMtxtFecMuerteNA.Text = autorActual.FechaDefuncion.Date.ToShortDateString();
        //    if (!autorActual.FechaNacimiento.Date.Equals(new DateTime()))
        //        KMtxtFecNacimientoNA.Text = autorActual.FechaNacimiento.Date.ToShortDateString();
        //}
        private void IdiomaTexto()
        {
            LblTituloAutores.Text = ControladorIdioma.GetTexto("Au_TituloFrm");
            TTAutores.SetToolTip(this.LblTituloAutores, ControladorIdioma.GetTexto("Au_TituloFrm"));
            TTAutores.SetToolTip(this.LsvAutoresNA, ControladorIdioma.GetTexto("Au_TTLsv"));
            TTAutores.SetToolTip(this.MBtnMasLsvNA, ControladorIdioma.GetTexto("Au_TTBtnMasLsv"));
            TTAutores.SetToolTip(this.MBtnMenosLsvNA, ControladorIdioma.GetTexto("Au_TTBtnMenosLsv"));
            LsvAutoresNA.Columns[0].Text = ControladorIdioma.GetTexto("Au_LsvNombre");
            LsvAutoresNA.Columns[1].Text = ControladorIdioma.GetTexto("Au_Ocupacion");
            LblNombreNA.Text= ControladorIdioma.GetTexto("Au_Nombre");
            TTAutores.SetToolTip(this.KTxtNombreAu, ControladorIdioma.GetTexto("Au_TTNombre"));
            LblAliasAu.Text = ControladorIdioma.GetTexto("Au_Alias");
            TTAutores.SetToolTip(this.KtxtAliasAu, ControladorIdioma.GetTexto("Au_TTAlias"));
            LblOcupacionNA.Text = ControladorIdioma.GetTexto("Au_Ocupacion");
            TTAutores.SetToolTip(this.KCmbOcupacionNA, ControladorIdioma.GetTexto("Au_TTOcupacion"));
            TTAutores.SetToolTip(this.MBtnMasOcupacionNA, ControladorIdioma.GetTexto("Au_BtnMasOcu"));
            LblNacimientoAu.Text = ControladorIdioma.GetTexto("Au_FNac");
            TTAutores.SetToolTip(this.KMtxtFecNacimientoNA, ControladorIdioma.GetTexto("FormatoFecha"));
            LblDefuncionAu.Text = ControladorIdioma.GetTexto("Au_FDef");
            TTAutores.SetToolTip(this.KMtxtFecMuerteNA, ControladorIdioma.GetTexto("FormatoFecha"));
            LblEnlaceAu.Text = ControladorIdioma.GetTexto("Au_Enlace");
            TTAutores.SetToolTip(this.KTxtEnlaceAu, ControladorIdioma.GetTexto("Au_TTEnlace"));
            LblComentarioAu.Text = ControladorIdioma.GetTexto("Au_Comentario");
            TTAutores.SetToolTip(this.KTxtComentarioAu, ControladorIdioma.GetTexto("Au_TTComentario"));
            TTAutores.SetToolTip(this.MBtnAniadirImagenAu, ControladorIdioma.GetTexto("Au_MasImg"));
            TTAutores.SetToolTip(this.MBtnBorrarImagenAu, ControladorIdioma.GetTexto("Au_MenosImg"));
            TTAutores.SetToolTip(this.PcbAutorNA, ControladorIdioma.GetTexto("Au_Pcb"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTAutores.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Guardar");
            TTAutores.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Guardar"));
            LblSigueVivo.Text = ControladorIdioma.GetTexto("Au_Vivo");
            TTAutores.SetToolTip(this.TBtnVivo, ControladorIdioma.GetTexto("Au_TTVivo"));
            GBtnActualizar.Text = ControladorIdioma.GetTexto("ActualizarConBD");
            TTAutores.SetToolTip(this.GBtnActualizar,ControladorIdioma.GetTexto("Au_TTActualizar"));
            LblObligatorio.Text = ControladorIdioma.GetTexto("CamposObligatorios");
        }
        private void ActualizarOcupacion()
        {
            listaOcupacion.Sort();
            ocupacionBinding.ResetBindings(false);
            KCmbOcupacionNA.SelectedItem = autorActual.NombreOcupacion == "" ?
                    null : autorActual.NombreOcupacion;
        }

        private ListViewItem AniadirPersona(Autor persona)
        {
            var item = LsvAutoresNA.Items.Add(persona.Nombre);
            item.SubItems.Add(persona.NombreOcupacion);
            item.Tag = persona;
            if (autorActual == persona) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            string a = KMtxtFecMuerteNA.MaskCompleted ? KMtxtFecMuerteNA.Text
                : new DateTime().Date.ToShortDateString();
            string b = KMtxtFecNacimientoNA.MaskCompleted ? KMtxtFecNacimientoNA.Text
                : new DateTime().Date.ToShortDateString();
            string c = autorActual.NombreOcupacion == null ? ""
                : autorActual.NombreOcupacion;

            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreAu.Text == autorActual.Nombre &&
                KTxtComentarioAu.Text == autorActual.Comentario &&
                KtxtAliasAu.Text == autorActual.Alias &&
                KTxtEnlaceAu.Text == autorActual.EnlaceReferencia &&
                rutaImagen == autorActual.Imagen &&
                KCmbOcupacionNA.Text == c &&
                a == autorActual.FechaDefuncion.Date.ToShortDateString() &&
                b == autorActual.FechaNacimiento.Date.ToShortDateString())
                return false;
            else
                return true;    
        }

        private void CargarImagen(string rutaImagen)
        {
            try
            {
                PcbAutorNA.Image = ControladorImagen.ObtenerImagenStream(rutaImagen);
            }
            catch (FileNotFoundException)
            {
                //PcbAutorNA.Image = PcbAutorNA.ErrorImage;
                PcbAutorNA.Image = Properties.Resources.silueta;
            }
            catch (ArgumentException)
            {
                PcbAutorNA.Image = Properties.Resources.silueta;
                //PcbAutorNA.Image = PcbAutorNA.ErrorImage;
            }
        }

        private void ComprobarGuardado()
        {
            //Comparar objetos para preguntar si guardar
            if (autorActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                {
                    GBtnAceptar_Click(null, null);
                }
                    
            }
        }
        #endregion
        #region añadir/modificar autores
        private void LsvAutoresNA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e != null && !e.IsSelected)
                ComprobarGuardado();

            //Comprobar selección item
            if ((e == null || e.IsSelected) && LsvAutoresNA.SelectedItems.Count == 1)
            {
                PanOpcionesNA.Visible = true;
                itemActual = LsvAutoresNA.SelectedItems[0];
                autorActual = (Autor)itemActual.Tag;
                KTxtNombreAu.Text = autorActual.Nombre;
                KTxtComentarioAu.Text = autorActual.Comentario;
                if (String.IsNullOrWhiteSpace(autorActual.NombreOcupacion))
                {
                    KCmbOcupacionNA.SelectedItem = null;
                    KCmbOcupacionNA.Text = "";
                }
                else
                {
                    KCmbOcupacionNA.SelectedItem = autorActual.NombreOcupacion;
                    KCmbOcupacionNA.Text = autorActual.NombreOcupacion;
                }
                KtxtAliasAu.Text = autorActual.Alias;
                KTxtEnlaceAu.Text = autorActual.EnlaceReferencia;
                rutaImagen = autorActual.Imagen;
                CargarImagen(rutaImagen);
                if (!autorActual.FechaDefuncion.Date.Equals(new DateTime()))
                {
                    KMtxtFecMuerteNA.Text = autorActual.FechaDefuncion.Date.ToShortDateString();
                    TBtnVivo.Checked = false;
                }
                else
                {
                    TBtnVivo.Checked = true;
                    KMtxtFecMuerteNA.Text = "";
                }
                TBtnVivo_CheckedChanged(null, null);
                if (!autorActual.FechaNacimiento.Date.Equals(new DateTime()))
                    KMtxtFecNacimientoNA.Text = autorActual.FechaNacimiento.Date.ToShortDateString();
                else
                    KMtxtFecNacimientoNA.Text = "";
            }
            else
            {
                //Ocultar edición cuando no hay selección
                PanOpcionesNA.Visible = false;
            }
        }

        private void MBtnMasLsvNA_Click(object sender, EventArgs e)
        {
            Autor p = new Autor(ControladorIdioma.GetTexto("Au_NuevaPersona"));
            listaPersona.Add(p);
            var item = AniadirPersona(p);
            item.Selected = true;
            Biblioteca.biblioteca.GuardarJson();
        }

        private void MBtnMenosLsvNA_Click(object sender, EventArgs e)
        {
            if (LsvAutoresNA.SelectedItems.Count == 1 &&
               VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                //Actualizar en BD compartida si se puede
                if (ConexionBD.Conexion != null &&
                    UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario != "Usuario")
                {
                    if (VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_BorrarAutorBD"))
                        == DialogResult.Yes)
                    {
                        if (ConexionBD.AbrirConexion())
                        {
                            autorActual.BorraDeBDCompartida();
                            ConexionBD.CerrarConexion();
                            VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("BorradoOK"));
                        }
                    }
                }

                var item = LsvAutoresNA.SelectedItems[0];

                //Borrar de los libros que tienen referencia al objeto
                Biblioteca.biblioteca.ListaLibro.ForEach(p =>
                {
                    if (p.ListaAutor.Contains(autorActual))
                        p.ListaAutor.Remove(autorActual);
                });

                listaPersona.Remove(autorActual);
                LsvAutoresNA.Items.Remove(item);
                Biblioteca.biblioteca.GuardarJson();
                VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO+ControladorIdioma.GetTexto("BorradoCorrectamente"));
            }
            else
                VentanaWindowsComun.MensajeWarning(ControladorIdioma.GetTexto("SeleccionaAutor"));
        }
        private void MBtnMasOcupacionNA_Click(object sender, EventArgs e)
        {
            FrmInputTxt input = new FrmInputTxt(null);
            if (listaOcupacion.Contains(KCmbOcupacionNA.Text))
            {
                input = new FrmInputTxt(KCmbOcupacionNA.Text);
            }
            input.FormBorderStyle = FormBorderStyle.None;
            input.Text = "Ocupación";
            input.ShowDialog();
            string x = input.tipo;
            //Comprobar que no esté en blanco
            if (!String.IsNullOrWhiteSpace(x) && !input.editable)
            {
                listaOcupacion.Add(x);
                ActualizarOcupacion();
                KCmbOcupacionNA.SelectedItem = x;
            }
            else if (!String.IsNullOrWhiteSpace(x) && input.editable)
            {
                int i = listaOcupacion.IndexOf(KCmbOcupacionNA.SelectedItem.ToString());
                listaOcupacion[i] = x;
                listaPersona.ForEach(p =>
                {
                    if (p.NombreOcupacion == KCmbOcupacionNA.Text)
                        p.NombreOcupacion = x;
                });
                foreach (ListViewItem item in LsvAutoresNA.Items)
                {
                    if (item.SubItems[1].Text == KCmbOcupacionNA.Text)
                        item.SubItems[1].Text = x;
                }
                ActualizarOcupacion();
                KCmbOcupacionNA.SelectedItem = x;
            }
            else if (x == null)
            {
                listaOcupacion.Remove((string)KCmbOcupacionNA.SelectedItem);
                listaPersona.ForEach(p =>
                {
                    if (p.NombreOcupacion == KCmbOcupacionNA.Text)
                        p.NombreOcupacion = "";
                });
                foreach (ListViewItem item in LsvAutoresNA.Items)
                {
                    if (item.SubItems[1].Text == KCmbOcupacionNA.Text)
                        item.SubItems[1].Text = "";
                }
                ActualizarOcupacion();
                KCmbOcupacionNA.SelectedItem = null;
                KCmbOcupacionNA.Text = "";
            }
        }
        private void MBtnAniadirImagenAu_Click(object sender, EventArgs e)
        {
            string s = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_IMAGEN);
            if (s != "")
            {
                rutaImagen = s;
                CargarImagen(rutaImagen);
            }
        }

        private void MBtnBorrarImagenAu_Click(object sender, EventArgs e)
        {
            PcbAutorNA.Image = Properties.Resources.silueta;
            rutaImagen = null;
        }
        private void ActualizarListView()
        {
            //Actualizar listview
            itemActual.Text = autorActual.Nombre;
            itemActual.SubItems[1].Text = autorActual.NombreOcupacion;
        }

        private void KTxtNombreAu_Enter(object sender, EventArgs e)
        {
            if (KTxtNombreAu.Text.Equals(ControladorIdioma.GetTexto("Au_NuevaPersona")))
            {
                KTxtNombreAu.Text = "";
            }
        }

        private void KTxtNombreAu_Leave(object sender, EventArgs e)
        {
            if (KTxtNombreAu.Text.Equals(""))
            {
                KTxtNombreAu.Text = ControladorIdioma.GetTexto("Au_NuevaPersona");
            }
        }
        private void TBtnVivo_CheckedChanged(object sender, EventArgs e)
        {
            KMtxtFecMuerteNA.Enabled = !TBtnVivo.Checked;
        }
        #endregion
        #region botones aceptar y actualizar
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesNA.Visible == true)
            {
                if (!String.IsNullOrWhiteSpace(KTxtNombreAu.Text))
                {
                    //Actualizar persona
                    autorActual.Nombre = KTxtNombreAu.Text;
                    if (listaOcupacion.Contains(KCmbOcupacionNA.Text))
                        autorActual.NombreOcupacion = KCmbOcupacionNA.Text;
                    else
                        autorActual.NombreOcupacion = "";
                    autorActual.Comentario = KTxtComentarioAu.Text;
                    autorActual.Alias = KtxtAliasAu.Text;
                    autorActual.EnlaceReferencia = KTxtEnlaceAu.Text;
                    if (KMtxtFecMuerteNA.MaskCompleted && !TBtnVivo.Checked)
                    {
                        DateTime d = new DateTime();
                        DateTime.TryParse(KMtxtFecMuerteNA.Text, out d);
                        autorActual.FechaDefuncion = d;
                    }
                    else
                        autorActual.FechaDefuncion = new DateTime();
                    if (KMtxtFecNacimientoNA.MaskCompleted)
                    {
                        DateTime d = new DateTime();
                        DateTime.TryParse(KMtxtFecNacimientoNA.Text, out d);
                        autorActual.FechaNacimiento = d;
                    }
                    else
                        autorActual.FechaNacimiento = new DateTime();

                    if (rutaImagen != autorActual.Imagen)
                    {
                        //if (File.Exists(autorActual.Imagen))
                        //    File.Delete(autorActual.Imagen);
                        autorActual.Imagen = ControladorImagen.GuardarImagen(rutaImagen,
                            ControladorImagen.RUTA_PERSONA, autorActual.IdAutor.ToString());
                        rutaImagen = autorActual.Imagen;
                        CargarImagen(autorActual.Imagen);
                    }
                    else
                    {
                        string file = ControladorImagen.RUTA_BASE +
                            ControladorImagen.RUTA_PERSONA + autorActual.IdAutor.ToString();
                        if (File.Exists(file))
                            File.Delete(file);
                    }

                    //Actualizar en BD compartida si se puede
                    if (ConexionBD.Conexion != null &&
                        UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario != "Usuario")
                    {
                        if (VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_GuardarAutorBD"))
                            == DialogResult.Yes)
                        {
                            if (ConexionBD.AbrirConexion())
                            {
                                autorActual.MeterEnBDCompartida();
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
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_NombreVacio"));
            }
            else
                VentanaWindowsComun.MensajeWarning(ControladorIdioma.GetTexto("SeleccionaAutor"));
        }

     
        private void GBtnActualizar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesNA.Visible == true)
            {
                //Actualizar en BD compartida si se puede
                if (ConexionBD.Conexion != null)
                {
                    if (VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_ActualizarAutorBD"))
                        == DialogResult.Yes)
                    {
                        if (ConexionBD.AbrirConexion())
                        {
                            Autor autor = LecturaBD.SelectAutor(EscrituraBD.GetObjetoIdDeLocal(
                                autorActual.ListaIdCompartido));
                            ConexionBD.CerrarConexion();
                            if (autor != null)
                            {
                                autorActual.Nombre = autor.Nombre;
                                autorActual.Alias = autor.Alias;
                                autorActual.Comentario = autor.Comentario;
                                autorActual.EnlaceReferencia = autor.EnlaceReferencia;
                                autorActual.FechaDefuncion = autor.FechaDefuncion;
                                autorActual.FechaNacimiento = autor.FechaNacimiento;
                                autorActual.Imagen = autor.ImagenTemp == null ? null :
                                    ControladorImagen.RUTA_PERSONA + autorActual.IdAutor;
                                if (!String.IsNullOrWhiteSpace(autor.NombreOcupacion) &&
                                    !listaOcupacion.Contains(autor.NombreOcupacion))
                                    listaOcupacion.Add(autor.NombreOcupacion);
                                autorActual.NombreOcupacion = autor.NombreOcupacion;
                                if (autorActual.Imagen != null)
                                {
                                    //Thread.Sleep(10);
                                    File.Delete(autorActual.Imagen);
                                    File.WriteAllBytes(autorActual.Imagen, autor.ImagenTemp);
                                    CargarImagen(autorActual.Imagen);
                                }
                                ActualizarOcupacion();
                                LsvAutoresNA_ItemSelectionChanged(null, null);
                                ActualizarListView();
                                Biblioteca.biblioteca.GuardarJson();
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("DescargaOK"));
                            }
                            else
                                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("AutorNoExiste"));
                        }
                    }
                }
            }
            else
                VentanaWindowsComun.MensajeWarning(ControladorIdioma.GetTexto("SeleccionaAutor"));
        }
        #endregion
        #region cerrar formulario
        private void FrmAutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }

        private void MBtnCerrarAutores_Click(object sender, EventArgs e)
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
        private void PanTituloAutores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

      
    }
}
