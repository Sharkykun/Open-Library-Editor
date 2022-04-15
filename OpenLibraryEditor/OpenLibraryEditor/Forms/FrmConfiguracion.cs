using OpenLibraryEditor.Clases;
using System;
using System.Collections;
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
    public partial class FrmConfiguracion : Form
    {
        private List<string> idiomas;
        public FrmConfiguracion()
        {
            InitializeComponent();
           
            
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            CmbIdiomaConfi.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIdiomaConfi.DrawMode = DrawMode.OwnerDrawFixed;
            CmbIdiomaConfi.Items.AddRange(Enumerable.Repeat<string>(" ", ImlIdiomas.Images.Count).ToArray());
            idiomas = new List<string>();
            idiomas.Add("Español de España (European Spanish)");
            idiomas.Add("English (EEUU)");
            idiomas.Add("Français (French)");
        }
        #region metodos propios
        private void IdiomaTexto()
        {
            LblTituloConfi.Text = ControladorIdioma.GetTexto("Con_Titulo");
            KgbGeneral.Values.Heading = ControladorIdioma.GetTexto("Con_General");
            LblUltimaBBDD.Text = ControladorIdioma.GetTexto("Con_GCargar");
            TxtSubtituloUltimaBBDD.Text = ControladorIdioma.GetTexto("Con_GRecordar");
            TTConfi.SetToolTip(this.TBtnUltimaBBDD, ControladorIdioma.GetTexto("Con_GTTCargar"));
            LblUbicacion.Text= ControladorIdioma.GetTexto("Con_GUbicacion");
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
            RbtnDetalles.Text =ControladorIdioma.GetTexto("Con_ADetalles");
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
            ChkAutores.Text= ControladorIdioma.GetTexto("Con_DWAutores");
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
            LblIpServidor.Text= ControladorIdioma.GetTexto("Con_SWIP");
            TTConfi.SetToolTip(this.CmbIP, ControladorIdioma.GetTexto("Con_SWCmbIP"));
            LblPuertoServidor.Text = ControladorIdioma.GetTexto("Con_SWPuerto");
            TTConfi.SetToolTip(this.NudPuerto, ControladorIdioma.GetTexto("Con_SWTTPuerto"));

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
        #endregion

        private void BtnRestaurarValores_Click(object sender, EventArgs e)
        {

        }
    }
}
