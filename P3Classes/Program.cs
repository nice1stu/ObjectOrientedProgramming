/*//Create a Console Project named P3Classes
Extend the class Person:
Give it a field of type string with the name name
Give it a method named IntroduceYourself()
The method should print "Hello, my name is " and the name of the Person to the console
Create an Array of three Person, name it persons
Ask the user for three names.
Use a for-loop, to do so.
Put each name into one slot of the Person-Array's name
Now, call IntroduceYourself() on each person of the Array*/

//Create a Console Project named P2Classes

/*Person person = new Person();
Animal animal = new Animal();
Car car = new Car();

Console.WriteLine(person);
Console.WriteLine(animal);
Console.WriteLine(car);*/



Person[] persons = new Person[3];

for (int i = 0; i < persons.Length; i++)
{
    persons[i] = new Person();
}

for (int i = 0; i < persons.Length; i++)
{
    Console.WriteLine("Give me a name ");
    persons[i].name = Console.ReadLine();
}

for (int i = 0; i < persons.Length; i++)
{
    persons[i].IntroduceYourself();
}
public class Person
{
    public string name;
    public void IntroduceYourself()
    {
        Console.WriteLine($"Hello, my name is {name}");
    }
}

public class Animal
{ }


public class Car
{ }

