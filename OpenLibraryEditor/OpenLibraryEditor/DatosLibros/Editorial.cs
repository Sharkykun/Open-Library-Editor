using OpenLibraryEditor.BaseDatos;
using System;
using System.Collections.Generic;

namespace OpenLibraryEditor.DatosLibros
{
    public class Editorial : IComparable<Editorial>, IOperacionesBD
    {
        private List<string> listaIdCompartido = new List<string>();
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

        public Editorial(string nombre, string comentario, string imagen)
        {
            this.nombre = nombre;
            this.comentario = comentario;
            this.imagen = imagen;
        }

        #region Get y Set
        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public List<string> ListaIdCompartido { get => listaIdCompartido; set => listaIdCompartido = value; }
        #endregion

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idEditorial = rnd.Next();
            } while (Biblioteca.biblioteca.ListaEditorial.
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

        public void MeterEnBDCompartida()
        {
            if (EscrituraBD.GetObjetoIdDeLocal(listaIdCompartido) > 0)
            {
                EscrituraBD.UpdateEditorial(this);
            }
            else
            {
                EscrituraBD.InsertEditorial(this);
            }
        }

        public void BorraDeBDCompartida()
        {
            //Borrar referencia con libros, si existe
            EscrituraBD.DeleteListaEditorialDesdeEditorial(this);

            EscrituraBD.DeleteEditorial(this);
        }
    }
}