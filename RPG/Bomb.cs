public class Bomb : Unit
{
    private int count2Five;

    public Bomb(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) {}
    public override void TakeDamage(int value, Unit opponent)
    {
        base.TakeDamage(value, opponent);
        
        if (count2Five >= 4)
        {
            Health = 0;
            Console.WriteLine("*** BOOM! *** Bomb has exploded");
            opponent.TakeDamage(500, this);
            return;
        }
        
        count2Five++;
    }
}