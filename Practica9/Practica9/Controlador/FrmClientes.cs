using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica9.Vista;
using MVA_Class_Demo;

namespace Practica9.Controlador
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            VistaDatos vista = new VistaDatos();
            vista.Mostrar(listBox1, Data.Clientes);
        }
    }
}
