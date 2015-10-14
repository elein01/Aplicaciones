using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimacionCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AnimarCirculo(Circulo circulo, Vista vista)
        {
            vista.colorLapiz = Color.DarkRed;
            vista.mostrarCirc(circulo);
            bool sentido = true;
            while (true)
            {
                while (chkAnimacion.Checked)
                {
                    
                    vista.colorLapiz = Color.Purple;
                    vista.mostrarCirc(circulo);
                    if (sentido)
                    {
                        if (circulo.centro.X <= panel1.Width - 2 * circulo.radio)
                            circulo.centro = new Point(circulo.centro.X + circulo.radio, circulo.centro.Y);
                        else
                            sentido = false;
                    }
                    else
                    {
                        if (circulo.centro.X > circulo.radio)
                            circulo.centro = new Point(circulo.centro.X - circulo.radio, circulo.centro.Y);
                        else
                            sentido = true;
                    }
                    vista.colorLapiz = Color.Purple;
                    vista.mostrarCirc(circulo);
                }
            }
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            if (chkAnimacion.Checked)
            {
                Random aleatorio = new Random();
                int r = aleatorio.Next(15, 50);
                int x, y;
                x = aleatorio.Next(0, panel1.Width - r);
                y = aleatorio.Next(0, panel1.Height - r);
                Point punto = new Point(x, y);
                Circulo circulo = new Circulo(r, punto);
                Task tarea = new Task( () => AnimarCirculo(circulo, new Vista(panel1)));
                tarea.Start();
            }
        }

        private void chkAnimacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnimacion.Checked)
            {
                Rectangulo rec = new Rectangulo(new Point(50, 60), new Point(350, 200));
                Color colorPluma = Color.Purple;
                Vista vista = new Vista(panel1, colorPluma);
                vista.mostrarRec(rec);

                Circulo circulo1 = new Circulo(20, new Point(340, 50));
                vista.colorLapiz = Color.Purple;
                vista.mostrarCirc(circulo1);

            }
        }
    }
}
