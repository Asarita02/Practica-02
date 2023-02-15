using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Pasillo:Tramo, metodosvarios2
    {
        private int pasillo1;
        private int pasillo2;
        private int pasillo3;
        private int pasillo4;
        private int pasillo5;
        private int pasillo6;

        public int Pasillo1 { get => pasillo1; set => pasillo1 = value; }
        public int Pasillo2 { get => pasillo2; set => pasillo2 = value; }
        public int Pasillo3 { get => pasillo3; set => pasillo3 = value; }
        public int Pasillo4 { get => pasillo4; set => pasillo4 = value; }
        public int Pasillo5 { get => pasillo5; set => pasillo5 = value; }
        public int Pasillo6 { get => pasillo6; set => pasillo6 = value; }

        public void Identificarpasillo()
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