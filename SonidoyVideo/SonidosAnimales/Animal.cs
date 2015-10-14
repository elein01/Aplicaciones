using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SonidosAnimales
{
    abstract class SerVivo
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

        public SerVivo( Image img, string nom)
        {
            imagen = img;
            nombre = nom;
        }
        abstract public void Accion();
    }
}
