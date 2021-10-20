using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperLib
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public string GetName() => Name;
        public User(string n, int cr)
        {
            Name = n;
            Credits = cr;
        }
        User() { }
    }
}
