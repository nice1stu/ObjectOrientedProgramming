//Create a Console Project named P1ObjectOrientedProgramming
/*Create a Console Project named P1ObjectOrientedProgramming
Small exercise for warm-up:
Create an array of three strings, named names
Ask the user for three names.
Use a for-loop, to do so.
Put each name into one slot of the Array.
Now, print all three names to the console.
In one line.
Separated by comma.*/

string[] names = new string[3];

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Please enter a name.");
    names[i] = Console.ReadLine();
}

Console.WriteLine(names[0]+", "+names[1]+", "+names[2]);