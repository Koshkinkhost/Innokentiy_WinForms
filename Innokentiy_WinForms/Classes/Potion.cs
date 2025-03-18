using Innokentiy_WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Potion : Item, IUse
    {
        public int health;
        public Potion(double w, double p) : base(w, p)
        {

        }

        public void Use(Potion potion)
        {
            GameProvider.hero.Health += potion.health;
        }

        public void Use(IWeapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}
