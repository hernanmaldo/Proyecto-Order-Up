namespace Front.Formulario
{
    partial class Comida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Comida));
            pictureBox1 = new PictureBox ();
            pictureBox2 = new PictureBox ();
            pictureBox3 = new PictureBox ();
            pictureBox4 = new PictureBox ();
            label2 = new Label ();
            label1 = new Label ();
            label3 = new Label ();
            label4 = new Label ();
            button1 = new Button ();
            numericUpDown1 = new NumericUpDown ();
            comboBox1 = new ComboBox ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (801, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (31, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (121, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject ("pictureBox3.Image");
            pictureBox3.Location = new Point (31, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size (121, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject ("pictureBox4.Image");
            pictureBox4.Location = new Point (31, 294);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size (121, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point (208, 107);
            label2.Name = "label2";
            label2.Size = new Size (31, 15);
            label2.TabIndex = 10;
            label2.Text = "1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Location = new Point (208, 206);
            label1.Name = "label1";
            label1.Size = new Size (31, 15);
            label1.TabIndex = 11;
            label1.Text = "2300";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Location = new Point (208, 324);
            label3.Name = "label3";
            label3.Size = new Size (25, 15);
            label3.TabIndex = 12;
            label3.Text = "700";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Location = new Point (310, 31);
            label4.Name = "label4";
            label4.Size = new Size (112, 15);
            label4.TabIndex = 13;
            label4.Text = "Seleccionar Comida";
            // 
            // button1
            // 
            button1.Location = new Point (612, 104);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 16;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point (335, 158);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size (120, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (334, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (121, 23);
            comboBox1.TabIndex = 14;
            // 
            // Comida
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (button1);
            Controls.Add (numericUpDown1);
            Controls.Add (comboBox1);
            Controls.Add (label4);
            Controls.Add (label3);
            Controls.Add (label1);
            Controls.Add (label2);
            Controls.Add (pictureBox4);
            Controls.Add (pictureBox3);
            Controls.Add (pictureBox2);
            Controls.Add (pictureBox1);
            Name = "Comida";
            Text = "Comida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit ();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}