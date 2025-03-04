using Innokentiy_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Interfaces
{
    internal interface IFighter
    {
        void Attack(Creature target,IWeapon weapon);
    }
}
