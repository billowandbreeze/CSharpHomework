using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caylay
{
    public partial class Form1 : Form
    {
        private Graphics graphics;

        private double per1;
        private double per2;

        private double th1;
        private double th2;

        private Pen penColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            double leng = double.Parse(textBox2.Text);

            per1 = double.Parse(comboBox1.Text);
            per2 = double.Parse(comboBox2.Text);

            th1 = double.Parse(comboBox3.Text);
            th2 = double.Parse(comboBox4.Text);

            if (radioButton1.Checked)
            {
                penColor = Pens.Black;
            }else if (radioButton2.Checked)
            {
                penColor = Pens.Blue;
            }else if (radioButton3.Checked)
            {
                penColor = Pens.Pink;
            }
            else if (radioButton4.Checked)
            {
                penColor = Pens.Yellow;
            }
            else if (radioButton5.Checked)
            {
                penColor = Pens.Purple;
            }
            else if (radioButton6.Checked)
            {
                penColor = Pens.Red;
            }

            if (graphics == null)
            {
                graphics = panel1.CreateGraphics();
                drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
            }
            else
            {
                graphics.Clear(Color.White);
                graphics = panel1.CreateGraphics();
                drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
            }
        }

        private void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if(n == 0)
            {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(penColor, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
