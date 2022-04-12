using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenLibraryEditor.DatosLibros
{
    public class Persona : IComparable<Persona>
    {
        private int idPersona;
        private string nombre = "";
        private string alias = "";
        private string nombreOcupacion = "";
        private DateTime fechaNacimiento = new DateTime();
        private DateTime fechaDefuncion = new DateTime();
        private string enlaceReferencia = "";
        private string comentario = "";
        private string imagen = "";

        //Lista estática de ocupaciones
        [JsonIgnore]
        public static List<string> ocupacionLista = new List<string>();

        public Persona()
        {
        }
        public Persona(string nombre)
        {
            SetRandomId();
            this.nombre = nombre;
        }

        #region Get y Set
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Alias { get => alias; set => alias = value; }
        public string NombreOcupacion { get => nombreOcupacion; set => nombreOcupacion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaDefuncion { get => fechaDefuncion; set => fechaDefuncion = value; }
        public string EnlaceReferencia { get => enlaceReferencia; set => enlaceReferencia = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        #endregion

        private void SetRandomId()
        {
            Random rnd = new Random();
            do
            {
                idPersona = rnd.Next();
            } while (UsuarioDatos.listaPersona.
                FindIndex(p => idPersona == p.idPersona) != -1);
        }

        public int CompareTo(Persona other)
        {
            if (nombre.CompareTo(other.nombre) > 0) return 1;
            else if (nombre.CompareTo(other.nombre) == 0)
            {
                if (idPersona > other.idPersona) return 1;
                else if (idPersona == other.idPersona) return 0;
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