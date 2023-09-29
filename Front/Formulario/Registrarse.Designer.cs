namespace Front.Formulario
{
    partial class Registrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Registrarse));
            pictureBox1 = new PictureBox ();
            button1 = new Button ();
            label4 = new Label ();
            label2 = new Label ();
            label3 = new Label ();
            label5 = new Label ();
            label6 = new Label ();
            textBox2 = new TextBox ();
            textBox3 = new TextBox ();
            textBox4 = new TextBox ();
            textBox5 = new TextBox ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (806, 448);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point (565, 203);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 22;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Location = new Point (309, 34);
            label4.Name = "label4";
            label4.Size = new Size (83, 15);
            label4.TabIndex = 19;
            label4.Text = "Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point (288, 102);
            label2.Name = "label2";
            label2.Size = new Size (110, 15);
            label2.TabIndex = 17;
            label2.Text = "Ingrese su Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point (288, 157);
            label3.Name = "label3";
            label3.Size = new Size (110, 15);
            label3.TabIndex = 23;
            label3.Text = "Ingrese su Apellido:";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Location = new Point (288, 211);
            label5.Name = "label5";
            label5.Size = new Size (95, 15);
            label5.TabIndex = 24;
            label5.Text = "Ingrese su Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Location = new Point (288, 267);
            label6.Name = "label6";
            label6.Size = new Size (126, 15);
            label6.TabIndex = 25;
            label6.Text = "Ingrese su Contraseña:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point (443, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size (100, 23);
            textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point (443, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size (100, 23);
            textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point (443, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size (100, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point (443, 259);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size (100, 23);
            textBox5.TabIndex = 30;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (textBox5);
            Controls.Add (textBox4);
            Controls.Add (textBox3);
            Controls.Add (textBox2);
            Controls.Add (label6);
            Controls.Add (label5);
            Controls.Add (label3);
            Controls.Add (button1);
            Controls.Add (label4);
            Controls.Add (label2);
            Controls.Add (pictureBox1);
            Name = "Registrarse";
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}