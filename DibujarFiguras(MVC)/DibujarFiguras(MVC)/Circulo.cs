using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DibujarFiguras_MVC_
{
    class Circulo
    {
        public int radio { set; get; }
        public Point centro { set; get; }

        public Circulo(int rad, Point cen) // constructor
        {
            this.radio = rad;
            this.centro = cen;
        }
        public double area() // Metodo para calcular el area del circulo 
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
