using System;

namespace Ans3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool tool = new Tool();
            tool.PrintPrime(1000);
        }
    }

    class Tool
    {
        public void PrintPrime(int last)
        {
            int[] isPrime = new int[last + 1];

            for(int i = 2; i <= Math.Sqrt(last); i++)
            {
                //减少循环次数
                for (int j = 2 * i; j < last + 1; j += i)
                {
                    isPrime[j] = 1;
                }
            }

            for(int i = 2; i < last + 1; i++)
            {
                if(isPrime[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
