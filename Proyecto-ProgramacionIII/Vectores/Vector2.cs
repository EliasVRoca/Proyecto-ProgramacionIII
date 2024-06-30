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
    public partial class Vector2 : Form
    {
        public Vector2()
        {
            InitializeComponent();
        }
        public string OrdenMergeSort(string numerosTexto)
        {

            int[] numeros = numerosTexto.Split(',')
                                        .Select(numStr => int.Parse(numStr.Trim()))
                                        .ToArray();
            MergeSort(numeros, 0, numeros.Length - 1);

            string resultado = string.Join(",", numeros);

            return resultado;
        }
        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);

                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }
        private void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;


            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int c = 0; c < n1; ++c)
                L[c] = arr[left + c];
            for (int t = 0; t < n2; ++t)
                R[t] = arr[middle + 1 + t];

            int i = 0, j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numerosTexto = textBox1.Text;
            string resultado = OrdenMergeSort(numerosTexto);
            label3.Text = resultado;
        }
    }
}
