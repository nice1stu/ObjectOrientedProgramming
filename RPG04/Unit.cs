class Unit
{
    private string name;
    private int id;
    private static int nextId;
    private int health;
    private int maxHealth;

    public Unit(string name, int maxHealth)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        health = maxHealth;
        id = nextId;
        nextId++;
    }

    public int Health
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
        Console.WriteLine($"Unit #{id}: {name} got finalized.");
    }

    // Make sure, that this is the last line of the constructor:
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name} - {health}/{maxHealth} Health");//Unit #27: Zombie - 127/200 Health
    }
}