using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class InfoUsuarioBD : IComparable<InfoUsuarioBD>
    {
        private string nombre;
        private string correo;
        private string tipoUsuario;

        public InfoUsuarioBD(string nombre, string correo, string tipoUsuario)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.tipoUsuario = tipoUsuario;
        }
        public InfoUsuarioBD() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public int CompareTo(InfoUsuarioBD other)
        {
            if (nombre.CompareTo(other.nombre) > 0) return 1;
            else return -1;
        }
    }
}
