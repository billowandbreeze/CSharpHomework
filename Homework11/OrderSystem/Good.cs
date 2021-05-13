using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManageSystem
{
    [Table("Good")]
    public class Good
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
        public String Name
        {
            get; set;
        }

        public Double Prize
        {
            get; set;
        }

        public Good()
        {

        }

        public Good(String Name, Double Prize)
        {
            this.Name = Name;
            this.Prize = Prize;
        }
       
        public override string ToString()
        {
            return Name + "(" + Prize + "元)";
        }
    }
}
