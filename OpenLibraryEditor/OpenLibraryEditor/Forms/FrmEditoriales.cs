﻿using OpenLibraryEditor.Clases;
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
        //private const string NOMBRE_OBJETO = "la editorial";
        private string NOMBRE_OBJETO = ControladorIdioma.GetTexto("ED_LaEditorial");
        private List<Editorial> listaEditorial = Biblioteca.biblioteca.ListaEditorial;
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
        public FrmEditoriales(bool setNew, Editorial editorialActual)
        {
            InitializeComponent();
            this.setNew = setNew;
            this.editorialActual = editorialActual;
            EditarEditorialDesdeMain();
        }
        private void MBtnCerrarEditoriales_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmEditoriales_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
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
        private void EditarEditorialDesdeMain()
        {
            PanOpcionesED.Visible = true;
            KTxtNombreEd.Text = editorialActual.Nombre;
            KTxtComentarioEd.Text = editorialActual.Comentario;
            rutaImagen = editorialActual.Imagen;
            CargarImagen(rutaImagen);
        }
        private void IdiomaTexto()
        {
            LblTituloEditoriales.Text = ControladorIdioma.GetTexto("ED_TituloFrm");
            TTEditorial.SetToolTip(this.LblTituloEditoriales, ControladorIdioma.GetTexto("ED_TituloFrm"));
            TTEditorial.SetToolTip(this.LsvEditorialNE, ControladorIdioma.GetTexto("ED_Lsv"));
            LsvEditorialNE.Columns[0].Text = ControladorIdioma.GetTexto("ED_LsvNombre");
            TTEditorial.SetToolTip(this.MBtnMasLsvNE, ControladorIdioma.GetTexto("ED_TTLsvMas"));
            TTEditorial.SetToolTip(this.MBtnMenosLsvNE, ControladorIdioma.GetTexto("ED_TTLsvMenos"));
            LblNombreEd.Text = ControladorIdioma.GetTexto("ED_Nombre");
            TTEditorial.SetToolTip(this.KTxtNombreEd, ControladorIdioma.GetTexto("ED_TTNombre"));
            LblComentarioEd.Text = ControladorIdioma.GetTexto("ED_Comentario");
            TTEditorial.SetToolTip(this.KTxtComentarioEd, ControladorIdioma.GetTexto("ED_TTComentario"));
            TTEditorial.SetToolTip(this.PcbEditorialesEd, ControladorIdioma.GetTexto("ED_TTPcb"));
            TTEditorial.SetToolTip(this.MBtnAniadirImagenEd, ControladorIdioma.GetTexto("ED_TTMasImg"));
            TTEditorial.SetToolTip(this.MBtnBorrarImagenEd, ControladorIdioma.GetTexto("ED_TTMenosImg"));
            TTEditorial.SetToolTip(this.PcbLogoEditoriales, ControladorIdioma.GetTexto("Main_TTLogo"));
            GBtnCancelar.Text= ControladorIdioma.GetTexto("Cancelar");
            TTEditorial.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Guardar");
            TTEditorial.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Guardar"));
            TTEditorial.SetToolTip(this.MBtnCerrarEditoriales, ControladorIdioma.GetTexto("Cerrar"));
        }
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
                PcbEditorialesEd.Image = Properties.Resources.libros;
            }
            catch (ArgumentException)
            {
                PcbEditorialesEd.Image = Properties.Resources.libros;
            }
        }

        private void ComprobarGuardado()
        {
            //Comparar objetos para preguntar si guardar
            if (editorialActual != null && EsObjetoCambiado())
            {
                var result = VentanaWindowsComun.MensajeGuardarObjeto(NOMBRE_OBJETO);
                if (result == DialogResult.Yes) 
                {
                    GBtnAceptar_Click(null, null);
                }
                    
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
            if (!e.IsSelected)
                ComprobarGuardado();

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
            Editorial p = new Editorial(ControladorIdioma.GetTexto("ED_NuevaEdi"));
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
                VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO + ControladorIdioma.GetTexto("BorradoCorrectamente"));
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
            PcbEditorialesEd.Image = Properties.Resources.libros;
            rutaImagen = null;
        }
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            if (PanOpcionesED.Visible == true)
            {
                if (!String.IsNullOrWhiteSpace(KTxtNombreEd.Text))
                {
                    //Actualizar etiqueta
                    editorialActual.Nombre = KTxtNombreEd.Text;
                    editorialActual.Comentario = KTxtComentarioEd.Text;
                    if (rutaImagen != editorialActual.Imagen)
                    {
                        editorialActual.Imagen = ControladorImagen.GuardarImagen(rutaImagen,
                            ControladorImagen.RUTA_EDITORIAL, editorialActual.IdEditorial.ToString());
                        rutaImagen = editorialActual.Imagen;
                    }
                    else
                    {
                        string file = ControladorImagen.RUTA_BASE +
                        ControladorImagen.RUTA_EDITORIAL + editorialActual.IdEditorial.ToString();
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }
                    }

                    //Actualizar listview
                    itemActual.Text = KTxtNombreEd.Text;
                    VentanaWindowsComun.MensajeInformacion(NOMBRE_OBJETO + ControladorIdioma.GetTexto("GuardadoCorrectamente"));
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Error_NombreVacio"));
            }
        }
        private void FrmEditoriales_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }
    }
}
