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
    public partial class Mayor_Num_Form : Form
    {
        funct_Num.Operaciones_Numericas_abel block_Numero = new funct_Num.Operaciones_Numericas_abel();
        public Mayor_Num_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int datos_textB = int.Parse(textBox1.Text);
            int result = block_Numero.Funcion_Mayor_N(datos_textB);
            label2.Text = result.ToString();
        }
    }
}
