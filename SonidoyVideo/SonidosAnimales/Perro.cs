using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SonidosAnimales
{
    class Perro : SerVivo
    {
        public Perro(string nom, Image img)
            :base(img, nom)
        {
        }
        public override void Accion()
        {
            SoundPlayer soni = new SoundPlayer("perro.wav");
            soni.Play();
        }
    }
}
