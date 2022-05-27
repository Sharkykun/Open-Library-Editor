using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;

namespace OpenLibraryEditor.BaseDatos
{
    public class ConexionBD
    {
        public static MySqlConnection Conexion;
        public static int IdBD;
        public const string NOMBRE_BD = "open_library_editor";
        public const string ANTENOMBRE_USUARIO_BD = "ole_";

        public static void CrearBD(string servidor, string usuario, string contrasena, string puerto)
        {
            BorrarBD(servidor, usuario, contrasena, puerto);

            EstablecerConexion(servidor, usuario, contrasena, puerto);

            if(!AbrirConexion())
            {
                Console.WriteLine("No existe la BD. Creando...");
                EstablecerConexionNueva(servidor, usuario, contrasena, puerto);
                AbrirConexion();

                //Crear base de datos si no existe
                MySqlCommand cmd = new MySqlCommand("create database if not exists " + NOMBRE_BD, Conexion);
                cmd.ExecuteNonQuery();

                CerrarConexion();

                //Cerramos y abrimos de nuevo la conexion pero con la BD creada
                EstablecerConexion(servidor, usuario, contrasena, puerto);
                AbrirConexion();
            }

            //Creamos tablas
            CrearTablaIdBD();
            CrearTablaUsuario();
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

            //Creamos usuario ole_anon (sin contraseña) que usarán usuarios externos para hacer consultas
            //Servirá tambien para cargar un tipo de usuario
            CrearUsuarioExternoBD();
            CrearUsuarioRegistroBD();

            //Generar ID random propio de la BD
            Random rnd = new Random();
            EscrituraBD.InsertarIdBD(rnd.Next());
            IdBD = LecturaBD.SelectObtenerIdBD();

            CerrarConexion();
        }

        private static void EstablecerConexionNueva(string servidor, string usuario, string contrasena, string puerto)
        {
            //Iniciar sesion con ip, usuario y contraseña
            string connString = "server=" + servidor + ";uid=" + usuario + ";pwd=" + contrasena + ";port=" + puerto + ";";
            Conexion = new MySqlConnection(connString);
        }

        public static bool EstablecerConexion(string servidor, string usuario, string contrasena, string puerto)
        {
            //Iniciar sesion ahora con bd
            string connString = "server=" + servidor + ";database=" + NOMBRE_BD +
                ";uid=" + usuario + ";pwd=" + contrasena + ";port=" + puerto + "; Convert Zero Datetime=True;";
            Conexion = new MySqlConnection(connString);
            
            return true;
        }

        public static bool AbrirConexion()
        {
            //No poner mensaje de error en ventana aquí
            try
            {
                Console.WriteLine("Conexion con MySql abierta.");
                //Abrir conexión
                Conexion.Open();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }
        }

        public static bool CerrarConexion()
        {
            //No poner mensaje de error en ventana aquí
            try
            {
                Console.WriteLine("Conexion con MySql cerrada.");
                //Cerrar conexión
                Conexion.Close();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }
        }

