using ShopperLib;
using ShopperLib.Model;
using System;


namespace Shopper
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("Alex", 0);
            User u2 = new User("Leo", 0);
            Product p1 = new Product("milk", 55, "456721");
            Order o1 = new Order(u1);
            o1.addPosition(p1,2);
            Saver.AddOrder(o1);
            Saver.AddProduct(p1);
            Saver.AddUser(u1);
            Saver.AddUser(u2);
        }
    }
}
