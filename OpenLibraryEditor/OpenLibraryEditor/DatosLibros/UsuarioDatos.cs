using Newtonsoft.Json;
using OpenLibraryEditor.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class UsuarioDatos
    {
        private string ubicacionBD;
        private bool contenidoExplicito = true;
        private string idiomaIntefaz = ControladorIdioma.IDIOMA_ESPANOL;
        private int tipoVista;
        private int accionDobleClick;
        private bool[] descargaDetallesLibro = { true, true, true, true, true };
        private List<InfoBaseDatos> listaInfoBD = new List<InfoBaseDatos>();
        private InfoBaseDatos bDActual;

        //Clave original de Sergio
        //private string googleBooksApiKey = "AIzaSyC9BJTVe8BN8bZGsf7dF4We3Bsz9lL6mPc";

        //Otra clave para hacer mas pruebas
        //private string googleBooksApiKey = "AIzaSyD7DbgxMkwPI02ku_XhqtIPGAWnctQh4us";

        private bool esAdministrador = false;
        private InfoUsuarioBD infoUsuarioActual;
        private string googleBooksApiKey = "AIzaSyC9BJTVe8BN8bZGsf7dF4We3Bsz9lL6mPc";

        private string recordarUrl;
        private string recordarUsuario;
        private string recordarContr;


        public const string RUTA_FICHERO = "config.json";

        //Variables estáticas
        [JsonIgnore]
        public static UsuarioDatos configuracionUsuario = new UsuarioDatos();


        public UsuarioDatos()
        {
        }

        public string GoogleBooksApiKey { get => googleBooksApiKey; set => googleBooksApiKey = value; }
        public string UbicacionBD { get => ubicacionBD; set => ubicacionBD = value; }
        public bool ContenidoExplicito { get => contenidoExplicito; set => contenidoExplicito = value; }
        public string IdiomaIntefaz { get => idiomaIntefaz; set => idiomaIntefaz = value; }
        public int TipoVista { get => tipoVista; set => tipoVista = value; }
        public int AccionDobleClick { get => accionDobleClick; set => accionDobleClick = value; }
        public bool[] DescargaDetallesLibro { get => descargaDetallesLibro; set => descargaDetallesLibro = value; }
        public List<InfoBaseDatos> ListaInfoBD { get => listaInfoBD; set => listaInfoBD = value; }
        [JsonIgnore]
        public InfoBaseDatos BDActual { get => bDActual; set => bDActual = value; }
        [JsonIgnore]
        public bool EsAdministrador { get => esAdministrador; set => esAdministrador = value; }
        [JsonIgnore]
        public InfoUsuarioBD InfoUsuarioActual { get => infoUsuarioActual; set => infoUsuarioActual = value; }
        public string RecordarUrl { get => recordarUrl; set => recordarUrl = value; }
        public string RecordarUsuario { get => recordarUsuario; set => recordarUsuario = value; }
        public string RecordarContr { get => recordarContr; set => recordarContr = value; }

        public static UsuarioDatos CargarJson()
        {
            if (File.Exists(RUTA_FICHERO))
            {
                string json = File.ReadAllText(RUTA_FICHERO);
                UsuarioDatos obj = (UsuarioDatos)JsonConvert.DeserializeObject(json, typeof(UsuarioDatos));
                return obj;
            }
            else
                return new UsuarioDatos();
        }

        public void GuardarJson()
        {
            string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO, jsonString);
        }
    }
}
