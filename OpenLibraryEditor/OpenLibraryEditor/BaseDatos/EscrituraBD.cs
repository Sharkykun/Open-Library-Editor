using MySql.Data.MySqlClient;
using OpenLibraryEditor.Clases;
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

        #region Procesos varios
        internal static void InsertarIdBD(int id)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            INSERT INTO `Biblioteca` VALUES (" + id + ");", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void ComprobarFK(bool esActivado)
        {
            int i = esActivado ? 1 : 0;
            MySqlCommand tabla = new MySqlCommand(@"SET foreign_key_checks = " + i, ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        private static int SetRandomId(string tablaNombre, string campo)
        {
            Random rnd = new Random();
            int i;
            do
            {
                i = rnd.Next();
            } while (LecturaBD.SelectObtenerIdNuevoTabla(tablaNombre, campo, i) > 0);
            return i;
        }

        private static int GetObjetoIdDeLocal(List<string> listaIdCompartido)
        {
            return int.Parse(listaIdCompartido.Find(p =>
                p.Contains(ConexionBD.idBD.ToString())).Split('-')[1]);
        }

        private static Nullable<int> GetGeneroPadreIdObjeto(Genero genero)
        {
            //Obtener genero padre Id si no es null
            Nullable<int> i;
            if (genero.GeneroPadre != null)
                i = GetObjetoIdDeLocal(genero.GeneroPadre.ListaIdCompartido);
            else
                i = null;
            return i;
        }
        #endregion

        #region Libro
        public static void InsertLibro(Libro libro)
        {
            int id = SetRandomId("Libro", "idLibro");
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Libro` VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',
'{8}',{9},{10},'{11}','{12}','{13}','{14}','{15}','{16}',{17},{18},'{19}');",
            id,
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
            ControladorImagen.RenombrarImagen(libro.ImagenPortada, id.ToString()),
            ControladorImagen.RenombrarImagen(libro.ImagenContraportada, id.ToString()),
            libro.NombreTipo,
            libro.MayorEdad,
            libro.NumeroCapitulos,
            libro.EnlaceReferencia), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateLibro(Libro libro)
        {

            int id = GetObjetoIdDeLocal(libro.ListaIdCompartido);
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
                WHERE idLibro = '" + id + "';",
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
            ControladorImagen.RenombrarImagen(libro.ImagenPortada, id.ToString()),
            ControladorImagen.RenombrarImagen(libro.ImagenContraportada, id.ToString()),
            libro.NombreTipo,
            libro.MayorEdad,
            libro.NumeroCapitulos,
            libro.EnlaceReferencia), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteLibro(Libro libro)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Libro` WHERE idLibro = "
                + GetObjetoIdDeLocal(libro.ListaIdCompartido),
            ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region Autor
        public static void InsertAutor(Autor autor)
        {
            //Comprobar si existe Ocupacion
            if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                InsertOcupacion(autor.NombreOcupacion);

            int id = SetRandomId("Autor", "idAutor");
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Autor` VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
            id,
            autor.Nombre,
            autor.Alias,
            autor.NombreOcupacion,
            autor.FechaNacimiento.ToShortDateString(),
            autor.FechaDefuncion.ToShortDateString(),
            autor.EnlaceReferencia,
            autor.Comentario,
            ControladorImagen.RenombrarImagen(autor.Imagen, id.ToString())), 
            ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateAutor(Autor autor)
        {
            //Comprobar si no existe Ocupacion para añadirlo
            if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                InsertOcupacion(autor.NombreOcupacion);

            int id = GetObjetoIdDeLocal(autor.ListaIdCompartido);
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Autor` SET nombreAutor = '{0}',
                alias = '{1}',
                nombreOcupacion = '{2}',
                fechaNacimiento = '{3}',
                fechaDefuncion = '{4}',
                enlaceReferencia = '{5}',
                comentario = '{6}',
                imagen = '{7}'
                WHERE idAutor = '" + id + "';",
            autor.Nombre,
            autor.Alias,
            autor.NombreOcupacion,
            autor.FechaNacimiento.ToShortDateString(),
            autor.FechaDefuncion.ToShortDateString(),
            autor.EnlaceReferencia,
            autor.Comentario,
            ControladorImagen.RenombrarImagen(autor.Imagen, id.ToString())), 
            ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteAutor(Autor autor)
        {
            //Comprobar si ningun autor que queda tiene la Ocupacion
            //if (LecturaBD.SelectOcupacionCantidadPorAutor(autor.NombreOcupacion) <= 1)
            //    DeleteOcupacion(autor.NombreOcupacion);

            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Autor` WHERE idAutor = " +
            GetObjetoIdDeLocal(autor.ListaIdCompartido), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region Genero
        public static void InsertGenero(Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Genero` VALUES ({0},'{1}',{2},'{3}');",
            SetRandomId("Genero", "idGenero"),
            genero.Nombre,
            GetGeneroPadreIdObjeto(genero),
            genero.Comentario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateGenero(Genero genero)
        {
            int id = GetObjetoIdDeLocal(genero.ListaIdCompartido);
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Genero` SET nombreGenero = '{0}',
                generoPadre = {1},
                comentario = '{2}'
                WHERE idGenero = '" + id + "';",
            genero.Nombre,
            GetGeneroPadreIdObjeto(genero),
            genero.Comentario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteGenero(Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Genero` WHERE idGenero = '" +
                GetObjetoIdDeLocal(genero.ListaIdCompartido),
            ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region Editorial
        public static void InsertEditorial(Editorial editorial)
        {
            int id = SetRandomId("Editorial", "idEditorial");
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `Editorial` VALUES ({0},'{1}','{2}','{3}');",
            id,
            editorial.Nombre,
            editorial.Comentario,
            ControladorImagen.RenombrarImagen(editorial.Imagen, id.ToString())), 
            ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateEditorial(Editorial editorial)
        {
            int id = GetObjetoIdDeLocal(editorial.ListaIdCompartido);
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Editorial` SET nombreEditorial = '{0}',
                comentario = '{1}',
                imagen = '{2}'
                WHERE idEditorial = '" + id + "';",
            editorial.Nombre,
            editorial.Comentario,
            ControladorImagen.RenombrarImagen(editorial.Imagen, id.ToString())),
            ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteEditorial(Editorial editorial)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Editorial` WHERE idEditorial = " +
            GetObjetoIdDeLocal(editorial.ListaIdCompartido),
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region Ocupacion
        public static void InsertOcupacion(string ocupacion)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            INSERT INTO `Ocupacion` VALUES ('" + ocupacion + "');", ConexionBD.conexion);
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
            UPDATE `Ocupacion` SET nombreOcupacion = '" + ocupacionNueva + "' WHERE nombreOcupacion = '" + ocupacionOriginal + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
            ComprobarFK(true);
        }

        public static void DeleteOcupacion(string ocupacion)
        {
            //Quitar la referencia en todos los autores
            MySqlCommand tabla = new MySqlCommand(@"
            UPDATE `Autor` SET nombreOcupacion = NULL WHERE nombreOcupacion='" + ocupacion + "' ", ConexionBD.conexion);
            tabla.ExecuteNonQuery();

            tabla = new MySqlCommand(@"
            DELETE FROM `Ocupacion` WHERE nombreOcupacion = '" + ocupacion + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region TipoLibro
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
        #endregion

        #region Usuario
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

        public static void UpdateUsuario(string nombreOriginal, InfoUsuarioBD usuario, string contrasenia)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Usuario` SET correoUsuario = '{0}',
                nombreUsuario = '{1}',
                contrasenia = '{2}',
                tipoUsuario = '{3}' 
                WHERE nombreUsuario = '" + nombreOriginal + "';",
            usuario.Correo,
            usuario.Nombre,
            contrasenia,
            usuario.TipoUsuario), ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteUsuario(InfoUsuarioBD usuario)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Usuario` WHERE nombreUsuario = '" + usuario.Nombre + "';",
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region UsuarioLibro
        public static void InsertUsuarioLibro(Libro libro, InfoUsuarioBD usuario)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `UsuarioLibro` VALUES ('{0}',{1},{2},{3},'{4}','{5}','{6}',
'{7}',{8},'{9}',{10},{11});",
            usuario.Nombre,
            GetObjetoIdDeLocal(libro.ListaIdCompartido),
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

        public static void UpdateUsuarioLibro(string nombreOriginal, Libro libro, InfoUsuarioBD usuario)
        {
            int id = GetObjetoIdDeLocal(libro.ListaIdCompartido);
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `UsuarioLibro` SET nombreUsuario = '{0}',
                idLibro = {1},
                puntuacion = {2},
                vecesLeido = {3},
                tiempoLectura = '{4}',
                fechaComienzo = '{5}',
                fechaTerminado = '{6}',
                comentario = '{7}',
                capituloActual = {8},
                estadoLectura = '{9}',
                ocultar = {10},
                favorito = {11}
                WHERE nombreUsuario = '" + nombreOriginal + "' and " +
                "idLibro = " + id + ";",
            usuario.Nombre,
            GetObjetoIdDeLocal(libro.ListaIdCompartido),
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
            DELETE FROM `UsuarioLibro` WHERE nombreUsuario = '" + usuario.Nombre + "' and " +
                "idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion

        #region Listas
        public static void InsertListaEditorial(Libro libro, Editorial editorial)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `ListaEditorial` VALUES ({0},{1});",
            GetObjetoIdDeLocal(editorial.ListaIdCompartido),
            GetObjetoIdDeLocal(libro.ListaIdCompartido))
                , ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteListaEditorial(Libro libro, Editorial editorial)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `ListaEditorial` WHERE idEditorial = " + GetObjetoIdDeLocal(editorial.ListaIdCompartido)
            + " and " +
                "idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertListaAutor(Libro libro, Autor autor)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `ListaAutor` VALUES ({0},{1});",
            GetObjetoIdDeLocal(autor.ListaIdCompartido),
            GetObjetoIdDeLocal(libro.ListaIdCompartido))
                , ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteListaAutor(Libro libro, Autor autor)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `ListaAutor` WHERE idAutor = " + GetObjetoIdDeLocal(autor.ListaIdCompartido)
            + " and " +
                "idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void InsertListaGenero(Libro libro, Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            INSERT INTO `ListaGenero` VALUES ({0},{1});",
            GetObjetoIdDeLocal(genero.ListaIdCompartido),
            GetObjetoIdDeLocal(libro.ListaIdCompartido))
                , ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void DeleteListaGenero(Libro libro, Genero genero)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `ListaGenero` WHERE idGenero = " + GetObjetoIdDeLocal(genero.ListaIdCompartido)
            + " and " +
                "idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
        #endregion
    }
}
