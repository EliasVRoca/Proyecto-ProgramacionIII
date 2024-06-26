namespace Proyecto_ProgramacionIII.Cadena
{
    partial class Cadena4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadena4));
            label1 = new Label();
            Respuesta = new Label();
            Ejecutar = new Button();
            Entrada = new TextBox();
            Title = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Cascadia Code PL", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(376, 123);
            label1.Name = "label1";
            label1.Size = new Size(384, 180);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Respuesta
            // 
            Respuesta.AutoSize = true;
            Respuesta.Font = new Font("Cascadia Code PL", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Respuesta.Location = new Point(67, 330);
            Respuesta.Name = "Respuesta";
            Respuesta.Size = new Size(100, 21);
            Respuesta.TabIndex = 8;
            Respuesta.Text = "Respuesta:";
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(90, 229);
            Ejecutar.Margin = new Padding(3, 2, 3, 2);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(145, 38);
            Ejecutar.TabIndex = 7;
            Ejecutar.Text = "Ejecutar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // Entrada
            // 
            Entrada.Location = new Point(67, 123);
            Entrada.Margin = new Padding(3, 2, 3, 2);
            Entrada.Multiline = true;
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(212, 57);
            Entrada.TabIndex = 6;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(136, 9);
            Title.Name = "Title";
            Title.Size = new Size(496, 42);
            Title.TabIndex = 5;
            Title.Text = "Escribir un proceso la cual elimine la primetra letra \r\nde cada palabra\r\n";
            // 
            // Cadena4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Respuesta);
            Controls.Add(Ejecutar);
            Controls.Add(Entrada);
            Controls.Add(Title);
            Name = "Cadena4";
            Text = "Cadena4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Respuesta;
        private Button Ejecutar;
        private TextBox Entrada;
        private Label Title;
    }
}