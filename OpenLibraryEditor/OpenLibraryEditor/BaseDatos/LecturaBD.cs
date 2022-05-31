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
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static int SelectExisteUsuarioBD(string nombreUsuario)
		{
			string query = "SELECT count(*) FROM mysql.user where user = '"+nombreUsuario+"'";
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static int SelectObtenerIdTablaNuevo(string tablaNombre, string campo, int randomId)
		{
			string query = "SELECT COUNT(*) FROM "+ tablaNombre+" WHERE "+campo+" like "+ randomId;
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static string SelectOcupacion(string ocupacion)
        {
            string query = "SELECT * FROM Ocupacion WHERE nombreOcupacion = '" + ocupacion+"'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static List<Autor> SelectAutoresDesdeListaAutor(int idLibro)
		{
			string query = "SELECT * FROM Autor t WHERE idAutor = " +
				"(SELECT idAutor FROM ListaAutor WHERE idLibro = "+ idLibro+ " AND idAutor = t.idAutor)";
			List<Autor> listaAutores = new List<Autor>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
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
			
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
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

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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
		public static InfoUsuarioBD SelectUsuarioSegunMail(string mail)
		{
			string query = "SELECT * FROM Usuario WHERE correoUsuario = '" + mail + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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

		public static int SelectUsuarioCorreo(string correoUsuario)
		{
			string query = "SELECT count(*) FROM Usuario WHERE correoUsuario = '" + correoUsuario + "'";
			
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static byte[] SelectUsuarioFotoPerfil(string nombreUsuario)
		{
			string query = "SELECT * FROM Usuario WHERE nombreUsuario = '" + nombreUsuario + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						if (lector["imagenPerfil"].GetType() != typeof(System.DBNull))
							return (byte[])lector["imagenPerfil"];
					}

					return null;
				}
			}
		}

		public static void SelectUsuarioLibro(string nombreUsuario, Libro libro)
		{
			string query = "SELECT * FROM UsuarioLibro WHERE nombreUsuario = '" + nombreUsuario + "'"
				+ " AND idLibro = "+EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido);

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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

		public static int SelectUsuarioLibroExiste(string nombreUsuario, Libro libro)
		{
			string query = String.Format(@"
                SELECT COUNT(*) FROM UsuarioLibro WHERE nombreUsuario = '" + 
				nombreUsuario + "' AND idLibro ='" 
				+ EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido) 
				+ "'");
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static int SelectUsuarioLibroPorUsuario(string nombreUsuario)
		{
			string query = String.Format(@"
                SELECT COUNT(*) FROM UsuarioLibro WHERE nombreUsuario = '" +
				nombreUsuario + "'");
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static List<Editorial> SelectEditorialesDesdeListaEditorial(int idLibro)
		{
			string query = "SELECT * FROM Editorial t WHERE idEditorial = " +
				"(SELECT idEditorial FROM ListaEditorial WHERE idLibro = " + idLibro + " AND idEditorial = t.idEditorial)";
			List<Editorial> listaEditorial = new List<Editorial>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
					{
						listaEditorial.Add(ConversorRegistro.RegistroAEditorial(lector));
					}

					return listaEditorial;
				}
			}
		}

		public static Editorial SelectEditorial(int idEditorial)
		{
			string query = "SELECT * FROM Editorial WHERE idEditorial = '" + idEditorial + "'";
			
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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

		public static List<Genero> SelectGenerosDesdeListaGenero(int idLibro)
		{
			string query = "SELECT * FROM Genero t WHERE idGenero = " +
				"(SELECT idGenero FROM ListaGenero WHERE idLibro = " + idLibro + " AND idGenero = t.idGenero)";
			List<Genero> listaGeneros = new List<Genero>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
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

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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
			string query = "SELECT * FROM Libro";
			List<Libro> listaLibros = new List<Libro>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
					{
						listaLibros.Add(ConversorRegistro.RegistroALibro(lector));
					}

					return listaLibros;
				}
			}
		}

		public static Libro SelectLibro(int idLibro, InfoUsuarioBD usuario)
		{
			string query = "SELECT * FROM Libro WHERE idLibro = '" + idLibro + "'";
			Libro libro = null;

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					if (lector.Read())
					{
						libro = ConversorRegistro.RegistroALibro(lector);
					}
				}
			}

			if (libro != null)
			{
				//Recuperar listas
				//libro.ListaAutor.AddRange(SelectAutoresDesdeListaAutor(
				//			EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido)));
				//libro.ListaEditorial.AddRange(SelectEditorialesDesdeListaEditorial(
				//			EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido)));
				//libro.ListaGenero.AddRange(SelectGenerosDesdeListaGenero(
				//			EscrituraBD.GetObjetoIdDeLocal(libro.ListaIdCompartido)));
				if (usuario != null)
					LecturaBD.SelectUsuarioLibro(usuario.Nombre,libro);
			}

			return libro;
		}

		public static string SelectTipoLibro(string tipoLibro)
		{
			string query = "SELECT * FROM TipoLibro WHERE nombreTipoLibro = '" + tipoLibro + "'";

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
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
			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				return int.Parse(comando.ExecuteScalar().ToString());
			}
		}

		public static List<Libro> SelectBuscarLibro(string campo, string texto, InfoUsuarioBD usuario)
		{
			string query = "SELECT * FROM Libro WHERE "+campo+" LIKE '%" + texto + "%'";
			List<int> listaIds = new List<int>();
			List<Libro> listaLibros = new List<Libro>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
					{
						listaIds.Add(int.Parse(lector["idLibro"].ToString()));
					}
				}
			}

			foreach (int id in listaIds)
			{
				listaLibros.Add(SelectLibro(id, usuario));
			}

			return listaLibros;
		}

		public static List<Libro> SelectBuscarElementoPorNombre(string texto, string tabla, string campoId, string nombreCampo, InfoUsuarioBD usuario)
		{
			string query = "SELECT "+ campoId + " FROM "+tabla+" WHERE "+nombreCampo+" LIKE '%" + texto + "%'";
			List<int> listaIds = new List<int>();
			List<Libro> listaLibros = new List<Libro>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
					{
						listaIds.Add(int.Parse(lector[campoId].ToString()));
					}
				}
			}

			foreach (int id in listaIds)
			{
				listaLibros.AddRange(SelectBuscarLibrosDesdeLista(tabla, campoId, id, usuario));
			}

			return listaLibros;
		}

		private static List<Libro> SelectBuscarLibrosDesdeLista(string tabla, string campo, int idElemento, InfoUsuarioBD usuario)
		{
			string query = "SELECT * FROM Lista"+tabla+" WHERE "+campo+" = " + idElemento;
			List<int> listaIds = new List<int>();
			List<Libro> listaLibros = new List<Libro>();

			using (MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion))
			{
				using (MySqlDataReader lector = comando.ExecuteReader())
				{

					while (lector.Read())
					{
						listaIds.Add(int.Parse(lector["idLibro"].ToString()));
					}
				}
			}

			foreach (int id in listaIds)
			{
				listaLibros.Add(SelectLibro(id, usuario));
			}

			return listaLibros;
		}
	}
}
