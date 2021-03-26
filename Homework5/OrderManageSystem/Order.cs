using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Order
    {
        private String id;
        private Client client;
        private double totalPrize;

        private List<OrderDetails> details = new List<OrderDetails>();

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
            get
            {
                totalPrize = 0;
                foreach(OrderDetails o in details)
                {
                    totalPrize += o.GetTotalPrize();
                }

                return totalPrize;
            }
        }

        public List<OrderDetails> Details
        {
            get => details;
        }

        public void AddDetails(OrderDetails orderDetails)
        {
            //如果已经存在相同物品，则在OrderDetails中增加一个
            foreach (OrderDetails o in details)
            {
                if (o.Goods == orderDetails.Goods)
                {
                    o.Num += 1;
                    return;
                }
            }

            details.Add(orderDetails);
        }

        public void RemoveDetails(OrderDetails orderDetails)
        {
            foreach (OrderDetails o in details)
            {
                if(o == orderDetails)
                {
                    details.Remove(o);
                    return;
                }
            }

            //抛出异常
        }

        public void ChangeDetails(OrderDetails orderDetails, Good goods, int num)
        {
            foreach (OrderDetails o in details)
            {
                if (o == orderDetails)
                {
                    o.Goods = goods;
                    o.Num = num;
                    return;
                }
            }

            //抛出异常
        }

        public OrderDetails FindDetails(Good goods)
        {
            foreach(OrderDetails o in details)
            {
                if(o.Goods == goods)
                {
                    Console.WriteLine("Find " + goods.Name);
                    return o;
                }
            }

            //抛出异常
            return null;
        }

        public void ShowDetails()
        {
            foreach(OrderDetails o in details)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
