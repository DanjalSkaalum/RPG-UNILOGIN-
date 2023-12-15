namespace RPG_UNILOGIN_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting up the Player and Monster NPC and Equipment
            Player player1 = new Player("Hero", hp: 100, xp: 0, level: 1, Player.PlayerClass.Fighter, Player.PlayerRace.Human);
            NPC npc1 = new NPC("Orc", NPC.NPCType.Monster, hp: 35, damageDone: 15);
            Equipment sword = new Equipment(name: "Sword", weight: 5, damageDone: 20);

            // Adding Equipment to Equipment list
            player1.Equipment.Add(sword);

            // Establishing encounter
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s). They are a {player1.Race} {player1.Class} with {player1.HP} HP.");
            Console.WriteLine($"{npc1.Name} is a {npc1.Type}. They have {npc1.HP} HP.");

            // Simulating Fight between Player and NPC
            while (npc1.HP > 0)
            {
                // Player attacks NPC
                player1.Attack(npc1);

                // NPC attacks Player
                npc1.Attack(player1);
            }

            // Display player's equipment and health
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s) and {player1.HP} HP left.");

            // Simulating XP gain and level up mechanic
            player1.XP = player1.XP + 50;
            player1.LevelUp();

            // Setting up a new Monster NPC
            NPC npc2 = new NPC("Orc Warchief", NPC.NPCType.Monster, hp: 50, damageDone: 20);

            // Establishing second encounter
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s). They are a {player1.Race} {player1.Class} with {player1.HP} HP.");
            Console.WriteLine($"{npc2.Name} is a {npc2.Type}. They have {npc2.HP} HP.");
            while (npc2.HP > 0)
            {
                // Player attacks NPC
                player1.Attack(npc2);

                // NPC attacks Player
                npc2.Attack(player1);
            }

            // Display player's equipment and health
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s) and {player1.HP} HP left.");

            // Simulating XP gain and a successful level up
            player1.XP = player1.XP + 50;
            player1.LevelUp();

            Console.ReadLine();
        }
    }
}
