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

            string startUrl = textBox1.Text;

            //加入初始界面，设置初始值为false
            crawler.URLS.Add(startUrl, false);

            crawler.Crawl();

            richTextBox1.Text = crawler.res;
        }

        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();

            string startUrl = textBox1.Text;

            //加入初始界面，设置初始值为false
            crawler.URLS.Add(startUrl, false);

            crawler.Crawl1();

            richTextBox1.Text = crawler.res;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();

            string startUrl = textBox1.Text;

            //加入初始界面，设置初始值为false
            crawler.URLS.Add(startUrl, false);

            crawler.Crawl2();

            richTextBox1.Text = crawler.res;
        }
    }
}
