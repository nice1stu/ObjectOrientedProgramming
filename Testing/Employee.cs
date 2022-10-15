public class Employee
{
    public static int TotalCount { get; set; }

    public static void Sign()
    {
        Console.WriteLine("Employee signed.");
    }

    public static void Quit()
    {
        Console.WriteLine("Employee quit.");
    }
}