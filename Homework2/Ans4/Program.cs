using System;

namespace Ans4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您要输入的矩阵行数：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入您要输入的矩阵列数：");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("请依次输入您要输入的数字：");
            int[,] arr = new int[m,n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            /*int[,] arr =
            {
                {1, 2, 3, 4},
                {5, 1, 2, 3},
                {9, 5, 1, 3},
                {1, 9, 5, 1}
            };*/

            Tool tool = new Tool();
            Console.WriteLine("该矩阵是否是Toeplitz矩阵：" + tool.IsToeplitz(arr, m, n));
        }
    }

    class Tool
    {
        public bool IsToeplitz(int[,] arr, int m, int n)
        {
            if(m == 1 || n == 1)
            {
                return true;
            }

            for(int i = 1; i < m; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    if(arr[i - 1, j - 1] != arr[i, j])
                    {
                        return false;
                    }
                }
            }


            return true;

            /*繁琐版本
            对第一行检验
            for(int a = 0; a < n; a++)
            {
                int temp = arr[0,a];

                int i = 0;
                int j = a;

                while(i < m && j < n)
                {
                    if(arr[i,j] != temp)
                    {
                        return false;
                    }

                    i++;
                    j++;
                }
            }

            //对第一列检验
            for (int a = 0; a < m; a++)
            {
                int temp = arr[a,0];

                int i = a;
                int j = 0;

                while (i < m && j < n)
                {
                    if (arr[i,j] != temp)
                    {
                        return false;
                    }

                    i++;
                    j++;
                }
            }*/
        }
    }
}
