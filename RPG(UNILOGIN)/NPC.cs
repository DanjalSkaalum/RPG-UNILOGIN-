using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UNILOGIN_
{
    internal class NPC : Base
    {
        public NPCType Type { get; set; }

        public enum NPCType
        {
            Enemy,
            Ally,
            Merchant,
            Monster
        }

        public NPC(string name, NPCType npcType, int hp)
        {
            Name = name;
            Type = npcType;
            HP = hp;
        }

        public override void Attack()
        {
            // Implement NPC attack logic
            Console.WriteLine($"{Name} attacks.");
        }

        public override void Damage(int amount)
        {
            // Implement NPC damage logic
            HP -= amount;
            if (CheckIfDead())
            {
                Console.WriteLine($"{Name} is dead.");
            }
            else
            {
                Console.WriteLine($"{Name} is still alive with {HP} HP left!");
            }
        }

        public override bool CheckIfDead()
        {
            // Implement NPC death logic
            return HP <= 0;
        }
    }
}
