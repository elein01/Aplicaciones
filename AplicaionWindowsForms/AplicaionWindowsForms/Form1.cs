using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaionWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNomArchivo.Text = openFileDialog1.FileName;
                List<Alumno> alumnos = modelo.leer(txtNomArchivo.Text);
                Vista.Imprime_lista(lvPersonas, alumnos);
           
            }
        }
    }
}
