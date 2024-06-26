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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_ProgramacionIII.Cadena
{
    public partial class Cadena2 : Form
    {
        public Cadena2()
        {
            InitializeComponent();
        }

        private void Cadena2_Load(object sender, EventArgs e)
        {

        }

        static string deleteVocals(string words)
        {
            string[] vocales = {"a", "e", "i", "o", "u",
                "A", "E", "I", "O", "U",
                "á", "é", "í", "ó", "ú",
                "Á", "É", "Í", "Ó", "Ú"};
            for (int i = 0; i < vocales.Length; i++)
            {
                words = words.Replace(vocales[i], "");
            }


            return words;
        }


     

        private void button1_Click_2(object sender, EventArgs e)
        {
            string words = textBox1.Text;
            string res = deleteVocals(words);
            label2.Text = ($"RESPUESTA: \n {res}");
        }
    }
}
