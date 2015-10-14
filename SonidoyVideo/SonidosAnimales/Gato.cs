using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SonidosAnimales
{
    class Gato : SerVivo
    {
        public Gato(string nom, Image img)
            :base(img, nom)
        {
        }
       public override void Accion()
        {
            SoundPlayer soni = new SoundPlayer("gato.wav");
            soni.Play();
        }
    }
}
