using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_con_Subinterfaces
{
    internal class Bicicleta : Vehiculo, IVehiculoTerreste
    {
        public override void Acelerar(int incremento)
        {
            base.Acelerar(incremento);
            Console.WriteLine($"La bicicleta acelera a {velocidad} km/h.");
        }

        public override void Frenar(int decremento)
        {
            base.Frenar(decremento);
            Console.WriteLine($"La bicicleta frena a {velocidad} km/h.");
        }

        public void CambiarMarcha(int marcha)
        {
            Console.WriteLine($"La bicicleta cambia a marcha {marcha}.");
        }
    }
}
