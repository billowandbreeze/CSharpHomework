using System;

namespace Ans1
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeList<int> nodeList = new NodeList<int>();
            
            for(int i = 0; i < 10; i++)
            {
                Random random = new Random(i);
                nodeList.Add(random.Next(0, 100));
            }

            nodeList.ForEach(a => Console.WriteLine(a));

            int m = nodeList.Head.val;
            nodeList.ForEach(a => m = Math.Max(a, m));
            Console.WriteLine("max = {0}", m);

            m = nodeList.Head.val;
            nodeList.ForEach(a => m = Math.Min(a, m));
            Console.WriteLine("min = {0}", m);

            int sum = 0;
            nodeList.ForEach(a => sum += a);
            Console.WriteLine("sum = {0}", sum);
        }
    }
}
