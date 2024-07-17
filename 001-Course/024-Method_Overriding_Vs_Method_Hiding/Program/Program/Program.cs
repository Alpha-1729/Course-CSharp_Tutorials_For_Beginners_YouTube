// Method Overriding Vs Method Hiding

/*
>>>> Method overriding vs Method hiding.
        In method overriding a base class reference variable pointing to a child class objecct, will invoke the overriden method in the Child class.
        in method hiding a base class reference variable pointing to a child class object, will invoke the hidden method in the Base class.
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;

public class MOBaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Method Overriding - Base class print method");
    }
}

public class MODerivedClass : MOBaseClass
{
    public override void Print()
    {
        Console.WriteLine("Method Overriding - Child class print method");
    }
}

public class MHBaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Method Hiding - Base class print method");
    }
}

public class MHDerivedClass : MHBaseClass
{
    public new void Print()
    {
        Console.WriteLine("Method Hiding - Child class print method");
    }
}
class Program
{
    static void Main()
    {
        // Method overriding example.
        // This will print the child class print method.
        MOBaseClass MOB = new MODerivedClass();
        MOB.Print();

        // Method hiding example 1.
        // This will print the parent class print method.
        MHBaseClass MHB = new MHDerivedClass();
        MHB.Print();

        // Method hiding example 2.
        // This will print the child print method.
        MHDerivedClass MHD = new MHDerivedClass();
        MHD.Print();
    }
}
