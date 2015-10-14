using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectura_escritura_archivos
{
    class Alumno
    {
        public string nombre { set; get; }
        public string direccion { set; get; }
        public int edad { set; get; }
        
        public Alumno(string nombre, string direccion, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }

        public Alumno()
        {
            this.nombre = null;
            this.direccion = null;
            this.edad = 0;
        }
    }
}
