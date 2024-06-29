using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ProgramacionIII.Cadena
{
    public partial class Cadena3 : Form
    {
        public Cadena3()
        {
            InitializeComponent();
        }

        static string devolverPalabraMasLarga(string cadena)
        {
            string[] palabras = cadena.Split(' ');

            int tamano = 0;
            int posicion = 0;

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > tamano)
                {
                    tamano = palabras[i].Length;
                    posicion = i;
                }
            }

            return palabras[posicion];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabras = Entrada.Text;
            string res = devolverPalabraMasLarga(palabras);
            Respuesta.Text = $"RESPUESTA: \n {res}";
        }
    }
}
