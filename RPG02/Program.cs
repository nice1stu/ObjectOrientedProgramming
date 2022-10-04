// Lets try the RPG again

/*string[] units = new String[3];
for (int i = 0; i < units.Length; i++)
{
    Console.WriteLine("Please name your unit");
    string userInput = Console.ReadLine();
    units[i] = new string(userInput);
}*/
Unit unit = new Unit(200, "Skeleton");
unit = new Unit(200, "Zombie");
unit = new Unit(200, "Necromancer");
unit = new Unit(1337, "Leet");

/*Testing Finalizer
    for (int i = 0; i < 2; i++)
    {
        unit = new Unit(200, "LivingHand");
        GC.Collect();
    }*/

public class Unit
{
    private string name;
    public int iD;
    public static int nextId;
    private int health;
    private int maxHealth;
    
    public Unit(int maxHealth, string name)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        health = maxHealth;
        SetHealth(newHealth:health);
        this.iD = nextId;
        nextId++;
        ReportStatus();// Make sure, that this is the last line of the constructor:
    }

    public void SetHealth(int newHealth)
    {
        Console.WriteLine("What do you want Leet's Health to be?");
        newHealth = Convert.ToInt32(Console.ReadLine());
        health = Math.Max(0, newHealth);
    }
    public string GetName()
    {
        return name;
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