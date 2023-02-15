using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prestamodelibros
{
    public class Libro : Pasillo, metodosvarios1
    {
        private int titulo;
        private int fechadepublicacion;
        private int autor;
        private int editorial;
        private int edicion;
        private int idioma;

        public int Titulo { get => titulo; set => titulo = value; }
        public int Fechadepublicacion { get => fechadepublicacion; set => fechadepublicacion = value; }
        public int Autor { get => autor; set => autor = value; }
        public int Editorial { get => editorial; set => editorial = value; }
        public int Edicion { get => edicion; set => edicion = value; }
        public int Idioma { get => idioma; set => idioma = value; }

        public void Buscarlibro()
        {
            throw new System.NotImplementedException();
        }

        public void metodoa()
        {
            throw new NotImplementedException();
        }

        public void metodob()
        {
            throw new NotImplementedException();
        }
    }
}