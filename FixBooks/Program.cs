/*Output:What title does book 1 have?
Input:Star Wars
Output:What title does book 1 have?
Input: Lord of the Rings
Output:What title does book 1 have?
Input: Harry Potter
Output:What title does book 1 have?
Input: Pirates of the Caribbean
Output:What title does book 1 have?
Input: Game of Thrones
Output:Thank you for your Input!
Output:Star Wars-Lord of the Rings-Harry Potter-Pirates of the Caribbean-Game of Thrones-End*/

Book[] books = new Book[5];

for (int i = 0; i < books.Length; i++)
{
   books[i] = new Book();
}

for(int i = 0; i < 5; i++)
{
   Console.WriteLine($"What title does book {i+1} have?");
   books[i].title = Console.ReadLine();
}
Console.WriteLine("Thank you for your input!");
for(int i = 0; i < 5; i++)
{
   Console.Write(books[i].title+"-");
}
Console.Write("End");

public class Book
{
   public string title;
}
