﻿namespace Proyecto___Programacion_III___UPC
{
    partial class Ejercicio_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_3));
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(488, 180);
            label5.Name = "label5";
            label5.Size = new Size(180, 182);
            label5.TabIndex = 13;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(272, 247);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 12;
            label4.Text = "            ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(75, 206);
            label3.Name = "label3";
            label3.Size = new Size(164, 19);
            label3.TabIndex = 11;
            label3.Text = "Escribe un número :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 46);
            label2.Name = "label2";
            label2.Size = new Size(645, 57);
            label2.TabIndex = 10;
            label2.Text = "3.- Escribe una función que devuelva la suma de los primeros n términos de la serie.\r\n\r\n      Ej. Serie : 0, 2, 4, 6, 8, 10, 12, 14, 16, . . .      SumaSerie(5) =>20";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(255, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 26);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(141, 246);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 8;
            label1.Text = "Resultado :";
            // 
            // button1
            // 
            button1.Location = new Point(192, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ejercicio_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Ejercicio_3";
            Text = "Ejercicio 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}