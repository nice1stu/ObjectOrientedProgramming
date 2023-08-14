namespace RPG;

public class Skeleton : Unit
{
    private int _bonusDamage = 10;
    public Skeleton(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }
    
    public override void TakeDamage(int value, Unit opponent)
    {
        Health -= (value + _bonusDamage);
        Console.WriteLine($"The {this.Name} has taken {value + _bonusDamage} points of Damage from {opponent.Name}");
    }
}