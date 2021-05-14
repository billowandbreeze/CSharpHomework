using OrderManageSystem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderContext : DbContext
    {
        public OrderContext()
                : base("OrderDb") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
