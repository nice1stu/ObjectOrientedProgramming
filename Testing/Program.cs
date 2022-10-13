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

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            Console.WriteLine("Error");
            return;
        }

        name = value;
        Console.WriteLine($"You have successfully changed name to : {name}");
    }
}