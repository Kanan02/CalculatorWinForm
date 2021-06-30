using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        bool operatorPressed = false;
        bool equalPressed = false;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            MinimumSize = new Size(345, 382);
            MaximumSize = new Size(345, 382);
        }
        void DoCalculation()
        {
            
            double ans = 0;
            char sign = ' ';
            if (textBox1.Text != "")
            {
                sign = textBox1.Text[textBox1.Text.Length - 1];
            }
            switch (sign)
            {
                case '+':
                    ans = double.Parse(textBox1.Text.Substring(0, textBox1.Text.Length - 1)) + double.Parse(textBox2.Text);
                    break;
                case '-':
                    ans = double.Parse(textBox1.Text.Substring(0, textBox1.Text.Length - 1)) - double.Parse(textBox2.Text);
                    break;
                case '\\':
                    ans = double.Parse(textBox1.Text.Substring(0, textBox1.Text.Length - 1)) / double.Parse(textBox2.Text);
                    break;
                case 'X':
                    ans = double.Parse(textBox1.Text.Substring(0, textBox1.Text.Length - 1)) * double.Parse(textBox2.Text);
                    break;
                default:
                    break;
            }
            textBox2.Text = $"{ans}";

        }
        private void divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DoCalculation();
            }
            textBox1.Text = "";
            operatorPressed = true;
            textBox2.Text += (sender as Button).Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }
        private void equals_Click(object sender, EventArgs e)
        {
            if (!operatorPressed&&!equalPressed)
            {


                string last_text = textBox2.Text;
                DoCalculation();
                textBox1.Text += last_text;
                textBox1.Text += '=';
                operatorPressed = true;
                equalPressed = true;
            }
        }
        private void one_Click(object sender, EventArgs e)
        {
            if (equalPressed)
            {
                textBox1.Text = "";
            }
            if (operatorPressed)
            {
                textBox2.Text = (sender as Button).Text;
            }
            else
            {
                textBox2.Text += (sender as Button).Text;
            }
            operatorPressed = false;
            equalPressed = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text=="del")
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            else
            {
                textBox2.Text = "";
            }
        }
    }
}
