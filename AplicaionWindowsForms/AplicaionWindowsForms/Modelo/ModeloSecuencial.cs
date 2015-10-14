using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AplicaionWindowsForms
{
    class ModeloSecuencial
    {
        private BinaryWriter escritor;
        private BinaryReader lector;

        public ModeloSecuencial()
        {
            escritor = null;
            lector = null;
        }
        public void abrir_escritura(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            escritor = new BinaryWriter(fs);
        }
        public void abrir_lectura(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            lector = new BinaryReader(fs);
        }
        public void escribir(string archivo, Alumno a)
        {
            abrir_escritura(archivo);
            escritor.Write(a.Nombre);
            escritor.Write(a.Direccion);
            escritor.Write(a.Edad);
            escritor.Close();
        }
        public List<Alumno> leer(string archivo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            if (escritor != null)
                escritor.Close();
            if (File.Exists(archivo))
            {
                abrir_lectura(archivo);
                try
                {
                    lector.Read();
                    while (true)
                    {
                        string nombre = lector.ReadString();
                        string direccion = lector.ReadString();
                        int edad = Convert.ToInt16(lector.ReadString());
                        alumnos.Add(new Alumno(nombre, direccion, edad);
                    }
                }
                catch(EndOfStreamException)
                {
                    //fin del archivo
                }
                finally
                {
                    lector.Close();
                }
            }
            else
                MessageBox.Show(string.Format("El archivo {0} no existe", archivo));

            return alumnos;
        }
    }
}
