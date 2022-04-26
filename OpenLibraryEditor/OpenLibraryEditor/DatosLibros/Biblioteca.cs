using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class Biblioteca
    {
        private List<Libro> listaLibro = new List<Libro>();

        public List<Libro> ListaLibro { get => listaLibro; set => listaLibro = value; }
       
        override public string ToString()
        {
            return "Nº de libros: "+ listaLibro.Count;
        }
    }
}
