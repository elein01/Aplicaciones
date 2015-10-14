using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica9
{
    class Cliente : ITarjetadelealtad, IComparable
    {
        private string nombre;
        private int puntos;
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Agregarpuntos(int puntos)
        {
            this.puntos += puntos;
            return Puntos;
        }
        public void Resetearpuntos()
        {
            puntos = 0;
        }
        public int Puntos
        {
            get {
                if (puntos >= 0)
                    return puntos;
                else 
                return 0;
                }
        }
        public override string  ToString()
        {
 	         return String.Format("Cliente: {0} - Puntos Acumulados:{1}",this.Nombre,this.Puntos);
        }
        public Cliente(string nombre)
        {
            Nombre = nombre;
            puntos = 0;
        }


        public int CompareTo(object obj)
        {
            Cliente ottro = (Cliente)obj;
            return String.Compare(this.Nombre, ottro.Nombre);
        }
    }
}
