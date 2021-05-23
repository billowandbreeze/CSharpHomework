using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Client> Clients { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        /*
        public DbSet<Good> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        */
    }
}
