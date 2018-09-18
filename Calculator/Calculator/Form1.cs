using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (znak == '√')
            {
                c = Math.Sqrt(a);
            }
            else
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;

                    case '-':
                        c = a - b;
                        break;

                    case '*':
                        c = a * b;
                        break;

                    case '/':
                        c = a / b;
                        break;
                }
            }

            textBox1.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
