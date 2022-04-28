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
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static List<Autor> SelectAutoresLista()
		{
			string query = "Select * From Autor";
			List<Autor> listaAutores = new List<Autor>();

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

		public static Autor SelectAutor(string nombreAutor)
		{
			string query = "Select * From Autor Where nombreAutor = '" + nombreAutor + "'";
			
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

		public static List<InfoUsuarioBD> SelectUsuariosLista()
		{
			string query = "Select * From Usuario";
			List<InfoUsuarioBD> listaUsuarios = new List<InfoUsuarioBD>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						listaUsuarios.Add(ConversorRegistro.RegistroAUsuarioInfo(lector));
					}

					return listaUsuarios;
				}
			}
		}

		public static InfoUsuarioBD SelectUsuario(string correo)
		{
			string query = "Select * From Usuario Where correoUsuario = '" + correo + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						return ConversorRegistro.RegistroAUsuarioInfo(lector);
					}

					return null;
				}
			}
		}

		public static void SelectUsuarioLibro(string correo, Libro libro)
		{
			string query = "Select * From UsuarioLibro Where correoUsuario = '" + correo + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						ConversorRegistro.RegistroAUsuarioLibro(lector, libro);
					}
				}
			}
		}

		public static List<Editorial> SelectEditorialesLista()
		{
			string query = "Select * From Editorial";
			List<Editorial> listaEditoriales = new List<Editorial>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						listaEditoriales.Add(ConversorRegistro.RegistroAEditorial(lector));
					}

					return listaEditoriales;
				}
			}
		}

		public static Editorial SelectEditorial(string nombreEditorial)
		{
			string query = "Select * From Editorial Where nombreEditorial = '" + nombreEditorial + "'";
			
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						return ConversorRegistro.RegistroAEditorial(lector);
					}

					return null;
				}
			}
		}

		public static List<Genero> SelectGenerosLista()
		{
			string query = "Select * From Genero";
			List<Genero> listaGeneros = new List<Genero>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						listaGeneros.Add(ConversorRegistro.RegistroAGenero(lector));
					}

					return listaGeneros;
				}
			}
		}

		public static Genero SelectGenero(string generoNombre)
		{
			string query = "Select * From Genero Where nombreGenero = '" + generoNombre + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						return ConversorRegistro.RegistroAGenero(lector);
					}

					return null;
				}
			}
		}

		public static List<Libro> SelectLibrosLista()
		{
			string query = "Select * From Libro";
			List<Libro> listaLibros = new List<Libro>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						listaLibros.Add(ConversorRegistro.RegistroALibro(lector));
					}

					return listaLibros;
				}
			}
		}

		public static Libro SelectLibro(string libroNombre)
		{
			string query = "Select * From Libro Where isbn13 = '" + libroNombre + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						return ConversorRegistro.RegistroALibro(lector);
					}

					return null;
				}
			}
		}

		public static string SelectTipoLibro(string tipoLibro)
		{
			string query = "Select * From TipoLibro Where nombreTipoLibro = '" + tipoLibro + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						string datos = lector["nombreTipoLibro"].ToString();
						return datos;
					}

					return null;
				}
			}
		}

		public static int SelectTipoLibroCantidadPorLibro(string tipoLibro)
		{
			string query = "Select count(*) as c From Libro Where nombreTipoLibro = '" + tipoLibro + "'";
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}
	}
}
