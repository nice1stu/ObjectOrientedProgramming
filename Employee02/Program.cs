/*Create an Employee class
Add all data as fields to the class:
each Employee's name
each Employee's salary
all Employees as an array
all Employees' tax rate
Now, add whatever functions and methods are needed to solve above exercise.*/

using System.ComponentModel;
EMS();
string[] employeeName = new string[100];
int[] employeeSalary = new int[100];
int[] employeeID = new int[100];

Employee employee[employeeID] = new Employee(employeeName, employeeSalary);

void EMS()
{//menu
    Console.WriteLine("Do you want to...");
    Console.WriteLine("1: List all Employees");
    Console.WriteLine("2: Add another Employee");
    Console.WriteLine("3: Change the Tax Rate");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput == 1)
    {
        for (int i = 0; i < employee.Length; i++)
        {
            Console.WriteLine("Here is a list of all employees");
            Console.WriteLine($"Employee 1: {employee[i]}. Salary: {employee[i]} Taxes ({employeeTaxRate}%): {employeeSalary*employeeTaxRate} Salary After Taxes: {employeeSalary*(1-employeeTaxRate)});
        }
    }else if (userInput == 2)
    {
        Console.WriteLine("Add another employee");
        Console.WriteLine("Employee name:");
        string employeeName = Console.ReadLine();
        Console.WriteLine("Employee salary:");
        int employeeSalary = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("What's the new Tax Rate (0.1 = 10%)?");
    double employeeTaxRate = Convert.ToDouble(Console.ReadLine());

}

public class Employee
{
    public string employeeName;
    public int employeeSalary;
    public static double emplooyeeTaxRate;
    int employeeID = 0;

    public AddEmployee(string employeeName, int employeeSalary)
    {
        int nextID;
        this.employeeName = employeeName;
        this.employeeSalary = employeeSalary;
        nextID++;
        employeeID = nextID;
    }
}