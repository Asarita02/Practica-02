using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Compras: Inventario, usuariodegestióndeinventario
    {
        private int id_compra;
        private int fecha_compra;
        private int proveedor;
        private int lista_productos;
        private int costo_total;
        private int estado;

        public int Id_compra { get => id_compra; set => id_compra = value; }
        public int Fecha_compra { get => fecha_compra; set => fecha_compra = value; }
        public int Proveedor { get => proveedor; set => proveedor = value; }
        public int Lista_productos { get => lista_productos; set => lista_productos = value; }
        public int Costo_total { get => costo_total; set => costo_total = value; }
        public int Estado { get => estado; set => estado = value; }

        public void agregarCompra()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarCompra()
        {
            throw new System.NotImplementedException();
        }

        public void buscarCompra()
        {
            throw new System.NotImplementedException();
        }

        public void actualizarEstadoCompra()
        {
            throw new System.NotImplementedException();
        }

        public void calcularTotalCompras()
        {
            throw new System.NotImplementedException();
        }
    }
}