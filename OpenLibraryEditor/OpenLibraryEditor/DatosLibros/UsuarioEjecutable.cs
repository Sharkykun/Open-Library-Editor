using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class UsuarioEjecutable
    {
        private string nombreEjecutable = "";
        private string extensionFichero = "";
        private string rutaEjecutable = "";
        private string argumentos = "";

        public const string CLAVE_FICHERO = "{file}";

        public UsuarioEjecutable(string nombreEjecutable)
        {
            this.nombreEjecutable = nombreEjecutable;
        }

        public string NombreEjecutable { get => nombreEjecutable; set => nombreEjecutable = value; }
        public string ExtensionFichero { get => extensionFichero; set => extensionFichero = value; }
        public string RutaEjecutable { get => rutaEjecutable; set => rutaEjecutable = value; }
        public string Argumentos { get => argumentos; set => argumentos = value; }

        public override string ToString()
        {
            return nombreEjecutable;
        }
    }
}
