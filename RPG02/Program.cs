// Lets try the RPG

//Unit unit = new Unit("Skeleton", 100);
//unit = new Unit("Zombie", 200);
//unit = new Unit("Necromancer",300);
/*Unit unit = new Unit("Leet",1337);
Console.WriteLine("What do you want Leet's Health to be?");
unit.Health = Convert.ToInt32(Console.ReadLine());
unit.ReportStatus();*/

do
{
Unit unit = new Unit("Leet",1337);
Console.WriteLine("What do you want Leet's Health to be?");
unit.Health = Convert.ToInt32(Console.ReadLine());
unit.ReportStatus();
}
while (Unit.health > 0) ;

/*Testing Finalizer
for(int i = 0; i < 2; i++)
{
    unit = new Unit("LivingHand",400);
    GC.Collect();
}*/
public class Unit
{
    private string name;
    public int iD;
    public int nextId;
    private int maxHealth;
    public static int health;
    public int Health
    {
        get 
        {
            return health;
        }
        set
        {
            health = Math.Clamp(value, 0, maxHealth);
        }
    }
    public Unit(string name, int maxHealth)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        iD = nextId;
        nextId++;
        //ReportStatus();// Make sure, that this is the last line of the constructor:
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

