// Abstract Classes

/*
>>>> Abstract classes.
        The abstract keyword is used to create abstract classes.
        
        An abstract class is incomplete and hence cannot be instantiated.

        An abstract class can only be used as base class.
        An abstract class cannot be sealed.
        An abstract class may contain members (Methods, Properties, Indexers, and Events), but not mandatory.
        A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members.
>>>> If a class inherits an abstract class, there are 2 options available for that class.
        Option 1:
            Provide implementation for all the abstract members inherited from the base abstract class.
        Option 2:
            If the class does not wish to provide Implementation for all the abstract members inherited from the abstract class, then the class has to be marked as abstract.
>>>>
>>>>
>>>>
>>>>
*/

using System;

public abstract class Customer
{
    public abstract void Print();
}
class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print Method");
    }
    static void Main()
    {
        Program P = new Program();
        P.Print();

        // OR

        Customer C = new Program();
        C.Print();
    }
}
