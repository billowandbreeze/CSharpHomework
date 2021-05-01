using System;
using System.Threading;
using System.Windows.Forms;
using CrawlerSpace;

namespace CrawlerForm
{
    public partial class Form1 : Form
    {
        private Crawler crawler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.cnblogs.com/dstang2000/";
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();
            string s = crawler.getHttp(textBox1.Text);
            crawler.selectAll(s);

            richTextBox1.Text = crawler.ToString();
            crawler.urls.Clear();
        }

        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();
            string s = crawler.getHttp(textBox1.Text);
            crawler.selectURLS(s);

            richTextBox1.Text = crawler.ToString();
            crawler.urls.Clear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();
            string s = crawler.getHttp(textBox1.Text);
            crawler.selectEndURLS(s);

            richTextBox1.Text = crawler.ToString();
            crawler.urls.Clear();
        }
    }
}
