using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Clientes:Pagos, usuariodeservicioalcliente
    {
        private int id_cliente;
        private int nombre;
        private int correo_electrónico;
        private int teléfono;
        private int dirección;
        private int historial_compras;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Nombre { get => nombre; set => nombre = value; }
        public int Correo_electrónico { get => correo_electrónico; set => correo_electrónico = value; }
        public int Teléfono { get => teléfono; set => teléfono = value; }
        public int Dirección { get => dirección; set => dirección = value; }
        public int Historial_compras { get => historial_compras; set => historial_compras = value; }

        public void agregar_cliente()
        {
            throw new System.NotImplementedException();
        }

        public void eliminar_cliente()
        {
            throw new System.NotImplementedException();
        }

        public void modificar_cliente()
        {
            throw new System.NotImplementedException();
        }
    }
}