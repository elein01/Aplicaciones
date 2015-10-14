using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica9.Vista;

namespace Practica9.Controlador
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
            VistaDatos vista = new VistaDatos();
            List<Administrador> administrativos = new List<Administrador>();
            administrativos.Add(new Administrador("007", "James", "Bond", "London, Englad", Administrador.Depto.Ventas));
            administrativos.Add(new Administrador("001", "Max", "Steel", "Dalas, Texas", Administrador.Depto.Contrataciones));
            vista.Mostrar(listBox1, administrativos);
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

       
        } 
}
