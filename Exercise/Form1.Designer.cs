
namespace Exercise
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
            this.C = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(214, 68);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(69, 45);
            this.C.TabIndex = 0;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(34, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(289, 68);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(69, 45);
            this.delete.TabIndex = 3;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.C_Click);


            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(289, 129);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(69, 45);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(289, 180);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(69, 45);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.divide_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(289, 241);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(69, 45);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.divide_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(289, 292);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(69, 45);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.divide_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(54, 241);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(69, 45);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.one_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(54, 180);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(69, 45);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.one_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(54, 129);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(69, 45);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(129, 292);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(69, 45);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.one_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(129, 241);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(69, 45);
            this.eight.TabIndex = 14;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.one_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(129, 180);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(69, 45);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(129, 129);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(69, 45);
            this.two.TabIndex = 12;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.one_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(204, 241);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(69, 45);
            this.nine.TabIndex = 18;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.one_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(204, 180);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(69, 45);
            this.six.TabIndex = 17;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(204, 129);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(69, 45);
            this.three.TabIndex = 16;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.one_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(289, 343);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(69, 45);
            this.equals.TabIndex = 20;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(204, 292);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(69, 45);
            this.dotButton.TabIndex = 21;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.divide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 397);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button dotButton;
    }
}

