﻿namespace Front
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (Form1));
            pictureBox1 = new PictureBox ();
            label1 = new Label ();
            label2 = new Label ();
            label3 = new Label ();
            textBox1 = new TextBox ();
            textBox2 = new TextBox ();
            label4 = new Label ();
            label5 = new Label ();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit ();
            SuspendLayout ();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject ("pictureBox1.Image");
            pictureBox1.Location = new Point (12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size (798, 445);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font ("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point (196, 18);
            label1.Name = "label1";
            label1.Size = new Size (430, 36);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO A ORDER UP!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font ("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point (46, 101);
            label2.Name = "label2";
            label2.Size = new Size (73, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Font = new Font ("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point (596, 101);
            label3.Name = "label3";
            label3.Size = new Size (175, 25);
            label3.TabIndex = 3;
            label3.Text = "Administrador";
            // 
            // textBox1
            // 
            textBox1.Location = new Point (596, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size (166, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point (596, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size (175, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point (596, 164);
            label4.Name = "label4";
            label4.Size = new Size (131, 21);
            label4.TabIndex = 6;
            label4.Text = "Ingrese su Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font ("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point (596, 257);
            label5.Name = "label5";
            label5.Size = new Size (175, 21);
            label5.TabIndex = 7;
            label5.Text = "Ingrese su Contraseña:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (label5);
            Controls.Add (label4);
            Controls.Add (textBox2);
            Controls.Add (textBox1);
            Controls.Add (label3);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
    }
}