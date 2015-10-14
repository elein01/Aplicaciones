using Practica9;
using Practica9.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo.Datos
{
    static class Data
        //Cuando usas un static tus variables y mètodos deben ser estaticos
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static List<Administrador> administradores = new List<Administrador>();
        private static List<Producto> productos = new List<Producto>();

        public static List<Cliente> Clientes
        {
            get{ return clientes; }
        }
        public static List<Administrador> Administradores
        {
            get{ return administradores; }
        }
        public static List<Producto> Productos
        {
            get { return productos; }
        }
        public static void addC(Cliente c)
        {
            clientes.Add(c);
        }
        public static void addP(Producto p)
        {
            productos.Add(p);
        }
        public static void addA(Administrador a)
        {
            administradores.Add(a);
        }       
    }
}
