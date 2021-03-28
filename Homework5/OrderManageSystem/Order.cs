using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Order
    {
        //----------------------字段----------------------
        private String id;
        private Client client;
        private double totalPrize;
        private List<OrderDetails> details;


        //----------------------属性----------------------
        public String ID
        {
            set => id = value;
            get => id;
        }

        public Client Client
        {
            set => client = value;
            get => client;
        }

        public double TotalPrize
        {
            get => totalPrize;
        }

        public List<OrderDetails> Details
        {
            get => details;
        }

        //----------------------构造器----------------------
        public Order(String id, Client client)
        {
            this.id = id;
            this.client = client;
            totalPrize = 0;
            details = new List<OrderDetails>();
        }

        //----------------------更新订单总价格----------------------
        public void UpdateTotalPrize()
        {
            totalPrize = 0;
            foreach (OrderDetails o in details)
            {
                totalPrize += o.GetTotalPrize();
            }
        }

        //----------------------订单明细的增删改查----------------------
        public void AddDetails(OrderDetails orderDetails)
        {
            //如果已经存在相同物品，则直接修改订单明细
            foreach (OrderDetails o in details)
            {
                if (o.Equals(orderDetails))
                {
                    o.Num = 2 * o.Num;
                    UpdateTotalPrize();
                    return;
                }
            }

            details.Add(orderDetails);
            UpdateTotalPrize();
        }

        public void RemoveDetails(OrderDetails orderDetails)
        {
            foreach (OrderDetails o in details)
            {
                if(o == orderDetails)
                {
                    details.Remove(o);
                    UpdateTotalPrize();
                    return;
                }
            }

            Exception e = new Exception("Can't remove: can't find order details!");
            throw e;
        }

        public void ChangeDetails(OrderDetails orderDetails, Good goods, int num)
        {
            foreach (OrderDetails o in details)
            {
                if (o == orderDetails)
                {
                    o.Goods = goods;
                    o.Num = num;
                    UpdateTotalPrize();
                    return;
                }
            }

            Exception e = new Exception("Can't change: can't find order details!");
            throw e;
        }

        public OrderDetails FindDetails(Good goods)
        {
            foreach(OrderDetails o in details)
            {
                if(o.Goods == goods)
                {
                    //Console.WriteLine("Find " + goods.Name);
                    return o;
                }
            }

            Exception e = new Exception("Can't find order details!");
            throw e;
        }

        //----------------------打印订单----------------------
        public void ShowDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine(client);
            Console.WriteLine("Total Prize: " + totalPrize);

            foreach (OrderDetails o in details)
            {
                Console.WriteLine(o.ToString());
            }
        }


        //----------------------重写方法----------------------
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   client == order.client &&
                   id == order.id &&
                   totalPrize == order.totalPrize &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(details, order.details);
        }
    }
}
