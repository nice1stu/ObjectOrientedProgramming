Unit unit;
for (int i = 0; i < 4; i++)
{
    unit = new Unit(name: "LivingHand", i, 100);
    unit.ReportStatus();
}

unit = new Unit("Leet", Unit.NextId, 1337);
unit.ReportStatus();

while (unit.SetHealth > 0)
{
    Console.WriteLine("What do you want Leet's Health to be?");
    string? userInput = Console.ReadLine();
    if (userInput != null)
    {
        int leetHealth = int.Parse(userInput);
        unit.SetHealth = leetHealth;
    }
    unit.ReportStatus();
}

/*for(int i = 0; i < 2; i++)
{
    Unit unit = new Unit("LivingHand", i);
    GC.Collect();
}*/

class Unit
{
    private string _name;
    private int _id;
    private int _maxHealth;
    private int _health;
    public static int NextId { get; set; }

    public Unit(string name, int id, int _maxHealth)
    {
        this._name = name;
        this._maxHealth = _maxHealth;
        _health = _maxHealth;
        _id = id;
        NextId++;
    }

    public int SetHealth
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            if (_health <= 0 || _health > _maxHealth)
            {
                _health = Math.Min(Math.Max(0, value), _maxHealth);
            }
        }
    }
    
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{_id}: {_name} - {_health}/{_maxHealth} Health" );
    }
    
    ~Unit()
    {
        Console.WriteLine($"Unit #{_id}: {_name} got finalized");
    }
    // Make sure, that this is the last line of the constructor:
}