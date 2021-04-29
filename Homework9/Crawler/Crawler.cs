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
    public class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public String res
        {
            get;
            set;
        }

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

        /*教材爬虫程序*/
        public void Crawl()
        {
            res = "开始爬行了.... ";

            while (true)
            {
                string current = FindUrl();

                if (current == null || count > 50)
                {
                    break;
                }

                res += "\n爬行" + current + "页面!";

                //获得当前网址
                string html = DownLoad(current); 

                //设置网址当前值为true，表示已经访问过
                urls[current] = true;

                //访问网址数加一
                count++;

                //解析
                Parse(html);
            }

            res += "\n爬行结束";
        }

        /*修改爬虫程序：仅爬取当前页面*/
        public void Crawl1()
        {
            res = "开始爬行了.... ";
            string start = FindUrl();
            res += "\n爬行" + start + "页面!";

            string html = DownLoad(start);
            urls[start] = true;
            count++;
            Parse(html);


            while (true)
            {
                string current = FindUrl();

                if (current == null || count > 50)
                {
                    break;
                }

                Console.WriteLine("爬行" + current + "页面!");
                html = DownLoad(current);
                urls[current] = true;
                count++;
            }

            res += "爬行结束了";
        }

        /*修改爬虫程序：仅爬取html、jsp、aspx*/
        public void Crawl2()
        {
            res = "开始爬行了.... ";

            while (true)
            {
                string current = FindUrl();

                if (current == null || count > 50)
                {
                    break;
                }

                res += "\n爬行" + current + "页面!";
                string html = DownLoad(current);
                urls[current] = true;
                count++;
                Parse1(html);
            }

            res += "\n爬行结束";
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

        private void Parse1(string html)
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

                if (strRef.ToString().EndsWith(".jsp") || strRef.ToString().EndsWith(".html") || strRef.ToString().EndsWith(".aspx"))
                {
                    if (urls[strRef] == null)
                    {
                        urls[strRef] = false;
                    }
                }
            }
        }

        /*相对地址转化为绝对地址???*/
        public static void GetUrlListBHtml(string text, string pre)
        {
            string pat = @" (?<=href\s*=)(?:[ \s""']*)(?!#|mailto|location.|javascript|.*css|.*this\.)[^""']*(?:[ \s>""']) ";
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(text);

            while (m.Success)
            {
                string urlX = m.Value.Replace(" \"" , "" );
                 if (urlX.IndexOf(" / ") == 0) // 相对地址
                {
                    Console.WriteLine(" 原地址是 " + urlX);
                    Console.WriteLine(" 新的绝对地址是 " + pre + urlX);
                }
                m = m.NextMatch();
            }
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
    }
}
