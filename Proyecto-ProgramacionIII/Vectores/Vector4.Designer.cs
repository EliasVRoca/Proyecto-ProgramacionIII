namespace Proyecto_ProgramacionIII.Vectores
{
    partial class Vector4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 32);
            label1.TabIndex = 0;
            label1.Text = "ELIMINAR EL DATO \"X\" DE UN VECTOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(210, 60);
            label2.TabIndex = 1;
            label2.Text = "Asignar los valores del vector; \r\nEjemplo: 34, 5, 32, 61, 5...\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(-1, 204);
            label3.Name = "label3";
            label3.Size = new Size(325, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el digito a buscar , que desea eliminar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(75, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 4;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(383, 204);
            label4.Name = "label4";
            label4.Size = new Size(405, 240);
            label4.TabIndex = 6;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(362, 95);
            label5.Name = "label5";
            label5.Size = new Size(232, 30);
            label5.TabIndex = 7;
            label5.Text = "Esperando Resultado.....";
            // 
            // Vector4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Vector4";
            Text = "Vector4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
    }
}