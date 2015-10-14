using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasANDPilas
{
    class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return String.Format("Nombre: {0}", Nombre);
        }
    }
}
