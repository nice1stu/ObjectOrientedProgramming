public class Necromancer : Unit
{
    bool hasResurrected = false;

    public Necromancer(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) {}
    public override void TakeDamage(int value, Unit opponent)
    {
        base.TakeDamage(value, opponent);
        HasResurrected();
    }
    
    private void HasResurrected()
    {
        if (IsDead && !hasResurrected)
        {
            Console.WriteLine("Necromancer is born again!");
            Health = (int)(maxHealth * .5);
            hasResurrected = true;
        }
    }
}