using MySql.Data.MySqlClient;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.BaseDatos
{
    public class EscrituraBD
    {
        /*
         TODO:
        - Control try-catch para evitar que deje de funcionar la app. Debe reintentar conectar.
        - Añadir control de relaciones en los métodos de escritura.
        */

        public static void ComprobarFK(bool esActivado)
        {
            int i = esActivado ? 1 : 0;
            MySqlCommand tabla = new MySqlCommand(@"SET foreign_key_checks = "+i, ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertOcupacion(string ocupacion)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            INSERT INTO `Ocupacion` VALUES ('"+ocupacion+"');", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateOcupacion(string ocupacionOriginal, string ocupacionNueva)
        {
            ComprobarFK(false);
            //Cambiar la referencia en todos los autores
            MySqlCommand tabla = new MySqlCommand(@"
            UPDATE `Autor` SET nombreOcupacion = '" + ocupacionNueva + "'  WHERE nombreOcupacion='" + ocupacionOriginal + "' ", ConexionBD.conexion);
            tabla.ExecuteNonQuery();

            tabla = new MySqlCommand(@"
            UPDATE `Ocupacion` SET nombreOcupacion = '" + ocupacionNueva + "' WHERE nombreOcupacion = '"+ ocupacionOriginal + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
            ComprobarFK(true);
        }

        public static void DeleteOcupacion(string ocupacion)
        {
            //Quitar la referencia en todos los autores
            MySqlCommand tabla = new MySqlCommand(@"
            UPDATE `Autor` SET nombreOcupacion = NULL WHERE nombreOcupacion='" + ocupacion+"' ", ConexionBD.conexion);
            tabla.ExecuteNonQuery();

            tabla = new MySqlCommand(@"
            DELETE FROM `Ocupacion` WHERE nombreOcupacion = '" + ocupacion + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertAutor(Autor autor)
        {
            //Comprobar si existe Ocupacion
            if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                InsertOcupacion(autor.NombreOcupacion);

            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Autor` VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
            autor.Nombre,
            autor.Alias,
            autor.NombreOcupacion,
            autor.FechaNacimiento.ToShortDateString(),
            autor.FechaDefuncion.ToShortDateString(),
            autor.EnlaceReferencia,
            autor.Comentario,
            autor.Imagen), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateAutor(string nombreOriginal, Autor autor)
        {
            //Comprobar si no existe Ocupacion para añadirlo
            if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                InsertOcupacion(autor.NombreOcupacion);

            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Autor` SET nombreAutor = '{0}',
                alias = '{1}',
                nombreOcupacion = '{2}',
                fechaNacimiento = '{3}',
                fechaDefuncion = '{4}',
                enlaceReferencia = '{5}',
                comentario = '{6}',
                imagen = '{7}'
                WHERE nombreAutor = '"+ nombreOriginal + "';",
            autor.Nombre,
            autor.Alias,
            autor.NombreOcupacion,
            autor.FechaNacimiento.ToShortDateString(),
            autor.FechaDefuncion.ToShortDateString(),
            autor.EnlaceReferencia,
            autor.Comentario,
            autor.Imagen), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteAutor(Autor autor)
        {
            //Comprobar si ningun autor que queda tiene la Ocupacion
            //if (LecturaBD.SelectOcupacionCantidadPorAutor(autor.NombreOcupacion) <= 1)
            //    DeleteOcupacion(autor.NombreOcupacion);

            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Autor` WHERE nombreAutor = '" + autor.Nombre + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertEditorial(Editorial editorial)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Editorial` VALUES ('{0}','{1}','{2}');",
            editorial.Nombre,
            editorial.Comentario,
            editorial.Imagen), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateEditorial(string nombreOriginal, Editorial editorial)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Editorial` SET nombreEditorial = '{0}',
                comentario = '{1}',
                imagen = '{2}'
                WHERE nombreAutor = '" + nombreOriginal + "';",
            editorial.Nombre,
            editorial.Comentario,
            editorial.Imagen), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteEditorial(Editorial editorial)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Editorial` WHERE nombreEditorial = '" + editorial.Nombre + "';",
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertGenero(Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Genero` VALUES ('{0}','{1}','{2}');",
            genero.Nombre,
            genero.GeneroPadre.Nombre,
            genero.Comentario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateGenero(string nombreOriginal, Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Genero` SET nombreGenero = '{0}',
                generoPadre = '{1}',
                comentario = '{2}'
                WHERE nombreAutor = '" + nombreOriginal + "';",
            genero.Nombre,
            genero.GeneroPadre.Nombre,
            genero.Comentario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteGenero(Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Genero` WHERE nombreGenero = '" + genero.Nombre + "';",
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertLibro(Libro libro)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Libro` VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}',
'{7}',{8},{9},'{10}','{11}','{12}','{13}','{14}','{15}',{16},{17},'{18}');",
            libro.Isbn_13,
            libro.Titulo,
            libro.Subtitulo,
            libro.TituloAlternativo,
            libro.Sinopsis,
            libro.NumeroPaginas,
            libro.FechaPublicacion,
            libro.FechaAdicionBD,
            libro.Edicion,
            libro.NumeroVolumen,
            libro.Idioma,
            libro.IdiomaOriginal,
            libro.Isbn_10,
            libro.ImagenPortada,
            libro.ImagenContraportada,
            libro.NombreTipo,
            libro.MayorEdad,
            libro.NumeroCapitulos,
            libro.EnlaceReferencia), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateLibro(string isbn13Original, Libro libro)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Libro` SET isbn13 = '{0}',
                titulo = '{1}',
                subtitulo = '{2}',
                tituloAlternativo = '{3}',
                sinopsis = '{4}',
                numeroPaginas = {5},
                fechaPublicacion = '{6}',
                fechaAdicionBD = '{7}',
                edicion = {8},
                numeroVolumen = {9},
                idioma = '{10}',
                idiomaOriginal = '{11}',
                isbn10 = '{12}',
                imagenPortada = '{13}',
                imagenContraportada = '{14}',
                nombreTipoLibro = '{15}',
                mayorEdad = {16},
                numeroCapitulos = {17},
                enlaceReferencia = '{18}',
                WHERE isbn13 = '" + isbn13Original + "';",
            libro.Isbn_13,
            libro.Titulo,
            libro.Subtitulo,
            libro.TituloAlternativo,
            libro.Sinopsis,
            libro.NumeroPaginas,
            libro.FechaPublicacion,
            libro.FechaAdicionBD,
            libro.Edicion,
            libro.NumeroVolumen,
            libro.Idioma,
            libro.IdiomaOriginal,
            libro.Isbn_10,
            libro.ImagenPortada,
            libro.ImagenContraportada,
            libro.NombreTipo,
            libro.MayorEdad,
            libro.NumeroCapitulos,
            libro.EnlaceReferencia), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteLibro(Libro libro)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Libro` WHERE isbn13 = '" + libro.Isbn_13 + "';",
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertTipoLibro(string tipoLibro)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            INSERT INTO `TipoLibro` VALUES ('" + tipoLibro + "');", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateTipoLibro(string tipoLibroOriginal, string tipoLibroNuevo)
        {
            ComprobarFK(false);
            //Cambiar la referencia en todos los libros
            MySqlCommand tabla = new MySqlCommand(@"
            UPDATE `Libro` SET nombreTipoLibro = '" + tipoLibroNuevo + "'  WHERE nombreTipoLibro='" + tipoLibroOriginal + "' ", ConexionBD.conexion);
            tabla.ExecuteNonQuery();

            tabla = new MySqlCommand(@"
            UPDATE `TipoLibro` SET nombreTipoLibro = '" + tipoLibroNuevo + "' WHERE nombreTipoLibro = '" + tipoLibroOriginal + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
            ComprobarFK(true);
        }

        public static void DeleteTipoLibro(string tipoLibro)
        {
            //Quitar la referencia en todos los autores
            MySqlCommand tabla = new MySqlCommand(@"
            UPDATE `Libro` SET nombreTipoLibro = NULL WHERE nombreTipoLibro='" + tipoLibro + "' ", ConexionBD.conexion);
            tabla.ExecuteNonQuery();

            tabla = new MySqlCommand(@"
            DELETE FROM `TipoLibro` WHERE nombreTipoLibro = '" + tipoLibro + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertUsuario(InfoUsuarioBD usuario, string contrasenia)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Usuario` VALUES ('{0}','{1}','{2}','{3}');",
            usuario.Correo,
            usuario.Nombre,
            contrasenia,
            usuario.TipoUsuario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateUsuario(string correoOriginal, InfoUsuarioBD usuario, string contrasenia)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Usuario` SET correoUsuario = '{0}',
                nombreUsuario = '{1}',
                contrasenia = '{2}',
                tipoUsuario = '{3}' 
                WHERE nombreAutor = '" + correoOriginal + "';",
            usuario.Correo,
            usuario.Nombre,
            contrasenia,
            usuario.TipoUsuario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteUsuario(InfoUsuarioBD usuario)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Usuario` WHERE correoUsuario = '" + usuario.Correo + "';",
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertUsuarioLibro(Libro libro, InfoUsuarioBD usuario)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `UsuarioLibro` VALUES ('{0}','{1}',{2},{3},'{4}','{5}','{6}',
'{7}',{8},'{9}',{10},{11});",
            usuario.Correo,
            libro.Isbn_13,
            libro.Puntuacion,
            libro.VecesLeido,
            libro.TiempoLectura,
            libro.FechaComienzo,
            libro.FechaTerminado,
            libro.Comentario,
            libro.CapituloActual,
            libro.EstadoLectura,
            libro.Ocultar,
            libro.Favorito), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateUsuarioLibro(string isbn13Original, string correoOriginal, Libro libro, InfoUsuarioBD usuario)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `UsuarioLibro` SET correoUsuario = '{0}',
                isbn13 = '{1}',
                puntuacion = {2},
                vecesLeido = {3},
                tiempoLectura = '{4}',
                fechaComienzo = '{5}',
                fechaTerminado = '{6}',
                comentario = '{7}',
                capituloActual = {8},
                estadoLectura = '{9}',
                ocultar = {10},
                favorito = {11},
                WHERE correoUsuario = '" + correoOriginal + "' and " +
                "isbn13 = "+ isbn13Original + ";",
            usuario.Correo,
            libro.Isbn_13,
            libro.Puntuacion,
            libro.VecesLeido,
            libro.TiempoLectura,
            libro.FechaComienzo,
            libro.FechaTerminado,
            libro.Comentario,
            libro.CapituloActual,
            libro.EstadoLectura,
            libro.Ocultar,
            libro.Favorito), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteUsuarioLibro(Libro libro, InfoUsuarioBD usuario)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `UsuarioLibro` WHERE correoUsuario = '" + usuario.Correo + "' and " +
                "isbn13 = " + libro.Isbn_13 + ";",
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
    }
}
