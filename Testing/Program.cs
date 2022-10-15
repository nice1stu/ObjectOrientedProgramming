static void Main(string[] args)
{
    Animal[] animals = { new Animal(), new Dog(), new Cat() };
    foreach (Animal animal in animals)
    {
        animal.MakeSound();
    }
}

{
    Main(new string[] { });
}