using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una distancia a recorrer en km");
            double distancia = double.Parse(Console.ReadLine());
            double velocidad = distancia / 6;
            if (velocidad >100)
            {
                Console.WriteLine("El vehiculo se desplazara a gran velocidad");
            }
            else
            {
                Console.WriteLine("El vehiculo se desplazara a velocidad moderada");
            }
            Console.WriteLine("El vehiculo ira a " + velocidad + "km/h");
            Console.ReadLine();
        }
    }
}
