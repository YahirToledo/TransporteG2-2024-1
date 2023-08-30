using System;
using System.Collections.Generic;
using System.Linq;
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
                if (0 < value && value < 150)
                {
                    velocidad = value;
                }
                else
                {
                    velocidad = 60
                }
            } 
        }

        #endregion
        public Tractor()
        {
            SeñalarAñoProduccion();
            Console.WriteLine("Tractor");
            LimpiarDisplay();
            
        }
        public override void Tractor(string accion)
        {

        }
    }
}
