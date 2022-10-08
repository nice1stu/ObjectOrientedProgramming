// Lets try the RPG

Unit unit = new Unit("Skeleton", 100);
unit = new Unit("Zombie", 200);
unit = new Unit("Necromancer",300);

/*Testing Finalizer
for(int i = 0; i < 2; i++)
{
    unit = new Unit("LivingHand",400);
    GC.Collect();
}*/

for(int i = 0; i < 3; i++)
{
    new Unit("Leet",1337);
}
public class Unit
{
    private string name;
    public int iD;
    public static int nextId;
    private int maxHealth;
    private int health;
    public Unit(string name, int maxHealth)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        SetHealth(health);
        iD = nextId;
        nextId++;
        ReportStatus();// Make sure, that this is the last line of the constructor:
    }
    public int SetHealth(int newHealth)
    {
        Console.WriteLine("What do you want Leet's Health to be?");
        newHealth = Convert.ToInt32(Console.ReadLine());
        health = newHealth;
        health = Math.Clamp(health, 0, maxHealth);
        return health;
    }
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{iD}: {name} - {health}/{maxHealth} Health");
    }
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{iD}: {name} got finalized.");
    }
}