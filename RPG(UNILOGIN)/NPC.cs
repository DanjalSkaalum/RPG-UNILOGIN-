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

        // An enum for the NPC's arbitrary NPC type choice
        public enum NPCType
        {
            Enemy,
            Ally,
            Merchant,
            Monster
        }

        // Properties for the NPC
        int DamageDone;

        // Constructor for making a Non-Playable Character
        public NPC(string name, NPCType npcType, int hp, int damageDone)
        {
            Name = name;
            Type = npcType;
            HP = hp;
            DamageDone = damageDone;
        }

        // Method for the NPC's attacks
        public override void Attack(Base target)
        {
            // Implement NPC attack logic
            if (!CheckIfDead())
            {
                if (target is Player playerTarget)
                {
                    int totalDamage = CalculateTotalDamage();

                    // // Informs of the NPC's target and damage
                    Console.WriteLine($"{Name} attacks {playerTarget.Name} with {totalDamage} damage!");

                    // Applies damage to targeted Player
                    playerTarget.Damage(totalDamage);
                }
                else
                {
                    // Informs of anti-EVE limitations
                    Console.WriteLine($"{Name} can only attack players.");
                }
            }
        }

        // Method for calulating the NPC's damage output
        private int CalculateTotalDamage()
        {
            // Returns the NPC's set damage
            return DamageDone;
        }

        // Method for the NPC taking damage
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

        // Bool check for NPC death
        public override bool CheckIfDead()
        {
            // Returns bool value, true if dead, false if otherwise
            return HP <= 0;
        }
    }
}
