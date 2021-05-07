using System;
using System.Windows.Forms;
using CrawlerSpace;
using System.Threading;

namespace CrawlerForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.cnblogs.com/dstang2000/";
            textBox2.Text = "https://www.baidu.com/";
            textBox3.Text = "https://www.cnblogs.com/";
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            Crawler crawler1 = new Crawler();
            Crawler crawler2 = new Crawler();
            Crawler crawler3 = new Crawler();

            ThreadStart start1 = new ThreadStart(() => crawler1.selectEndURLS(textBox1.Text));
            Thread thread1 = new Thread(start1);
            thread1.Start();

            ThreadStart start2 = new ThreadStart(() => crawler2.selectEndURLS(textBox2.Text));
            Thread thread2 = new Thread(start2);
            thread2.Start();

            ThreadStart start3 = new ThreadStart(() => crawler3.selectEndURLS(textBox3.Text));
            Thread thread3 = new Thread(start3);
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            richTextBox1.Text = crawler1.ToString();
            richTextBox2.Text = crawler2.ToString();
            richTextBox3.Text = crawler3.ToString();

            crawler1.urls.Clear();
            crawler2.urls.Clear();
            crawler3.urls.Clear();
        }
    }
}
