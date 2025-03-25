using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Item
    {
        public Item(string n, double w, double p)
        {
            Name = n;
            Weight = w;
            Price = p;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Name} {Weight} {Price}";
        }
    }
}
