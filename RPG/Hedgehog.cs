public class Hedgehog : Unit
{
    private int tookDamage;
    public Hedgehog(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) {}
    public override void TakeDamage(int value, Unit opponent)
    {
        if (tookDamage < 2) //Defense Mode
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Hedgehog in Defense Mode ***");
            Console.WriteLine("The Hedgehog's Spikes are up and they hurt!");
            opponent.Health -= 5;
            tookDamage++;
            Console.ResetColor();
            return;
        }
        
        base.TakeDamage(value, opponent);
    }
}