using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica9.Controlador
{
    public partial class FrmAddAdministrativo : Form
    {
        public FrmAddAdministrativo()
        {
            InitializeComponent();
        }

        private void AddAdministrativo_Load(object sender, EventArgs e)
        {
            foreach (string item in Enum.GetNames(typeof(Administrador.Depto)))
                cmbDepartamento.Items.Add(item);
        }
        private void validarDatos(ErrorProvider ep, TextBox txt)
        {
            if (txt.Text.Trim().Length == 0)
            {
                ep.Icon = Icon.FromHandle(((Bitmap)imageList1.Images[0]).GetHicon());
                ep.SetError(txt, "Dato no válido");
            }
            else
            {
                ep.Icon = Icon.FromHandle(((Bitmap)imageList1.Images[1]).GetHicon());
                ep.SetError(txt, "Dato Correcto");
            }
        }
        private void txtNumero_Leave(object sender, EventArgs e)
        {
            validarDatos(errorNumero, txtNumero);
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            validarDatos(errorNombre, txtNombre);
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            validarDatos(errorApellido, txtApellido);
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            validarDatos(errorDireccion, txtDireccion);
        }
    }
}
