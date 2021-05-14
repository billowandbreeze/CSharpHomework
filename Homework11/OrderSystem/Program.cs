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
            using (var oc = new OrderContext())
            {
                var client = new Client("0002", "狗");

                oc.Clients.Add(client);
                oc.SaveChanges();

                /*
                var query = from order in oc.Orders
                            select order;
                foreach (var q in query)
                {
                    Console.WriteLine("OrderId:{0},OrderDate:{1}", q.Id, q.OrderDate);
                }
                */
                Console.Read();
            }
        }
    }
}
