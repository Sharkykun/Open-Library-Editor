using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.Clases
{
    public static class ControladorImagen
    {
        //Directorios para guardar imagenes en local
        public const string RUTA_BASE = ".\\img\\";
        public const string RUTA_LIBRO = RUTA_BASE + "book\\";
        public const string RUTA_PERSONA = RUTA_BASE + "people\\";
        public const string RUTA_IDIOMA = RUTA_BASE + "language\\";
        public const string RUTA_SERIE = RUTA_BASE + "serie\\";
        public const string RUTA_EDITORIAL = RUTA_BASE + "editorial\\";

        public static string GuardarImagen(string ficheroOrigen, string carpetaDestino, string nuevoNombreFichero)
        {
            //Copiar imagen nueva y usar nueva ruta relativa
            if (!String.IsNullOrWhiteSpace(ficheroOrigen))
            {
                try
                {
                    string extension = Path.GetExtension(ficheroOrigen);
                    string destFichero = carpetaDestino + nuevoNombreFichero + extension;
                    Directory.CreateDirectory(carpetaDestino);
                    File.Copy(ficheroOrigen, destFichero, true);
                    return destFichero;
                }
                catch (FileNotFoundException)
                {
                    VentanaWindowsComun.MensajeError("No se cargó la imagen correctamente.");
                }
            }
            return "";
        }

        public static string RenombrarImagen(string nombreOriginal, string nombreNuevo)
        {
            string[] ruta = nombreOriginal.Split('\\');
            ruta[ruta.Length - 1] = nombreNuevo;
            return Path.Combine(ruta);
        }
    }
}
