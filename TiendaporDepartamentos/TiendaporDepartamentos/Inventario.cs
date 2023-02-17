using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Inventario:Ventas, usuariodegestióndeinventario
    {
        private int id_producto;
        private int nombre_producto;
        private int descripcion;
        private int precio;
        private int cantidad;
        private int directorio;
        private int categoria;

        public int Productos { get => id_producto; set => id_producto = value; }
        public int Nivelesdestock { get => nombre_producto; set => nombre_producto = value; }
        public int Descripcion { get => descripcion; set => descripcion = value; }
        public int Preciosdeventa { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Informesdeinventario { get => directorio; set => directorio = value; }
        public int Categoria { get => categoria; set => categoria = value; }

        public void agregar_producto()
        {
            throw new System.NotImplementedException();
        }

        public void eliminar_producto()
        {
            throw new System.NotImplementedException();
        }

        public void actualizar_producto()
        {
            throw new System.NotImplementedException();
        }

        public void actualizar_niveles_stock()
        {
            throw new System.NotImplementedException();
        }
    }
}