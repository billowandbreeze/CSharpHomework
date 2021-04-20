using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    public class Client
    {
        private String name;

        public String Name
        {
            get => name;
            set => name = value;
        }

        public Client()
        {

        }

        public Client(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
