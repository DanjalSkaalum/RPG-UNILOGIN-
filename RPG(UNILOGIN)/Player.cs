using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static RPG_UNILOGIN_.NPC;

namespace RPG_UNILOGIN_
{
    internal class Player : Base
    {
        public PlayerClass PClass { get; set; }
        public PlayerRace Race { get; set; }

        // An enum for the Player's arbitrary class choice
        public enum PlayerClass
        {
            Fighter,
            Priest,
            Mage,
            Rogue
        }
        // An enum for the player's arbitrary race choice
        public enum PlayerRace
        {
            Elf, 
            Dwarf, 
            Hobbit,
            Human
        }

        // Properties for the player
        public int Level;
        public List<Equipment> Equipment { get; set; }

        public Player()
        {

        }
        // Constructor for making a Player Character
        public Player(string name, int hp, int xp, int level, PlayerClass pClass, PlayerRace race)
        {
            Name = name;
            HP = hp;
            XP = xp;
            Level = level;
            PClass = pClass; 
            Race = race;
            Equipment = new List<Equipment>();
        }

        // Method for the player's attacks
        public override void Attack(Base target)
        {
            // Check for if the character can attack
            if (!CheckIfDead())
            {
                // If and else for targeting purposes
                if (target is NPC npcTarget)
                {
                    int totalDamage = CalculateTotalDamage();

                    // Informs of the player's target and damage
                    Console.WriteLine($"{Name} attacks {npcTarget.Name} with {totalDamage} damage!");

                    // Applies damage to targeted NPC
                    npcTarget.Damage(totalDamage);
                }
                else
                {
                    // Informs of anti-PVP limitations
                    Console.WriteLine($"{Name} can only attack NPCs.");
                }
            }
        }

        // Method for calulating the player's damage output
        private int CalculateTotalDamage()
        {
            int totalDamage = 0;

            // Sum up damage from each piece of equipment
            foreach (Equipment equipment in Equipment)
            {
                totalDamage += equipment.DamageDone;
            }

            return totalDamage;
        }

        // Method for the Player taking damage
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

        // Bool check for Player death
        public override bool CheckIfDead()
        {
            // Returns bool value, true if dead, false if otherwise
            return HP <= 0;
        }

        public void LevelUp()
        {
            // XP threshold for leveling up (you can adjust this value)
            int xpThreshold = 100;

            // Informs of accumulated  XP
            Console.WriteLine($"{Name} has {XP} out of {xpThreshold} XP.");

            // Checks if the player has enough XP to level up
            if (XP >= xpThreshold)
            {
                // Increases level
                Level++;

                // Informs of a level up
                Console.WriteLine($"{Name} leveled up to Level {Level}!");
                Console.WriteLine($"Congratulations! {Name} has gained a new level.");

                // Provides level up benefits and XP reset
                HP += 50; // Increases HP by 50 for demonstration purposes
                XP = 0; // Resets XP to 0 after leveling up

                // Increases XP Threshold for next level up
                xpThreshold += xpThreshold;
            }
            else
            {
                int xpDifference = xpThreshold - XP;
                // Informs lack of XP to level up
                Console.WriteLine($"{Name} does not have enough XP to level up yet. Lacking {xpDifference} XP.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
