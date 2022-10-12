namespace RPG03;
//He has a special ability: The first time he dies, he resurrects and his Health is set back to 50% of his maxHealth again!
public class Necromancer : Unit
{
    private bool hasResurrected = false;
    public Necromancer(string Name, int maxHealth) : base(Name, maxHealth)
    {
        if (IsAlive == false)
        {
            health = (int)(maxHealth * 0.5);
        }
    }
}