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
        public string accion;

        public virtual float Velocidad 
        { 
            get => velocidad;
            set
            {
                if (0 < value && value < 200)
                    velocidad = value;
                else
                    velocidad = 70;
            }
        }
        #endregion

        #region Metodos
        public void LimpiarDisplay()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void SeñalarAñoProduccion()
        {
            añoProduccion = 2023;
            Velocidad = 80;
            Console.WriteLine("Año de produccion: {0}", añoProduccion);
            LimpiarDisplay();
        }
        public virtual void Acelerar(float velocidad)
        {
            Console.WriteLine("El auto esta a {0} [km/h]", velocidad);
            LimpiarDisplay();
            Console.WriteLine("Acelerando");
            LimpiarDisplay();
            Console.WriteLine("Ahora esta a {0} [km/h]", velocidad + 20);
        }
        public virtual void Frenar(float velocidad)
        {
            Console.WriteLine("El auto esta a {0} [km/h]", velocidad);
            LimpiarDisplay();
            Console.WriteLine("Frenando");
            LimpiarDisplay();
            Console.WriteLine("Ahora esta a {0} [km/h]", velocidad - 20);
        }
        #endregion
    }
}
