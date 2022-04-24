using OpenLibraryEditor.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Controles
{
    public partial class VistaDetallesV : UserControl
    {
        public VistaDetallesV()
        {
            InitializeComponent();
        }
        public void setImagen(Image imagen)
        {
            PcbImgLibro.BackgroundImage = imagen;
            PcbImgLibro.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Image getImagen()
        {
            return PcbImgLibro.Image;
        }
        public void setTituloLibro(string titulo)
        {
            LblTituloLibro.Text = titulo;
        }
        public string getTituloLibro()
        {
            return LblTituloLibro.Text;
        }
        public void setPersonas(string personas)
        {
            LblPersonasLibro.Text = personas;
        }
        public string getPersonas()
        {
            return LblPersonasLibro.Text;
        }
        public void setLblEditorial(string editorial)
        {
            LblEditorial.Text = editorial;
        }
        public void setEditoriales(string editoriales)
        {
            LblEscribirEditoriales.Text = editoriales;
        }
        public string getEditoriales()
        {
            return LblEscribirEditoriales.Text;
        }
        public void setLblSeries(string serie)
        {
            LblSeries.Text = serie;
        }
        public void setSeries(string series)
        {
            LblescribirSeries.Text = series;
        }
        public string getSeries()
        {
            return LblescribirSeries.Text;
        }
        public void setLblIsbn10(string isbn10)
        {
            LblIsbn10.Text = isbn10;
        }
        public void setIsbn10(string is10)
        {
            LblEscribirIsbn10.Text = is10;
        }
        public string getIsbn10()
        {
            return LblEscribirIsbn10.Text;
        }
        public void setLblIsbn13(string isbn13)
        {
            LblIsbn13.Text = isbn13;
        }
        public void setIsbn13(string is13)
        {
            LblEscribirIsbn13.Text = is13;
        }
        public string getIsbn13()
        {
            return LblEscribirIsbn13.Text;
        }
        public void setLblFecha(string fecha)
        {
            LblFecha.Text = fecha;
        }
        public void setFecha(string fecha)
        {
            LblEscribirFecha.Text = fecha;
        }
        public string getFecha()
        {
            return LblEscribirFecha.Text;
        }
        public void setLblIdioma(string idioma)
        {
            LblIdioma.Text = idioma;
        }
        public void setIdioma(string idioma)
        {
            LblEscribirIdioma.Text = idioma;
        }
        public string getIdioma()
        {
            return LblEscribirIdioma.Text;
        }
        public void setLblFormato(string formato)
        {
            LblFormato.Text = formato;
        }
        public void setFormato(string formato)
        {
            LblEscribirFormato.Text = formato;
        }
        public string getFormato()
        {
            return LblEscribirFormato.Text;
        }

        private void PanBorde_MouseEnter(object sender, EventArgs e)
        {
            PanDatos.BackColor = Color.Silver;
        }

        private void PanBorde_MouseLeave(object sender, EventArgs e)
        {
            PanDatos.BackColor = Color.Gainsboro;
        }

        private void PanBorde_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void VistaDetallesV_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
        }

        private void IdiomaTexto()
        {
            LblEditorial.Text = ControladorIdioma.GetTexto("Main_Edi");
            LblSeries.Text = ControladorIdioma.GetTexto("Main_Ser");
            LblIsbn10.Text = ControladorIdioma.GetTexto("Main_is10");
            LblIsbn13.Text = ControladorIdioma.GetTexto("Main_is13");
            LblPaginas.Text = ControladorIdioma.GetTexto("Main_Pag");
            LblFecha.Text = ControladorIdioma.GetTexto("Main_Publicado");
            LblIdioma.Text = ControladorIdioma.GetTexto("Main_Idioma");
            LblFormato.Text = ControladorIdioma.GetTexto("Main_Formato");
        }
    }
}
