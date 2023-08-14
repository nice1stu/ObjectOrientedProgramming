namespace RPG;

public class Unit : IHand
{
    private int _id;
    private static int _nextId;
    private int _health;
    protected int MaxHealth;
    
    public int Id // Public property for accessing the private _id field
    {
        get => _id;
    }

    public int Health
    {
        get => _health;
        set => _health = Math.Clamp(value, 0, MaxHealth);
    }

    public IWeapon Weapon  //We will use it to keep track of what Weapon is currently equipped to this Hand
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
        
        // Call EquipTo on the weapon argument, passing a reference to the Unit itself (this)
        weapon.EquipTo(this);
    }
    
    public virtual void Attack(Unit target)
    {
        if (target.Weapon is MindControl)
        {
            target.Weapon.Attack(this, this); // Use the MindControl weapon's Attack method on the target
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