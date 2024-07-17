// Inheritance

/*
>>>> Inheritance.
        Inheritance is one of the primary pillarys of the OOP.
        It allows code reuse.
        Code reuse can reduce time and errors.
>>>> Inheritance in Csharp.
        C# supports only  single class inheritance.
            A class can only have a single parent.
        C# support multi level inheritance.
        C# supports multiple interface inheritance.
        Child class is a specialization of base class.
        Base classes are automatically instantiated before derived classes.
        Parent class constructor executes before child class constructor.
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
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine("{0} {1}", FirstName, LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Sam";
        FTE.LastName = "John";
        FTE.YearlySalary = 500000;
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Abraham";
        PTE.LastName = "Monald";
        PTE.HourlyRate = 500;
        PTE.PrintFullName();


        ChildClass CC = new ChildClass();
    }
}


public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor called.");
    }

    public ParentClass(string message)
    {
        Console.WriteLine(message);
    }
}

// Calling the constructor with parameter in the parent class.
// Using the base keyword.
public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived class controlling parent class.")
    {
        Console.WriteLine("ChildClass Constructor called.");
    }

}
