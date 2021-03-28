using System;

namespace OrderManageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------商品们----------------------
            Good good1 = new Good("Sport Shoes", 200);
            Good good2 = new Good("Water", 2);
            Good good3 = new Good("Dress", 300);
            Good good4 = new Good("Book", 39);
            Good good5 = new Good("Smart Phone", 6000);

            //----------------------顾客们----------------------
            Client client1 = new Client("John");
            Client client2 = new Client("Sherlock");
            Client client3 = new Client("Molly");

            //----------------------订单明细们----------------------
            OrderDetails orderDetails1 = new OrderDetails(good1, 1);
            OrderDetails orderDetails2 = new OrderDetails(good2, 10);
            OrderDetails orderDetails3 = new OrderDetails(good3, 2);
            OrderDetails orderDetails4 = new OrderDetails(good4, 3);
            OrderDetails orderDetails5 = new OrderDetails(good5, 1);

            //----------------------订单们----------------------
            Order order1 = new Order("0001", client1);
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order1.AddDetails(orderDetails4);

            //order1.ShowDetails();

            OrderDetails temp = order1.FindDetails(good2);
            order1.ChangeDetails(temp, good5, 2);

            //Console.WriteLine();
            //order1.ShowDetails();

            order1.RemoveDetails(temp);

            //Console.WriteLine();
            //order1.ShowDetails();

            order1.AddDetails(orderDetails1);
            //Console.WriteLine();
            //order1.ShowDetails();

            Order order2 = new Order("0002", client2);
            order2.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails5);

            Order order3 = new Order("0003", client3);
            order3.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails4);

            Order order4 = new Order("0004", client1);
            order4.AddDetails(orderDetails1);
            order4.AddDetails(orderDetails1);

            //----------------------订单服务----------------------
            Console.WriteLine("\nOrderService:");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.AddOrder(order4);
            orderService.ShowOrder();

            Console.WriteLine("---------查询订单号为0002的订单---------");
            orderService.FindOrderById("0002");

            Console.WriteLine("---------查询顾客1的订单---------");
            orderService.FindOrderByClient(client1);

            Console.WriteLine("---------查询订单金额为1117的订单---------");
            orderService.FindOrderByPrize(1117);
        }
    }
}
