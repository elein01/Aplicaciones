using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica9.Modelo;
using Practica9;

namespace MVA_Class_Demo
{
    static class Data
    {
        private static List<Producto> productos = new List<Producto>();
        private static List<Administrador> administradores = new List<Administrador>();
        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Administrador> Administradores
        {
            get { return administradores; }
        }

        public static List<Cliente> Clientes
        {
            get { return clientes; }
        }

        public static List<Producto> Productos
        {
            get { return productos; }
        }

        public static void add(Cliente c)
        {
            clientes.Add(c);
        }

        public static void add(Administrador a)
        {
            administradores.Add(a);
        }

        public static void add(Producto p)
        {
            productos.Add(p);
        }
    }
}
