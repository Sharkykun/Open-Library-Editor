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
        public static string RegistroAOcupacion(MySqlDataReader registro)
        {
            return registro["nombreOcupacion"].ToString();
        }

        public static Persona RegistroAAutor(MySqlDataReader registro)
        {
            return new Persona(int.Parse(registro["idAutor"].ToString()),
                registro["nombre"].ToString(),
                registro["alias"].ToString(),
                registro["nombreOcupacion"].ToString(),
                DateTime.Parse(registro["fechaNacimiento"].ToString()),
                DateTime.Parse(registro["fechaDefuncion"].ToString()),
                registro["enlaceReferencia"].ToString(),
                registro["comentario"].ToString(),
                registro["imagen"].ToString());
        }
    }
}
