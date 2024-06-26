namespace Proyecto_ProgramacionIII.Cadena
{
    partial class Cadena5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadena5));
            label2 = new Label();
            Resultado = new Label();
            Ejecutar = new Button();
            Entrada = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Cascadia Code PL", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(356, 94);
            label2.Name = "label2";
            label2.Size = new Size(406, 176);
            label2.TabIndex = 9;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Cascadia Code PL", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resultado.Location = new Point(45, 354);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 21);
            Resultado.TabIndex = 8;
            Resultado.Text = "Resultado:";
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(64, 232);
            Ejecutar.Margin = new Padding(3, 2, 3, 2);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(164, 38);
            Ejecutar.TabIndex = 7;
            Ejecutar.Text = "Ejecutar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // Entrada
            // 
            Entrada.Location = new Point(45, 86);
            Entrada.Margin = new Padding(3, 2, 3, 2);
            Entrada.Multiline = true;
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(205, 95);
            Entrada.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 18);
            label1.TabIndex = 5;
            label1.Text = "INVERTIR PALABRAS EN LA CADENA\r\n";
            // 
            // Cadena5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Resultado);
            Controls.Add(Ejecutar);
            Controls.Add(Entrada);
            Controls.Add(label1);
            Name = "Cadena5";
            Text = "Cadena5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label Resultado;
        private Button Ejecutar;
        private TextBox Entrada;
        private Label label1;
    }
}