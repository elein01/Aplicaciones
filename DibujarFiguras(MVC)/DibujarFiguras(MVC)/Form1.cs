using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DibujarFiguras_MVC_
{
    public partial class Form1 : Form
    {
        Rectangulo r;
        Circulo c;
        Vista v;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularArea();
        }
        public void CalcularArea()
        {
            if (rdRectangulo.Checked)
            {
                Point punto1 = new Point(Convert.ToInt16(txtP1x.Text), Convert.ToInt16(txtP1y.Text));
                Point punto2 = new Point(Convert.ToInt16(txtP2x.Text), Convert.ToInt16(txtP2y.Text));

                r = new Rectangulo(punto1, punto2);

                lbResAreaRec.Text = r.area().ToString();
            }
            else
            {
                Point puntos = new Point(Convert.ToInt16(txtPx.Text), Convert.ToInt16(txtPy.Text));
                int radio = int.Parse(txtRadio.Text);
                c = new Circulo(radio, puntos);
                lbAreaCir.Text = c.area().ToString();
            }
        }
        public void Dibujar()
        {
            v = new Vista(panel1, Color.Red, Color.White);
            if (rdRectangulo.Checked)
            {
                v.mostrarRec(r);
            }
            else
                if (rdCirculo.Checked)
                {
                    v.mostrarCirc(c);
                }
        }
        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Dibujar();
        }

        private void btnBorrae_Click(object sender, EventArgs e)
        {
            v.Borrar();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdRectangulo.Checked)
            {
                txtP1x.Text = e.X.ToString();
                txtP1y.Text = e.Y.ToString();
            }
            else
            {
                txtPx.Text = e.X.ToString();
                txtPy.Text = e.Y.ToString();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdRectangulo.Checked)
            {
                txtP2x.Text = e.X.ToString();
                txtP2y.Text = e.Y.ToString();
                CalcularArea();
                Dibujar();
            }
            else
            {
                txtRadio.Text = Math.Abs(Convert.ToInt16(txtPx.Text) - e.X).ToString();
                CalcularArea();
                Dibujar();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Text = String.Format(" {0} , {1} ", e.X, e.Y);
        }

        private void rdRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            grpRectangulo.Enabled = true;
            grpCirculo.Enabled = false;
        }

        private void rdCirculo_CheckedChanged(object sender, EventArgs e)
        {
            grpCirculo.Enabled = true;
            grpRectangulo.Enabled = false;
        }
    }
}
