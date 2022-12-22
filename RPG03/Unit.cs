class Unit
{
    // fields
    public string name;
    public int id;
    public static int nextId = 1;

    // constructor
    public Unit(string name)
    {
        this.name = name;
        this.id = nextId;
        nextId++;

        // Make sure, that this is the last line of the constructor:
        ReportStatus();
    }

    // method
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name}");
    }
}
