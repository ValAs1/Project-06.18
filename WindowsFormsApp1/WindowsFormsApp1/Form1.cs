﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileName;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fileName = @"C:\Users\Asatryan\Desktop\test.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Reader = new StreamReader(fileName);
            textBox1.Text = Reader.ReadToEnd();
            Reader.Close();
        }
    }
}
