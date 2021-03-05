using System;

namespace Ans2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您要输入的数组长度：");
            int len = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入您要输入的数字：");
            int[] arr = new int[len];
            for(int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Tool tool = new Tool();

            Console.WriteLine("最大值为" + tool.GetMax(arr));
            Console.WriteLine("最小值为" + tool.GetMin(arr));
            Console.WriteLine("和为" + tool.GetSum(arr));
            Console.WriteLine("平均值为" + tool.GetAve(arr));
        }
    }

    class Tool
    {
        public int GetMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                return -1;
            }

            int max = arr[0];

            foreach (int a in arr)
            {
                if(a > max)
                {
                    max = a;
                }
            }

            return max;
        }

        public int GetMin(int[] arr)
        {
            if (arr.Length == 0)
            {
                return -1;
            }

            int min = arr[0];

            foreach (int a in arr)
            {
                if (a < min)
                {
                    min = a;
                }
            }

            return min;
        }

        public int GetSum(int[] arr)
        {
            if (arr.Length == 0)
            {
                return -1;
            }

            int res = 0;

            foreach (int a in arr)
            {
                res += a;
            }

            return res;
        }

        public int GetAve(int[] arr)
        {
            if (arr.Length == 0)
            {
                return -1;
            }

            int res = GetSum(arr);
            res = res / arr.Length;

            return res;
        }
    }
}
