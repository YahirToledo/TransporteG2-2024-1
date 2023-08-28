using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2_2024_1
{
    internal class Automovil : Transporte
    {
        public Automovil()
        {
            SeñalarMarca();
            if (marca == "BMW")
            {
                Console.WriteLine("Automovil");
            }
        }
    }
}
