public class Hedgehog : Unit
{
    private int tookDamage;
    public Hedgehog(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) {}
    public override void TakeDamage(int value, Unit opponent)
    {
        if (tookDamage < 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Hedgehog in Defense Mode ***");
            tookDamage++;
            Console.ResetColor();
            return;
        }
        
        base.TakeDamage(value, opponent);
    }
}