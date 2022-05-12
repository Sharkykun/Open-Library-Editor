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
		public static int SelectObtenerIdBD()
		{
			string query = "SELECT * FROM Biblioteca";
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static int SelectObtenerIdNuevoTabla(string tablaNombre, string campo, int randomId)
		{
			string query = "SELECT COUNT(*) FROM "+ tablaNombre+" WHERE "+campo+" like "+ randomId;
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static string SelectOcupacion(string ocupacion)
        {
            string query = "SELECT * FROM Ocupacion WHERE nombreOcupacion = '" + ocupacion+"'";

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
			string query = "SELECt COUNT(*) FROM Autor WHERE nombreOcupacion = '" + nombreOcupacion+"'";
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static List<Autor> SelectAutoresLista()
		{
			string query = "SELECT * FROM Autor";
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

		public static Autor SelectAutor(int idAutor)
		{
			string query = "SELECT * FROM Autor WHERE idAutor = '" + idAutor + "'";
			
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
			string query = "SELECT * FROM Usuario";
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

		public static InfoUsuarioBD SelectUsuario(string nombreUsuario)
		{
			string query = "SELECT * FROM Usuario WHERE nombreUsuario = '" + nombreUsuario + "'";

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

		public static void SelectUsuarioLibro(string nombreUsuario, Libro libro)
		{
			string query = "SELECT * FROM UsuarioLibro WHERE nombreUsuario = '" + nombreUsuario + "'";

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
			string query = "SELECT * FROM Editorial";
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

		public static Editorial SelectEditorial(int idEditorial)
		{
			string query = "SELECT * FROM Editorial WHERE id = '" + idEditorial + "'";
			
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
			string query = "SELECT * FROM Genero";
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

		public static Genero SelectGenero(int idGenero)
		{
			string query = "SELECT * FROM Genero WHERE idGenero = '" + idGenero + "'";

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
			string query = "SELEC * FROM Libro";
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

		public static Libro SelectLibro(int idLibro)
		{
			string query = "SELECT * FROM Libro WHERE idLibro = '" + idLibro + "'";

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
			string query = "SELECT * FROM TipoLibro WHERE nombreTipoLibro = '" + tipoLibro + "'";

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
			string query = "SELECT COUNT(*) FROM Libro WHERE nombreTipoLibro = '" + tipoLibro + "'";
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}
	}
}
