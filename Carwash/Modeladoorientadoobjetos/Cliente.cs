using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public class Cliente: Requerimiento, Metodosvarios4, Metodosvarios3
    {
        private int nombre;
        private int cedula;
        private int celular;
        private int vehiculo;
        private int ultimomantenimiento;
        private int telefono;

        public int Nombre { get => nombre; set => nombre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public int Celular { get => celular; set => celular = value; }
        public int Vehiculo { get => vehiculo; set => vehiculo = value; }
        public int Ultimomantenimiento { get => ultimomantenimiento; set => ultimomantenimiento = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}