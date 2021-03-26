using System;

namespace OrderManageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Good good1 = new Good("Sport Shoes", 200);
            Good good2 = new Good("Water", 2);
            Good good3 = new Good("Dress", 300);
            Good good4 = new Good("Book", 39);
            Good good5 = new Good("Smart Phone", 6000);


            OrderDetails orderDetails1 = new OrderDetails(good1, 1);
            OrderDetails orderDetails2 = new OrderDetails(good2, 10);
            OrderDetails orderDetails3 = new OrderDetails(good3, 2);
            OrderDetails orderDetails4 = new OrderDetails(good4, 3);
            OrderDetails orderDetails5 = new OrderDetails(good5, 1);

            Order order1 = new Order();
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order1.AddDetails(orderDetails4);

            order1.ShowDetails();

            OrderDetails temp = order1.FindDetails(good2);
            order1.ChangeDetails(temp, good5, 2);

            Console.WriteLine();
            order1.ShowDetails();
            order1.RemoveDetails(temp);

            Console.WriteLine();
            order1.ShowDetails();

            order1.AddDetails(orderDetails1);
            Console.WriteLine();
            order1.ShowDetails();

            Order order2 = new Order();
            order2.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails5);

            Console.WriteLine("\nOrderService:");
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.ShowOrder();
        }
    }
}
