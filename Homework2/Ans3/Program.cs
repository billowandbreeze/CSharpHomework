using System;

namespace Ans3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool tool = new Tool();
            tool.PrintPrime();
        }
    }

    class Tool
    {
        public void PrintPrime()
        {
            int[] isPrime = new int[101];

            for(int i = 2; i < 101; i++)
            {
                //减少循环次数
                for (int j = 2 * i; j < 101; j += i)
                {
                    isPrime[j] = 1;
                }
            }

            for(int i = 2; i < 101; i++)
            {
                if(isPrime[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
