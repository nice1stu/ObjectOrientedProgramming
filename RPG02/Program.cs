// Lets try the RPG again

/* Testing
Unit woofs = new Unit("Woofs");
Unit bello = new Unit("Bello");
Console.WriteLine(woofs.name);
Console.WriteLine(bello.name);*/

string[] units = new string[3];
for (int i = 0; i < units.Length; i++)
{
    Console.WriteLine("Please name your unit");
    string userInput = Console.ReadLine();
    units[i] = userInput;
}
/* Testing
 Console.WriteLine(units[0]);
Console.WriteLine(units[1]);
Console.WriteLine(units[2]);*/

public class Unit
{
    public string name;
    public int iD;
    public static int nextId;
    public Unit(string name)
    {
        this.name = name;
        this.iD = nextId;
        nextId++;
    }
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{iD}: {name}");
    }
}
