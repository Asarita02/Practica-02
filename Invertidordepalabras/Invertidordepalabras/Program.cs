using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertidordepalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa que que invierte el sentido de las palabras Geomel");
            Console.ReadLine();


            Console.Write("Ingrese una palabra que desee invertir su sentido: ");
            string palabra = Console.ReadLine();

            
            string invertida = "";
            for (int p = palabra.Length - 1; p>= 0; p--)
            {
                invertida += palabra[p];
            }

            Console.WriteLine("Palabra invertida: " + invertida);
            Console.ReadLine();
        }
    }
}
