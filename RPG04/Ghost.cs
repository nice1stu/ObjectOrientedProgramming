/*Add a new class inheriting from Unit named Ghost
The Ghost has 200 Health
The Ghost uses Haunt, a Weapon with 10 Damage.
Edit the Hero's Attack-Method.
Check first, whether the target-Unit is a Ghost
If it is, then do a random-roll:
With a 55% Chance, the Hero is scared and will not attack this round.
Write "The Hero is too scared to attack!"
Make sure that the Hero does not get scared by other Units!*/

public class Ghost : Unit
{
    public Ghost(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon)
    {
    }
    public override void TakeDamage(int value, Unit opponent)
    {
        Random random = new Random();
        int chance = random.Next(99);
        Console.WriteLine(chance);
        if (chance < 55)
        {
            value = 0;
            Console.WriteLine("The Hero is too scared to attack!");
        }
        Health -= (value);
        Console.WriteLine($"The {this.Name} has taken {value} points of Damage from {opponent.Name}");
    }
}