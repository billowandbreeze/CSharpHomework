using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TodoApi.Models
{
    [Serializable]
    public class Order
    {
        //----------------------属性----------------------
        public String Id { get; set; }

        public virtual Client Client { get; set; }

        public double TotalPrize
        {
            get
            {
                double res = 0;

                foreach(OrderDetail o in OrderDetails)
                {
                    res += o.Prize;
                }

                return res;
            }
        }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        //----------------------构造器----------------------
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public Order(String ID, Client Client)
        {
            this.Id = ID;
            this.Client = Client;
            OrderDetails = new List<OrderDetail>();
        }


        //----------------------找到订单的工具----------------------
        private OrderDetail AddOrderTool(Good good)
        {
            foreach (OrderDetail o in OrderDetails)
            {
                if (o.GoodItem == good)
                {
                    return o;
                }
            }

            return null;
        }

        private OrderDetail FindOrderTool(OrderDetail orderDetails)
        {
            foreach(OrderDetail o in OrderDetails)
            {
                if(o == orderDetails)
                {
                    return o;
                }
            }

            return null;
        }


        //----------------------订单明细的增删改查----------------------
        public void AddDetails(OrderDetail orderDetails)
        {
            OrderDetails.Add(orderDetails);
        }


        public void RemoveDetails(OrderDetail orderDetails)
        {
            if(FindOrderTool(orderDetails) != null)
            {
                OrderDetails.Remove(FindOrderTool(orderDetails));
            }
            else
            {
                Exception e = new Exception("Can't remove: can't find order details!");
                throw e;
            }
        }


        public void ChangeDetails(OrderDetail oldOrderDetails, OrderDetail newOrderDetails)
        {
            if(FindOrderTool(oldOrderDetails) != null)
            {
                OrderDetails.Remove(FindOrderTool(oldOrderDetails));
                AddDetails(newOrderDetails);
            }
            else
            {
                Exception e = new Exception("Can't change: can't find order details!");
                throw e;
            }
        }

        public OrderDetail FindDetails(Good goods, int num)
        {
            foreach(OrderDetail o in OrderDetails)
            {
                if(o.GoodItem == goods && o.Num == num)
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
                   Id == order.Id;
        }

        public override string ToString()
        {
            String res = "ID: " + Id + "\n" + Client + "\n";


            foreach(OrderDetail o in OrderDetails)
            {
                res += o.ToString();
                res += "\n";
            }

            res += "Total Prize: " + TotalPrize + "\n";

            return res;
        }
    }
}
