using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ProgramacionIII.Cadena
{
    public partial class Cadena1 : Form
    {
        public Cadena1()
        {
            InitializeComponent();
        }
        public int count_words(string words)
        {

            int res = 0;
            if (words == "")
            {
                return 0;
            }
            string[] arreglo = words.Split(' ');
            res = arreglo.Length;
            return res;
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            string words = textBox1.Text.Trim();
            int res = count_words(words);
            Res.Text = $"RESPUESTA: {res} PALABRAS";
        }
    }
}
