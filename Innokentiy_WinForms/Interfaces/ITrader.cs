using Innokentiy_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innokentiy_WinForms.Interfaces
{
    internal interface ITrader
    {
        void Sell(Creature creature,Item item);
    }
}
