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
    public partial class Mover_Mayor_Form : Form
    {
        funct_Num.Operaciones_Numericas_abel block_Numero = new funct_Num.Operaciones_Numericas_abel();
        public Mover_Mayor_Form()
        {
            InitializeComponent();
        }

        private void Mover_Mayor_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            string resultado = block_Numero.mover_Mayor(textBox1.Text);
            label6.Text = resultado;
        }
    }
}
