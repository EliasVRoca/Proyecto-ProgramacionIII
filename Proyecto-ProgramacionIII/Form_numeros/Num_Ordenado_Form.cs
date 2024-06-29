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
    public partial class Num_Ordenado_Form : Form
    {
        funct_Num.Operaciones_Numericas_abel block_Numero = new funct_Num.Operaciones_Numericas_abel();

        public Num_Ordenado_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = block_Numero.order_number(textBox1.Text);
            if (resultado)
            {
                label3.Text = "los digitos están ordenados";
            }
            else
            {
                label3.Text = "los digitos no están ordenados";
            }
        }
    }
}
