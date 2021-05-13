using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManageSystem
{
    [Table("OrderDetails")]
    public class OrderDetails
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
        [Key]
        [Required]
        [StringLength(32)]
        public String DetailsID
        {
            get; set;
        }


        public virtual Good Goods
        {
            get; set;
        }

        public int Num
        {
            get; set;
        }

        public double Prize
        {
            get; set;
        }
        

        //----------------------构造器----------------------
        public OrderDetails()
        {
            Prize = 0;
        }

        public OrderDetails(Good Goods, int Num)
        {
            this.Goods = Goods;
            this.Num = Num;
        }

        //----------------------重写方法----------------------
        public override string ToString()
        {
            return Goods.ToString() + "\nNumber: " + Num;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            return obj is OrderDetails details &&
                   Goods.Name == details.Goods.Name &&
                   Goods.Prize == details.Goods.Prize &&
                   Num == details.Num;
        }
    }
}
