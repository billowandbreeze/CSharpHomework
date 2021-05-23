using System;

namespace TodoApi.Models
{
    public class Good
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public Double Prize { get; set; }

        public Good()
        {

        }

        public Good(String Id, String Name, Double Prize)
        {
            this.Id = Id;
            this.Name = Name;
            this.Prize = Prize;
        }
       
        public override string ToString()
        {
            return Name + "(" + Prize + "元)";
        }
    }
}
