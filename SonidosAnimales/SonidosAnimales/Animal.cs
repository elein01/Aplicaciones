using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SonidosAnimales
{
    class Animal
    {
        private Image imagen;
        private string nombre;

        public Image Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public Animal( Image img, string nom)
        {
            imagen = img;
            nombre = nom;
        }
        public virtual void sonido()
        {
            SoundPlayer soni = new SoundPlayer("");
            soni.Play();
        }

    }
}
