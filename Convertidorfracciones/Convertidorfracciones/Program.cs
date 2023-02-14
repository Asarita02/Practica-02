using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Convertidorfracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que convierte fracciones mixtas en fracciones comunes Geomel");

            int numerador, denominador, entero;

            Console.Write("Ingrese la fracción mixta (en el formato 'entero numerador/denominador'): ");
            string fraccionMixta = Console.ReadLine();

            string[] fraccionSplit = fraccionMixta.Split(' ', '/');
            entero = Convert.ToInt32(fraccionSplit[0]);
            numerador = Convert.ToInt32(fraccionSplit[1]);
            denominador = Convert.ToInt32(fraccionSplit[2]);

           
            numerador += entero * denominador;

            Console.WriteLine("La fracción mixta " + fraccionMixta + " en fracción común es: " + numerador + "/" + denominador);

            Console.ReadLine();
        }
    }  
    
}
