using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Pagos: Ventas, usuariodeservicioalcliente
    {
        private int cliente;
        private int código_seguridad;
        private int monto;
        private int fecha_pago;
        private int tipo_pago;
        private int siestado_pago;

        public int Cliente { get => cliente; set => cliente = value; }
        public int Código_seguridad { get => código_seguridad; set => código_seguridad = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public int Tipo_pago { get => tipo_pago; set => tipo_pago = value; }
        public int Siestado_pago { get => siestado_pago; set => siestado_pago = value; }

        public void Registrarpago()
        {
            throw new System.NotImplementedException();
        }

        public void Anularpago()
        {
            throw new System.NotImplementedException();
        }
    }
}