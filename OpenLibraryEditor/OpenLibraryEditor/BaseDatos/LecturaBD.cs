using MySql.Data.MySqlClient;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.BaseDatos
{
    public class LecturaBD
    {
		public static string ScalarPersonalizado(string query, string columna)
		{
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						string datos = lector[columna].ToString();
						lector.Close();
						return datos.ToString();
					}

					return null;
				}
			}
		}

        public static string SelectOcupacion(string ocupacion)
        {
            string query = "Select * From Ocupacion Where nombreOcupacion = '" + ocupacion+"'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						string datos = lector["nombreOcupacion"].ToString();
						return datos;
					}

					return null;
				}
			}
		}

        public static int SelectOcupacionCantidadPorAutor(string nombreOcupacion)
        {
			string query = "Select count(*) as c From Autor Where nombreOcupacion = '" + nombreOcupacion+"'";
			return int.Parse(ScalarPersonalizado(query, "c"));
		}

		public static List<Persona> SelectAutoresLista(Persona autor)
		{
			string query = "Select * From Autor Where idAutor = " + autor.IdPersona;
			List<Persona> listaAutores = new List<Persona>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						listaAutores.Add(ConversorRegistro.RegistroAAutor(lector));
					}

					return listaAutores;
				}
			}
		}

		public static Persona SelectAutor(Persona autor)
		{
			string query = "Select * From Autor Where idAutor = " + autor.IdPersona;
			List<Persona> listaAutores = new List<Persona>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						return ConversorRegistro.RegistroAAutor(lector);
					}

					return null;
				}
			}
		}
	}
}
