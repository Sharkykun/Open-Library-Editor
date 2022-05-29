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
         NOTAS TODO:
            - Try-catch de control por si fallo de aconexion realizados falta hacer metodo de reconexion a BD tras fallo.
            - Comprobaciones en inserts,deletes y updates realizadas y mensaje de error sale si algo a pasado.

         TODO:
            - Control try-catch para evitar que deje de funcionar la app. Debe reintentar conectar.
            - Añadir control de relaciones en los métodos de escritura.
            - Si un usuario borra, y otro usuario sigue teniendo la referencia en listaIdCompartido para ese objeto ya borrado, ¿como lo quitamos?
            - Hacer que suba la imagen al servidor, y confirma que el renombrado va bien.
         */

        #region Procesos varios
        internal static void InsertarIdBD(int id)
        {
            try
            {
                MySqlCommand tabla = new MySqlCommand(@"
                INSERT INTO `Biblioteca` VALUES (" + id + ");", ConexionBD.Conexion);
                tabla.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void ComprobarFK(bool esActivado)
        {
            int i = esActivado ? 1 : 0;

            try
            {
                MySqlCommand tabla = new MySqlCommand(@"SET foreign_key_checks = " + i, ConexionBD.Conexion);
                tabla.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        private static int SetRandomId(string tablaNombre, string campo)
        {
            Random rnd = new Random();
            int i = -1;

            try
            {
                do
                {
                    i = rnd.Next()+1;
                } while (LecturaBD.SelectObtenerIdTablaNuevo(tablaNombre, campo, i) > 0);
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }

           
            return i;
        }

        public static int GetObjetoIdDeLocal(List<string> listaIdCompartido)
        {
            try
            {
                if(listaIdCompartido.Count > 0 && listaIdCompartido.Exists(p =>
                    p.Contains(ConexionBD.IdBD.ToString())))
                        return int.Parse(listaIdCompartido.Find(p =>
                        p.Contains(ConexionBD.IdBD.ToString())).Split('-')[1]);
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }

            return 0;
        }
        #endregion

        #region Libro
        private static MySqlCommand ComprobarLibroExiste(Libro libro)
        {
            // Se comprueba primero que el libro no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Libro WHERE idLibro = " +
                GetObjetoIdDeLocal(libro.ListaIdCompartido)),
                ConexionBD.Conexion);
        }

        // NOTA: Comprobaciones en libros hechas
        public static void InsertLibro(Libro libro)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarLibroExiste(libro);

                // Si esta da 0 entonces que se meta el nuevo libro
                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    int id = SetRandomId("Libro", "idLibro");
                    byte[] img = ControladorImagen.ImagenAByteArray(libro.ImagenPortada);
                    byte[] img2 = ControladorImagen.ImagenAByteArray(libro.ImagenContraportada);
                    MySqlCommand insertLibro = new MySqlCommand(String.Format(@"
                    INSERT INTO `Libro` VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',
                    '{8}',{9},{10},'{11}','{12}','{13}',@portada,@contraportada,{14},{15},{16},'{17}');",
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
                    String.IsNullOrWhiteSpace(libro.NombreTipo) ? "NULL" : "'" + libro.NombreTipo + "'",
                    libro.MayorEdad,
                    libro.NumeroCapitulos,
                    libro.EnlaceReferencia), ConexionBD.Conexion);
                    insertLibro.Parameters.Add("@portada", MySqlDbType.MediumBlob, img == null ? 0 : img.Length).Value = img;
                    insertLibro.Parameters.Add("@contraportada", MySqlDbType.MediumBlob, img2 == null ? 0 : img2.Length).Value = img2;
                    insertLibro.ExecuteNonQuery();
                    libro.ListaIdCompartido.Add(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("LibroRepetido"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }

        }

        public static void UpdateLibro(Libro libro)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarLibroExiste(libro);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    int id = GetObjetoIdDeLocal(libro.ListaIdCompartido);
                    byte[] img = ControladorImagen.ImagenAByteArray(libro.ImagenPortada);
                    byte[] img2 = ControladorImagen.ImagenAByteArray(libro.ImagenContraportada);
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
                    imagenPortada = @portada,
                    imagenContraportada = @contraportada,
                    nombreTipoLibro = {13},
                    mayorEdad = {14},
                    numeroCapitulos = {15},
                    enlaceReferencia = '{16}'
                    WHERE idLibro = " + id + ";",
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
                    String.IsNullOrWhiteSpace(libro.NombreTipo) ? "NULL" : "'" + libro.NombreTipo + "'",
                    libro.MayorEdad,
                    libro.NumeroCapitulos,
                    libro.EnlaceReferencia), ConexionBD.Conexion);
                    tabla.Parameters.Add("@portada", MySqlDbType.MediumBlob, img == null ? 0 : img.Length).Value = img;
                    tabla.Parameters.Add("@contraportada", MySqlDbType.MediumBlob, img2 == null ? 0 : img2.Length).Value = img2;
                    tabla.ExecuteNonQuery();

                }
                else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("NoExisteLibro"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void DeleteLibro(Libro libro)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarLibroExiste(libro);

                // Se elimian el libro si este se encuentra
                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    int id = GetObjetoIdDeLocal(libro.ListaIdCompartido);
                    MySqlCommand tabla = new MySqlCommand(@"
                DELETE FROM `Libro` WHERE idLibro = "
                    + id,
                    ConexionBD.Conexion);

                    tabla.ExecuteNonQuery();
                    libro.ListaIdCompartido.Add(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("NoPuedeBorrarLibro"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }



        }
        #endregion

        #region Autor

        // NOTA: Termiando las comprobaciones de autor y sigo sin ver lo de añadir la ocupacion si 
        // no existe por mi lo dejamos null el campo en esa tabal y que después el usuario meta
        // la ocupacion al autor 
        private static MySqlCommand ComprobarAutorExiste(Autor autor)
        {
            // Se comprueba primero que el autor no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Autor WHERE idAutor = " +
                GetObjetoIdDeLocal(autor.ListaIdCompartido)),
                ConexionBD.Conexion);
        }

        public static void InsertAutor(Autor autor)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarAutorExiste(autor);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    // Comprobar si existe Ocupacion
                    //if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                    //    InsertOcupacion(autor.NombreOcupacion);
                    string ocupacion = String.IsNullOrWhiteSpace(autor.NombreOcupacion) ? "NULL" : "'" + autor.NombreOcupacion + "'";

                    int id = SetRandomId("Autor", "idAutor");
                    byte[] img = ControladorImagen.ImagenAByteArray(autor.Imagen);
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `Autor` VALUES ({0},'{1}','{2}',{3},'{4}','{5}','{6}','{7}',@imagen);",
                    id,
                    autor.Nombre,
                    autor.Alias,
                    ocupacion,
                    autor.FechaNacimiento.ToShortDateString(),
                    autor.FechaDefuncion.ToShortDateString(),
                    autor.EnlaceReferencia,
                    autor.Comentario),
                    ConexionBD.Conexion);
                    tabla.Parameters.Add("@imagen", MySqlDbType.MediumBlob, img==null ? 0 : img.Length).Value = img;
                    tabla.ExecuteNonQuery();
                    autor.ListaIdCompartido.Add(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                    
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("AutorRepetido"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void UpdateAutor(Autor autor)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarAutorExiste(autor);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    //Comprobar si no existe Ocupacion para añadirlo
                    //if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                    //    InsertOcupacion(autor.NombreOcupacion);

                    int id = GetObjetoIdDeLocal(autor.ListaIdCompartido);
                    byte[] img = ControladorImagen.ImagenAByteArray(autor.Imagen);
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    UPDATE `Autor` SET nombreAutor = '{0}',
                    alias = '{1}',
                    nombreOcupacion = {2},
                    fechaNacimiento = '{3}',
                    fechaDefuncion = '{4}',
                    enlaceReferencia = '{5}',
                    comentario = '{6}',
                    imagen = @imagen
                    WHERE idAutor = '" + id + "';",
                    autor.Nombre,
                    autor.Alias,
                    String.IsNullOrWhiteSpace(autor.NombreOcupacion) ? "NULL" : "'" + autor.NombreOcupacion + "'",
                    autor.FechaNacimiento.ToShortDateString(),
                    autor.FechaDefuncion.ToShortDateString(),
                    autor.EnlaceReferencia,
                    autor.Comentario),
                    ConexionBD.Conexion);
                    tabla.Parameters.Add("@imagen", MySqlDbType.MediumBlob, img == null ? 0 : img.Length).Value = img;
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("AutorNoExiste"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteAutor(Autor autor)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarAutorExiste(autor);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    //Comprobar si ningun autor que queda tiene la Ocupacion
                    //if (LecturaBD.SelectOcupacionCantidadPorAutor(autor.NombreOcupacion) <= 1)
                    //    DeleteOcupacion(autor.NombreOcupacion);
                    int id = GetObjetoIdDeLocal(autor.ListaIdCompartido);
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `Autor` WHERE idAutor = " +
                    id, ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                    autor.ListaIdCompartido.Add(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("AutorNoExiste"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion

        #region Genero

        // NOTA: Terminadas todas las comporbaciones de libros ha hacer
        private static MySqlCommand ComprobarGeneroExiste(Genero genero)
        {
            // Se comprueba primero que el genero no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Genero WHERE idGenero = " +
                GetObjetoIdDeLocal(genero.ListaIdCompartido)),
                ConexionBD.Conexion);
        }

        private static void InsertGeneroPadre(Genero genero)
        {
            //Meter al género padre primero si no está
            if (genero != null && LecturaBD.SelectGenero(
                GetObjetoIdDeLocal(genero.ListaIdCompartido)) == null)
                InsertGenero(genero);
        }

        public static void InsertGenero(Genero genero)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarGeneroExiste(genero);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    int id = SetRandomId("Genero", "idGenero");
                    
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `Genero` VALUES ({0},'{1}','{2}');",
                    id,
                    genero.Nombre,
                    genero.Comentario), ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                    genero.ListaIdCompartido.Add(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("GeneroRepetido"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void UpdateGenero(Genero genero)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarGeneroExiste(genero);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    int id = GetObjetoIdDeLocal(genero.ListaIdCompartido);
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    UPDATE `Genero` SET nombreGenero = '{0}',
                    comentario = '{1}'
                    WHERE idGenero = " + id + ";",
                    genero.Nombre,
                    genero.Comentario), ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("GeneroNoExiste"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteGenero(Genero genero)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarGeneroExiste(genero);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    int id = GetObjetoIdDeLocal(genero.ListaIdCompartido);

                    //Quitar referencia de genero a borrar en los hijos
                    MySqlCommand tabla = new MySqlCommand(@"
                    UPDATE `Genero` SET generoPadre = NULL
                    WHERE generoPadre = " + id + ";",
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();

                    tabla = new MySqlCommand(@"
                    DELETE FROM `Genero` WHERE idGenero = " +
                    id,
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                    genero.ListaIdCompartido.Remove(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("GeneroNoExiste"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion

        #region Editorial
        private static MySqlCommand ComprobarEditorialExiste(Editorial editorial)
        {
            // Se comprueba primero que la editorial no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Editorial WHERE idEditorial = '" +
                GetObjetoIdDeLocal(editorial.ListaIdCompartido)+"'"),
                ConexionBD.Conexion);
        }

        // NOTA: Terminado la parte de comprobaciones con editoriales
        public static void InsertEditorial(Editorial editorial)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarEditorialExiste(editorial);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    int id = SetRandomId("Editorial", "idEditorial");
                    byte[] img = ControladorImagen.ImagenAByteArray(editorial.Imagen);
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `Editorial` VALUES ({0},'{1}','{2}',@imagen);",
                    id,
                    editorial.Nombre,
                    editorial.Comentario),
                    ConexionBD.Conexion);
                    tabla.Parameters.Add("@imagen", MySqlDbType.MediumBlob, img == null ? 0 : img.Length).Value = img;
                    tabla.ExecuteNonQuery();
                    editorial.ListaIdCompartido.Add(LecturaBD.SelectObtenerIdBD()+"-"+id.ToString());
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("EditorialRepetida"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void UpdateEditorial(Editorial editorial)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarEditorialExiste(editorial);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    int id = GetObjetoIdDeLocal(editorial.ListaIdCompartido);
                    byte[] img = ControladorImagen.ImagenAByteArray(editorial.Imagen);
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    UPDATE `Editorial` SET nombreEditorial = '{0}',
                    comentario = '{1}',
                    imagen = @imagen
                    WHERE idEditorial = " + id + ";",
                    editorial.Nombre,
                    editorial.Comentario),
                    ConexionBD.Conexion);
                    tabla.Parameters.Add("@imagen", MySqlDbType.MediumBlob, img == null ? 0 : img.Length).Value = img;
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("EditorialNoExiste"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteEditorial(Editorial editorial)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarEditorialExiste(editorial);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    int id = GetObjetoIdDeLocal(editorial.ListaIdCompartido);
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `Editorial` WHERE idEditorial = " +
                    id,
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                    editorial.ListaIdCompartido.Remove(LecturaBD.SelectObtenerIdBD() + "-" + id.ToString());
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("EditorialNoExiste"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }


        }
        #endregion

        #region Ocupacion
        // NOTA: Terminado la parte de comprobaciones realcionaadas con la ocupacion
        private static MySqlCommand ComprobarOcupacionExiste(string ocupacion)
        {
            // Se comprueba primero que la ocupacion no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Ocupacion WHERE nombreOcupacion = '" + ocupacion + "'"),
                ConexionBD.Conexion);
        }

        public static void InsertOcupacion(string ocupacion)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarOcupacionExiste(ocupacion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    INSERT INTO `Ocupacion` VALUES ('" + ocupacion + "');", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("OcupacionRepetida"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void UpdateOcupacion(string ocupacionOriginal, string ocupacionNueva)
        {
            try
            {
                // Se comprueba primero que la ocupacion existe en la bd 
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Ocupacion WHERE nombreOcupacion = '" + ocupacionOriginal + "'"), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    ComprobarFK(false);
                    //Cambiar la referencia en todos los autores
                    MySqlCommand tabla = new MySqlCommand(@"
                    UPDATE `Autor` SET nombreOcupacion = '" + ocupacionNueva + "'  WHERE nombreOcupacion='" + ocupacionOriginal + "' ", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();

                    tabla = new MySqlCommand(@"
                    UPDATE `Ocupacion` SET nombreOcupacion = '" + ocupacionNueva + "' WHERE nombreOcupacion = '" + ocupacionOriginal + "';", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                    ComprobarFK(true);
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("OcupacionNoExiste"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteOcupacion(string ocupacion)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarOcupacionExiste(ocupacion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    //Quitar la referencia en todos los autores
                    MySqlCommand tabla = new MySqlCommand(@"
                    UPDATE `Autor` SET nombreOcupacion = NULL WHERE nombreOcupacion='" + ocupacion + "' ", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();

                    tabla = new MySqlCommand(@"
                    DELETE FROM `Ocupacion` WHERE nombreOcupacion = '" + ocupacion + "';", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("OcupacionNoExiste"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion

        #region TipoLibro
        // NOTA: Terminado las comprobaciones del tipoLibro
        private static MySqlCommand ComprobarTipoLibroExiste(string tipoLibro)
        {
            // Se comprueba primero que el TipoLibro no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM TipoLibro WHERE nombreTipoLibro = '" + tipoLibro + "'"),
                ConexionBD.Conexion);
        }

        public static void InsertTipoLibro(string tipoLibro)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarTipoLibroExiste(tipoLibro);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    INSERT INTO `TipoLibro` VALUES ('" + tipoLibro + "');", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("TipoLibroRepetido"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void UpdateTipoLibro(string tipoLibroOriginal, string tipoLibroNuevo)
        {
            try
            {
                // Se comprueba primero que el TipoLibro no existe en la bd 
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM TipoLibro WHERE nombreTipoLibro = '" + tipoLibroOriginal + "'"), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    ComprobarFK(false);
                    //Cambiar la referencia en todos los libros
                    MySqlCommand tabla = new MySqlCommand(@"
                    UPDATE `Libro` SET nombreTipoLibro = '" + tipoLibroNuevo + "'  WHERE nombreTipoLibro='" + tipoLibroOriginal + "' ", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();

                    tabla = new MySqlCommand(@"
                    UPDATE `TipoLibro` SET nombreTipoLibro = '" + tipoLibroNuevo + "' WHERE nombreTipoLibro = '" + tipoLibroOriginal + "';", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                    ComprobarFK(true);
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("TipoLibroRepetido"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void DeleteTipoLibro(string tipoLibro)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarTipoLibroExiste(tipoLibro);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    //Quitar la referencia en todos los autores
                    MySqlCommand tabla = new MySqlCommand(@"
                    UPDATE `Libro` SET nombreTipoLibro = NULL WHERE nombreTipoLibro='" + tipoLibro + "' ", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();

                    tabla = new MySqlCommand(@"
                    DELETE FROM `TipoLibro` WHERE nombreTipoLibro = '" + tipoLibro + "';", ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("TipoLibroNoExiste"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion

        #region Usuario
        // NOTA: Comprobacion en usuarios hechas.
        private static MySqlCommand ComprobarUsuarioExiste(InfoUsuarioBD usuario)
        {
            // Se comprueba primero que el TipoLibro no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Usuario WHERE nombreUsuario = '" + usuario.Nombre + "'"),
                ConexionBD.Conexion);
        }
        public static MySqlCommand ComprobarMailExiste(string mail)
        {
            // Se comprueba primero que el TipoLibro no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM Usuario WHERE correoUsuario = '" + mail + "'"),
                ConexionBD.Conexion);
        }

        public static void InsertUsuario(InfoUsuarioBD usuario, string contrasenia)
        {
            try 
            {
                MySqlCommand comprobacion = ComprobarUsuarioExiste(usuario);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    //Creamos usuario en tabla con su info
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `Usuario` VALUES ('{0}','{1}','{2}',NULL);",
                    usuario.Correo,
                    usuario.Nombre,
                    usuario.TipoUsuario), ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();

                    //Creamos usuario con permisos en mysql
                    if (usuario.TipoUsuario == "Usuario")
                        ConexionBD.CrearUsuarioComunBD(usuario.Nombre, contrasenia, usuario.Nombre);
                    else if (usuario.TipoUsuario == "Editor")
                        ConexionBD.CrearEditorBD(usuario.Nombre, contrasenia, usuario.Nombre);
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("UsuarioRepetido"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void UpdateUsuario(string nombreOriginal, InfoUsuarioBD usuario)
        {
            try
            {
                //ComprobarFK(false);
                ////Cambiar la referencia en todos los autores
                //MySqlCommand tabla = new MySqlCommand(@"
                //    UPDATE `UsuarioLibro` SET nombreUsuario = '" + usuario.Nombre +
                //    "' WHERE nombreUsuario='" + nombreOriginal + "' ", ConexionBD.Conexion);
                //tabla.ExecuteNonQuery();

                //tabla = new MySqlCommand(String.Format(@"
                //UPDATE `Usuario` SET correoUsuario = '{0}',
                //nombreUsuario = '{1}',
                //tipoUsuario = '{2}' 
                //WHERE nombreUsuario = '" + nombreOriginal + "';",
                //usuario.Correo,
                //usuario.Nombre,
                //usuario.TipoUsuario), ConexionBD.Conexion);
                //tabla.ExecuteNonQuery();
                //ComprobarFK(true);

                ////Quitamos, por si acaso, el usuario con el nuevo nombre si existiera en mysql.user
                //MySqlCommand tabla = new MySqlCommand(@"
                //DROP USER '" + ConexionBD.ANTENOMBRE_USUARIO_BD +
                //nombreOriginal + "';",
                //ConexionBD.Conexion);
                //tabla.ExecuteNonQuery();

                ////Renombramos el usuario de mysql users
                //tabla = new MySqlCommand(@"
                //RENAME USER '" + ConexionBD.ANTENOMBRE_USUARIO_BD + nombreOriginal +
                //"'@'%' TO '"
                //+ ConexionBD.ANTENOMBRE_USUARIO_BD + usuario.Nombre + "'@'%';",
                //ConexionBD.Conexion);
                //tabla.ExecuteNonQuery();

                //Modificamos permisos de usuario en mysql
                if (usuario.TipoUsuario == "Usuario")
                    ConexionBD.CrearUsuarioComunBD(usuario.Nombre, null, nombreOriginal);
                else if (usuario.TipoUsuario == "Editor")
                    ConexionBD.CrearEditorBD(usuario.Nombre, null, nombreOriginal);
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }
        public static void UpdateMailUsuario(string mail, InfoUsuarioBD usuario)
        {
            try
            {
                //ConexionBD.AbrirConexion();
                //Cambiar la referencia en todos los autores
                MySqlCommand tabla =new MySqlCommand(String.Format(@"
                UPDATE `Usuario` SET correoUsuario = '{0}'
                WHERE nombreUsuario = '" + usuario.Nombre + "';",
                mail), ConexionBD.Conexion);
                tabla.ExecuteNonQuery();
                //ConexionBD.CerrarConexion();
               
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }
        public static bool UpdatePasswordUsuario(string password, InfoUsuarioBD usuario)
        {
            try
            {
                //HACER EL UPDATE DE LA TABLA USER
                //ConexionBD.AbrirConexion();
                //Cambiar la referencia en todos los autores
                MySqlCommand tabla = new MySqlCommand(String.Format(@"
                ALTER USER '"+ConexionBD.ANTENOMBRE_USUARIO_BD+usuario.Nombre+"'@'%' IDENTIFIED BY '"+password+"';"),
                ConexionBD.Conexion);
                tabla.ExecuteNonQuery();
                return true;
                //ConexionBD.CerrarConexion();

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
                return false;
            }
        }
        public static void UpdateTipoUsuario(string tipoNuevo, InfoUsuarioBD usuario)
        {
            try
            {
                ConexionBD.AbrirConexion();
                
                //Cambiar la referencia en todos los autores
                MySqlCommand tabla = new MySqlCommand(String.Format(@"
                UPDATE `Usuario` SET tipoUsuario = '{0}'
                WHERE nombreUsuario = '" + usuario.Nombre + "';",
                tipoNuevo), ConexionBD.Conexion);
                tabla.ExecuteNonQuery();

                //Modificamos permisos de usuario en mysql
                if (usuario.TipoUsuario == "Usuario")
                    ConexionBD.CrearUsuarioComunBD(usuario.Nombre, null, ConexionBD.ANTENOMBRE_USUARIO_BD + usuario.Nombre);
                else if (usuario.TipoUsuario == "Editor")
                    ConexionBD.CrearEditorBD(usuario.Nombre, null, ConexionBD.ANTENOMBRE_USUARIO_BD + usuario.Nombre);

                ConexionBD.CerrarConexion();

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void UpdateFotoUsuario(byte[] img, InfoUsuarioBD usuario)
        {
            try
            {
                //Cambiar la referencia en todos los autores
                MySqlCommand tabla = new MySqlCommand(@"
                UPDATE `Usuario` SET imagenPerfil = @imagen
                WHERE nombreUsuario = '" + usuario.Nombre + "';",
                ConexionBD.Conexion);
                tabla.Parameters.Add("@imagen", MySqlDbType.MediumBlob, img == null ? 0 : img.Length).Value = img;
                tabla.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }

        public static void DeleteUsuario(InfoUsuarioBD usuario)
        {
            try
            {
                MySqlCommand tabla = new MySqlCommand(@"
                DELETE FROM `Usuario` WHERE nombreUsuario = '" + usuario.Nombre + "';",
                ConexionBD.Conexion);
                tabla.ExecuteNonQuery();

                //Borramos el usuario de mysql users
                tabla = new MySqlCommand(@"
                DROP USER '"+ConexionBD.ANTENOMBRE_USUARIO_BD +
                usuario.Nombre+"';",
                ConexionBD.Conexion);
                tabla.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion

        #region UsuarioLibro
        // NOTA: Comprobaciones hechas y funcionamiento correcto.
        private static MySqlCommand ComprobarUsuarioLibroExiste(Libro libro, InfoUsuarioBD usuario)
        {
            // Se comprueba primero que el TipoLibro no existe en la bd 
            return new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM UsuarioLibro WHERE nombreUsuario = '" 
                + usuario.Nombre + "' AND idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido)
                ), ConexionBD.Conexion);
        }

        public static void InsertUsuarioLibro(Libro libro, InfoUsuarioBD usuario)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarUsuarioLibroExiste(libro, usuario);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
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
                    libro.Favorito), ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);
            }
        }
        
        public static void UpdateUsuarioLibro(string nombreOriginal, Libro libro, InfoUsuarioBD usuario)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarUsuarioLibroExiste(libro, usuario);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
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
                    libro.Favorito), ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("NoRegistroUsuarioLibro"));
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteUsuarioLibro(Libro libro, InfoUsuarioBD usuario)
        {
            try
            {
                MySqlCommand comprobacion = ComprobarUsuarioLibroExiste(libro, usuario);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `UsuarioLibro` WHERE nombreUsuario = '" + usuario.Nombre + "' and " +
                    "idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("NoRegistroUsuarioLibro"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteUsuarioLibroDesdeLibro(Libro libro)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM UsuarioLibro WHERE idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido)
                ), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `UsuarioLibro` WHERE idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("NoRegistroUsuarioLibro"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteUsuarioLibroDesdeUsuario(InfoUsuarioBD usuario)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM UsuarioLibro WHERE nombreUsuario = '" + usuario.Nombre + "'"
                ), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `UsuarioLibro` WHERE nombreUsuario = '" + usuario.Nombre + "'"
                    , ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("NoRegistroUsuarioLibro"));

            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion

        #region Listas
        // NOTA: Comprobaciones correspondientes de lista hechas y probadas en la BD en local...
        public static void InsertListaEditorial(Libro libro, Editorial editorial)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaEditorial WHERE idEditorial = "
                    + GetObjetoIdDeLocal(editorial.ListaIdCompartido)
                    + " AND idLibro = "
                    + GetObjetoIdDeLocal(libro.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `ListaEditorial` VALUES ({0},{1});",
                    GetObjetoIdDeLocal(editorial.ListaIdCompartido),
                    GetObjetoIdDeLocal(libro.ListaIdCompartido))
                    , ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteListaEditorialDesdeLibro(Libro libro)
        {
            try
            {
                // Se comprueba primero que el no existe la entrdad en BD 
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaEditorial WHERE idLibro = "
            + GetObjetoIdDeLocal(libro.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `ListaEditorial` WHERE idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteListaEditorialDesdeEditorial(Editorial editorial)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaEditorial WHERE idEditorial = "
            + GetObjetoIdDeLocal(editorial.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `ListaEditorial` WHERE idEditorial = " + GetObjetoIdDeLocal(editorial.ListaIdCompartido),
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void InsertListaAutor(Libro libro, Autor autor)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaAutor WHERE idAutor =  "
            + GetObjetoIdDeLocal(autor.ListaIdCompartido)
            + " AND idLibro = "
            + GetObjetoIdDeLocal(libro.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `ListaAutor` VALUES ({0},{1});",
                    GetObjetoIdDeLocal(autor.ListaIdCompartido),
                    GetObjetoIdDeLocal(libro.ListaIdCompartido))
                    , ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteListaAutorDesdeLibro(Libro libro)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaAutor WHERE idLibro = "
                + GetObjetoIdDeLocal(libro.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `ListaAutor` WHERE idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido),
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteListaAutorDesdeAutor(Autor autor)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaAutor WHERE idAutor =  "
            + GetObjetoIdDeLocal(autor.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `ListaAutor` WHERE idAutor = " + GetObjetoIdDeLocal(autor.ListaIdCompartido),
                    ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void InsertListaGenero(Libro libro, Genero genero)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaGenero WHERE idGenero = "
            + GetObjetoIdDeLocal(genero.ListaIdCompartido)
            + " AND idLibro = "
            + GetObjetoIdDeLocal(libro.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) == 0)
                {
                    MySqlCommand tabla = new MySqlCommand(String.Format(@"
                    INSERT INTO `ListaGenero` VALUES ({0},{1});",
                    GetObjetoIdDeLocal(genero.ListaIdCompartido),
                    GetObjetoIdDeLocal(libro.ListaIdCompartido))
                    , ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteListaGeneroDesdeLibro(Libro libro)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaGenero WHERE idLibro = "
            + GetObjetoIdDeLocal(libro.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `ListaGenero` WHERE idLibro = " + GetObjetoIdDeLocal(libro.ListaIdCompartido)
                    , ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }

        public static void DeleteListaGeneroDesdeGenero(Genero genero)
        {
            try
            {
                MySqlCommand comprobacion = new MySqlCommand(String.Format(@"
                SELECT COUNT(*) FROM ListaGenero WHERE idGenero = "
            + GetObjetoIdDeLocal(genero.ListaIdCompartido)), ConexionBD.Conexion);

                if (int.Parse(comprobacion.ExecuteScalar().ToString()) > 0)
                {
                    MySqlCommand tabla = new MySqlCommand(@"
                    DELETE FROM `ListaGenero` WHERE idGenero = " + GetObjetoIdDeLocal(genero.ListaIdCompartido)
                    , ConexionBD.Conexion);
                    tabla.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexionBD") + ex.Message);

            }
        }
        #endregion
    }
}
