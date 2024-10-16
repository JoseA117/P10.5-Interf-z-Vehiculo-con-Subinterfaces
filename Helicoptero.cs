using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_con_Subinterfaces
{
    internal class Helicoptero : Vehiculo, IVehiculoAereo
    {
        public override void Acelerar(int incremento)
        {
            base.Acelerar(incremento);
            Console.WriteLine($"El helicóptero acelera a {velocidad} km/h.");
        }

        public override void Frenar(int decremento)
        {
            base.Frenar(decremento);
            Console.WriteLine($"El helicóptero frena a {velocidad} km/h.");
        }

        public void Despegar()
        {
            Console.WriteLine("El helicóptero ha despegado.");
        }
    }
}
