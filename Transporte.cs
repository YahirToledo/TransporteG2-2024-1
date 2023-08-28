using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2_2024_1
{
    internal abstract class Transporte
    {
        #region Atributos
        public string marca;
        public ushort añoProduccion;
        #endregion

        #region Metodo
        public void SeñalarAñoProduccion()
        {
            añoProduccion = 2023;
            Console.WriteLine("Año de produccion: {0}", añoProduccion);
        }
        #endregion
    }
}
