public class Unit
{
    private int id;
    private static int nextId;
    private int health;
    protected int maxHealth;

    public int Health
    {
        get => health;
        set => health = Math.Clamp(value, 0, maxHealth);
    }

    public Weapon Weapon { get; }
    public string Name { get; }
    
    public bool IsDead => health <= 0;

    public Unit(string name, int maxHealth, Weapon weapon)
    {
        this.Name = name;
        this.maxHealth = maxHealth;
        this.Weapon = weapon;
        health = maxHealth;
        id = nextId++;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"A {Name} has spawned");
        Console.ResetColor();
    }
    
    public virtual void Attack(Unit target)
    {
        TakeDamage(target.Weapon.Power, target);
    }
    
    public virtual void TakeDamage(int value, Unit opponent)
    {
        Health -= value;
        Console.WriteLine($"The {this.Name} has taken {value} points of Damage from {opponent.Name}");
    }

    // Make sure, that this is the last line of the constructor:
    public virtual void ReportStatus()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
        Console.ResetColor();
    }
    
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{id}: {Name} got finalized.");
    }
}