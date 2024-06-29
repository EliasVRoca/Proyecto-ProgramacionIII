namespace Proyecto_ProgramacionIII.Cadena
{
    partial class Cadena1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Funcion = new Label();
            Ejecutar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            Res = new Label();
            SuspendLayout();
            // 
            // Funcion
            // 
            Funcion.AutoSize = true;
            Funcion.BackColor = SystemColors.ControlDarkDark;
            Funcion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Funcion.ForeColor = SystemColors.ControlLightLight;
            Funcion.Location = new Point(422, 127);
            Funcion.Name = "Funcion";
            Funcion.Size = new Size(210, 105);
            Funcion.TabIndex = 7;
            Funcion.Text = "public int count_words(string words) {\r\n\r\n    int res = 0;\r\n    string[] arreglo = words.Split();\r\n    res = arreglo.Length;\r\n    return res;\r\n}";
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(113, 183);
            Ejecutar.Margin = new Padding(3, 2, 3, 2);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(107, 28);
            Ejecutar.TabIndex = 6;
            Ejecutar.Text = "Probar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(511, 32);
            label1.TabIndex = 5;
            label1.Text = "ESCRIBIR UNA FUNCION QUE DEVUELVA LA CANTIDAD DE PALABRAS QUE HAY EN UNA\r\nCADENA\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 67);
            textBox1.TabIndex = 8;
            // 
            // Res
            // 
            Res.AutoSize = true;
            Res.Location = new Point(63, 283);
            Res.Name = "Res";
            Res.Size = new Size(72, 15);
            Res.TabIndex = 9;
            Res.Text = "RESPUESTA: ";
            // 
            // Cadena1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Res);
            Controls.Add(textBox1);
            Controls.Add(Funcion);
            Controls.Add(Ejecutar);
            Controls.Add(label1);
            Name = "Cadena1";
            Text = "Cadena1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Funcion;
        private Button Ejecutar;
        private Label label1;
        private TextBox textBox1;
        private Label Res;
    }
}