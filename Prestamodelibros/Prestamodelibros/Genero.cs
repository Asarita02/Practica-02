using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Generoliterario: Libro, metodosvarios2, metodosvarios4, metodosvarios1
    {
        private int aventura;
        private int erotico;
        private int cienciaficcion;
        private int romance;
        private int paranormal;
        private int fantasia;

        public int Aventura { get => aventura; set => aventura = value; }
        public int Erotico { get => erotico; set => erotico = value; }
        public int Cienciaficcion { get => cienciaficcion; set => cienciaficcion = value; }
        public int Romance { get => romance; set => romance = value; }
        public int Paranormal { get => paranormal; set => paranormal = value; }
        public int Fantasia { get => fantasia; set => fantasia = value; }

        public void elegirgenero()
        {
            throw new System.NotImplementedException();
        }

        public void Metodo1()
        {
            throw new NotImplementedException();
        }

        public void Metodo2()
        {
            throw new NotImplementedException();
        }
    }
}