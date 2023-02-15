using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public abstract class cita: Empresa, Usabilidad, Metodosvarios
    {
        private int fecha;
        private int hora;
        private int dia;
        private int empleado;
        private int servicioreq;
        private int comentario;

        public int Fecha { get => fecha; set => fecha = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Empleado { get => empleado; set => empleado = value; }
        public int Servicioreq { get => servicioreq; set => servicioreq = value; }
        public int Comentario { get => comentario; set => comentario = value; }
    }
}