using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;

namespace CrawlerSpace
{
    public class Crawler
    {
        public Queue<String> urls = new Queue<string>();

        //读取网页上的所有信息
        public string getHttp(String URL)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(URL);
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 20000;

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);

            String res = streamReader.ReadToEnd();

            streamReader.Close();
            httpWebResponse.Close();

            return res;
        }

        //筛选所有网址
        public void selectURLS(String URL)
        {
            string html = getHttp(URL);

            string expression = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(expression).Matches(html);

            foreach (Match match in matches)
            {
                String url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');

                if (expression.Length == 0)
                {
                    continue;
                }

                urls.Enqueue(url);
            }
        }

        //筛选固定结尾网址
        public void selectEndURLS(String URL)
        {
            string html = getHttp(URL);

            string expression = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(expression).Matches(html);

            foreach (Match match in matches)
            {
                String url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');

                if (expression.Length == 0)
                {
                    continue;
                }

                if (url.ToString().EndsWith(".jsp") || url.ToString().EndsWith(".html") || url.ToString().EndsWith(".aspx"))
                {
                    urls.Enqueue(url);
                }
            }
        }

        //遍历访问
        public void selectAll(String URL)
        {
            int count = 0;
            selectEndURLS(URL);

            Queue<String> temp = new Queue<string>();

            while (true)
            {
                if (urls.Count == 0 || count > 20)
                {
                    break;
                }

                String tempUrl = urls.Dequeue();
                temp.Enqueue(tempUrl);
                count++;


                selectEndURLS(tempUrl);

            }

            foreach(String s in temp)
            {
                urls.Enqueue(s);
            }
            temp.Clear();
        }

        public override string ToString()
        {
            String res = "";

            foreach (String url in urls)
            {
                res = res + url + "\n";
            }

            return res;
        }
    }
}
