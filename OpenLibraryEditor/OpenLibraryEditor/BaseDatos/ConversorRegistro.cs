using MySql.Data.MySqlClient;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.BaseDatos
{
    public class ConversorRegistro
    {
        public static Autor RegistroAAutor(MySqlDataReader registro)
        {
            DateTime fechaNac = registro["fechaNacimiento"].GetType() != typeof(System.DBNull) ?
                DateTime.Parse(registro["fechaNacimiento"].ToString()) : new DateTime();
            DateTime fechaDef = registro["fechaDefuncion"].GetType() != typeof(System.DBNull) ?
                DateTime.Parse(registro["fechaDefuncion"].ToString()) : new DateTime();

            Autor a = new Autor(registro["nombreAutor"].ToString(),
                registro["alias"].ToString(),
                registro["nombreOcupacion"].ToString(),
                fechaNac,
                fechaDef,
                registro["enlaceReferencia"].ToString(),
                registro["comentario"].ToString(),
                null);
            if(registro["imagen"].GetType() != typeof(System.DBNull))
                a.ImagenTemp = (byte[])registro["imagen"];
            a.ListaIdCompartido.Add(ConexionBD.IdBD+"-"+registro["idAutor"].ToString());
            return a;
        }

        public static Editorial RegistroAEditorial(MySqlDataReader registro)
        {
            Editorial e = new Editorial(registro["nombreEditorial"].ToString(),
                registro["comentario"].ToString(),
                null);
            if (registro["imagen"].GetType() != typeof(System.DBNull))
                e.ImagenTemp = (byte[])registro["imagen"];
            e.Imagen = ControladorImagen.RUTA_EDITORIAL + e.IdEditorial;
            e.ListaIdCompartido.Add(ConexionBD.IdBD + "-" + registro["idEditorial"].ToString());
            return e;
        }

        public static Genero RegistroAGenero(MySqlDataReader registro)
        {
            Genero g = new Genero(registro["nombreGenero"].ToString(),
                registro["comentario"].ToString());
            g.ListaIdCompartido.Add(ConexionBD.IdBD + "-" + registro["idGenero"].ToString());
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
            Libro libro = new Libro(registro["titulo"].ToString());
            libro.Isbn_13 = registro["isbn13"].ToString();
            libro.Subtitulo = registro["subtitulo"].ToString();
            libro.TituloAlternativo = registro["tituloAlternativo"].ToString();
            libro.Sinopsis = registro["sinopsis"].ToString();
            libro.NumeroPaginas = int.Parse(registro["numeroPaginas"].ToString());
            if (registro["fechaPublicacion"].GetType() != typeof(System.DBNull))
                libro.FechaPublicacion = DateTime.Parse(registro["fechaPublicacion"].ToString());
            else
                libro.FechaPublicacion = new DateTime();
            if (registro["fechaAdicionBD"].GetType() != typeof(System.DBNull))
                libro.FechaAdicionBD = DateTime.Parse(registro["fechaAdicionBD"].ToString());
            else
                libro.FechaAdicionBD = new DateTime();
            libro.Edicion = int.Parse(registro["edicion"].ToString());
            libro.NumeroVolumen = double.Parse(registro["numeroVolumen"].ToString());
            libro.Idioma = registro["idioma"].ToString();
            libro.IdiomaOriginal = registro["idiomaOriginal"].ToString();
            libro.Isbn_10 = registro["isbn10"].ToString();
            libro.NombreTipo = registro["nombreTipoLibro"].ToString();
            libro.MayorEdad = bool.Parse(registro["mayorEdad"].ToString());
            libro.NumeroCapitulos = int.Parse(registro["numeroCapitulos"].ToString());
            libro.EnlaceReferencia = registro["enlaceReferencia"].ToString();
            libro.ListaIdCompartido.Add(ConexionBD.IdBD + "-" + registro["idLibro"].ToString());
            libro.ImagenPortada = ControladorImagen.RUTA_EDITORIAL + libro.IdLibro+"_c";
            libro.ImagenContraportada = ControladorImagen.RUTA_EDITORIAL + libro.ImagenContraportada+ "_b";
            if (registro["imagenPortada"].GetType() != typeof(System.DBNull))
                libro.PortadaTemp = (byte[])registro["imagenPortada"];
            if (registro["imagenContraportada"].GetType() != typeof(System.DBNull))
                libro.ContraportadaTemp = (byte[])registro["imagenContraportada"];
            return libro;
        }

        public static void RegistroAUsuarioLibro(MySqlDataReader registro, Libro libro)
        {
            libro.Puntuacion = Double.Parse(registro["puntuacion"].ToString());
            libro.VecesLeido = int.Parse(registro["vecesLeido"].ToString());
            libro.TiempoLectura = TimeSpan.Parse(registro["tiempoLectura"].ToString());
            if (registro["fechaComienzo"].GetType() != typeof(System.DBNull))
                libro.FechaComienzo = DateTime.Parse(registro["fechaComienzo"].ToString());
            else
                libro.FechaComienzo = new DateTime();
            if (registro["fechaTerminado"].GetType() != typeof(System.DBNull))
                libro.FechaTerminado = DateTime.Parse(registro["fechaTerminado"].ToString());
            else
                libro.FechaTerminado = new DateTime();
            libro.Comentario = registro["comentario"].ToString();
            libro.CapituloActual = int.Parse(registro["capituloActual"].ToString());
            libro.EstadoLectura = registro["estadoLectura"].ToString();
            libro.Favorito = bool.Parse(registro["favorito"].ToString());
        }
    }
}
