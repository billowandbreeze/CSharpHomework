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
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        public Hashtable URLS
        {
            get
            {
                return urls;
            }
        }

        public Crawler()
        {

        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");

            while (true)
            {
                string current = FindUrl();

                if (current == null || count > 50)
                {
                    break;
                }

                Console.WriteLine("爬行" + current + "页面!");

                //获得当前网址
                string html = DownLoad(current); 

                //设置网址当前值为true，表示已经访问过
                urls[current] = true;

                //访问网址数加一
                count++;

                //解析
                Parse(html);
            }

            Console.WriteLine("爬行结束");
        }

        public void CrawlerOnlyCurrent()
        {
            Console.WriteLine("开始爬行了.... ");

            string start = FindUrl();

            Console.WriteLine("爬行" + start + "页面!");

            //获得当前网址
            string html = DownLoad(start);

            //设置网址当前值为true，表示已经访问过
            urls[start] = true;

            //访问网址数加一
            count++;

            //解析
            Parse(html);


            while (true)
            {
                string current = FindUrl();

                if (current == null || count > 50)
                {
                    break;
                }

                Console.WriteLine("爬行" + current + "页面!");

                //获得当前网址
                html = DownLoad(current);

                //设置网址当前值为true，表示已经访问过
                urls[current] = true;

                //访问网址数加一
                count++;
            }

            Console.WriteLine("爬行结束了");
        }

        private String FindUrl()
        {
            foreach (string url in urls.Keys)
            {
                //如果该网址布尔值为true，跳过
                if ((bool)urls[url])
                {
                    continue;
                }

                return url;
            }

            return null;
        }

        private string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                string html = webClient.DownloadString(url);
                string fileName = count.ToString();

                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";

            MatchCollection matches = new Regex(strRef).Matches(html);

            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');

                if (strRef.Length == 0)
                {
                    continue;
                }

                if (urls[strRef] == null)
                {
                    urls[strRef] = false;
                }
            }
        }


    }
}