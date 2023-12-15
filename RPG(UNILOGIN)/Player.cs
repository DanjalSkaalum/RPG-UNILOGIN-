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
        public enum PlayerClass
        {
            Fighter,
            Priest,
            Mage,
            Rogue
        }
        public enum PlayerRace
        {
            Elf, 
            Dwarf, 
            Hobbit,
            Human
        }

        public int Level;
        public string Class;
        public string Race;
        public List<Equipment> Equipment { get; set; }

        public Player()
        {

        }
        public Player(string name, int hp, int xp, int level, PlayerClass playerClass, PlayerRace race)
        {
            Name = name;
            HP = hp;
            XP = xp;
            Level = level;
            Class = playerClass.ToString();
            Race = race.ToString();
            Equipment = new List<Equipment>();
        }

        bool HasAttacked;
        public override void Attack()
        {
            // Implement player attack logic
                Console.WriteLine($"{Name} attacks the creature.");
        }

        public override void Damage(int amount)
        {
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
            return HP <= 0;
        }
    }
}
