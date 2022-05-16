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
        private string servidorIP;
        private int puerto;

        public InfoBaseDatos()
        {
        }

        public InfoBaseDatos(string nombre, string servidorIP, int puerto)
        {
            this.nombre = nombre;
            this.servidorIP = servidorIP;
            this.puerto = puerto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ServidorIP { get => servidorIP; set => servidorIP = value; }
        public int Puerto { get => puerto; set => puerto = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
