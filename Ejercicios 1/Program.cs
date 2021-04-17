using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu nota");
            double nota = double.Parse(Console.ReadLine());
            if (nota >=1)
                if (nota <=7)
                {
                    Console.WriteLine("Dentro de rango");
                }
            else
                {
                    Console.WriteLine("Fuera de rango");
                }    
            Console.ReadLine();
        }
    }
}
