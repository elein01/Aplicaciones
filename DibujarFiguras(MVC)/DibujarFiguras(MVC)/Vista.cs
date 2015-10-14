using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DibujarFiguras_MVC_
{
    class Vista
    {
        private Graphics g;
        private Color colorLapiz, colorFondo;
        private int ancho, alto;
        private Pen lapiz;

        public Vista(Panel areaDibujo, Color cl, Color cf)
        {
            g = areaDibujo.CreateGraphics();
            colorLapiz = cl;
            colorFondo = cf;
            ancho = areaDibujo.Width;
            alto = areaDibujo.Height;
        }

        public void mostrarRec(Rectangulo r)
        {
            lapiz = new Pen(colorLapiz);
            lapiz.Width = 3;
            g.DrawRectangle(lapiz, r.p1.X, r.p1.Y, r.ancho(), r.alto());
        }
        public void mostrarCirc(Circulo c)
        {
            lapiz = new Pen(colorLapiz);
            lapiz.Width = 3;
            g.DrawEllipse(lapiz, c.centro.X, c.centro.Y, c.radio, c.radio);
        }
        public void Borrar()
        {
            SolidBrush fondo = new SolidBrush(Color.LightPink);
            Rectangle rec = new Rectangle(0, 0, ancho, alto);
            g.FillRectangle(fondo, rec);
        }
    }
}
