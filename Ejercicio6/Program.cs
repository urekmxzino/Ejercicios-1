using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            for (int contador = 0; contador < numero;contador++)
            {
                if ((contador % 2) != 0)
                {
                    Console.WriteLine(contador);
                }

            }
            Console.ReadLine();
            

        }
    }
}
