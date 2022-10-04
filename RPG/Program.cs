//Create a Console Project named RPG
// Make sure, that this is the last line of the constructor:

Unit[] units = new Unit[5];

units[0] = new Unit("Zombie", 3000);
units[1] = new Unit("Skeleton", 2000);
units[2] = new Unit("Necromancer", 2000);
units[3] = new Unit("Leet", 1337);

for (int i = 0; i < Unit.nextId; i++)
{
    units[i].ReportStatus();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"What do you want {units[3]} Health to be?");
    int userInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{units[3]} - {health}/{maxHealth} Health");
}

/*Output:Unit #3: Leet - 1337/1337 Health
Output:What do you want Leet's Health to be?
Input:1234
Output:Unit #3: Leet - 1234/1337 Health
Output:What do you want Leet's Health to be?
Input:-100
Output:Unit #3: Leet - 0/1337 Health
Output:What do you want Leet's Health to be?
Input:2000
Output:Unit #3: Leet - 1337/1337 Health*/
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
    public Unit(string name, int maxHealth)
    {
        this.name = name;
        id = nextId;
        nextId++;
        this.maxHealth = maxHealth;
        health = this.maxHealth;
    }

    public int SetHealth()
    {
        int newHealth = 0;
        if (newHealth <=0)
        {
            return 0;
        }
        else if (newHealth > maxHealth )
        {
            newHealth = maxHealth;
        }

        {
            newHealth = maxHealth;
        }
        health = newHealth;
        return health;
    }
    /*Modify ReportStatus, to show not only the Id and Name, but also Health and MaxHealth:
Unit #27: Zombie - 127/200 Health
27 is the id
Zombie is the name
127 is the health
200 is the maxHealth*/
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name}");
        Console.WriteLine($"{id} is the ID");
        Console.WriteLine($"{name} is the Name");
        Console.WriteLine($"{health} is the Health");
        Console.WriteLine($"{maxHealth} is the Maximum Health");
    }
    
    //Add a Finalizer to the Unit Class
    //Make it say print Unit #2: Zombie got finalized." to the Console.
    ~Unit()
    {
        Console.WriteLine($"Unit #{id}: {name} got finalized.");
    }
}
