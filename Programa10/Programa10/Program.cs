using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10]; // Definimos un arreglo de 10 elementos

            // Generamos números aleatorios y los añadimos al arreglo
            Random rand = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(1, 101); // Genera un número aleatorio entre 1 y 100
            }

            // Mostramos el arreglo antes de ser ordenado
            Console.WriteLine("Arreglo antes de ser ordenado:");
            MostrarArreglo(numeros);

            // Ordenamos el arreglo de forma ascendente
            OrdenarArreglo(numeros, true);

            // Mostramos el arreglo ordenado de forma ascendente
            Console.WriteLine("Arreglo ordenado de forma ascendente:");
            MostrarArreglo(numeros);

            // Ordenamos el arreglo de forma descendente
            OrdenarArreglo(numeros, false);

            // Mostramos el arreglo ordenado de forma descendente
            Console.WriteLine("Arreglo ordenado de forma descendente:");
            MostrarArreglo(numeros);
        }

        // Método para mostrar un arreglo en la consola
        static void MostrarArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }

        // Método para ordenar un arreglo utilizando el método de burbuja
        static void OrdenarArreglo(int[] arreglo, bool ascendente)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    bool comparacion;
                    if (ascendente)
                    {
                        comparacion = arreglo[j] > arreglo[j + 1];
                    }
                    else
                    {
                        comparacion = arreglo[j] < arreglo[j + 1];
                    }

                    if (comparacion)
                    {
                        // Intercambiamos los elementos
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
