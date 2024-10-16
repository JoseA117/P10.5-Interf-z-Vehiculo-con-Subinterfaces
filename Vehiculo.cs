using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_con_Subinterfaces
{
    internal abstract class Vehiculo : IVehiculo
    {
        protected int velocidad;

        public virtual void Acelerar(int incremento)
        {
            velocidad += incremento;
        }

        public virtual void Frenar(int decremento)
        {
            velocidad -= decremento;
            if (velocidad < 0) velocidad = 0;
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }
    }
}
