public class Hero : Unit
{
    public Hero(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }

    public override void ReportStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Hero - {Health}/{maxHealth} Health");
        Console.ResetColor();
    }
    
    public override void Attack(Unit target)
    {
        TakeDamage(target.Weapon.Power, target);
        if (target is Skeleton)
        {
            //Health -= (target.Weapon.Power+10);
            Console.WriteLine("The Hero deals 10 extra Damage against the Skeleton's weak Bones!");
        }
    }
}