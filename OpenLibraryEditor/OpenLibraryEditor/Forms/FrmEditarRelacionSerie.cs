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
    public partial class FrmEditarRelacionSerie : Form
    {
        #region atributos
        private RelacionSerie relacionTemp;
        private Serie serieOrigen;
        private Serie serieActual;
        private ListViewItem itemActual;
        private List<string> listaTipoRelacion = RelacionSerie.tipoRelacionLista;
        private BindingSource tipoBinding = new BindingSource();
        private bool esOk = false;
        private string rutaImagen;

        public bool EsOk { get => esOk; set => esOk = value; }
        #endregion
        public FrmEditarRelacionSerie(RelacionSerie relacion, ListView listView, Serie serie)
        {
            InitializeComponent();
            relacionTemp = relacion;
            serieOrigen = serie;
            foreach (ListViewItem i in listView.Items)
            {
                if (!((i.Tag as Serie) == serie))
                    LsvSeriesRS.Items.Add((ListViewItem)i.Clone());
            }

            //Vincular lista de ocupacion con Combobox
            tipoBinding.DataSource = listaTipoRelacion;
            KCmbtipoRelacionRS.DataSource = tipoBinding;
        }
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloRelacionSerie_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void MBtnCerrarReSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KBtnCancelarRS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region metodos propios
        private void CargarImagen(string rutaImagen)
        {
            try
            {
                PcbRS.Image = Image.FromFile(rutaImagen);
            }
            catch (FileNotFoundException)
            {
                //PcbRS.Image = OpenLibraryEditor.Properties.Resources.imagen;
                PcbRS.Image = PcbRS.ErrorImage;
            }
            catch (ArgumentException)
            {
                //PcbRS.Image = OpenLibraryEditor.Properties.Resources.imagen;
                PcbRS.Image = PcbRS.ErrorImage;
            }
        }

        private void ActualizarTipoRelacion()
        {
            listaTipoRelacion.Sort();
            tipoBinding.ResetBindings(false);
            KCmbtipoRelacionRS.SelectedItem = relacionTemp.NombreTipoRelacionSerie == "" ?
                    null : relacionTemp.NombreTipoRelacionSerie;
        }
        #endregion

        private void LsvSeriesRS_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Comprobar selección item
            if (e.IsSelected && LsvSeriesRS.SelectedItems.Count == 1)
            {
                itemActual = LsvSeriesRS.SelectedItems[0];
                serieActual = (Serie)itemActual.Tag;
                CargarImagen(serieActual.Imagen);
            }
            else
            {
                //Quitar imagen si no hay selección
                PcbRS.Image = null;
            }
        }

        private void MBtnMasRS_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Escribe el nombre del tipo de relación.",
                "Añadir Tipo de Relación", "", Location.X, Location.Y + 10);
            //Comprobar que no esté en blanco
            if (!String.IsNullOrWhiteSpace(x))
            {
                listaTipoRelacion.Add(x);
                ActualizarTipoRelacion();
                KCmbtipoRelacionRS.SelectedItem = x;
            }
        }

        private void MBtnMenosRS_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto("el tipo de relación") == DialogResult.Yes)
            {
                listaTipoRelacion.Remove((string)KCmbtipoRelacionRS.SelectedItem);
                ActualizarTipoRelacion();
                KCmbtipoRelacionRS.SelectedItem = null;
            }
        }

        private void MBtnAniadirImagenRS_Click(object sender, EventArgs e)
        {
            string s = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_IMAGEN);
            if (s != "")
            {
                rutaImagen = s;
                CargarImagen(rutaImagen);
            }
        }

        private void MBtnBorrarImagenRS_Click(object sender, EventArgs e)
        {
            PcbRS.Image = PcbRS.ErrorImage;
        }

        private void KBtnAceptarRS_Click(object sender, EventArgs e)
        {
            if (LsvSeriesRS.SelectedItems.Count == 1)
            {
                foreach (RelacionSerie i in serieActual.ListaRelacionSerie)
                {
                    if (i.Serie == serieOrigen)
                    {
                        VentanaWindowsComun.MensajeError("La relación con esta serie ya existe.");
                        return;
                    }
                }
            }

            if (!String.IsNullOrWhiteSpace(KCmbtipoRelacionRS.Text) &&
                LsvSeriesRS.SelectedItems.Count == 1)
            {
                relacionTemp.Serie = serieActual;
                relacionTemp.NombreTipoRelacionSerie = KCmbtipoRelacionRS.Text;
                esOk = true;
                Close();
            }
            else
            {
                VentanaWindowsComun.MensajeError("La relación debe tener una seríe y un tipo.");
            }
        }
    }
}
