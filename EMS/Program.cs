/*Create an Employee class
Add all data as fields to the class:
each Employee's name
each Employee's salary
all Employees as an array
all Employees' tax rate
Now, add whatever functions and methods are needed to solve above exercise.*/

using System.Threading.Channels;

int nextId = 0;

Employee[] employees = new Employee[100];
for (int i = 0; i < employees.Length; i++)
{
    employees[i] = new Employee();
}
//Menu();
//void Menu()
while (true)
{
    Console.WriteLine("Employee Management System");
    Console.WriteLine("[1] Print list of all employees");
    Console.WriteLine("[2] Create a new employee");
    Console.WriteLine("[3] change tax rate of employees");
    int userInput1 = Convert.ToInt32(Console.ReadLine());
    if (userInput1 == 1)
    {
        for (int i = 0; i < nextId; i++)
        {
            Employee e = employees[i];
            Console.WriteLine($"Name: {employees[i].name}, Salary: {employees[i].salary}, Tax Rate: {(Employee.taxRate)*100}%, Tax Paid: {(employees[i].salary * (Employee.taxRate))}, Net Salary: {(employees[i].salary * (1-Employee.taxRate))}");
        }
        //Iterate over Employees
        //Print Name
        //Print Salary
        //Print Tax Rate (Shared)
        //Print Taxes
        //Print Salary after Taxes
    }
    else if (userInput1 == 2)
    {
        //Create a new Employee
        Console.WriteLine("What is the name of the employee file you want to create?"); //Ask for the name and assign it
        employees[nextId].name = Console.ReadLine();
        Console.WriteLine($"What is the salary of {employees[nextId].name}");//Ask for the salary and assign it
        employees[nextId].salary = Convert.ToInt32(Console.ReadLine());
        nextId++;
    }
    else if (userInput1 == 3)
    {
        //Ask for the tax rate And assign it so it changes for all employees
        Console.WriteLine("what % tax rate would you like to set?");
        string userInput2 = Console.ReadLine();
        Employee.taxRate = (Convert.ToDouble(userInput2)/100);
    }
}

public class Employee
{
    public string name;

    public int salary;

    public static double taxRate;
}
