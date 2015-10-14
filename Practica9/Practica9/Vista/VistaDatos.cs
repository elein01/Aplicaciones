            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica9.Modelo;

namespace Practica9.Vista
{
    class VistaDatos
    {
       // este método le pide como parametro un listBox y una lista
        public void Mostrar<T>(ListBox lista, List<T> coleccion)
        {
            coleccion.Sort();
            foreach (object item in coleccion)
                lista.Items.Add(item);
        }
    }
}
