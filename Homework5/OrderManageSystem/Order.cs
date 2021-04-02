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
            get
            {
                totalPrize = 0;
                foreach (OrderDetails o in details)
                {
                    totalPrize += o.Prize;
                }

                return totalPrize;
            }
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


        //----------------------找到订单的工具----------------------
        private OrderDetails AddOrderTool(Good good)
        {
            foreach (OrderDetails o in details)
            {
                if (o.Goods == good)
                {
                    return o;
                }
            }

            return null;
        }

        private OrderDetails FindOrderTool(OrderDetails orderDetails)
        {
            foreach(OrderDetails o in details)
            {
                if(o == orderDetails)
                {
                    return o;
                }
            }

            return null;
        }


        //----------------------订单明细的增删改查----------------------
        public void AddDetails(OrderDetails orderDetails)
        {
            if(AddOrderTool(orderDetails.Goods) != null)
            {
                AddOrderTool(orderDetails.Goods).Num += orderDetails.Num;
            }
            else
            {
                details.Add(orderDetails);
            }
        }


        public void RemoveDetails(OrderDetails orderDetails)
        {
            if(FindOrderTool(orderDetails) != null)
            {
                details.Remove(FindOrderTool(orderDetails));
            }
            else
            {
                Exception e = new Exception("Can't remove: can't find order details!");
                throw e;
            }
        }


        public void ChangeDetails(OrderDetails oldOrderDetails, OrderDetails newOrderDetails)
        {
            if(FindOrderTool(oldOrderDetails) != null)
            {
                details.Remove(FindOrderTool(oldOrderDetails));
                AddDetails(newOrderDetails);
            }
            else
            {
                Exception e = new Exception("Can't change: can't find order details!");
                throw e;
            }
        }

        public OrderDetails FindDetails(Good goods, int num)
        {
            foreach(OrderDetails o in details)
            {
                if(o.Goods == goods && o.Num == num)
                {
                    return o;
                }
            }

            Exception e = new Exception("Can't find order details!");
            throw e;
        }


        //----------------------重写方法----------------------
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            return obj is Order order &&
                   id == order.id;
        }

        public override string ToString()
        {
            String res = "ID: " + id + "\n" + client + "\n";


            foreach(OrderDetails o in details)
            {
                res += o.ToString();
                res += "\n";
            }

            res += "Total Prize: " + TotalPrize + "\n";

            return res;
        }
    }
}
