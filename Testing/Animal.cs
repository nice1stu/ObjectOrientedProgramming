public class Animal
{
    public int Age { get; set; }

    public void Breathes()
    {
        Console.WriteLine($"{this} age {Age} breathes.");
    }
}