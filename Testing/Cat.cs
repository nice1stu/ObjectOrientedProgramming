public class Cat : Animal
{
    public override string FavouriteFood => "Mice";
    public void HuntMice(){}
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}