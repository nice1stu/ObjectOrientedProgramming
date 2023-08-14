/*The Skeleton inherits from Unit, has 250 Health, the name "Skeleton"
 
Make the Attack-Method on the Unit-class virtual, if you haven't done so already.
This allows us to overload this method for some Units, giving them special Attack abilities.
overload the Attack-Method on the Hero-class.
First, call the base-Attack-Method.
Then, check, if the target-Unit is a Skeleton
If it is, then Deal 10 Damage extra.
Print "The Hero deals 10 extra Damage against the Skeleton's weak Bones!"*/

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