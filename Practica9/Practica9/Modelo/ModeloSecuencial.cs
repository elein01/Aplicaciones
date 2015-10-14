using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Practica9.Modelo
{
    class ModeloSecuencial
    {
        private BinaryReader lector;
        private BinaryWriter escritor;

        public ModeloSecuencial()
        {
            lector = null;
            escritor = null;
        }

        public void abrir_escritura(string nomarchivo)
        {
            FileStream fs = new FileStream(nomarchivo, FileMode.Append, FileAccess.Write);
            escritor = new BinaryWriter(fs);
        }
        public void abrir_lectura(string nomarchivo)
        {
            FileStream fs = new FileStream(nomarchivo, FileMode.Open, FileAccess.Read);
            lector = new BinaryReader(fs);
        }
        public void escribirCliente(string archivo, Cliente c)
        {
            abrir_escritura(archivo);
            escritor.Write(c.Nombre);
            escritor.Write(c.Puntos);
            escritor.Close();
        }
        public List<Cliente> leer(string archivo)
        {
            List<Cliente> alumnos = new List<Cliente>();
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
                        alumnos.Add(new Cliente(nombre));
                    }
                }
                catch (EndOfStreamException)
                {
                    //fin del archivo
                }
                finally
                {
                    lector.Close();
                }
            }
            else
                MessageBox.Show(String.Format("El  archivo {0} no existe", archivo));
            return alumnos;
        }
    }
}
