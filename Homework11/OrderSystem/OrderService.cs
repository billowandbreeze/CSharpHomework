using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using OrderSystem;

namespace OrderManageSystem
{
    public class OrderService
    {
        //----------------------找订单的工具----------------------
        private Order FindOrderTool(Order order)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where Id = {0}", order.Id);

                return query.FirstOrDefault();
            }
        }

        //----------------------订单的增删改查----------------------
        public void AddOrder(Order order)
        {
            using (var oc = new OrderContext())
            {
                oc.Orders.Add(order);
                oc.SaveChanges();
            }
        }

        public void RemoveOrder(Order order)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where Id = {0}", order.Id);

                oc.OrderDetails.RemoveRange(query.FirstOrDefault().OrderDetails);

                oc.Orders.RemoveRange(query);
                oc.SaveChanges();
            }
        }

        public void ChangeOrder(Order oldOrder, Order newOrder)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where Id = {0}", oldOrder.Id);
                oc.OrderDetails.RemoveRange(query.FirstOrDefault().OrderDetails);
                oc.Orders.RemoveRange(query);

                oc.Orders.Add(newOrder);

                oc.SaveChanges();
            }
        }

        public Order FindOrder(String id)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where Id = {0}", id);

                return query.FirstOrDefault();
            }
        }


        //----------------------各种查询功能----------------------
        public List<Order> FindOrderById(String id)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where Id = {0}", id);

                return query.ToList();
            }
        }

        public List<Order> FindOrderByClient(Client client)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where Client_Id = {0}", client.Id);

                return query.ToList();
            }
        }

        public List<Order> FindOrderByPrize(int prize)
        {
            using (var oc = new OrderContext())
            {
                var query = oc.Orders.SqlQuery("select * from orders where TotalPrize <= {0}", prize);

                return query.ToList();
            }
        }

        //----------------------重写方法----------------------
        public override string ToString()
        {
            String res = "";

            using (var oc = new OrderContext())
            {                
                var query = oc.Orders.SqlQuery("select * from orders");

                foreach (var q in query)
                {
                    res = res + "\n" + q.ToString();
                }
            }

            return res;
        }



        //----------------------序列化和反序列化----------------------
        /*
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
        */
    }
}
