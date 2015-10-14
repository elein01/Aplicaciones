using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica9.Modelo
{
    class Producto 
    {
        public enum Productos{ Tortas, Empanadas, Quesadillas, Tostadas, Tacos, Licuados};
        private Productos Nomb;
        private double Prec;

        public Producto(Productos nombre, double precio)
        {
            Nomb = nombre;
            Prec = precio;
        }
        public Productos Nombre
        {
            get { return Nomb; }
            set { Nomb = value; }
        }
        public double Precio
        {
            get { return Prec; }
            set
            {
                if (value > 0)
                    Precio = value;
                else
                    Precio = 0;
            }
        }
        public override string ToString()
        {
            return String.Format("{0} - ${1}", Nombre, Precio); 
        }



      
    }
}
