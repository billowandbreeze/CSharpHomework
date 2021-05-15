using OrderManageSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*初始化数据库语句
            using (var oc = new OrderContext())
            {
                var client = new Client("0002", "狗");

                var good1 = new Good("0002", "骨头", 10);
                var good2 = new Good("0003", "生骨肉", 50);

                var orderdetail1 = new OrderDetail("0002", good1, 2);
                var orderdetail2 = new OrderDetail("0003", good2, 1);
                var order = new Order("0002", client);
                order.OrderDetails.Add(orderdetail1);
                order.OrderDetails.Add(orderdetail2);

                oc.Orders.Add(order);

                try
                {
                    oc.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                

                OrderService orderService = new OrderService();

                var client = new Client("0003", "兔子");

                var good1 = new Good("0004", "胡萝卜", 2);
                var good2 = new Good("0005", "白菜", 1);

                var orderdetail1 = new OrderDetail("0004", good1, 10);
                var orderdetail2 = new OrderDetail("0005", good2, 20);

                var order = new Order("0003", client);


                Console.WriteLine("操作成功");
                Console.Read();
            }
            */

            OrderService orderService = new OrderService();

            var client = new Client("0003", "兔子");

            var good1 = new Good("0004", "胡萝卜", 2);
            var good2 = new Good("0005", "白菜", 1);

            var orderdetail1 = new OrderDetail("0004", good1, 10);
            var orderdetail2 = new OrderDetail("0005", good2, 20);

            var order = new Order("0003", client);

            order.AddDetails(orderdetail1);
            order.AddDetails(orderdetail2);


            var newClient = new Client("0004", "麻雀");
            var newGood = new Good("0006", "面包", 10);
            var newOrderdetail = new OrderDetail("0004", newGood, 1);
            var newOrder = new Order("0003", newClient);
            newOrder.AddDetails(newOrderdetail);

            //已完成测试
            //orderService.AddOrder(order);
            //orderService.RemoveOrder(order);
            //orderService.ChangeOrder(order, newOrder);

            Console.WriteLine("完成");
            Console.ReadKey();
        }
    }
}
