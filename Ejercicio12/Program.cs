using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 7");
            int numero = int.Parse(Console.ReadLine());
            int a = 0;
            while (a == 0)
            {
                if (numero >= 1 && numero <= 7)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                        Console.WriteLine("Ingrese denuevo el numero");
                        numero = int.Parse(Console.ReadLine());
                    }

            }
            Console.ReadLine();
        }
    }
}
