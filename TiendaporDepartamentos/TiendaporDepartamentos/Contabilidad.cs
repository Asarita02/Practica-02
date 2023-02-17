using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Contabilidad:Ventas, usuariodeanálisisdedatos
    {
        private int ingresos;
        private int gastos;
        private int impuestos;
        private int cuentas_por_cobrar;
        private int cuentas_por_pagar;
        private int Beneficios;

        public int Ingresos { get => ingresos; set => ingresos = value; }
        public int Gastos { get => gastos; set => gastos = value; }
        public int Impuestos { get => impuestos; set => impuestos = value; }
        public int Cuentas_por_cobrar { get => cuentas_por_cobrar; set => cuentas_por_cobrar = value; }
        public int Cuentas_por_pagar { get => cuentas_por_pagar; set => cuentas_por_pagar = value; }
        public int Beneficios1 { get => Beneficios; set => Beneficios = value; }

        public void Registargastos()
        {
            throw new System.NotImplementedException();
        }

        public void registarcostos()
        {
            throw new System.NotImplementedException();
        }

        public void generarreporte()
        {
            throw new System.NotImplementedException();
        }

        public void registarventas()
        {
            throw new System.NotImplementedException();
        }
    }
}