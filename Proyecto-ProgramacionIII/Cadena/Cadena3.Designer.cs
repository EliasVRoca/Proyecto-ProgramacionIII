namespace Proyecto_ProgramacionIII.Cadena
{
    partial class Cadena3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadena3));
            code = new Label();
            Respuesta = new Label();
            button1 = new Button();
            Entrada = new TextBox();
            Title = new Label();
            SuspendLayout();
            // 
            // code
            // 
            code.AutoSize = true;
            code.BackColor = SystemColors.ControlDarkDark;
            code.Font = new Font("Cascadia Code PL", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            code.ForeColor = Color.White;
            code.Location = new Point(380, 71);
            code.Name = "code";
            code.Size = new Size(378, 288);
            code.TabIndex = 9;
            code.Text = resources.GetString("code.Text");
            // 
            // Respuesta
            // 
            Respuesta.AutoSize = true;
            Respuesta.Font = new Font("Cascadia Code PL", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Respuesta.Location = new Point(46, 322);
            Respuesta.Name = "Respuesta";
            Respuesta.Size = new Size(100, 21);
            Respuesta.TabIndex = 8;
            Respuesta.Text = "RESPUESTA:";
            // 
            // button1
            // 
            button1.Location = new Point(67, 205);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(160, 38);
            button1.TabIndex = 7;
            button1.Text = "Probar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Entrada
            // 
            Entrada.Location = new Point(46, 97);
            Entrada.Margin = new Padding(3, 2, 3, 2);
            Entrada.Multiline = true;
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(211, 61);
            Entrada.TabIndex = 6;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(169, 9);
            Title.Name = "Title";
            Title.Size = new Size(415, 42);
            Title.TabIndex = 5;
            Title.Text = "ESCRIBIR UNA FUNCION QUE DEVUELBA LA PALABRA \r\nMAS LARGA\r\n";
            // 
            // Cadena3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(code);
            Controls.Add(Respuesta);
            Controls.Add(button1);
            Controls.Add(Entrada);
            Controls.Add(Title);
            Name = "Cadena3";
            Text = "Cadena3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label code;
        private Label Respuesta;
        private Button button1;
        private TextBox Entrada;
        private Label Title;
    }
}