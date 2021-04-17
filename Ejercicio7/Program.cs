using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            double num2 = double.Parse(Console.ReadLine());
            double menor = 0;
            double mayor = 0;
            if (num1 < num2)
            {
                menor = num1;
                mayor = num2;

            }
            else if (num1 > num2)
            {
                menor = num2;
                mayor = num1;
            }
            else if (num1 == num2)
            {
                menor = num1;
                mayor = num1;
            }
            for( menor = menor; menor <= mayor; menor++) 
{
                Console.WriteLine(menor);
            }
            Console.ReadLine();
        }
        
    }
}
