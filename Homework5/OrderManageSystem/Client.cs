﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Client
    {
        private String name;

        public String Name
        {
            get => name;
            set => name = value;
        }

        public Client(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Client Name :" + name;
        }
    }
}
