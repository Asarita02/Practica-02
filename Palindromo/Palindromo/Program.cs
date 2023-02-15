using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cadena de texto: ");
            string texto = Console.ReadLine();
            string textoInvertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }

            bool esPalindromo = true;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != textoInvertido[i])
                {
                    esPalindromo = false;
                    break;
                }
            }

            
            if (esPalindromo)
            {
                Console.WriteLine("La cadena es un palíndromo");
            }
            else
            {
                Console.WriteLine("La cadena no es un palíndromo");
                Console.ReadLine();
            }
        }
    }
}
