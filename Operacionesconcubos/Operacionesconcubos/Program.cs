using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacionesconcubos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al programa Geomel que calcula la suma o diferencia de cubos"); 

            Console.WriteLine("Ingrese el valor del primer cubo:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo cubo:");
            int b = int.Parse(Console.ReadLine());

            int resultado = 0;

            if (a > b)
            {
                resultado = (a + b) * (a - b) * (a * a + b * b + a * b);
            }
            else if (b > a)
            {
                resultado = (a + b) * (b - a) * (a * a + b * b - a * b);
            }
            else
            {
                Console.WriteLine("a y b son iguales, no se puede resolver");
                return;
            }

            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();

        }
    }
}
