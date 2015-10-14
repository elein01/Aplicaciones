using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica9
{
    class Administrador:Empleado
    {
        public enum Depto { Ventas, Compras, Contrataciones, Gerencia };
        private Depto departamento;
        public Depto Departamento
        {
            get { return departamento; }
            set { departamento = value; }

        }

        public override void Hire()
        {
            MessageBox.Show("Administrador Contratado");
        }
        public Administrador(string numero, string nombre, string apellidos, string direccion, Depto depto):base(numero, nombre, apellidos, direccion)
        {
            Departamento = depto;
        }
        public override string ToString()
        {

            return String.Format("{0} - {1} {2} {3} {4} ", EmpNumber, FirstName, LastName, Address, Departamento);
        }
        public override void Login()
        {
            MessageBox.Show("Login Administrador");
        }

        /*public override void Hire()
        {
            MessageBox.Show("Contratar a alguien");
        }*/
    }
}
