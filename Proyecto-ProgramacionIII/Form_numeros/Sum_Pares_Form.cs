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
    public partial class Sum_Pares_Form : Form
    {
        funct_Num.Operaciones_Numericas_abel block_Numero = new funct_Num.Operaciones_Numericas_abel();

        public Sum_Pares_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int date_user = int.Parse(textBox1.Text);
            int resultado = block_Numero.suma_Pares(date_user);
            label1.Text = resultado.ToString();
        }
    }
}
