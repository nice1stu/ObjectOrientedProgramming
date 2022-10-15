public class Dog : Animal
{
    public Dog(int age)
    {
        Age = age;
    }
    public void Bark()
    {
        Console.WriteLine($"I am {Age} years old, but I can bark!");
    }
}