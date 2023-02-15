using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadorasemanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula la cantidad de semanas entre dos fechas introducidas");
            Console.ReadLine();

            
            Console.WriteLine("Ingrese la primera fecha en formato dd/mm/aaaa:");
            string fechaInicioStr = Console.ReadLine();


            DateTime fechaInicio = DateTime.ParseExact(fechaInicioStr, "dd/MM/yyyy", null);

            Console.WriteLine("Ingrese la segunda fecha en formato dd/mm/aaaa:");
            string fechaFinStr = Console.ReadLine();


            DateTime fechaFin = DateTime.ParseExact(fechaFinStr, "dd/MM/yyyy", null);

            TimeSpan tiempoTranscurrido = fechaFin - fechaInicio;
            int semanasTranscurridas = (int)(tiempoTranscurrido.TotalDays / 7);

            Console.WriteLine("Entre las fechas {0} y {1} han transcurrido {2} semanas.", fechaInicio.ToShortDateString(), fechaFin.ToShortDateString(), semanasTranscurridas);
            Console.ReadLine();
        }
    }
}
