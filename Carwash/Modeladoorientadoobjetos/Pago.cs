using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public class Pago:Cliente,Metodosvarios3, Metodosvarios
    {
        private int fecha;
        private int monto;
        private int servicio;
        private int Empresa;
        private int comentario;
        private int itbis;

        public int Fecha { get => fecha; set => fecha = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Servicio { get => servicio; set => servicio = value; }
        public int Empresa1 { get => Empresa; set => Empresa = value; }
        public int Comentario { get => comentario; set => comentario = value; }
        public int Itbis { get => itbis; set => itbis = value; }
    }
}