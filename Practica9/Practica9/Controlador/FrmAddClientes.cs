using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVA_Class_Demo;

namespace Practica9.Controlador
{
    public partial class FrmAddClientes : Form
    {
        public FrmAddClientes()
        {
            InitializeComponent();
        }

        private void FrmAddClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0 && MessageBox.Show("Deseas agregar el cliente " + txtNombre.Text, " App Empleado - Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Data.add(new Cliente(txtNombre.Text));
                MessageBox.Show("Cliente Agregado", "App - Empleado - Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Favor de introducir datos válidos", "App - Empleado - Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
