Dog dog = new Dog(5);
Fish fish = new Fish(2);
Parrot parrot = new Parrot(7);
Chicken chicken = new Chicken(3);

dog.Breathes();
dog.Walks();
dog.Swims();

fish.Breathes();
fish.Swim();
Console.WriteLine(fish.Age);

parrot.Breathes();
parrot.Fly();
parrot.Walks();

chicken.Breathes();
chicken.Fly();
chicken.Walks();