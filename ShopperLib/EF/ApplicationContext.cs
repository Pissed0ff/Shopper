using Microsoft.EntityFrameworkCore;
using ShopperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperLib.EF
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions)
            :base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
