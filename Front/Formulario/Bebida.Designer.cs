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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit ();
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
            // Bebida
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject ("$this.BackgroundImage");
            ClientSize = new Size (1055, 538);
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
            ResumeLayout (false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}