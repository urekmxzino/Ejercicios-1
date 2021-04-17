using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 7");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Miercoles");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
                    
        }
    }
}
