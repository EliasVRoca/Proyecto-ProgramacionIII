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
    public partial class Vector3 : Form
    {
        public Vector3()
        {
            InitializeComponent();
        }

        public string OrdenInsertionSort(string numerosTexto)
        {
            int[] numeros = numerosTexto.Split(',')
                                        .Select(numStr => int.Parse(numStr.Trim()))
                                        .ToArray();
            InsertionSort(numeros);
            string resultado = string.Join(",", numeros);

            return resultado;
        }
        private void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numerosTexto = textBox1.Text;
            string resultado = OrdenInsertionSort(numerosTexto);
            label2.Text = resultado;
        }
    }
}
