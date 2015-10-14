using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ColasANDPilas
{
    // PILA : el 1ero que entra es el ultimo que sale
    // COLA: el 1ero que entra es el primero que sale

    public partial class Form1 : Form
    {
        //Pila
        Stack pila = new Stack();
        //Cola
        Queue cola = new Queue(); // no se define el tamaño

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // agregar en la cola se utiliza Enqueue
            cola.Enqueue(new Persona(txtItem.Text)); // se crea un objeto para utilizar la clase Persona
            // Agregar en una pila se utiliza Push
            pila.Push(new Persona(txtItem.Text)); 
            txtItem.Text = "";
            MostrarDatos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0) // comprueba que existan registros 
            {
                // Quitar en una cola Dequeue
                cola.Dequeue();
                // Quitar en una pila Pop
                pila.Pop();
            }
            else
                MessageBox.Show("No hay elemento a remover", "Pilas & Colas", MessageBoxButtons.OK, MessageBoxIcon.Information);
              // 1er parametro muestra la cadena 
              // 2do parametro muestra el titulo que tendra la ventana
              // 3er parametro crea un boton de aceptar
              // 4to parametro muestra un icono
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            Vista v = new Vista();
            v.MostrarPila(lisPila, pila, lbTurnPila);
            v.MostrarCola(lisCola, cola, lbTurnCola);
            lbCantidad.Text = String.Format("Elementos: {0}", pila.Count);
        }
    }
}
