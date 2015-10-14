using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonidosAnimales
{
    public partial class Form1 : Form
    {
        ArrayList miLista = new ArrayList();
        // Animal[] animales = new Animal[3]; con ******  Arreglo de objetos  *******

        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
              Animal objt = (Animal)miLista[e.RowIndex];
              objt.sonido();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Animal perro = new Perro("Perro", Image.FromFile("perro.jpg"));
            miLista.Add(perro);
            Animal gato = new Gato("Gato", Image.FromFile("gato.jpg"));
            miLista.Add(gato);
            Animal elefant = new Elefante("Elefante", Image.FromFile("elefante.jpg"));
            miLista.Add(elefant);

            int i = 0;

           foreach (Animal ani in miLista)
           {
               dataGridView1.Rows.Add();
               dataGridView1[0, i].Value = ani.Imagen;
               dataGridView1[1, i].Value = ani.Nombre;
               dataGridView1[2, i].Value = " Clic Aqui";
               i++;            
           }               
        }       
    }
}
