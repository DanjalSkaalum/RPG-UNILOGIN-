using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UNILOGIN_
{
    internal class Equipment
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int DamageDone { get; set; }

        public Equipment(string name, int weight, int damageDone)
        {
            Name = name;
            Weight = weight;
            DamageDone = damageDone;
        }
    }
}
