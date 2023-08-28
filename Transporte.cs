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
        private string marca;
        private ushort añoProduccion;
        #endregion

        #region Metodo
        public void SeñalarMarca()
        {
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
        }
        #endregion
    }
}
