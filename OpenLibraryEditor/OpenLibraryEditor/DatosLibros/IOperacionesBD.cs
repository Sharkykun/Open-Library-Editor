using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.DatosLibros
{
    public interface IOperacionesBD
    {
        void MeterEnBDCompartida();
        void BorraDeBDCompartida();
    }
}
