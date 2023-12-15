using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_UNILOGIN_
{
    internal class Player : Base
    {
        string _Name;
        int _HP;
        int _XP;
        string Name { get { return _Name; } set { _Name = value; } }
        int HP { get { return _HP; } set { _HP = value; } }
        int XP { get { return _XP; } set { _XP = value; } }

        public void Attack()
        {

        }
    }
}
