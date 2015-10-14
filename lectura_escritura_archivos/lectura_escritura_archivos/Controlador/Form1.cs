using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace lectura_escritura_archivos
{
    public partial class Form1 : Form
    {
        ModeloSecuencial modelo = new ModeloSecuencial();
        VistaSecuencial vista = new VistaSecuencial();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = openFileDialog1.FileName;
            }
            List<Alumno> a = new List<Alumno>();
            a = modelo.leer(txtArchivo.Text);
            vista.imrpimevista(lvPersonas, a);
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.nombre = txtNombre.Text;
            a.direccion = txtDireccion.Text;
            a.edad = Convert.ToInt16(txtEdad.Text);
            modelo.escribir(txtArchivo.Text, a);

            MessageBox.Show("Datos escritos en el archivo!!");
        }
    }
}
