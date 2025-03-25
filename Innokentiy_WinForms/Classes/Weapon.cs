using Innokentiy_WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Weapon : Item
    {
        public int damage; 
        public Weapon(int damage, double w, double p, string n) : base(n, p, w)
        {
            this.damage = damage;
        }
     
       

    }
}
