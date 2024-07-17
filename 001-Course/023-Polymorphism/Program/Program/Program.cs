// Polymorphism

/*
>>>> Polymorphism
        It is the one of the primary pillars of the OOP.
        
        It allows you to invoke derived class methods through a base class reference during runtime.
        
        In the base class the method is declared virtual, and in the derived class we override the same method.
        The virtual keyword indicates, the method can be overrided in any derived class.
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Part Time");
    }
}
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Full Time");
    }
}
public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Temporary");
    }
}
class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach (Employee emp in employees)
        {
            emp.PrintFullName();
        }
    }
}
