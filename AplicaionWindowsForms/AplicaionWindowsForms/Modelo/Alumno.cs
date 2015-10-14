using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaionWindowsForms
{
    class Alumno
    {
        public string Nombre { set; get; }
        public string Direccion { get; set; }
        public int Edad { get; set; }

        public Alumno(string nombre, string direccion, int edad)
        {
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
        }


    }
}
