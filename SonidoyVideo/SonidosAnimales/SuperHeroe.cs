using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace SonidosAnimales
{
    class SuperHeroe : SerVivo
    {
        private string video;

        public SuperHeroe( string nom,Image img, string video)
            : base(img, nom)
        {
            this.video = video;
        }
        public override void Accion()
        {
            EjecutarProceso();
        }
        private void EjecutarProceso()
        {
                Process nuevoProceso = new Process();
                nuevoProceso.StartInfo.FileName = video;
                nuevoProceso.Start();
        }
    }
}
