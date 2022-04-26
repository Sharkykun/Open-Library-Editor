using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OpenLibraryEditor.BaseDatos
{
    public class ConexionBD
    {
        public static MySqlConnection conexion;
        public const string NOMBRE_BD = "open_library_editor";

        public static void CrearBD(string servidor, string usuario, string contrasena, string puerto)
        {
            BorrarBD(servidor, usuario, contrasena, puerto);

            EstablecerConexion(servidor, usuario, contrasena, puerto);

            try
            {
                AbrirConexion();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                Console.WriteLine("No existe la BD. Creando...");
                EstablecerConexionNueva(servidor, usuario, contrasena, puerto);
                AbrirConexion();

                //Crear base de datos si no existe
                MySqlCommand cmd = new MySqlCommand("create database if not exists " + NOMBRE_BD, conexion);
                cmd.ExecuteNonQuery();

                CerrarConexion();

                //Cerramos y abrimos de nuevo la conexion pero con la BD creada
                EstablecerConexion(servidor, usuario, contrasena, puerto);
                AbrirConexion();
            }

            //Creamos tablas
            CrearTablaUsuario();
            CrearTablaIdioma();
            CrearTablaOcupacion();
            CrearTablaTipoLibro();
            CrearTablaEditorial();
            CrearTablaAutor();
            CrearTablaGenero();
            CrearTablaLibro();
            CrearTablaListaEditorial();
            CrearTablaListaAutor();
            CrearTablaListaGenero();
            CrearTablaUsuarioLibro();

            CerrarConexion();
        }

        private static void EstablecerConexionNueva(string servidor, string usuario, string contrasena, string puerto)
        {
            //Iniciar sesion con ip, usuario y contraseña
            string connString = "server=" + servidor + ";uid=" + usuario + ";pwd=" + contrasena + ";port=" + puerto + ";";
            conexion = new MySqlConnection(connString);
        }

        private static void EstablecerConexion(string servidor, string usuario, string contrasena, string puerto)
        {
            //Iniciar sesion ahora con bd
            string connString = "server=" + servidor + ";database=" + NOMBRE_BD +
                ";uid=" + usuario + ";pwd=" + contrasena + ";port=" + puerto + ";";
            conexion = new MySqlConnection(connString);
        }

        public static void AbrirConexion()
        {
            Console.WriteLine("Conexion con MySql abierta.");
            //Abrir conexión
            conexion.Open();
        }

        public static void CerrarConexion()
        {
            //Cerrar conexión
            Console.WriteLine("Conexion con MySql cerrada.");
            conexion.Close();
        }

        private static void BorrarBD(string servidor, string usuario, string contrasena, string puerto)
        {
            EstablecerConexion(servidor, usuario, contrasena, puerto);
            AbrirConexion();

            //Para pruebas
            MySqlCommand borrar_test = new MySqlCommand(@"
                DROP Database if exists "+NOMBRE_BD+";", conexion);
            borrar_test.ExecuteNonQuery();

            CerrarConexion();
        }

        private static void CrearTablaLibro()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Libro` (
	            `isbn13` varchar(13) NOT NULL,
	            `titulo` varchar(150) NOT NULL,
                `subtitulo` varchar(150),
	            `tituloAlternativo` varchar(150),
	            `sinopsis` varchar(500),
	            `numeroPaginas` INT,
	            `fechaPublicacion` DATE,
	            `fechaAdicionBD` DATE,
	            `edicion` INT,
	            `numeroVolumen` INT,
	            `nombreIdioma` varchar(75),
	            `idiomaOriginal` varchar(75),
	            `isbn10` varchar(10),
	            `imagenPortada` varchar(256),
	            `imagenContraportada` varchar(256),
	            `nombreTipoLibro` varchar(40),
	            `mayorEdad` BOOLEAN NOT NULL,
	            `numeroCapitulos` INT NOT NULL,
	            `enlaceReferencia` varchar(256),
                `comentario` varchar(300),
	            PRIMARY KEY (`isbn13`),
                FOREIGN KEY (`nombreIdioma`) REFERENCES `Idioma`(`nombreIdioma`),
                FOREIGN KEY (`idiomaOriginal`) REFERENCES `Idioma`(`nombreIdioma`),
                FOREIGN KEY (`nombreTipoLibro`) REFERENCES `TipoLibro`(`nombreTipoLibro`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaIdioma()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Idioma` (
	            `nombreIdioma` varchar(75) NOT NULL,
	            PRIMARY KEY (`nombreIdioma`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaTipoLibro()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `TipoLibro` (
	            `nombreTipoLibro` varchar(40) NOT NULL,
	            PRIMARY KEY (`nombreTipoLibro`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaEditorial()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Editorial` (
	            `idEditorial` INT NOT NULL,
	            `nombre` varchar(75) NOT NULL,
	            `comentario` varchar(300),
	            `imagen` varchar(256),
	            PRIMARY KEY (`idEditorial`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaListaEditorial()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `ListaEditorial` (
	            `idEditorial` INT NOT NULL,
	            `isbn13` varchar(13) NOT NULL,
	            PRIMARY KEY (`idEditorial`,`isbn13`),
                FOREIGN KEY (`idEditorial`) REFERENCES `Editorial`(`idEditorial`),
                FOREIGN KEY (`isbn13`) REFERENCES `Libro`(`isbn13`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaAutor()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Autor` (
	            `idAutor` INT NOT NULL,
	            `nombre` varchar(150) NOT NULL,
	            `alias` varchar(150),
	            `nombreOcupacion` varchar(75),
	            `fechaNacimiento` DATE,
	            `fechaDefuncion` DATE,
	            `enlaceReferencia` varchar(256),
	            `comentario` varchar(300),
	            `imagen` varchar(256),
	            PRIMARY KEY (`idAutor`),
                FOREIGN KEY (`nombreOcupacion`) REFERENCES `Ocupacion`(`nombreOcupacion`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaOcupacion()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Ocupacion` (
	            `nombreOcupacion` varchar(75) NOT NULL,
	            PRIMARY KEY (`nombreOcupacion`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaListaAutor()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `ListaAutor` (
	            `idAutor` INT NOT NULL,
	            `isbn13` varchar(13) NOT NULL,
	            PRIMARY KEY (`idAutor`,`isbn13`),
                FOREIGN KEY (`idAutor`) REFERENCES `Autor`(`idAutor`),
                FOREIGN KEY (`isbn13`) REFERENCES `Libro`(`isbn13`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaGenero()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Genero` (
	            `idGenero` INT NOT NULL,
	            `nombre` varchar(75),
	            `generoPadre` INT NOT NULL,
	            `comentario` varchar(300),
	            PRIMARY KEY (`idGenero`),
                FOREIGN KEY (`generoPadre`) REFERENCES `Genero`(`idGenero`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaListaGenero()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `ListaGenero` (
	            `idGenero` INT NOT NULL,
	            `isbn13` varchar(13) NOT NULL,
	            PRIMARY KEY (`idGenero`,`isbn13`),
                FOREIGN KEY (`idGenero`) REFERENCES `Genero`(`idGenero`),
                FOREIGN KEY (`isbn13`) REFERENCES `Libro`(`isbn13`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaUsuario()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Usuario` (
	            `correoUsuario` varchar(150) NOT NULL,
	            `nombreUsuario` varchar(50) NOT NULL,
	            `contraseña` varchar(50) NOT NULL,
                `tipoUsuario` varchar(40) NOT NULL,
	            PRIMARY KEY (`correoUsuario`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaUsuarioLibro()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `UsuarioLibro` (
	            `correoUsuario` varchar(150) NOT NULL,
	            `isbn13` varchar(13) NOT NULL,
	            `puntuacion` INT,
	            `vecesLeido` INT,
	            `tiempoLectura` TIME,
	            `fechaComienzo` DATE,
	            `fechaTerminado` DATE,
	            `comentario` varchar(300),
	            `capituloActual` INT,
	            `estadoLectura` varchar(40) NOT NULL,
	            `ocultar` BOOLEAN NOT NULL,
	            `favorito` BOOLEAN NOT NULL,
	            PRIMARY KEY (`correoUsuario`,`isbn13`),
                FOREIGN KEY (`correoUsuario`) REFERENCES `Usuario`(`correoUsuario`),
                FOREIGN KEY (`isbn13`) REFERENCES `Libro`(`isbn13`)
            );", conexion);
            tabla.ExecuteNonQuery();
        }
    }
}
