// Lets try the RPG

using RPG03;

/*Unit unit = new Unit("Skeleton", 100);
unit = new Unit("Zombie", 200);
Necromancer necromancer01 = new Necromancer("Necromancer",200);
unit = new Unit("Leet", 1337);*/

class Program
{
    public static void Main(string[] args)
    {
        int value = 0;
        Unit unit = new Necromancer("Necromancer", 200);
        Necromancer.health = 200;
        Console.WriteLine("Necromancer" + Necromancer.health);
        
        void Damage() => unit.Health -= value;
        
        do
        {
            Console.WriteLine("How much damage do you want to deal to Necromancer?");
            string userInput = Console.ReadLine();
            value = Convert.ToInt32(userInput);
            Damage();
        } while (unit.IsAlive);
    }
}