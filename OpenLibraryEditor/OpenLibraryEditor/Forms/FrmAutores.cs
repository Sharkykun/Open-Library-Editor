using Microsoft.VisualBasic;
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
    public partial class FrmAutores : Form
    {
        #region atributos
        //private const string NOMBRE_OBJETO = "el autor";
        private string NOMBRE_OBJETO = ControladorIdioma.GetTexto("Au_ElAutor");
        private bool setNew;
        private Autor personaNueva;
        private List<Autor> listaPersona = Biblioteca.biblioteca.ListaAutor;
        private List<string> listaOcupacion = Biblioteca.biblioteca.ListaOcupacion;
        private Autor personaActual;
        private ListViewItem itemActual;
        private BindingSource ocupacionBinding = new BindingSource();

        private string rutaImagen;

        public Autor PersonaNueva { get => personaNueva; set => personaNueva = value; }
        #endregion
        public FrmAutores(bool setNew)
        {
            InitializeComponent();
            this.setNew = setNew;
        }

        private void MBtnCerrarAutores_Click(object sender, EventArgs e)
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
        private void PanTituloAutores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            //Cargar personas
            foreach (Autor p in listaPersona)
            {
                AniadirPersona(p);
            }

            //Vincular lista de ocupacion con Combobox
            ocupacionBinding.DataSource = listaOcupacion;
            KCmbOcupacionNA.DataSource = ocupacionBinding;

            if (setNew)
            {
                MBtnMasLsvNA_Click(null, null);
                personaNueva = personaActual;
            }
        }

        #region metodos propios

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
            TTAutores.SetToolTip(this.MBtnMenosOcupacionNA, ControladorIdioma.GetTexto("Au_BtnMenosOcu"));
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
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Aceptar");
            TTAutores.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Aceptar"));
            LblSigueVivo.Text = ControladorIdioma.GetTexto("Au_Vivo");
            TTAutores.SetToolTip(this.TBtnVivo, ControladorIdioma.GetTexto("Au_TTVivo"));
        }
        private void ActualizarOcupacion()
        {
            listaOcupacion.Sort();
            ocupacionBinding.ResetBindings(false);
            KCmbOcupacionNA.SelectedItem = personaActual.NombreOcupacion == "" ?
                    null : personaActual.NombreOcupacion;
        }

        private ListViewItem AniadirPersona(Autor persona)
        {
            var item = LsvAutoresNA.Items.Add(persona.Nombre);
            item.SubItems.Add(persona.NombreOcupacion);
            item.Tag = persona;
            if (personaActual == persona) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreAu.Text == personaActual.Nombre &&
                KTxtComentarioAu.Text == personaActual.Comentario &&
                KtxtAliasAu.Text == personaActual.Alias &&
                KTxtEnlaceAu.Text == personaActual.EnlaceReferencia &&
                rutaImagen == personaActual.Imagen &&
                KCmbOcupacionNA.Text == personaActual.NombreOcupacion &&
                KMtxtFecMuerteNA.Text == personaActual.FechaDefuncion.Date.ToShortDateString() &&
                KMtxtFecNacimientoNA.Text == personaActual.FechaNacimiento.Date.ToShortDateString())
                return false;
            else
                return true;
        }

        private void CargarImagen(string rutaImagen)
        {
            try
            {
                PcbAutorNA.Image = Image.FromFile(rutaImagen);
            }
            catch (FileNotFoundException)
            {
                PcbAutorNA.Image = PcbAutorNA.ErrorImage;
                //PcbAutorNA.Image = OpenLibraryEditor.Properties.Resources.silueta;
            }
            catch (ArgumentException)
            {
                //PcbAutorNA.Image = OpenLibraryEditor.Properties.Resources.silueta;
                PcbAutorNA.Image = PcbAutorNA.ErrorImage;
            }
        }

        private void ComprobarGuardado()
        {
            //Comparar objetos para preguntar si guardar
            if (personaActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                    GBtnAceptar_Click(null, null);
            }
        }
        #endregion
        private void LsvAutoresNA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                ComprobarGuardado();

            //Comprobar selección item
            if (e.IsSelected && LsvAutoresNA.SelectedItems.Count == 1)
            {
                PanOpcionesNA.Visible = true;
                itemActual = LsvAutoresNA.SelectedItems[0];
                personaActual = (Autor)itemActual.Tag;
                KTxtNombreAu.Text = personaActual.Nombre;
                KTxtComentarioAu.Text = personaActual.Comentario;
                KCmbOcupacionNA.SelectedItem = personaActual.NombreOcupacion == "" ?
                    null : personaActual.NombreOcupacion;
                KtxtAliasAu.Text = personaActual.Alias;
                KTxtEnlaceAu.Text = personaActual.EnlaceReferencia;
                rutaImagen = personaActual.Imagen;
                CargarImagen(rutaImagen);
                KMtxtFecMuerteNA.Text = personaActual.FechaDefuncion.Date.ToShortDateString();
                KMtxtFecNacimientoNA.Text = personaActual.FechaNacimiento.Date.ToShortDateString();
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
        }

        private void MBtnMenosLsvNA_Click(object sender, EventArgs e)
        {
            if (LsvAutoresNA.SelectedItems.Count == 1 &&
               VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                var item = LsvAutoresNA.SelectedItems[0];
                listaPersona.Remove(personaActual);
                LsvAutoresNA.Items.Remove(item);
            }
        }
       

        private void MBtnMasOcupacionNA_Click(object sender, EventArgs e)
        {
            FrmInputTxt input = new FrmInputTxt(null);
            if (KCmbOcupacionNA.SelectedItem != null)
            {
                input = new FrmInputTxt(KCmbOcupacionNA.SelectedItem.ToString());
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
                ActualizarOcupacion();
                KCmbOcupacionNA.SelectedItem = x;
            }
            else if (x == null)
            {
                listaOcupacion.Remove((string)KCmbOcupacionNA.SelectedItem);
                ActualizarOcupacion();
                KCmbOcupacionNA.SelectedItem = null;
            }
        }

        private void MBtnMenosOcupacionNA_Click(object sender, EventArgs e)
        {
            //if (VentanaWindowsComun.MensajeBorrarObjeto(personaActual.NombreOcupacion) == DialogResult.Yes)
            //{
            //    listaOcupacion.Remove((string)KCmbOcupacionNA.SelectedItem);
            //    ActualizarOcupacion();
            //    KCmbOcupacionNA.SelectedItem = null;
            //}
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
             PcbAutorNA.Image = PcbAutorNA.ErrorImage;
        }
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesNA.Visible == true)
            {
                if (!String.IsNullOrWhiteSpace(KTxtNombreAu.Text))
                {
                    //Actualizar persona
                    personaActual.Nombre = KTxtNombreAu.Text;
                    personaActual.NombreOcupacion = KCmbOcupacionNA.Text;
                    personaActual.Comentario = KTxtComentarioAu.Text;
                    personaActual.Alias = KtxtAliasAu.Text;
                    personaActual.EnlaceReferencia = KTxtEnlaceAu.Text;
                    personaActual.FechaDefuncion = DateTime.Parse(KMtxtFecMuerteNA.Text);
                    personaActual.FechaNacimiento = DateTime.Parse(KMtxtFecNacimientoNA.Text);
                    if (rutaImagen != personaActual.Imagen)
                    {
                        personaActual.Imagen = ControladorImagen.GuardarImagen(rutaImagen,
                            ControladorImagen.RUTA_PERSONA, personaActual.IdAutor.ToString());
                        rutaImagen = personaActual.Imagen;
                    }

                    //Actualizar listview
                    itemActual.Text = KTxtNombreAu.Text;
                    itemActual.SubItems[1].Text = KCmbOcupacionNA.Text;
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_NombreVacio"));
            }
        }

        private void FrmAutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }

      
    }
}
