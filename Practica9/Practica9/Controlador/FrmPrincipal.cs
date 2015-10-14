using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica9.Vista;
using Practica9.Modelo;
using Practica9.Controlador;



namespace Practica9
{
    public partial class frmPrincipal : Form
    {
        VistaDatos vista = new VistaDatos();
        List<Producto> producto = new List<Producto>();
        List<Administrador> administrativos = new List<Administrador>();

        public frmPrincipal()
        {
            
 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que deseas salir?","App Empleado Cliente",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==
                System.Windows.Forms.DialogResult.Yes)
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmClientes());
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmProducto()); 
        }
        private void MostrarFormulario(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmAddClientes());
        }

        private void altasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmAddProducto());
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmClientes());
        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmAddAdministrativo());
        }

        private void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmAdministrador());
        }

        private void catálogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmProducto());
        }      
    }
}
