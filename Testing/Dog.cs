public class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog gets constructed");
    }
    public void Bark()
    {
        Console.WriteLine($"I am {Age} years old, but I can bark!");
    }
}