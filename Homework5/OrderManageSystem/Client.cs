using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Client
    {
        public String Name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Client Name :" + Name;
        }
    }
}
