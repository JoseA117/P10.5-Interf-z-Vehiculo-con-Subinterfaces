using System;

namespace Vehiculo_con_Subinterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehiculo> vehiculos = new List<IVehiculo>
       {
           new Automovil(),
           new Bicicleta(),
           new Avion(),
           new Helicoptero(),
           new Barco(),
           new Velero()
       };

            List<string> nombresVehiculos = new List<string>
       {
           "Automóvil",
           "Bicicleta",
           "Avión",
           "Helicóptero",
           "Barco",
           "Velero"
       };

            Dictionary<int, Action<IVehiculo>> acciones = new Dictionary<int, Action<IVehiculo>>
       {
           { 1, AcelerarVehicuLo },
           { 2, FrenarVehicuLo },
           { 3, ObtenerVelocidadVehicuLo },
           { 4, CambiarMarchaVehicuLo },
           { 5, DespegarVehicuLo },
           { 6, ZarparVehicuLo }
       };

            while (true)
            {
                Console.WriteLine("Seleccione un vehículo (0 para salir):");
                for (int i = 0; i < vehiculos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombresVehiculos[i]}");
                }

                int vehiculoSeleccionado = int.Parse(Console.ReadLine()) - 1;

                if (vehiculoSeleccionado < 0) break; 

                if (vehiculoSeleccionado >= vehiculos.Count)
                {
                    Console.WriteLine("Selección no válida.");
                    continue;
                }

                IVehiculo vehiculo = vehiculos[vehiculoSeleccionado];

                Console.WriteLine("Seleccione una acción:");
                Console.WriteLine("1. Acelerar");
                Console.WriteLine("2. Frenar");
                Console.WriteLine("3. Obtener Velocidad");

                if (vehiculo is IVehiculoTerreste) 
                    Console.WriteLine("4. Cambiar Marcha");

                if (vehiculo is IVehiculoAereo) 
                    Console.WriteLine("5. Despegar");

                if (vehiculo is IVehiculoAcuatico) 
                    Console.WriteLine("6. Zarpar");

                int accionSeleccionada = int.Parse(Console.ReadLine());

                if (acciones.ContainsKey(accionSeleccionada))
                {
                    acciones[accionSeleccionada](vehiculo); 

                    if (accionSeleccionada == 4 && vehiculo is IVehiculoTerreste terrestre) 
                    {
                        Console.Write("Ingrese la marcha: ");
                        int marcha = int.Parse(Console.ReadLine());
                        terrestre.CambiarMarcha(marcha);
                    }
                    else if (accionSeleccionada == 5 && vehiculo is IVehiculoAereo aereo) 
                    {
                        aereo.Despegar();
                    }
                    else if (accionSeleccionada == 6 && vehiculo is IVehiculoAcuatico acuatico) 
                    {
                        acuatico.Zarpar();
                    }
                }
                else
                {
                    Console.WriteLine("Acción no válida.");
                }
            }
        }

        static void AcelerarVehicuLo(IVehiculo vehicuLo)
        {
            Console.Write("Ingrese el incremento de velocidad: ");
            int incremento = int.Parse(Console.ReadLine());
            vehicuLo.Acelerar(incremento);
        }

        static void FrenarVehicuLo(IVehiculo vehicuLo)
        {
            Console.Write("Ingrese el decremento de velocidad: ");
            int decremento = int.Parse(Console.ReadLine());
            vehicuLo.Frenar(decremento);
        }

        static void ObtenerVelocidadVehicuLo(IVehiculo vehicuLo)
        {
            Console.WriteLine($"La velocidad actual es: {vehicuLo.ObtenerVelocidad()} km/h");
        }

        static void CambiarMarchaVehicuLo(IVehiculo vehicuLo)
        {
            if (vehicuLo is IVehiculoTerreste terrestre)
            {
                Console.Write("Ingrese la marcha: ");
                int marcha = int.Parse(Console.ReadLine());
                terrestre.CambiarMarcha(marcha);
            }
        }

        static void DespegarVehicuLo(IVehiculo vehicuLo)
        {
            if (vehicuLo is IVehiculoAereo aereo)
            {
                aereo.Despegar();
            }
        }

        static void ZarparVehicuLo(IVehiculo vehicuLo)
        {
            if (vehicuLo is IVehiculoAcuatico acuatico)
            {
                acuatico.Zarpar();
            }
        }
    }
}
