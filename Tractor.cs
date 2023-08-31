using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TransporteG2_2024_1
{
    internal class Tractor : Transporte
    {
        #region Propiedades
        public override float Velocidad 
        { 
            get => base.Velocidad;
            set
            {
                if (value < 50)
                {
                    velocidad = value;
                }
                else
                {
                    velocidad = 30;
                }
            } 
        }

        #endregion
        public Tractor()
        {
            SeñalarAñoProduccion();
            Console.WriteLine("Tractor");
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
        public override void Acelerar(float velocidad)
        {
            Console.WriteLine("El tractor esta a {0} [km/h]", velocidad);
            LimpiarDisplay();
            Console.WriteLine("Acelerando");
            LimpiarDisplay();
            Console.WriteLine("Ahora esta a {0} [km/h]", velocidad + 20);
        }
        public override void Frenar(float velocidad)
        {
            Console.WriteLine("El tractor esta a {0} [km/h]", velocidad);
            LimpiarDisplay();
            Console.WriteLine("Frenando");
            LimpiarDisplay();
            Console.WriteLine("Ahora esta a {0} [km/h]", velocidad - 20);
        }
    }
}
