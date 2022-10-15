public class Chicken: Terrestrial
{
    public Chicken(int age)
    {
        Age = age;
    }
    public void Fly()
    {
        Console.WriteLine($"{this} age {Age} flies.");
    }
}