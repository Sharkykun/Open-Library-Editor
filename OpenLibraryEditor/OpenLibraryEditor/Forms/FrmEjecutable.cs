﻿using OpenLibraryEditor.Clases;
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
        private const string NOMBRE_OBJETO = "el ejecutable";
        private bool setNew;
        private List<UsuarioEjecutable> listaEjecutable = Biblioteca.biblioteca.ListaEjecutable;
        private UsuarioEjecutable ejecutableActual;
        private ListViewItem itemActual;
        #endregion
        public FrmEjecutable(bool setNew)
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
        private void PanTituloEjecutables_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void MBtnCerrarEjecutable_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KBtnCancelarEJ_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #region metodos propios
        private void IdiomaTexto()
        {
            TTEjecutable.SetToolTip(this.PcbLogoEjecutable, ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloEjecutable.Text = ControladorIdioma.GetTexto("Ej_TituloFrm");
            TTEjecutable.SetToolTip(this.LblTituloEjecutable, ControladorIdioma.GetTexto("Ej_TituloFrm"));
            TTEjecutable.SetToolTip(this.LsvEjecutable, ControladorIdioma.GetTexto("Ej_TTLsv"));
            LsvEjecutable.Columns[0].Text = ControladorIdioma.GetTexto("Ej_LsvNombre");
            LsvEjecutable.Columns[1].Text = ControladorIdioma.GetTexto("Ej_LsvExtension");
            TTEjecutable.SetToolTip(this.MBtnMasLsvEJ, ControladorIdioma.GetTexto("Ej_TTMas"));
            TTEjecutable.SetToolTip(this.MBtnMenosLsvEJ, ControladorIdioma.GetTexto("Ej_TTMenos"));
            LblNombreEJ.Text = ControladorIdioma.GetTexto("Ej_Nombre");
            TTEjecutable.SetToolTip(this.KTxtNombreEJ, ControladorIdioma.GetTexto("Ej_TTNombre"));
            LblExtensionEJ.Text = ControladorIdioma.GetTexto("Ej_Extension");
            TTEjecutable.SetToolTip(this.KTxtExtensionEJ, ControladorIdioma.GetTexto("Ej_TTExtension"));
            LblRutaEJ.Text = ControladorIdioma.GetTexto("Ej_Ruta");
            TTEjecutable.SetToolTip(this.IBtnBuscarRutaEJ, ControladorIdioma.GetTexto("Ej_TTRuta"));
            LblArgumentosEJ.Text = ControladorIdioma.GetTexto("Ej_Argumentos");
            TTEjecutable.SetToolTip(this.KTxtArgumentosEJ, ControladorIdioma.GetTexto("Ej_TTArgumentos"));
            KBtnCancelarEJ.Text = ControladorIdioma.GetTexto("Cancelar");
            TTEjecutable.SetToolTip(this.KBtnCancelarEJ, ControladorIdioma.GetTexto("Cancelar"));
            KBtnAceptarEJ.Text = ControladorIdioma.GetTexto("Aceptar");
            TTEjecutable.SetToolTip(this.KBtnAceptarEJ, ControladorIdioma.GetTexto("Aceptar"));
            TTEjecutable.SetToolTip(this.MBtnCerrarEjecutable, ControladorIdioma.GetTexto("Cerrar"));
        }
        private ListViewItem AniadirEjecutable(UsuarioEjecutable ejecutable)
        {
            var item = LsvEjecutable.Items.Add(ejecutable.NombreEjecutable);
            item.SubItems.Add(ejecutable.ExtensionFichero);
            item.Tag = ejecutable;
            if (ejecutableActual == ejecutable) item.Selected = true;
            return item;
        }

        private bool EsObjetoCambiado()
        {
            //Comprobar si el objeto actual tiene algo cambiado
            if (KTxtNombreEJ.Text == ejecutableActual.NombreEjecutable &&
                KTxtExtensionEJ.Text == ejecutableActual.ExtensionFichero &&
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
                    KBtnAceptarEJ_Click(null, null);
            }
        }

        #endregion
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
                KTxtExtensionEJ.Text = ejecutableActual.ExtensionFichero;
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
            UsuarioEjecutable ej = new UsuarioEjecutable("Nuevo Ejecutable");
            listaEjecutable.Add(ej);
            var item = AniadirEjecutable(ej);
            item.Selected = true;
        }

        private void MBtnMenosLsvEJ_Click(object sender, EventArgs e)
        {
            if (LsvEjecutable.SelectedItems.Count == 1 &&
                VentanaWindowsComun.MensajeBorrarObjeto(NOMBRE_OBJETO) == DialogResult.Yes)
            {
                var item = LsvEjecutable.SelectedItems[0];
                listaEjecutable.Remove(ejecutableActual);
                LsvEjecutable.Items.Remove(item);
            }
        }

        private void IBtnBuscarRutaEJ_Click(object sender, EventArgs e)
        {
            KTxtRutaEJ.Text = VentanaWindowsComun.GetRutaFichero(VentanaWindowsComun.FILTRO_TODO);
        }

        private void KBtnAceptarEJ_Click(object sender, EventArgs e)
        {
            if (PanOpcionesEJ.Visible == true) { 
                if (String.IsNullOrWhiteSpace(KTxtNombreEJ.Text) &&
                    String.IsNullOrWhiteSpace(KTxtExtensionEJ.Text) &&
                    String.IsNullOrWhiteSpace(KTxtRutaEJ.Text))
                {
                    //Actualizar etiqueta
                    ejecutableActual.NombreEjecutable = KTxtNombreEJ.Text;
                    ejecutableActual.ExtensionFichero = KTxtExtensionEJ.Text;
                    ejecutableActual.RutaEjecutable = KTxtRutaEJ.Text;
                    ejecutableActual.Argumentos = KTxtArgumentosEJ.Text;

                    //Actualizar listview
                    itemActual.Text = KTxtNombreEJ.Text;
                    itemActual.SubItems[1].Text = KTxtExtensionEJ.Text;
                }
                else VentanaWindowsComun.MensajeError("El nombre, extensión y ruta no pueden estar vacíos.");
            }
        }

        private void FrmEjecutable_FormClosing(object sender, FormClosingEventArgs e)
        {
            ComprobarGuardado();
        }
    }
}
