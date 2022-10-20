/*The Skeleton inherits from Unit, has 250 Health, the name "Skeleton"*/

public class Skeleton : Unit
{
    private int bonusDamage = 10;
    public Skeleton(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }
    
    public override void TakeDamage(int value, Unit opponent)
    {
        Health -= (value+bonusDamage);
        Console.WriteLine("The Hero deals 10 extra Damage against the Skeleton's weak Bones!");
        Console.WriteLine($"The {this.Name} has taken {value+bonusDamage} points of Damage from {opponent.Name}");
    }
}