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
                    //报错
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

            //抛出异常
        }

        public void ChangeOrder(Order order, Good goods, int num)
        {
            foreach (Order o in orders)
            {
                if (o == order)
                {
                    //条件还没写
                    return;
                }
            }

            //抛出异常
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

            return null;
            //抛出异常
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

        //----------------------排序功能----------------------


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
