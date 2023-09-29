namespace Front.Formulario
{
    partial class Bebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Bebida));
            pictureBox1 = new PictureBox ();
            pictureBox2 = new PictureBox ();
            pictureBox3 = new PictureBox ();
            pictureBox4 = new PictureBox ();
            pictureBox5 = new PictureBox ();
            label1 = new Label ();
            comboBox1 = new ComboBox ();
            numericUpDown1 = new NumericUpDown ();
            button1 = new Button ();
            label2 = new Label ();
            label3 = new Label ();
            label4 = new Label ();
            label5 = new Label ();
            label6 = new Label ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (45, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (77, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (45, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (87, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject ("pictureBox3.Image");
            pictureBox3.Location = new Point (45, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size (69, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject ("pictureBox4.Image");
            pictureBox4.Location = new Point (45, 346);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size (87, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject ("pictureBox5.Image");
            pictureBox5.Location = new Point (45, 434);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size (87, 82);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Location = new Point (294, 24);
            label1.Name = "label1";
            label1.Size = new Size (109, 15);
            label1.TabIndex = 5;
            label1.Text = "Seleccionar Bebida:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (294, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (121, 23);
            comboBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point (295, 157);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size (120, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point (572, 103);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 8;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point (143, 76);
            label2.Name = "label2";
            label2.Size = new Size (31, 15);
            label2.TabIndex = 9;
            label2.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point (143, 183);
            label3.Name = "label3";
            label3.Size = new Size (31, 15);
            label3.TabIndex = 10;
            label3.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Location = new Point (165, 298);
            label4.Name = "label4";
            label4.Size = new Size (31, 15);
            label4.TabIndex = 11;
            label4.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Location = new Point (165, 388);
            label5.Name = "label5";
            label5.Size = new Size (31, 15);
            label5.TabIndex = 12;
            label5.Text = "1000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Location = new Point (165, 475);
            label6.Name = "label6";
            label6.Size = new Size (31, 15);
            label6.TabIndex = 13;
            label6.Text = "1000";
            // 
            // Bebida
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject ("$this.BackgroundImage");
            ClientSize = new Size (1055, 538);
            Controls.Add (label6);
            Controls.Add (label5);
            Controls.Add (label4);
            Controls.Add (label3);
            Controls.Add (label2);
            Controls.Add (button1);
            Controls.Add (numericUpDown1);
            Controls.Add (comboBox1);
            Controls.Add (label1);
            Controls.Add (pictureBox5);
            Controls.Add (pictureBox4);
            Controls.Add (pictureBox3);
            Controls.Add (pictureBox2);
            Controls.Add (pictureBox1);
            Name = "Bebida";
            Text = "Bebida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}