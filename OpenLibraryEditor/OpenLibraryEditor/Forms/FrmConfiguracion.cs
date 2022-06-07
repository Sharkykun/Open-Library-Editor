using Microsoft.VisualBasic;
using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using OpenLibraryEditor.Metodos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmConfiguracion : Form
    {
        private UsuarioDatos configuracionUsuario = UsuarioDatos.configuracionUsuario;
        InfoUsuarioBD usuario = new InfoUsuarioBD();
        private List<string> idiomas;
        private string ipAnterior = "0.0.0.0";

        private const string IDIOMA_ESPANOL = "Español de España (European Spanish)";
        private const string IDIOMA_INGLES = "English (EEUU)";
        private const string IDIOMA_FRANCES = "Français (French)";

        private bool usuRegistrado;
        public FrmConfiguracion()
        {
            InitializeComponent();
        }
        public FrmConfiguracion(bool usuRegistrado)
        {
            InitializeComponent();
            this.usuRegistrado = usuRegistrado;
        }

        private void FrmPruebaConfi_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            //PosicionInicial();
            CmbIdiomaConfi.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIdiomaConfi.DrawMode = DrawMode.OwnerDrawFixed;
            idiomas = new List<string>();
            idiomas.Add("Español de España (European Spanish)");
            idiomas.Add("English (EEUU)");
            idiomas.Add("Français (French)");
            CmbIdiomaConfi.Items.AddRange(idiomas.ToArray());
            CargarConfiguracion();
            CmbIP.Items.AddRange(configuracionUsuario.ListaInfoBD.ToArray());
            if (CmbIP.Items.Count > 0)
                CmbIP.SelectedIndex = 0;
            
            gunaHScrollBar1.Maximum = 250;
            gunaHScrollBar1.Minimum = -60;
            gunaHScrollBar1.Value = 0;
          
        }

        #region metodos propios
        private void IdiomaTexto()
        {
            LblTituloConfi.Text = ControladorIdioma.GetTexto("Con_Titulo");
            this.Text= ControladorIdioma.GetTexto("Con_Titulo");
            KgbDatosUsu.Values.Heading = ControladorIdioma.GetTexto("Con_DatosUsu");
            LblMailActual.Text = ControladorIdioma.GetTexto("Con_MailActual");
            TTConfi.SetToolTip(this.TxtMailActual, ControladorIdioma.GetTexto("Con_TTMailA"));
            LblMailNuevo.Text = ControladorIdioma.GetTexto("Con_MailNuevo");
            TTConfi.SetToolTip(this.TxtMailNuevo, ControladorIdioma.GetTexto("Con_TTMailN"));
            LblNuevaPass.Text = ControladorIdioma.GetTexto("Con_ContraNueva");
            TTConfi.SetToolTip(this.KTxtContraNueva, ControladorIdioma.GetTexto("Con_TTContraNueva"));
            LblRepetrirContra.Text = ControladorIdioma.GetTexto("Con_RepetirContra");
            TTConfi.SetToolTip(this.KTxtRepetirContra, ControladorIdioma.GetTexto("Con_TTRepetirContra"));
            GBtnActualizarMail.Text = ControladorIdioma.GetTexto("Actualizar");
            TTConfi.SetToolTip(this.GBtnActualizarMail, ControladorIdioma.GetTexto("Con_TTActualizar"));
            GBtnModificarPass.Text = ControladorIdioma.GetTexto("Modificar");
            TTConfi.SetToolTip(this.GBtnModificarPass, ControladorIdioma.GetTexto("Con_TTModificar"));
            TTConfi.SetToolTip(this.IpcbMostrarContra, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTConfi.SetToolTip(this.IpcbMostrarContra1, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTConfi.SetToolTip(this.IpcbOcultarContra, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTConfi.SetToolTip(this.IpcbOcultarContra1, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));

            TTConfi.SetToolTip(this.MBtnMasIP, ControladorIdioma.GetTexto("Con_TTMasUrl"));
            TTConfi.SetToolTip(this.MBtnMenosIP, ControladorIdioma.GetTexto("Con_TTMenosUrl"));

            KgbGeneral.Values.Heading = ControladorIdioma.GetTexto("Con_General");
            LblUbicacion.Text = ControladorIdioma.GetTexto("Con_GUbicacion");
            TxtSubtituloUbicacion.Text = ControladorIdioma.GetTexto("Con_Gruta");
            TTConfi.SetToolTip(this.IBtnOpenFile, ControladorIdioma.GetTexto("Con_GTTRuta"));
            LblContenidoExpConfi.Text = ControladorIdioma.GetTexto("Con_GExplicito");
            TxtSubtituloContenidoExp.Text = ControladorIdioma.GetTexto("Con_GPermitir");
            TTConfi.SetToolTip(this.TBtnContenidoExp, ControladorIdioma.GetTexto("Con_GTTExp"));

            KgbApariencia.Values.Heading = ControladorIdioma.GetTexto("Con_Apariencia");
            LblIdiomaConfi.Text = ControladorIdioma.GetTexto("Con_AIdioma");
            TxtSubtituloEligeIdioConfi.Text = ControladorIdioma.GetTexto("Con_AEligeIdi");
            TTConfi.SetToolTip(this.CmbIdiomaConfi, ControladorIdioma.GetTexto("Con_ATTComboId"));
            LblVisuConfi.Text = ControladorIdioma.GetTexto("Con_AVisu");
            TxtSubtituloVisuConfi.Text = ControladorIdioma.GetTexto("Con_AEstVisu");
            RbtnMosaico.Text = ControladorIdioma.GetTexto("Con_AMosaico");
            TTConfi.SetToolTip(this.RbtnMosaico, ControladorIdioma.GetTexto("Con_AMosaico"));
            RbtnDetalles.Text = ControladorIdioma.GetTexto("Con_ADetalles");
            TTConfi.SetToolTip(this.RbtnDetalles, ControladorIdioma.GetTexto("Con_ADetalles"));
            LblDobleClick.Text = ControladorIdioma.GetTexto("Con_ADoble");
            TxtSubtituloDobleClick.Text = ControladorIdioma.GetTexto("Con_AConfiDoble");
            TTConfi.SetToolTip(this.CmbDobleClick, ControladorIdioma.GetTexto("Con_ATTCmbDoble"));

            KgbDescargasWeb.Values.Heading = ControladorIdioma.GetTexto("Con_Descargas");
            LblCamposActualizar.Text = ControladorIdioma.GetTexto("Con_DWSelecciona");
            KgbDetallesLibro.Values.Heading = ControladorIdioma.GetTexto("Con_DWDetalles");
            ChkAutores.Text = ControladorIdioma.GetTexto("Con_DWAutores");
            TTConfi.SetToolTip(this.ChkAutores, ControladorIdioma.GetTexto("Con_DWAutores"));
            ChkGeneros.Text = ControladorIdioma.GetTexto("Con_DWGeneros");
            TTConfi.SetToolTip(this.ChkGeneros, ControladorIdioma.GetTexto("Con_DWGeneros"));
            ChkEditoriales.Text = ControladorIdioma.GetTexto("Con_DWEditoriales");
            TTConfi.SetToolTip(this.ChkEditoriales, ControladorIdioma.GetTexto("Con_DWEditoriales"));

            KgbServidorWeb.Values.Heading = ControladorIdioma.GetTexto("Con_Servidor");
            LblTituloServidorWeb.Text = ControladorIdioma.GetTexto("Con_SWTitulo");
            TxtSubtituloServidor.Text = ControladorIdioma.GetTexto("Con_SWEstTit");
            TTConfi.SetToolTip(this.TxtTituloServidorWeb, ControladorIdioma.GetTexto("Con_SWTTTitulo"));
            LblIpServidor.Text = ControladorIdioma.GetTexto("Con_SWIP");
            TTConfi.SetToolTip(this.CmbIP, ControladorIdioma.GetTexto("Con_SWCmbIP"));
            LblIp.Text = ControladorIdioma.GetTexto("Url");
            LblPuertoServidor.Text = ControladorIdioma.GetTexto("Con_SWPuerto");
            TTConfi.SetToolTip(this.NudPuerto, ControladorIdioma.GetTexto("Con_SWTTPuerto"));

            LblGoogleBooksClave.Text = ControladorIdioma.GetTexto("Con_Google");
            TxtSubtituloGoogleBooksClave.Text = ControladorIdioma.GetTexto("Con_SubGoogle");

            GBtnRestaurar.Text = ControladorIdioma.GetTexto("Con_BtnRestaurar");
            TTConfi.SetToolTip(this.GBtnRestaurar, ControladorIdioma.GetTexto("Con_BtnRestaurar"));
            GBtnCancelar.Text = ControladorIdioma.GetTexto("Cancelar");
            TTConfi.SetToolTip(this.GBtnCancelar, ControladorIdioma.GetTexto("Cancelar"));
            GBtnAceptar.Text = ControladorIdioma.GetTexto("Aceptar");
            TTConfi.SetToolTip(this.GBtnAceptar, ControladorIdioma.GetTexto("Aceptar"));
            CmbDobleClick.Items.Clear();
            CmbDobleClick.Items.Add(ControladorIdioma.GetTexto("Con_CmbDobleEjecutar"));
            CmbDobleClick.Items.Add(ControladorIdioma.GetTexto("Con_CmbDobleEditar"));

            if (usuRegistrado) {
                PanDatosUsu.Visible = true;
                TxtMailActual.Text = UsuarioActual();
                if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Administrador"))
                {
                    LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Adm");
                }
                else if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Usuario"))
                {
                    LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Usu");
                }
                else if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Editor"))
                {
                    LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("TipoUsuario") + ControladorIdioma.GetTexto("Adm_Editor");
                }
            }
            else
            {
                KgbDatosUsu.Visible = false;
                PanDatosUsu.Visible = true;
                LblTipoUsuarioConectado.Text = ControladorIdioma.GetTexto("ModoSinConexion");
            }

        }
        private string UsuarioActual()
        {
            if (ConexionBD.AbrirConexion())
            {
                usuario = LecturaBD.SelectUsuario(UsuarioDatos.configuracionUsuario.InfoUsuarioActual.Nombre);
                ConexionBD.CerrarConexion();
            }
           
            return usuario.Correo;
        }
        private void gunaHScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
                if (PanElementos.Width < 850) 
                {
                    MPcbConfi.Location = new Point(-gunaHScrollBar1.Value, MPcbConfi.Location.Y);
                    LblTituloConfi.Location = new Point(-gunaHScrollBar1.Value + MPcbConfi.Width, LblTituloConfi.Location.Y);
                    KgbDatosUsu.Location = new Point(-gunaHScrollBar1.Value, KgbDatosUsu.Location.Y);
                    KgbGeneral.Location = new Point(-gunaHScrollBar1.Value, KgbGeneral.Location.Y);
                    KgbApariencia.Location = new Point(-gunaHScrollBar1.Value, KgbApariencia.Location.Y);
                    KgbDescargasWeb.Location = new Point(-gunaHScrollBar1.Value, KgbDescargasWeb.Location.Y);
                    KgbServidorWeb.Location = new Point(-gunaHScrollBar1.Value, KgbServidorWeb.Location.Y);
                }
        }

      

        private void CmbIdiomaConfi_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index >= 0)
            {
                if (e.Index < ImlIdiomas.Images.Count)
                {
                    Image img = new Bitmap(ImlIdiomas.Images[e.Index], new Size(20, 20));
                    e.Graphics.DrawImage(img, new PointF(e.Bounds.Left + 4, e.Bounds.Top + 2));
                }
                e.Graphics.DrawString(string.Format(idiomas[e.Index], e.Index + 1)
                 , e.Font, new SolidBrush(e.ForeColor)
                 , e.Bounds.Left + 36, e.Bounds.Top + 2);
            }
        }

        private string CargarIdioma(string idioma)
        {
            switch (idioma)
            {
                case ControladorIdioma.IDIOMA_INGLES:
                    return IDIOMA_INGLES;
                case ControladorIdioma.IDIOMA_ESPANOL:
                    return IDIOMA_ESPANOL;
                case ControladorIdioma.IDIOMA_FRANCES:
                    return IDIOMA_FRANCES;
                default:
                    return "";
            }
        }

        private string GuardarIdioma(string idioma)
        {
            switch (idioma)
            {
                case IDIOMA_INGLES:
                    return ControladorIdioma.IDIOMA_INGLES;
                case IDIOMA_ESPANOL:
                    return ControladorIdioma.IDIOMA_ESPANOL;
                case IDIOMA_FRANCES:
                    return ControladorIdioma.IDIOMA_FRANCES;
                default:
                    return "";
            }
        }

        private void CargarConfiguracion()
        {
            //Cargar datos de usuario local
            TxtUbicacionBBDD.Text = configuracionUsuario.UbicacionBD;
            TBtnContenidoExp.Checked = configuracionUsuario.ContenidoExplicito;
            CmbIdiomaConfi.SelectedItem = CargarIdioma(configuracionUsuario.IdiomaIntefaz);
            if (configuracionUsuario.TipoVista == 0)
                RbtnMosaico.Checked = true;
            else
                RbtnDetalles.Checked = true;
            if (configuracionUsuario.AccionDobleClick < CmbDobleClick.Items.Count)
                CmbDobleClick.SelectedIndex = configuracionUsuario.AccionDobleClick;

            ChkAutores.Checked = configuracionUsuario.DescargaDetallesLibro[0];
            ChkGeneros.Checked = configuracionUsuario.DescargaDetallesLibro[1];
            ChkEditoriales.Checked = configuracionUsuario.DescargaDetallesLibro[3];
            TxtGoogleBooksClave.Text = configuracionUsuario.GoogleBooksApiKey;
        }
        private void GBtnRestaurar_Click(object sender, EventArgs e)
        {
            //Restaura todos los campos menos los relativos a info de servidores
            configuracionUsuario = new UsuarioDatos();
            CargarConfiguracion();
        }

        private void IBtnOpenFile_Click(object sender, EventArgs e)
        {
            string carpeta = VentanaWindowsComun.GetRutaCarpeta();
            if (carpeta != "")
                TxtUbicacionBBDD.Text = carpeta;
        }

        private void MBtnMasIP_Click(object sender, EventArgs e)
        {
            //Falta mensaje de error si campos vacios
            InfoBaseDatos info = new InfoBaseDatos("Nuevo Servidor", "0.0.0.0", 3306);
            CmbIP.Items.Add(info);
            CmbIP.SelectedItem = info;
        }

        private void MBtnMenosIP_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto(ControladorIdioma.GetTexto("Con_InfoServidor")) == DialogResult.Yes)
            {
                CmbIP.Items.Remove(CmbIP.SelectedItem);
                if (CmbIP.Items.Count > 0)
                    CmbIP.SelectedIndex = 0;
            }
        }

        private void CmbIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbIP.SelectedIndex != -1)
            {
                InfoBaseDatos info = (InfoBaseDatos)CmbIP.SelectedItem;
                TxtTituloServidorWeb.Text = info.Nombre;
                NudPuerto.Value = info.Puerto;
                TxtIP.Text = info.ServidorUrl;
            }
        }
        private void GBtnAceptar_Click(object sender, EventArgs e)
        {
            //Guardar datos en objeto
            configuracionUsuario.UbicacionBD = TxtUbicacionBBDD.Text;
            configuracionUsuario.ContenidoExplicito = TBtnContenidoExp.Checked;
            configuracionUsuario.IdiomaIntefaz = GuardarIdioma(CmbIdiomaConfi.SelectedItem.ToString());
            if (RbtnMosaico.Checked)
                configuracionUsuario.TipoVista = 0;
            else
                configuracionUsuario.TipoVista = 1;
            configuracionUsuario.AccionDobleClick = CmbDobleClick.SelectedIndex;
            configuracionUsuario.DescargaDetallesLibro[0] = ChkAutores.Checked;
            configuracionUsuario.DescargaDetallesLibro[1] = ChkGeneros.Checked;
            configuracionUsuario.DescargaDetallesLibro[3] = ChkEditoriales.Checked;
            configuracionUsuario.GoogleBooksApiKey = TxtGoogleBooksClave.Text;
            configuracionUsuario.ListaInfoBD.Clear();
            foreach (InfoBaseDatos info in CmbIP.Items)
                configuracionUsuario.ListaInfoBD.Add(info);

            //Guardar datos en json
            configuracionUsuario.GuardarJson();

            //Cambiar de formularios
            ControladorIdioma.idioma = configuracionUsuario.IdiomaIntefaz;
            IdiomaTexto();
            FrmMenuPrincipal form = (FrmMenuPrincipal)(Parent as Panel).Parent;
            form.IdiomaTexto();

            VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("Info_GuardadoOk"));
        }
        private void TxtTituloServidorWeb_TextChanged(object sender, EventArgs e)
        {
            if (CmbIP.SelectedIndex != -1)
            {
                InfoBaseDatos info = (InfoBaseDatos)CmbIP.SelectedItem;
                info.Nombre = TxtTituloServidorWeb.Text;
                CmbIP.Items[CmbIP.SelectedIndex] = info;
            }
        }

        private void NudPuerto_ValueChanged(object sender, EventArgs e)
        {
            if (CmbIP.SelectedIndex != -1)
                (CmbIP.SelectedItem as InfoBaseDatos).Puerto = (int)NudPuerto.Value;
        }

        private void TxtIP_Leave(object sender, EventArgs e)
        {
            if (CmbIP.SelectedIndex != -1)
                (CmbIP.SelectedItem as InfoBaseDatos).ServidorUrl = TxtIP.Text;
        }
        #endregion

        #region usuario registrado

        #region mostrar/ocultar password
        private void IpcbMostrarContra_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraNueva, true, false, IpcbOcultarContra, IpcbMostrarContra);
        }

        private void IpcbOcultarContra_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraNueva, false, true, IpcbMostrarContra, IpcbOcultarContra);
        }

        private void IpcbMostrarContra1_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtRepetirContra, true, false, IpcbOcultarContra1, IpcbMostrarContra1);
        }

        private void IpcbOcultarContra1_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtRepetirContra, false, true, IpcbMostrarContra1, IpcbOcultarContra1);
        }
        #endregion
        private void GBtnActualizarMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetodosComunes.EsEmailValido(TxtMailNuevo.Text))
                {
                    if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Administrador"))
                    {
                        if (ConexionBD.AbrirConexion())
                        {
                            if (LecturaBD.SelectUsuarioCorreo(TxtMailNuevo.Text) == 0)
                            {
                                EscrituraBD.UpdateMailUsuario(TxtMailNuevo.Text, UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                ConexionBD.CerrarConexion();
                                TxtMailActual.Text = UsuarioActual();
                                TxtMailNuevo.Text = "";
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("MailCambiadoOk"));
                                
                            }
                            else
                                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_ErrorMail"));
                        }
                    }
                    else
                    {
                        ConexionBD.EstablecerConexion(UsuarioDatos.configuracionUsuario.BDActual.ServidorUrl,
                        "ole_register", "ole123Ole", UsuarioDatos.configuracionUsuario.BDActual.Puerto.ToString());
                        if (ConexionBD.AbrirConexion())
                        {
                            if (LecturaBD.SelectUsuarioCorreo(TxtMailNuevo.Text) == 0)
                            {
                                EscrituraBD.UpdateMailUsuario(TxtMailNuevo.Text, UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
                                ConexionBD.CerrarConexion();
                                TxtMailActual.Text = "";
                                TxtMailActual.Text = UsuarioActual();
                                TxtMailNuevo.Text = "";
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("MailCambiadoOk"));
                            }
                            else
                                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_ErrorMail"));
                        }
                    }
                }
                else
                {
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("MailNoValido"));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void GBtnModificarPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(KTxtContraNueva.Text) && !String.IsNullOrWhiteSpace(KTxtRepetirContra.Text))
                {
                    if (KTxtContraNueva.Text == KTxtRepetirContra.Text)
                    {
                        if (UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario.Equals("Administrador"))
                        {
                            if (ConexionBD.AbrirConexion())
                            {
                                EscrituraBD.UpdatePasswordUsuario(KTxtContraNueva.Text, usuario);
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("MailActualizarContra"));
                                KTxtContraNueva.Text = "";
                                KTxtRepetirContra.Text = "";
                                ConexionBD.CerrarConexion();
                            }
                        }
                        else
                        {
                            ConexionBD.EstablecerConexion(UsuarioDatos.configuracionUsuario.BDActual.ServidorUrl,
                            "ole_register", "ole123Ole", UsuarioDatos.configuracionUsuario.BDActual.Puerto.ToString());
                            if (ConexionBD.AbrirConexion())
                            {
                                EscrituraBD.UpdatePasswordUsuario(KTxtContraNueva.Text, usuario);
                                VentanaWindowsComun.MensajeInformacion(ControladorIdioma.GetTexto("MailActualizarContra"));
                                KTxtContraNueva.Text = "";
                                KTxtRepetirContra.Text = "";
                                ConexionBD.CerrarConexion();
                            }
                        }
                    }
                    else
                    {
                        VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Reg_ContraNoCoincide"));
                    }
                }
                else
                {
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Log_Error4"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        #endregion
    }
}
