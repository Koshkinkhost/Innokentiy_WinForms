using Innokentiy_WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Innokentiy_WinForms.Classes
{
    internal class Potion : Item
    {
        public int health;
        public Potion(int h, string n, double w, double p) : base(n, w, p)
        {
            health = h;
        }
      

        //public void Use(Potion potion)
        //{
        //    GameProvider.hero.Health += potion.health;
        //}

        //public void Use(IWeapon weapon)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
