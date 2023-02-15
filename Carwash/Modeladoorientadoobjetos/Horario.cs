using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public class Horario: Servicio, Metodosvarios, Metodosvarios2
    {
        private int tanda;
        private int hora;
        private int especificacion;
        private int year;
        private int mes;
        private int dia;

        public int Tanda { get => tanda; set => tanda = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Especificacion { get => especificacion; set => especificacion = value; }
        public int Year { get => year; set => year = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Dia { get => dia; set => dia = value; }
    }
}