        private static void BorrarBD(string servidor, string usuario, string contrasena, string puerto)
        {
            EstablecerConexion(servidor, usuario, contrasena, puerto);
            try
            {
                AbrirConexion();

                MySqlCommand borrar_test = new MySqlCommand(@"
                DROP Database if exists " + NOMBRE_BD + ";", Conexion);
                borrar_test.ExecuteNonQuery();

                //MySqlCommand comando = new MySqlCommand(@"
                //DROP USER '" + ConexionBD.ANTENOMBRE_USUARIO_BD + "%';",
                //ConexionBD.Conexion);
                //comando.ExecuteNonQuery();

                CerrarConexion();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No se pudo borrar la BD.");
            }
        }

        #region Crear usuarios de BD

        public static void CrearAdminBD(string nombreUsuario, string contrasenia, string email)
        {
            string nombreFinal = ANTENOMBRE_USUARIO_BD + nombreUsuario;
            CrearUsuarioBD(nombreFinal, contrasenia);
            //Arreglar problema de corrupcion de una tabla que no sé el motivo
            //Esto lo deja bien, sin romper nada que hubiera.
            MySqlCommand cmd = new MySqlCommand("REPAIR TABLE mysql.db USE_FRM;",
                Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT ALL ON " +
                NOMBRE_BD+" .* TO'"+ nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT GRANT OPTION ON " +
                NOMBRE_BD + " .* TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT ALL ON " +
                "mysql .user TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT GRANT OPTION ON " +
                "mysql .user TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT CREATE USER, RELOAD ON " +
                "*.* TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            AplicarPermisosUsuario();


            //Incluir datos en tabla Usuario
            EscrituraBD.InsertUsuario(new InfoUsuarioBD(nombreUsuario, email, "Administrador"),
                contrasenia);
        }

        private static void AplicarPermisosUsuario()
        {
            MySqlCommand cmd = new MySqlCommand("FLUSH PRIVILEGES;", Conexion);
            cmd.ExecuteNonQuery();
        }

        public static void CrearEditorBD(string nombreUsuario, string contrasenia, string nombreAntiguo)
        {
            string nombreFinal = ANTENOMBRE_USUARIO_BD + nombreUsuario;
            if (contrasenia != null)
                CrearUsuarioBD(nombreFinal, contrasenia);
            QuitarPrivilegiosUsuarioBD(nombreAntiguo, false);
            AplicarPermisosUsuario();
            ConcederLecturaTabla("Biblioteca", nombreFinal);
            ConcederLecturaTabla("Usuario", nombreFinal);
            ConcederEdicionTabla("UsuarioLibro", nombreFinal);
            ConcederEdicionTabla("Libro", nombreFinal);
            ConcederEdicionTabla("TipoLibro", nombreFinal);
            ConcederEdicionTabla("ListaAutor", nombreFinal);
            ConcederEdicionTabla("Autor", nombreFinal);
            ConcederEdicionTabla("Ocupacion", nombreFinal);
            ConcederEdicionTabla("ListaEditorial", nombreFinal);
            ConcederEdicionTabla("Editorial", nombreFinal);
            ConcederEdicionTabla("ListaGenero", nombreFinal);
            ConcederEdicionTabla("Genero", nombreFinal);
            AplicarPermisosUsuario();
        }

        public static void CrearUsuarioComunBD(string nombreUsuario, string contrasenia, string nombreAntiguo)
        {
            string nombreFinal = ANTENOMBRE_USUARIO_BD + nombreUsuario;
            if(contrasenia != null)
                CrearUsuarioBD(nombreFinal, contrasenia);
            QuitarPrivilegiosUsuarioBD(nombreAntiguo, true);
            AplicarPermisosUsuario();
            ConcederLecturaTabla("Biblioteca", nombreFinal);
            ConcederLecturaTabla("Usuario", nombreFinal);
            ConcederEdicionTabla("UsuarioLibro", nombreFinal);
            ConcederLecturaTabla("Libro", nombreFinal);
            ConcederLecturaTabla("TipoLibro", nombreFinal);
            ConcederLecturaTabla("ListaAutor", nombreFinal);
            ConcederLecturaTabla("Autor", nombreFinal);
            ConcederLecturaTabla("Ocupacion", nombreFinal);
            ConcederLecturaTabla("ListaEditorial", nombreFinal);
            ConcederLecturaTabla("Editorial", nombreFinal);
            ConcederLecturaTabla("ListaGenero", nombreFinal);
            ConcederLecturaTabla("Genero", nombreFinal);
            AplicarPermisosUsuario();
        }

        public static void CrearUsuarioExternoBD()
        {
            string nombreFinal = ANTENOMBRE_USUARIO_BD + "anon";
            CrearUsuarioBD(nombreFinal, "");
            ConcederLecturaTabla("Biblioteca", nombreFinal);
            ConcederLecturaTabla("Usuario", nombreFinal);
            ConcederLecturaTabla("UsuarioLibro", nombreFinal);
            ConcederLecturaTabla("Libro", nombreFinal);
            ConcederLecturaTabla("TipoLibro", nombreFinal);
            ConcederLecturaTabla("ListaAutor", nombreFinal);
            ConcederLecturaTabla("Autor", nombreFinal);
            ConcederLecturaTabla("Ocupacion", nombreFinal);
            ConcederLecturaTabla("ListaEditorial", nombreFinal);
            ConcederLecturaTabla("Editorial", nombreFinal);
            ConcederLecturaTabla("ListaGenero", nombreFinal);
            ConcederLecturaTabla("Genero", nombreFinal);
            AplicarPermisosUsuario();
        }

        public static void CrearUsuarioRegistroBD()
        {
            string nombreFinal = ANTENOMBRE_USUARIO_BD + "register";
            CrearUsuarioBD(nombreFinal, "ole123Ole");
            MySqlCommand cmd = new MySqlCommand("REPAIR TABLE mysql.db USE_FRM;",
                Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT SELECT ON " +
                NOMBRE_BD + " .* TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            ConcederEdicionTabla("Usuario", nombreFinal);
            ConcederEdicionTabla("UsuarioLibro", nombreFinal);
            cmd = new MySqlCommand("GRANT GRANT OPTION ON " +
                NOMBRE_BD + " .* TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT ALL ON " +
                "mysql .user TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT GRANT OPTION ON " +
                "mysql .user TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("GRANT CREATE USER, RELOAD, ALTER ON " +
                "*.* TO'" + nombreFinal + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
            AplicarPermisosUsuario();
        }

        private static void CrearUsuarioBD(string nombreUsuario, string contrasenia)
        {
            MySqlCommand cmd;
            if (LecturaBD.SelectExisteUsuarioBD(nombreUsuario) == 0)
            {
                cmd = new MySqlCommand("CREATE USER '" + nombreUsuario + "'@'%' IDENTIFIED BY '" + contrasenia + "'", Conexion);
                cmd.ExecuteNonQuery();
            }
        }

        private static void QuitarPrivilegiosUsuarioBD(string nombreUsuario, bool esEditor)
        {
            if (esEditor)
            {
                QuitarPrivilegios(nombreUsuario, "Biblioteca", false);
                QuitarPrivilegios(nombreUsuario, "Usuario", false);
                QuitarPrivilegios(nombreUsuario, "UsuarioLibro", true);
                QuitarPrivilegios(nombreUsuario, "Libro", true);
                QuitarPrivilegios(nombreUsuario, "TipoLibro", true);
                QuitarPrivilegios(nombreUsuario, "ListaAutor", true);
                QuitarPrivilegios(nombreUsuario, "Autor", true);
                QuitarPrivilegios(nombreUsuario, "Ocupacion", true);
                QuitarPrivilegios(nombreUsuario, "ListaEditorial", true);
                QuitarPrivilegios(nombreUsuario, "Editorial", true);
                QuitarPrivilegios(nombreUsuario, "ListaGenero", true);
                QuitarPrivilegios(nombreUsuario, "Genero", true);
            }
            else
            {
                QuitarPrivilegios(nombreUsuario, "Biblioteca", false);
                QuitarPrivilegios(nombreUsuario, "Usuario", false);
                QuitarPrivilegios(nombreUsuario, "UsuarioLibro", true);
                QuitarPrivilegios(nombreUsuario, "Libro", false);
                QuitarPrivilegios(nombreUsuario, "TipoLibro", false);
                QuitarPrivilegios(nombreUsuario, "ListaAutor", false);
                QuitarPrivilegios(nombreUsuario, "Autor", false);
                QuitarPrivilegios(nombreUsuario, "Ocupacion", false);
                QuitarPrivilegios(nombreUsuario, "ListaEditorial", false);
                QuitarPrivilegios(nombreUsuario, "Editorial", false);
                QuitarPrivilegios(nombreUsuario, "ListaGenero", false);
                QuitarPrivilegios(nombreUsuario, "Genero", false);
            }
        }

        private static void QuitarPrivilegios(string nombreUsuario, string tabla, bool esEscritura)
        {
            try
            {
                if (!esEscritura)
                {
                    MySqlCommand cmd = new MySqlCommand("REVOKE SELECT ON " +
                       NOMBRE_BD + "."+tabla+" FROM '" + nombreUsuario + "'@'%';", Conexion);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("REVOKE SELECT,INSERT,UPDATE,DELETE ON " +
                       NOMBRE_BD + "." + tabla +" FROM '" + nombreUsuario + "'@'%';", Conexion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException)
            {
                Console.WriteLine("Sin permisos en la BD para este usuario.");
            }
        }

        private static void ConcederEdicionTabla(string tabla, string nombreUsuario)
        {
            MySqlCommand cmd = new MySqlCommand("GRANT SELECT,INSERT,DELETE,UPDATE ON " +
               NOMBRE_BD + "."+tabla+" TO'" + nombreUsuario + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
        }

        private static void ConcederLecturaTabla(string tabla, string nombreUsuario)
        {
            MySqlCommand cmd = new MySqlCommand("GRANT SELECT ON " +
               NOMBRE_BD + "." + tabla + " TO'" + nombreUsuario + "'@'%';", Conexion);
            cmd.ExecuteNonQuery();
        }

        #endregion

        private static void CrearTablaLibro()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Libro` (
                `idLibro` INT NOT NULL,
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
	            `idioma` varchar(75),
	            `idiomaOriginal` varchar(75),
	            `isbn10` varchar(10),
	            `imagenPortada` MEDIUMBLOB,
	            `imagenContraportada` MEDIUMBLOB,
	            `nombreTipoLibro` varchar(40),
	            `mayorEdad` BOOLEAN NOT NULL,
	            `numeroCapitulos` INT,
	            `enlaceReferencia` varchar(256),
                PRIMARY KEY (`idLibro`),
                FOREIGN KEY (`nombreTipoLibro`) REFERENCES `TipoLibro`(`nombreTipoLibro`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaTipoLibro()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `TipoLibro` (
	            `nombreTipoLibro` varchar(40) NOT NULL,
	            PRIMARY KEY (`nombreTipoLibro`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaEditorial()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Editorial` (
                `idEditorial` INT NOT NULL,
	            `nombreEditorial` varchar(75) NOT NULL,
	            `comentario` varchar(300),
	            `imagen` MEDIUMBLOB,
	            PRIMARY KEY (`idEditorial`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaListaEditorial()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `ListaEditorial` (
	            `idEditorial` INT NOT NULL,
	            `idLibro` INT NOT NULL,
	            PRIMARY KEY (`idEditorial`,`idLibro`),
                FOREIGN KEY (`idEditorial`) REFERENCES `Editorial`(`idEditorial`),
                FOREIGN KEY (`idLibro`) REFERENCES `Libro`(`idLibro`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }
        private static void CrearTablaAutor()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Autor` (
                `idAutor` INT NOT NULL,
	            `nombreAutor` varchar(150) NOT NULL,
	            `alias` varchar(150),
	            `nombreOcupacion` varchar(75),
	            `fechaNacimiento` DATE,
	            `fechaDefuncion` DATE,
	            `enlaceReferencia` varchar(256),
	            `comentario` varchar(300),
	            `imagen` MEDIUMBLOB,
	            PRIMARY KEY (`idAutor`),
                FOREIGN KEY (`nombreOcupacion`) REFERENCES `Ocupacion`(`nombreOcupacion`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaOcupacion()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Ocupacion` (
	            `nombreOcupacion` varchar(75) NOT NULL,
	            PRIMARY KEY (`nombreOcupacion`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaListaAutor()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `ListaAutor` (
	            `idAutor` INT NOT NULL,
	            `idLibro` INT NOT NULL,
	            PRIMARY KEY (`idAutor`,`idLibro`),
                FOREIGN KEY (`idAutor`) REFERENCES `Autor`(`idAutor`),
                FOREIGN KEY (`idLibro`) REFERENCES `Libro`(`idLibro`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaGenero()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Genero` (
                `idGenero` INT NOT NULL,
	            `nombreGenero` varchar(75) NOT NULL,
	            `comentario` varchar(300),
	            PRIMARY KEY (`idGenero`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaListaGenero()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `ListaGenero` (
	            `idGenero` INT NOT NULL,
	            `idLibro` INT NOT NULL,
	            PRIMARY KEY (`idGenero`,`idLibro`),
                FOREIGN KEY (`idGenero`) REFERENCES `Genero`(`idGenero`),
                FOREIGN KEY (`idLibro`) REFERENCES `Libro`(`idLibro`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaUsuario()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Usuario` (
	            `correoUsuario` varchar(150) UNIQUE NOT NULL,
	            `nombreUsuario` varchar(50) NOT NULL,
                `tipoUsuario` varchar(40) NOT NULL,
                `imagenPerfil` MEDIUMBLOB,
	            PRIMARY KEY (`nombreUsuario`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaUsuarioLibro()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `UsuarioLibro` (
	            `nombreUsuario` varchar(50) NOT NULL,
	            `idLibro` INT NOT NULL,
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
	            PRIMARY KEY (`nombreUsuario`,`idLibro`),
                FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario`(`nombreUsuario`),
                FOREIGN KEY (`idLibro`) REFERENCES `Libro`(`idLibro`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }

        private static void CrearTablaIdBD()
        {
            MySqlCommand tabla = new MySqlCommand(@"
            CREATE TABLE `Biblioteca` (
	            `idBD` INT NOT NULL,
	            PRIMARY KEY (`idBD`)
            );", Conexion);
            tabla.ExecuteNonQuery();
        }
    }
}
