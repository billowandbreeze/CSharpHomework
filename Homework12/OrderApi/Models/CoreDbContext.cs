using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class CoreDbContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; } //创建实体类添加Context中

        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {

        }
    }
}
