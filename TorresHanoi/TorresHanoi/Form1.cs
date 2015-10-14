using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresHanoi
{
    public partial class Form1 : Form
    {
        ListBox torreOrigen;
        Stack pilaOrigen;
        Hanoi hanoi = new Hanoi();
        int movimientos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void HacerDragDrop(ListBox lista, Stack pila)
        {
            try
            {
                torreOrigen = lista;
                pilaOrigen = pila;
                lista.DoDragDrop(lista.SelectedItem, DragDropEffects.Move);
            }
            catch { }
        }
        private void finDelJuego()
        {
            movimientos++;
            lbMovimientos.Text = string.Format("Mobimientos: {0}", movimientos);
            if (hanoi.Torre3.Count == Convert.ToInt16(cmbDiscos.Text))
                MessageBox.Show("Ganaste", "Torre de Hanoi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbDiscos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int discos = Convert.ToInt16(cmbDiscos.Text);
            Torre1.Items.Clear();
            Torre2.Items.Clear();
            Torre3.Items.Clear();
            hanoi.clear();

            for (int i = discos; i > 0; i--)
            {
                Torre1.Items.Insert(0, i);
                hanoi.Torre1.Push(i);
            }
            movimientos = 0;
            lbMovimientos.Text = string.Format("Movimientos: {0}", movimientos);
        }
        private void Torre1_DragDrop(object sender, DragEventArgs e)
        {
            if (VistaHanoi.Intercambiar(Torre1, torreOrigen, hanoi.Torre1, pilaOrigen))
                finDelJuego();
        }
        private void Torre2_DragDrop(object sender, DragEventArgs e)
        {
            if (VistaHanoi.Intercambiar(Torre2, torreOrigen, hanoi.Torre2, pilaOrigen))
                finDelJuego();
        }
        private void Torre3_DragDrop(object sender, DragEventArgs e)
        {
            if (VistaHanoi.Intercambiar(Torre3, torreOrigen, hanoi.Torre3, pilaOrigen))
                finDelJuego();
        }
       private void Torre1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Torre2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Torre3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void Torre1_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(Torre1, hanoi.Torre1);
        }
        private void Torre2_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(Torre2, hanoi.Torre2);
        }
        private void Torre3_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(Torre3, hanoi.Torre3);
        }
    }
}
