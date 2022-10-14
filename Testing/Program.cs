Person person = new Person();
person.SetName("Hans");
Console.WriteLine(person.GetName());
person.Promote();
Console.WriteLine(person.GetName());
person.SetName("Will");
Console.WriteLine(person.GetName());


public class Person
{
    private string name;
    private bool isPromoted;

    public string GetName()
    {
        if (isPromoted)
        {
            return "Officer " + name;
        }
        return name;
    }

    public void SetName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            Console.WriteLine("Error. Can not assign an invalid name to Person.");
            return;
        }

        name = value;
        Console.WriteLine($"You have successfully changed name to : {value}");
    }

    public void Promote()
    {
        isPromoted = true;
        Console.WriteLine($"Promoted {name}.");
    }
}