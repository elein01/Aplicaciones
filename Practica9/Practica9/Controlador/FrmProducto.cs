using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica9.Modelo;
using Practica9.Vista;
using MVA_Class_Demo;

namespace Practica9.Controlador
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            VistaDatos vista = new VistaDatos();
            vista.Mostrar(listBox1, Data.Productos);
        }
    }
}
