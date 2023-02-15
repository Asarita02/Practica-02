using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public class Empleados: Cliente, Metodosvarios4, Metodosvarios
    {
        private int nombre;
        private int id;
        private int sueldo;
        private int horariolaboral;
        private int cedula;
        private int extension;
        public int Nombre
        {
            get => default;
            set
            {
            }
        }

        public int ID
        {
            get => default;
            set
            {
            }
        }

        public int Cedula
        {
            get => default;
            set
            {
            }
        }

        public int Extension
        {
            get => default;
            set
            {
            }
        }

        public int Sueldo
        {
            get => default;
            set
            {
            }
        }

        public int HorarioLaboral
        {
            get => default;
            set
            {
            }
        }
    }
}