using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class InfoBaseDatos
    {
        private string nombre;
        private string servidorUrl;
        private int puerto;

        public InfoBaseDatos()
        {
        }

        public InfoBaseDatos(string nombre, string servidorUrl, int puerto)
        {
            this.nombre = nombre;
            this.servidorUrl = servidorUrl;
            this.puerto = puerto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ServidorUrl { get => servidorUrl; set => servidorUrl = value; }
        public int Puerto { get => puerto; set => puerto = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
