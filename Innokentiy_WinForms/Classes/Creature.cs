using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int CarryWeaight { get; set; }
        public double Wallet { get; set; }
        public List<Item> Items { get; set; }
        public Creature(int h, int C, int W)
        {
            Health = h;
            Wallet = W;
            CarryWeaight = C;
            Items = new List<Item>();
        }
       

    }
}
