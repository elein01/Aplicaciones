using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SonidosAnimales
{
    class Elefante : Animal
    {
        public Elefante(string nom, Image img)
            :base(img, nom)
        {
        }
        public override void sonido()
        {
            SoundPlayer soni = new SoundPlayer("elefante.wav");
            soni.Play();
        }
    }
}
