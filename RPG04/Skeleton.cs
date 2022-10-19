/*The Skeleton inherits from Unit, has 250 Health, the name "Skeleton"*/

public class Skeleton : Unit
{
    internal static string name = "Skeleton";
    internal static int maxHealth = 250;
    //internal static int power = 46;
    public static Weapon weapon { get; }
    public Skeleton(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon)
    {
        BoneSword boneSword = new BoneSword();
    }
}