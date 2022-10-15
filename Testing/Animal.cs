public class Animal
{
    public int Age { get; set; }

    public Animal()
    {
        Console.WriteLine("Animal gets constructed");
    }

    public void Breathes()
    {
        Console.WriteLine($"I am breathing");
    }
}