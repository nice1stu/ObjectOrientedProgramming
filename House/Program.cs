House myHouse = new House(); //Create an Instance of class House and assign it to variable myHouse.
myHouse.Print(); //Call Print on myHouse.
myHouse.color = "Red";//Assign "Red" to the field color of variable myHouse.
myHouse.number = 100;//Assign 100 to the field number of variable myHouse.
myHouse.Print();//Call Print on myHouse
House yourHouse = new House();//Create an Instance of class House and assign it to variable yourHouse.
Console.WriteLine("What color would you like your house?"); //Print "What color would you like your house?"
yourHouse.color = Console.ReadLine();//Assign the Input of the User to the field color of variable yourHouse.
Console.WriteLine("What number do you like your house to have?");//Print "What number do you like your house to have?"
yourHouse.number = Convert.ToInt32(Console.ReadLine());//Assign the Input of the user to the field number of variable yourHouse.
yourHouse.Print();//Call Print on yourHouse
if (myHouse.color == yourHouse.color)//If both houses have the same color, print "Our houses have the same Color!"
{
    Console.WriteLine("Our houses have the same Color!");
}
if (myHouse.number == yourHouse.number)//If both houses have the same number, print "Our houses have the same Number!"
{
    Console.WriteLine("Our houses have the same Number!");
}

public class House //Create a class named House
{
    public string color;//Give it a Field of type String named Color
    public int number;//Give it a Field of type int named number

    public void Print()//Give it a Method named Print
    {
        Console.WriteLine($"This is a {color} House with number {number}.");//When Called, it should print "This is a {color} House with number {number}.";
    }
}



