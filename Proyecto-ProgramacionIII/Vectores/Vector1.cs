using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ProgramacionIII.Vectores
{
    public partial class Vector1 : Form
    {
        public Vector1()
        {
            InitializeComponent();
        }

        public int contar_pares_vector(int[] vector) 
        {
            Helpers helpers = new Helpers();
            int par = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (helpers.esPar(vector[i]))
                {
                    par++;
                }
            }
            return par;
        }

        private void EJECUTAR_Click(object sender, EventArgs e)
        {
            string req = textBox1.Text.Trim();
            string[] vector = req.Split(',');
            int[] vectorInt = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                vectorInt[i] = int.Parse(vector[i]);
            }
            int res = contar_pares_vector(vectorInt);
            RES.Text = $"RESPUESTA: {res} PARES";
        }
    }
}
