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
        int n1;
        int n2;
        string option;
        int a;
       

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            n1 = Convert.ToInt32(textBox1.Text);
            option = "+";
            textBox1.Text=("");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            option = "-";
            textBox1.Text = ("");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            option = "/";
            textBox1.Text = ("");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            option = "*";
            textBox1.Text = ("");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToInt32(textBox1.Text);
            if (option == "+")
            {
                textBox1.Text = (n1+n2).ToString();
            }
            else if (option == "-")
            {
                textBox1.Text = (n1 - n2).ToString();
            }
            else if (option == "*")
            {
                textBox1.Text = (n1 * n2).ToString();
            }
            else if (option == "/")
            {
                textBox1.Text = (n1 / n2).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            a = a + 1;
            textBox1.Text = a.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            a = a - 1;
            textBox1.Text = a.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {



        }
    }
}
