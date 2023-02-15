using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Prestamo: Estudiante, metodosvarios2
    {
        private int nombreestudiante;
        private int fecha;
        private int titulolibro;
        private int tiempoprestado;
        private int edicionlibro;
        private int categorialibro;

        public int Nombreestudiante { get => nombreestudiante; set => nombreestudiante = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public int Titulolibro { get => titulolibro; set => titulolibro = value; }
        public int Tiempoprestado { get => tiempoprestado; set => tiempoprestado = value; }
        public int Edicionlibro { get => edicionlibro; set => edicionlibro = value; }
        public int Categorialibro { get => categorialibro; set => categorialibro = value; }

        public void contabilizarprestamo()
        {
            throw new System.NotImplementedException();
        }

        public void metodoA()
        {
            throw new NotImplementedException();
        }

        public void metodoB()
        {
            throw new NotImplementedException();
        }
    }
}