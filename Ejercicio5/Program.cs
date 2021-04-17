using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de notas a promediar");
            int cantidad = int.Parse(Console.ReadLine());
            int contador = 0;
            double promedio = 0;
            while (contador < cantidad )
            {
                contador++;
                Console.WriteLine("Ingrese una nota");
                double nota = double.Parse(Console.ReadLine());
                int a = 0;
                while (a == 0)
                {
                    if (nota >= 1 && nota <=7)
                        {
                            a = 1;
                        }
                        else
                        {
                            a = 0;
                            Console.WriteLine("Ingrese la nota denuevo");
                            nota = double.Parse(Console.ReadLine());
                        }

                }
                 promedio+= nota;

            }
            promedio /= cantidad;
            Console.WriteLine("El promedio es: "+promedio);
            Console.ReadLine();
        }
    }
}

