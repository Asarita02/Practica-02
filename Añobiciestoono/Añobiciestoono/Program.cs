using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Añobiciestoono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que identifica si un año es biciesto o no"); 
            Console.WriteLine("Ingrese un año: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("El año es bisiesto.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
                Console.ReadLine();
            }
        }
    }
}
