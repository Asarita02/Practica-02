using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modeladoorientadoobjetos
{
    public class Vehiculo:Empresa, Metodosvarios3, Metodosvarios2
    {
        private int marca;
        private int modelo;
        private int serial;
        private int categoria;
        private int year;
        private int color;

        public int Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public int Serial { get => serial; set => serial = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Year { get => year; set => year = value; }
        public int Color { get => color; set => color = value; }
    }
}