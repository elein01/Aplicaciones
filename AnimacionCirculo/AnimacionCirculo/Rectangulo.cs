using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimacionCirculo
{
    class Rectangulo
    {
        public Point p1 { set; get; }
        public Point p2 { set; get; }

        public Rectangulo(Point punto1, Point punto2)
        {
            p1 = punto1;
            p2 = punto2;
        }
        public int ancho()
        {
            return Math.Abs(p2.X - p1.X);
        }
        public int alto()
        {
            return Math.Abs(p1.Y - p2.Y);
        }
        public int area()
        {
            return ancho() * alto();
        }
    }
}