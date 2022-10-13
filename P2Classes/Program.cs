/*Create a Console Project named P2Classes
Create 3 Classes:
Person
Animal
Car
For each of these classes:
Create one instance (object) of the class and assign each to a variable
Use Console.WriteLine and pass that instance (object) into the method*/

Person a = new Person();
Animal b = new Animal();
Car c = new Car();

public class Person
{
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