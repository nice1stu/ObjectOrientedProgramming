public class Dog : Terrestrial
{
    public Dog(int age)
    {
        Age = age;
    }
    public void Swims()
    {
        Console.WriteLine($"{this} age {Age} swims.");
    }
}