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

string[] enemyUnits = new String[4];
for (int i = 0; i < enemyUnits.Length; i++)
{
    Unit unit = new Unit(enemyUnits[i]);
    //Unit.ReportStatus();
}

class Unit
{
    private string name;
    private int id;
    private static int nextId;

    public Unit(string name)
    {
        this.name = name;
        id = nextId;
        nextId++;
    }

    //Finalizer
    ~Unit()
    {
        for (int i = 0; i < 2; i++)
        {
            Unit unit = new Unit("LivingHand");
            GC.Collect();
            Console.WriteLine("LivingHand got finalized.");
            Thread.Sleep(1000);
        }

        // Make sure, that this is the last line of the constructor:
        /*void ReportStatus()
        {
            Console.WriteLine($"Unit #{id}: {name}");
        }*/
    }
}