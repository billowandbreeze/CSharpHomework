using System;

namespace Ans1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*测试代码
            Rect r = new Rect(10, 20);
            Sqare s = new Sqare(10);
            Circle c = new Circle(10);
            Triangle t1 = new Triangle(3, 4, 5);
            Triangle t2 = new Triangle(3, 4, 8);

            Console.WriteLine("它们是否是合法形状");
            Console.WriteLine("长方形：" + r.IsLegal());
            Console.WriteLine("正方形：" + s.IsLegal());
            Console.WriteLine("圆形：" + c.IsLegal());
            Console.WriteLine("三角形1：" + t1.IsLegal());
            Console.WriteLine("三角形2：" + t2.IsLegal());

            Console.WriteLine();
            Console.WriteLine("它们的面积是");
            Console.WriteLine("长方形：" + r.Area);
            Console.WriteLine("正方形：" + s.Area);
            Console.WriteLine("圆形：" + c.Area);
            Console.WriteLine("三角形1：" + t1.Area);*/

            Factory factory = new Factory();
            Console.WriteLine(factory.GetSumArea());
        }
    }

    interface Shape {
        double Area { get; }
        bool IsLegal();
    }

    class Rect : Shape{
        protected double length;
        protected double width;
        protected double area = 0;

        public Rect(double length, double width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public bool IsLegal()
        {
            if(length <= 0 || width <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Sqare : Rect{
        public Sqare(double sideLength):base(sideLength, sideLength){ }
    }

    class Circle : Shape
    {
        private double radius;
        private double area = 0;

        public Circle(double radius)
        {
            this.radius = radius;
            area = radius * radius * 3.14;
        }

        public double Area {
            get
            {
                return area;
            }
        }

        public bool IsLegal()
        {
            if(radius <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;
        private double area = 0;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            double temp = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(temp * Math.Abs(temp - side1) * Math.Abs(temp - side2) * Math.Abs(temp - side3));
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public bool IsLegal()
        {
            if(side1 > 0 && side2 > 0 && side3 > 0)
            {
                if((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    class Factory
    {
        public Shape creatShape(int randomNum)
        {
            Shape s = null;
            Random r = new Random();

            if(randomNum == 0)
            {
                Console.WriteLine("随机产生图形：长方形");

                do
                {
                    int length = r.Next() % 11;
                    int width = r.Next() % 11;
                    s = new Rect(length, width);
                } while (!s.IsLegal());

                Console.WriteLine("面积为" + s.Area);
            }
            else if(randomNum == 1)
            {
                Console.WriteLine("随机产生图形：正方形");

                do
                {
                    int side = r.Next() % 11;
                    s = new Sqare(side);
                } while (!s.IsLegal());

                Console.WriteLine("面积为" + s.Area);
            }
            else if(randomNum == 2)
            {
                Console.WriteLine("随机产生图形：圆形");

                do
                {
                    int radius = r.Next() % 11;
                    s = new Circle(radius);
                } while (!s.IsLegal());

                Console.WriteLine("面积为" + s.Area);
            }
            else if(randomNum == 3)
            {
                Console.WriteLine("随机产生图形：三角形");

                do
                {
                    int side1 = r.Next() % 11;
                    int side2 = r.Next() % 11;
                    int side3 = r.Next() % 11;

                    s = new Triangle(side1, side2, side3);
                } while (!s.IsLegal());

                Console.WriteLine("面积为" + s.Area);
            }

            return s;
        }

        public double GetSumArea()
        {
            double sumArea = 0;
            Random seed = new Random();

            for(int i = 0; i < 10; i++)
            {
                int randomNum = seed.Next() % 4;
                sumArea += this.creatShape(randomNum).Area;
            }

            return sumArea;
        }
    }
}
