using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.ForeColor = Color.LightGray;
            textBox1.Text = "Name";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = Color.LightGray;
            textBox2.Text = "Surname";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);

            textBox3.ForeColor = Color.LightGray;
            textBox3.Text = "Phone";
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);

        }
        string fileName;
        private void Form1_Load(object sender, EventArgs e)
        {
            fileName = @"C:\Users\KIP\Desktop\test.txt";

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Writer = new StreamWriter(fileName, true);
                Writer.Write($" Имя - {textBox1.Text}\r\n Фамилия - {textBox2.Text}\r\n Телефон - {textBox3.Text}\r\n mail - {textBox4.Text}\r\n");
                Writer.Close();

            }
            catch (Exception Situation)
            {
                MessageBox.Show(Situation.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //var Reader = new StreamReader(fileName);
            //textBox1.Text = Reader.ReadToEnd();
            //Reader.Close();
          ////  var Writer = new StreamWriter(fileName);
            
                //Writer.Write(textBox1.Text);
                //Writer.Write(textBox2.Text);
                //Writer.Write(textBox3.Text);
                // Writer.Write(textBox4.Text);

            ////Writer.Write($" Имя - {textBox1.Text}\r\n Фамилия - {textBox2.Text}\r\n Телефон - {textBox3.Text}\r\n mail - {textBox4.Text}\r");
            ////    Writer.Close();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var Reader = new StreamReader(fileName);
            textBox5.Text = Reader.ReadToEnd();
            Reader.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Surname";
                textBox2.ForeColor = Color.Gray;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Surname")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Phone";
                textBox3.ForeColor = Color.Gray;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Phone")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
    }
}
