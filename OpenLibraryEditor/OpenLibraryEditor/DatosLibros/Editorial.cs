using System;
using System.Collections.Generic;

namespace OpenLibraryEditor.DatosLibros
{
    public class Editorial : IComparable<Editorial>
    {
        private int idEditorial;
        private string nombre = "";
        private string comentario = "";
        private string imagen = "";

        public Editorial()
        {
        }

        public Editorial(string nombre)
        {
            SetRandomId();
            this.nombre = nombre;
        }

        #region Get y Set
        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        #endregion

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idEditorial = rnd.Next();
            } while (UsuarioDatos.listaEditorial.
                FindIndex(p => idEditorial == p.idEditorial) != -1);
        }

        public int CompareTo(Editorial otro)
        {
            if (nombre.CompareTo(otro.nombre) > 0) return 1;
            else if (nombre.CompareTo(otro.nombre) == 0)
            {
                if (idEditorial > otro.idEditorial) return 1;
                else if (idEditorial == otro.idEditorial) return 0;
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