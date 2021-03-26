using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class OrderDetails
    {
        private Good goods;
        private int num;

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

        public OrderDetails(Good goods, int num)
        {
            this.goods = goods;
            this.num = num;
        }

        public double GetTotalPrize()
        {
            return goods.Prize * num;
        }

        public override string ToString()
        {
            return goods.ToString() + "\nNumber: " + num;
        }
    }
}
