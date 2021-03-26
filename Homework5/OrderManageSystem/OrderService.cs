using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();

        public List<Order> Orders
        {
            get => orders;
        }

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

            //抛出异常
            return null;
        }

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
