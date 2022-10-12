namespace RPG03;

public class Unit
{
    public int iD;
    public int nextId;
    private int maxHealth;
    public static int health;

    public string Name { get; }

    public int Health
    {
        get => health;
        set => health = Math.Clamp(value, 0, maxHealth);
    }

    public bool IsAlive
    {
        get        
        {
            if (Health > 0)
            {
                return true;
            }
            return false;
        }
    }

    public Unit(string Name, int maxHealth)
    {
        this.Name = Name;
        this.maxHealth = maxHealth;
        iD = nextId;
        nextId++;
        ReportStatus();// Make sure, that this is the last line of the constructor:

    }
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{iD}: {Name} - {health}/{maxHealth} Health");
    }
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{iD}: {Name} got finalized.");
    }
}