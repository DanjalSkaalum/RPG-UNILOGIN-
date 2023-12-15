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
            Equipment dagger = new Equipment(name: "Dagger", weight: 1, damageDone: 10);

            // Adding Equipment to Player 1's Equipment list
            player1.Equipment.Add(sword);
            player1.Equipment.Add(dagger);

            // Establishing encounter
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s). They are a {player1.Race} {player1.PClass} with {player1.HP} HP.");
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
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s). They are a {player1.Race} {player1.PClass} with {player1.HP} HP.");
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

            // Setting up a second Player and Merchant NPC and Equipment
            Player player2 = new Player("Other Hero", hp: 100, xp: 0, level: 1, Player.PlayerClass.Rogue, Player.PlayerRace.Hobbit);
            NPC npc3 = new NPC("Jeffery", NPC.NPCType.Merchant, hp: 10, damageDone: 5);

            // Adding Equipment to Player 2's Equipment list
            player2.Equipment.Add(dagger);
            player2.Equipment.Add(dagger);

            // Establishing encounter
            Console.WriteLine($"{player2.Name} has {player2.Equipment.Count} equipment(s). They are a {player2.Race} {player2.PClass} with {player2.HP} HP.");
            Console.WriteLine($"{npc3.Name} is a {npc3.Type}. They have {npc3.HP} HP.");

            Console.ReadLine();
        }
    }
}
