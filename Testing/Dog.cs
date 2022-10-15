public class Dog : Animal
{
    // Additionally, we define a Bark()-Method
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}