using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Models {
    public class OrderDetail
    {
        public String Id { get; set; }


        public virtual Good GoodItem { get; set; }

        public int Num { get; set; }

        public double Prize
        {
            get
            {
                return GoodItem.Prize * Num;
            }
        }
        

        //----------------------构造器----------------------
        public OrderDetail()
        {
            
        }

        public OrderDetail(String Id, Good GoodItem, int Num)
        {
            this.Id = Id;
            this.GoodItem = GoodItem;
            this.Num = Num;
        }

        //----------------------重写方法----------------------
        public override string ToString()
        {
            return GoodItem.ToString() + "\nNumber: " + Num;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            return obj is OrderDetail details &&
                   GoodItem.Name == details.GoodItem.Name &&
                   GoodItem.Prize == details.GoodItem.Prize &&
                   Num == details.Num;
        }
    }
}
