namespace Front.Formulario
{
    partial class InicioAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (InicioAdministrador));
            panel1 = new Panel ();
            pictureBox1 = new PictureBox ();
            button1 = new Button ();
            button2 = new Button ();
            button3 = new Button ();
            pictureBox2 = new PictureBox ();
            panel1.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            SuspendLayout ();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add (button2);
            panel1.Controls.Add (button1);
            panel1.Location = new Point (-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size (192, 449);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (800, 449);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point (28, 124);
            button1.Name = "button1";
            button1.Size = new Size (120, 31);
            button1.TabIndex = 2;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point (28, 207);
            button2.Name = "button2";
            button2.Size = new Size (120, 34);
            button2.TabIndex = 3;
            button2.Text = "Ver Reporte";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point (652, 342);
            button3.Name = "button3";
            button3.Size = new Size (75, 23);
            button3.TabIndex = 4;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (188, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (438, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // InicioAdministrador
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size (800, 450);
            Controls.Add (pictureBox2);
            Controls.Add (button3);
            Controls.Add (panel1);
            Controls.Add (pictureBox1);
            Name = "InicioAdministrador";
            Text = "InicioAdministrador";
            panel1.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ResumeLayout (false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox2;
    }
}