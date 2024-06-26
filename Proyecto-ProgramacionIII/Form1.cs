
using Proyecto_ProgramacionIII.Cadena;
using Proyecto_ProgramacionIII.Vectores;

namespace Proyecto_ProgramacionIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1CadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadena1 cadena1 = new Cadena1();
            cadena1.Show();
        }

        private void ejercicio2CadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadena2 cadena2 = new Cadena2();
            cadena2.Show();
        }

        private void ejercicio3CadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadena3 cadena3 = new Cadena3();
            cadena3.Show();
        }

        private void ejercicio4CadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadena4 cadena4 = new Cadena4();
            cadena4.Show();
        }

        private void ejercicio5CadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadena5 cadena5 = new Cadena5();
            cadena5.Show();
        }

        private void ejercicio1VectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector1 vector1 = new Vector1();
            vector1.Show();
        }

        private void ejercicio2VectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector2 vector2 = new Vector2();
            vector2.Show();
        }

        private void ejercicio3VectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector3 vector3 = new Vector3();
            vector3.Show();
        }

        private void ejercicio4VectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector4 vector4 = new Vector4();
            vector4.Show();
        }

        private void ejercicio5VectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector5 vector5 = new Vector5();
            vector5.Show();
        }
    }
}
