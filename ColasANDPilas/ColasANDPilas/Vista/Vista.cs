using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ColasANDPilas
{
    class Vista
    {
        public void MostrarPila(ListBox lista, Stack pila, Label turno)
        {
            // Limpiando Valores
            lista.Items.Clear();
            // Mostrando los valores

            foreach (Persona item in pila)
                lista.Items.Add(item);

            if (pila.Count > 0)
            {
                turno.Text = String.Format("Turno: {0}", pila.Peek()); // peek es para saber cual es el ultimo de la pila
            }
            else turno.Text = "Sin elementos";
        }

        public void MostrarCola(ListBox lista, Queue cola, Label turno)
        {
            // Limpiando Valores
            lista.Items.Clear();
            // Mostrando los valores
            foreach (Persona item in cola)
                lista.Items.Add(item);

            if (cola.Count > 0)
            {
                turno.Text = String.Format("Turno: {0}", cola.Peek()); // peek es para saber cual es el ultimo de la cola
            }
            else turno.Text = "Sin elementos";
        }
    }
}
