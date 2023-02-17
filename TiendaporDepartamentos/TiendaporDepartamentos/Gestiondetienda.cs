using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public abstract class Gestiondetienda
    {

        private int Id_tienda;
        private int nombre_tienda;
        private int Estado;
        private int descripcióno;
        private int horario;
        private int gerente;

        public int Id_tienda1 { get => Id_tienda; set => Id_tienda = value; }
        public int Nombre_tienda { get => nombre_tienda; set => nombre_tienda = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int Descripcióno { get => descripcióno; set => descripcióno = value; }
        public int Horario { get => horario; set => horario = value; }
        public int Gerente { get => gerente; set => gerente = value; }

        public void validarestado()
        {
            throw new System.NotImplementedException();
        }

        public void modificarinfo()
        {
            throw new System.NotImplementedException();
        }
    }
}