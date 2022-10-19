/*The Skeleton inherits from Unit, has 250 Health, the name "Skeleton"*/

public class Skeleton : Unit
{
    public static Weapon weapon { get; }
    public Skeleton(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon)
    {
    }
}