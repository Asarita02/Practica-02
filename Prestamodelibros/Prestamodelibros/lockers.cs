using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public abstract class escaleras: Pasillo
    {
        private int escalerapasillo1;
        private int escalerapasillo2;
        private int escalerapasillo3;
        private int escalerapasillo4;
        private int escalerapasillo5;
        private int escalerapasillo6;

        public int Escalerapasillo1 { get => escalerapasillo1; set => escalerapasillo1 = value; }
        public int Escalerapasillo2 { get => escalerapasillo2; set => escalerapasillo2 = value; }
        public int Escalerapasillo3 { get => escalerapasillo3; set => escalerapasillo3 = value; }
        public int Escalerapasillo4 { get => escalerapasillo4; set => escalerapasillo4 = value; }
        public int Escalerapasillo5 { get => escalerapasillo5; set => escalerapasillo5 = value; }
        public int Escalerapasillo6 { get => escalerapasillo6; set => escalerapasillo6 = value; }
    }
}