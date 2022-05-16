using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenLibraryEditor.DatosLibros
{
    public class Etiqueta : IComparable<Etiqueta>
    {
        private int idEtiqueta;
        private string nombre = "";
        private string comentario = "";
        private string nombreCategoria = "";

        public Etiqueta()
        {
        }
        public Etiqueta(string nombre)
        {
            SetRandomId();
            this.nombre = nombre;
        }

        public int IdEtiqueta { get => idEtiqueta; set => idEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }

        public int CompareTo(Etiqueta other)
        {
            if (nombre.CompareTo(other.nombre) > 0) return 1;
            else if (nombre.CompareTo(other.nombre) == 0)
            {
                if (idEtiqueta > other.idEtiqueta) return 1;
                else if (idEtiqueta == other.idEtiqueta) return 0;
                else return -1;
            }
            else return -1;
        }

        public bool Equals(Etiqueta obj)
        {
            if (nombre.Equals(obj.nombre) && idEtiqueta.Equals(obj.idEtiqueta))
                return true;
            else
                return false;
        }

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idEtiqueta = rnd.Next();
            } while (Biblioteca.biblioteca.ListaEtiqueta.
                FindIndex(p => idEtiqueta == p.idEtiqueta) != -1);
        }

        override public string ToString()
        {
            return nombre;
        }
    }
}