/*Create an Employee class
Add all data as fields to the class:
each Employee's name
each Employee's salary
all Employees as an array
all Employees' tax rate
Now, add whatever functions and methods are needed to solve above exercise.*/

using System.ComponentModel;
EMS();
string[] employee = new string[100];

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
    }

}

public class Employee
{
    public string employeeName;
    public int employeeSalary;
    public static float emplooyeeTaxRate;

    public Employee(string employeeName, int employeeSalary)
    {
        
    }
}