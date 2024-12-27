namespace Laborator6_Endri_Gjini
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(76, 210);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 0;
            button1.Text = "Kompresim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(219, 210);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 1;
            button2.Text = "Dekompress";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 23);
            textBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(522, 84);
            button3.Name = "button3";
            button3.Size = new Size(70, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 23);
            textBox2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(522, 139);
            button4.Name = "button4";
            button4.Size = new Size(70, 23);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(336, 210);
            button5.Name = "button5";
            button5.Size = new Size(136, 23);
            button5.TabIndex = 6;
            button5.Text = "Kompress Thread";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(505, 210);
            button6.Name = "button6";
            button6.Size = new Size(146, 23);
            button6.TabIndex = 7;
            button6.Text = "Dekompress Thread";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 292);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
