using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UNILOGIN_
{
    internal abstract class Base
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }

        public virtual void Attack()
        {
            throw new NotImplementedException("Attack method must be implemented in subclasses");
        }

        public virtual void Damage(int amount)
        {
            throw new NotImplementedException("Damage method must be implemented in subclasses");
        }

        public virtual bool CheckIfDead()
        {
            throw new NotImplementedException("CheckIfDead method must be implemented in subclasses");
        }
    }
}
