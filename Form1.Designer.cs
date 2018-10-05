namespace Homework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rectangular = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.circum = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.farhen = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Label();
            this.cSquare = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius/Temp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length/Height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width/Base";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "33";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Area of Cicrle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // circle
            // 
            this.circle.AutoEllipsis = true;
            this.circle.AutoSize = true;
            this.circle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.circle.Location = new System.Drawing.Point(52, 133);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(40, 13);
            this.circle.TabIndex = 10;
            this.circle.Text = "Result ";
            this.circle.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Area of rectangular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rectangular
            // 
            this.rectangular.AutoEllipsis = true;
            this.rectangular.AutoSize = true;
            this.rectangular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectangular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rectangular.Location = new System.Drawing.Point(141, 133);
            this.rectangular.Name = "rectangular";
            this.rectangular.Size = new System.Drawing.Size(40, 13);
            this.rectangular.TabIndex = 12;
            this.rectangular.Text = "Result ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Area of Triangle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // triangle
            // 
            this.triangle.AutoEllipsis = true;
            this.triangle.AutoSize = true;
            this.triangle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.triangle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.triangle.Location = new System.Drawing.Point(238, 133);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(40, 13);
            this.triangle.TabIndex = 14;
            this.triangle.Text = "Result ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 15;
            this.button4.Text = "Circumference ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // circum
            // 
            this.circum.AutoEllipsis = true;
            this.circum.AutoSize = true;
            this.circum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.circum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.circum.Location = new System.Drawing.Point(344, 133);
            this.circum.Name = "circum";
            this.circum.Size = new System.Drawing.Size(40, 13);
            this.circum.TabIndex = 16;
            this.circum.Text = "Result ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 43);
            this.button5.TabIndex = 17;
            this.button5.Text = "Convert To Fahrenheit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // farhen
            // 
            this.farhen.AutoEllipsis = true;
            this.farhen.AutoSize = true;
            this.farhen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.farhen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.farhen.Location = new System.Drawing.Point(440, 133);
            this.farhen.Name = "farhen";
            this.farhen.Size = new System.Drawing.Size(40, 13);
            this.farhen.TabIndex = 18;
            this.farhen.Text = "Result ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(526, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 43);
            this.button6.TabIndex = 19;
            this.button6.Text = "Average";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // average
            // 
            this.average.AutoEllipsis = true;
            this.average.AutoSize = true;
            this.average.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.average.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.average.Location = new System.Drawing.Point(541, 133);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(40, 13);
            this.average.TabIndex = 20;
            this.average.Text = "Result ";
            // 
            // cSquare
            // 
            this.cSquare.AutoEllipsis = true;
            this.cSquare.AutoSize = true;
            this.cSquare.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cSquare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cSquare.Location = new System.Drawing.Point(664, 133);
            this.cSquare.Name = "cSquare";
            this.cSquare.Size = new System.Drawing.Size(40, 13);
            this.cSquare.TabIndex = 21;
            this.cSquare.Text = "Result ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(639, 168);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 43);
            this.button7.TabIndex = 22;
            this.button7.Text = "ptheorum";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cSquare);
            this.Controls.Add(this.average);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.farhen);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.circum);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rectangular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Text = "HomeWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label circle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label rectangular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label triangle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label circum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label farhen;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label cSquare;
        private System.Windows.Forms.Button button7;
    }
}

