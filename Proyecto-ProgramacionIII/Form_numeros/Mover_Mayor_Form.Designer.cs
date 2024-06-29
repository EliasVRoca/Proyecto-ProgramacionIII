namespace Proyecto___Programacion_III___UPC.Form_num
{
    partial class Mover_Mayor_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mover_Mayor_Form));
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(353, 298);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(608, 138);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 17;
            label7.Text = "Resultado Final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(617, 203);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 16;
            label6.Text = "esperando...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 203);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 15;
            label5.Text = "esperando...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 143);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 14;
            label3.Text = "VALOR INGRESADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 203);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 13;
            label2.Text = "INGRESE DIGITOS NUMERICOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 58);
            label1.Name = "label1";
            label1.Size = new Size(495, 32);
            label1.TabIndex = 12;
            label1.Text = "MOVER EL MAYOR DIGITO AL ULTIMO LUGAR";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(321, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 26);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(130, 328);
            label4.Name = "label4";
            label4.Size = new Size(588, 304);
            label4.TabIndex = 19;
            // 
            // Mover_Mayor_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 641);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Mover_Mayor_Form";
            Text = "Mover_Mayor_Form";
            Load += Mover_Mayor_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
    }
}