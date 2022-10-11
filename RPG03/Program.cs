// Lets try the RPG

Unit unit = new Unit("Skeleton", 100);
unit = new Unit("Zombie", 200);
unit = new Unit("Necromancer",300);
unit = new Unit("Leet", 1337);
int value = 0;

void Damage()
{
    unit.Health -= value;
}

do
{
    Console.WriteLine("How much damage do you want to deal to Leet?");
    string userInput = Console.ReadLine();
    value = Convert.ToInt32(userInput);
    Damage();
} while (unit.IsAlive);

public class Unit
{
    public int iD;
    public int nextId;
    private int maxHealth;
    private static int health;

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