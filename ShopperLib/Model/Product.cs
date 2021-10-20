using System;

namespace ShopperLib
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Cod { get; set; }

        public Product(string name, decimal price, string cod)
        {
            Name = name;
            Price = price;
            Cod = cod;
        }
        Product() { }
    }
}
