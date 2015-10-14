using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lectura_escritura_archivos
{
    class VistaSecuencial
    {
        public void imrpimevista(ListView lv, List<Alumno> alumnos)
        {
            lv.Items.Clear();
            foreach (Alumno alumno in alumnos)
            {
                ListViewItem item = lv.Items.Add(alumno.nombre);
                item = lv.Items.Add(alumno.direccion);
                item = lv.Items.Add(alumno.edad.ToString());
            }
        }
    }
}
