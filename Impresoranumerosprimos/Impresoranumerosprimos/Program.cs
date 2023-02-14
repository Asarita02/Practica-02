using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresoranumerosprimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 2; // Número inicial
            int fin = 20; // Número final

            Console.WriteLine("Programa que imprime una lista de numeros primos Geomel");

            for (int i = inicio; i <= fin; i++)
            {
                bool esPrimo = true;

                for (int M = 2; M < i; M++)
                {
                    if (i % M == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
