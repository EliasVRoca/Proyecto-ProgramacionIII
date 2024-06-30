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
    public partial class Vector4 : Form
    {
        public string EliminarDato(string numerosTexto, string datoAEliminarTexto)
        {
            int datoAEliminar;
            if (!int.TryParse(datoAEliminarTexto, out datoAEliminar))
            {
                return "Error.";
            }

            var numeros = numerosTexto.Split(',')
                                     .Select(numStr => int.Parse(numStr.Trim()))
                                     .ToList();
            numeros.RemoveAll(num => num == datoAEliminar);
            string resultado = string.Join(",", numeros);

            return resultado;
        }
        public Vector4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numerosTexto = textBox1.Text;
            string datoAEliminarTexto = textBox2.Text;
            string resultado = EliminarDato(numerosTexto, datoAEliminarTexto);
            label5.Text = resultado;
        }
    }
}
