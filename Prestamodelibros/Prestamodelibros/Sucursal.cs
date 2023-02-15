using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Sucursal:Libro, metodosvarios, metodosvarios1
    {
        private int losprocedes;
        private int losprados;
        private int hisprados;
        private int Arroyohondo;
        private int sdeste;
        private int santiago;

        public int Losprocedes { get => losprocedes; set => losprocedes = value; }
        public int Losprados { get => losprados; set => losprados = value; }
        public int Hisprados { get => hisprados; set => hisprados = value; }
        public int Arroyohondo1 { get => Arroyohondo; set => Arroyohondo = value; }
        public int Sdeste { get => sdeste; set => sdeste = value; }
        public int Santiago { get => santiago; set => santiago = value; }

        public void Buscarsucursal()
        {
            throw new System.NotImplementedException();
        }

        public void metodo1()
        {
            throw new NotImplementedException();
        }

        public void metodo2()
        {
            throw new NotImplementedException();
        }

        public void metodoa()
        {
            throw new NotImplementedException();
        }

        public void metodob()
        {
            throw new NotImplementedException();
        }

        public void metodoI()
        {
            throw new NotImplementedException();
        }

        public void MetodoII()
        {
            throw new NotImplementedException();
        }
    }
}