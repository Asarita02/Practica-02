using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public abstract class Gestiondeprocesos:Gestiondetienda

    {        private int Id_proceso;
        private int nombre_proceso;
        private int Estado;
        private int descripción;
        private int observaciones;
        private int Responsabilidades;

        public int Id_proceso1 { get => Id_proceso; set => Id_proceso = value; }
        public int Nombre_proceso { get => nombre_proceso; set => nombre_proceso = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int Descripción { get => descripción; set => descripción = value; }
        public int Observaciones { get => observaciones; set => observaciones = value; }
        public int Responsabilidades1 { get => Responsabilidades; set => Responsabilidades = value; }

        public void modificarproceso()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarproceso()
        {
            throw new System.NotImplementedException();
        }
    }
}
