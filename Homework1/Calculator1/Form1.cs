using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        private double d1;
        private double d2;
        private string s;
        private double res;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            s = textBox3.Text;

            switch (s)
            {
                case "+":
                    res = d1 + d2;
                    break;
                case "-":
                    res = d1 - d2;
                    break;
                case "*":
                    res = d1 * d2;
                    break;
                case "/":
                    res = d1 / d2;
                    break;
                case "%":
                    res = d1 % d2;
                    break;
                default:
                    Console.WriteLine("您输入的符号无法识别");
                    return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("开始计算");
            label6.Text = res.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            d1 = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            d2 = double.Parse(textBox2.Text);
        }
    }
}
