//Create a Console Project named P1ObjectOrientedProgramming


string [] names = new String[3];
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Please enter a name");
    string userInput = Console.ReadLine();
    names[i] = userInput;
}

for (int i = 0; i < names.Length; i++)
{
    Console.Write(names[i]);
    if (i < names.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
