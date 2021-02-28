using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 0;
            double d2 = 0;
            Console.WriteLine("————计算器————");
            Console.WriteLine("请输入第一个操作数：");
            try
            {
                d1 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("数字格式不正确");
                return;
            }

            Console.WriteLine("请输入第二个操作数：");
            try
            {
                d2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("数字格式不正确");
                return;
            }

            Console.WriteLine("请输入操作符：");
            string s = Console.ReadLine();

            double res = 0;

            switch (s)
            {
                case "+":
                    res = d1 + d2;
                    break;
                case "-":
                    res = d1 - d2;
                    break;
                case "*":
                    res = d1 * d2;
                    break;
                case "/":
                    res = d1 / d2;
                    break;
                case "%":
                    res = d1 % d2;
                    break;
                default:
                    Console.WriteLine("您输入的符号无法识别");
                    return;
            }

            Console.WriteLine("计算结果为：{0}", res);
        }
    }
}
