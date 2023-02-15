using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Librosrequeridos: Libro, metodosvarios4
    {
        private int titulolibro;
        private int nombreautor;
        private int edicionlibro;
        private int cantidadrequerida;
        private int fechadeentrega;
        private int sucursal;

        public int Titulolibro { get => titulolibro; set => titulolibro = value; }
        public int Nombreautor { get => nombreautor; set => nombreautor = value; }
        public int Edicionlibro { get => edicionlibro; set => edicionlibro = value; }
        public int Cantidadrequerida { get => cantidadrequerida; set => cantidadrequerida = value; }
        public int Fechadeentrega { get => fechadeentrega; set => fechadeentrega = value; }
        public int Sucursal { get => sucursal; set => sucursal = value; }

        public void Metodo1()
        {
            throw new NotImplementedException();
        }

        public void Metodo2()
        {
            throw new NotImplementedException();
        }

        public void obtenerrequerimiento()
        {
            throw new System.NotImplementedException();
        }
    }
}