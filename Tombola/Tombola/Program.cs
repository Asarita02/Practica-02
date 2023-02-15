using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombola
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            
            Console.WriteLine("Programa que simula una tombola");
            Console.ReadLine();

            Random random = new Random();

            int numero1 = random.Next(100);
            int numero2 = random.Next(100);
            int numero3 = random.Next(100);

            
            Console.WriteLine("Los números generados son:");
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.ReadLine();
        }
    }
}
