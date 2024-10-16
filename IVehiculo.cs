using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_con_Subinterfaces
{
    internal interface IVehiculo
    {
        void Acelerar(int incremento);
        void Frenar(int decremento);
        int ObtenerVelocidad();
    }
}
