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
        public static void InsertOcupacion(string ocupacion)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            INSERT INTO `Ocupacion` VALUES ('"+ocupacion+"');", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }

        public static void UpdateOcupacion(string ocupacionOriginal, string ocupacionNueva)
        {
            MySqlCommand tabla = new MySqlCommand(@"
            UPDATE `Ocupacion` SET nombreOcupacion = '" + ocupacionNueva + "' WHERE nombreOcupacion = '"+ ocupacionOriginal + "';", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
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
            INSERT INTO `Autor` VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
            autor.IdAutor,
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

        public static void UpdateAutor(Autor autor)
        {
            //Comprobar si existe Ocupacion
            if (LecturaBD.SelectOcupacion(autor.NombreOcupacion) == null)
                InsertOcupacion(autor.NombreOcupacion);

            MySqlCommand tabla = new MySqlCommand(String.Format(@"
            UPDATE `Autor` SET idAutor = {0},
                nombre = '{1}',
                alias = '{2}',
                nombreOcupacion = '{3}',
                fechaNacimiento = '{4}',
                fechaDefuncion = '{5}',
                enlaceReferencia = '{6}',
                comentario = '{7}',
                imagen = '{8}';",
            autor.IdAutor,
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
            if (LecturaBD.SelectOcupacionCantidadPorAutor(autor.NombreOcupacion) <= 1)
                DeleteOcupacion(autor.NombreOcupacion);

            MySqlCommand tabla = new MySqlCommand(@"
            DELETE FROM `Autor` WHERE idAutor = " + autor.IdAutor + ";", ConexionBD.conexion);
            tabla.ExecuteNonQuery();
        }
    }
}
