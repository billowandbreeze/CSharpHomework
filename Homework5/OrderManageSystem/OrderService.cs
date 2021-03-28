using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManageSystem
{
    class OrderService
    {
        //----------------------字段----------------------
        private List<Order> orders = new List<Order>();

        //----------------------属性----------------------
        public List<Order> Orders
        {
            get => orders;
        }

        //----------------------订单的增删改查----------------------
        public void AddOrder(Order order)
        {
            //如果已经存在相同订单，则在有错误
            foreach (Order o in orders)
            {
                if(o == order)
                {
                    Exception e = new Exception("The same order!");
                    throw e;
                }
            }

            orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            foreach (Order o in orders)
            {
                if (o == order)
                {
                    orders.Remove(o);
                    return;
                }
            }

            Exception e = new Exception("Can't remove: can't find the order!");
            throw e;
        }

        public void ChangeOrder(Order order, String id, Client client)
        {
            foreach (Order o in orders)
            {
                if (o == order)
                {
                    o.ID = id;
                    o.Client = client;
                    return;
                }
            }

            Exception e = new Exception("Can't change: can't find the order!");
            throw e;
        }

        public Order FindOrder(String id)
        {
            foreach (Order o in orders)
            {
                if (o.ID == id)
                {
                    return o;
                }
            }

            Exception e = new Exception("Can't find the order!");
            throw e;
        }


        //----------------------各种查询功能----------------------
        public void FindOrderById(String id)
        {
            var order = from o in orders
                        where o.ID == id
                        select o;

            foreach(var x in order)
            {
                x.ShowDetails();
            }

            //没找到的情况？
        }

        public void FindOrderByClient(Client client)
        {
            var order = from o in orders
                        where o.Client == client
                        orderby o.TotalPrize descending
                        select o;

            foreach (var x in order)
            {
                x.ShowDetails();
                Console.WriteLine();
            }

            //没找到的情况？
        }

        public void FindOrderByPrize(int prize)
        {
            var order = from o in orders
                        where o.TotalPrize == prize
                        orderby o.ID
                        select o;

            foreach (var x in order)
            {
                x.ShowDetails();
                Console.WriteLine();
            }

            //没找到的情况？
        }


        //----------------------打印所有订单----------------------
        public void ShowOrder()
        {
            foreach(Order o in orders)
            {
                o.ShowDetails();
                Console.WriteLine();
            }
        }
    }
}
