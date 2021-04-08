using NUnit.Framework;
using System.Collections.Generic;
using OrderManageSystem;
using System.Xml.Serialization;
using System.IO;

namespace OrderServerTest
{
    public class Tests
    {
        private void GetOrderService(out Order order1, out Order order2, out Order order3)
        {
            Client client1 = new Client("client1");
            Client client2 = new Client("client2");
            Client client3 = new Client("client3");

            Good good1 = new Good("good1", 1);
            Good good2 = new Good("good2", 2);
            Good good3 = new Good("good2", 3);

            OrderDetails orderDetails1 = new OrderDetails(good1, 1);
            OrderDetails orderDetails2 = new OrderDetails(good2, 2);
            OrderDetails orderDetails3 = new OrderDetails(good3, 3);

            order1 = new Order("0001", client1);
            order2 = new Order("0002", client2);
            order3 = new Order("0003", client3);
            

            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);

            order2.AddDetails(orderDetails2);

            order3.AddDetails(orderDetails3);
        }

        [Test]
        public void TestAdd()
        {
            Order order1;
            Order order2;
            Order order3;

            GetOrderService(out order1, out order2, out order3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            List<Order> orderTest = new List<Order>();
            orderTest.Add(order1);
            orderTest.Add(order2);

            Assert.AreEqual(orderService.orders, orderTest);
        }

        [Test]
        public void TestRemove()
        {
            Order order1;
            Order order2;
            Order order3;

            GetOrderService(out order1, out order2, out order3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.RemoveOrder(order1);

            List<Order> orderTest = new List<Order>();
            orderTest.Add(order1);
            orderTest.Add(order2);
            orderTest.Remove(order1);

            Assert.AreEqual(orderService.orders, orderTest);
        }

        [Test]
        public void TestChange()
        {
            Order order1;
            Order order2;
            Order order3;

            GetOrderService(out order1, out order2, out order3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.ChangeOrder(order1, order3);

            List<Order> orderTest = new List<Order>();
            orderTest.Add(order2);
            orderTest.Add(order3);

            Assert.AreEqual(orderService.orders, orderTest);
        }

        [Test]
        public void TestFind()
        {
            Order order1;
            Order order2;
            Order order3;

            GetOrderService(out order1, out order2, out order3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            Assert.AreEqual(orderService.FindOrder("0002"), order2);
        }

        [Test]
        public void TestExport()
        {
            Order order1;
            Order order2;
            Order order3;

            GetOrderService(out order1, out order2, out order3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.Export();

            FileStream fs1 = new FileStream("order.xml", FileMode.Open);
            FileStream fs2 = new FileStream("test.xml", FileMode.Open);

            Assert.AreEqual(fs1, fs2);
        }

        [Test]
        public void TestImport()
        {
            Order order1;
            Order order2;
            Order order3;

            GetOrderService(out order1, out order2, out order3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.Export();

            List<Order> o = orderService.Import();

            List<Order> orderTest = new List<Order>();
            orderTest.Add(order1);
            orderTest.Add(order2);

            Assert.AreEqual(o, orderTest);
        }
    }
}