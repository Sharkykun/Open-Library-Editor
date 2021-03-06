using OpenLibraryEditor.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class Genero : IComparable<Genero>, IOperacionesBD
    {
        private List<string> listaIdCompartido = new List<string>();
        private int idGenero;
        private string nombre = "";
        private string comentario = "";

        public Genero()
        {
        }
        public Genero(string nombre)
        {
            SetRandomId();
            this.nombre = nombre;
        }

        public Genero(string nombre, string comentario)
        {
            this.nombre = nombre;
            this.comentario = comentario;
        }

        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public List<string> ListaIdCompartido { get => listaIdCompartido; set => listaIdCompartido = value; }

        public int CompareTo(Genero otro)
        {
            if (nombre.CompareTo(otro.nombre) > 0) return 1;
            else if (nombre.CompareTo(otro.nombre) == 0)
            {
                if (idGenero > otro.idGenero) return 1;
                else if (idGenero == otro.idGenero) return 0;
                else return -1;
            }
            else return -1;
        }

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idGenero = rnd.Next();
            } while (Biblioteca.biblioteca.ListaGenero.
                FindIndex(p => idGenero == p.idGenero) != -1);
        }

        override public string ToString()
        {
            return nombre;
        }

        public void MeterEnBDCompartida()
        {
            if (EscrituraBD.GetObjetoIdDeLocal(listaIdCompartido) > 0)
            {
                EscrituraBD.UpdateGenero(this);
            }
            else
            {
                EscrituraBD.InsertGenero(this);
            }
        }

        public bool BorraDeBDCompartida()
        {
            //Borrar referencia con libros, si existe
            EscrituraBD.DeleteListaGeneroDesdeGenero(this);

            return EscrituraBD.DeleteGenero(this);
        }
    }
}
