using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public abstract class Empleados: Sucursal
    {
        private int nombre;
        private int cedula;
        private int posicion;
        private int fechadenacimiento;
        private int id;
        private int direccion;

        public int Nombre { get => nombre; set => nombre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Id { get => id; set => id = value; }
        public int Direccion { get => direccion; set => direccion = value; }
    }
}