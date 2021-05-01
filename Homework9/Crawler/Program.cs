using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace CrawlerSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            string s = crawler.getHttp("http://www.cnblogs.com/dstang2000/");

            Console.WriteLine("获得网页...");
            //Console.WriteLine(s);

            //crawler.selectURLS(s);
            //crawler.selectEndURLS(s);

            crawler.selectAll(s);

            Console.WriteLine(crawler.ToString());

            /*
            foreach(String url in crawler.urls)
            {
                Console.WriteLine(url);
            }
            */

            Console.WriteLine("爬取完成...");

            Console.ReadLine();
        }
    }
}
