using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaporDepartamentos
{
    public class Seguridad:Empleados, usuariodeanálisisdedatos
    {
        private int usuario;
        private int contraseña;
        private int nivel_acceso;
        private int política_contraseña;
        private int registro_actividad;
        private int sistemas_seguridad;

        public int Usuario { get => usuario; set => usuario = value; }
        public int Contraseña { get => contraseña; set => contraseña = value; }
        public int Nivel_acceso { get => nivel_acceso; set => nivel_acceso = value; }
        public int Política_contraseña { get => política_contraseña; set => política_contraseña = value; }
        public int Registro_actividad { get => registro_actividad; set => registro_actividad = value; }
        public int Sistemas_seguridad { get => sistemas_seguridad; set => sistemas_seguridad = value; }

        public void accederasistemadeseguridad()
        {
            throw new System.NotImplementedException();
        }
    }
}