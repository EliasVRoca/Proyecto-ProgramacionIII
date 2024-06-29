namespace Proyecto___Programacion_III___UPC.Form_num
{
    partial class Impares_antes_Pares_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impares_antes_Pares_Form));
            label4 = new Label();
            Digit_Ingresados = new Label();
            Segundo = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(585, 145);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 14;
            label4.Text = "........";
            // 
            // Digit_Ingresados
            // 
            Digit_Ingresados.AutoSize = true;
            Digit_Ingresados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Digit_Ingresados.Location = new Point(12, 145);
            Digit_Ingresados.Name = "Digit_Ingresados";
            Digit_Ingresados.Size = new Size(28, 30);
            Digit_Ingresados.TabIndex = 13;
            Digit_Ingresados.Text = "...";
            // 
            // Segundo
            // 
            Segundo.AutoSize = true;
            Segundo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Segundo.Location = new Point(12, 69);
            Segundo.Name = "Segundo";
            Segundo.Size = new Size(211, 32);
            Segundo.TabIndex = 12;
            Segundo.Text = "Digitos Ingresados";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(270, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(549, 80);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 10;
            label2.Text = "Resultado";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(291, 314);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(102, 46);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, -4);
            label1.Name = "label1";
            label1.Size = new Size(479, 40);
            label1.TabIndex = 8;
            label1.Text = "Contador de impares antes de pares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 205);
            label3.Name = "label3";
            label3.Size = new Size(296, 32);
            label3.TabIndex = 15;
            label3.Text = "Ingrese Digitos Numericos";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(501, 182);
            label5.Name = "label5";
            label5.Size = new Size(347, 443);
            label5.TabIndex = 16;
            label5.Text = resources.GetString("label5.Text");
            // 
            // Impares_antes_Pares_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 623);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Digit_Ingresados);
            Controls.Add(Segundo);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Impares_antes_Pares_Form";
            Text = "Impares_antes_Pares_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label Digit_Ingresados;
        private Label Segundo;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label5;
    }
}