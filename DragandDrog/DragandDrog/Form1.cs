using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragandDrog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void lisDestino_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(lisDestino);
        }

        private void lisDestino_DragDrop(object sender, DragEventArgs e)
        {
            Intercambiar(lisDestino, lisOrigen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 9; i >= 0; i--)
                lisOrigen.Items.Add(i);
        }
        private void Intercambiar(ListBox listaA, ListBox listaB) // Este metodo toma el numero de la 
        {                                                        //  lista A lo pasa a la B y lo borra de la A
        
            Object item = listaB.SelectedItem;
            listaA.Items.Add(item);
            listaB.Items.Remove(item);
        }

        private void lisOrigen_DragDrop(object sender, DragEventArgs e)
        {
            Intercambiar(lisOrigen, lisDestino);
        }

        private void lisOrigen_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(lisOrigen);
        }
        private void HacerDragDrop(ListBox lista)
        {
            try
            {
                lista.DoDragDrop(lista.SelectedItem, DragDropEffects.Move);
            }
            catch { }
        }

        private void lisDestino_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lisOrigen_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
