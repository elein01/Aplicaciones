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
              SerVivo objt = (SerVivo)miLista[e.RowIndex];
              objt.Accion();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            SerVivo perro = new Perro("Perro", Image.FromFile("perro.jpg"));
            miLista.Add(perro);
            SerVivo gato = new Gato("Gato", Image.FromFile("gato.jpg"));
            miLista.Add(gato);
            SerVivo elefant = new Elefante("Elefante", Image.FromFile("elefante.jpg"));
            miLista.Add(elefant);
            SerVivo superman = new SuperHeroe("SuperMan", Image.FromFile("superman.jpg"), "TrailerSuperman.avi");
            miLista.Add(superman); 
            SerVivo batman = new SuperHeroe("Batman", Image.FromFile("batman.jpg"), "TrailerBatman.avi");
            miLista.Add(batman);
            SerVivo spiderman = new SuperHeroe("Spiderman", Image.FromFile("spiderman.jpg"), "TrailerSpiderman.avi");
            miLista.Add(spiderman);
            SerVivo jhonny = new Actores("Jhonny Depp", Image.FromFile("jhonnydepp.jpg"), "JohnnyDepp.docx");
            miLista.Add(jhonny);
            SerVivo sandra = new Actores("Sandra Bullock", Image.FromFile("sandrabullock.jpg"), "SandraBullock.docx");
            miLista.Add(sandra);

           
            int i = 0;

            foreach (SerVivo ani in miLista)
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
