using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMCDYMCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Programa que calcula el MCD y el MCM de dos numeros Geomel");
            Console.WriteLine("Ingrese el primer numero");

            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int mcd = 1;
            int mcm = num1 * num2;

            for (int i = 2; i <= Math.Min(num1, num2); i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    mcd = i;
                }
            }

            mcm /= mcd;

            Console.WriteLine("El MCD de " + num1 + " y " + num2 + " es: " + mcd);
            Console.WriteLine("El MCM de " + num1 + " y " + num2 + " es: " + mcm);

            Console.ReadLine();
        }
    }
}
