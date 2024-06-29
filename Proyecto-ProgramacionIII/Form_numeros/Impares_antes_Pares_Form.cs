using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Programacion_III___UPC.Form_num
{
    public partial class Impares_antes_Pares_Form : Form
    {
        funct_Num.Operaciones_Numericas_abel block_Numero = new funct_Num.Operaciones_Numericas_abel(); 
        public Impares_antes_Pares_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Digit_Ingresados.Text = textBox1.Text;
            int resultado = block_Numero.contador_Cantidad_impares(textBox1.Text);
            label4.Text = "Se encontraron:" + " " + resultado.ToString();
        }
    }
}
