namespace RPG;

public class Unit : IHand
{
    private int _id;
    private static int _nextId;
    private int _health;
    protected int MaxHealth;
    
    public int Id
    {
        get => _id;
    }

    public int Health
    {
        get => _health;
        set => _health = Math.Clamp(value, 0, MaxHealth);
    }

    public IWeapon Weapon
    {
        get;
        set;
    }

    public string Name { get; }
    
    public bool IsDead => _health <= 0;

    public Unit(string name, int maxHealth, IWeapon weapon)
    {
        this.Name = name;
        this.MaxHealth = maxHealth;
        this.Weapon = weapon;
        _health = maxHealth;
        _id = _nextId++;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"A {Name} has spawned");
        Console.ResetColor();
        
        weapon.EquipTo(this);
    }
    
    public virtual void Attack(Unit target)
    {
        if (Weapon is MindControl)
        {
            target.TakeDamage(0, this); // janky fix to make it so mind control weapon equipped class take no damage
        }
        else
        {
            TakeDamage(target.Weapon.Power, target);
        }
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
        Console.WriteLine($"Unit #{_id}: {Name} - {_health}/{MaxHealth} Health");
        Console.ResetColor();
    }
    
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{_id}: {Name} got finalized.");
    }
}