namespace RPG;

public class Ghost : Unit
{
    public Ghost(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon)
    {
    }
    public override void TakeDamage(int value, Unit opponent)
    {
        Random random = new Random();
        int chance = random.Next(99);
        //Console.WriteLine(chance);
        if (chance < 55)
        {
            value = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Hero is too scared to attack!");
            Console.ResetColor();
        }
        Health -= (value);
        Console.WriteLine($"The {this.Name} has taken {value} points of Damage from {opponent.Name}");
    }
}