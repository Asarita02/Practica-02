using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Logistica: Ventas, usuariodegestióndepromociones
    {
        private int Id;
        private int FechaDeEntrega;
        private int Estado;
        private int MétodoDeEnvío;
        private int CostoDeEnvío;
        private int FechaDePago;

        public int Id1 { get => Id; set => Id = value; }
        public int FechaDeEntrega1 { get => FechaDeEntrega; set => FechaDeEntrega = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int MétodoDeEnvío1 { get => MétodoDeEnvío; set => MétodoDeEnvío = value; }
        public int CostoDeEnvío1 { get => CostoDeEnvío; set => CostoDeEnvío = value; }
        public int FechaDePago1 { get => FechaDePago; set => FechaDePago = value; }

        public void calcular_costos_envío()
        {
            throw new System.NotImplementedException();
        }

        public void verificar_disponibilidad()
        {
            throw new System.NotImplementedException();
        }
    }
}