Unit unit;

for (int i = 0; i < 4; i++)
{
    unit = new Unit(name: "LivingHand", i, 100);
    unit.ReportStatus();
}

unit = new Unit("Leet", Unit.NextId, 1337);
unit.ReportStatus();

while (unit.Health > 0)
{
    Console.WriteLine("How much damage do you want to deal to Leet??");
    string? userInput = Console.ReadLine();
    if (userInput != null)
    {
        int damageDone = int.Parse(userInput);
        unit.Damage(damageDone);
    }
    unit.ReportStatus();
}

class Unit
{
    private readonly int _id;
    private readonly int _maxHealth;
    private int _health;
    public static int NextId { get; private set; }

    public Unit(string name, int id, int maxHealth)
    {
        this.Name = name;
        this._maxHealth = maxHealth;
        _health = maxHealth;
        _id = id;
        NextId++;
    }

    private string Name { get; }

    protected internal int Health
    {
        get => _health;
        private set
        {
            _health = Math.Min(Math.Max(0, value), _maxHealth);
            if (!IsAlive)
            {
                _health = 0;
            }
        }
    }

    public virtual void Damage(int value)
    {
        Health -= value;
    }
    bool IsAlive
    {
        get
        {
            return _health > 0;
        }
    }

    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{_id}: {Name} - {Health}/{_maxHealth} Health" );
    }
    
    ~Unit()
    {
        Console.WriteLine($"Unit #{_id}: {Name} got finalized");
    }
    // Make sure, that this is the last line of the constructor:
}

class Necromancer : Unit
{
    bool hasResurrected = false;
    public Necromancer(string name, int id, int maxHealth) : base(name, id, maxHealth) {}
    public override void Damage(int value)
    {
        
    }
}