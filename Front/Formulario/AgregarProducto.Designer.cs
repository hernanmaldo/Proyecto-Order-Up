namespace Front.Formulario
{
    partial class AgregarProducto
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
            button1 = new Button ();
            label1 = new Label ();
            label2 = new Label ();
            label3 = new Label ();
            label4 = new Label ();
            label5 = new Label ();
            label6 = new Label ();
            richTextBox1 = new RichTextBox ();
            textBox1 = new TextBox ();
            label7 = new Label ();
            textBox2 = new TextBox ();
            comboBox1 = new ComboBox ();
            panel1 = new Panel ();
            panel2 = new Panel ();
            panel3 = new Panel ();
            panel4 = new Panel ();
            panel5 = new Panel ();
            panel1.SuspendLayout ();
            SuspendLayout ();
            // 
            // button1
            // 
            button1.Location = new Point (214, 415);
            button1.Name = "button1";
            button1.Size = new Size (75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point (47, 27);
            label1.Name = "label1";
            label1.Size = new Size (52, 15);
            label1.TabIndex = 1;
            label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point (43, 72);
            label2.Name = "label2";
            label2.Size = new Size (56, 15);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point (43, 173);
            label3.Name = "label3";
            label3.Size = new Size (38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point (323, 173);
            label4.Name = "label4";
            label4.Size = new Size (38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point (43, 229);
            label5.Name = "label5";
            label5.Size = new Size (38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point (43, 286);
            label6.Name = "label6";
            label6.Size = new Size (38, 15);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point (561, 329);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size (192, 96);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point (150, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size (100, 23);
            textBox1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point (381, 218);
            label7.Name = "label7";
            label7.Size = new Size (38, 15);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // textBox2
            // 
            textBox2.Location = new Point (150, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size (100, 23);
            textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point (423, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size (121, 23);
            comboBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add (panel5);
            panel1.Controls.Add (panel4);
            panel1.Controls.Add (comboBox1);
            panel1.Controls.Add (richTextBox1);
            panel1.Controls.Add (panel2);
            panel1.Controls.Add (panel3);
            panel1.Location = new Point (2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size (795, 448);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Location = new Point (0, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size (792, 88);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point (3, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size (792, 41);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point (0, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size (792, 41);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point (3, 273);
            panel5.Name = "panel5";
            panel5.Size = new Size (792, 41);
            panel5.TabIndex = 3;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF (7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size (800, 450);
            Controls.Add (textBox2);
            Controls.Add (label7);
            Controls.Add (textBox1);
            Controls.Add (label6);
            Controls.Add (label5);
            Controls.Add (label4);
            Controls.Add (label3);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (button1);
            Controls.Add (panel1);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            panel1.ResumeLayout (false);
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
    }
}