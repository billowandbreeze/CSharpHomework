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
        //----------------------属性----------------------
        public List<Order> Orders
        {
            get; set;
        }

        //----------------------找订单的工具----------------------
        private Order FindOrderTool(Order order)
        {
            foreach(Order o in Orders)
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
            foreach (Order o in Orders)
            {
                if(o == order)
                {
                    Exception e = new Exception("The same order!");
                    throw e;
                }
            }

            Orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            if(FindOrderTool(order) != null)
            {
                Orders.Remove(FindOrderTool(order));
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
                Orders.Remove(FindOrderTool(oldOrder));
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
            foreach (Order o in Orders)
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
        public List<Order> FindOrderById(String id)
        {
            var order = from o in Orders
                        where o.ID == id
                        select o;

            return order.ToList();
        }

        public List<Order> FindOrderByClient(String name)
        {
            var order = from o in Orders
                        where o.Client.Name == name
                        orderby o.TotalPrize descending
                        select o;

            return order.ToList();
        }

        public List<Order> FindOrderByPrize(int prize)
        {
            var order = from o in Orders
                        where o.TotalPrize <= prize
                        orderby o.ID
                        select o;

            return order.ToList();
        }

        //----------------------重写方法----------------------
        public override string ToString()
        {
            String res = "";

            foreach (Order o in Orders)
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
                   EqualityComparer<List<Order>>.Default.Equals(Orders, service.Orders);
        }

        //----------------------序列化和反序列化----------------------
        public void Export(String fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, this.Orders);
            }
        }

        public List<Order> Import(String fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fileStream);

                return temp;
            }
        }
    }
}
