using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Hero : Creature
    {
        public string name;
        public Weapon weapon;
        public Potion potion;
        public Hero(string n, int h, int C, int W) : base(h, C, W)
        {
            name = n;
        }
        
    }
}
