using System;

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
    }
}