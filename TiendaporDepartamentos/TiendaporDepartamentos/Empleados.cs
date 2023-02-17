using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Empleados:Clientes, usuariodeservicioalcliente
    {
        private int nombre;
        private int puesto;
        private int salario;
        private int fecha_de_contratación;
        private int id_empleado;
        private int dirección;
        private int número_de_teléfono;

        public int Nombre1 { get => nombre; set => nombre = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public int Salario { get => salario; set => salario = value; }
        public int Fecha_de_contratación { get => fecha_de_contratación; set => fecha_de_contratación = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Dirección1 { get => dirección; set => dirección = value; }
        public int Número_de_teléfono { get => número_de_teléfono; set => número_de_teléfono = value; }

        public void Crearempleado()
        {
            throw new System.NotImplementedException();
        }

        public void Eliminarempleado()
        {
            throw new System.NotImplementedException();
        }

        public void modificarempleado()
        {
            throw new System.NotImplementedException();
        }
    }
}