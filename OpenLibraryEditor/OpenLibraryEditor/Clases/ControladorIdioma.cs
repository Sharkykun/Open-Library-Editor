using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Clases
{
    public class ControladorIdioma
    {
        public static string idioma = "Strings_es_ES";

        public static string GetTexto(string claveIdioma)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var g = assembly.DefinedTypes.FirstOrDefault(p => p.Name == idioma).DeclaredProperties.FirstOrDefault(p => p.Name == claveIdioma);
            string s = g.GetValue(null, null).ToString();
            return s;
        }
        public static void AbrirFormularioIdioma(string idioma, Type tipoFormulario, out Form form)
        {
            form = (Form)Activator.CreateInstance(tipoFormulario, new object[] { idioma });
        }
    }
}