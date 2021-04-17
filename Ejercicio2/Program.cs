using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero");
            double numero = double.Parse(Console.ReadLine());
            if ((numero%2)==0)
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es Impar");
                }
            Console.ReadLine();
        }
    }
}
