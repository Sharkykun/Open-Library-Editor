using Microsoft.VisualBasic;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
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
        /*
        TODO:
        - Añadir a doble click con IdiomaTexto los valores: Ejecutar Libro, Editar Información.
        - Poner idioma al nuevo label para editar IP.
        - Poner idioma al nuevo label para editar Clave Google Books.
        */
        private UsuarioDatos configuracionUsuario = UsuarioDatos.configuracionUsuario;
        private List<string> idiomas;
        private string ipAnterior = "0.0.0.0";

        private const string IDIOMA_ESPANOL = "Español de España (European Spanish)";
        private const string IDIOMA_INGLES = "English (EEUU)";
        private const string IDIOMA_FRANCES = "Français (French)";
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        #region metodos propios
        private void IdiomaTexto()
        {
            LblTituloConfi.Text = ControladorIdioma.GetTexto("Con_Titulo");
            KgbGeneral.Values.Heading = ControladorIdioma.GetTexto("Con_General");
            LblUltimaBBDD.Text = ControladorIdioma.GetTexto("Con_GCargar");
            TxtSubtituloUltimaBBDD.Text = ControladorIdioma.GetTexto("Con_GRecordar");
            TTConfi.SetToolTip(this.TBtnUltimaBBDD, ControladorIdioma.GetTexto("Con_GTTCargar"));
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
            LblTema.Text = ControladorIdioma.GetTexto("Con_ATema");
            TxtSubtituloTema.Text = ControladorIdioma.GetTexto("Con_AEstTema");
            RbtnClaro.Text = ControladorIdioma.GetTexto("Con_AClaro");
            TTConfi.SetToolTip(this.RbtnClaro, ControladorIdioma.GetTexto("Con_AClaro"));
            RbtnOscuro.Text = ControladorIdioma.GetTexto("Con_AOscuro");
            TTConfi.SetToolTip(this.RbtnOscuro, ControladorIdioma.GetTexto("Con_AOscuro"));

            KgbDescargasWeb.Values.Heading = ControladorIdioma.GetTexto("Con_Descargas");
            LblCamposActualizar.Text = ControladorIdioma.GetTexto("Con_DWSelecciona");
            KgbDetallesLibro.Values.Heading = ControladorIdioma.GetTexto("Con_DWDetalles");
            ChkAutores.Text = ControladorIdioma.GetTexto("Con_DWAutores");
            TTConfi.SetToolTip(this.ChkAutores, ControladorIdioma.GetTexto("Con_DWAutores"));
            ChkGeneros.Text = ControladorIdioma.GetTexto("Con_DWGeneros");
            TTConfi.SetToolTip(this.ChkGeneros, ControladorIdioma.GetTexto("Con_DWGeneros"));
            ChkSeries.Text = ControladorIdioma.GetTexto("Con_DWSeries");
            TTConfi.SetToolTip(this.ChkSeries, ControladorIdioma.GetTexto("Con_DWSeries"));
            ChkEditoriales.Text = ControladorIdioma.GetTexto("Con_DWEditoriales");
            TTConfi.SetToolTip(this.ChkEditoriales, ControladorIdioma.GetTexto("Con_DWEditoriales"));
            ChkTags.Text = ControladorIdioma.GetTexto("Con_DWEtiquetas");
            TTConfi.SetToolTip(this.ChkTags, ControladorIdioma.GetTexto("Con_DWEtiquetas"));
            KgbImagenesLibro.Values.Heading = ControladorIdioma.GetTexto("Con_DWTam");
            RbtnMiniatura.Text = ControladorIdioma.GetTexto("Con_DWMini");
            TTConfi.SetToolTip(this.RbtnMiniatura, ControladorIdioma.GetTexto("Con_DWMini"));
            RbtnMediana.Text = ControladorIdioma.GetTexto("Con_DWMedi");
            TTConfi.SetToolTip(this.RbtnMediana, ControladorIdioma.GetTexto("Con_DWMedi"));
            RbtnGrande.Text = ControladorIdioma.GetTexto("Con_DWGrande");
            TTConfi.SetToolTip(this.RbtnGrande, ControladorIdioma.GetTexto("Con_DWGrande"));

            KgbServidorWeb.Values.Heading = ControladorIdioma.GetTexto("Con_Servidor");
            LblTituloServidorWeb.Text = ControladorIdioma.GetTexto("Con_SWTitulo");
            TxtSubtituloServidor.Text = ControladorIdioma.GetTexto("Con_SWEstTit");
            TTConfi.SetToolTip(this.TxtTituloServidorWeb, ControladorIdioma.GetTexto("Con_SWTTTitulo"));
            LblIpServidor.Text = ControladorIdioma.GetTexto("Con_SWIP");
            TTConfi.SetToolTip(this.CmbIP, ControladorIdioma.GetTexto("Con_SWCmbIP"));
            LblPuertoServidor.Text = ControladorIdioma.GetTexto("Con_SWPuerto");
            TTConfi.SetToolTip(this.NudPuerto, ControladorIdioma.GetTexto("Con_SWTTPuerto"));

            LblGoogleBooksClave.Text = ControladorIdioma.GetTexto("Con_Google");
            TxtSubtituloGoogleBooksClave.Text = ControladorIdioma.GetTexto("Con_SubGoogle");

            BtnRestaurarValores.Text = ControladorIdioma.GetTexto("Con_BtnRestaurar");
            TTConfi.SetToolTip(this.BtnRestaurarValores, ControladorIdioma.GetTexto("Con_BtnRestaurar"));
            BtnCancelarConfi.Text = ControladorIdioma.GetTexto("Cancelar");
            TTConfi.SetToolTip(this.BtnCancelarConfi, ControladorIdioma.GetTexto("Cancelar"));
            BtnAceptarConfi.Text = ControladorIdioma.GetTexto("Aceptar");
            TTConfi.SetToolTip(this.BtnAceptarConfi, ControladorIdioma.GetTexto("Aceptar"));

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
            TBtnUltimaBBDD.Checked = configuracionUsuario.CargaUltimaBD;
            TxtUbicacionBBDD.Text = configuracionUsuario.UbicacionBD;
            TBtnContenidoExp.Checked = configuracionUsuario.ContenidoExplicito;
            CmbIdiomaConfi.SelectedItem = CargarIdioma(configuracionUsuario.IdiomaIntefaz);
            if (configuracionUsuario.TipoVista == 0)
                RbtnMosaico.Checked = true;
            else
                RbtnDetalles.Checked = true;
            if (configuracionUsuario.AccionDobleClick < CmbDobleClick.Items.Count)
                CmbDobleClick.SelectedIndex = configuracionUsuario.AccionDobleClick;
            if (configuracionUsuario.TemaOscuro)
                RbtnOscuro.Checked = true;
            else
                RbtnClaro.Checked = true;
            ChkAutores.Checked = configuracionUsuario.DescargaDetallesLibro[0];
            ChkGeneros.Checked = configuracionUsuario.DescargaDetallesLibro[1];
            ChkSeries.Checked = configuracionUsuario.DescargaDetallesLibro[2];
            ChkEditoriales.Checked = configuracionUsuario.DescargaDetallesLibro[3];
            ChkTags.Checked = configuracionUsuario.DescargaDetallesLibro[4];
            switch (configuracionUsuario.TamañoImagenLibro)
            {
                case 0:
                    RbtnMiniatura.Checked = true;
                    break;
                case 1:
                    RbtnMediana.Checked = true;
                    break;
                case 2:
                    RbtnGrande.Checked = true;
                    break;
            }
            TxtGoogleBooksClave.Text = configuracionUsuario.GoogleBooksApiKey;
        }
        #endregion

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            CmbIdiomaConfi.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIdiomaConfi.DrawMode = DrawMode.OwnerDrawFixed;
            idiomas = new List<string>();
            idiomas.Add("Español de España (European Spanish)");
            idiomas.Add("English (EEUU)");
            idiomas.Add("Français (French)");
            CmbIdiomaConfi.Items.AddRange(idiomas.ToArray());

            CargarConfiguracion();
            CmbIP.Items.AddRange(configuracionUsuario.ListaInfoBD.ToArray());
            //Seleccionar BD si el usuario ha entrado en alguna al iniciar sesion
            CmbIP.SelectedItem = configuracionUsuario.BDActual;
        }

        private void BtnRestaurarValores_Click(object sender, EventArgs e)
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
            string x = Interaction.InputBox("Escribe el nombre del servidor.",
                "Añadir Servidor", "", Location.X, Location.Y + 10);
            //Comprobar que no esté en blanco
            if (!String.IsNullOrWhiteSpace(x))
            {
                InfoBaseDatos info = new InfoBaseDatos(x, "0.0.0.0", 80);
                CmbIP.Items.Add(info);
                CmbIP.SelectedItem = info;
            }
        }

        private void MBtnMenosIP_Click(object sender, EventArgs e)
        {
            if (VentanaWindowsComun.MensajeBorrarObjeto("la información del servidor") == DialogResult.Yes)
            {
                CmbIP.Items.Remove(CmbIP.SelectedItem);
                if(CmbIP.Items.Count > 0)
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
                TxtIP.Text = info.ServidorIP;
            }
        }

        private void BtnAceptarConfi_Click(object sender, EventArgs e)
        {
            //Guardar datos en objeto
            configuracionUsuario.CargaUltimaBD = TBtnUltimaBBDD.Checked;
            configuracionUsuario.UbicacionBD = TxtUbicacionBBDD.Text;
            configuracionUsuario.ContenidoExplicito = TBtnContenidoExp.Checked;
            configuracionUsuario.IdiomaIntefaz = GuardarIdioma(CmbIdiomaConfi.SelectedItem.ToString());
            if (RbtnMosaico.Checked)
                configuracionUsuario.TipoVista = 0;
            else
                configuracionUsuario.TipoVista = 1;
            configuracionUsuario.AccionDobleClick = CmbDobleClick.SelectedIndex;
            configuracionUsuario.TemaOscuro = RbtnOscuro.Checked;
            configuracionUsuario.DescargaDetallesLibro[0] = ChkAutores.Checked;
            configuracionUsuario.DescargaDetallesLibro[1] = ChkGeneros.Checked;
            configuracionUsuario.DescargaDetallesLibro[2] = ChkSeries.Checked;
            configuracionUsuario.DescargaDetallesLibro[3] = ChkEditoriales.Checked;
            configuracionUsuario.DescargaDetallesLibro[4] = ChkTags.Checked;
            if (RbtnMiniatura.Checked)
                configuracionUsuario.TamañoImagenLibro = 0;
            else if (RbtnGrande.Checked)
                configuracionUsuario.TamañoImagenLibro = 2;
            else
                configuracionUsuario.TamañoImagenLibro = 1;
            configuracionUsuario.GoogleBooksApiKey = TxtGoogleBooksClave.Text;
            configuracionUsuario.ListaInfoBD.Clear();
            foreach (InfoBaseDatos info in CmbIP.Items)
                configuracionUsuario.ListaInfoBD.Add(info);
            configuracionUsuario.BDActual = (InfoBaseDatos)CmbIP.SelectedItem;

            //Guardar datos en json
            configuracionUsuario.GuardarJson();

            //Cambiar de formularios
            ControladorIdioma.idioma = configuracionUsuario.IdiomaIntefaz;
            IdiomaTexto();
            FrmMenuPrincipal form = (FrmMenuPrincipal)(Parent as Panel).Parent;
            form.IdiomaTexto();

            VentanaWindowsComun.MensajeInformacion("Se ha guardado correctamente.");
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
            if(CmbIP.SelectedIndex != -1)
                (CmbIP.SelectedItem as InfoBaseDatos).Puerto = (int)NudPuerto.Value;
        }

        private void TxtIP_Leave(object sender, EventArgs e)
        {
            if (CmbIP.SelectedIndex != -1)
            {
                string patronIP = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|
                25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
                bool esCorrecto = Regex.Match(TxtIP.Text, patronIP).Success;
                if (!esCorrecto && !String.IsNullOrWhiteSpace(TxtIP.Text))
                {
                    VentanaWindowsComun.MensajeError("La IP no tiene formato correcto.");
                    TxtIP.Text = ipAnterior;
                }
                else
                {
                    ipAnterior = TxtIP.Text;
                    (CmbIP.SelectedItem as InfoBaseDatos).ServidorIP = TxtIP.Text;
                }
            }
        }
    }
}
