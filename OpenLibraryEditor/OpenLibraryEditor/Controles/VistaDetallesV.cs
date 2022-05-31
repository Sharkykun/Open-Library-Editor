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

namespace OpenLibraryEditor.Controles
{
    public partial class VistaDetallesV : UserControl
    {
        private ArrayList listaPersonas = new ArrayList();
        public VistaDetallesV()
        {
            InitializeComponent();
        }
        #region getter y setter
        public void setImagen(Image imagen)
        {
            PcbImgLibro.BackgroundImage = imagen;
            PcbImgLibro.BackgroundImageLayout = ImageLayout.Stretch;
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
        public int getTamanioLblTitulo()
        {
            return LblTituloLibro.Width;
        }
        public void setTamanioMaximoTitulo(int x, int y, bool si)
        {
            LblTituloLibro.MaximumSize = new Size(x,y);
            LblTituloLibro.AutoSize = si;
        }
        public void setAutores(string personas)
        {
            listaPersonas.Add(personas);
            string quitarComa = null;
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                quitarComa += listaPersonas[i] + ", ";
            }
            LblAutores.Text = quitarComa.Substring(0, (quitarComa.LastIndexOf(", ")));
            if(LblAutores.Text.Length > 57)
            {
                LblAutores.Text = LblAutores.Text.Substring(0,57)+"...";
            }
        }
        public string getAutores()
        {
            return LblAutores.Text;
        }
        public int getTamanioLblAutores()
        {
            return LblAutores.Width;
        }
        public void setTamanioMaximoAutores(int x, int y, bool si)
        {
            LblAutores.MaximumSize = new Size(x, y);
            LblAutores.AutoSize = si;
        }
        public void setEditoriales(string editoriales)
        { 
             LblEscribirEditorial.Text += editoriales.ToUpper()+" ";
        }
        public string getEditoriales()
        {
            return LblEscribirEditorial.Text;
        }
        public int getTamanioLblEditoriales()
        {
            return LblEscribirEditorial.Width;
        }
        public void setTamanioMaximoEditoriales(int x, int y, bool si)
        {
            LblEscribirEditorial.MaximumSize = new Size(x, y);
            LblEscribirEditorial.AutoSize = si;
        }
       
        public void setIsbn10(string is10)
        {
            LblEscribirIsbn10.Text = is10.ToUpper();
        }
        public string getIsbn10()
        {
            return LblEscribirIsbn10.Text;
        }
        public void setIsbn13(string is13)
        {
            LblEscribirIsbn13.Text = is13.ToUpper();
        }
        public string getIsbn13()
        {
            return LblEscribirIsbn13.Text;
        }
        public void setFecha(string fecha)
        {
            LblEscribirFecha.Text = fecha;
        }
        public string getFecha()
        {
            return LblEscribirFecha.Text;
        }
        public void setIdioma(string idioma)
        {
            LblEscribirIdioma.Text = idioma.ToUpper();
        }
        public string getIdioma()
        {
            return LblEscribirIdioma.Text;
        }
        public void setFormato(string formato)
        {
            LblEscribirFormato.Text = formato.ToUpper();
        }
        public string getFormato()
        {
            return LblEscribirFormato.Text;
        }
        public void setPaginas(string paginas)
        {
            LblEscribirPag.Text = paginas;
        }
        public string getPaginas()
        {
            return LblEscribirPag.Text;
        }

        #endregion
        #region metodos
        private void PanBorde_MouseEnter(object sender, EventArgs e)
        {
            PanDatos.BackColor = Color.FromArgb(80, 137,205, 250);
        }

        private void PanBorde_MouseLeave(object sender, EventArgs e)
        {
            PanDatos.BackColor = Color.FromArgb(243, 249, 255);
        }

        private void PanBorde_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void PanBorde_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }
        #endregion
        private void VistaDetallesV_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
        }
        #region metodos propios
        private void IdiomaTexto()
        {
            LblEditorial.Text = ControladorIdioma.GetTexto("Main_Edi");
            //LblSeries.Text = ControladorIdioma.GetTexto("Main_Ser");
            LblIsbn10.Text = ControladorIdioma.GetTexto("Main_is10");
            LblIsbn13.Text = ControladorIdioma.GetTexto("Main_is13");
            LblPaginas.Text = ControladorIdioma.GetTexto("Main_Pag");
            LblPublicado.Text = ControladorIdioma.GetTexto("Main_Publicado");
            LblIdioma.Text = ControladorIdioma.GetTexto("Main_Idioma");
            LblFormato.Text = ControladorIdioma.GetTexto("Main_Formato");
        }


        #endregion
    }
}
