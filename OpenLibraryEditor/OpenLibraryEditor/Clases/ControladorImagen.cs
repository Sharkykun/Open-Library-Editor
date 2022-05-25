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
                    string destFichero = carpetaDestino + nuevoNombreFichero;
                    Directory.CreateDirectory(carpetaDestino);
                    //if (File.Exists(destFichero))
                    //        File.Delete(destFichero);
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

        public static Bitmap ObtenerImagenStream(string rutaImagen)
        { 
            Bitmap bmp = null;
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(rutaImagen)))
            {
                bmp = new Bitmap(ms);
            }
            return bmp;
        }

        public static string RenombrarImagen(string nombreOriginal, string nombreNuevo)
        {
            if (File.Exists(nombreOriginal))
            {
                string[] ruta = nombreOriginal.Split('\\');
                ruta[ruta.Length - 1] = nombreNuevo;
                return Path.Combine(ruta);
            }
            else return null;
        }

        public static byte[] ByteArrayAImagen(byte[] blob)
        {
            if (blob.Length != 0)
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    byte[] pData = blob;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    //return bm;
                }
            }
            return null;
        }

        public static byte[] ImagenAByteArray(string rutaImagen)
        {
            if (File.Exists(rutaImagen))
            {
                return File.ReadAllBytes(rutaImagen);
            }
            return null;
        }
    }
}
