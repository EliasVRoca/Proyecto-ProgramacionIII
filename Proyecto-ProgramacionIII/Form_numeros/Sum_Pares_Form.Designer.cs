namespace Proyecto___Programacion_III___UPC.Form_num
{
    partial class Sum_Pares_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sum_Pares_Form));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(159, 249);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(124, 58);
            button1.TabIndex = 8;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 152);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 7;
            label1.Text = "Esperando resultado....";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 31);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 9);
            label2.Name = "label2";
            label2.Size = new Size(286, 32);
            label2.TabIndex = 9;
            label2.Text = "SUMAR NUMEROS PARES";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(441, 210);
            label3.Name = "label3";
            label3.Size = new Size(322, 257);
            label3.TabIndex = 10;
            label3.Click += label3_Click;
            // 
            // Sum_Pares_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 467);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Sum_Pares_Form";
            Text = "Sum_Pares_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}