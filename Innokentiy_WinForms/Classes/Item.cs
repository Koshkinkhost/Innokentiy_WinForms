using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Item
    {
        public double Weight { get; set; }
        public double Price { get; set; }
        public Item(double w, double p)
        {
            Weight = w;
            Price = p;
        }
    }
}
