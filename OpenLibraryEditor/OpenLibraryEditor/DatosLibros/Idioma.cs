using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class Idioma
    {
        private string nombreIdioma;
        private string rutaImagen;

        public Idioma()
        {
        }
        public Idioma(string nombreIdioma)
        {
            this.nombreIdioma = nombreIdioma;
        }

        public string NombreIdioma { get => nombreIdioma; set => nombreIdioma = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }
    }
}
