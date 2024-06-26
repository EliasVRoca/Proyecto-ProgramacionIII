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
    public partial class Cadena5 : Form
    {
        public Cadena5()
        {
            InitializeComponent();
        }

        static string invertirPalabras(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                char[] palabra = palabras[i].ToCharArray();
                palabras[i] = string.Join("", palabra.Reverse());
            }

            return string.Join(" ", palabras);
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            string cadena = Entrada.Text.Trim();
            string res = invertirPalabras((string)cadena);
            Resultado.Text = $"Resultado: \n {res}";
        }
    }
}
