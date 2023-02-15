using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Autor: Libro, metodosvarios4, metodosvarios
    {
        private int nombre;
        private int fechadenacimiento;
        private int nacionalidad;
        private int generos;
        private int seudononimo;
        private int obrasnotables;

        public int Nombre { get => nombre; set => nombre = value; }
        public int Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Generos { get => generos; set => generos = value; }
        public int Seudononimo { get => seudononimo; set => seudononimo = value; }
        public int Obrasnotables { get => obrasnotables; set => obrasnotables = value; }

        public void buscarautor()
        {
            throw new System.NotImplementedException();
        }

        public void Metodo1()
        {
            throw new NotImplementedException();
        }

        public void metodo1()
        {
            throw new NotImplementedException();
        }

        public void Metodo2()
        {
            throw new NotImplementedException();
        }

        public void metodo2()
        {
            throw new NotImplementedException();
        }
    }
}