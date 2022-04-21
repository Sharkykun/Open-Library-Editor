using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class UsuarioDatos
    {
        private string estanteriaImagen;
        private int estanteriaPosX;
        private int estanteriaPosY;
        private int estanteriaPadding;
        private string googleBooksApiKey;

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

        public UsuarioDatos(int estanteriaPosX, int estanteriaPosY, int estanteriaPadding)
        {
            this.estanteriaPosX = estanteriaPosX;
            this.estanteriaPosY = estanteriaPosY;
            this.estanteriaPadding = estanteriaPadding;
        }

        public string EstanteriaImagen { get => estanteriaImagen; set => estanteriaImagen = value; }
        public int EstanteriaPosX { get => estanteriaPosX; set => estanteriaPosX = value; }
        public int EstanteriaPosY { get => estanteriaPosY; set => estanteriaPosY = value; }
        public int EstanteriaPadding { get => estanteriaPadding; set => estanteriaPadding = value; }
        public string GoogleBooksApiKey { get => googleBooksApiKey; set => googleBooksApiKey = value; }
    }
}
