using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Good
    {
        private String name;
        private Double prize;

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
            return "Good Name: " + name + "\nPrize: " + prize + " yuan";
        }
    }
}
