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
    public partial class FrmSeries : Form
    {
        #region atributos
        private const string NOMBRE_OBJETO = "la serie";
        private bool setNew;
        private Serie serieNueva;
        private List<Serie> listaSerie = Biblioteca.biblioteca.ListaSerie;
        private Serie serieActual;
        private ListViewItem itemSerieActual;
        private List<RelacionSerie> listaTempRelacion;
        private RelacionSerie relacionActual;

        private string rutaImagen;

        public Serie SerieNueva { get => serieNueva; set => serieNueva = value; }
        #endregion
        public FrmSeries(bool setNew)
        {
            InitializeComponent();
            this.setNew = setNew;
        }

        private void MBtnCerrarSeries_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KBtnCancelarSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmSeries_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            //Cargar personas
            foreach (Serie s in listaSerie)
            {
                AniadirSerie(s);
            }

            if (setNew)
            {
                MBtnMasLsvNS_Click(null, null);
                serieNueva = serieActual;
            }
        }
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTituloSeries_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region metodos propios
        private void IdiomaTexto()
        {
            TTSeries.SetToolTip(this.PcbLogoSeries,ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloSeries.Text = ControladorIdioma.GetTexto("Se_TituloFrm");
            TTSeries.SetToolTip(this.LblTituloSeries, ControladorIdioma.GetTexto("Se_TituloFrm"));
            TTSeries.SetToolTip(this.LsvSeriesNS, ControladorIdioma.GetTexto("Se_TTLsv"));
            LsvSeriesNS.Columns[0].Text = ControladorIdioma.GetTexto("Se_LsvNombre");
            LsvSeriesNS.Columns[1].Text = ControladorIdioma.GetTexto("Se_Estado");
            TTSeries.SetToolTip(this.MBtnMasLsvNS, ControladorIdioma.GetTexto("Se_TTLsvMas"));
            TTSeries.SetToolTip(this.MBtnMenosLsvNS, ControladorIdioma.GetTexto("Se_TTLsvMenos"));
            LblNombreSe.Text = ControladorIdioma.GetTexto("Se_Nombre");
            TTSeries.SetToolTip(this.KTxtNombreSe, ControladorIdioma.GetTexto("Se_TTNombre"));
            LblEstadoSe.Text = ControladorIdioma.GetTexto("Se_Estado");
            TTSeries.SetToolTip(this.KCmbEstadoSe, ControladorIdioma.GetTexto("Se_TTEstado"));
            LblComentarioSe.Text = ControladorIdioma.GetTexto("Se_Comentario");
            TTSeries.SetToolTip(this.KTxtComentarioSe, ControladorIdioma.GetTexto("Se_TTComentario"));
            LblImagenSerieNS.Text = ControladorIdioma.GetTexto("Se_Imagen");
            TTSeries.SetToolTip(this.PcbSerieNS, ControladorIdioma.GetTexto("Se_TTPcb"));
            TTSeries.SetToolTip(this.MBtnAniadirImagenSe, ControladorIdioma.GetTexto("Se_TTMasImg"));
            TTSeries.SetToolTip(this.MBtnBorrarImagenSe, ControladorIdioma.GetTexto("Se_TTMenosImg"));
            KGbRelacionesNS.Values.Heading = ControladorIdioma.GetTexto("Se_Relaciones");
            LsvRelacionSeriesNS.Columns[0].Text = ControladorIdioma.GetTexto("Se_RLsvSerie");
            LsvRelacionSeriesNS.Columns[1].Text = ControladorIdioma.GetTexto("Se_RLsvTipo");
            TTSeries.SetToolTip(this.MBtnMasRelacionNS, ControladorIdioma.GetTexto("Se_RMas"));
            TTSeries.SetToolTip(this.MBtnMenosRelacionNS, ControladorIdioma.GetTexto("Se_RMenos"));
            MBtnEditarRS.Text = ControladorIdioma.GetTexto("Se_REditar");
            TTSeries.SetToolTip(this.MBtnEditarRS, ControladorIdioma.GetTexto("Se_RTTEditar"));
            KBtnCancelarSe.Text = ControladorIdioma.GetTexto("Cancelar");
            TTSeries.SetToolTip(this.KBtnCancelarSe, ControladorIdioma.GetTexto("Cancelar"));
            KBtnAceptarSe.Text = ControladorIdioma.GetTexto("Aceptar");
            TTSeries.SetToolTip(this.KBtnAceptarSe, ControladorIdioma.GetTexto("Aceptar"));
            TTSeries.SetToolTip(this.MBtnCerrarSeries, ControladorIdioma.GetTexto("Cerrar"));
        }
        private ListViewItem AniadirSerie(Serie serie)
        {
            var item = LsvSeriesNS.Items.Add(serie.Nombre);
            item.SubItems.Add(serie.Estado);
            item.Tag = serie;
            if (serieActual == serie) item.Selected = true;
            return item;
        }

        private ListViewItem AniadirRelacion(RelacionSerie relacion)
        {
            var item = LsvRelacionSeriesNS.Items.Add(relacion.Serie.Nombre);
            item.SubItems.Add(relacion.NombreTipoRelacionSerie);
            item.Tag = relacion;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si las relaciones actuales tienen algo cambiado
            foreach (RelacionSerie relacion in listaTempRelacion)
            {
                if (!serieActual.ListaRelacionSerie.Any(p => p.Equals(relacion)))
                    return true;
            }

            //Comprobar si serie actual tiene algo cambiado
            if (KTxtNombreSe.Text == serieActual.Nombre &&
                KTxtComentarioSe.Text == serieActual.Comentario &&
                rutaImagen == serieActual.Imagen &&
                KCmbEstadoSe.Text == serieActual.Estado)
                return false;
            else
                return true;
        }

        private void CargarImagen(string rutaImagen)
        {
            try
            {
                PcbSerieNS.Image = Image.FromFile(rutaImagen);
            }
            catch (FileNotFoundException)
            {
                PcbSerieNS.Image = PcbSerieNS.ErrorImage;
                //PcbSerieNS.Image = OpenLibraryEditor.Properties.Resources.imagen;
            }
            catch (ArgumentException)
            {
                //PcbSerieNS.Image = OpenLibraryEditor.Properties.Resources.imagen;
                PcbSerieNS.Image = PcbSerieNS.ErrorImage;
            }
        }

        private void ComprobarGuardado()
        {
            //Comparar objetos para preguntar si guardar
            if (serieActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes)
                    KBtnAceptarSe_Click(null, null);
            }
        }

        private FrmEditarRelacionSerie CrearFormularioRelacion(RelacionSerie relacion)
        {
            FrmEditarRelacionSerie form = new FrmEditarRelacionSerie(relacion, LsvSeriesNS, serieActual);
            form.FormBorderStyle = FormBorderStyle.None;
            form.ShowDialog();
            return form;
        }

        #endregion
       

        private void LsvSeriesNS_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                ComprobarGuardado();

            //Comprobar selección item
            if (e.IsSelected && LsvSeriesNS.SelectedItems.Count == 1)
            {
                PanOpcionesSE.Visible = true;
                itemSerieActual = LsvSeriesNS.SelectedItems[0];
                serieActual = (Serie)itemSerieActual.Tag;
                KTxtNombreSe.Text = serieActual.Nombre;
                KTxtComentarioSe.Text = serieActual.Comentario;
                KCmbEstadoSe.SelectedItem = serieActual.Estado == "" ?
                    null : serieActual.Estado;
                rutaImagen = serieActual.Imagen;
                CargarImagen(rutaImagen);

                //Cargar relaciones para editar
                LsvRelacionSeriesNS.Items.Clear();
                listaTempRelacion = new List<RelacionSerie>();
                foreach (RelacionSerie rel in serieActual.ListaRelacionSerie)
                    listaTempRelacion.Add(rel.Copy());
            }
            else
            {
                //Ocultar edición cuando no hay selección
                PanOpcionesSE.Visible = false;
            }
        }

        private void MBtnMasLsvNS_Click(object sender, EventArgs e)
        {
            //Aqui salta un error de que no puede ser 0
            Serie s = new Serie("Nueva Serie", KCmbEstadoSe.Items[0].ToString());
            listaSerie.Add(s);
            var item = AniadirSerie(s);
            item.Selected = true;
        }

        private void MBtnMenosLsvNS_Click(object sender, EventArgs e)
        {
            if (LsvSeriesNS.SelectedItems.Count == 1 &&
              VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                //Borrar relaciones
                foreach (RelacionSerie rel in serieActual.ListaRelacionSerie)
                {
                    int i = rel.Serie.ListaRelacionSerie.FindIndex(p => p.Serie == serieActual);
                    rel.Serie.ListaRelacionSerie.RemoveAt(i);
                }

                //Borrar serie
                var item = LsvSeriesNS.SelectedItems[0];
                listaSerie.Remove(serieActual);
                LsvSeriesNS.Items.Remove(item);
            }
        }

        private void MBtnAniadirImagenSe_Click(object sender, EventArgs e)
        {
            string s = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_IMAGEN);
            if (s != "")
            {
                rutaImagen = s;
                CargarImagen(rutaImagen);
            }
        }

        private void MBtnBorrarImagenSe_Click(object sender, EventArgs e)
        {
            PcbSerieNS.Image = PcbSerieNS.ErrorImage;
        }

        private void LsvRelacionSeriesNS_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item != null)
            {
                relacionActual = (RelacionSerie)e.Item.Tag;
            }
        }

        private void MBtnMasRelacionNS_Click(object sender, EventArgs e)
        {
            RelacionSerie relacion = new RelacionSerie();
            FrmEditarRelacionSerie f = CrearFormularioRelacion(relacion);
            if (f.EsOk)
            {
                listaTempRelacion.Add(relacion);
                var item = AniadirRelacion(relacion);
                item.Selected = true;
            }
        }

        private void MBtnMenosRelacionNS_Click(object sender, EventArgs e)
        {
            if (LsvRelacionSeriesNS.SelectedItems.Count == 1 &&
               VentanaWindowsComun.MensajeBorrarObjeto("la relación") == DialogResult.Yes)
            {
                int i = relacionActual.Serie.ListaRelacionSerie.FindIndex(p => p.Serie == serieActual);
                relacionActual.Serie.ListaRelacionSerie.RemoveAt(i);
            }
        }
        private void MBtnEditarRS_Click(object sender, EventArgs e)
        {
            RelacionSerie relacion = new RelacionSerie();
            FrmEditarRelacionSerie f = CrearFormularioRelacion(relacion);
            if (f.EsOk)
            {
                relacionActual.Serie = relacion.Serie;
                relacionActual.NombreTipoRelacionSerie = relacion.NombreTipoRelacionSerie;
            }
        }
        private void KBtnAceptarSe_Click(object sender, EventArgs e)
        {
            if (PanOpcionesSE.Visible == true) {
                if (!String.IsNullOrWhiteSpace(KTxtNombreSe.Text))
                {
                    //Actualizar serie
                    serieActual.Nombre = KTxtNombreSe.Text;
                    serieActual.Estado = KCmbEstadoSe.Text;
                    serieActual.Comentario = KTxtComentarioSe.Text;
                    serieActual.ListaRelacionSerie = listaTempRelacion;
                    if (rutaImagen != serieActual.Imagen)
                    {
                        serieActual.Imagen = ControladorImagen.GuardarImagen(rutaImagen,
                            ControladorImagen.RUTA_SERIE, serieActual.IdSerie.ToString());
                        rutaImagen = serieActual.Imagen;
                    }

                    //Actualizar listview
                    itemSerieActual.Text = KTxtNombreSe.Text;
                    itemSerieActual.SubItems[1].Text = KCmbEstadoSe.Text;
                }
                else
                    VentanaWindowsComun.MensajeError("El nombre no puede estar vacío.");
            }
        }

        private void FrmSeries_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }
    }
}
