using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una distancia a recorrer");
            double distancia = double.Parse(Console.ReadLine());
            double velocidad = distancia / 6;
            Console.WriteLine("El vehiculo ira a " + velocidad+"km/h");
            Console.ReadLine();
        }
    }
}
