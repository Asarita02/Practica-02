using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Estudiante: Prestamo
    {
        private int matricula;
        private int nombre;
        private int direccion;
        private int celular;
        private int cedula;
        private int carrera;

        public int Matricula { get => matricula; set => matricula = value; }
        public int Nombre { get => nombre; set => nombre = value; }
        public int Direccion { get => direccion; set => direccion = value; }
        public int Celular { get => celular; set => celular = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public int Carrera { get => carrera; set => carrera = value; }

        public void identificarestudiante()
        {
            throw new System.NotImplementedException();
        }
    }
}