using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace SonidosAnimales
{
    class Actores : SerVivo
    {
        string documento;

        public Actores(string nom, Image imag, string doc)
            : base(imag, nom)
        {
            this.documento = doc;
        }
        public override void Accion()
        {
            EjecutarProceso();
        }
        private void EjecutarProceso()
        {
            try
            {
                Process nuevoProceso = new Process();
                nuevoProceso.StartInfo.FileName = documento;
                nuevoProceso.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
