public class Dog : Animal
{
    public override string FavouriteFood => "Bones";
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
    public void GuardHouse(){}
}