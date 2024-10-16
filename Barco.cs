using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_con_Subinterfaces
{
    internal class Barco : Vehiculo, IVehiculoAcuatico
    {
        public override void Acelerar(int incremento)
        {
            base.Acelerar(incremento);
            Console.WriteLine($"El barco acelera a {velocidad} km/h.");
        }

        public override void Frenar(int decremento)
        {
            base.Frenar(decremento);
            Console.WriteLine($"El barco frena a {velocidad} km/h.");
        }

        public void Zarpar()
        {
            Console.WriteLine("El barco ha zarpado.");
        }
    }
}
