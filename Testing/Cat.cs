public class Cat : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Meow!");
    }
}