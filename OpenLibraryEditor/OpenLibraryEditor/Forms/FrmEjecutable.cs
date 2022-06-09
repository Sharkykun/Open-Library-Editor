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
    public partial class FrmEjecutable : Form
    {
        #region atributos
        private string NOMBRE_OBJETO = ControladorIdioma.GetTexto("Ej_ElEjecutable");
        private bool setNew;
        private List<UsuarioEjecutable> listaEjecutable = Biblioteca.biblioteca.ListaEjecutable;
        private UsuarioEjecutable ejecutableActual;
        private ListViewItem itemActual;
        #endregion
        #region constructor y load
        public FrmEjecutable(bool setNew)
        {
            InitializeComponent();
            this.setNew = setNew;
        }
        private void FrmEjecutable_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            //Cargar etiquetas
            foreach (UsuarioEjecutable ej in listaEjecutable)
            {
                AniadirEjecutable(ej);
            }

            if (setNew)
                MBtnMasLsvEJ_Click(null, null);

        }
        #endregion
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloEjecutables_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region metodos propios
        private void IdiomaTexto()
        {
            TTEjecutable.SetToolTip(this.PcbLogoEjecutable, ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloEjecutable.Text = ControladorIdioma.GetTexto("Ej_TituloFrm");
            this.Text= ControladorIdioma.GetTexto("Ej_TituloFrm");
            TTEjecutable.SetToolTip(this.LblTituloEjecutable, ControladorIdioma.GetTexto("Ej_TituloFrm"));
            TTEjecutable.SetToolTip(this.LsvEjecutable, ControladorIdioma.GetTexto("Ej_TTLsv"));
            LsvEjecutable.Columns[0].Text = ControladorIdioma.GetTexto("Ej_LsvNombre");
            //LsvEjecutable.Columns[1].Text = ControladorIdioma.GetTexto("Ej_LsvExtension");
            TTEjecutable.SetToolTip(this.MBtnMasLsvEJ, ControladorIdioma.GetTexto("Ej_TTMas"));
            TTEjecutable.SetToolTip(this.MBtnMenosLsvEJ, ControladorIdioma.GetTexto("Ej_TTMenos"));
            LblNombreEJ.Text = ControladorIdioma.GetTexto("Ej_Nombre");
            TTEjecutable.SetToolTip(this.KTxtNombreEJ, ControladorIdioma.GetTexto("Ej_TTNombre"));
            LblRutaEJ.Text = ControladorIdioma.GetTexto("Ej_Ruta");
            TTEjecutable.SetToolTip(this.IBtnBuscarRutaEJ, ControladorIdioma.GetTexto("Ej_TTRuta"));
            LblArgumentosEJ.Text = ControladorIdioma.GetTexto("Ej_Argumentos");
            TTEjecutable.SetToolTip(this.KTxtArgumentosEJ, ControladorIdioma.GetTexto("Ej_TTArgumentos"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTEjecutable.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Guardar");
            TTEjecutable.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Guardar"));
            TTEjecutable.SetToolTip(this.MBtnCerrarEjecutable, ControladorIdioma.GetTexto("Cerrar"));
        }
        private ListViewItem AniadirEjecutable(UsuarioEjecutable ejecutable)
        {
            var item = LsvEjecutable.Items.Add(ejecutable.NombreEjecutable);
            item.Tag = ejecutable;
            if (ejecutableActual == ejecutable) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreEJ.Text == ejecutableActual.NombreEjecutable &&
                KTxtRutaEJ.Text == ejecutableActual.RutaEjecutable &&
                KTxtArgumentosEJ.Text == ejecutableActual.Argumentos)
                return false;
            else
                return true;
        }

        private void ComprobarGuardado()
        {
            //Comparar objetos para preguntar si guardar
            if (ejecutableActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                    GBtnAceptar_Click(null, null);
            }
        }
        private void KTxtNombreEJ_Enter(object sender, EventArgs e)
        {
            if (KTxtNombreEJ.Text.Equals(ControladorIdioma.GetTexto("Ej_NuevoEjecutable")))
            {
                KTxtNombreEJ.Text = "";
            }
        }

        private void KTxtNombreEJ_Leave(object sender, EventArgs e)
        {
            if (KTxtNombreEJ.Text.Equals(""))
            {
                KTxtNombreEJ.Text = ControladorIdioma.GetTexto("Ej_NuevoEjecutable");
            }
        }

        #endregion
        #region listview
        private void LsvEjecutable_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                ComprobarGuardado();

            //Comprobar selección item
            if (e.IsSelected && LsvEjecutable.SelectedItems.Count == 1)
            {
                PanOpcionesEJ.Visible = true;
                itemActual = LsvEjecutable.SelectedItems[0];
                ejecutableActual = (UsuarioEjecutable)itemActual.Tag;
                KTxtNombreEJ.Text = ejecutableActual.NombreEjecutable;
                KTxtRutaEJ.Text = ejecutableActual.RutaEjecutable;
                KTxtArgumentosEJ.Text = ejecutableActual.Argumentos;
            }
            else
            {
                //Ocultar edición cuando no hay selección
                PanOpcionesEJ.Visible = false;
            }
        }

        private void MBtnMasLsvEJ_Click(object sender, EventArgs e)
        {
            UsuarioEjecutable ej = new UsuarioEjecutable(ControladorIdioma.GetTexto("Ej_NuevoEjecutable"));
            listaEjecutable.Add(ej);
            var item = AniadirEjecutable(ej);
            item.Selected = true;
        }

        private void MBtnMenosLsvEJ_Click(object sender, EventArgs e)
        {
            //VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO)
            if (LsvEjecutable.SelectedItems.Count == 1 &&
                VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                //Quitar referencias a ejecutable en otros libros y sus acciones
                Biblioteca.biblioteca.ListaLibro.ForEach(p =>
                {
                    p.ListaAccion.ForEach(s =>
                    {
                        if (s.Ejecutable == ejecutableActual)
                            s.Ejecutable = null;
                    });
                });

                var item = LsvEjecutable.SelectedItems[0];
                listaEjecutable.Remove(ejecutableActual);
                LsvEjecutable.Items.Remove(item);
                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("EjecutableBorradoOK"));
            }
        }
        #endregion
        #region ruta ejecutable
        private void IBtnBuscarRutaEJ_Click(object sender, EventArgs e)
        {
            KTxtRutaEJ.Text = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_TODO);
        }
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesEJ.Visible == true) { 
                if (!String.IsNullOrWhiteSpace(KTxtNombreEJ.Text) &&
                    !String.IsNullOrWhiteSpace(KTxtRutaEJ.Text))
                {
                    //Actualizar etiqueta
                    ejecutableActual.NombreEjecutable = KTxtNombreEJ.Text;
                    ejecutableActual.RutaEjecutable = KTxtRutaEJ.Text;
                    ejecutableActual.Argumentos = KTxtArgumentosEJ.Text;

                    //Actualizar listview
                    itemActual.Text = KTxtNombreEJ.Text;
                    VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("EjecutableGuardadoOK"));
                }
                else VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_CamposVacios"));
            }
        }
        #endregion
        #region cerrar formulario
        private void MBtnCerrarEjecutable_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmEjecutable_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }
        #endregion

     
    }
}
