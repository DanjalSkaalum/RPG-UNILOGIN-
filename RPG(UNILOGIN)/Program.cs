namespace RPG_UNILOGIN_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Hero", hp: 100, xp: 0, level: 1, Player.PlayerClass.Fighter, Player.PlayerRace.Human);
            NPC npc1 = new NPC("Orc", NPC.NPCType.Monster, hp: 35);
            Equipment sword = new Equipment(name: "Sword", weight: 5, damageDone: 10);

            player1.Equipment.Add(sword);

            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s). They are a {player1.Race} {player1.Class}.");
            Console.WriteLine($"{npc1.Name} is a {npc1.Type}.");

            // Player attacks NPC
            player1.Attack();
            npc1.Damage(20); // Assume NPC takes 20 damage

            // NPC attacks Player
            npc1.Attack();
            player1.Damage(15); // Assume Player takes 15 damage

            // Display player's equipment
            Console.WriteLine($"{player1.Name} has {player1.Equipment.Count} equipment(s).");


            Console.ReadLine();

            // You can extend and modify these classes and methods according to your game logic.
        }
    }
}
