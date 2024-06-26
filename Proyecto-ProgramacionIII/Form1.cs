using Proyecto___Programacion_III___UPC;

namespace Proyecto_ProgramacionIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void serie_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Ejercicio_1 ejercicio_1 = new Ejercicio_1();
            ejercicio_1.Show();
        }
        private void serie_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_2 ejercicio_2 = new Ejercicio_2();
            ejercicio_2.Show();
        }
        private void serie_3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_3 ejercicio_3 = new Ejercicio_3();
            ejercicio_3.Show();
        }
        private void serie_4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_4 ejercicio_4 = new Ejercicio_4();
            ejercicio_4.Show();
        }
        private void serie_5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_5 ejercicio_5 = new Ejercicio_5();
            ejercicio_5.Show();
        }
    }
}
