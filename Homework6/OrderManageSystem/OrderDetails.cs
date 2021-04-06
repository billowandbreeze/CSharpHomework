using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    public class OrderDetails
    {
        //----------------------字段----------------------
        private Good goods;
        private int num;

        //----------------------属性----------------------
        public Good Goods
        {
            set => goods = value;
            get => goods;
        }

        public int Num
        {
            set => num = value;
            get => num;
        }

        public double Prize
        {
            get
            {
                return goods.Prize * num;
            }
        }

        //----------------------构造器----------------------
        public OrderDetails()
        {

        }

        public OrderDetails(Good goods, int num)
        {
            this.goods = goods;
            this.num = num;
        }

        //----------------------重写方法----------------------
        public override string ToString()
        {
            return goods.ToString() + "\nNumber: " + num;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            return obj is OrderDetails details &&
                   goods.Name == details.goods.Name &&
                   goods.Prize == details.goods.Prize &&
                   num == details.num;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Goods, Num, Prize);
        }
    }
}
