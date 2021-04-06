using System;
using System.IO;

namespace OrderManageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------商品----------------------
            Good good1 = new Good("Sport Shoes", 200);
            Good good2 = new Good("Water", 2);
            Good good3 = new Good("Dress", 300);
            Good good4 = new Good("Book", 39);
            Good good5 = new Good("Smart Phone", 6000);
            Good good6 = new Good("Computer", 10000);


            //----------------------顾客----------------------
            Client client1 = new Client("John");
            Client client2 = new Client("Sherlock");
            Client client3 = new Client("Molly");


            //----------------------订单明细----------------------
            OrderDetails orderDetails1 = new OrderDetails(good1, 1);
            OrderDetails orderDetails2 = new OrderDetails(good2, 10);
            OrderDetails orderDetails3 = new OrderDetails(good3, 2);
            OrderDetails orderDetails4 = new OrderDetails(good4, 3);
            OrderDetails orderDetails5 = new OrderDetails(good5, 1);


            //----------------------订单----------------------
            Order order1 = new Order("0001", client1);
            Order order2 = new Order("0002", client2);
            Order order3 = new Order("0003", client3);
            Order order4 = new Order("0004", client1);


            //----------------------订单管理----------------------
            OrderService orderService = new OrderService();


            //----------------------添加订单明细----------------------
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);

            order2.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails4);
            order2.AddDetails(orderDetails5);

            order3.AddDetails(orderDetails1);
            order3.AddDetails(orderDetails3);
            order3.AddDetails(orderDetails5);

            order4.AddDetails(orderDetails2);
            order4.AddDetails(orderDetails4);

            
            //----------------------添加订单----------------------
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            
            Console.WriteLine("---------按订单号升序排序功能---------");
            orderService.Orders.Sort((o1, o2) => int.Parse(o1.ID) - int.Parse(o2.ID));
            Console.WriteLine(orderService);

            Console.WriteLine("---------按订单号降序排序功能---------");
            orderService.Orders.Sort((o1, o2) => int.Parse(o2.ID) - int.Parse(o1.ID));
            Console.WriteLine(orderService);

            Console.WriteLine("---------按价格升序排序功能---------");
            orderService.Orders.Sort((o1, o2) => (int)o1.TotalPrize - (int)o2.TotalPrize);
            Console.WriteLine(orderService);

            Console.WriteLine("---------按价格降序排序功能---------");
            orderService.Orders.Sort((o1, o2) => (int)o2.TotalPrize - (int)o1.TotalPrize);
            Console.WriteLine(orderService);

            orderService.Export();

            Console.WriteLine("\nXML: ");
            Console.WriteLine(File.ReadAllText("order.xml"));

            Console.WriteLine("\n反序列化：");
            foreach(Order o in orderService.Import())
            {
                Console.WriteLine(o);
            }
        }
    }
}
