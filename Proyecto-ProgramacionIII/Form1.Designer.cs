namespace Proyecto_ProgramacionIII
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            eliasToolStripMenuItem = new ToolStripMenuItem();
            abelToolStripMenuItem = new ToolStripMenuItem();
            joseToolStripMenuItem = new ToolStripMenuItem();
            Titulo = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eliasToolStripMenuItem, abelToolStripMenuItem, joseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eliasToolStripMenuItem
            // 
            eliasToolStripMenuItem.Name = "eliasToolStripMenuItem";
            eliasToolStripMenuItem.Size = new Size(42, 20);
            eliasToolStripMenuItem.Text = "Elias";
            // 
            // abelToolStripMenuItem
            // 
            abelToolStripMenuItem.Name = "abelToolStripMenuItem";
            abelToolStripMenuItem.Size = new Size(43, 20);
            abelToolStripMenuItem.Text = "Abel";
            // 
            // joseToolStripMenuItem
            // 
            joseToolStripMenuItem.Name = "joseToolStripMenuItem";
            joseToolStripMenuItem.Size = new Size(41, 20);
            joseToolStripMenuItem.Text = "Jose";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Cascadia Code PL", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(247, 205);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(309, 25);
            Titulo.TabIndex = 1;
            Titulo.Text = "PROGRAMACIÓN III - PROYECTO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eliasToolStripMenuItem;
        private ToolStripMenuItem abelToolStripMenuItem;
        private ToolStripMenuItem joseToolStripMenuItem;
        private Label Titulo;
    }
}
