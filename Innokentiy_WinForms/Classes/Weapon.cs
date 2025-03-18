using Innokentiy_WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Weapon : Item, IUse
    {
        public int damage;
        public string name; 
        public Weapon(int damage, double w, double p) : base(w, p)
        {
            this.damage = damage;
            this.name = name;
        }
        public void Use(Weapon item)
        {
            GameProvider.hero.weapon = item;
        }

    }
}
