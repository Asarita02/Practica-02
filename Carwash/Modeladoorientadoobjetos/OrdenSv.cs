using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public class OrdenSv: Empresa, Metodosvarios, Usabilidad
    {
        private int empresa;
        private int servicio;
        private int fecha;
        private int Noorden;
        private int comentario;
        private int acuerdopago;

        public int Empresa { get => empresa; set => empresa = value; }
        public int Servicio { get => servicio; set => servicio = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public int Noorden1 { get => Noorden; set => Noorden = value; }
        public int Comentario { get => comentario; set => comentario = value; }
        public int Acuerdopago { get => acuerdopago; set => acuerdopago = value; }
    }
}