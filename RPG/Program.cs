//Create a Console Project named RPG
// Make sure, that this is the last line of the constructor:

Unit[] units = new Unit[5];

units[0] = new Unit("Zombie");
units[1] = new Unit("Skeleton");
units[2] = new Unit("Necromancer");
units[3] = new Unit("LivingHand");

for (int i = 0; i < Unit.nextId; i++)
{
    units[i].ReportStatus();
}

//Finalizer
/*for(int i = 0; i < 2; i++){
    Unit unit = new Unit("LivingHand");
    GC.Collect();
}*/
public class Unit
{
    public string name;
    public int id;
    public static int nextId;
    private int health;
    private int maxHealth;
    public Unit(string name)
    {
        this.name = name;
        id = nextId;
        nextId++;
    }
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name}");
    }
    //Add a Finalizer to the Unit Class
    //Make it say print Unit #2: Zombie got finalized." to the Console.
    ~Unit()
    {
        Console.WriteLine($"Unit #{id}: {name} got finalized.");
    }
}
