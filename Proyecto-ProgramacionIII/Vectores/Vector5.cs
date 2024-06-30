using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_ProgramacionIII.Vectores
{
    public partial class Vector5 : Form
    {
        public string InvertirParteVector(string numerosTexto, string rangoTexto)
        {
            string[] partesRango = rangoTexto.Split(',');

            if (partesRango.Length != 2)
            {
                return "Error: El formato del rango debe ser (inicio,fin).";
            }
            int inicio, fin;
            if (!int.TryParse(partesRango[0].Trim(), out inicio) || !int.TryParse(partesRango[1].Trim(), out fin))
            {
                return "Error: El formato del rango no es válido.";
            }
            var numeros = numerosTexto.Split(',')
                                     .Select(numStr => int.Parse(numStr.Trim()))
                                     .ToList();
            if (inicio < 0 || inicio >= numeros.Count || fin < 0 || fin >= numeros.Count || inicio >= fin)
            {
                return "Error: El rango especificado está fuera de los límites del vector.";
            }

            int length = fin - inicio + 1;
            numeros.Reverse(inicio, length);
            string resultado = string.Join(",", numeros);

            return resultado;
        }

        public Vector5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numerosTexto = textBox1.Text;
            string rangoTexto = textBox2.Text;
            string resultado = InvertirParteVector(numerosTexto, rangoTexto);
            label5.Text = resultado;
        }
    }
}
