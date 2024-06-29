using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Programacion_III___UPC
{
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }
        Series helper = new Series();
        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int resultado = helper.Serie_5(numero);
            label4.Text = resultado.ToString();
        }
    }
}
