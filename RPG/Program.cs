﻿//Create a Console Project named RPG
// Make sure, that this is the last line of the constructor:

Unit[] units = new Unit[5];

units[0] = new Unit("Zombie", int maxHealth);
units[1] = new Unit("Skeleton", int maxHealth);
units[2] = new Unit("Necromancer", int maxHealth);
units[3] = new Unit("LivingHand", int maxHealth);

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
    public static int health;
    public static int maxHealth;
    public Unit(string name, int maxHealth)
    {
        this.name = name;
        id = nextId;
        nextId++;
        health = (int)maxHealth;
    }

    public int SetHealth()
    {
        int newHealth;
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