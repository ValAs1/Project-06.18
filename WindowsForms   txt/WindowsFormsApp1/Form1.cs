using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            textBox1.ForeColor = Color.LightGray;
            textBox1.Text = "Please Enter Name";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = Color.LightGray;
            textBox2.Text = "Please Enter Address";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Please Enter Name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Please Enter Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
         private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Please Enter Address")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Please Enter Address";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}
//public partial class WaterMark : Form
//{
//    public WaterMark()
//    {
//        //InitializeComponent();
//        //textBox1.ForeColor = Color.LightGray;
//        //textBox1.Text = "Please Enter Name";
//        //this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
//        //this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

//        //textBox2.ForeColor = Color.LightGray;
//        //textBox2.Text = "Please Enter Address";
//        //this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
//        //this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
//    }

//    private void textBox1_Leave(object sender, EventArgs e)
//    {
//        if (textBox1.Text == "")
//        {
//            textBox1.Text = "Please Enter Name";
//            textBox1.ForeColor = Color.Gray;
//        }
//    }

//    private void textBox1_Enter(object sender, EventArgs e)
//    {
//        if (textBox1.Text == "Please Enter Name")
//        {
//            textBox1.Text = "";
//            textBox1.ForeColor = Color.Black;
//        }
//    }

//    private void textBox2_Enter(object sender, EventArgs e)
//    {
//        if (textBox2.Text == "Please Enter Address")
//        {
//            textBox2.Text = "";
//            textBox2.ForeColor = Color.Black;
//        }
//    }

//    private void textBox2_Leave(object sender, EventArgs e)
//    {
//        if (textBox2.Text == "")
//        {
//            textBox2.Text = "Please Enter Address";
//            textBox2.ForeColor = Color.Gray;
//        }
//    }
//}
//}