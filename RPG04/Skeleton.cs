/*The Skeleton inherits from Unit, has 250 Health, the name "Skeleton"*/

public class Skeleton : Unit
{
    public Skeleton(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }
    
    public override void TakeDamage(int value, Unit opponent)
    {
        Health -= (value+10);
        Console.WriteLine("The Hero deals 10 extra Damage against the Skeleton's weak Bones!");
        Console.WriteLine($"The {this.Name} has taken {value+10} points of Damage from {opponent.Name}");
    }
}