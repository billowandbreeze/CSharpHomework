using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManageSystem
{
    [Table("Order")]
    [Serializable]
    public class Order
    {
        /*
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(32)]
        
        public string StuName { get; set; }
        public DateTime SubTime { get; set; }
     
        //一个学生 只能对应 一个班级
        public virtual ClassInfo ClassInfo { get; set; }
        */


        //----------------------属性----------------------
        [Key]
        [Required]
        [StringLength(32)]
        public String ID
        {
            get; set;
        }

        public virtual Client Client
        {
            get; set;
        }

        public double TotalPrize
        {
            get; set;
        }

        public virtual List<OrderDetails> Details
        {
            get; set;
        }

        //----------------------构造器----------------------
        public Order()
        {
            Details = new List<OrderDetails>();
        }

        public Order(String ID, Client Client)
        {
            this.ID = ID;
            this.Client = Client;
            TotalPrize = 0;
            Details = new List<OrderDetails>();
        }


        //----------------------找到订单的工具----------------------
        private OrderDetails AddOrderTool(Good good)
        {
            foreach (OrderDetails o in Details)
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
            foreach(OrderDetails o in Details)
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
                Details.Add(orderDetails);
            }
        }


        public void RemoveDetails(OrderDetails orderDetails)
        {
            if(FindOrderTool(orderDetails) != null)
            {
                Details.Remove(FindOrderTool(orderDetails));
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
                Details.Remove(FindOrderTool(oldOrderDetails));
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
            foreach(OrderDetails o in Details)
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
                   ID == order.ID;
        }

        public override string ToString()
        {
            String res = "ID: " + ID + "\n" + Client + "\n";


            foreach(OrderDetails o in Details)
            {
                res += o.ToString();
                res += "\n";
            }

            res += "Total Prize: " + TotalPrize + "\n";

            return res;
        }
    }
}
