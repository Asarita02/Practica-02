using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Prestamodelibros
{
    public class Tramo : Pasillo, metodosvarios
    {
        private int tramoa;
        private int tramob;
        private int tramoc;
        private int tramod;
        private int tramoe;
        private int tramof;

        public int Tramoa { get => tramoa; set => tramoa = value; }
        public int Tramob { get => tramob; set => tramob = value; }
        public int Tramoc { get => tramoc; set => tramoc = value; }
        public int Tramod { get => tramod; set => tramod = value; }
        public int Tramoe { get => tramoe; set => tramoe = value; }
        public int Tramof { get => tramof; set => tramof = value; }

        public void identificartramo()
        {
            throw new System.NotImplementedException();
        }

        public void metodo1()
        {
            throw new NotImplementedException();
        }

        public void metodo2()
        {
            throw new NotImplementedException();
        }
    }
}