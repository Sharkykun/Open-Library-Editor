using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenLibraryEditor.DatosLibros
{
    public class Autor : IComparable<Autor>
    {
        private List<string> listaIdCompartido = new List<string>();
        private int idAutor;
        private string nombre = "";
        private string alias = "";
        private string nombreOcupacion = "";
        private DateTime fechaNacimiento = new DateTime();
        private DateTime fechaDefuncion = new DateTime();
        private string enlaceReferencia = "";
        private string comentario = "";
        private string imagen = "";

        public Autor()
        {
        }
        public Autor(string nombre)
        {
            SetRandomId();
            this.nombre = nombre;
        }

        public Autor(string nombre, string alias, string nombreOcupacion, DateTime fechaNacimiento, DateTime fechaDefuncion, string enlaceReferencia, string comentario, string imagen)
        {
            this.nombre = nombre;
            this.alias = alias;
            this.nombreOcupacion = nombreOcupacion;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaDefuncion = fechaDefuncion;
            this.enlaceReferencia = enlaceReferencia;
            this.comentario = comentario;
            this.imagen = imagen;
        }


        #region Get y Set
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Alias { get => alias; set => alias = value; }
        public string NombreOcupacion { get => nombreOcupacion; set => nombreOcupacion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaDefuncion { get => fechaDefuncion; set => fechaDefuncion = value; }
        public string EnlaceReferencia { get => enlaceReferencia; set => enlaceReferencia = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public List<string> ListaIdCompartido { get => listaIdCompartido; set => listaIdCompartido = value; }

        #endregion

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idAutor = rnd.Next();
            } while (Biblioteca.biblioteca.ListaAutor.
                FindIndex(p => idAutor == p.idAutor) != -1);
        }

        public int CompareTo(Autor other)
        {
            if (nombre.CompareTo(other.nombre) > 0) return 1;
            else if (nombre.CompareTo(other.nombre) == 0)
            {
                if (idAutor > other.idAutor) return 1;
                else if (idAutor == other.idAutor) return 0;
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