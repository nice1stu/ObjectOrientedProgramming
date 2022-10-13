{
    Main(new string[] { });
}

static void Main(string[] args)
{
    for (var i = 0; i < 5; i++)
    {
        var animal = new Animal();
        GC.Collect();
        Thread.Sleep(1000);
    }
}

public class Animal
{
    public Animal()
    {
        Console.WriteLine("animal is created");
    }

    ~Animal()
    {
        Console.WriteLine("animal is destroyed");
    }
}