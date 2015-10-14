using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica9
{
    abstract class Empleado : IComparable
    {
        public virtual void Login()
        {
            MessageBox.Show("Login Empleado");
        }

        public abstract void Hire();

        public Empleado(string numero, string nombre, string apellidos, string direccion)
        {
            EmpNumber = numero;
            FirstName = nombre;
            LastName = apellidos;
            Address = direccion;
        }

        private string empNumber;
        private string firstname;
        private string lastName;
        private string address;

        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int CompareTo(object obj)
        {
            Empleado comparado = (Empleado)obj;
            return String.Compare(this.FirstName, comparado.FirstName);
        }
    }
}
