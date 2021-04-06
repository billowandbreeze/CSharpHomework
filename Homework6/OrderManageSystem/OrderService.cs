using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace OrderManageSystem
{
    public class OrderService
    {
        //----------------------字段----------------------
        public List<Order> orders = new List<Order>();

        //----------------------属性----------------------
        public List<Order> Orders
        {
            get => orders;
            set => orders = value;
        }

        //----------------------找订单的工具----------------------
        private Order FindOrderTool(Order order)
        {
            foreach(Order o in orders)
            {
                if(o == order)
                {
                    return o;
                }
            }

            return null;
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
            if(FindOrderTool(order) != null)
            {
                orders.Remove(FindOrderTool(order));
            }
            else
            {
                Exception e = new Exception("Can't remove: can't find the order!");
                throw e;
            }
        }

        public void ChangeOrder(Order oldOrder, Order newOrder)
        {
            if (FindOrderTool(oldOrder) != null)
            {
                orders.Remove(FindOrderTool(oldOrder));
                AddOrder(newOrder);
            }
            else
            {
                Exception e = new Exception("Can't change: can't find the order!");
                throw e;
            }
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

            foreach (var x in order)
            {
                Console.WriteLine(x);
            }
        }

        public void FindOrderByClient(Client client)
        {
            var order = from o in orders
                        where o.Client == client
                        orderby o.TotalPrize descending
                        select o;

            foreach (var x in order)
            {
                Console.WriteLine(x);
            }
        }

        public void FindOrderByPrize(int prize)
        {
            var order = from o in orders
                        where o.TotalPrize == prize
                        orderby o.ID
                        select o;

            foreach (var x in order)
            {
                Console.WriteLine(x);
            }
        }

        //----------------------重写方法----------------------
        public override string ToString()
        {
            String res = "";

            foreach (Order o in orders)
            {
                res += o.ToString();
                res += "\n";
            }

            return res;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            return obj is OrderService service &&
                   EqualityComparer<List<Order>>.Default.Equals(orders, service.orders);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //----------------------序列化和反序列化----------------------
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            using (FileStream fileStream = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, this.orders);
            }
        }

        public List<Order> Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            using (FileStream fileStream = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fileStream);

                return temp;
            }
        }
    }
}
