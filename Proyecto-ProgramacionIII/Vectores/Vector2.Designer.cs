namespace Proyecto_ProgramacionIII.Vectores
{
    partial class Vector2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector2));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(712, 30);
            label1.TabIndex = 0;
            label1.Text = "ORDERNAR LO VALORES DEL VECTOR CON EL ALGORITMO \"MERGESORT\"";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 88);
            label2.Name = "label2";
            label2.Size = new Size(273, 54);
            label2.TabIndex = 1;
            label2.Text = "Ingrese los digitos numericos, \r\nEj:  2,5,7,8,58,23\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 156);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 44);
            textBox1.TabIndex = 2;
            textBox1.Tag = "";
            // 
            // button1
            // 
            button1.Location = new Point(71, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 3;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(318, 169);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 4;
            label3.Text = "Eperando Resultado...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(12, 261);
            label4.Name = "label4";
            label4.Size = new Size(335, 180);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(262, 169);
            label5.Name = "label5";
            label5.Size = new Size(21, 21);
            label5.TabIndex = 6;
            label5.Text = "=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(369, 246);
            label6.Name = "label6";
            label6.Size = new Size(265, 195);
            label6.TabIndex = 7;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Vector2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Vector2";
            Text = "Vector2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}