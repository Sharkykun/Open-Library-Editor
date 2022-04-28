using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.DatosLibros
{
    public class Libro : IComparable<Libro>
    {
        //Datos de libro comunes
        private string isbn_13;
        private string titulo;
        private string subtitulo;
        private string tituloAlternativo;
        private string sinopsis;
        private int numeroPaginas;
        private List<Editorial> listaEditorial = new List<Editorial>();
        private DateTime fechaPublicacion;
        private DateTime fechaAdicionBD; //Fecha de inclusión en base de datos
        private int edicion;
        private List<Serie> listaSerie = new List<Serie>();
        private double numeroVolumen; //Para series de múltiples volúmenes
        private string idioma;
        private string isbn_10;
        private List<Genero> listaGenero = new List<Genero>();
        private List<Autor> listaAutor = new List<Autor>();
        private string imagenPortada;
        private string imagenContraportada;
        private List<Etiqueta> listaEtiqueta = new List<Etiqueta>();
        private string nombreTipo; //novela, manga, novela web...
        private bool mayorEdad;
        private int numeroCapitulos;
        private string idiomaOriginal;
        private string enlaceReferencia;

        //Datos personales de usuario
        private double puntuacion;
        private List<UsuarioAccion> listaAccion = new List<UsuarioAccion>();
        private int vecesLeido; 
        private string estadoLectura;
        private DateTime tiempoLectura;
        private string comentario; 
        private int capituloActual;
        private DateTime fechaComienzo;
        private DateTime fechaTerminado; 
        private bool ocultar;
        private bool favorito;

        public Libro()
        {
        }

        public Libro(string isbn_13, string titulo)
        {
            this.isbn_13 = isbn_13;
            this.titulo = titulo;
        }


        #region Get y Set
        public string Isbn_13 { get => isbn_13; set => isbn_13 = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string TituloAlternativo { get => tituloAlternativo; set => tituloAlternativo = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int NumeroPaginas { get => numeroPaginas; set => numeroPaginas = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public DateTime FechaAdicionBD { get => fechaAdicionBD; set => fechaAdicionBD = value; }
        public int Edicion { get => edicion; set => edicion = value; }
        public double NumeroVolumen { get => numeroVolumen; set => numeroVolumen = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public string Isbn_10 { get => isbn_10; set => isbn_10 = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
        public bool MayorEdad { get => mayorEdad; set => mayorEdad = value; }
        public int NumeroCapitulos { get => numeroCapitulos; set => numeroCapitulos = value; }
        public string IdiomaOriginal { get => idiomaOriginal; set => idiomaOriginal = value; }
        public string EnlaceReferencia { get => enlaceReferencia; set => enlaceReferencia = value; }
        public double Puntuacion { get => puntuacion; set => puntuacion = value; }
        public int VecesLeido { get => vecesLeido; set => vecesLeido = value; }
        public string EstadoLectura { get => estadoLectura; set => estadoLectura = value; }
        public DateTime TiempoLectura { get => tiempoLectura; set => tiempoLectura = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public int CapituloActual { get => capituloActual; set => capituloActual = value; }
        public DateTime FechaComienzo { get => fechaComienzo; set => fechaComienzo = value; }
        public DateTime FechaTerminado { get => fechaTerminado; set => fechaTerminado = value; }
        public bool Ocultar { get => ocultar; set => ocultar = value; }
        public bool Favorito { get => favorito; set => favorito = value; }
        public List<Editorial> ListaEditorial { get => listaEditorial; set => listaEditorial = value; }
        public List<Serie> ListaSerie { get => listaSerie; set => listaSerie = value; }
        public List<Genero> ListaGenero { get => listaGenero; set => listaGenero = value; }
        public List<Autor> ListaAutor { get => listaAutor; set => listaAutor = value; }
        public string ImagenPortada { get => imagenPortada; set => imagenPortada = value; }
        public string ImagenContraportada { get => imagenContraportada; set => imagenContraportada = value; }
        public List<Etiqueta> ListaEtiqueta { get => listaEtiqueta; set => listaEtiqueta = value; }
        public List<UsuarioAccion> ListaAccion { get => listaAccion; set => listaAccion = value; }
        #endregion

        override public string ToString()
        {
            return titulo;
        }

        public int CompareTo(Libro otro)
        {
            if (titulo.CompareTo(otro.titulo) > 0) return 1;
            else if (titulo.CompareTo(otro.titulo) == 0)
            {
                if (isbn_13.CompareTo(otro.isbn_13) > 0) return 1;
                else if (isbn_13 == otro.isbn_13) return 0;
                else return -1;
            }
            else return -1;
        }

        [Serializable]
        internal class IdRepetidoException : Exception
        {
            public IdRepetidoException()
            {
            }

            public IdRepetidoException(string message) : base(message)
            {
            }
        }
    }
}
