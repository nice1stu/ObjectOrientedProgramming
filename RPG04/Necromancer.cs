public class Necromancer : Unit
{
    bool hasResurrected = false;
    
    public Necromancer(string name, int maxHealth) : base(name, maxHealth){}
    public override void Damage(int value)
    {
        Health -= value;
    }
}