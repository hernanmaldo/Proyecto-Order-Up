namespace Front.Formulario
{
    partial class Postres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Postres));
            pictureBox1 = new PictureBox ();
            pictureBox2 = new PictureBox ();
            pictureBox3 = new PictureBox ();
            pictureBox4 = new PictureBox ();
            button1 = new Button ();
            numericUpDown1 = new NumericUpDown ();
            comboBox1 = new ComboBox ();
            label4 = new Label ();
            label1 = new Label ();
            label2 = new Label ();
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
            pictureBox1.Location = new Point (-5, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (806, 448);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject ("pictureBox2.Image");
            pictureBox2.Location = new Point (44, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size (146, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject ("pictureBox3.Image");
            pictureBox3.Location = new Point (44, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size (146, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject ("pictureBox4.Image");
            pictureBox4.Location = new Point (44, 310);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size (146, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point (663, 97);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 22;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point (386, 151);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size (120, 23);
            numericUpDown1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (385, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (121, 23);
            comboBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Location = new Point (361, 24);
            label4.Name = "label4";
            label4.Size = new Size (112, 15);
            label4.TabIndex = 19;
            label4.Text = "Seleccionar Comida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Location = new Point (259, 199);
            label1.Name = "label1";
            label1.Size = new Size (31, 15);
            label1.TabIndex = 18;
            label1.Text = "2300";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point (259, 100);
            label2.Name = "label2";
            label2.Size = new Size (31, 15);
            label2.TabIndex = 17;
            label2.Text = "1000";
            // 
            // Postres
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (button1);
            Controls.Add (numericUpDown1);
            Controls.Add (comboBox1);
            Controls.Add (label4);
            Controls.Add (label1);
            Controls.Add (label2);
            Controls.Add (pictureBox4);
            Controls.Add (pictureBox3);
            Controls.Add (pictureBox2);
            Controls.Add (pictureBox1);
            Name = "Postres";
            Text = "Postres";
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
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}