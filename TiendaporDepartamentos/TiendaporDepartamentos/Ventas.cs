using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Ventas: Clientes, usuariodeventas
    {
        private int id_venta;
        private int fecha_venta;
        private int lista_productos;
        private int total_venta;
        private int forma_pago;
        private int estado;

        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
        public int Lista_productos { get => lista_productos; set => lista_productos = value; }
        public int Total_venta { get => total_venta; set => total_venta = value; }
        public int Forma_pago { get => forma_pago; set => forma_pago = value; }
        public int Estado { get => estado; set => estado = value; }

        public void registrar_venta()
        {
            throw new System.NotImplementedException();
        }

        public void anular_venta()
        {
            throw new System.NotImplementedException();
        }

        public void obtener_venta()
        {
            throw new System.NotImplementedException();
        }

        public void buscar_venta()
        {
            throw new System.NotImplementedException();
        }

        public void generar_reporte_ventas()
        {
            throw new System.NotImplementedException();
        }

        public void calcular_impuestos()
        {
            throw new System.NotImplementedException();
        }
    }
}