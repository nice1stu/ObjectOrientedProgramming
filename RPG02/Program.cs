// Lets try the RPG

/*string[] units = new String[3];
for (int i = 0; i < units.Length; i++)
{
    Console.WriteLine("Please name your unit");
    string userInput = Console.ReadLine();
    units[i] = new string(userInput);
}*/

Unit unit = new Unit("Skeleton");
unit = new Unit("Zombie");
unit = new Unit("Necromancer");

//Testing Finalizer
for(int i = 0; i < 2; i++)
{
    unit = new Unit("LivingHand");
    GC.Collect();
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
        this.iD = nextId;
        nextId++;
        ReportStatus();// Make sure, that this is the last line of the constructor:
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