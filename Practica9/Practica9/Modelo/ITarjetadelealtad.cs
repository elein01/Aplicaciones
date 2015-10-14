using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica9
{
    interface ITarjetadelealtad
    {
        int Puntos { get; }
        int Agregarpuntos(int puntos);
        void Resetearpuntos();
    }
}
