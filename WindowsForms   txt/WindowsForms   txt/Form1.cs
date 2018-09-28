using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsForms___txt
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
           fileName = @"C:\Users\KIP\Desktop\test.txt";
            //string path = @"C:\Users\KIP\Desktop";
            //string fileName = $@"{path}\test.txt";
           // var file = new FileInfo(fileName);

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                var Reader = new StreamReader(fileName);
                textBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            catch (FileNotFoundException Situation)
            {
                MessageBox.Show(Situation.Message + "\n" + "Ошибка", "файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception Situation)
            {
                MessageBox.Show(Situation.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var Writer = new StreamWriter(fileName, false);
                Writer.Write(textBox1.Text);
                Writer.Close();
            }
            catch(Exception Situation)
            {
                MessageBox.Show(Situation.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
