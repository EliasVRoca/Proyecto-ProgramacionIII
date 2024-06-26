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

namespace Proyecto___Programacion_III___UPC
{
    public partial class Ejercicio_1 : Form
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }
        Series helper = new Series();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int resultado = helper.Serie_1(numero);
            label4.Text = resultado.ToString();
        }
    }
}
