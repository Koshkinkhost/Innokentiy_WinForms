using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Classes
{
    internal class Potion : Item
    {
        public Potion(double w, double p) : base(w, p)
        {

        }

        public void Health(Hero hero)
        {
            hero.Health += 10;
        }
    }
}
