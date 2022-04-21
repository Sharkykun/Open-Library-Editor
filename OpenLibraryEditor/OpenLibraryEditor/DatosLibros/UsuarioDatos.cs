using Newtonsoft.Json;
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
        private bool cargaUltimaBD = true;
        private string ubicacionBD;
        private bool contenidoExplicito = true;
        private string idiomaIntefaz;
        private int tipoVista;
        private string accionDobleClick;
        private string tema;
        private bool[] descargaDetallesLibro = { true, true, true, true, true };
        private int tamañoImagenLibro;
        private List<InfoBaseDatos> listaInfoBD = new List<InfoBaseDatos>();
        private InfoBaseDatos bDActual;
        private string googleBooksApiKey;

        public const string RUTA_FICHERO = "config.json";

        //Listas estática para todo lo local
        [JsonIgnore]
        public static Biblioteca biblioteca = new Biblioteca();
        [JsonIgnore]
        public static List<Editorial> listaEditorial = new List<Editorial>();
        [JsonIgnore]
        public static List<Genero> listaGenero = new List<Genero>();
        [JsonIgnore]
        public static List<Persona> listaPersona = new List<Persona>();
        [JsonIgnore]
        public static List<Serie> listaSerie = new List<Serie>();
        [JsonIgnore]
        public static List<Etiqueta> listaEtiqueta = new List<Etiqueta>();
        [JsonIgnore]
        public static List<Idioma> listaIdioma = new List<Idioma>();
        [JsonIgnore]
        public static List<UsuarioEjecutable> listaEjecutable = new List<UsuarioEjecutable>();

        public UsuarioDatos()
        {
        }

        public string GoogleBooksApiKey { get => googleBooksApiKey; set => googleBooksApiKey = value; }
        public bool CargaUltimaBD { get => cargaUltimaBD; set => cargaUltimaBD = value; }
        public string UbicacionBD { get => ubicacionBD; set => ubicacionBD = value; }
        public bool ContenidoExplicito { get => contenidoExplicito; set => contenidoExplicito = value; }
        public string IdiomaIntefaz { get => idiomaIntefaz; set => idiomaIntefaz = value; }
        public int TipoVista { get => tipoVista; set => tipoVista = value; }
        public string AccionDobleClick { get => accionDobleClick; set => accionDobleClick = value; }
        public string Tema { get => tema; set => tema = value; }
        public bool[] DescargaDetallesLibro { get => descargaDetallesLibro; set => descargaDetallesLibro = value; }
        public int TamañoImagenLibro { get => tamañoImagenLibro; set => tamañoImagenLibro = value; }
        public List<InfoBaseDatos> ListaInfoBD { get => listaInfoBD; set => listaInfoBD = value; }
        public InfoBaseDatos BDActual { get => bDActual; set => bDActual = value; }

        private static object CargarJson()
        {
            string json = File.ReadAllText(RUTA_FICHERO);
            UsuarioDatos obj = (UsuarioDatos)JsonConvert.DeserializeObject(json, typeof(UsuarioDatos));
            return obj;
        }

        private void GuardarJson()
        {
            string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO, jsonString);
        }
    }
}
