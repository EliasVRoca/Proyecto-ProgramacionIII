namespace Proyecto_ProgramacionIII.Vectores
{
    partial class Vector3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(755, 30);
            label1.TabIndex = 1;
            label1.Text = "ORDERNAR LO VALORES DEL VECTOR CON EL ALGORITMO  \"INSERTIONSORT\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 167);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 2;
            label2.Text = "Eperando Resultado...";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(273, 54);
            label3.TabIndex = 3;
            label3.Text = "Ingrese los digitos numericos, \r\nEj:  27,15,47,36\r\n\r\n\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(43, 162);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 34);
            textBox1.TabIndex = 4;
            textBox1.Tag = "";
            // 
            // button1
            // 
            button1.Location = new Point(73, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 5;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(214, 166);
            label5.Name = "label5";
            label5.Size = new Size(27, 30);
            label5.TabIndex = 7;
            label5.Text = "=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(166, 282);
            label4.Name = "label4";
            label4.Size = new Size(386, 170);
            label4.TabIndex = 8;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(577, 167);
            label6.Name = "label6";
            label6.Size = new Size(221, 285);
            label6.TabIndex = 9;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Vector3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Vector3";
            Text = "Vector3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}