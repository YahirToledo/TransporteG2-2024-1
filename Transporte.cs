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
        internal float velocidad;

        public virtual float Velocidad 
        { 
            get => velocidad;
            set
            {
                if (0 < value && value < 300 )
                {
                    velocidad = value;
                }
                else
                {
                    velocidad = 80;
                }
            }
        }
        #endregion

        #region Metodo
        public void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void SeñalarAñoProduccion()
        {
            añoProduccion = 2023;
            Console.WriteLine("Año de produccion: {0}", añoProduccion);
        }
        public void Acelerar()
        {
            Console.WriteLine("Estas a {0} [km/h]", velocidad);
            LimpiarDisplay();
            Console.WriteLine("Acelerando");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Ahora estas a {0} [km/h]", velocidad + 20);
        }
        public void Frenar()
        {
            Console.WriteLine("Estas a {0} [km/h]", velocidad);
            LimpiarDisplay();
            Console.WriteLine("Frenando");
            LimpiarDisplay();
            Console.WriteLine("Ahora estas a {0} [km/h]", velocidad - 20);
        }
        #endregion
    }
}
