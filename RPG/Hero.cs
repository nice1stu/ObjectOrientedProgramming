public class Hero : Unit
{
    public Hero(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }

    public override void ReportStatus()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Hero - {Health}/{maxHealth} Health");
        Console.ResetColor();
    }
}