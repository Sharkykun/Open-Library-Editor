using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class Biblioteca
    {
        private int idBiblioteca;
        private string nombre;
        private List<Libro> listaLibro = new List<Libro>();
        private string imagen;

        public Biblioteca()
        {
        }

        public Biblioteca(int idBiblioteca, string nombre)
        {
            this.idBiblioteca = idBiblioteca;
            this.nombre = nombre;
        }

        public int IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Libro> ListaLibro { get => listaLibro; set => listaLibro = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        override public string ToString()
        {
            return nombre;
        }
    }
}
