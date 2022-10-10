// Lets try the RPG

Unit unit = new Unit("Skeleton", 100);
unit = new Unit("Zombie", 200);
unit = new Unit("Necromancer",300);

do
{
    unit = new Unit("Leet",1337);
    Console.WriteLine("What do you want Leet's Health to be?");
    unit.Health = Convert.ToInt32(Console.ReadLine());
}
while (unit.isAlive) ;

public class Unit
{
    public int iD;
    public int nextId;
    private int maxHealth;
    public static int health;

    public string Name { get; }

    public int Health
    {
        set => health = Math.Clamp(value, 0, maxHealth);
    }

    public bool isAlive
    {
        get { return isAlive; }
        set
        {
            if (health <= 0)
            {
                isAlive = false;
            }
            isAlive = true;
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