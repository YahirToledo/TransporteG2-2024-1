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
            SeñalarAñoProduccion();
            Console.WriteLine("Automovil");
            Console.WriteLine("A: Acelerar");
            Console.WriteLine("F: Frenar");
            string accion = Console.ReadLine();
            LimpiarDisplay();
            switch (accion)
            {
                case "A":
                    Acelerar(velocidad);
                    break;
                case "F":
                    Frenar(velocidad);
                    break;
                default:
                    Console.WriteLine("Escriba una ccion valida");
                    break;
            }
        }

    }
}
