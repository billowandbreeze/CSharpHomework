using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    public class Good
    {
        private String name;
        private Double prize;

        public Good()
        {

        }

        public Good(String name, Double prize)
        {
            this.name = name;
            this.prize = prize;
        }

        public String Name
        {
            get => name;
            set => name = value;
        }

        public Double Prize
        {
            get => prize;
            set => prize = value;
        }

        public override string ToString()
        {
            return name + "(" + prize + " yuan)";
        }
    }
}
