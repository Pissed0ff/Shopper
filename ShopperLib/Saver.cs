using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopperLib.EF;
using ShopperLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperLib
{
    public class Saver
    {
        static DbContextOptions<ApplicationContext> options = new DbContextOptions<ApplicationContext>();
        public static void AddUser(User user)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static void AddOrder(Order order)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public static void AddProduct(Product product)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        static Saver()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()+@"\EF");
            builder.AddJsonFile("AppSettings.json");
            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionstBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            options = optionstBuilder.UseSqlServer(connectionString).Options;

        }
    }
}
