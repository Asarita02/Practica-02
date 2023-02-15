using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public abstract class Precio: Servicio, Metodosvarios4, Metodosvarios2
    {
        private int servicio;
        private int monto;
        private int cantidad;
        private int descuentopermitido;
        private int centrodecosto;
        private int costo;

        public int Servicio { get => servicio; set => servicio = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Descuentopermitido { get => descuentopermitido; set => descuentopermitido = value; }
        public int Centrodecosto { get => centrodecosto; set => centrodecosto = value; }
        public int Costo { get => costo; set => costo = value; }
    }
}