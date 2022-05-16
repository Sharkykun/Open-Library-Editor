﻿using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmAdministrarUsuarios : Form
    {
        /*TODO:
        - Añadir texto de idioma al boton editar.
        - Cargar usuarios reales desde BD compartida.
        - Hacer comprobaciones con la BD compartida para verificar si mostrar 
        el boton editar (ver si eres administrador o no). Aplicar para que el usuario conectado pueda editarse a si mismo la contraseña, pero no el tipo.
         */
        private List<InfoUsuarioBD> listaUsuarios = new List<InfoUsuarioBD>();
        private List<InfoUsuarioBD> listaUsuariosFiltrada;
        private InfoUsuarioBD usuarioActual;
        private bool esReverso = false;

        public FrmAdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void ObtenerUsuariosBD()
        {
            if (ConexionBD.conexion != null)
            {
                ConexionBD.AbrirConexion();
                listaUsuarios = LecturaBD.SelectUsuariosLista();
                ConexionBD.CerrarConexion();
            }
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            KCmbBuscarPorUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Nombre"));
            KCmbBuscarPorUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Email"));
            KCmbBuscarPorUsu.Items.Add(ControladorIdioma.GetTexto("Adm_CmbTipo"));
            KCmbBuscarPorUsu.SelectedIndex = 0;

            KCmbTipoUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Editor"));
            KCmbTipoUsu.Items.Add(ControladorIdioma.GetTexto("Adm_Usu"));
            KCmbTipoUsu.Items.Add("Administrador");

            //Recoger usuarios de BD compartida
            ObtenerUsuariosBD();

            //Si el usuario es administrador, mostrar botones para editar
            if (UsuarioDatos.configuracionUsuario.EsAdministrador)
            {
                MBtnMasUsu.Visible = true;
                MBtnEditarUsu.Visible = true;
                MBtnMenosUsu.Visible = true;
            }

            //Colocar usuarios por nombre
            listaUsuarios.Sort();
            ColocarUsuarios(listaUsuarios);
        }

        private void IdiomaTexto()
        {
            LblTituloFormAbierto.Text = ControladorIdioma.GetTexto("Adm_FrmTitulo");
            LblBuscarPor.Text= ControladorIdioma.GetTexto("BuscarPor");
            KgbDatosUsuario.Values.Heading = ControladorIdioma.GetTexto("Adm_DatosUsu");
            LblNombreUsu.Text = ControladorIdioma.GetTexto("Adm_NombreUsu");
            LblEmail.Text= ControladorIdioma.GetTexto("Reg_Email");
            //LblContra.Text= ControladorIdioma.GetTexto("Reg_Contra");
            LblTipoUsu.Text = ControladorIdioma.GetTexto("Adm_Tipo");
        }

        private void SeleccionarTipoUsuario(InfoUsuarioBD usuario)
        {
            switch(usuario.TipoUsuario)
            {
                case "Usuario":
                    KCmbTipoUsu.SelectedIndex = 1;
                    break;
                case "Editor":
                    KCmbTipoUsu.SelectedIndex = 0;
                    break;
                case "Administrador":
                    KCmbTipoUsu.SelectedIndex = 2;
                    break;
            }
        }

        private void ColocarUsuarios(List<InfoUsuarioBD> listaUsuario)
        {
            List<InfoUsuarioBD> lista = new List<InfoUsuarioBD>();
            lista.AddRange(listaUsuario.ToArray());
            LsvUsuariosBD.Items.Clear();
            if (esReverso)
                lista.Reverse();
            else
                lista.Sort();
            foreach (InfoUsuarioBD u in lista)
            {
                AniadirElementoUsuario(u);
            }
        }

        private ListViewItem AniadirElementoUsuario(InfoUsuarioBD usuario)
        {
            var item = LsvUsuariosBD.Items.Add(usuario.Nombre);
            item.SubItems.Add(usuario.TipoUsuario);
            item.SubItems.Add(usuario.Correo);
            item.Tag = usuario;
            return item;
        }

        private void LsvUsuariosBD_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (LsvUsuariosBD.SelectedItems.Count == 1)
            {
                KgbDatosUsuario.Visible = true;

                usuarioActual = (InfoUsuarioBD)LsvUsuariosBD.SelectedItems[0].Tag;
                LblEscribirNombreUsu.Text = usuarioActual.Nombre;
                LblEscribirEmail.Text = usuarioActual.Correo;
                SeleccionarTipoUsuario(usuarioActual);
            }
            else
                KgbDatosUsuario.Visible = false;
        }

        private void MBtnBuscar_Click(object sender, EventArgs e)
        {
            switch (KCmbBuscarPorUsu.SelectedIndex)
            {
                case 0:
                    listaUsuariosFiltrada = 
                        listaUsuarios.FindAll(p => p.Nombre != null ?
                    p.Nombre.IndexOf(KTxtBuscarUsu.Text, StringComparison.OrdinalIgnoreCase) > -1
                    : false);
                    break;
                case 1:
                    listaUsuariosFiltrada = 
                        listaUsuarios.FindAll(p => p.Correo != null ?
                    p.Correo.IndexOf(KTxtBuscarUsu.Text, StringComparison.OrdinalIgnoreCase) > -1
                    : false);
                    break;
                case 2:
                    listaUsuariosFiltrada = 
                        listaUsuarios.FindAll(p => p.TipoUsuario != null ?
                    p.TipoUsuario.IndexOf(KTxtBuscarUsu.Text, StringComparison.OrdinalIgnoreCase) > -1
                    : false);
                    break;
            }

            if (String.IsNullOrWhiteSpace(KTxtBuscarUsu.Text))
                ColocarUsuarios(listaUsuarios);
            else
                ColocarUsuarios(listaUsuariosFiltrada);
        }

        private void MBtnOrden_Click(object sender, EventArgs e)
        {
            esReverso = !esReverso;
            MBtnBuscar_Click(null, null);
        }

        private void MBtnMasUsu_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario form = new FrmEditarUsuario(new InfoUsuarioBD("Nuevo usuario", "correo@gmail.com", "Usuario"), false);
            form.ShowDialog();
            if (form.EsOk)
            {
                ObtenerUsuariosBD();
                ColocarUsuarios(listaUsuarios);
            }
        }

        private void MBtnEditarUsu_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario form = new FrmEditarUsuario((InfoUsuarioBD)LsvUsuariosBD.SelectedItems[0].Tag, true);
            form.ShowDialog();
            if (form.EsOk)
            {
                ObtenerUsuariosBD();
                ColocarUsuarios(listaUsuarios);
            }
        }

        private void MBtnMenosUsu_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto("este usuario") == DialogResult.Yes)
            {
                ConexionBD.AbrirConexion();
                EscrituraBD.DeleteUsuario((InfoUsuarioBD)LsvUsuariosBD.SelectedItems[0].Tag);
                ConexionBD.CerrarConexion();
                ObtenerUsuariosBD();
                ColocarUsuarios(listaUsuarios);
            }
        }
    }
}
