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
        }
        string fileName;
        private void Form1_Load(object sender, EventArgs e)
        {
            fileName = @"C:\Users\Asatryan\Desktop\test.txt";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                //var Reader = new StreamReader(fileName);
                //textBox1.Text = Reader.ReadToEnd();
                //Reader.Close();
                var Writer = new StreamWriter(fileName);
            
                //Writer.Write(textBox1.Text);
                //Writer.Write(textBox2.Text);
                //Writer.Write(textBox3.Text);
                // Writer.Write(textBox4.Text);

            Writer.Write($" Имя - {textBox1.Text}\r\n Фамилия - {textBox2.Text}\r\n Телефон - {textBox3.Text}\r\n mail - {textBox4.Text}\r");
                Writer.Close();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var Reader = new StreamReader(fileName);
            textBox5.Text = Reader.ReadToEnd();
            Reader.Close();
        }
    }
}
