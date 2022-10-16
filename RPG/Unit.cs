/*Rename the Damage-Method to TakeDamage.
Methods should always describe an Action (something that can be done)
And Damage can either be a Verb (to damage) or a Noun (the damage)
TakeDamage more specifically describes, what the method does

Introduce a new Property IsDead of type bool to the Unit
Have it return true, if the Unit is not IsAlive and false, if the unit IsAlive*/

public class Unit
{
    private int id;
    private static int nextId;
    private int health;
    protected int maxHealth;

    public virtual void TakeDamage(int value)
    {
        Health -= value;
    }
    public bool IsAlive
    {
        get
        {
            if (health > 0)
            {
                return true;
            }
            return false;
        }
    }

    public bool IsDead
    {
        get
        {
            if (health <= 0)
            {
                return true;
            }
            return false;
        }
    }
    public string Name { get; }

    public Unit(string name, int maxHealth)
    {
        this.Name = name;
        this.maxHealth = maxHealth;
        health = maxHealth;
        id = nextId;
        nextId++;
    }

    protected internal int Health
    {
        set
        {
            health = value;
            health = Math.Clamp(health, 0, maxHealth);
        }
        get { return health; }
    }
    
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{id}: {Name} got finalized.");
    }

    // Make sure, that this is the last line of the constructor:
    public void ReportStatus()
    {
        //Console.WriteLine($"Hero - {hero.Health}/{Hero.maxHealth} Health");
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
    }
}