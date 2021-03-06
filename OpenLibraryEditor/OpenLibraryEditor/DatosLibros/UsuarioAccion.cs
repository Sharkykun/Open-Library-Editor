using System;
using System.Diagnostics;
using System.IO;

namespace OpenLibraryEditor.DatosLibros
{
    public class UsuarioAccion
    {
        private int idAccion;
        private string rutaFichero = "";
        private UsuarioEjecutable ejecutable;

        public UsuarioAccion()
        {
        }

        public UsuarioAccion(Libro libroref, string rutaFichero, UsuarioEjecutable ejecutable)
        {
            SetRandomId(libroref);
            this.rutaFichero = rutaFichero;
            this.ejecutable = ejecutable;
        }

        public int IdAccion { get => idAccion; set => idAccion = value; }
        public string RutaFichero { get => rutaFichero; set => rutaFichero = value; }
        public UsuarioEjecutable Ejecutable { get => ejecutable; set => ejecutable = value; }

        public override string ToString()
        {
            return "Fichero: " + rutaFichero + " || Ejecutable: " + ejecutable.ToString();
        }
        private void SetRandomId(Libro libroref)
        {
            Random rnd = new Random();
            do
            {
                idAccion = rnd.Next();
            } while (libroref.ListaAccion.
                FindIndex(p => idAccion == p.idAccion) != -1);
        }

        public Process EjecutarAccion()
        {
            if (ejecutable != null)
            {
                string exe = "\"" + ejecutable.RutaEjecutable + "\"";
                string cmd = "";
                //Si la constante "file" aparece en los argumentos, colocar ruta fichero ahí
                //Si no, crear estructura por defecto, exe + fichero + argumentos.
                if (ejecutable.Argumentos.Contains(UsuarioEjecutable.CLAVE_FICHERO))
                {
                    string copia = ejecutable.Argumentos.Replace(UsuarioEjecutable.CLAVE_FICHERO, "\"" + rutaFichero + "\"");
                    cmd += " " + copia;
                }
                else
                {
                    cmd += "\"" + rutaFichero + "\" ";
                    cmd += ejecutable.Argumentos;
                }

                if (File.Exists(ejecutable.RutaEjecutable) && File.Exists(rutaFichero))
                {
                    //Lanzar proceso
                    Process p = Process.Start(exe, cmd);
                    return p;
                }
            }
            return null;
        }
    }
}