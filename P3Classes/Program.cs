/*Continue Working on P2Classes
Extend the class Person:
Give it a field of type string with the name name
Give it a method named IntroduceYourself()
The method should print "Hello, my name is " and the name of the Person to the console
Create an Array of three Person, name it persons
Ask the user for three names.
Use a for-loop, to do so.
Put each name into one slot of the Person-Array's name
Now, call IntroduceYourself() on each person of the Array*/

string?[] persons = new string?[3];
for (int i = 0; i < persons.Length; i++)
{
    Console.WriteLine("Please enter a name.");
    string? userInput = Console.ReadLine();
    persons[i] = userInput;
}

for (int i = 0; i < persons.Length; i++)
{
    Person.name = persons[i];
    Person.IntroduceYourself();
}

public class Person
{
    public static string? name;

    public static void IntroduceYourself()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
    public Person()
    {
        Console.WriteLine("Person");
    }
}

public class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal");
    }
}

public class Car
{
    public Car()
    {
        Console.WriteLine("Car");
    } 
}