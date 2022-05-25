using Newtonsoft.Json;
using OpenLibraryEditor.BaseDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.DatosLibros
{
    public class Libro : IComparable<Libro>, IOperacionesBD
    {
        //Datos de libro comunes
        private List<string> listaIdCompartido = new List<string>();
        private int idLibro;
        private string isbn_13;
        private string titulo;
        private string subtitulo;
        private string tituloAlternativo;
        private string sinopsis;
        private int numeroPaginas;
        private List<Editorial> listaEditorial = new List<Editorial>();
        private DateTime fechaPublicacion;
        private DateTime fechaAdicionBD; //Fecha de inclusión en base de datos local
        private int edicion;
        private List<Serie> listaSerie = new List<Serie>();
        private double numeroVolumen; //Para series de múltiples volúmenes
        private string idioma;
        private string isbn_10;
        private List<Genero> listaGenero = new List<Genero>();
        private List<Autor> listaAutor = new List<Autor>();
        private string imagenPortada;
        private string imagenContraportada;
        private byte[] portadaTemp;
        private byte[] contraportadaTemp;
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
        private TimeSpan tiempoLectura;
        private string comentario; 
        private int capituloActual;
        private DateTime fechaComienzo;
        private DateTime fechaTerminado; 
        private bool ocultar;
        private bool favorito;

        public Libro()
        {
        }

        public Libro(string titulo)
        {
            SetRandomId();
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
        public TimeSpan TiempoLectura { get => tiempoLectura; set => tiempoLectura = value; }
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
        public List<string> ListaIdCompartido { get => listaIdCompartido; set => listaIdCompartido = value; }
        public int IdLibro { get => idLibro; set => idLibro = value; }
        [JsonIgnore]
        public byte[] PortadaTemp { get => portadaTemp; set => portadaTemp = value; }
        [JsonIgnore]
        public byte[] ContraportadaTemp { get => contraportadaTemp; set => contraportadaTemp = value; }
        #endregion

        override public string ToString()
        {
            return titulo;
        }

        public void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idLibro = rnd.Next();
            } while (Biblioteca.biblioteca.ListaLibro.
                FindIndex(p => idLibro == p.idLibro) != -1);
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

        private void InsertarListasBD()
        {
            //Pasar autores del libro a BD
            foreach (Autor autor in listaAutor)
            {
                autor.MeterEnBDCompartida();
                EscrituraBD.InsertListaAutor(this, autor);
            }

            //Pasar genero del libro a BD
            foreach (Genero genero in listaGenero)
            {
                genero.MeterEnBDCompartida();
                EscrituraBD.InsertListaGenero(this, genero);
            }

            //Pasar editorial del libro a BD
            foreach (Editorial editorial in listaEditorial)
            {
                editorial.MeterEnBDCompartida();
                EscrituraBD.InsertListaEditorial(this, editorial);
            }
        }

        public void MeterEnBDCompartida()
        {
            LimpiadoDeListasBDCompartida();

            //Comprobar si no existe Ocupacion para añadirlo
            if (!String.IsNullOrWhiteSpace(nombreTipo) &&
                LecturaBD.SelectTipoLibro(nombreTipo) == null)
                EscrituraBD.InsertTipoLibro(nombreTipo);

            if (EscrituraBD.GetObjetoIdDeLocal(listaIdCompartido) > 0)
            {
                EscrituraBD.UpdateLibro(this);
                InsertarListasBD();
            }
            else
            {
                EscrituraBD.InsertLibro(this);
                InsertarListasBD();
            }
        }

        public void BorraDeBDCompartida()
        {
            LimpiadoDeListasBDCompartida();

            //Borrar de UsuarioLibro todas las relaciones con info de usuarios con ese libro
            if(LecturaBD.SelectUsuarioLibroExiste(
                        UsuarioDatos.configuracionUsuario.InfoUsuarioActual.Nombre,
                        this) > 0)
                EscrituraBD.DeleteUsuarioLibroDesdeLibro(this);

            //Comprobar si ningun libro que queda tiene el tipo de libro
            if (!String.IsNullOrWhiteSpace(nombreTipo) &&
                LecturaBD.SelectTipoLibroCantidadPorLibro(nombreTipo) == 0)
                EscrituraBD.DeleteTipoLibro(nombreTipo);

            EscrituraBD.DeleteLibro(this);
        }

        private void LimpiadoDeListasBDCompartida()
        {
            //Borramos desde Libro todas las relaciones con Autores, Generos y Editoriales
            EscrituraBD.DeleteListaAutorDesdeLibro(this);
            EscrituraBD.DeleteListaEditorialDesdeLibro(this);
            EscrituraBD.DeleteListaGeneroDesdeLibro(this);
        }

        public void MeterUsuarioLibroEnBDCompartida()
        {
            var usuario = UsuarioDatos.configuracionUsuario.InfoUsuarioActual;
            if (LecturaBD.SelectUsuarioLibroExiste(usuario.Nombre, this) > 0)
            {
                EscrituraBD.UpdateUsuarioLibro(usuario.Nombre, this, usuario);
            }
            else
            {
                EscrituraBD.InsertUsuarioLibro(this, usuario);
            }
        }

        public void BorrarUsuarioLibroEnBDCompartida()
        {
            EscrituraBD.DeleteUsuarioLibro(this, 
                UsuarioDatos.configuracionUsuario.InfoUsuarioActual);
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
