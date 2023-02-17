using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Pedido:Clientes, usuariodeservicioalcliente
    {
        private int cliente;
        private int productos;
        private int fecha_pedido;
        private int estado_pedido;
        private int dirección_envío;
        private int transportista;

        public int Cliente { get => cliente; set => cliente = value; }
        public int Productos { get => productos; set => productos = value; }
        public int Fecha_pedido { get => fecha_pedido; set => fecha_pedido = value; }
        public int Estado_pedido { get => estado_pedido; set => estado_pedido = value; }
        public int Dirección_envío { get => dirección_envío; set => dirección_envío = value; }
        public int Transportista { get => transportista; set => transportista = value; }

        public void Registarpedido()
        {
            throw new System.NotImplementedException();
        }

        public void modificarpedido()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarpedido()
        {
            throw new System.NotImplementedException();
        }
    }
}