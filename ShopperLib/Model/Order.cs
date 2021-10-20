using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperLib.Model
{
    public class Order
    {
        public int Id { get; set; }
        public User User;
        public Dictionary<Product, int> List;
        public decimal totalPrice { get; set; }

        Order() { }
        public Order(User user)
        {
            User = user;
            List = new Dictionary<Product, int>();
            totalPrice = 0;
        }

        public void addPosition(Product product, int quantity)
        {
            List.Add(product, quantity);
        }
    }
}
