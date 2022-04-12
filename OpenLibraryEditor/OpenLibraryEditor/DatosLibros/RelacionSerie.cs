using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public class RelacionSerie
    {
        //Añadir relaciones entre series.
        private Serie serie; //Identificador de la serie a la que aplicar la relación
        private string nombreTipoRelacionSerie = ""; //Tipo de relación desde serie base. Sacada de lista de tipos de relación establecida por el usuario.

        //Lista estática de ocupaciones
        public static List<string> tipoRelacionLista = new List<string>();

        public RelacionSerie()
        {
        }
        public RelacionSerie(Serie serie, string nombreTipoRelacionSerie)
        {
            this.serie = serie;
            this.nombreTipoRelacionSerie = nombreTipoRelacionSerie;
        }

        #region Get y Set
        public Serie Serie { get => serie; set => serie = value; }
        public string NombreTipoRelacionSerie { get => nombreTipoRelacionSerie; set => nombreTipoRelacionSerie = value; }
        #endregion
        override public string ToString()
        {
            return "Serie: " + serie + "\nRelación: " + nombreTipoRelacionSerie;
        }

        public bool Equals(RelacionSerie otro)
        {
            if (serie == otro.Serie &&
                nombreTipoRelacionSerie == otro.NombreTipoRelacionSerie)
                return true;
            else
                return false;
        }

        public RelacionSerie Copy()
        {
            RelacionSerie relacion = new RelacionSerie(serie, nombreTipoRelacionSerie);
            return relacion;
        }
    }
}
