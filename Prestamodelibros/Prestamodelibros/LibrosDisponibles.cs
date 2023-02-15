using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class LibrosDisponibles: Prestamo, metodosvarios
    {
        private int titulolibro;
        private int nombreautor;
        private int edicionlibro;
        private int cantidaddisponible;
        private int cantidadprestada;
        private int cantdisponiblerequerida;

        public int Titulolibro { get => titulolibro; set => titulolibro = value; }
        public int Nombreautor { get => nombreautor; set => nombreautor = value; }
        public int Edicionlibro { get => edicionlibro; set => edicionlibro = value; }
        public int Cantidaddisponible { get => cantidaddisponible; set => cantidaddisponible = value; }
        public int Cantidadprestada { get => cantidadprestada; set => cantidadprestada = value; }
        public int Cantdisponiblerequerida { get => cantdisponiblerequerida; set => cantdisponiblerequerida = value; }

        public void buscardisponibilidad()
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