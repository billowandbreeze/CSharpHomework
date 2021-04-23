﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();

            string startUrl = "http://www.cnblogs.com/dstang2000/";

            //加入初始界面，设置初始值为false
            crawler.URLS.Add(startUrl, false);

            //crawler.Crawl();

            //new Thread(crawler.Crawl).Start();

            new Thread(crawler.CrawlerOnlyCurrent).Start();

            Console.ReadKey();
        }
    }
}
