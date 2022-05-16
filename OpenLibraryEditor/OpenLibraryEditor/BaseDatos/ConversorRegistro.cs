using MySql.Data.MySqlClient;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.BaseDatos
{
    public class ConversorRegistro
    {
        public static Autor RegistroAAutor(MySqlDataReader registro)
        {
            Autor a = new Autor(registro["nombreAutor"].ToString(),
                registro["alias"].ToString(),
                registro["nombreOcupacion"].ToString(),
                DateTime.Parse(registro["fechaNacimiento"].ToString()),
                DateTime.Parse(registro["fechaDefuncion"].ToString()),
                registro["enlaceReferencia"].ToString(),
                registro["comentario"].ToString(),
                registro["imagen"].ToString());
            a.ListaIdCompartido.Add(ConexionBD.idBD+"-"+registro["idAutor"].ToString());
            return a;
        }

        public static Editorial RegistroAEditorial(MySqlDataReader registro)
        {
            Editorial e = new Editorial(registro["nombreEditorial"].ToString(),
                registro["comentario"].ToString(),
                registro["imagen"].ToString());
            e.ListaIdCompartido.Add(ConexionBD.idBD + "-" + registro["idEditorial"].ToString());
            return e;
        }

        public static Genero RegistroAGenero(MySqlDataReader registro)
        {
            //Si tiene genero padre, sacarlo recursivamente
            Genero generoPadre = null;
            if (registro["generoPadre"].ToString() == null)
                generoPadre = LecturaBD.SelectGenero(Convert.ToInt32(registro["generoPadre"]));

            Genero g = new Genero(registro["nombreGenero"].ToString(),
                generoPadre,
                registro["comentario"].ToString());
            g.ListaIdCompartido.Add(ConexionBD.idBD + "-" + registro["idGenero"].ToString());
            return g;
        }

        public static InfoUsuarioBD RegistroAUsuarioInfo(MySqlDataReader registro)
        {
            return new InfoUsuarioBD(registro["nombreUsuario"].ToString(),
                registro["correoUsuario"].ToString(),
                registro["tipoUsuario"].ToString());
        }

        public static Libro RegistroALibro(MySqlDataReader registro)
        {
            Libro libro = new Libro();
            libro.Isbn_13 = registro["isbn13"].ToString();
            libro.Titulo = registro["titulo"].ToString();
            libro.Subtitulo = registro["subtitulo"].ToString();
            libro.TituloAlternativo = registro["tituloAlternativo"].ToString();
            libro.Sinopsis = registro["sinopsis"].ToString();
            libro.NumeroPaginas = int.Parse(registro["numeroPaginas"].ToString());
            libro.FechaPublicacion = DateTime.Parse(registro["fechaPublicacion"].ToString());
            libro.FechaAdicionBD = DateTime.Parse(registro["fechaAdicionBD"].ToString());
            libro.Edicion = int.Parse(registro["edicion"].ToString());
            libro.NumeroVolumen = double.Parse(registro["numeroVolumen"].ToString());
            libro.Idioma = registro["idioma"].ToString();
            libro.IdiomaOriginal = registro["idiomaOriginal"].ToString();
            libro.Isbn_10 = registro["isbn10"].ToString();
            libro.ImagenPortada = registro["imagenPortada"].ToString();
            libro.ImagenContraportada = registro["imagenContraportada"].ToString();
            libro.NombreTipo = registro["nombreTipoLibro"].ToString();
            libro.MayorEdad = bool.Parse(registro["mayorEdad"].ToString());
            libro.NumeroCapitulos = int.Parse(registro["numeroCapitulos"].ToString());
            libro.EnlaceReferencia = registro["enlaceReferencia"].ToString();
            libro.ListaIdCompartido.Add(ConexionBD.idBD + "-" + registro["idLibro"].ToString());
            return libro;
        }

        public static void RegistroAUsuarioLibro(MySqlDataReader registro, Libro libro)
        {
            libro.Puntuacion = Double.Parse(registro["puntuacion"].ToString());
            libro.VecesLeido = int.Parse(registro["vecesLeido"].ToString());
            libro.TiempoLectura = TimeSpan.Parse(registro["tiempoLectura"].ToString());
            libro.FechaComienzo = DateTime.Parse(registro["fechaComienzo"].ToString());
            libro.FechaTerminado = DateTime.Parse(registro["fechaTerminado"].ToString());
            libro.Comentario = registro["comentario"].ToString();
            libro.CapituloActual = int.Parse(registro["capituloActual"].ToString());
            libro.EstadoLectura = registro["estadoLectura"].ToString();
            libro.Ocultar = bool.Parse(registro["ocultar"].ToString());
            libro.Favorito = bool.Parse(registro["favorito"].ToString());
        }
    }
}
