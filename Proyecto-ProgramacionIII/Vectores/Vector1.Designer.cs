namespace Proyecto_ProgramacionIII.Vectores
{
    partial class Vector1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector1));
            TITLE = new Label();
            textBox1 = new TextBox();
            EJECUTAR = new Button();
            RES = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TITLE
            // 
            TITLE.AutoSize = true;
            TITLE.Location = new Point(238, 9);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(315, 30);
            TITLE.TabIndex = 0;
            TITLE.Text = "ESCRIBIR UNA FUNCIÓN QUE DEVUELVA LA CANTIDAD DE\r\nPARES QUE CONTIENE\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 82);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 50);
            textBox1.TabIndex = 1;
            // 
            // EJECUTAR
            // 
            EJECUTAR.Location = new Point(87, 168);
            EJECUTAR.Name = "EJECUTAR";
            EJECUTAR.Size = new Size(116, 45);
            EJECUTAR.TabIndex = 2;
            EJECUTAR.Text = "EJECUTAR";
            EJECUTAR.UseVisualStyleBackColor = true;
            EJECUTAR.Click += EJECUTAR_Click;
            // 
            // RES
            // 
            RES.AutoSize = true;
            RES.Location = new Point(40, 301);
            RES.Name = "RES";
            RES.Size = new Size(69, 15);
            RES.TabIndex = 3;
            RES.Text = "RESPUESTA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Cascadia Code PL", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(370, 82);
            label2.Name = "label2";
            label2.Size = new Size(368, 221);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Vector1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(RES);
            Controls.Add(EJECUTAR);
            Controls.Add(textBox1);
            Controls.Add(TITLE);
            Name = "Vector1";
            Text = "Vector1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TITLE;
        private TextBox textBox1;
        private Button EJECUTAR;
        private Label RES;
        private Label label2;
    }
}