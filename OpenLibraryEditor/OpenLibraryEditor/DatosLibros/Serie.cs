using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenLibraryEditor.DatosLibros
{
    public class Serie : IComparable<Serie>
    {
        private int idSerie;
        private string nombre = "";
        private string comentario = "";
        private string imagen = "";
        private string estado = ""; //ID de una lista fija de estados. Finalizada, En publicación, abandonada... Estado de la serie de libros en general
        private List<RelacionSerie> listaRelacionSerie = new List<RelacionSerie>();

        public Serie()
        {
        }
        public Serie(string nombre, string estado)
        {
            SetRandomId();
            this.nombre = nombre;
            this.estado = estado;
        }

        #region Get y Set

        public int IdSerie { get => idSerie; set => idSerie = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Estado { get => estado; set => estado = value; }
        public List<RelacionSerie> ListaRelacionSerie { get => listaRelacionSerie; set => listaRelacionSerie = value; }

        #endregion

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idSerie = rnd.Next();
            } while (Biblioteca.biblioteca.ListaSerie.
                FindIndex(p => idSerie == p.idSerie) != -1);
        }

        public int CompareTo(Serie other)
        {
            if (nombre.CompareTo(other.nombre) > 0) return 1;
            else if (nombre.CompareTo(other.nombre) == 0)
            {
                if (idSerie > other.idSerie) return 1;
                else if (idSerie == other.idSerie) return 0;
                else return -1;
            }
            else return -1;
        }

        override public string ToString()
        {
            return nombre;
        }
    }
}