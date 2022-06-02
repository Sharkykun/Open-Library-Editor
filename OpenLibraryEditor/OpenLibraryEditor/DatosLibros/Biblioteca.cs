using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class Biblioteca
    {
        public static Biblioteca biblioteca = new Biblioteca();

        private List<string> listaTipoLibro = new List<string>();
        private List<string> listaOcupacion = new List<string>();
        private List<string> listaCategoria = new List<string>();
        private List<string> listaTipoRelacion = new List<string>();
        private List<Editorial> listaEditorial = new List<Editorial>();
        private List<Genero> listaGenero = new List<Genero>();
        private List<Autor> listaAutor = new List<Autor>();
        private List<UsuarioEjecutable> listaEjecutable = new List<UsuarioEjecutable>();
        private List<Libro> listaLibro = new List<Libro>();

        public const string RUTA_FICHERO = "biblioteca.json";


        public List<string> ListaTipoLibro { get => listaTipoLibro; set => listaTipoLibro = value; }
        public List<string> ListaOcupacion { get => listaOcupacion; set => listaOcupacion = value; }
        public List<string> ListaCategoria { get => listaCategoria; set => listaCategoria = value; }
        public List<string> ListaTipoRelacion { get => listaTipoRelacion; set => listaTipoRelacion = value; }
        public List<Editorial> ListaEditorial { get => listaEditorial; set => listaEditorial = value; }
        public List<Genero> ListaGenero { get => listaGenero; set => listaGenero = value; }
        public List<Autor> ListaAutor { get => listaAutor; set => listaAutor = value; }
        public List<UsuarioEjecutable> ListaEjecutable { get => listaEjecutable; set => listaEjecutable = value; }
        public List<Libro> ListaLibro { get => listaLibro; set => listaLibro = value; }
        

        override public string ToString()
        {
            return "Nº de libros: "+ listaLibro.Count;
        }

        public static Biblioteca CargarJson()
        {
            if (File.Exists(RUTA_FICHERO))
            {
                string json = String.IsNullOrWhiteSpace(UsuarioDatos.configuracionUsuario.UbicacionBD) ? 
                    File.ReadAllText(RUTA_FICHERO) :
                    File.ReadAllText(UsuarioDatos.configuracionUsuario.UbicacionBD +
                        "\\" + RUTA_FICHERO);
                Biblioteca obj = (Biblioteca)JsonConvert.DeserializeObject(json, typeof(Biblioteca), new JsonSerializerSettings
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.All
                });
                return obj;
            }
            else
                return new Biblioteca();
        }

        public void GuardarJson()
        {
            string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All
            });
            if(!String.IsNullOrWhiteSpace(UsuarioDatos.configuracionUsuario.UbicacionBD))
                File.WriteAllText(UsuarioDatos.configuracionUsuario.UbicacionBD+
                    "\\"+RUTA_FICHERO, jsonString);
            else
                File.WriteAllText(RUTA_FICHERO, jsonString);
        }
    }
}
