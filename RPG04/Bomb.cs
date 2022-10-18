/*The Bomb inherits from Unit, has 500 Health, the name Bomb and this Special Ability:
It explodes after 5 Rounds
When exploding, the Bomb's Health is set to 0
Print Unit #3: Bomb has exploded!
Add these three new monsters to your SpawnNewUnit-Method
extend the Random Number to give results between 0 and 2
And map each of these numbers to a Unit that is then created*/

public class Bomb:Unit
{
    internal static string name = "Bomb";
    internal static int maxHealth = 500;
    //internal static int power = 0;
    internal static Weapon weapon = new Weapon(66, "Training Sword");
    private int count2Five;

    public Bomb(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon)
    {}
    public override void TakeDamage(int value)
    {
        if (count2Five == 4)
        {
            Health = 0;
            Console.WriteLine("*** BOOM! *** Bomb has exploded");
        }
        Health -= value;
        count2Five++;
    }
}