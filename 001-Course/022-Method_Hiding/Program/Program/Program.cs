// Method Hiding

/*
>>>> Inheritance Concept.
        Use the new keyword to hide a base class member. You will get a compiler warning if you miss the new keyword.
>>>> Different ways to invoke a hidden base class member from derived class.
        1. Use base keyword.
        2. Cast child type to parenttype and invoke the hidden member.
        3. A parent class reference variable can point to a child class object.
            ParentClass PC = new ChildClass()
            PC.HiddenMethod();
>>>>
>>>>
>>>>
>>>>
*/

using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee 
{
    // Calling the method in the parent class.
    public new void PrintFullName()
    {
        base.PrintFullName();
    }
}

public class PartTimeEmployee : Employee
{
    // This method hide the method in the parent class.
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}
class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Sam";
        FTE.LastName = "John";
        FTE.PrintFullName();

        PartTimeEmployee PTE1 = new PartTimeEmployee();
        PTE1.FirstName = "Vladamir";
        PTE1.LastName = "Putin";
        PTE1.PrintFullName();

        // Calling the method in the parent class using the type cast operator.
        ((Employee)PTE1).PrintFullName();

        // Calling the method in the parent class using the parent class reference variable.
        Employee PTE2 = new PartTimeEmployee();
        PTE2.FirstName = "Abraham";
        PTE2.LastName = "Lincoln";
        PTE2.PrintFullName();
    }
}
