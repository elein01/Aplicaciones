using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVA_Class_Demo;
using Practica9.Modelo;

namespace Practica9.Controlador
{
    public partial class FrmAddProducto : Form
    {
        public FrmAddProducto()
        {
            InitializeComponent();
        }

        private void btnAddProcducto_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            double precio = 0.0;
            try
            {
                precio = Double.Parse(this.txtPrecio.Text);
            }
            catch (Exception)
            {
                bandera = false;
                MessageBox.Show("Valor de precio no valido", "App Cliente - Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (bandera)
            {
                Producto p = new Producto((Producto.Productos)Enum.Parse(typeof(Producto.Productos),
                    cmbProductos.Text),precio));
                Data.add(p);
                ModeloSecuencial.escribir("Productos.data", p);
                MessageBox.Show("Producto Agregado", " App Cliente-Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmAddProducto_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Producto.Productos)))
                cmbProductos.Items.Add(item);
        }
    }
}
