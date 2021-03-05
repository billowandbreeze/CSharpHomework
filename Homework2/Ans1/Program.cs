using System;

namespace Ans1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Tool tool = new Tool();
            Console.WriteLine("请输入一个数字：");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("您输入的不是数字！");
                return;
            }

            tool.PrintAns(num);
        }
    }

    class Tool
    {
        public void PrintAns(int num)
        {
            int n = num;
            for(int i = 2; i <= num; i++)
            {
                if(n == 1)
                {
                    return;
                }

                if(n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                    i--;
                }
            }
        }
    }
}
