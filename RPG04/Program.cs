/*Create a Console Project named RPG
Create a class named Unit
Add a field to the Class of type string named name
Add a Contructor to the Class
The Contructor requires an argument of type string named name
Assign the value of name to the field name (use this. to reference the field)
Add a field of type int named id to the Class
Add a static field of type int named nextId to the Class
static fields are shared acros all Class instances
In the Constructor, assign the vaalue of nextId to the field id of the class
After that, increase nextId by 1
this ensures, that the next unit gets a higher id than the previous one
Add a method named ReportStatus to the Class
It reports the unit's status to the User by printing:
Unit #2: Zombie
where 2 needs to be replaced by the unit's id
and Zombie needs to be replaced by the unit's name
Create three instances of a Unit with names of your choice
Call ReportStatus at the end of the Constructor!
Make sure, that this Method call stays at the bottom of the constructor at all times!
I think it's best to put a comment there right away: // Make sure, that this is the last line of the constructor:

Continue working on the Project RPG
Add a Finalizer to the Unit Class
Make it say print Unit #2: Zombie got finalized." to the Console.
You can quickly test it using following code sample:*/

string[] enemyNames = new[] { "Zombie", "Skeleton", "Necromancer", "LivingHand", "Leet" };
int[] maxHealthTable = new[] { 100, 200, 300, 400, 1337 };

Unit unit = new Unit(enemyNames[4], maxHealthTable[4]);
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("What do you want Leet's Health to be?");
    int newHealth = Convert.ToInt32(Console.ReadLine());
    unit.SetHealth();
    unit.ReportStatus();
}

/*Testing Finalizer
for(int i = 0; i < 2; i++)
{
    Unit unit = new Unit("LivingHand");
    GC.Collect();
}*/

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

    public int SetHealth()
    {
        int newHealth = 0;
        health = newHealth;
        health = Math.Clamp(0, health, maxHealth);
        return health;
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
