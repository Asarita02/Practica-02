using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public abstract class Mantenimientos : Empresa,Metodosvarios, Metodosvarios2
    {
        private int ultimomantenimiento;
        private int cliente;
        private int vehiculo;
        private int ultimoserv;
        private int comentario;
        private int empleado;

        public int Ultimomantenimiento { get => ultimomantenimiento; set => ultimomantenimiento = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Vehiculo { get => vehiculo; set => vehiculo = value; }
        public int Ultimoserv { get => ultimoserv; set => ultimoserv = value; }
        public int Comentario { get => comentario; set => comentario = value; }
        public int Empleado { get => empleado; set => empleado = value; }
    }
}