public class Unit
{
    private int id;
    private static int nextId;
    private int health;
    protected int maxHealth;

    public virtual void Damage(int value)
    {
        Health -= value;
    }
    public bool IsAlive
    {
        get
        {
            if (health > 0)
            {
                return true;
            }

            return false;
        }
    }

    public string Name { get; }

    public Unit(string name, int maxHealth)
    {
        this.Name = name;
        this.maxHealth = maxHealth;
        health = maxHealth;
        id = nextId;
        nextId++;
    }

    protected internal int Health
    {
        set
        {
            health = value;
            health = Math.Clamp(health, 0, maxHealth);
        }
        get { return health; }
    }
    
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{id}: {Name} got finalized.");
    }

    // Make sure, that this is the last line of the constructor:
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");//Unit #27: Zombie - 127/200 Health
    }
}